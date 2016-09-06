Imports System.DirectoryServices
Imports System.Globalization
Imports System.Security.Principal
Imports System.Threading

Public Class AD

    Public Shared Property currentUser As String
    Public Shared Property currentUserFullName As String
    Public Shared Property currentUserGroup As String

#Region "GetDirectoryEntry"
    'Method used to create an entry to the AD.
    'Replace the path, username, and password with the ones specific to you 
    'and your network. 
    'Hardcoding a username & password can be viewed as a security risk
    'so you may want to store this in an encrypted file.
    Private Shared Function GetDirectoryEntry(Optional ByVal usr As String = Nothing, Optional ByVal psw As String = Nothing) As DirectoryEntry
        If (usr Is Nothing And psw Is Nothing) Then
            usr = "cursorme\ecadadmin"
            psw = "ecadadmin01"
        Else
            If Not usr.Contains("\") Then
                usr = "cursorme\" & usr
            End If
        End If

        Dim dirEntry As DirectoryEntry = New DirectoryEntry()
        dirEntry.Path = "LDAP://cmad.cursorme.com:389/CN=Users;DC=cursorme,DC=com"
        dirEntry.Username = usr
        dirEntry.Password = psw
        Return dirEntry
    End Function
#End Region

#Region "TryLogin"
    ' Attempts to login
    Public Shared Function TryLogin(ByVal usr As String, Optional ByVal psw As String = Nothing) As Boolean
        Try
            If (usr Is Nothing Or
                String.Empty.Equals(usr) Or
                String.Empty.Equals(psw)) Then
                Return False
            End If

            If psw = Nothing Then
                Return LoadUserData(usr, New DirectorySearcher(GetDirectoryEntry(usr)))
            Else
                Return LoadUserData(usr, New DirectorySearcher(GetDirectoryEntry(usr, psw)))
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "LoadUserData"
    ' Loads user data to global vars
    Private Shared Function LoadUserData(ByRef usr As String, ByRef search As DirectorySearcher) As Boolean
        If usr.Contains("\") Then
            usr = usr.Split("\")(1)
        End If
        search.Filter = "(SAMAccountName=" & usr & ")"
        search.PropertiesToLoad.Add("displayName")
        Dim result As SearchResult = search.FindOne()

        If (result Is Nothing) Then
            Return False
        Else
            AD.currentUser = usr
            AD.currentUserFullName = result.Properties("displayName")(0)
            Return True
        End If
    End Function
#End Region

#Region "Logout"

    Public Shared Sub Logout()
        AD.currentUser = Nothing
        AD.currentUserFullName = Nothing
        AD.currentUserGroup = Nothing
    End Sub

#End Region

#Region "SetADProperty"
    ' Helper method that sets properties for AD users.
    Public Shared Sub SetADProperty(ByVal de As DirectoryEntry, _
    ByVal pName As String, ByVal pValue As String)
        'First make sure the property value isnt "nothing"
        If Not pValue Is Nothing Then
            'Check to see if the DirectoryEntry contains this property already
            If de.Properties.Contains(pName) Then 'The DE contains this property
                'Update the properties value
                de.Properties(pName)(0) = pValue
            Else    'Property doesnt exist
                'Add the property and set it's value
                de.Properties(pName).Add(pValue)
            End If
        End If
    End Sub
#End Region

#Region "ExtractUserName"
    'Function to extract just the login from the provided string 
    '(given in the format DOMAIN\USERNAME)
    Public Function ExtractUserName(ByVal path As String) As String
        Dim userPath As String() = path.Split(New Char() {"\"c})
        Return userPath((userPath.Length - 1))
    End Function
#End Region

#Region "SetCultureAndIdentity"
    'Establish identity (principal) and culture for a thread.
    Public Shared Sub SetCultureAndIdentity()
        AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal)
        Dim principal As WindowsPrincipal = CType(Thread.CurrentPrincipal, WindowsPrincipal)
        Dim identity As WindowsIdentity = CType(principal.Identity, WindowsIdentity)
        System.Threading.Thread.CurrentThread.CurrentCulture = New CultureInfo("en-GB")
    End Sub
#End Region

#Region "CreateADAccount"
    'Procedure to create a new Active Directory account
    Public Sub CreateAdAccount(ByVal sUserName As String, _
           ByVal sPassword As String, _
           ByVal sFirstName As String, ByVal sLastName As String, _
           ByVal sGroupName As String)
        'Dim catalog As Catalog = New Catalog()
        Dim dirEntry As New DirectoryEntry()
        ' 1. Create user account
        Dim adUsers As DirectoryEntries = dirEntry.Children
        Dim newUser As DirectoryEntry = adUsers.Add("CN=" & sUserName, "user")
        ' 2. Set properties
        SetADProperty(newUser, "givenname", sFirstName)
        SetADProperty(newUser, "sn", sLastName)
        SetADProperty(newUser, "SAMAccountName", sUserName)
        SetADProperty(newUser, "userPrincipalName", sUserName)
        newUser.CommitChanges()
        ' 3. Set the password
        SetPassword(newUser, sPassword)
        ' 5. Add the user to the specified group
        AddUserToGroup(dirEntry, newUser, sGroupName)
        ' 6. Enable the account
        EnableAccount(newUser)
        ' 7. Close & clean-up
        newUser.Close()
        dirEntry.Close()
    End Sub
#End Region

#Region "SetPassword"
    'Method to set a user's password
    Private Shared Sub SetPassword(ByVal dEntry As DirectoryEntry, _
    ByVal sPassword As String)
        Dim oPassword As Object() = New Object() {sPassword}
        Dim ret As Object = dEntry.Invoke("SetPassword", oPassword)
        dEntry.CommitChanges()
    End Sub
#End Region

#Region "EnableAccount"
    'Method to enable a user account in the AD.
    Private Shared Sub EnableAccount(ByVal de As DirectoryEntry)
        'UF_DONT_EXPIRE_PASSWD 0x10000
        Dim exp As Integer = CInt(de.Properties("userAccountControl").Value)
        de.Properties("userAccountControl").Value = exp Or &H1
        de.CommitChanges()
        'UF_ACCOUNTDISABLE 0x0002
        Dim val As Integer = CInt(de.Properties("userAccountControl").Value)
        de.Properties("userAccountControl").Value = val And Not &H2
        de.CommitChanges()
    End Sub
#End Region

#Region "AddUserToGroup"
    'Method to add a user to a group
    Public Shared Sub AddUserToGroup(ByVal de As DirectoryEntry, _
    ByVal deUser As DirectoryEntry, ByVal GroupName As String)
        Dim deSearch As DirectorySearcher = New DirectorySearcher()
        deSearch.SearchRoot = de
        deSearch.Filter = "(&(objectClass=group) (cn=" & GroupName & "))"
        Dim results As SearchResultCollection = deSearch.FindAll()
        Dim isGroupMember As Boolean = False
        If results.Count > 0 Then
            Dim group As New DirectoryEntry(results(0).Path)
            Dim members As Object = group.Invoke("Members", Nothing)
            For Each member As Object In CType(members, IEnumerable)
                Dim x As DirectoryEntry = New DirectoryEntry(member)
                Dim name As String = x.Name
                If name <> deUser.Name Then
                    isGroupMember = False
                Else
                    isGroupMember = True
                    Exit For
                End If
            Next member
            If (Not isGroupMember) Then
                group.Invoke("Add", New Object() {deUser.Path.ToString()})
            End If
            group.Close()
        End If
        Return
    End Sub
#End Region

#Region "DisableAccount"
    'Method that disables a user account in the AD 
    'and hides user's email from Exchange address lists.
    Public Sub DisableAccount(ByVal sLogin As String)
        '   1. Search the Active Directory for the desired user
        Dim dirEntry As DirectoryEntry = GetDirectoryEntry()
        Dim dirSearcher As DirectorySearcher = New DirectorySearcher(dirEntry)
        dirSearcher.Filter = "(&(objectCategory=Person)(objectClass=user)(SAMAccountName=" + sLogin + "))"
        dirSearcher.SearchScope = SearchScope.Subtree
        Dim results As SearchResult = dirSearcher.FindOne()
        '   2. Check returned results
        If Not results Is Nothing Then
            ''   2a. User was returned
            'Dim dirEntryResults As DirectoryEntry = GetDirectoryEntry(results.Path)
            'Dim iVal As Integer = _
            '    CInt(dirEntryResults.Properties("userAccountControl").Value)
            ''   3. Disable the users account
            'dirEntryResults.Properties("userAccountControl").Value = iVal Or &H2
            ''   4. Hide users email from all Exchange Mailing Lists
            'dirEntryResults.Properties("msExchHideFromAddressLists").Value = "TRUE"
            'dirEntryResults.CommitChanges()
            'dirEntryResults.Close()
        End If
        dirEntry.Close()
    End Sub
#End Region

End Class
