<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PiecePartData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PiecePartData))
        Me.Panel_Header = New System.Windows.Forms.Panel()
        Me.RadButton_DeletePart = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_CopyAsNewRecord = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_WhereUsed = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox_KemetLogo = New System.Windows.Forms.PictureBox()
        Me.RadLabel_Title = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_PiecePartNo = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_PiecePartNo = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Type = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_Type = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadCheckBox_Active = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_Obsolete = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadTextBox__Description = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Description = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_ShortDesc = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_ShortDesc = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Specification = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Specification = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_UnitOfMeasure = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_UnitOfMeasure = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Data = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Data = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_DrawingNumber = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_DrawingNumber = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_MSpecNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_MSpecNo = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_ExampleNP = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_CostBaseOld = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_PreviousCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_PreviousCost = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_CurrentCost = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_CurrentCost = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_CurrentCostSource = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_PreviousCostSource = New Telerik.WinControls.UI.RadTextBox()
        Me.RadGridView_Grid = New Telerik.WinControls.UI.RadGridView()
        Me.Panel_Suppliers = New System.Windows.Forms.Panel()
        Me.RadTextBox_VendorDescription3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_VendorDescription2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_VendorDescription1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Supplier3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Supplier2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Supplier1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_VendorDescription = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_Supplier = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadButton_AddAField = New Telerik.WinControls.UI.RadButton()
        Me.Panel_OracleData = New System.Windows.Forms.Panel()
        Me.RadCheckBox_MultilevelBackflushFlag = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_BackflushFlag = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox_StagingFlag = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel_BackflushWarehouse = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_StagingWarehouse = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_FirstOp = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_BackflushWarehouse = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_StagingWarehouse = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_FirstOp = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Function = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_OracleData = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_CostBase = New Telerik.WinControls.UI.RadTextBox()
        Me.Panel_Header.SuspendLayout()
        CType(Me.RadButton_DeletePart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_CopyAsNewRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_WhereUsed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_PiecePartNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PiecePartNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Type, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_Type, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_Active, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_Obsolete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox__Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_ShortDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ShortDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Specification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Specification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_UnitOfMeasure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_UnitOfMeasure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_DrawingNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_DrawingNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_MSpecNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_MSpecNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_ExampleNP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CostBaseOld, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_PreviousCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PreviousCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CurrentCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_CurrentCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CurrentCostSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_PreviousCostSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView_Grid.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Suppliers.SuspendLayout()
        CType(Me.RadTextBox_VendorDescription3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_VendorDescription2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_VendorDescription1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Supplier3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Supplier2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Supplier1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_VendorDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_AddAField, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_OracleData.SuspendLayout()
        CType(Me.RadCheckBox_MultilevelBackflushFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_BackflushFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_StagingFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_BackflushWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_StagingWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_FirstOp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_BackflushWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_StagingWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_FirstOp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Function, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_OracleData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_CostBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Header
        '
        Me.Panel_Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Header.Controls.Add(Me.RadButton_DeletePart)
        Me.Panel_Header.Controls.Add(Me.RadButton_CopyAsNewRecord)
        Me.Panel_Header.Controls.Add(Me.RadButton_WhereUsed)
        Me.Panel_Header.Controls.Add(Me.PictureBox_KemetLogo)
        Me.Panel_Header.Controls.Add(Me.RadLabel_Title)
        Me.Panel_Header.Location = New System.Drawing.Point(-5, -2)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New System.Drawing.Size(1033, 68)
        Me.Panel_Header.TabIndex = 2
        '
        'RadButton_DeletePart
        '
        Me.RadButton_DeletePart.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_DeletePart.Location = New System.Drawing.Point(540, 8)
        Me.RadButton_DeletePart.Name = "RadButton_DeletePart"
        Me.RadButton_DeletePart.Size = New System.Drawing.Size(100, 50)
        Me.RadButton_DeletePart.TabIndex = 14
        Me.RadButton_DeletePart.Text = "PiecePart_DeletePart"
        Me.RadButton_DeletePart.TextWrap = True
        Me.RadButton_DeletePart.ThemeName = "Windows8"
        '
        'RadButton_CopyAsNewRecord
        '
        Me.RadButton_CopyAsNewRecord.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_CopyAsNewRecord.Location = New System.Drawing.Point(410, 8)
        Me.RadButton_CopyAsNewRecord.Name = "RadButton_CopyAsNewRecord"
        Me.RadButton_CopyAsNewRecord.Size = New System.Drawing.Size(100, 50)
        Me.RadButton_CopyAsNewRecord.TabIndex = 13
        Me.RadButton_CopyAsNewRecord.Text = "PiecePart_CopyAsNewRecord"
        Me.RadButton_CopyAsNewRecord.TextWrap = True
        Me.RadButton_CopyAsNewRecord.ThemeName = "Windows8"
        '
        'RadButton_WhereUsed
        '
        Me.RadButton_WhereUsed.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_WhereUsed.Location = New System.Drawing.Point(280, 8)
        Me.RadButton_WhereUsed.Name = "RadButton_WhereUsed"
        Me.RadButton_WhereUsed.Size = New System.Drawing.Size(100, 50)
        Me.RadButton_WhereUsed.TabIndex = 12
        Me.RadButton_WhereUsed.Text = "PiecePart_WhereUsed"
        Me.RadButton_WhereUsed.TextWrap = True
        Me.RadButton_WhereUsed.ThemeName = "Windows8"
        '
        'PictureBox_KemetLogo
        '
        Me.PictureBox_KemetLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox_KemetLogo.Image = Global.ECAD.My.Resources.Resources.kemet_logo_small
        Me.PictureBox_KemetLogo.Location = New System.Drawing.Point(896, 4)
        Me.PictureBox_KemetLogo.MaximumSize = New System.Drawing.Size(142, 61)
        Me.PictureBox_KemetLogo.Name = "PictureBox_KemetLogo"
        Me.PictureBox_KemetLogo.Size = New System.Drawing.Size(116, 54)
        Me.PictureBox_KemetLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_KemetLogo.TabIndex = 11
        Me.PictureBox_KemetLogo.TabStop = False
        '
        'RadLabel_Title
        '
        Me.RadLabel_Title.AutoSize = False
        Me.RadLabel_Title.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel_Title.Location = New System.Drawing.Point(25, -2)
        Me.RadLabel_Title.Name = "RadLabel_Title"
        Me.RadLabel_Title.Size = New System.Drawing.Size(282, 68)
        Me.RadLabel_Title.TabIndex = 0
        Me.RadLabel_Title.Text = "PiecePart_Title"
        Me.RadLabel_Title.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Title.ThemeName = "Windows8"
        '
        'RadDropDownList_PiecePartNo
        '
        Me.RadDropDownList_PiecePartNo.AutoSize = False
        Me.RadDropDownList_PiecePartNo.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.RadDropDownList_PiecePartNo.Location = New System.Drawing.Point(178, 82)
        Me.RadDropDownList_PiecePartNo.Name = "RadDropDownList_PiecePartNo"
        Me.RadDropDownList_PiecePartNo.Size = New System.Drawing.Size(329, 30)
        Me.RadDropDownList_PiecePartNo.TabIndex = 7
        Me.RadDropDownList_PiecePartNo.ThemeName = "Windows8"
        '
        'RadLabel_PiecePartNo
        '
        Me.RadLabel_PiecePartNo.AutoSize = False
        Me.RadLabel_PiecePartNo.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.RadLabel_PiecePartNo.Location = New System.Drawing.Point(22, 82)
        Me.RadLabel_PiecePartNo.Name = "RadLabel_PiecePartNo"
        Me.RadLabel_PiecePartNo.Size = New System.Drawing.Size(150, 30)
        Me.RadLabel_PiecePartNo.TabIndex = 6
        Me.RadLabel_PiecePartNo.Text = "PiecePart_PiecePartNo"
        Me.RadLabel_PiecePartNo.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_PiecePartNo.TextWrap = False
        Me.RadLabel_PiecePartNo.ThemeName = "Windows8"
        '
        'RadLabel_Type
        '
        Me.RadLabel_Type.AutoSize = False
        Me.RadLabel_Type.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.RadLabel_Type.Location = New System.Drawing.Point(22, 118)
        Me.RadLabel_Type.Name = "RadLabel_Type"
        Me.RadLabel_Type.Size = New System.Drawing.Size(150, 30)
        Me.RadLabel_Type.TabIndex = 8
        Me.RadLabel_Type.Text = "PiecePart_Type"
        Me.RadLabel_Type.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Type.TextWrap = False
        Me.RadLabel_Type.ThemeName = "Windows8"
        '
        'RadDropDownList_Type
        '
        Me.RadDropDownList_Type.AutoSize = False
        Me.RadDropDownList_Type.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.RadDropDownList_Type.Location = New System.Drawing.Point(178, 118)
        Me.RadDropDownList_Type.Name = "RadDropDownList_Type"
        Me.RadDropDownList_Type.Size = New System.Drawing.Size(329, 30)
        Me.RadDropDownList_Type.TabIndex = 9
        Me.RadDropDownList_Type.ThemeName = "Windows8"
        '
        'RadCheckBox_Active
        '
        Me.RadCheckBox_Active.AutoSize = False
        Me.RadCheckBox_Active.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Active.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_Active.Location = New System.Drawing.Point(535, 87)
        Me.RadCheckBox_Active.Name = "RadCheckBox_Active"
        Me.RadCheckBox_Active.Size = New System.Drawing.Size(102, 20)
        Me.RadCheckBox_Active.TabIndex = 17
        Me.RadCheckBox_Active.Text = "PiecePart_Active"
        Me.RadCheckBox_Active.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Active.ThemeName = "Windows8"
        '
        'RadCheckBox_Obsolete
        '
        Me.RadCheckBox_Obsolete.AutoSize = False
        Me.RadCheckBox_Obsolete.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Obsolete.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_Obsolete.Location = New System.Drawing.Point(666, 87)
        Me.RadCheckBox_Obsolete.Name = "RadCheckBox_Obsolete"
        Me.RadCheckBox_Obsolete.Size = New System.Drawing.Size(102, 20)
        Me.RadCheckBox_Obsolete.TabIndex = 18
        Me.RadCheckBox_Obsolete.Text = "PiecePart_Obsolete"
        Me.RadCheckBox_Obsolete.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Obsolete.ThemeName = "Windows8"
        '
        'RadTextBox__Description
        '
        Me.RadTextBox__Description.AutoSize = False
        Me.RadTextBox__Description.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox__Description.Location = New System.Drawing.Point(155, 163)
        Me.RadTextBox__Description.Multiline = True
        Me.RadTextBox__Description.Name = "RadTextBox__Description"
        Me.RadTextBox__Description.Size = New System.Drawing.Size(240, 50)
        Me.RadTextBox__Description.TabIndex = 20
        Me.RadTextBox__Description.ThemeName = "Windows8"
        '
        'RadLabel_Description
        '
        Me.RadLabel_Description.AutoSize = False
        Me.RadLabel_Description.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Description.Location = New System.Drawing.Point(14, 163)
        Me.RadLabel_Description.Name = "RadLabel_Description"
        Me.RadLabel_Description.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Description.TabIndex = 19
        Me.RadLabel_Description.Text = "PiecePart_Description"
        Me.RadLabel_Description.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Description.TextWrap = False
        Me.RadLabel_Description.ThemeName = "Windows8"
        '
        'RadTextBox_ShortDesc
        '
        Me.RadTextBox_ShortDesc.AutoSize = False
        Me.RadTextBox_ShortDesc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_ShortDesc.Location = New System.Drawing.Point(155, 219)
        Me.RadTextBox_ShortDesc.Name = "RadTextBox_ShortDesc"
        Me.RadTextBox_ShortDesc.Size = New System.Drawing.Size(240, 25)
        Me.RadTextBox_ShortDesc.TabIndex = 22
        Me.RadTextBox_ShortDesc.ThemeName = "Windows8"
        '
        'RadLabel_ShortDesc
        '
        Me.RadLabel_ShortDesc.AutoSize = False
        Me.RadLabel_ShortDesc.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ShortDesc.Location = New System.Drawing.Point(14, 219)
        Me.RadLabel_ShortDesc.Name = "RadLabel_ShortDesc"
        Me.RadLabel_ShortDesc.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_ShortDesc.TabIndex = 21
        Me.RadLabel_ShortDesc.Text = "PiecePart_ShortDesc"
        Me.RadLabel_ShortDesc.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_ShortDesc.TextWrap = False
        Me.RadLabel_ShortDesc.ThemeName = "Windows8"
        '
        'RadTextBox_Specification
        '
        Me.RadTextBox_Specification.AutoSize = False
        Me.RadTextBox_Specification.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Specification.Location = New System.Drawing.Point(155, 250)
        Me.RadTextBox_Specification.Name = "RadTextBox_Specification"
        Me.RadTextBox_Specification.Size = New System.Drawing.Size(240, 25)
        Me.RadTextBox_Specification.TabIndex = 24
        Me.RadTextBox_Specification.ThemeName = "Windows8"
        '
        'RadLabel_Specification
        '
        Me.RadLabel_Specification.AutoSize = False
        Me.RadLabel_Specification.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Specification.Location = New System.Drawing.Point(14, 250)
        Me.RadLabel_Specification.Name = "RadLabel_Specification"
        Me.RadLabel_Specification.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Specification.TabIndex = 23
        Me.RadLabel_Specification.Text = "PiecePart_Specification"
        Me.RadLabel_Specification.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Specification.TextWrap = False
        Me.RadLabel_Specification.ThemeName = "Windows8"
        '
        'RadTextBox_UnitOfMeasure
        '
        Me.RadTextBox_UnitOfMeasure.AutoSize = False
        Me.RadTextBox_UnitOfMeasure.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_UnitOfMeasure.Location = New System.Drawing.Point(155, 296)
        Me.RadTextBox_UnitOfMeasure.Name = "RadTextBox_UnitOfMeasure"
        Me.RadTextBox_UnitOfMeasure.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_UnitOfMeasure.TabIndex = 26
        Me.RadTextBox_UnitOfMeasure.ThemeName = "Windows8"
        '
        'RadLabel_UnitOfMeasure
        '
        Me.RadLabel_UnitOfMeasure.AutoSize = False
        Me.RadLabel_UnitOfMeasure.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_UnitOfMeasure.Location = New System.Drawing.Point(14, 296)
        Me.RadLabel_UnitOfMeasure.Name = "RadLabel_UnitOfMeasure"
        Me.RadLabel_UnitOfMeasure.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_UnitOfMeasure.TabIndex = 25
        Me.RadLabel_UnitOfMeasure.Text = "PiecePart_UnitOfMeasure"
        Me.RadLabel_UnitOfMeasure.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_UnitOfMeasure.TextWrap = False
        Me.RadLabel_UnitOfMeasure.ThemeName = "Windows8"
        '
        'RadTextBox_Data
        '
        Me.RadTextBox_Data.AutoSize = False
        Me.RadTextBox_Data.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Data.Location = New System.Drawing.Point(155, 327)
        Me.RadTextBox_Data.Name = "RadTextBox_Data"
        Me.RadTextBox_Data.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_Data.TabIndex = 28
        Me.RadTextBox_Data.ThemeName = "Windows8"
        '
        'RadLabel_Data
        '
        Me.RadLabel_Data.AutoSize = False
        Me.RadLabel_Data.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Data.Location = New System.Drawing.Point(14, 327)
        Me.RadLabel_Data.Name = "RadLabel_Data"
        Me.RadLabel_Data.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Data.TabIndex = 27
        Me.RadLabel_Data.Text = "PiecePart_Data"
        Me.RadLabel_Data.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Data.TextWrap = False
        Me.RadLabel_Data.ThemeName = "Windows8"
        '
        'RadTextBox_DrawingNumber
        '
        Me.RadTextBox_DrawingNumber.AutoSize = False
        Me.RadTextBox_DrawingNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_DrawingNumber.Location = New System.Drawing.Point(155, 358)
        Me.RadTextBox_DrawingNumber.Name = "RadTextBox_DrawingNumber"
        Me.RadTextBox_DrawingNumber.Size = New System.Drawing.Size(122, 25)
        Me.RadTextBox_DrawingNumber.TabIndex = 30
        Me.RadTextBox_DrawingNumber.ThemeName = "Windows8"
        '
        'RadLabel_DrawingNumber
        '
        Me.RadLabel_DrawingNumber.AutoSize = False
        Me.RadLabel_DrawingNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_DrawingNumber.Location = New System.Drawing.Point(14, 358)
        Me.RadLabel_DrawingNumber.Name = "RadLabel_DrawingNumber"
        Me.RadLabel_DrawingNumber.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_DrawingNumber.TabIndex = 29
        Me.RadLabel_DrawingNumber.Text = "PiecePart_DrawingNumber"
        Me.RadLabel_DrawingNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_DrawingNumber.TextWrap = False
        Me.RadLabel_DrawingNumber.ThemeName = "Windows8"
        '
        'RadTextBox_MSpecNo
        '
        Me.RadTextBox_MSpecNo.AutoSize = False
        Me.RadTextBox_MSpecNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_MSpecNo.Location = New System.Drawing.Point(155, 389)
        Me.RadTextBox_MSpecNo.Name = "RadTextBox_MSpecNo"
        Me.RadTextBox_MSpecNo.Size = New System.Drawing.Size(122, 25)
        Me.RadTextBox_MSpecNo.TabIndex = 32
        Me.RadTextBox_MSpecNo.ThemeName = "Windows8"
        '
        'RadLabel_MSpecNo
        '
        Me.RadLabel_MSpecNo.AutoSize = False
        Me.RadLabel_MSpecNo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_MSpecNo.Location = New System.Drawing.Point(14, 389)
        Me.RadLabel_MSpecNo.Name = "RadLabel_MSpecNo"
        Me.RadLabel_MSpecNo.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_MSpecNo.TabIndex = 31
        Me.RadLabel_MSpecNo.Text = "PiecePart_MSpecNo"
        Me.RadLabel_MSpecNo.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_MSpecNo.TextWrap = False
        Me.RadLabel_MSpecNo.ThemeName = "Windows8"
        '
        'RadLabel_ExampleNP
        '
        Me.RadLabel_ExampleNP.AutoSize = False
        Me.RadLabel_ExampleNP.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_ExampleNP.Location = New System.Drawing.Point(251, 327)
        Me.RadLabel_ExampleNP.Name = "RadLabel_ExampleNP"
        Me.RadLabel_ExampleNP.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_ExampleNP.TabIndex = 33
        Me.RadLabel_ExampleNP.Text = "PiecePart_ExampleNP"
        Me.RadLabel_ExampleNP.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_ExampleNP.TextWrap = False
        Me.RadLabel_ExampleNP.ThemeName = "Windows8"
        '
        'RadTextBox_CostBaseOld
        '
        Me.RadTextBox_CostBaseOld.AutoSize = False
        Me.RadTextBox_CostBaseOld.Enabled = False
        Me.RadTextBox_CostBaseOld.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_CostBaseOld.Location = New System.Drawing.Point(287, 420)
        Me.RadTextBox_CostBaseOld.Name = "RadTextBox_CostBaseOld"
        Me.RadTextBox_CostBaseOld.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_CostBaseOld.TabIndex = 35
        Me.RadTextBox_CostBaseOld.ThemeName = "Windows8"
        '
        'RadTextBox_PreviousCost
        '
        Me.RadTextBox_PreviousCost.AutoSize = False
        Me.RadTextBox_PreviousCost.Enabled = False
        Me.RadTextBox_PreviousCost.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_PreviousCost.Location = New System.Drawing.Point(163, 483)
        Me.RadTextBox_PreviousCost.Name = "RadTextBox_PreviousCost"
        Me.RadTextBox_PreviousCost.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_PreviousCost.TabIndex = 39
        Me.RadTextBox_PreviousCost.ThemeName = "Windows8"
        '
        'RadLabel_PreviousCost
        '
        Me.RadLabel_PreviousCost.AutoSize = False
        Me.RadLabel_PreviousCost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_PreviousCost.Location = New System.Drawing.Point(22, 483)
        Me.RadLabel_PreviousCost.Name = "RadLabel_PreviousCost"
        Me.RadLabel_PreviousCost.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_PreviousCost.TabIndex = 38
        Me.RadLabel_PreviousCost.Text = "PiecePart_PreviousCost"
        Me.RadLabel_PreviousCost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_PreviousCost.TextWrap = False
        Me.RadLabel_PreviousCost.ThemeName = "Windows8"
        '
        'RadTextBox_CurrentCost
        '
        Me.RadTextBox_CurrentCost.AutoSize = False
        Me.RadTextBox_CurrentCost.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_CurrentCost.Location = New System.Drawing.Point(163, 452)
        Me.RadTextBox_CurrentCost.Name = "RadTextBox_CurrentCost"
        Me.RadTextBox_CurrentCost.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_CurrentCost.TabIndex = 37
        Me.RadTextBox_CurrentCost.ThemeName = "Windows8"
        '
        'RadLabel_CurrentCost
        '
        Me.RadLabel_CurrentCost.AutoSize = False
        Me.RadLabel_CurrentCost.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_CurrentCost.Location = New System.Drawing.Point(22, 452)
        Me.RadLabel_CurrentCost.Name = "RadLabel_CurrentCost"
        Me.RadLabel_CurrentCost.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_CurrentCost.TabIndex = 36
        Me.RadLabel_CurrentCost.Text = "PiecePart_CurrentCost"
        Me.RadLabel_CurrentCost.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_CurrentCost.TextWrap = False
        Me.RadLabel_CurrentCost.ThemeName = "Windows8"
        '
        'RadTextBox_CurrentCostSource
        '
        Me.RadTextBox_CurrentCostSource.AutoSize = False
        Me.RadTextBox_CurrentCostSource.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_CurrentCostSource.Location = New System.Drawing.Point(259, 452)
        Me.RadTextBox_CurrentCostSource.Name = "RadTextBox_CurrentCostSource"
        Me.RadTextBox_CurrentCostSource.Size = New System.Drawing.Size(118, 25)
        Me.RadTextBox_CurrentCostSource.TabIndex = 40
        Me.RadTextBox_CurrentCostSource.ThemeName = "Windows8"
        '
        'RadTextBox_PreviousCostSource
        '
        Me.RadTextBox_PreviousCostSource.AutoSize = False
        Me.RadTextBox_PreviousCostSource.Enabled = False
        Me.RadTextBox_PreviousCostSource.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_PreviousCostSource.Location = New System.Drawing.Point(259, 483)
        Me.RadTextBox_PreviousCostSource.Name = "RadTextBox_PreviousCostSource"
        Me.RadTextBox_PreviousCostSource.Size = New System.Drawing.Size(118, 25)
        Me.RadTextBox_PreviousCostSource.TabIndex = 41
        Me.RadTextBox_PreviousCostSource.ThemeName = "Windows8"
        '
        'RadGridView_Grid
        '
        Me.RadGridView_Grid.Location = New System.Drawing.Point(407, 163)
        '
        '
        '
        Me.RadGridView_Grid.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView_Grid.Name = "RadGridView_Grid"
        Me.RadGridView_Grid.Size = New System.Drawing.Size(309, 189)
        Me.RadGridView_Grid.TabIndex = 42
        Me.RadGridView_Grid.Text = "RadGridView1"
        Me.RadGridView_Grid.ThemeName = "Windows8"
        '
        'Panel_Suppliers
        '
        Me.Panel_Suppliers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Suppliers.Controls.Add(Me.RadTextBox_VendorDescription3)
        Me.Panel_Suppliers.Controls.Add(Me.RadTextBox_VendorDescription2)
        Me.Panel_Suppliers.Controls.Add(Me.RadTextBox_VendorDescription1)
        Me.Panel_Suppliers.Controls.Add(Me.RadTextBox_Supplier3)
        Me.Panel_Suppliers.Controls.Add(Me.RadTextBox_Supplier2)
        Me.Panel_Suppliers.Controls.Add(Me.RadTextBox_Supplier1)
        Me.Panel_Suppliers.Controls.Add(Me.RadLabel_VendorDescription)
        Me.Panel_Suppliers.Controls.Add(Me.RadLabel_Supplier)
        Me.Panel_Suppliers.Controls.Add(Me.RadLabel_1)
        Me.Panel_Suppliers.Controls.Add(Me.RadLabel_2)
        Me.Panel_Suppliers.Controls.Add(Me.RadLabel_3)
        Me.Panel_Suppliers.Location = New System.Drawing.Point(407, 389)
        Me.Panel_Suppliers.Name = "Panel_Suppliers"
        Me.Panel_Suppliers.Size = New System.Drawing.Size(602, 119)
        Me.Panel_Suppliers.TabIndex = 43
        '
        'RadTextBox_VendorDescription3
        '
        Me.RadTextBox_VendorDescription3.AutoSize = False
        Me.RadTextBox_VendorDescription3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_VendorDescription3.Location = New System.Drawing.Point(456, 66)
        Me.RadTextBox_VendorDescription3.Multiline = True
        Me.RadTextBox_VendorDescription3.Name = "RadTextBox_VendorDescription3"
        Me.RadTextBox_VendorDescription3.Size = New System.Drawing.Size(122, 46)
        Me.RadTextBox_VendorDescription3.TabIndex = 38
        Me.RadTextBox_VendorDescription3.ThemeName = "Windows8"
        '
        'RadTextBox_VendorDescription2
        '
        Me.RadTextBox_VendorDescription2.AutoSize = False
        Me.RadTextBox_VendorDescription2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_VendorDescription2.Location = New System.Drawing.Point(309, 65)
        Me.RadTextBox_VendorDescription2.Multiline = True
        Me.RadTextBox_VendorDescription2.Name = "RadTextBox_VendorDescription2"
        Me.RadTextBox_VendorDescription2.Size = New System.Drawing.Size(122, 46)
        Me.RadTextBox_VendorDescription2.TabIndex = 37
        Me.RadTextBox_VendorDescription2.ThemeName = "Windows8"
        '
        'RadTextBox_VendorDescription1
        '
        Me.RadTextBox_VendorDescription1.AutoSize = False
        Me.RadTextBox_VendorDescription1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_VendorDescription1.Location = New System.Drawing.Point(161, 65)
        Me.RadTextBox_VendorDescription1.Multiline = True
        Me.RadTextBox_VendorDescription1.Name = "RadTextBox_VendorDescription1"
        Me.RadTextBox_VendorDescription1.Size = New System.Drawing.Size(122, 46)
        Me.RadTextBox_VendorDescription1.TabIndex = 36
        Me.RadTextBox_VendorDescription1.ThemeName = "Windows8"
        '
        'RadTextBox_Supplier3
        '
        Me.RadTextBox_Supplier3.AutoSize = False
        Me.RadTextBox_Supplier3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Supplier3.Location = New System.Drawing.Point(456, 35)
        Me.RadTextBox_Supplier3.Name = "RadTextBox_Supplier3"
        Me.RadTextBox_Supplier3.Size = New System.Drawing.Size(122, 25)
        Me.RadTextBox_Supplier3.TabIndex = 35
        Me.RadTextBox_Supplier3.ThemeName = "Windows8"
        '
        'RadTextBox_Supplier2
        '
        Me.RadTextBox_Supplier2.AutoSize = False
        Me.RadTextBox_Supplier2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Supplier2.Location = New System.Drawing.Point(309, 34)
        Me.RadTextBox_Supplier2.Name = "RadTextBox_Supplier2"
        Me.RadTextBox_Supplier2.Size = New System.Drawing.Size(122, 25)
        Me.RadTextBox_Supplier2.TabIndex = 34
        Me.RadTextBox_Supplier2.ThemeName = "Windows8"
        '
        'RadTextBox_Supplier1
        '
        Me.RadTextBox_Supplier1.AutoSize = False
        Me.RadTextBox_Supplier1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_Supplier1.Location = New System.Drawing.Point(161, 34)
        Me.RadTextBox_Supplier1.Name = "RadTextBox_Supplier1"
        Me.RadTextBox_Supplier1.Size = New System.Drawing.Size(122, 25)
        Me.RadTextBox_Supplier1.TabIndex = 33
        Me.RadTextBox_Supplier1.ThemeName = "Windows8"
        '
        'RadLabel_VendorDescription
        '
        Me.RadLabel_VendorDescription.AutoSize = False
        Me.RadLabel_VendorDescription.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_VendorDescription.Location = New System.Drawing.Point(3, 64)
        Me.RadLabel_VendorDescription.Name = "RadLabel_VendorDescription"
        Me.RadLabel_VendorDescription.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_VendorDescription.TabIndex = 32
        Me.RadLabel_VendorDescription.Text = "PiecePart_VendorDescription"
        Me.RadLabel_VendorDescription.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_VendorDescription.TextWrap = False
        Me.RadLabel_VendorDescription.ThemeName = "Windows8"
        '
        'RadLabel_Supplier
        '
        Me.RadLabel_Supplier.AutoSize = False
        Me.RadLabel_Supplier.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Supplier.Location = New System.Drawing.Point(3, 34)
        Me.RadLabel_Supplier.Name = "RadLabel_Supplier"
        Me.RadLabel_Supplier.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_Supplier.TabIndex = 31
        Me.RadLabel_Supplier.Text = "PiecePart_Supplier"
        Me.RadLabel_Supplier.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Supplier.TextWrap = False
        Me.RadLabel_Supplier.ThemeName = "Windows8"
        '
        'RadLabel_1
        '
        Me.RadLabel_1.AutoSize = False
        Me.RadLabel_1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_1.Location = New System.Drawing.Point(161, 7)
        Me.RadLabel_1.Name = "RadLabel_1"
        Me.RadLabel_1.Size = New System.Drawing.Size(122, 25)
        Me.RadLabel_1.TabIndex = 30
        Me.RadLabel_1.Text = "1"
        Me.RadLabel_1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_1.TextWrap = False
        Me.RadLabel_1.ThemeName = "Windows8"
        '
        'RadLabel_2
        '
        Me.RadLabel_2.AutoSize = False
        Me.RadLabel_2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_2.Location = New System.Drawing.Point(309, 7)
        Me.RadLabel_2.Name = "RadLabel_2"
        Me.RadLabel_2.Size = New System.Drawing.Size(122, 25)
        Me.RadLabel_2.TabIndex = 29
        Me.RadLabel_2.Text = "2"
        Me.RadLabel_2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_2.TextWrap = False
        Me.RadLabel_2.ThemeName = "Windows8"
        '
        'RadLabel_3
        '
        Me.RadLabel_3.AutoSize = False
        Me.RadLabel_3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_3.Location = New System.Drawing.Point(456, 7)
        Me.RadLabel_3.Name = "RadLabel_3"
        Me.RadLabel_3.Size = New System.Drawing.Size(122, 25)
        Me.RadLabel_3.TabIndex = 28
        Me.RadLabel_3.Text = "3"
        Me.RadLabel_3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_3.TextWrap = False
        Me.RadLabel_3.ThemeName = "Windows8"
        '
        'RadButton_AddAField
        '
        Me.RadButton_AddAField.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton_AddAField.Location = New System.Drawing.Point(407, 349)
        Me.RadButton_AddAField.Name = "RadButton_AddAField"
        Me.RadButton_AddAField.Size = New System.Drawing.Size(309, 34)
        Me.RadButton_AddAField.TabIndex = 44
        Me.RadButton_AddAField.Text = "PiecePart_AddAField"
        Me.RadButton_AddAField.TextWrap = True
        Me.RadButton_AddAField.ThemeName = "Windows8"
        '
        'Panel_OracleData
        '
        Me.Panel_OracleData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_OracleData.Controls.Add(Me.RadCheckBox_MultilevelBackflushFlag)
        Me.Panel_OracleData.Controls.Add(Me.RadCheckBox_BackflushFlag)
        Me.Panel_OracleData.Controls.Add(Me.RadCheckBox_StagingFlag)
        Me.Panel_OracleData.Controls.Add(Me.RadLabel_BackflushWarehouse)
        Me.Panel_OracleData.Controls.Add(Me.RadLabel_StagingWarehouse)
        Me.Panel_OracleData.Controls.Add(Me.RadLabel_FirstOp)
        Me.Panel_OracleData.Controls.Add(Me.RadTextBox_BackflushWarehouse)
        Me.Panel_OracleData.Controls.Add(Me.RadTextBox_StagingWarehouse)
        Me.Panel_OracleData.Controls.Add(Me.RadTextBox_FirstOp)
        Me.Panel_OracleData.Location = New System.Drawing.Point(722, 163)
        Me.Panel_OracleData.Name = "Panel_OracleData"
        Me.Panel_OracleData.Size = New System.Drawing.Size(287, 189)
        Me.Panel_OracleData.TabIndex = 45
        '
        'RadCheckBox_MultilevelBackflushFlag
        '
        Me.RadCheckBox_MultilevelBackflushFlag.AutoSize = False
        Me.RadCheckBox_MultilevelBackflushFlag.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_MultilevelBackflushFlag.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_MultilevelBackflushFlag.Location = New System.Drawing.Point(-22, 161)
        Me.RadCheckBox_MultilevelBackflushFlag.Name = "RadCheckBox_MultilevelBackflushFlag"
        Me.RadCheckBox_MultilevelBackflushFlag.Size = New System.Drawing.Size(256, 20)
        Me.RadCheckBox_MultilevelBackflushFlag.TabIndex = 43
        Me.RadCheckBox_MultilevelBackflushFlag.Text = "PiecePart_MultilevelBackflushFlag"
        Me.RadCheckBox_MultilevelBackflushFlag.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_MultilevelBackflushFlag.ThemeName = "Windows8"
        '
        'RadCheckBox_BackflushFlag
        '
        Me.RadCheckBox_BackflushFlag.AutoSize = False
        Me.RadCheckBox_BackflushFlag.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_BackflushFlag.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_BackflushFlag.Location = New System.Drawing.Point(-22, 135)
        Me.RadCheckBox_BackflushFlag.Name = "RadCheckBox_BackflushFlag"
        Me.RadCheckBox_BackflushFlag.Size = New System.Drawing.Size(256, 20)
        Me.RadCheckBox_BackflushFlag.TabIndex = 42
        Me.RadCheckBox_BackflushFlag.Text = "PiecePart_BackflushFlag"
        Me.RadCheckBox_BackflushFlag.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_BackflushFlag.ThemeName = "Windows8"
        '
        'RadCheckBox_StagingFlag
        '
        Me.RadCheckBox_StagingFlag.AutoSize = False
        Me.RadCheckBox_StagingFlag.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_StagingFlag.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_StagingFlag.Location = New System.Drawing.Point(-22, 109)
        Me.RadCheckBox_StagingFlag.Name = "RadCheckBox_StagingFlag"
        Me.RadCheckBox_StagingFlag.Size = New System.Drawing.Size(256, 20)
        Me.RadCheckBox_StagingFlag.TabIndex = 41
        Me.RadCheckBox_StagingFlag.Text = "PiecePart_StagingFlag"
        Me.RadCheckBox_StagingFlag.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_StagingFlag.ThemeName = "Windows8"
        '
        'RadLabel_BackflushWarehouse
        '
        Me.RadLabel_BackflushWarehouse.AutoSize = False
        Me.RadLabel_BackflushWarehouse.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_BackflushWarehouse.Location = New System.Drawing.Point(3, 75)
        Me.RadLabel_BackflushWarehouse.Name = "RadLabel_BackflushWarehouse"
        Me.RadLabel_BackflushWarehouse.Size = New System.Drawing.Size(173, 25)
        Me.RadLabel_BackflushWarehouse.TabIndex = 40
        Me.RadLabel_BackflushWarehouse.Text = "PiecePart_BackflushWarehouse"
        Me.RadLabel_BackflushWarehouse.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_BackflushWarehouse.TextWrap = False
        Me.RadLabel_BackflushWarehouse.ThemeName = "Windows8"
        '
        'RadLabel_StagingWarehouse
        '
        Me.RadLabel_StagingWarehouse.AutoSize = False
        Me.RadLabel_StagingWarehouse.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_StagingWarehouse.Location = New System.Drawing.Point(3, 44)
        Me.RadLabel_StagingWarehouse.Name = "RadLabel_StagingWarehouse"
        Me.RadLabel_StagingWarehouse.Size = New System.Drawing.Size(173, 25)
        Me.RadLabel_StagingWarehouse.TabIndex = 39
        Me.RadLabel_StagingWarehouse.Text = "PiecePart_StagingWarehouse"
        Me.RadLabel_StagingWarehouse.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_StagingWarehouse.TextWrap = False
        Me.RadLabel_StagingWarehouse.ThemeName = "Windows8"
        '
        'RadLabel_FirstOp
        '
        Me.RadLabel_FirstOp.AutoSize = False
        Me.RadLabel_FirstOp.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_FirstOp.Location = New System.Drawing.Point(3, 13)
        Me.RadLabel_FirstOp.Name = "RadLabel_FirstOp"
        Me.RadLabel_FirstOp.Size = New System.Drawing.Size(173, 25)
        Me.RadLabel_FirstOp.TabIndex = 38
        Me.RadLabel_FirstOp.Text = "PiecePart_FirstOp"
        Me.RadLabel_FirstOp.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_FirstOp.TextWrap = False
        Me.RadLabel_FirstOp.ThemeName = "Windows8"
        '
        'RadTextBox_BackflushWarehouse
        '
        Me.RadTextBox_BackflushWarehouse.AutoSize = False
        Me.RadTextBox_BackflushWarehouse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_BackflushWarehouse.Location = New System.Drawing.Point(182, 75)
        Me.RadTextBox_BackflushWarehouse.Name = "RadTextBox_BackflushWarehouse"
        Me.RadTextBox_BackflushWarehouse.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_BackflushWarehouse.TabIndex = 37
        Me.RadTextBox_BackflushWarehouse.ThemeName = "Windows8"
        '
        'RadTextBox_StagingWarehouse
        '
        Me.RadTextBox_StagingWarehouse.AutoSize = False
        Me.RadTextBox_StagingWarehouse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_StagingWarehouse.Location = New System.Drawing.Point(182, 44)
        Me.RadTextBox_StagingWarehouse.Name = "RadTextBox_StagingWarehouse"
        Me.RadTextBox_StagingWarehouse.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_StagingWarehouse.TabIndex = 36
        Me.RadTextBox_StagingWarehouse.ThemeName = "Windows8"
        '
        'RadTextBox_FirstOp
        '
        Me.RadTextBox_FirstOp.AutoSize = False
        Me.RadTextBox_FirstOp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_FirstOp.Location = New System.Drawing.Point(182, 13)
        Me.RadTextBox_FirstOp.Name = "RadTextBox_FirstOp"
        Me.RadTextBox_FirstOp.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_FirstOp.TabIndex = 35
        Me.RadTextBox_FirstOp.ThemeName = "Windows8"
        '
        'RadLabel_Function
        '
        Me.RadLabel_Function.AutoSize = False
        Me.RadLabel_Function.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Function.ForeColor = System.Drawing.Color.Red
        Me.RadLabel_Function.Location = New System.Drawing.Point(722, 359)
        Me.RadLabel_Function.Name = "RadLabel_Function"
        Me.RadLabel_Function.Size = New System.Drawing.Size(287, 24)
        Me.RadLabel_Function.TabIndex = 46
        Me.RadLabel_Function.Text = "PiecePart_Function"
        Me.RadLabel_Function.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Function.ThemeName = "Windows8"
        '
        'RadLabel_OracleData
        '
        Me.RadLabel_OracleData.AutoSize = False
        Me.RadLabel_OracleData.BorderVisible = True
        Me.RadLabel_OracleData.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_OracleData.Location = New System.Drawing.Point(739, 147)
        Me.RadLabel_OracleData.Name = "RadLabel_OracleData"
        Me.RadLabel_OracleData.Size = New System.Drawing.Size(135, 25)
        Me.RadLabel_OracleData.TabIndex = 47
        Me.RadLabel_OracleData.Text = "PiecePart_OracleData"
        Me.RadLabel_OracleData.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel_OracleData.TextWrap = False
        Me.RadLabel_OracleData.ThemeName = "Windows8"
        '
        'RadTextBox_CostBase
        '
        Me.RadTextBox_CostBase.AutoSize = False
        Me.RadTextBox_CostBase.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox_CostBase.Location = New System.Drawing.Point(287, 389)
        Me.RadTextBox_CostBase.Name = "RadTextBox_CostBase"
        Me.RadTextBox_CostBase.Size = New System.Drawing.Size(90, 25)
        Me.RadTextBox_CostBase.TabIndex = 34
        Me.RadTextBox_CostBase.ThemeName = "Windows8"
        '
        'PiecePartData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1021, 519)
        Me.Controls.Add(Me.RadLabel_OracleData)
        Me.Controls.Add(Me.RadLabel_Function)
        Me.Controls.Add(Me.Panel_OracleData)
        Me.Controls.Add(Me.RadButton_AddAField)
        Me.Controls.Add(Me.Panel_Suppliers)
        Me.Controls.Add(Me.RadGridView_Grid)
        Me.Controls.Add(Me.RadTextBox_PreviousCostSource)
        Me.Controls.Add(Me.RadTextBox_CurrentCostSource)
        Me.Controls.Add(Me.RadTextBox_PreviousCost)
        Me.Controls.Add(Me.RadLabel_PreviousCost)
        Me.Controls.Add(Me.RadTextBox_CurrentCost)
        Me.Controls.Add(Me.RadLabel_CurrentCost)
        Me.Controls.Add(Me.RadTextBox_CostBaseOld)
        Me.Controls.Add(Me.RadTextBox_CostBase)
        Me.Controls.Add(Me.RadLabel_ExampleNP)
        Me.Controls.Add(Me.RadTextBox_MSpecNo)
        Me.Controls.Add(Me.RadLabel_MSpecNo)
        Me.Controls.Add(Me.RadTextBox_DrawingNumber)
        Me.Controls.Add(Me.RadLabel_DrawingNumber)
        Me.Controls.Add(Me.RadTextBox_Data)
        Me.Controls.Add(Me.RadLabel_Data)
        Me.Controls.Add(Me.RadTextBox_UnitOfMeasure)
        Me.Controls.Add(Me.RadLabel_UnitOfMeasure)
        Me.Controls.Add(Me.RadTextBox_Specification)
        Me.Controls.Add(Me.RadLabel_Specification)
        Me.Controls.Add(Me.RadTextBox_ShortDesc)
        Me.Controls.Add(Me.RadLabel_ShortDesc)
        Me.Controls.Add(Me.RadTextBox__Description)
        Me.Controls.Add(Me.RadLabel_Description)
        Me.Controls.Add(Me.RadCheckBox_Obsolete)
        Me.Controls.Add(Me.RadCheckBox_Active)
        Me.Controls.Add(Me.RadDropDownList_Type)
        Me.Controls.Add(Me.RadLabel_Type)
        Me.Controls.Add(Me.RadDropDownList_PiecePartNo)
        Me.Controls.Add(Me.RadLabel_PiecePartNo)
        Me.Controls.Add(Me.Panel_Header)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1029, 552)
        Me.MinimumSize = New System.Drawing.Size(1029, 552)
        Me.Name = "PiecePartData"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(1029, 552)
        Me.Text = "PiecePart_TitleWindow"
        Me.ThemeName = "Windows8"
        Me.Panel_Header.ResumeLayout(False)
        CType(Me.RadButton_DeletePart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_CopyAsNewRecord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_WhereUsed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_PiecePartNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PiecePartNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Type, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_Type, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_Active, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_Obsolete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox__Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_ShortDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ShortDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Specification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Specification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_UnitOfMeasure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_UnitOfMeasure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_DrawingNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_DrawingNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_MSpecNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_MSpecNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_ExampleNP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CostBaseOld, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_PreviousCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PreviousCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CurrentCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_CurrentCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CurrentCostSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_PreviousCostSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_Grid.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView_Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Suppliers.ResumeLayout(False)
        CType(Me.RadTextBox_VendorDescription3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_VendorDescription2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_VendorDescription1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Supplier3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Supplier2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Supplier1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_VendorDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_AddAField, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_OracleData.ResumeLayout(False)
        CType(Me.RadCheckBox_MultilevelBackflushFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_BackflushFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_StagingFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_BackflushWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_StagingWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_FirstOp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_BackflushWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_StagingWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_FirstOp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Function, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_OracleData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_CostBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Header As System.Windows.Forms.Panel
    Friend WithEvents RadButton_DeletePart As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_CopyAsNewRecord As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_WhereUsed As Telerik.WinControls.UI.RadButton
    Friend WithEvents PictureBox_KemetLogo As System.Windows.Forms.PictureBox
    Friend WithEvents RadLabel_Title As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_PiecePartNo As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_PiecePartNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Type As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_Type As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadCheckBox_Active As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_Obsolete As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadTextBox__Description As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Description As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_ShortDesc As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_ShortDesc As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Specification As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Specification As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Data As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_UnitOfMeasure As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_UnitOfMeasure As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Data As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_DrawingNumber As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_DrawingNumber As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_MSpecNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_MSpecNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_ExampleNP As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_CostBaseOld As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_PreviousCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_PreviousCost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_CurrentCost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_CurrentCost As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_CurrentCostSource As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_PreviousCostSource As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadGridView_Grid As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Panel_Suppliers As System.Windows.Forms.Panel
    Friend WithEvents RadButton_AddAField As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel_VendorDescription As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_Supplier As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel_OracleData As System.Windows.Forms.Panel
    Friend WithEvents RadTextBox_VendorDescription3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_VendorDescription2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_VendorDescription1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Supplier3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Supplier2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Supplier1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Function As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_OracleData As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_CostBase As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_BackflushWarehouse As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_StagingWarehouse As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_FirstOp As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadCheckBox_MultilevelBackflushFlag As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_BackflushFlag As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox_StagingFlag As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel_BackflushWarehouse As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_StagingWarehouse As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_FirstOp As Telerik.WinControls.UI.RadLabel
End Class

