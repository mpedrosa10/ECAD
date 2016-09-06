<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoryMainForm
    Inherits Telerik.WinControls.UI.RadForm

    Public Sub New()
        InitializeComponent()
        LocalizeComponent()

    End Sub

    ' Localizes all the ui elements from a common Resource
    Private Sub LocalizeComponent()
        Me.SuspendLayout()

        Helpers.LocalizationHelper.LocalizeForm(Me)

        Me.ResumeLayout(False)
    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HistoryMainForm))
        Me.RadTextBox_PartNumber = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_PartNumber = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_LatestIssue = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_LatestIssue = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_IssueDate = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_IssueSubformQueryForIssueDataEntry = New Telerik.WinControls.UI.RadLabel()
        Me.RadGridView_Issues = New Telerik.WinControls.UI.RadGridView()
        Me.RadButton_Print = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Preview = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_PrintReport = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadTextBox_PartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_LatestIssue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_LatestIssue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_IssueDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_IssueSubformQueryForIssueDataEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_Issues, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_Issues.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Print, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_PrintReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadTextBox_PartNumber
        '
        Me.RadTextBox_PartNumber.AutoSize = False
        Me.RadTextBox_PartNumber.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_PartNumber.Location = New System.Drawing.Point(162, 15)
        Me.RadTextBox_PartNumber.Name = "RadTextBox_PartNumber"
        Me.RadTextBox_PartNumber.Size = New System.Drawing.Size(294, 30)
        Me.RadTextBox_PartNumber.TabIndex = 8
        Me.RadTextBox_PartNumber.ThemeName = "Windows8"
        '
        'RadLabel_PartNumber
        '
        Me.RadLabel_PartNumber.AutoSize = False
        Me.RadLabel_PartNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_PartNumber.Location = New System.Drawing.Point(15, 15)
        Me.RadLabel_PartNumber.Name = "RadLabel_PartNumber"
        Me.RadLabel_PartNumber.Size = New System.Drawing.Size(141, 30)
        Me.RadLabel_PartNumber.TabIndex = 7
        Me.RadLabel_PartNumber.Text = "HistoryMain_PartNumber"
        Me.RadLabel_PartNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_PartNumber.TextWrap = False
        Me.RadLabel_PartNumber.ThemeName = "Windows8"
        '
        'RadLabel_LatestIssue
        '
        Me.RadLabel_LatestIssue.AutoSize = False
        Me.RadLabel_LatestIssue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_LatestIssue.Location = New System.Drawing.Point(15, 51)
        Me.RadLabel_LatestIssue.Name = "RadLabel_LatestIssue"
        Me.RadLabel_LatestIssue.Size = New System.Drawing.Size(141, 30)
        Me.RadLabel_LatestIssue.TabIndex = 9
        Me.RadLabel_LatestIssue.Text = "HistoryMain_LatestIssue"
        Me.RadLabel_LatestIssue.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_LatestIssue.TextWrap = False
        Me.RadLabel_LatestIssue.ThemeName = "Windows8"
        '
        'RadTextBox_LatestIssue
        '
        Me.RadTextBox_LatestIssue.AutoSize = False
        Me.RadTextBox_LatestIssue.Enabled = False
        Me.RadTextBox_LatestIssue.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.RadTextBox_LatestIssue.Location = New System.Drawing.Point(162, 51)
        Me.RadTextBox_LatestIssue.Name = "RadTextBox_LatestIssue"
        Me.RadTextBox_LatestIssue.Size = New System.Drawing.Size(65, 30)
        Me.RadTextBox_LatestIssue.TabIndex = 10
        Me.RadTextBox_LatestIssue.ThemeName = "Windows8"
        '
        'RadTextBox_IssueDate
        '
        Me.RadTextBox_IssueDate.AutoSize = False
        Me.RadTextBox_IssueDate.Enabled = False
        Me.RadTextBox_IssueDate.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_IssueDate.Location = New System.Drawing.Point(242, 51)
        Me.RadTextBox_IssueDate.Name = "RadTextBox_IssueDate"
        Me.RadTextBox_IssueDate.Size = New System.Drawing.Size(65, 30)
        Me.RadTextBox_IssueDate.TabIndex = 11
        Me.RadTextBox_IssueDate.ThemeName = "Windows8"
        '
        'RadLabel_IssueSubformQueryForIssueDataEntry
        '
        Me.RadLabel_IssueSubformQueryForIssueDataEntry.AutoSize = False
        Me.RadLabel_IssueSubformQueryForIssueDataEntry.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_IssueSubformQueryForIssueDataEntry.Location = New System.Drawing.Point(15, 88)
        Me.RadLabel_IssueSubformQueryForIssueDataEntry.Name = "RadLabel_IssueSubformQueryForIssueDataEntry"
        Me.RadLabel_IssueSubformQueryForIssueDataEntry.Size = New System.Drawing.Size(393, 15)
        Me.RadLabel_IssueSubformQueryForIssueDataEntry.TabIndex = 12
        Me.RadLabel_IssueSubformQueryForIssueDataEntry.Text = "HistoryMain_IssueSubformQueryForIssueDataEntry"
        Me.RadLabel_IssueSubformQueryForIssueDataEntry.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_IssueSubformQueryForIssueDataEntry.TextWrap = False
        Me.RadLabel_IssueSubformQueryForIssueDataEntry.ThemeName = "Windows8"
        '
        'RadGridView_Issues
        '
        Me.RadGridView_Issues.AutoScroll = True
        Me.RadGridView_Issues.Location = New System.Drawing.Point(12, 109)
        '
        '
        '
        Me.RadGridView_Issues.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView_Issues.Name = "RadGridView_Issues"
        Me.RadGridView_Issues.Size = New System.Drawing.Size(704, 275)
        Me.RadGridView_Issues.TabIndex = 13
        Me.RadGridView_Issues.Text = "RadGridView1"
        Me.RadGridView_Issues.ThemeName = "Windows8"
        '
        'RadButton_Print
        '
        Me.RadButton_Print.BackColor = System.Drawing.Color.White
        Me.RadButton_Print.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.RadButton_Print.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadButton_Print.ForeColor = System.Drawing.Color.Black
        Me.RadButton_Print.Image = Global.ECAD.My.Resources.Resources.print_32
        Me.RadButton_Print.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButton_Print.Location = New System.Drawing.Point(470, 59)
        Me.RadButton_Print.Name = "RadButton_Print"
        Me.RadButton_Print.Size = New System.Drawing.Size(35, 35)
        Me.RadButton_Print.TabIndex = 15
        Me.RadButton_Print.ThemeName = "Windows8"
        '
        'RadButton_Preview
        '
        Me.RadButton_Preview.BackColor = System.Drawing.Color.White
        Me.RadButton_Preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadButton_Preview.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadButton_Preview.Image = Global.ECAD.My.Resources.Resources.preview_32
        Me.RadButton_Preview.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButton_Preview.Location = New System.Drawing.Point(521, 59)
        Me.RadButton_Preview.Name = "RadButton_Preview"
        Me.RadButton_Preview.Size = New System.Drawing.Size(35, 35)
        Me.RadButton_Preview.TabIndex = 14
        Me.RadButton_Preview.ThemeName = "Windows8"
        '
        'RadButton_PrintReport
        '
        Me.RadButton_PrintReport.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_PrintReport.Location = New System.Drawing.Point(574, 51)
        Me.RadButton_PrintReport.Name = "RadButton_PrintReport"
        Me.RadButton_PrintReport.Size = New System.Drawing.Size(142, 52)
        Me.RadButton_PrintReport.TabIndex = 16
        Me.RadButton_PrintReport.Text = "HistoryMain_ElectrolyticsHistory"
        Me.RadButton_PrintReport.TextWrap = True
        Me.RadButton_PrintReport.ThemeName = "Windows8"
        '
        'HistoryMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(728, 396)
        Me.Controls.Add(Me.RadButton_PrintReport)
        Me.Controls.Add(Me.RadButton_Print)
        Me.Controls.Add(Me.RadButton_Preview)
        Me.Controls.Add(Me.RadGridView_Issues)
        Me.Controls.Add(Me.RadLabel_IssueSubformQueryForIssueDataEntry)
        Me.Controls.Add(Me.RadTextBox_IssueDate)
        Me.Controls.Add(Me.RadTextBox_LatestIssue)
        Me.Controls.Add(Me.RadLabel_LatestIssue)
        Me.Controls.Add(Me.RadTextBox_PartNumber)
        Me.Controls.Add(Me.RadLabel_PartNumber)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HistoryMainForm"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "HistoryMain_TitleWindow"
        Me.ThemeName = "Windows8"
        CType(Me.RadTextBox_PartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_LatestIssue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_LatestIssue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_IssueDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_IssueSubformQueryForIssueDataEntry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_Issues.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_Issues, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Print, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Preview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_PrintReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadTextBox_PartNumber As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_PartNumber As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_LatestIssue As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_LatestIssue As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_IssueDate As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_IssueSubformQueryForIssueDataEntry As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGridView_Issues As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadButton_Print As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Preview As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_PrintReport As Telerik.WinControls.UI.RadButton
End Class

