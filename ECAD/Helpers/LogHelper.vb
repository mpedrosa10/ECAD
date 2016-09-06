Imports System.IO
Imports System.Threading

Namespace Helpers

    Public Class LogHelper

#Region "LogMessageToFile(String)"

        Private Shared loggingLock As Object = New Object

        Public Shared Sub LogMessageToFile(ByVal msg As String)
            SyncLock loggingLock
                Try
                    If (msg.Length <= 1) Then
                        Return
                    End If

                    Dim logLine As String = String.Format("Thread {0}-{1:G}: {2}.", Thread.CurrentThread.ManagedThreadId, DateTime.Now, msg)

                    ' File directory
                    Dim di As DirectoryInfo = New DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory)
                    ' File name
                    Dim fileName As String = String.Concat(AppDomain.CurrentDomain.FriendlyName)
                    ' File full path
                    Dim filePath As String = String.Concat(di, fileName, ".txt")
                    'Dim fileName As String = String.Concat(AppDomain.CurrentDomain.BaseDirectory, Reflection.Assembly.GetExecutingAssembly().GetName(), ".txt")

                    ' Write message to file
                    Using sw As StreamWriter = File.AppendText(filePath)
                        Try
                            sw.WriteLine(logLine)
                        Finally
                            sw.Close()
                        End Try
                    End Using

                    ' Get a reference to each file in that directory.
                    Dim fiArr() As FileInfo = di.GetFiles("*.txt")

                    ' Iterate through txt files in directory
                    For Each f As FileInfo In fiArr
                        If (f.Name = fileName + ".txt") Then
                            ' If current log file is too big, save it with a timestamp
                            If (f.Length > 10 * 1024 * 1024) Then
                                File.Copy(filePath, di.ToString + fileName + "_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".txt")
                                File.Delete(filePath)
                            End If
                        Else
                            ' Delete old log file
                            Dim ts As TimeSpan = New TimeSpan(DateTime.Now.Ticks - f.LastAccessTime.Ticks)
                            If (ts.TotalDays > 30) Then
                                File.Delete(f.FullName)
                            End If
                        End If
                    Next

                Catch ex As Exception
                    ' throw
                End Try
            End SyncLock
        End Sub

#End Region

#Region "LogMessageToFile(Exception)"
        ' Log Exception details
        Public Shared Sub LogMessageToFile(ByRef e As Exception)
            Dim msg As String = "Exception: " + e.Message

            If (e.StackTrace <> Nothing) Then
                msg += "\nStack Trace = " + e.StackTrace
            End If

            If (e.Source <> Nothing) Then
                msg += "\nSource = " + e.Source
            End If

            LogMessageToFile(msg)
        End Sub
#End Region

    End Class

End Namespace