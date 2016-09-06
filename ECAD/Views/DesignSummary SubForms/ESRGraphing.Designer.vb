<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ESR_Graphing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ESR_Graphing))
        Me.RadLabel_Title = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_PartNumber = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_PartNumber = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButton_PreviewReport = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_PrintReport = New Telerik.WinControls.UI.RadButton()
        Me.RadCheckBox_ShowData = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_AmericanStyle = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadButton_ScratchESR = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_RifaESRGrid = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_PartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_PreviewReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_PrintReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_ShowData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_AmericanStyle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_ScratchESR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_RifaESRGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel_Title
        '
        Me.RadLabel_Title.AutoSize = False
        Me.RadLabel_Title.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.RadLabel_Title.Location = New System.Drawing.Point(10, 10)
        Me.RadLabel_Title.Name = "RadLabel_Title"
        Me.RadLabel_Title.Size = New System.Drawing.Size(270, 35)
        Me.RadLabel_Title.TabIndex = 0
        Me.RadLabel_Title.Text = "ESRGraph_Title"
        Me.RadLabel_Title.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Title.TextWrap = False
        Me.RadLabel_Title.ThemeName = "Windows8"
        '
        'RadLabel_PartNumber
        '
        Me.RadLabel_PartNumber.AutoSize = False
        Me.RadLabel_PartNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_PartNumber.Location = New System.Drawing.Point(10, 52)
        Me.RadLabel_PartNumber.Name = "RadLabel_PartNumber"
        Me.RadLabel_PartNumber.Size = New System.Drawing.Size(113, 20)
        Me.RadLabel_PartNumber.TabIndex = 1
        Me.RadLabel_PartNumber.Text = "ESRGraph_PartNumber"
        Me.RadLabel_PartNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_PartNumber.TextWrap = False
        Me.RadLabel_PartNumber.ThemeName = "Windows8"
        '
        'RadTextBox_PartNumber
        '
        Me.RadTextBox_PartNumber.AutoSize = False
        Me.RadTextBox_PartNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBox_PartNumber.Location = New System.Drawing.Point(129, 52)
        Me.RadTextBox_PartNumber.Name = "RadTextBox_PartNumber"
        Me.RadTextBox_PartNumber.Size = New System.Drawing.Size(151, 20)
        Me.RadTextBox_PartNumber.TabIndex = 2
        Me.RadTextBox_PartNumber.ThemeName = "Windows8"
        '
        'RadButton_PreviewReport
        '
        Me.RadButton_PreviewReport.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_PreviewReport.Location = New System.Drawing.Point(25, 84)
        Me.RadButton_PreviewReport.Name = "RadButton_PreviewReport"
        Me.RadButton_PreviewReport.Size = New System.Drawing.Size(80, 60)
        Me.RadButton_PreviewReport.TabIndex = 3
        Me.RadButton_PreviewReport.Text = "ESRGraph_PreviewReport"
        Me.RadButton_PreviewReport.TextWrap = True
        Me.RadButton_PreviewReport.ThemeName = "Windows8"
        '
        'RadButton_PrintReport
        '
        Me.RadButton_PrintReport.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_PrintReport.Location = New System.Drawing.Point(185, 84)
        Me.RadButton_PrintReport.Name = "RadButton_PrintReport"
        Me.RadButton_PrintReport.Size = New System.Drawing.Size(80, 60)
        Me.RadButton_PrintReport.TabIndex = 4
        Me.RadButton_PrintReport.Text = "ESRGraph_PrintReport"
        Me.RadButton_PrintReport.TextWrap = True
        Me.RadButton_PrintReport.ThemeName = "Windows8"
        '
        'RadCheckBox_ShowData
        '
        Me.RadCheckBox_ShowData.AutoSize = False
        Me.RadCheckBox_ShowData.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_ShowData.Location = New System.Drawing.Point(10, 155)
        Me.RadCheckBox_ShowData.Name = "RadCheckBox_ShowData"
        Me.RadCheckBox_ShowData.Size = New System.Drawing.Size(120, 18)
        Me.RadCheckBox_ShowData.TabIndex = 5
        Me.RadCheckBox_ShowData.Text = "ESRGraph_ShowData"
        Me.RadCheckBox_ShowData.ThemeName = "Windows8"
        '
        'RadCheckBox_AmericanStyle
        '
        Me.RadCheckBox_AmericanStyle.AutoSize = False
        Me.RadCheckBox_AmericanStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_AmericanStyle.Location = New System.Drawing.Point(129, 155)
        Me.RadCheckBox_AmericanStyle.Name = "RadCheckBox_AmericanStyle"
        Me.RadCheckBox_AmericanStyle.Size = New System.Drawing.Size(151, 18)
        Me.RadCheckBox_AmericanStyle.TabIndex = 6
        Me.RadCheckBox_AmericanStyle.Text = "ESRGraph_AmericanStyle"
        Me.RadCheckBox_AmericanStyle.ThemeName = "Windows8"
        '
        'RadButton_ScratchESR
        '
        Me.RadButton_ScratchESR.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadButton_ScratchESR.Location = New System.Drawing.Point(50, 191)
        Me.RadButton_ScratchESR.Name = "RadButton_ScratchESR"
        Me.RadButton_ScratchESR.Size = New System.Drawing.Size(80, 20)
        Me.RadButton_ScratchESR.TabIndex = 7
        Me.RadButton_ScratchESR.Text = "ESRGraph_ScratchESR"
        Me.RadButton_ScratchESR.ThemeName = "Windows8"
        '
        'RadButton_RifaESRGrid
        '
        Me.RadButton_RifaESRGrid.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadButton_RifaESRGrid.Location = New System.Drawing.Point(160, 191)
        Me.RadButton_RifaESRGrid.Name = "RadButton_RifaESRGrid"
        Me.RadButton_RifaESRGrid.Size = New System.Drawing.Size(80, 20)
        Me.RadButton_RifaESRGrid.TabIndex = 8
        Me.RadButton_RifaESRGrid.Text = "ESRGraph_RifaESRGrid"
        Me.RadButton_RifaESRGrid.ThemeName = "Windows8"
        '
        'ESR_Graphing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 220)
        Me.Controls.Add(Me.RadButton_RifaESRGrid)
        Me.Controls.Add(Me.RadButton_ScratchESR)
        Me.Controls.Add(Me.RadCheckBox_AmericanStyle)
        Me.Controls.Add(Me.RadCheckBox_ShowData)
        Me.Controls.Add(Me.RadButton_PrintReport)
        Me.Controls.Add(Me.RadButton_PreviewReport)
        Me.Controls.Add(Me.RadTextBox_PartNumber)
        Me.Controls.Add(Me.RadLabel_PartNumber)
        Me.Controls.Add(Me.RadLabel_Title)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(300, 250)
        Me.MinimumSize = New System.Drawing.Size(300, 250)
        Me.Name = "ESR_Graphing"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(300, 250)
        Me.Text = "ESRGraph_TitleWindow"
        Me.ThemeName = "Windows8"
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_PartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_PreviewReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_PrintReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_ShowData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_AmericanStyle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_ScratchESR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_RifaESRGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadLabel_Title As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_PartNumber As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_PartNumber As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton_PreviewReport As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_PrintReport As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadCheckBox_ShowData As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_AmericanStyle As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadButton_ScratchESR As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_RifaESRGrid As Telerik.WinControls.UI.RadButton
End Class

