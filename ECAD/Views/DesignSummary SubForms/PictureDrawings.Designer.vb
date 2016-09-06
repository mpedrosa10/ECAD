<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PictureDrawings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PictureDrawings))
        Me.Panel_Header = New System.Windows.Forms.Panel()
        Me.RadTextBox_From = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_To = New Telerik.WinControls.UI.RadTextBox()
        Me.PictureBox_KemetLogo = New System.Windows.Forms.PictureBox()
        Me.RadLabel_Title = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_PictureReference = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList_PictureReference = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_Description = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox_Description = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox_Path = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel_Path = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel_DesignPicture = New Telerik.WinControls.UI.RadLabel()
        Me.PictureBox_Image = New System.Windows.Forms.PictureBox()
        Me.RadCheckBox_LimitScanToCurrentType = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadDropDownList_QuickScan = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel_QuickScan = New Telerik.WinControls.UI.RadLabel()
        Me.RadCheckBox_Obsolete = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadButton_ToThumbnails = New Telerik.WinControls.UI.RadButton()
        Me.object_596c9d5c_39e6_4d9f_ad08_fa0f4418cfee = New Telerik.WinControls.RootRadElement()
        Me.RadGroupBox_TypeOfDrawing = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadRadioButton_Winding = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButton_Specification = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButton_Dimensions = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadGroupBox_PictureMode = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadButton_Zoom = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Stretch = New Telerik.WinControls.UI.RadButton()
        Me.RadButton_Clip = New Telerik.WinControls.UI.RadButton()
        Me.Panel_Header.SuspendLayout()
        CType(Me.RadTextBox_From, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_To, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_PictureReference, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_PictureReference, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox_Path, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_Path, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_DesignPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_LimitScanToCurrentType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList_QuickScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel_QuickScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox_Obsolete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_ToThumbnails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox_TypeOfDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox_TypeOfDrawing.SuspendLayout()
        CType(Me.RadRadioButton_Winding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton_Specification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton_Dimensions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox_PictureMode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox_PictureMode.SuspendLayout()
        CType(Me.RadButton_Zoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Stretch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton_Clip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Header
        '
        Me.Panel_Header.BackColor = System.Drawing.Color.White
        Me.Panel_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Header.Controls.Add(Me.RadTextBox_From)
        Me.Panel_Header.Controls.Add(Me.RadTextBox_To)
        Me.Panel_Header.Controls.Add(Me.PictureBox_KemetLogo)
        Me.Panel_Header.Controls.Add(Me.RadLabel_Title)
        Me.Panel_Header.Location = New System.Drawing.Point(-2, -1)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New System.Drawing.Size(935, 70)
        Me.Panel_Header.TabIndex = 3
        '
        'RadTextBox_From
        '
        Me.RadTextBox_From.AutoSize = False
        Me.RadTextBox_From.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_From.Location = New System.Drawing.Point(272, 40)
        Me.RadTextBox_From.Name = "RadTextBox_From"
        Me.RadTextBox_From.Size = New System.Drawing.Size(100, 15)
        Me.RadTextBox_From.TabIndex = 13
        Me.RadTextBox_From.ThemeName = "Windows8"
        Me.RadTextBox_From.Visible = False
        '
        'RadTextBox_To
        '
        Me.RadTextBox_To.AutoSize = False
        Me.RadTextBox_To.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadTextBox_To.Location = New System.Drawing.Point(272, 10)
        Me.RadTextBox_To.Name = "RadTextBox_To"
        Me.RadTextBox_To.Size = New System.Drawing.Size(100, 15)
        Me.RadTextBox_To.TabIndex = 12
        Me.RadTextBox_To.ThemeName = "Windows8"
        Me.RadTextBox_To.Visible = False
        '
        'PictureBox_KemetLogo
        '
        Me.PictureBox_KemetLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox_KemetLogo.Image = Global.ECAD.My.Resources.Resources.kemet_logo_small
        Me.PictureBox_KemetLogo.Location = New System.Drawing.Point(795, 7)
        Me.PictureBox_KemetLogo.MaximumSize = New System.Drawing.Size(142, 61)
        Me.PictureBox_KemetLogo.Name = "PictureBox_KemetLogo"
        Me.PictureBox_KemetLogo.Size = New System.Drawing.Size(116, 55)
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
        Me.RadLabel_Title.Size = New System.Drawing.Size(251, 68)
        Me.RadLabel_Title.TabIndex = 0
        Me.RadLabel_Title.Text = "PictureDrawings_Title"
        Me.RadLabel_Title.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_Title.TextWrap = False
        Me.RadLabel_Title.ThemeName = "Windows8"
        '
        'RadLabel_PictureReference
        '
        Me.RadLabel_PictureReference.AutoSize = False
        Me.RadLabel_PictureReference.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.RadLabel_PictureReference.Location = New System.Drawing.Point(25, 89)
        Me.RadLabel_PictureReference.Name = "RadLabel_PictureReference"
        Me.RadLabel_PictureReference.Size = New System.Drawing.Size(183, 30)
        Me.RadLabel_PictureReference.TabIndex = 4
        Me.RadLabel_PictureReference.Text = "PictureDrawings_PictureReference"
        Me.RadLabel_PictureReference.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_PictureReference.TextWrap = False
        Me.RadLabel_PictureReference.ThemeName = "Windows8"
        '
        'RadDropDownList_PictureReference
        '
        Me.RadDropDownList_PictureReference.AutoSize = False
        Me.RadDropDownList_PictureReference.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownList_PictureReference.Location = New System.Drawing.Point(214, 89)
        Me.RadDropDownList_PictureReference.Name = "RadDropDownList_PictureReference"
        Me.RadDropDownList_PictureReference.Size = New System.Drawing.Size(456, 30)
        Me.RadDropDownList_PictureReference.TabIndex = 5
        Me.RadDropDownList_PictureReference.ThemeName = "Windows8"
        '
        'RadLabel_Description
        '
        Me.RadLabel_Description.AutoSize = False
        Me.RadLabel_Description.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Description.Location = New System.Drawing.Point(25, 135)
        Me.RadLabel_Description.Name = "RadLabel_Description"
        Me.RadLabel_Description.Size = New System.Drawing.Size(183, 25)
        Me.RadLabel_Description.TabIndex = 6
        Me.RadLabel_Description.Text = "PictureDrawings_Description"
        Me.RadLabel_Description.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Description.TextWrap = False
        Me.RadLabel_Description.ThemeName = "Windows8"
        '
        'RadTextBox_Description
        '
        Me.RadTextBox_Description.AutoSize = False
        Me.RadTextBox_Description.Location = New System.Drawing.Point(214, 135)
        Me.RadTextBox_Description.Name = "RadTextBox_Description"
        Me.RadTextBox_Description.Size = New System.Drawing.Size(255, 25)
        Me.RadTextBox_Description.TabIndex = 7
        Me.RadTextBox_Description.ThemeName = "Windows8"
        '
        'RadTextBox_Path
        '
        Me.RadTextBox_Path.AutoSize = False
        Me.RadTextBox_Path.Location = New System.Drawing.Point(214, 177)
        Me.RadTextBox_Path.Name = "RadTextBox_Path"
        Me.RadTextBox_Path.Size = New System.Drawing.Size(255, 25)
        Me.RadTextBox_Path.TabIndex = 9
        Me.RadTextBox_Path.ThemeName = "Windows8"
        '
        'RadLabel_Path
        '
        Me.RadLabel_Path.AutoSize = False
        Me.RadLabel_Path.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_Path.Location = New System.Drawing.Point(25, 177)
        Me.RadLabel_Path.Name = "RadLabel_Path"
        Me.RadLabel_Path.Size = New System.Drawing.Size(183, 25)
        Me.RadLabel_Path.TabIndex = 8
        Me.RadLabel_Path.Text = "PictureDrawings_Path"
        Me.RadLabel_Path.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_Path.TextWrap = False
        Me.RadLabel_Path.ThemeName = "Windows8"
        '
        'RadLabel_DesignPicture
        '
        Me.RadLabel_DesignPicture.AutoSize = False
        Me.RadLabel_DesignPicture.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel_DesignPicture.Location = New System.Drawing.Point(25, 223)
        Me.RadLabel_DesignPicture.Name = "RadLabel_DesignPicture"
        Me.RadLabel_DesignPicture.Size = New System.Drawing.Size(183, 25)
        Me.RadLabel_DesignPicture.TabIndex = 10
        Me.RadLabel_DesignPicture.Text = "PictureDrawings_DesignPicture"
        Me.RadLabel_DesignPicture.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadLabel_DesignPicture.TextWrap = False
        Me.RadLabel_DesignPicture.ThemeName = "Windows8"
        '
        'PictureBox_Image
        '
        Me.PictureBox_Image.BackColor = System.Drawing.Color.White
        Me.PictureBox_Image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox_Image.Location = New System.Drawing.Point(25, 254)
        Me.PictureBox_Image.Name = "PictureBox_Image"
        Me.PictureBox_Image.Size = New System.Drawing.Size(677, 346)
        Me.PictureBox_Image.TabIndex = 11
        Me.PictureBox_Image.TabStop = False
        '
        'RadCheckBox_LimitScanToCurrentType
        '
        Me.RadCheckBox_LimitScanToCurrentType.AutoSize = False
        Me.RadCheckBox_LimitScanToCurrentType.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_LimitScanToCurrentType.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadCheckBox_LimitScanToCurrentType.Location = New System.Drawing.Point(716, 94)
        Me.RadCheckBox_LimitScanToCurrentType.Name = "RadCheckBox_LimitScanToCurrentType"
        Me.RadCheckBox_LimitScanToCurrentType.Size = New System.Drawing.Size(195, 20)
        Me.RadCheckBox_LimitScanToCurrentType.TabIndex = 12
        Me.RadCheckBox_LimitScanToCurrentType.Text = "PictureDrawings_LimitScanToCurrentType"
        Me.RadCheckBox_LimitScanToCurrentType.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_LimitScanToCurrentType.ThemeName = "Windows8"
        '
        'RadDropDownList_QuickScan
        '
        Me.RadDropDownList_QuickScan.AutoSize = False
        Me.RadDropDownList_QuickScan.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadDropDownList_QuickScan.Location = New System.Drawing.Point(832, 138)
        Me.RadDropDownList_QuickScan.Name = "RadDropDownList_QuickScan"
        Me.RadDropDownList_QuickScan.Size = New System.Drawing.Size(79, 20)
        Me.RadDropDownList_QuickScan.TabIndex = 13
        Me.RadDropDownList_QuickScan.ThemeName = "Windows8"
        '
        'RadLabel_QuickScan
        '
        Me.RadLabel_QuickScan.AutoSize = False
        Me.RadLabel_QuickScan.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.RadLabel_QuickScan.Location = New System.Drawing.Point(715, 138)
        Me.RadLabel_QuickScan.Name = "RadLabel_QuickScan"
        Me.RadLabel_QuickScan.Size = New System.Drawing.Size(107, 20)
        Me.RadLabel_QuickScan.TabIndex = 14
        Me.RadLabel_QuickScan.Text = "PictureDrawings_QuickScan"
        Me.RadLabel_QuickScan.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel_QuickScan.TextWrap = False
        Me.RadLabel_QuickScan.ThemeName = "Windows8"
        '
        'RadCheckBox_Obsolete
        '
        Me.RadCheckBox_Obsolete.AutoSize = False
        Me.RadCheckBox_Obsolete.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Obsolete.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadCheckBox_Obsolete.Location = New System.Drawing.Point(715, 180)
        Me.RadCheckBox_Obsolete.Name = "RadCheckBox_Obsolete"
        Me.RadCheckBox_Obsolete.Size = New System.Drawing.Size(195, 20)
        Me.RadCheckBox_Obsolete.TabIndex = 15
        Me.RadCheckBox_Obsolete.Text = "PictureDrawings_Obsolete"
        Me.RadCheckBox_Obsolete.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadCheckBox_Obsolete.ThemeName = "Windows8"
        '
        'RadButton_ToThumbnails
        '
        Me.RadButton_ToThumbnails.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadButton_ToThumbnails.Location = New System.Drawing.Point(720, 559)
        Me.RadButton_ToThumbnails.Name = "RadButton_ToThumbnails"
        Me.RadButton_ToThumbnails.Size = New System.Drawing.Size(190, 41)
        Me.RadButton_ToThumbnails.TabIndex = 18
        Me.RadButton_ToThumbnails.Text = "PictureDrawings_ToThumbnails"
        Me.RadButton_ToThumbnails.ThemeName = "Windows8"
        '
        'object_596c9d5c_39e6_4d9f_ad08_fa0f4418cfee
        '
        Me.object_596c9d5c_39e6_4d9f_ad08_fa0f4418cfee.Name = "object_596c9d5c_39e6_4d9f_ad08_fa0f4418cfee"
        Me.object_596c9d5c_39e6_4d9f_ad08_fa0f4418cfee.StretchHorizontally = True
        Me.object_596c9d5c_39e6_4d9f_ad08_fa0f4418cfee.StretchVertically = True
        '
        'RadGroupBox_TypeOfDrawing
        '
        Me.RadGroupBox_TypeOfDrawing.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox_TypeOfDrawing.Controls.Add(Me.RadRadioButton_Winding)
        Me.RadGroupBox_TypeOfDrawing.Controls.Add(Me.RadRadioButton_Specification)
        Me.RadGroupBox_TypeOfDrawing.Controls.Add(Me.RadRadioButton_Dimensions)
        Me.RadGroupBox_TypeOfDrawing.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadGroupBox_TypeOfDrawing.HeaderText = "PictureDrawings_TypeOfDrawing"
        Me.RadGroupBox_TypeOfDrawing.Location = New System.Drawing.Point(715, 254)
        Me.RadGroupBox_TypeOfDrawing.Name = "RadGroupBox_TypeOfDrawing"
        Me.RadGroupBox_TypeOfDrawing.Size = New System.Drawing.Size(196, 137)
        Me.RadGroupBox_TypeOfDrawing.TabIndex = 19
        Me.RadGroupBox_TypeOfDrawing.Text = "PictureDrawings_TypeOfDrawing"
        Me.RadGroupBox_TypeOfDrawing.ThemeName = "Windows8"
        CType(Me.RadGroupBox_TypeOfDrawing.GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        CType(Me.RadGroupBox_TypeOfDrawing.GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        CType(Me.RadGroupBox_TypeOfDrawing.GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        CType(Me.RadGroupBox_TypeOfDrawing.GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        CType(Me.RadGroupBox_TypeOfDrawing.GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.RadGroupBox_TypeOfDrawing.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.Silver
        CType(Me.RadGroupBox_TypeOfDrawing.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.RadGroupBox_TypeOfDrawing.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        CType(Me.RadGroupBox_TypeOfDrawing.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        CType(Me.RadGroupBox_TypeOfDrawing.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        CType(Me.RadGroupBox_TypeOfDrawing.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        CType(Me.RadGroupBox_TypeOfDrawing.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        '
        'RadRadioButton_Winding
        '
        Me.RadRadioButton_Winding.AutoSize = False
        Me.RadRadioButton_Winding.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadRadioButton_Winding.Location = New System.Drawing.Point(36, 100)
        Me.RadRadioButton_Winding.Name = "RadRadioButton_Winding"
        Me.RadRadioButton_Winding.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadRadioButton_Winding.Size = New System.Drawing.Size(123, 30)
        Me.RadRadioButton_Winding.TabIndex = 2
        Me.RadRadioButton_Winding.Text = "PictureDrawings_Winding"
        Me.RadRadioButton_Winding.ThemeName = "Windows8"
        '
        'RadRadioButton_Specification
        '
        Me.RadRadioButton_Specification.AutoSize = False
        Me.RadRadioButton_Specification.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadRadioButton_Specification.Location = New System.Drawing.Point(36, 65)
        Me.RadRadioButton_Specification.Name = "RadRadioButton_Specification"
        Me.RadRadioButton_Specification.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadRadioButton_Specification.Size = New System.Drawing.Size(123, 30)
        Me.RadRadioButton_Specification.TabIndex = 1
        Me.RadRadioButton_Specification.Text = "PictureDrawings_Specification"
        Me.RadRadioButton_Specification.ThemeName = "Windows8"
        '
        'RadRadioButton_Dimensions
        '
        Me.RadRadioButton_Dimensions.AutoSize = False
        Me.RadRadioButton_Dimensions.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadRadioButton_Dimensions.Location = New System.Drawing.Point(36, 31)
        Me.RadRadioButton_Dimensions.Name = "RadRadioButton_Dimensions"
        Me.RadRadioButton_Dimensions.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadRadioButton_Dimensions.Size = New System.Drawing.Size(123, 30)
        Me.RadRadioButton_Dimensions.TabIndex = 0
        Me.RadRadioButton_Dimensions.Text = "PictureDrawings_Dimensions"
        Me.RadRadioButton_Dimensions.ThemeName = "Windows8"
        '
        'RadGroupBox_PictureMode
        '
        Me.RadGroupBox_PictureMode.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox_PictureMode.Controls.Add(Me.RadButton_Zoom)
        Me.RadGroupBox_PictureMode.Controls.Add(Me.RadButton_Stretch)
        Me.RadGroupBox_PictureMode.Controls.Add(Me.RadButton_Clip)
        Me.RadGroupBox_PictureMode.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadGroupBox_PictureMode.HeaderText = "PictureDrawings_PictureMode"
        Me.RadGroupBox_PictureMode.Location = New System.Drawing.Point(716, 406)
        Me.RadGroupBox_PictureMode.Name = "RadGroupBox_PictureMode"
        Me.RadGroupBox_PictureMode.Size = New System.Drawing.Size(196, 137)
        Me.RadGroupBox_PictureMode.TabIndex = 21
        Me.RadGroupBox_PictureMode.Text = "PictureDrawings_PictureMode"
        Me.RadGroupBox_PictureMode.ThemeName = "Windows8"
        CType(Me.RadGroupBox_PictureMode.GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        CType(Me.RadGroupBox_PictureMode.GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        CType(Me.RadGroupBox_PictureMode.GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        CType(Me.RadGroupBox_PictureMode.GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        CType(Me.RadGroupBox_PictureMode.GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.RadGroupBox_PictureMode.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.Silver
        CType(Me.RadGroupBox_PictureMode.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.RadGroupBox_PictureMode.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        CType(Me.RadGroupBox_PictureMode.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        CType(Me.RadGroupBox_PictureMode.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        CType(Me.RadGroupBox_PictureMode.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        CType(Me.RadGroupBox_PictureMode.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        '
        'RadButton_Zoom
        '
        Me.RadButton_Zoom.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadButton_Zoom.Location = New System.Drawing.Point(19, 100)
        Me.RadButton_Zoom.Name = "RadButton_Zoom"
        Me.RadButton_Zoom.Size = New System.Drawing.Size(159, 30)
        Me.RadButton_Zoom.TabIndex = 5
        Me.RadButton_Zoom.Text = "PictureDrawings_Zoom"
        Me.RadButton_Zoom.ThemeName = "Windows8"
        '
        'RadButton_Stretch
        '
        Me.RadButton_Stretch.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadButton_Stretch.Location = New System.Drawing.Point(19, 65)
        Me.RadButton_Stretch.Name = "RadButton_Stretch"
        Me.RadButton_Stretch.Size = New System.Drawing.Size(159, 30)
        Me.RadButton_Stretch.TabIndex = 4
        Me.RadButton_Stretch.Text = "PictureDrawings_Stretch"
        Me.RadButton_Stretch.ThemeName = "Windows8"
        '
        'RadButton_Clip
        '
        Me.RadButton_Clip.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadButton_Clip.Location = New System.Drawing.Point(19, 31)
        Me.RadButton_Clip.Name = "RadButton_Clip"
        Me.RadButton_Clip.Size = New System.Drawing.Size(159, 30)
        Me.RadButton_Clip.TabIndex = 3
        Me.RadButton_Clip.Text = "PictureDrawings_Clip"
        Me.RadButton_Clip.ThemeName = "Windows8"
        '
        'PictureDrawings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(932, 612)
        Me.Controls.Add(Me.RadGroupBox_PictureMode)
        Me.Controls.Add(Me.RadGroupBox_TypeOfDrawing)
        Me.Controls.Add(Me.RadButton_ToThumbnails)
        Me.Controls.Add(Me.RadCheckBox_Obsolete)
        Me.Controls.Add(Me.RadLabel_QuickScan)
        Me.Controls.Add(Me.RadDropDownList_QuickScan)
        Me.Controls.Add(Me.RadCheckBox_LimitScanToCurrentType)
        Me.Controls.Add(Me.PictureBox_Image)
        Me.Controls.Add(Me.RadLabel_DesignPicture)
        Me.Controls.Add(Me.RadTextBox_Path)
        Me.Controls.Add(Me.RadLabel_Path)
        Me.Controls.Add(Me.RadTextBox_Description)
        Me.Controls.Add(Me.RadLabel_Description)
        Me.Controls.Add(Me.RadDropDownList_PictureReference)
        Me.Controls.Add(Me.RadLabel_PictureReference)
        Me.Controls.Add(Me.Panel_Header)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(940, 645)
        Me.MinimumSize = New System.Drawing.Size(940, 645)
        Me.Name = "PictureDrawings"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(940, 645)
        Me.Text = "PictureDrawings_TitleWindow"
        Me.ThemeName = "Windows8"
        Me.Panel_Header.ResumeLayout(False)
        CType(Me.RadTextBox_From, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_To, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_KemetLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_PictureReference, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_PictureReference, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox_Path, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_Path, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_DesignPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_LimitScanToCurrentType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList_QuickScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel_QuickScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox_Obsolete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_ToThumbnails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox_TypeOfDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox_TypeOfDrawing.ResumeLayout(False)
        CType(Me.RadRadioButton_Winding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton_Specification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton_Dimensions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox_PictureMode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox_PictureMode.ResumeLayout(False)
        CType(Me.RadButton_Zoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Stretch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton_Clip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Header As System.Windows.Forms.Panel
    Friend WithEvents RadTextBox_From As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_To As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents PictureBox_KemetLogo As System.Windows.Forms.PictureBox
    Friend WithEvents RadLabel_Title As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_PictureReference As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList_PictureReference As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_Description As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox_Description As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox_Path As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel_Path As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel_DesignPicture As Telerik.WinControls.UI.RadLabel
    Friend WithEvents PictureBox_Image As System.Windows.Forms.PictureBox
    Friend WithEvents RadCheckBox_LimitScanToCurrentType As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadDropDownList_QuickScan As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel_QuickScan As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadCheckBox_Obsolete As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadButton_ToThumbnails As Telerik.WinControls.UI.RadButton
    Friend WithEvents object_596c9d5c_39e6_4d9f_ad08_fa0f4418cfee As Telerik.WinControls.RootRadElement
    Friend WithEvents RadGroupBox_TypeOfDrawing As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox_PictureMode As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadButton_Zoom As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Stretch As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton_Clip As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadRadioButton_Winding As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButton_Specification As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButton_Dimensions As Telerik.WinControls.UI.RadRadioButton
End Class

