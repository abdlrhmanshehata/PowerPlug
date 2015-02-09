<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PowerPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PowerPanel))
        Me.Scont_A = New System.Windows.Forms.SplitContainer()
        Me.TLP_Alignment = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_FormatShape = New System.Windows.Forms.Button()
        Me.btn_AlignBottom = New System.Windows.Forms.Button()
        Me.btn_AlignRight = New System.Windows.Forms.Button()
        Me.btn_AlignTop = New System.Windows.Forms.Button()
        Me.btn_AlignLeft = New System.Windows.Forms.Button()
        Me.btn_DistVer = New System.Windows.Forms.Button()
        Me.btn_DistHor = New System.Windows.Forms.Button()
        Me.btn_AlignMiddle = New System.Windows.Forms.Button()
        Me.btn_AlignCenter = New System.Windows.Forms.Button()
        Me.btn_Paragraph = New System.Windows.Forms.Button()
        Me.btn_DistRows = New System.Windows.Forms.Button()
        Me.btn_DistColumns = New System.Windows.Forms.Button()
        Me.btn_BorderAll = New System.Windows.Forms.Button()
        Me.btn_BorderRight = New System.Windows.Forms.Button()
        Me.btn_BorderLeft = New System.Windows.Forms.Button()
        Me.btn_BorderBottom = New System.Windows.Forms.Button()
        Me.btn_BorderTop = New System.Windows.Forms.Button()
        Me.btn_BringForward = New System.Windows.Forms.Button()
        Me.btn_SendtoBack = New System.Windows.Forms.Button()
        Me.btn_PasteText = New System.Windows.Forms.Button()
        Me.Scont_B = New System.Windows.Forms.SplitContainer()
        Me.TabControl_Format = New System.Windows.Forms.TabControl()
        Me.TabPage_SizeProperties = New System.Windows.Forms.TabPage()
        Me.Panel_total = New System.Windows.Forms.Panel()
        Me.Scont_TextFormat = New System.Windows.Forms.SplitContainer()
        Me.chkbx_TextFormat = New System.Windows.Forms.CheckBox()
        Me.Panel_TextFormat = New System.Windows.Forms.Panel()
        Me.TLP_FormatText = New System.Windows.Forms.TableLayoutPanel()
        Me.chkbxWrap = New System.Windows.Forms.CheckBox()
        Me.Gbox_InternalMargin = New System.Windows.Forms.GroupBox()
        Me.TLP_InternalMargin = New System.Windows.Forms.TableLayoutPanel()
        Me.TLP_TopMargin = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTop = New System.Windows.Forms.Label()
        Me.num_TopMargin = New System.Windows.Forms.NumericUpDown()
        Me.TLP_LeftMargin = New System.Windows.Forms.TableLayoutPanel()
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.num_LeftMargin = New System.Windows.Forms.NumericUpDown()
        Me.TLP_RightMargin = New System.Windows.Forms.TableLayoutPanel()
        Me.lblRight = New System.Windows.Forms.Label()
        Me.num_RightMargin = New System.Windows.Forms.NumericUpDown()
        Me.TLP_BottomMargin = New System.Windows.Forms.TableLayoutPanel()
        Me.lblBottom = New System.Windows.Forms.Label()
        Me.num_BotMargin = New System.Windows.Forms.NumericUpDown()
        Me.Gbox_TextLayout = New System.Windows.Forms.GroupBox()
        Me.TLP_TextLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.lblVerticalAlignment = New System.Windows.Forms.Label()
        Me.lblTextDirection = New System.Windows.Forms.Label()
        Me.cboxtextalignment = New System.Windows.Forms.ComboBox()
        Me.cboxtextdirection = New System.Windows.Forms.ComboBox()
        Me.Gbox_AutoFit = New System.Windows.Forms.GroupBox()
        Me.TLP_AutoFit = New System.Windows.Forms.TableLayoutPanel()
        Me.ResizeShape = New System.Windows.Forms.RadioButton()
        Me.ShrinkText = New System.Windows.Forms.RadioButton()
        Me.Donotautofit = New System.Windows.Forms.RadioButton()
        Me.Scont_ShapeFormat = New System.Windows.Forms.SplitContainer()
        Me.chkbx_ShapeFormat = New System.Windows.Forms.CheckBox()
        Me.Panel_ShapeFormat = New System.Windows.Forms.Panel()
        Me.TLP_FormatShape = New System.Windows.Forms.TableLayoutPanel()
        Me.Gbox_SizeandRotate = New System.Windows.Forms.GroupBox()
        Me.TLP_SizeAndRotate = New System.Windows.Forms.TableLayoutPanel()
        Me.TLP_Rotation = New System.Windows.Forms.TableLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Size_Rotation = New System.Windows.Forms.Label()
        Me.num_Rot = New System.Windows.Forms.NumericUpDown()
        Me.TLP_Height = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Size_Height = New System.Windows.Forms.Label()
        Me.num_Height = New System.Windows.Forms.NumericUpDown()
        Me.TLP_Width = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Size_Width = New System.Windows.Forms.Label()
        Me.num_Width = New System.Windows.Forms.NumericUpDown()
        Me.Gbox_Scale = New System.Windows.Forms.GroupBox()
        Me.TLP_Scale = New System.Windows.Forms.TableLayoutPanel()
        Me.chkbx_BestScale = New System.Windows.Forms.CheckBox()
        Me.chkbx_RelativeOrig = New System.Windows.Forms.CheckBox()
        Me.chkbx_LockAspectRatio = New System.Windows.Forms.CheckBox()
        Me.TLP_ScaleDimensions = New System.Windows.Forms.TableLayoutPanel()
        Me.TLP_HeightScale = New System.Windows.Forms.TableLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Size_ScaleHeight = New System.Windows.Forms.Label()
        Me.num_ScaleHeight = New System.Windows.Forms.NumericUpDown()
        Me.TLP_WidthScale = New System.Windows.Forms.TableLayoutPanel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Size_ScaleWidth = New System.Windows.Forms.Label()
        Me.num_ScaleWidth = New System.Windows.Forms.NumericUpDown()
        Me.Gbox_OriginalSize = New System.Windows.Forms.GroupBox()
        Me.TLP_OriginalSize = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_ResetOriginalSize = New System.Windows.Forms.Button()
        Me.TLP_OriginalSizeInner = New System.Windows.Forms.TableLayoutPanel()
        Me.TLP_OriginalWidth = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_OriginalWidth = New System.Windows.Forms.TextBox()
        Me.Size_OriginalWidth = New System.Windows.Forms.Label()
        Me.TLP_OriginalHeight = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_OriginalHeight = New System.Windows.Forms.TextBox()
        Me.Size_OriginalHeight = New System.Windows.Forms.Label()
        Me.btn_ShowNotes = New System.Windows.Forms.Button()
        Me.TabPage_FillAndLine = New System.Windows.Forms.TabPage()
        Me.panel_FillAndLine = New System.Windows.Forms.Panel()
        Me.Scont_Fill = New System.Windows.Forms.SplitContainer()
        Me.chkbx_Fill = New System.Windows.Forms.CheckBox()
        Me.Panel_BackgroundFill = New System.Windows.Forms.Panel()
        Me.Rbtn_BackgroundFill = New System.Windows.Forms.RadioButton()
        Me.Scont_PatternFilling = New System.Windows.Forms.SplitContainer()
        Me.Rbtn_PatternFilling = New System.Windows.Forms.RadioButton()
        Me.TLP_Ptrnfill1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TLP_Ptrnfill2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_PatternFores = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_patternBacks = New System.Windows.Forms.Button()
        Me.TLP_Patternimage = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButton43 = New System.Windows.Forms.RadioButton()
        Me.RadioButton44 = New System.Windows.Forms.RadioButton()
        Me.RadioButton45 = New System.Windows.Forms.RadioButton()
        Me.RadioButton46 = New System.Windows.Forms.RadioButton()
        Me.RadioButton47 = New System.Windows.Forms.RadioButton()
        Me.RadioButton48 = New System.Windows.Forms.RadioButton()
        Me.RadioButton37 = New System.Windows.Forms.RadioButton()
        Me.RadioButton38 = New System.Windows.Forms.RadioButton()
        Me.RadioButton39 = New System.Windows.Forms.RadioButton()
        Me.RadioButton40 = New System.Windows.Forms.RadioButton()
        Me.RadioButton41 = New System.Windows.Forms.RadioButton()
        Me.RadioButton42 = New System.Windows.Forms.RadioButton()
        Me.RadioButton31 = New System.Windows.Forms.RadioButton()
        Me.RadioButton32 = New System.Windows.Forms.RadioButton()
        Me.RadioButton33 = New System.Windows.Forms.RadioButton()
        Me.RadioButton34 = New System.Windows.Forms.RadioButton()
        Me.RadioButton35 = New System.Windows.Forms.RadioButton()
        Me.RadioButton36 = New System.Windows.Forms.RadioButton()
        Me.RadioButton25 = New System.Windows.Forms.RadioButton()
        Me.RadioButton26 = New System.Windows.Forms.RadioButton()
        Me.RadioButton27 = New System.Windows.Forms.RadioButton()
        Me.RadioButton28 = New System.Windows.Forms.RadioButton()
        Me.RadioButton29 = New System.Windows.Forms.RadioButton()
        Me.RadioButton30 = New System.Windows.Forms.RadioButton()
        Me.RadioButton19 = New System.Windows.Forms.RadioButton()
        Me.RadioButton20 = New System.Windows.Forms.RadioButton()
        Me.RadioButton21 = New System.Windows.Forms.RadioButton()
        Me.RadioButton22 = New System.Windows.Forms.RadioButton()
        Me.RadioButton23 = New System.Windows.Forms.RadioButton()
        Me.RadioButton24 = New System.Windows.Forms.RadioButton()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.RadioButton14 = New System.Windows.Forms.RadioButton()
        Me.RadioButton15 = New System.Windows.Forms.RadioButton()
        Me.RadioButton16 = New System.Windows.Forms.RadioButton()
        Me.RadioButton17 = New System.Windows.Forms.RadioButton()
        Me.RadioButton18 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Scont_TextureFill = New System.Windows.Forms.SplitContainer()
        Me.Rbtn_TextureFill = New System.Windows.Forms.RadioButton()
        Me.TLP_Texture = New System.Windows.Forms.TableLayoutPanel()
        Me.Gbox_Texture = New System.Windows.Forms.GroupBox()
        Me.TLP_InsertTxtureFrom = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_ClipboardTexture = New System.Windows.Forms.Button()
        Me.btn_FileTexture = New System.Windows.Forms.Button()
        Me.btn_TexturePreset = New System.Windows.Forms.CheckBox()
        Me.TLP_TranspTexture = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.num_TranspTexture = New System.Windows.Forms.NumericUpDown()
        Me.chkbx_RotateWithShape = New System.Windows.Forms.CheckBox()
        Me.chkbx_texture = New System.Windows.Forms.CheckBox()
        Me.Scont_TxtrVsPctr = New System.Windows.Forms.SplitContainer()
        Me.TLP_PictureFill = New System.Windows.Forms.TableLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.num_offsetleft = New System.Windows.Forms.NumericUpDown()
        Me.num_offsetright = New System.Windows.Forms.NumericUpDown()
        Me.num_offsettop = New System.Windows.Forms.NumericUpDown()
        Me.num_offsetbot = New System.Windows.Forms.NumericUpDown()
        Me.TLP_TextureFill = New System.Windows.Forms.TableLayoutPanel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.num_OffsetX = New System.Windows.Forms.NumericUpDown()
        Me.num_offsetY = New System.Windows.Forms.NumericUpDown()
        Me.num_ScaleXFill = New System.Windows.Forms.NumericUpDown()
        Me.num_ScaleYFill = New System.Windows.Forms.NumericUpDown()
        Me.cbox_AlignmentTexture = New System.Windows.Forms.ComboBox()
        Me.cbox_MirrorTexture = New System.Windows.Forms.ComboBox()
        Me.Scont_GradentFill = New System.Windows.Forms.SplitContainer()
        Me.Rbtn_Gradient = New System.Windows.Forms.RadioButton()
        Me.TLP_GradientFill = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.num_TranspGradient = New System.Windows.Forms.NumericUpDown()
        Me.btn_ColorGradientFill = New System.Windows.Forms.Button()
        Me.Scont_SolidFill = New System.Windows.Forms.SplitContainer()
        Me.Rbtn_SolidFill = New System.Windows.Forms.RadioButton()
        Me.TLP_SolidFill = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.num_Transparency = New System.Windows.Forms.NumericUpDown()
        Me.btn_SolidFillColor = New System.Windows.Forms.Button()
        Me.Panel_NoFill = New System.Windows.Forms.Panel()
        Me.Rbtn_NoFill = New System.Windows.Forms.RadioButton()
        Me.btn_ShowNotes2 = New System.Windows.Forms.Button()
        Me.Scont_C = New System.Windows.Forms.SplitContainer()
        Me.TLP_Notes = New System.Windows.Forms.TableLayoutPanel()
        Me.TLP_NotesTools1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TLP_NotesToolsinner = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_IndentInc = New System.Windows.Forms.Button()
        Me.btn_Reset = New System.Windows.Forms.Button()
        Me.btn_IndentDec = New System.Windows.Forms.Button()
        Me.btn_Bullet = New System.Windows.Forms.CheckBox()
        Me.cboxFontSize = New System.Windows.Forms.ComboBox()
        Me.cboxFontFamily = New System.Windows.Forms.ComboBox()
        Me.TLP_NotesTools2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnUnderline = New System.Windows.Forms.CheckBox()
        Me.btn_WrapText = New System.Windows.Forms.CheckBox()
        Me.btnItalic = New System.Windows.Forms.CheckBox()
        Me.btnPaste = New System.Windows.Forms.Button()
        Me.btnBold = New System.Windows.Forms.CheckBox()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnCut = New System.Windows.Forms.Button()
        Me.btnAlignRight = New System.Windows.Forms.CheckBox()
        Me.btnAlignCenter = New System.Windows.Forms.CheckBox()
        Me.btnAlignLeft = New System.Windows.Forms.CheckBox()
        Me.TLP_SHOWHIDE = New System.Windows.Forms.TableLayoutPanel()
        Me.txtNotes = New System.Windows.Forms.RichTextBox()
        Me.btn_HideNotes = New System.Windows.Forms.Button()
        Me.ColorDialog_SolidFill = New System.Windows.Forms.ColorDialog()
        Me.ImageList_Pattern = New System.Windows.Forms.ImageList(Me.components)
        Me.OpenFileDialog_PictureFill = New System.Windows.Forms.OpenFileDialog()
        Me.ImageList_Texture = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.Scont_A, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scont_A.Panel1.SuspendLayout()
        Me.Scont_A.Panel2.SuspendLayout()
        Me.Scont_A.SuspendLayout()
        Me.TLP_Alignment.SuspendLayout()
        CType(Me.Scont_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scont_B.Panel1.SuspendLayout()
        Me.Scont_B.Panel2.SuspendLayout()
        Me.Scont_B.SuspendLayout()
        Me.TabControl_Format.SuspendLayout()
        Me.TabPage_SizeProperties.SuspendLayout()
        Me.Panel_total.SuspendLayout()
        CType(Me.Scont_TextFormat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scont_TextFormat.Panel1.SuspendLayout()
        Me.Scont_TextFormat.Panel2.SuspendLayout()
        Me.Scont_TextFormat.SuspendLayout()
        Me.Panel_TextFormat.SuspendLayout()
        Me.TLP_FormatText.SuspendLayout()
        Me.Gbox_InternalMargin.SuspendLayout()
        Me.TLP_InternalMargin.SuspendLayout()
        Me.TLP_TopMargin.SuspendLayout()
        CType(Me.num_TopMargin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLP_LeftMargin.SuspendLayout()
        CType(Me.num_LeftMargin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLP_RightMargin.SuspendLayout()
        CType(Me.num_RightMargin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLP_BottomMargin.SuspendLayout()
        CType(Me.num_BotMargin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbox_TextLayout.SuspendLayout()
        Me.TLP_TextLayout.SuspendLayout()
        Me.Gbox_AutoFit.SuspendLayout()
        Me.TLP_AutoFit.SuspendLayout()
        CType(Me.Scont_ShapeFormat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scont_ShapeFormat.Panel1.SuspendLayout()
        Me.Scont_ShapeFormat.Panel2.SuspendLayout()
        Me.Scont_ShapeFormat.SuspendLayout()
        Me.Panel_ShapeFormat.SuspendLayout()
        Me.TLP_FormatShape.SuspendLayout()
        Me.Gbox_SizeandRotate.SuspendLayout()
        Me.TLP_SizeAndRotate.SuspendLayout()
        Me.TLP_Rotation.SuspendLayout()
        CType(Me.num_Rot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLP_Height.SuspendLayout()
        CType(Me.num_Height, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLP_Width.SuspendLayout()
        CType(Me.num_Width, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbox_Scale.SuspendLayout()
        Me.TLP_Scale.SuspendLayout()
        Me.TLP_ScaleDimensions.SuspendLayout()
        Me.TLP_HeightScale.SuspendLayout()
        CType(Me.num_ScaleHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLP_WidthScale.SuspendLayout()
        CType(Me.num_ScaleWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbox_OriginalSize.SuspendLayout()
        Me.TLP_OriginalSize.SuspendLayout()
        Me.TLP_OriginalSizeInner.SuspendLayout()
        Me.TLP_OriginalWidth.SuspendLayout()
        Me.TLP_OriginalHeight.SuspendLayout()
        Me.TabPage_FillAndLine.SuspendLayout()
        Me.panel_FillAndLine.SuspendLayout()
        CType(Me.Scont_Fill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scont_Fill.Panel1.SuspendLayout()
        Me.Scont_Fill.Panel2.SuspendLayout()
        Me.Scont_Fill.SuspendLayout()
        Me.Panel_BackgroundFill.SuspendLayout()
        CType(Me.Scont_PatternFilling, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scont_PatternFilling.Panel1.SuspendLayout()
        Me.Scont_PatternFilling.Panel2.SuspendLayout()
        Me.Scont_PatternFilling.SuspendLayout()
        Me.TLP_Ptrnfill1.SuspendLayout()
        Me.TLP_Ptrnfill2.SuspendLayout()
        Me.TLP_Patternimage.SuspendLayout()
        CType(Me.Scont_TextureFill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scont_TextureFill.Panel1.SuspendLayout()
        Me.Scont_TextureFill.Panel2.SuspendLayout()
        Me.Scont_TextureFill.SuspendLayout()
        Me.TLP_Texture.SuspendLayout()
        Me.Gbox_Texture.SuspendLayout()
        Me.TLP_InsertTxtureFrom.SuspendLayout()
        Me.TLP_TranspTexture.SuspendLayout()
        CType(Me.num_TranspTexture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scont_TxtrVsPctr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scont_TxtrVsPctr.Panel1.SuspendLayout()
        Me.Scont_TxtrVsPctr.Panel2.SuspendLayout()
        Me.Scont_TxtrVsPctr.SuspendLayout()
        Me.TLP_PictureFill.SuspendLayout()
        CType(Me.num_offsetleft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_offsetright, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_offsettop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_offsetbot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLP_TextureFill.SuspendLayout()
        CType(Me.num_OffsetX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_offsetY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_ScaleXFill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_ScaleYFill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scont_GradentFill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scont_GradentFill.Panel1.SuspendLayout()
        Me.Scont_GradentFill.Panel2.SuspendLayout()
        Me.Scont_GradentFill.SuspendLayout()
        Me.TLP_GradientFill.SuspendLayout()
        CType(Me.num_TranspGradient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scont_SolidFill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scont_SolidFill.Panel1.SuspendLayout()
        Me.Scont_SolidFill.Panel2.SuspendLayout()
        Me.Scont_SolidFill.SuspendLayout()
        Me.TLP_SolidFill.SuspendLayout()
        CType(Me.num_Transparency, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_NoFill.SuspendLayout()
        CType(Me.Scont_C, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scont_C.Panel1.SuspendLayout()
        Me.Scont_C.Panel2.SuspendLayout()
        Me.Scont_C.SuspendLayout()
        Me.TLP_Notes.SuspendLayout()
        Me.TLP_NotesTools1.SuspendLayout()
        Me.TLP_NotesToolsinner.SuspendLayout()
        Me.TLP_NotesTools2.SuspendLayout()
        Me.TLP_SHOWHIDE.SuspendLayout()
        Me.SuspendLayout()
        '
        'Scont_A
        '
        Me.Scont_A.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Scont_A.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Scont_A.IsSplitterFixed = True
        Me.Scont_A.Location = New System.Drawing.Point(0, 0)
        Me.Scont_A.Name = "Scont_A"
        Me.Scont_A.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Scont_A.Panel1
        '
        Me.Scont_A.Panel1.Controls.Add(Me.TLP_Alignment)
        '
        'Scont_A.Panel2
        '
        Me.Scont_A.Panel2.Controls.Add(Me.Scont_B)
        Me.Scont_A.Size = New System.Drawing.Size(276, 559)
        Me.Scont_A.SplitterDistance = 60
        Me.Scont_A.TabIndex = 0
        '
        'TLP_Alignment
        '
        Me.TLP_Alignment.BackColor = System.Drawing.SystemColors.Control
        Me.TLP_Alignment.ColumnCount = 11
        Me.TLP_Alignment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TLP_Alignment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TLP_Alignment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TLP_Alignment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TLP_Alignment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TLP_Alignment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TLP_Alignment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TLP_Alignment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TLP_Alignment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TLP_Alignment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TLP_Alignment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TLP_Alignment.Controls.Add(Me.btn_FormatShape, 8, 1)
        Me.TLP_Alignment.Controls.Add(Me.btn_AlignBottom, 7, 1)
        Me.TLP_Alignment.Controls.Add(Me.btn_AlignRight, 6, 1)
        Me.TLP_Alignment.Controls.Add(Me.btn_AlignTop, 5, 1)
        Me.TLP_Alignment.Controls.Add(Me.btn_AlignLeft, 4, 1)
        Me.TLP_Alignment.Controls.Add(Me.btn_DistVer, 3, 1)
        Me.TLP_Alignment.Controls.Add(Me.btn_DistHor, 2, 1)
        Me.TLP_Alignment.Controls.Add(Me.btn_AlignMiddle, 1, 1)
        Me.TLP_Alignment.Controls.Add(Me.btn_AlignCenter, 0, 1)
        Me.TLP_Alignment.Controls.Add(Me.btn_Paragraph, 9, 0)
        Me.TLP_Alignment.Controls.Add(Me.btn_DistRows, 8, 0)
        Me.TLP_Alignment.Controls.Add(Me.btn_DistColumns, 7, 0)
        Me.TLP_Alignment.Controls.Add(Me.btn_BorderAll, 6, 0)
        Me.TLP_Alignment.Controls.Add(Me.btn_BorderRight, 5, 0)
        Me.TLP_Alignment.Controls.Add(Me.btn_BorderLeft, 4, 0)
        Me.TLP_Alignment.Controls.Add(Me.btn_BorderBottom, 3, 0)
        Me.TLP_Alignment.Controls.Add(Me.btn_BorderTop, 2, 0)
        Me.TLP_Alignment.Controls.Add(Me.btn_BringForward, 1, 0)
        Me.TLP_Alignment.Controls.Add(Me.btn_SendtoBack, 0, 0)
        Me.TLP_Alignment.Controls.Add(Me.btn_PasteText, 10, 0)
        Me.TLP_Alignment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Alignment.Location = New System.Drawing.Point(0, 0)
        Me.TLP_Alignment.Name = "TLP_Alignment"
        Me.TLP_Alignment.RowCount = 2
        Me.TLP_Alignment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Alignment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Alignment.Size = New System.Drawing.Size(276, 60)
        Me.TLP_Alignment.TabIndex = 1
        '
        'btn_FormatShape
        '
        Me.btn_FormatShape.BackgroundImage = CType(resources.GetObject("btn_FormatShape.BackgroundImage"), System.Drawing.Image)
        Me.btn_FormatShape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_FormatShape.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_FormatShape.FlatAppearance.BorderSize = 0
        Me.btn_FormatShape.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_FormatShape.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_FormatShape.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_FormatShape.Location = New System.Drawing.Point(200, 30)
        Me.btn_FormatShape.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_FormatShape.Name = "btn_FormatShape"
        Me.btn_FormatShape.Size = New System.Drawing.Size(25, 30)
        Me.btn_FormatShape.TabIndex = 21
        Me.btn_FormatShape.UseVisualStyleBackColor = True
        '
        'btn_AlignBottom
        '
        Me.btn_AlignBottom.BackgroundImage = CType(resources.GetObject("btn_AlignBottom.BackgroundImage"), System.Drawing.Image)
        Me.btn_AlignBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_AlignBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_AlignBottom.FlatAppearance.BorderSize = 0
        Me.btn_AlignBottom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_AlignBottom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AlignBottom.Location = New System.Drawing.Point(175, 30)
        Me.btn_AlignBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_AlignBottom.Name = "btn_AlignBottom"
        Me.btn_AlignBottom.Size = New System.Drawing.Size(25, 30)
        Me.btn_AlignBottom.TabIndex = 20
        Me.btn_AlignBottom.UseVisualStyleBackColor = True
        '
        'btn_AlignRight
        '
        Me.btn_AlignRight.BackgroundImage = CType(resources.GetObject("btn_AlignRight.BackgroundImage"), System.Drawing.Image)
        Me.btn_AlignRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_AlignRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_AlignRight.FlatAppearance.BorderSize = 0
        Me.btn_AlignRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_AlignRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AlignRight.Location = New System.Drawing.Point(150, 30)
        Me.btn_AlignRight.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_AlignRight.Name = "btn_AlignRight"
        Me.btn_AlignRight.Size = New System.Drawing.Size(25, 30)
        Me.btn_AlignRight.TabIndex = 19
        Me.btn_AlignRight.UseVisualStyleBackColor = True
        '
        'btn_AlignTop
        '
        Me.btn_AlignTop.BackgroundImage = CType(resources.GetObject("btn_AlignTop.BackgroundImage"), System.Drawing.Image)
        Me.btn_AlignTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_AlignTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_AlignTop.FlatAppearance.BorderSize = 0
        Me.btn_AlignTop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_AlignTop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AlignTop.Location = New System.Drawing.Point(125, 30)
        Me.btn_AlignTop.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_AlignTop.Name = "btn_AlignTop"
        Me.btn_AlignTop.Size = New System.Drawing.Size(25, 30)
        Me.btn_AlignTop.TabIndex = 18
        Me.btn_AlignTop.UseVisualStyleBackColor = True
        '
        'btn_AlignLeft
        '
        Me.btn_AlignLeft.BackgroundImage = CType(resources.GetObject("btn_AlignLeft.BackgroundImage"), System.Drawing.Image)
        Me.btn_AlignLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_AlignLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_AlignLeft.FlatAppearance.BorderSize = 0
        Me.btn_AlignLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_AlignLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AlignLeft.Location = New System.Drawing.Point(100, 30)
        Me.btn_AlignLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_AlignLeft.Name = "btn_AlignLeft"
        Me.btn_AlignLeft.Size = New System.Drawing.Size(25, 30)
        Me.btn_AlignLeft.TabIndex = 17
        Me.btn_AlignLeft.UseVisualStyleBackColor = True
        '
        'btn_DistVer
        '
        Me.btn_DistVer.BackgroundImage = CType(resources.GetObject("btn_DistVer.BackgroundImage"), System.Drawing.Image)
        Me.btn_DistVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_DistVer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_DistVer.FlatAppearance.BorderSize = 0
        Me.btn_DistVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_DistVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_DistVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DistVer.Location = New System.Drawing.Point(75, 30)
        Me.btn_DistVer.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_DistVer.Name = "btn_DistVer"
        Me.btn_DistVer.Size = New System.Drawing.Size(25, 30)
        Me.btn_DistVer.TabIndex = 16
        Me.btn_DistVer.UseVisualStyleBackColor = True
        '
        'btn_DistHor
        '
        Me.btn_DistHor.BackgroundImage = CType(resources.GetObject("btn_DistHor.BackgroundImage"), System.Drawing.Image)
        Me.btn_DistHor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_DistHor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_DistHor.FlatAppearance.BorderSize = 0
        Me.btn_DistHor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_DistHor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_DistHor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DistHor.Location = New System.Drawing.Point(50, 30)
        Me.btn_DistHor.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_DistHor.Name = "btn_DistHor"
        Me.btn_DistHor.Size = New System.Drawing.Size(25, 30)
        Me.btn_DistHor.TabIndex = 15
        Me.btn_DistHor.UseVisualStyleBackColor = True
        '
        'btn_AlignMiddle
        '
        Me.btn_AlignMiddle.BackgroundImage = CType(resources.GetObject("btn_AlignMiddle.BackgroundImage"), System.Drawing.Image)
        Me.btn_AlignMiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_AlignMiddle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_AlignMiddle.FlatAppearance.BorderSize = 0
        Me.btn_AlignMiddle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_AlignMiddle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AlignMiddle.Location = New System.Drawing.Point(25, 30)
        Me.btn_AlignMiddle.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_AlignMiddle.Name = "btn_AlignMiddle"
        Me.btn_AlignMiddle.Size = New System.Drawing.Size(25, 30)
        Me.btn_AlignMiddle.TabIndex = 14
        Me.btn_AlignMiddle.UseVisualStyleBackColor = True
        '
        'btn_AlignCenter
        '
        Me.btn_AlignCenter.BackgroundImage = CType(resources.GetObject("btn_AlignCenter.BackgroundImage"), System.Drawing.Image)
        Me.btn_AlignCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_AlignCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_AlignCenter.FlatAppearance.BorderSize = 0
        Me.btn_AlignCenter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_AlignCenter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AlignCenter.Location = New System.Drawing.Point(0, 30)
        Me.btn_AlignCenter.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_AlignCenter.Name = "btn_AlignCenter"
        Me.btn_AlignCenter.Size = New System.Drawing.Size(25, 30)
        Me.btn_AlignCenter.TabIndex = 13
        Me.btn_AlignCenter.UseVisualStyleBackColor = True
        '
        'btn_Paragraph
        '
        Me.btn_Paragraph.BackgroundImage = CType(resources.GetObject("btn_Paragraph.BackgroundImage"), System.Drawing.Image)
        Me.btn_Paragraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Paragraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Paragraph.FlatAppearance.BorderSize = 0
        Me.btn_Paragraph.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_Paragraph.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Paragraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Paragraph.Location = New System.Drawing.Point(225, 0)
        Me.btn_Paragraph.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Paragraph.Name = "btn_Paragraph"
        Me.btn_Paragraph.Size = New System.Drawing.Size(25, 30)
        Me.btn_Paragraph.TabIndex = 11
        Me.btn_Paragraph.UseVisualStyleBackColor = True
        '
        'btn_DistRows
        '
        Me.btn_DistRows.BackgroundImage = CType(resources.GetObject("btn_DistRows.BackgroundImage"), System.Drawing.Image)
        Me.btn_DistRows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_DistRows.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_DistRows.FlatAppearance.BorderSize = 0
        Me.btn_DistRows.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_DistRows.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_DistRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DistRows.Location = New System.Drawing.Point(200, 0)
        Me.btn_DistRows.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_DistRows.Name = "btn_DistRows"
        Me.btn_DistRows.Size = New System.Drawing.Size(25, 30)
        Me.btn_DistRows.TabIndex = 10
        Me.btn_DistRows.UseVisualStyleBackColor = True
        '
        'btn_DistColumns
        '
        Me.btn_DistColumns.BackgroundImage = CType(resources.GetObject("btn_DistColumns.BackgroundImage"), System.Drawing.Image)
        Me.btn_DistColumns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_DistColumns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_DistColumns.FlatAppearance.BorderSize = 0
        Me.btn_DistColumns.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_DistColumns.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_DistColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DistColumns.Location = New System.Drawing.Point(175, 0)
        Me.btn_DistColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_DistColumns.Name = "btn_DistColumns"
        Me.btn_DistColumns.Size = New System.Drawing.Size(25, 30)
        Me.btn_DistColumns.TabIndex = 9
        Me.btn_DistColumns.UseVisualStyleBackColor = True
        '
        'btn_BorderAll
        '
        Me.btn_BorderAll.BackgroundImage = CType(resources.GetObject("btn_BorderAll.BackgroundImage"), System.Drawing.Image)
        Me.btn_BorderAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_BorderAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_BorderAll.FlatAppearance.BorderSize = 0
        Me.btn_BorderAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_BorderAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_BorderAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_BorderAll.Location = New System.Drawing.Point(150, 0)
        Me.btn_BorderAll.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_BorderAll.Name = "btn_BorderAll"
        Me.btn_BorderAll.Size = New System.Drawing.Size(25, 30)
        Me.btn_BorderAll.TabIndex = 8
        Me.btn_BorderAll.UseVisualStyleBackColor = True
        '
        'btn_BorderRight
        '
        Me.btn_BorderRight.BackgroundImage = CType(resources.GetObject("btn_BorderRight.BackgroundImage"), System.Drawing.Image)
        Me.btn_BorderRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_BorderRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_BorderRight.FlatAppearance.BorderSize = 0
        Me.btn_BorderRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_BorderRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_BorderRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_BorderRight.Location = New System.Drawing.Point(125, 0)
        Me.btn_BorderRight.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_BorderRight.Name = "btn_BorderRight"
        Me.btn_BorderRight.Size = New System.Drawing.Size(25, 30)
        Me.btn_BorderRight.TabIndex = 7
        Me.btn_BorderRight.UseVisualStyleBackColor = True
        '
        'btn_BorderLeft
        '
        Me.btn_BorderLeft.BackgroundImage = CType(resources.GetObject("btn_BorderLeft.BackgroundImage"), System.Drawing.Image)
        Me.btn_BorderLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_BorderLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_BorderLeft.FlatAppearance.BorderSize = 0
        Me.btn_BorderLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_BorderLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_BorderLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_BorderLeft.Location = New System.Drawing.Point(100, 0)
        Me.btn_BorderLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_BorderLeft.Name = "btn_BorderLeft"
        Me.btn_BorderLeft.Size = New System.Drawing.Size(25, 30)
        Me.btn_BorderLeft.TabIndex = 6
        Me.btn_BorderLeft.UseVisualStyleBackColor = True
        '
        'btn_BorderBottom
        '
        Me.btn_BorderBottom.BackgroundImage = CType(resources.GetObject("btn_BorderBottom.BackgroundImage"), System.Drawing.Image)
        Me.btn_BorderBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_BorderBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_BorderBottom.FlatAppearance.BorderSize = 0
        Me.btn_BorderBottom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_BorderBottom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_BorderBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_BorderBottom.Location = New System.Drawing.Point(75, 0)
        Me.btn_BorderBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_BorderBottom.Name = "btn_BorderBottom"
        Me.btn_BorderBottom.Size = New System.Drawing.Size(25, 30)
        Me.btn_BorderBottom.TabIndex = 5
        Me.btn_BorderBottom.UseVisualStyleBackColor = True
        '
        'btn_BorderTop
        '
        Me.btn_BorderTop.BackgroundImage = CType(resources.GetObject("btn_BorderTop.BackgroundImage"), System.Drawing.Image)
        Me.btn_BorderTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_BorderTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_BorderTop.FlatAppearance.BorderSize = 0
        Me.btn_BorderTop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_BorderTop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_BorderTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_BorderTop.Location = New System.Drawing.Point(50, 0)
        Me.btn_BorderTop.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_BorderTop.Name = "btn_BorderTop"
        Me.btn_BorderTop.Size = New System.Drawing.Size(25, 30)
        Me.btn_BorderTop.TabIndex = 4
        Me.btn_BorderTop.UseVisualStyleBackColor = True
        '
        'btn_BringForward
        '
        Me.btn_BringForward.BackgroundImage = CType(resources.GetObject("btn_BringForward.BackgroundImage"), System.Drawing.Image)
        Me.btn_BringForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_BringForward.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_BringForward.FlatAppearance.BorderSize = 0
        Me.btn_BringForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_BringForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_BringForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_BringForward.Location = New System.Drawing.Point(25, 0)
        Me.btn_BringForward.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_BringForward.Name = "btn_BringForward"
        Me.btn_BringForward.Size = New System.Drawing.Size(25, 30)
        Me.btn_BringForward.TabIndex = 3
        Me.btn_BringForward.UseVisualStyleBackColor = True
        '
        'btn_SendtoBack
        '
        Me.btn_SendtoBack.BackgroundImage = CType(resources.GetObject("btn_SendtoBack.BackgroundImage"), System.Drawing.Image)
        Me.btn_SendtoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_SendtoBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_SendtoBack.FlatAppearance.BorderSize = 0
        Me.btn_SendtoBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_SendtoBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_SendtoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SendtoBack.Location = New System.Drawing.Point(0, 0)
        Me.btn_SendtoBack.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_SendtoBack.Name = "btn_SendtoBack"
        Me.btn_SendtoBack.Size = New System.Drawing.Size(25, 30)
        Me.btn_SendtoBack.TabIndex = 2
        Me.btn_SendtoBack.UseVisualStyleBackColor = True
        '
        'btn_PasteText
        '
        Me.btn_PasteText.BackgroundImage = CType(resources.GetObject("btn_PasteText.BackgroundImage"), System.Drawing.Image)
        Me.btn_PasteText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_PasteText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_PasteText.FlatAppearance.BorderSize = 0
        Me.btn_PasteText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_PasteText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_PasteText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_PasteText.Location = New System.Drawing.Point(250, 0)
        Me.btn_PasteText.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_PasteText.Name = "btn_PasteText"
        Me.btn_PasteText.Size = New System.Drawing.Size(26, 30)
        Me.btn_PasteText.TabIndex = 12
        Me.btn_PasteText.UseVisualStyleBackColor = True
        '
        'Scont_B
        '
        Me.Scont_B.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Scont_B.Location = New System.Drawing.Point(0, 0)
        Me.Scont_B.Name = "Scont_B"
        Me.Scont_B.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Scont_B.Panel1
        '
        Me.Scont_B.Panel1.Controls.Add(Me.TabControl_Format)
        '
        'Scont_B.Panel2
        '
        Me.Scont_B.Panel2.Controls.Add(Me.Scont_C)
        Me.Scont_B.Panel2Collapsed = True
        Me.Scont_B.Size = New System.Drawing.Size(276, 495)
        Me.Scont_B.SplitterDistance = 340
        Me.Scont_B.SplitterWidth = 8
        Me.Scont_B.TabIndex = 0
        '
        'TabControl_Format
        '
        Me.TabControl_Format.Controls.Add(Me.TabPage_SizeProperties)
        Me.TabControl_Format.Controls.Add(Me.TabPage_FillAndLine)
        Me.TabControl_Format.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl_Format.Location = New System.Drawing.Point(0, 0)
        Me.TabControl_Format.Name = "TabControl_Format"
        Me.TabControl_Format.SelectedIndex = 0
        Me.TabControl_Format.Size = New System.Drawing.Size(276, 495)
        Me.TabControl_Format.TabIndex = 1
        '
        'TabPage_SizeProperties
        '
        Me.TabPage_SizeProperties.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage_SizeProperties.Controls.Add(Me.Panel_total)
        Me.TabPage_SizeProperties.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_SizeProperties.Name = "TabPage_SizeProperties"
        Me.TabPage_SizeProperties.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_SizeProperties.Size = New System.Drawing.Size(268, 469)
        Me.TabPage_SizeProperties.TabIndex = 0
        Me.TabPage_SizeProperties.Text = "Size And Properties"
        '
        'Panel_total
        '
        Me.Panel_total.AutoScroll = True
        Me.Panel_total.Controls.Add(Me.Scont_TextFormat)
        Me.Panel_total.Controls.Add(Me.Scont_ShapeFormat)
        Me.Panel_total.Controls.Add(Me.btn_ShowNotes)
        Me.Panel_total.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_total.Location = New System.Drawing.Point(3, 3)
        Me.Panel_total.Name = "Panel_total"
        Me.Panel_total.Size = New System.Drawing.Size(262, 463)
        Me.Panel_total.TabIndex = 0
        '
        'Scont_TextFormat
        '
        Me.Scont_TextFormat.Dock = System.Windows.Forms.DockStyle.Top
        Me.Scont_TextFormat.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Scont_TextFormat.IsSplitterFixed = True
        Me.Scont_TextFormat.Location = New System.Drawing.Point(0, 90)
        Me.Scont_TextFormat.Name = "Scont_TextFormat"
        Me.Scont_TextFormat.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Scont_TextFormat.Panel1
        '
        Me.Scont_TextFormat.Panel1.Controls.Add(Me.chkbx_TextFormat)
        '
        'Scont_TextFormat.Panel2
        '
        Me.Scont_TextFormat.Panel2.Controls.Add(Me.Panel_TextFormat)
        Me.Scont_TextFormat.Panel2Collapsed = True
        Me.Scont_TextFormat.Size = New System.Drawing.Size(262, 50)
        Me.Scont_TextFormat.TabIndex = 1
        '
        'chkbx_TextFormat
        '
        Me.chkbx_TextFormat.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkbx_TextFormat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkbx_TextFormat.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.chkbx_TextFormat.FlatAppearance.BorderSize = 2
        Me.chkbx_TextFormat.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkbx_TextFormat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.chkbx_TextFormat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkbx_TextFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkbx_TextFormat.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbx_TextFormat.Location = New System.Drawing.Point(0, 0)
        Me.chkbx_TextFormat.Name = "chkbx_TextFormat"
        Me.chkbx_TextFormat.Size = New System.Drawing.Size(262, 50)
        Me.chkbx_TextFormat.TabIndex = 2
        Me.chkbx_TextFormat.Text = "Text Box"
        Me.chkbx_TextFormat.UseVisualStyleBackColor = True
        '
        'Panel_TextFormat
        '
        Me.Panel_TextFormat.AutoScroll = True
        Me.Panel_TextFormat.Controls.Add(Me.TLP_FormatText)
        Me.Panel_TextFormat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_TextFormat.Location = New System.Drawing.Point(0, 0)
        Me.Panel_TextFormat.Name = "Panel_TextFormat"
        Me.Panel_TextFormat.Size = New System.Drawing.Size(150, 46)
        Me.Panel_TextFormat.TabIndex = 0
        '
        'TLP_FormatText
        '
        Me.TLP_FormatText.ColumnCount = 1
        Me.TLP_FormatText.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_FormatText.Controls.Add(Me.chkbxWrap, 0, 3)
        Me.TLP_FormatText.Controls.Add(Me.Gbox_InternalMargin, 0, 2)
        Me.TLP_FormatText.Controls.Add(Me.Gbox_TextLayout, 0, 0)
        Me.TLP_FormatText.Controls.Add(Me.Gbox_AutoFit, 0, 1)
        Me.TLP_FormatText.Dock = System.Windows.Forms.DockStyle.Top
        Me.TLP_FormatText.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLP_FormatText.Location = New System.Drawing.Point(0, 0)
        Me.TLP_FormatText.Name = "TLP_FormatText"
        Me.TLP_FormatText.RowCount = 4
        Me.TLP_FormatText.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TLP_FormatText.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_FormatText.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.TLP_FormatText.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TLP_FormatText.Size = New System.Drawing.Size(133, 424)
        Me.TLP_FormatText.TabIndex = 1
        '
        'chkbxWrap
        '
        Me.chkbxWrap.AutoSize = True
        Me.chkbxWrap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkbxWrap.Location = New System.Drawing.Point(3, 395)
        Me.chkbxWrap.Name = "chkbxWrap"
        Me.chkbxWrap.Size = New System.Drawing.Size(127, 26)
        Me.chkbxWrap.TabIndex = 0
        Me.chkbxWrap.Text = "Wrap text in shape"
        Me.chkbxWrap.UseVisualStyleBackColor = True
        '
        'Gbox_InternalMargin
        '
        Me.Gbox_InternalMargin.Controls.Add(Me.TLP_InternalMargin)
        Me.Gbox_InternalMargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gbox_InternalMargin.Location = New System.Drawing.Point(3, 225)
        Me.Gbox_InternalMargin.Name = "Gbox_InternalMargin"
        Me.Gbox_InternalMargin.Size = New System.Drawing.Size(127, 164)
        Me.Gbox_InternalMargin.TabIndex = 1
        Me.Gbox_InternalMargin.TabStop = False
        Me.Gbox_InternalMargin.Text = "Internal Margin"
        '
        'TLP_InternalMargin
        '
        Me.TLP_InternalMargin.ColumnCount = 1
        Me.TLP_InternalMargin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_InternalMargin.Controls.Add(Me.TLP_TopMargin, 0, 1)
        Me.TLP_InternalMargin.Controls.Add(Me.TLP_LeftMargin, 0, 0)
        Me.TLP_InternalMargin.Controls.Add(Me.TLP_RightMargin, 0, 2)
        Me.TLP_InternalMargin.Controls.Add(Me.TLP_BottomMargin, 0, 3)
        Me.TLP_InternalMargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_InternalMargin.Location = New System.Drawing.Point(3, 22)
        Me.TLP_InternalMargin.Name = "TLP_InternalMargin"
        Me.TLP_InternalMargin.RowCount = 4
        Me.TLP_InternalMargin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_InternalMargin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_InternalMargin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_InternalMargin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_InternalMargin.Size = New System.Drawing.Size(121, 139)
        Me.TLP_InternalMargin.TabIndex = 0
        '
        'TLP_TopMargin
        '
        Me.TLP_TopMargin.ColumnCount = 2
        Me.TLP_TopMargin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TLP_TopMargin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.TLP_TopMargin.Controls.Add(Me.lblTop, 0, 0)
        Me.TLP_TopMargin.Controls.Add(Me.num_TopMargin, 1, 0)
        Me.TLP_TopMargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_TopMargin.Location = New System.Drawing.Point(3, 37)
        Me.TLP_TopMargin.Name = "TLP_TopMargin"
        Me.TLP_TopMargin.RowCount = 1
        Me.TLP_TopMargin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_TopMargin.Size = New System.Drawing.Size(115, 28)
        Me.TLP_TopMargin.TabIndex = 3
        '
        'lblTop
        '
        Me.lblTop.AutoSize = True
        Me.lblTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTop.Location = New System.Drawing.Point(3, 0)
        Me.lblTop.Name = "lblTop"
        Me.lblTop.Size = New System.Drawing.Size(45, 28)
        Me.lblTop.TabIndex = 0
        Me.lblTop.Text = "Top :"
        Me.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'num_TopMargin
        '
        Me.num_TopMargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.num_TopMargin.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_TopMargin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.num_TopMargin.Location = New System.Drawing.Point(54, 3)
        Me.num_TopMargin.Name = "num_TopMargin"
        Me.num_TopMargin.Size = New System.Drawing.Size(58, 23)
        Me.num_TopMargin.TabIndex = 1
        '
        'TLP_LeftMargin
        '
        Me.TLP_LeftMargin.ColumnCount = 2
        Me.TLP_LeftMargin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TLP_LeftMargin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.TLP_LeftMargin.Controls.Add(Me.lblLeft, 0, 0)
        Me.TLP_LeftMargin.Controls.Add(Me.num_LeftMargin, 1, 0)
        Me.TLP_LeftMargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_LeftMargin.Location = New System.Drawing.Point(3, 3)
        Me.TLP_LeftMargin.Name = "TLP_LeftMargin"
        Me.TLP_LeftMargin.RowCount = 1
        Me.TLP_LeftMargin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_LeftMargin.Size = New System.Drawing.Size(115, 28)
        Me.TLP_LeftMargin.TabIndex = 2
        '
        'lblLeft
        '
        Me.lblLeft.AutoSize = True
        Me.lblLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLeft.Location = New System.Drawing.Point(3, 0)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(45, 28)
        Me.lblLeft.TabIndex = 0
        Me.lblLeft.Text = "Left :"
        Me.lblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'num_LeftMargin
        '
        Me.num_LeftMargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.num_LeftMargin.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_LeftMargin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.num_LeftMargin.Location = New System.Drawing.Point(54, 3)
        Me.num_LeftMargin.Name = "num_LeftMargin"
        Me.num_LeftMargin.Size = New System.Drawing.Size(58, 23)
        Me.num_LeftMargin.TabIndex = 1
        '
        'TLP_RightMargin
        '
        Me.TLP_RightMargin.ColumnCount = 2
        Me.TLP_RightMargin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TLP_RightMargin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.TLP_RightMargin.Controls.Add(Me.lblRight, 0, 0)
        Me.TLP_RightMargin.Controls.Add(Me.num_RightMargin, 1, 0)
        Me.TLP_RightMargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_RightMargin.Location = New System.Drawing.Point(3, 71)
        Me.TLP_RightMargin.Name = "TLP_RightMargin"
        Me.TLP_RightMargin.RowCount = 1
        Me.TLP_RightMargin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_RightMargin.Size = New System.Drawing.Size(115, 28)
        Me.TLP_RightMargin.TabIndex = 5
        '
        'lblRight
        '
        Me.lblRight.AutoSize = True
        Me.lblRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRight.Location = New System.Drawing.Point(3, 0)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(45, 28)
        Me.lblRight.TabIndex = 0
        Me.lblRight.Text = "Right :"
        Me.lblRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'num_RightMargin
        '
        Me.num_RightMargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.num_RightMargin.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_RightMargin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.num_RightMargin.Location = New System.Drawing.Point(54, 3)
        Me.num_RightMargin.Name = "num_RightMargin"
        Me.num_RightMargin.Size = New System.Drawing.Size(58, 23)
        Me.num_RightMargin.TabIndex = 1
        '
        'TLP_BottomMargin
        '
        Me.TLP_BottomMargin.ColumnCount = 2
        Me.TLP_BottomMargin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TLP_BottomMargin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.TLP_BottomMargin.Controls.Add(Me.lblBottom, 0, 0)
        Me.TLP_BottomMargin.Controls.Add(Me.num_BotMargin, 1, 0)
        Me.TLP_BottomMargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_BottomMargin.Location = New System.Drawing.Point(3, 105)
        Me.TLP_BottomMargin.Name = "TLP_BottomMargin"
        Me.TLP_BottomMargin.RowCount = 1
        Me.TLP_BottomMargin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_BottomMargin.Size = New System.Drawing.Size(115, 31)
        Me.TLP_BottomMargin.TabIndex = 4
        '
        'lblBottom
        '
        Me.lblBottom.AutoSize = True
        Me.lblBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBottom.Location = New System.Drawing.Point(3, 0)
        Me.lblBottom.Name = "lblBottom"
        Me.lblBottom.Size = New System.Drawing.Size(45, 31)
        Me.lblBottom.TabIndex = 0
        Me.lblBottom.Text = "Bottom :"
        Me.lblBottom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'num_BotMargin
        '
        Me.num_BotMargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.num_BotMargin.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_BotMargin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.num_BotMargin.Location = New System.Drawing.Point(54, 3)
        Me.num_BotMargin.Name = "num_BotMargin"
        Me.num_BotMargin.Size = New System.Drawing.Size(58, 23)
        Me.num_BotMargin.TabIndex = 1
        '
        'Gbox_TextLayout
        '
        Me.Gbox_TextLayout.Controls.Add(Me.TLP_TextLayout)
        Me.Gbox_TextLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gbox_TextLayout.Location = New System.Drawing.Point(3, 3)
        Me.Gbox_TextLayout.Name = "Gbox_TextLayout"
        Me.Gbox_TextLayout.Size = New System.Drawing.Size(127, 84)
        Me.Gbox_TextLayout.TabIndex = 2
        Me.Gbox_TextLayout.TabStop = False
        Me.Gbox_TextLayout.Text = "Text Layout"
        '
        'TLP_TextLayout
        '
        Me.TLP_TextLayout.ColumnCount = 2
        Me.TLP_TextLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.48201!))
        Me.TLP_TextLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.51799!))
        Me.TLP_TextLayout.Controls.Add(Me.lblVerticalAlignment, 0, 0)
        Me.TLP_TextLayout.Controls.Add(Me.lblTextDirection, 0, 1)
        Me.TLP_TextLayout.Controls.Add(Me.cboxtextalignment, 1, 0)
        Me.TLP_TextLayout.Controls.Add(Me.cboxtextdirection, 1, 1)
        Me.TLP_TextLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_TextLayout.Location = New System.Drawing.Point(3, 22)
        Me.TLP_TextLayout.Name = "TLP_TextLayout"
        Me.TLP_TextLayout.RowCount = 2
        Me.TLP_TextLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_TextLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_TextLayout.Size = New System.Drawing.Size(121, 59)
        Me.TLP_TextLayout.TabIndex = 0
        '
        'lblVerticalAlignment
        '
        Me.lblVerticalAlignment.AutoSize = True
        Me.lblVerticalAlignment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVerticalAlignment.Location = New System.Drawing.Point(3, 0)
        Me.lblVerticalAlignment.Name = "lblVerticalAlignment"
        Me.lblVerticalAlignment.Size = New System.Drawing.Size(51, 29)
        Me.lblVerticalAlignment.TabIndex = 0
        Me.lblVerticalAlignment.Text = "Vertical Alignment:"
        Me.lblVerticalAlignment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTextDirection
        '
        Me.lblTextDirection.AutoSize = True
        Me.lblTextDirection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTextDirection.Location = New System.Drawing.Point(3, 29)
        Me.lblTextDirection.Name = "lblTextDirection"
        Me.lblTextDirection.Size = New System.Drawing.Size(51, 30)
        Me.lblTextDirection.TabIndex = 1
        Me.lblTextDirection.Text = "Text Direction:"
        Me.lblTextDirection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboxtextalignment
        '
        Me.cboxtextalignment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboxtextalignment.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxtextalignment.FormattingEnabled = True
        Me.cboxtextalignment.Items.AddRange(New Object() {"Top", "Middle", "Bottom"})
        Me.cboxtextalignment.Location = New System.Drawing.Point(60, 3)
        Me.cboxtextalignment.Name = "cboxtextalignment"
        Me.cboxtextalignment.Size = New System.Drawing.Size(58, 25)
        Me.cboxtextalignment.TabIndex = 2
        '
        'cboxtextdirection
        '
        Me.cboxtextdirection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboxtextdirection.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxtextdirection.FormattingEnabled = True
        Me.cboxtextdirection.Items.AddRange(New Object() {"Horizontal", "Rotate all text 90*", "Rotate all text 270*", "Stacked"})
        Me.cboxtextdirection.Location = New System.Drawing.Point(60, 32)
        Me.cboxtextdirection.Name = "cboxtextdirection"
        Me.cboxtextdirection.Size = New System.Drawing.Size(58, 25)
        Me.cboxtextdirection.TabIndex = 3
        '
        'Gbox_AutoFit
        '
        Me.Gbox_AutoFit.Controls.Add(Me.TLP_AutoFit)
        Me.Gbox_AutoFit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gbox_AutoFit.Location = New System.Drawing.Point(3, 93)
        Me.Gbox_AutoFit.Name = "Gbox_AutoFit"
        Me.Gbox_AutoFit.Size = New System.Drawing.Size(127, 126)
        Me.Gbox_AutoFit.TabIndex = 3
        Me.Gbox_AutoFit.TabStop = False
        Me.Gbox_AutoFit.Text = "AutoFit"
        '
        'TLP_AutoFit
        '
        Me.TLP_AutoFit.ColumnCount = 1
        Me.TLP_AutoFit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_AutoFit.Controls.Add(Me.ResizeShape, 0, 2)
        Me.TLP_AutoFit.Controls.Add(Me.ShrinkText, 0, 1)
        Me.TLP_AutoFit.Controls.Add(Me.Donotautofit, 0, 0)
        Me.TLP_AutoFit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_AutoFit.Location = New System.Drawing.Point(3, 22)
        Me.TLP_AutoFit.Name = "TLP_AutoFit"
        Me.TLP_AutoFit.RowCount = 3
        Me.TLP_AutoFit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLP_AutoFit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLP_AutoFit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLP_AutoFit.Size = New System.Drawing.Size(121, 101)
        Me.TLP_AutoFit.TabIndex = 0
        '
        'ResizeShape
        '
        Me.ResizeShape.AutoSize = True
        Me.ResizeShape.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResizeShape.Location = New System.Drawing.Point(3, 69)
        Me.ResizeShape.Name = "ResizeShape"
        Me.ResizeShape.Size = New System.Drawing.Size(115, 29)
        Me.ResizeShape.TabIndex = 2
        Me.ResizeShape.TabStop = True
        Me.ResizeShape.Text = "Resize Shape to fit text"
        Me.ResizeShape.UseVisualStyleBackColor = True
        '
        'ShrinkText
        '
        Me.ShrinkText.AutoSize = True
        Me.ShrinkText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShrinkText.Location = New System.Drawing.Point(3, 36)
        Me.ShrinkText.Name = "ShrinkText"
        Me.ShrinkText.Size = New System.Drawing.Size(115, 27)
        Me.ShrinkText.TabIndex = 1
        Me.ShrinkText.TabStop = True
        Me.ShrinkText.Text = "Shrink text on overflow"
        Me.ShrinkText.UseVisualStyleBackColor = True
        '
        'Donotautofit
        '
        Me.Donotautofit.AutoSize = True
        Me.Donotautofit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Donotautofit.Location = New System.Drawing.Point(3, 3)
        Me.Donotautofit.Name = "Donotautofit"
        Me.Donotautofit.Size = New System.Drawing.Size(115, 27)
        Me.Donotautofit.TabIndex = 0
        Me.Donotautofit.TabStop = True
        Me.Donotautofit.Text = "Do not autofit"
        Me.Donotautofit.UseVisualStyleBackColor = True
        '
        'Scont_ShapeFormat
        '
        Me.Scont_ShapeFormat.Dock = System.Windows.Forms.DockStyle.Top
        Me.Scont_ShapeFormat.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Scont_ShapeFormat.IsSplitterFixed = True
        Me.Scont_ShapeFormat.Location = New System.Drawing.Point(0, 40)
        Me.Scont_ShapeFormat.Name = "Scont_ShapeFormat"
        Me.Scont_ShapeFormat.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Scont_ShapeFormat.Panel1
        '
        Me.Scont_ShapeFormat.Panel1.Controls.Add(Me.chkbx_ShapeFormat)
        '
        'Scont_ShapeFormat.Panel2
        '
        Me.Scont_ShapeFormat.Panel2.Controls.Add(Me.Panel_ShapeFormat)
        Me.Scont_ShapeFormat.Panel2Collapsed = True
        Me.Scont_ShapeFormat.Size = New System.Drawing.Size(262, 50)
        Me.Scont_ShapeFormat.TabIndex = 4
        '
        'chkbx_ShapeFormat
        '
        Me.chkbx_ShapeFormat.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkbx_ShapeFormat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkbx_ShapeFormat.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.chkbx_ShapeFormat.FlatAppearance.BorderSize = 2
        Me.chkbx_ShapeFormat.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkbx_ShapeFormat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.chkbx_ShapeFormat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkbx_ShapeFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkbx_ShapeFormat.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbx_ShapeFormat.Location = New System.Drawing.Point(0, 0)
        Me.chkbx_ShapeFormat.Name = "chkbx_ShapeFormat"
        Me.chkbx_ShapeFormat.Size = New System.Drawing.Size(262, 50)
        Me.chkbx_ShapeFormat.TabIndex = 3
        Me.chkbx_ShapeFormat.Text = "Size"
        Me.chkbx_ShapeFormat.UseVisualStyleBackColor = True
        '
        'Panel_ShapeFormat
        '
        Me.Panel_ShapeFormat.AutoScroll = True
        Me.Panel_ShapeFormat.Controls.Add(Me.TLP_FormatShape)
        Me.Panel_ShapeFormat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_ShapeFormat.Location = New System.Drawing.Point(0, 0)
        Me.Panel_ShapeFormat.Name = "Panel_ShapeFormat"
        Me.Panel_ShapeFormat.Size = New System.Drawing.Size(150, 46)
        Me.Panel_ShapeFormat.TabIndex = 0
        '
        'TLP_FormatShape
        '
        Me.TLP_FormatShape.ColumnCount = 1
        Me.TLP_FormatShape.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_FormatShape.Controls.Add(Me.Gbox_SizeandRotate, 0, 0)
        Me.TLP_FormatShape.Controls.Add(Me.Gbox_Scale, 0, 1)
        Me.TLP_FormatShape.Controls.Add(Me.Gbox_OriginalSize, 0, 2)
        Me.TLP_FormatShape.Dock = System.Windows.Forms.DockStyle.Top
        Me.TLP_FormatShape.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLP_FormatShape.Location = New System.Drawing.Point(0, 0)
        Me.TLP_FormatShape.Name = "TLP_FormatShape"
        Me.TLP_FormatShape.RowCount = 3
        Me.TLP_FormatShape.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TLP_FormatShape.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_FormatShape.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.TLP_FormatShape.Size = New System.Drawing.Size(133, 471)
        Me.TLP_FormatShape.TabIndex = 29
        '
        'Gbox_SizeandRotate
        '
        Me.Gbox_SizeandRotate.Controls.Add(Me.TLP_SizeAndRotate)
        Me.Gbox_SizeandRotate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gbox_SizeandRotate.Location = New System.Drawing.Point(3, 3)
        Me.Gbox_SizeandRotate.Name = "Gbox_SizeandRotate"
        Me.Gbox_SizeandRotate.Size = New System.Drawing.Size(127, 124)
        Me.Gbox_SizeandRotate.TabIndex = 0
        Me.Gbox_SizeandRotate.TabStop = False
        Me.Gbox_SizeandRotate.Text = "Size"
        '
        'TLP_SizeAndRotate
        '
        Me.TLP_SizeAndRotate.ColumnCount = 1
        Me.TLP_SizeAndRotate.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.28467!))
        Me.TLP_SizeAndRotate.Controls.Add(Me.TLP_Rotation, 0, 1)
        Me.TLP_SizeAndRotate.Controls.Add(Me.TLP_Height, 0, 0)
        Me.TLP_SizeAndRotate.Controls.Add(Me.TLP_Width, 0, 2)
        Me.TLP_SizeAndRotate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_SizeAndRotate.Location = New System.Drawing.Point(3, 22)
        Me.TLP_SizeAndRotate.Name = "TLP_SizeAndRotate"
        Me.TLP_SizeAndRotate.RowCount = 3
        Me.TLP_SizeAndRotate.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_SizeAndRotate.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_SizeAndRotate.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_SizeAndRotate.Size = New System.Drawing.Size(121, 99)
        Me.TLP_SizeAndRotate.TabIndex = 0
        '
        'TLP_Rotation
        '
        Me.TLP_Rotation.ColumnCount = 3
        Me.TLP_Rotation.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Rotation.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001!))
        Me.TLP_Rotation.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TLP_Rotation.Controls.Add(Me.Label11, 2, 0)
        Me.TLP_Rotation.Controls.Add(Me.Size_Rotation, 0, 0)
        Me.TLP_Rotation.Controls.Add(Me.num_Rot, 1, 0)
        Me.TLP_Rotation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Rotation.Location = New System.Drawing.Point(3, 36)
        Me.TLP_Rotation.Name = "TLP_Rotation"
        Me.TLP_Rotation.RowCount = 1
        Me.TLP_Rotation.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Rotation.Size = New System.Drawing.Size(115, 27)
        Me.TLP_Rotation.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(54, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 27)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "o"
        '
        'Size_Rotation
        '
        Me.Size_Rotation.AutoSize = True
        Me.Size_Rotation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Size_Rotation.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Size_Rotation.Location = New System.Drawing.Point(3, 0)
        Me.Size_Rotation.Name = "Size_Rotation"
        Me.Size_Rotation.Size = New System.Drawing.Size(19, 27)
        Me.Size_Rotation.TabIndex = 31
        Me.Size_Rotation.Text = "Rotation:"
        Me.Size_Rotation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'num_Rot
        '
        Me.num_Rot.DecimalPlaces = 2
        Me.num_Rot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.num_Rot.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_Rot.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.num_Rot.Location = New System.Drawing.Point(28, 3)
        Me.num_Rot.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.num_Rot.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.num_Rot.Name = "num_Rot"
        Me.num_Rot.Size = New System.Drawing.Size(20, 23)
        Me.num_Rot.TabIndex = 32
        '
        'TLP_Height
        '
        Me.TLP_Height.ColumnCount = 3
        Me.TLP_Height.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Height.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001!))
        Me.TLP_Height.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TLP_Height.Controls.Add(Me.Label1, 2, 0)
        Me.TLP_Height.Controls.Add(Me.Size_Height, 0, 0)
        Me.TLP_Height.Controls.Add(Me.num_Height, 1, 0)
        Me.TLP_Height.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Height.Location = New System.Drawing.Point(3, 3)
        Me.TLP_Height.Name = "TLP_Height"
        Me.TLP_Height.RowCount = 1
        Me.TLP_Height.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Height.Size = New System.Drawing.Size(115, 27)
        Me.TLP_Height.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 27)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = """"
        '
        'Size_Height
        '
        Me.Size_Height.AutoSize = True
        Me.Size_Height.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Size_Height.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Size_Height.Location = New System.Drawing.Point(3, 0)
        Me.Size_Height.Name = "Size_Height"
        Me.Size_Height.Size = New System.Drawing.Size(19, 27)
        Me.Size_Height.TabIndex = 31
        Me.Size_Height.Text = "Height:"
        Me.Size_Height.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'num_Height
        '
        Me.num_Height.DecimalPlaces = 2
        Me.num_Height.Dock = System.Windows.Forms.DockStyle.Fill
        Me.num_Height.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_Height.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.num_Height.Location = New System.Drawing.Point(28, 3)
        Me.num_Height.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.num_Height.Name = "num_Height"
        Me.num_Height.Size = New System.Drawing.Size(20, 23)
        Me.num_Height.TabIndex = 32
        '
        'TLP_Width
        '
        Me.TLP_Width.ColumnCount = 3
        Me.TLP_Width.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Width.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001!))
        Me.TLP_Width.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TLP_Width.Controls.Add(Me.Label9, 2, 0)
        Me.TLP_Width.Controls.Add(Me.Size_Width, 0, 0)
        Me.TLP_Width.Controls.Add(Me.num_Width, 1, 0)
        Me.TLP_Width.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Width.Location = New System.Drawing.Point(3, 69)
        Me.TLP_Width.Name = "TLP_Width"
        Me.TLP_Width.RowCount = 1
        Me.TLP_Width.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Width.Size = New System.Drawing.Size(115, 27)
        Me.TLP_Width.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(54, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 27)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = """"
        '
        'Size_Width
        '
        Me.Size_Width.AutoSize = True
        Me.Size_Width.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Size_Width.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Size_Width.Location = New System.Drawing.Point(3, 0)
        Me.Size_Width.Name = "Size_Width"
        Me.Size_Width.Size = New System.Drawing.Size(19, 27)
        Me.Size_Width.TabIndex = 31
        Me.Size_Width.Text = "Width:"
        Me.Size_Width.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'num_Width
        '
        Me.num_Width.DecimalPlaces = 2
        Me.num_Width.Dock = System.Windows.Forms.DockStyle.Fill
        Me.num_Width.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_Width.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.num_Width.Location = New System.Drawing.Point(28, 3)
        Me.num_Width.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.num_Width.Name = "num_Width"
        Me.num_Width.Size = New System.Drawing.Size(20, 23)
        Me.num_Width.TabIndex = 32
        '
        'Gbox_Scale
        '
        Me.Gbox_Scale.Controls.Add(Me.TLP_Scale)
        Me.Gbox_Scale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gbox_Scale.Location = New System.Drawing.Point(3, 133)
        Me.Gbox_Scale.Name = "Gbox_Scale"
        Me.Gbox_Scale.Size = New System.Drawing.Size(127, 210)
        Me.Gbox_Scale.TabIndex = 1
        Me.Gbox_Scale.TabStop = False
        Me.Gbox_Scale.Text = "Scale"
        '
        'TLP_Scale
        '
        Me.TLP_Scale.ColumnCount = 1
        Me.TLP_Scale.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Scale.Controls.Add(Me.chkbx_BestScale, 0, 3)
        Me.TLP_Scale.Controls.Add(Me.chkbx_RelativeOrig, 0, 2)
        Me.TLP_Scale.Controls.Add(Me.chkbx_LockAspectRatio, 0, 1)
        Me.TLP_Scale.Controls.Add(Me.TLP_ScaleDimensions, 0, 0)
        Me.TLP_Scale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Scale.Location = New System.Drawing.Point(3, 22)
        Me.TLP_Scale.Name = "TLP_Scale"
        Me.TLP_Scale.RowCount = 4
        Me.TLP_Scale.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TLP_Scale.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLP_Scale.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLP_Scale.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLP_Scale.Size = New System.Drawing.Size(121, 185)
        Me.TLP_Scale.TabIndex = 32
        '
        'chkbx_BestScale
        '
        Me.chkbx_BestScale.AutoSize = True
        Me.chkbx_BestScale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkbx_BestScale.Location = New System.Drawing.Point(3, 150)
        Me.chkbx_BestScale.Name = "chkbx_BestScale"
        Me.chkbx_BestScale.Size = New System.Drawing.Size(115, 32)
        Me.chkbx_BestScale.TabIndex = 31
        Me.chkbx_BestScale.Text = "Best scale for slideshow"
        Me.chkbx_BestScale.UseVisualStyleBackColor = True
        '
        'chkbx_RelativeOrig
        '
        Me.chkbx_RelativeOrig.AutoSize = True
        Me.chkbx_RelativeOrig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkbx_RelativeOrig.Location = New System.Drawing.Point(3, 114)
        Me.chkbx_RelativeOrig.Name = "chkbx_RelativeOrig"
        Me.chkbx_RelativeOrig.Size = New System.Drawing.Size(115, 30)
        Me.chkbx_RelativeOrig.TabIndex = 30
        Me.chkbx_RelativeOrig.Text = "Relative to original picture size"
        Me.chkbx_RelativeOrig.UseVisualStyleBackColor = True
        '
        'chkbx_LockAspectRatio
        '
        Me.chkbx_LockAspectRatio.AutoSize = True
        Me.chkbx_LockAspectRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkbx_LockAspectRatio.Location = New System.Drawing.Point(3, 78)
        Me.chkbx_LockAspectRatio.Name = "chkbx_LockAspectRatio"
        Me.chkbx_LockAspectRatio.Size = New System.Drawing.Size(115, 30)
        Me.chkbx_LockAspectRatio.TabIndex = 29
        Me.chkbx_LockAspectRatio.Text = "Lock aspect ratio"
        Me.chkbx_LockAspectRatio.UseVisualStyleBackColor = True
        '
        'TLP_ScaleDimensions
        '
        Me.TLP_ScaleDimensions.ColumnCount = 1
        Me.TLP_ScaleDimensions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_ScaleDimensions.Controls.Add(Me.TLP_HeightScale, 0, 0)
        Me.TLP_ScaleDimensions.Controls.Add(Me.TLP_WidthScale, 0, 1)
        Me.TLP_ScaleDimensions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_ScaleDimensions.Location = New System.Drawing.Point(3, 3)
        Me.TLP_ScaleDimensions.Name = "TLP_ScaleDimensions"
        Me.TLP_ScaleDimensions.RowCount = 2
        Me.TLP_ScaleDimensions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_ScaleDimensions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_ScaleDimensions.Size = New System.Drawing.Size(115, 69)
        Me.TLP_ScaleDimensions.TabIndex = 0
        '
        'TLP_HeightScale
        '
        Me.TLP_HeightScale.ColumnCount = 3
        Me.TLP_HeightScale.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_HeightScale.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_HeightScale.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TLP_HeightScale.Controls.Add(Me.Label13, 2, 0)
        Me.TLP_HeightScale.Controls.Add(Me.Size_ScaleHeight, 0, 0)
        Me.TLP_HeightScale.Controls.Add(Me.num_ScaleHeight, 1, 0)
        Me.TLP_HeightScale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_HeightScale.Location = New System.Drawing.Point(3, 3)
        Me.TLP_HeightScale.Name = "TLP_HeightScale"
        Me.TLP_HeightScale.RowCount = 1
        Me.TLP_HeightScale.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_HeightScale.Size = New System.Drawing.Size(109, 28)
        Me.TLP_HeightScale.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(85, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 28)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "%"
        '
        'Size_ScaleHeight
        '
        Me.Size_ScaleHeight.AutoSize = True
        Me.Size_ScaleHeight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Size_ScaleHeight.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Size_ScaleHeight.Location = New System.Drawing.Point(3, 0)
        Me.Size_ScaleHeight.Name = "Size_ScaleHeight"
        Me.Size_ScaleHeight.Size = New System.Drawing.Size(35, 28)
        Me.Size_ScaleHeight.TabIndex = 31
        Me.Size_ScaleHeight.Text = "Height:"
        Me.Size_ScaleHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'num_ScaleHeight
        '
        Me.num_ScaleHeight.DecimalPlaces = 2
        Me.num_ScaleHeight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.num_ScaleHeight.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_ScaleHeight.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.num_ScaleHeight.Location = New System.Drawing.Point(44, 3)
        Me.num_ScaleHeight.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.num_ScaleHeight.Name = "num_ScaleHeight"
        Me.num_ScaleHeight.Size = New System.Drawing.Size(35, 23)
        Me.num_ScaleHeight.TabIndex = 32
        '
        'TLP_WidthScale
        '
        Me.TLP_WidthScale.ColumnCount = 3
        Me.TLP_WidthScale.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_WidthScale.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_WidthScale.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TLP_WidthScale.Controls.Add(Me.Label15, 2, 0)
        Me.TLP_WidthScale.Controls.Add(Me.Size_ScaleWidth, 0, 0)
        Me.TLP_WidthScale.Controls.Add(Me.num_ScaleWidth, 1, 0)
        Me.TLP_WidthScale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_WidthScale.Location = New System.Drawing.Point(3, 37)
        Me.TLP_WidthScale.Name = "TLP_WidthScale"
        Me.TLP_WidthScale.RowCount = 1
        Me.TLP_WidthScale.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_WidthScale.Size = New System.Drawing.Size(109, 29)
        Me.TLP_WidthScale.TabIndex = 33
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(85, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 29)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "%"
        '
        'Size_ScaleWidth
        '
        Me.Size_ScaleWidth.AutoSize = True
        Me.Size_ScaleWidth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Size_ScaleWidth.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Size_ScaleWidth.Location = New System.Drawing.Point(3, 0)
        Me.Size_ScaleWidth.Name = "Size_ScaleWidth"
        Me.Size_ScaleWidth.Size = New System.Drawing.Size(35, 29)
        Me.Size_ScaleWidth.TabIndex = 31
        Me.Size_ScaleWidth.Text = "Width:"
        Me.Size_ScaleWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'num_ScaleWidth
        '
        Me.num_ScaleWidth.DecimalPlaces = 2
        Me.num_ScaleWidth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.num_ScaleWidth.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_ScaleWidth.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.num_ScaleWidth.Location = New System.Drawing.Point(44, 3)
        Me.num_ScaleWidth.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.num_ScaleWidth.Name = "num_ScaleWidth"
        Me.num_ScaleWidth.Size = New System.Drawing.Size(35, 23)
        Me.num_ScaleWidth.TabIndex = 32
        '
        'Gbox_OriginalSize
        '
        Me.Gbox_OriginalSize.Controls.Add(Me.TLP_OriginalSize)
        Me.Gbox_OriginalSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gbox_OriginalSize.Location = New System.Drawing.Point(3, 349)
        Me.Gbox_OriginalSize.Name = "Gbox_OriginalSize"
        Me.Gbox_OriginalSize.Size = New System.Drawing.Size(127, 119)
        Me.Gbox_OriginalSize.TabIndex = 2
        Me.Gbox_OriginalSize.TabStop = False
        Me.Gbox_OriginalSize.Text = "Original Size"
        '
        'TLP_OriginalSize
        '
        Me.TLP_OriginalSize.ColumnCount = 1
        Me.TLP_OriginalSize.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_OriginalSize.Controls.Add(Me.btn_ResetOriginalSize, 0, 1)
        Me.TLP_OriginalSize.Controls.Add(Me.TLP_OriginalSizeInner, 0, 0)
        Me.TLP_OriginalSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_OriginalSize.Location = New System.Drawing.Point(3, 22)
        Me.TLP_OriginalSize.Name = "TLP_OriginalSize"
        Me.TLP_OriginalSize.RowCount = 2
        Me.TLP_OriginalSize.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_OriginalSize.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_OriginalSize.Size = New System.Drawing.Size(121, 94)
        Me.TLP_OriginalSize.TabIndex = 32
        '
        'btn_ResetOriginalSize
        '
        Me.btn_ResetOriginalSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_ResetOriginalSize.Location = New System.Drawing.Point(3, 50)
        Me.btn_ResetOriginalSize.Name = "btn_ResetOriginalSize"
        Me.btn_ResetOriginalSize.Size = New System.Drawing.Size(115, 41)
        Me.btn_ResetOriginalSize.TabIndex = 0
        Me.btn_ResetOriginalSize.Text = "Reset"
        Me.btn_ResetOriginalSize.UseVisualStyleBackColor = True
        '
        'TLP_OriginalSizeInner
        '
        Me.TLP_OriginalSizeInner.ColumnCount = 2
        Me.TLP_OriginalSizeInner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_OriginalSizeInner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_OriginalSizeInner.Controls.Add(Me.TLP_OriginalWidth, 1, 0)
        Me.TLP_OriginalSizeInner.Controls.Add(Me.TLP_OriginalHeight, 0, 0)
        Me.TLP_OriginalSizeInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_OriginalSizeInner.Location = New System.Drawing.Point(3, 3)
        Me.TLP_OriginalSizeInner.Name = "TLP_OriginalSizeInner"
        Me.TLP_OriginalSizeInner.RowCount = 1
        Me.TLP_OriginalSizeInner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_OriginalSizeInner.Size = New System.Drawing.Size(115, 41)
        Me.TLP_OriginalSizeInner.TabIndex = 1
        '
        'TLP_OriginalWidth
        '
        Me.TLP_OriginalWidth.ColumnCount = 2
        Me.TLP_OriginalWidth.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.875!))
        Me.TLP_OriginalWidth.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.125!))
        Me.TLP_OriginalWidth.Controls.Add(Me.txt_OriginalWidth, 0, 0)
        Me.TLP_OriginalWidth.Controls.Add(Me.Size_OriginalWidth, 0, 0)
        Me.TLP_OriginalWidth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_OriginalWidth.Location = New System.Drawing.Point(60, 3)
        Me.TLP_OriginalWidth.Name = "TLP_OriginalWidth"
        Me.TLP_OriginalWidth.RowCount = 1
        Me.TLP_OriginalWidth.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_OriginalWidth.Size = New System.Drawing.Size(52, 35)
        Me.TLP_OriginalWidth.TabIndex = 31
        '
        'txt_OriginalWidth
        '
        Me.txt_OriginalWidth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_OriginalWidth.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_OriginalWidth.Location = New System.Drawing.Point(27, 3)
        Me.txt_OriginalWidth.Name = "txt_OriginalWidth"
        Me.txt_OriginalWidth.ReadOnly = True
        Me.txt_OriginalWidth.Size = New System.Drawing.Size(22, 25)
        Me.txt_OriginalWidth.TabIndex = 32
        '
        'Size_OriginalWidth
        '
        Me.Size_OriginalWidth.AutoSize = True
        Me.Size_OriginalWidth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Size_OriginalWidth.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Size_OriginalWidth.Location = New System.Drawing.Point(3, 0)
        Me.Size_OriginalWidth.Name = "Size_OriginalWidth"
        Me.Size_OriginalWidth.Size = New System.Drawing.Size(18, 35)
        Me.Size_OriginalWidth.TabIndex = 31
        Me.Size_OriginalWidth.Text = "Width:"
        Me.Size_OriginalWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TLP_OriginalHeight
        '
        Me.TLP_OriginalHeight.ColumnCount = 2
        Me.TLP_OriginalHeight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.09375!))
        Me.TLP_OriginalHeight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.90625!))
        Me.TLP_OriginalHeight.Controls.Add(Me.txt_OriginalHeight, 1, 0)
        Me.TLP_OriginalHeight.Controls.Add(Me.Size_OriginalHeight, 0, 0)
        Me.TLP_OriginalHeight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_OriginalHeight.Location = New System.Drawing.Point(3, 3)
        Me.TLP_OriginalHeight.Name = "TLP_OriginalHeight"
        Me.TLP_OriginalHeight.RowCount = 1
        Me.TLP_OriginalHeight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_OriginalHeight.Size = New System.Drawing.Size(51, 35)
        Me.TLP_OriginalHeight.TabIndex = 30
        '
        'txt_OriginalHeight
        '
        Me.txt_OriginalHeight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_OriginalHeight.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_OriginalHeight.Location = New System.Drawing.Point(26, 3)
        Me.txt_OriginalHeight.Name = "txt_OriginalHeight"
        Me.txt_OriginalHeight.ReadOnly = True
        Me.txt_OriginalHeight.Size = New System.Drawing.Size(22, 25)
        Me.txt_OriginalHeight.TabIndex = 29
        '
        'Size_OriginalHeight
        '
        Me.Size_OriginalHeight.AutoSize = True
        Me.Size_OriginalHeight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Size_OriginalHeight.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Size_OriginalHeight.Location = New System.Drawing.Point(3, 0)
        Me.Size_OriginalHeight.Name = "Size_OriginalHeight"
        Me.Size_OriginalHeight.Size = New System.Drawing.Size(17, 35)
        Me.Size_OriginalHeight.TabIndex = 31
        Me.Size_OriginalHeight.Text = "Height:"
        Me.Size_OriginalHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_ShowNotes
        '
        Me.btn_ShowNotes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_ShowNotes.Location = New System.Drawing.Point(0, 0)
        Me.btn_ShowNotes.Name = "btn_ShowNotes"
        Me.btn_ShowNotes.Size = New System.Drawing.Size(262, 40)
        Me.btn_ShowNotes.TabIndex = 5
        Me.btn_ShowNotes.Text = "Show Notes"
        Me.btn_ShowNotes.UseVisualStyleBackColor = True
        '
        'TabPage_FillAndLine
        '
        Me.TabPage_FillAndLine.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage_FillAndLine.Controls.Add(Me.panel_FillAndLine)
        Me.TabPage_FillAndLine.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_FillAndLine.Name = "TabPage_FillAndLine"
        Me.TabPage_FillAndLine.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_FillAndLine.Size = New System.Drawing.Size(268, 469)
        Me.TabPage_FillAndLine.TabIndex = 1
        Me.TabPage_FillAndLine.Text = "Fill And Line"
        '
        'panel_FillAndLine
        '
        Me.panel_FillAndLine.AutoScroll = True
        Me.panel_FillAndLine.Controls.Add(Me.Scont_Fill)
        Me.panel_FillAndLine.Controls.Add(Me.btn_ShowNotes2)
        Me.panel_FillAndLine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_FillAndLine.Location = New System.Drawing.Point(3, 3)
        Me.panel_FillAndLine.Name = "panel_FillAndLine"
        Me.panel_FillAndLine.Size = New System.Drawing.Size(262, 463)
        Me.panel_FillAndLine.TabIndex = 0
        '
        'Scont_Fill
        '
        Me.Scont_Fill.Dock = System.Windows.Forms.DockStyle.Top
        Me.Scont_Fill.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Scont_Fill.IsSplitterFixed = True
        Me.Scont_Fill.Location = New System.Drawing.Point(0, 40)
        Me.Scont_Fill.Name = "Scont_Fill"
        Me.Scont_Fill.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Scont_Fill.Panel1
        '
        Me.Scont_Fill.Panel1.Controls.Add(Me.chkbx_Fill)
        '
        'Scont_Fill.Panel2
        '
        Me.Scont_Fill.Panel2.AutoScroll = True
        Me.Scont_Fill.Panel2.Controls.Add(Me.Panel_BackgroundFill)
        Me.Scont_Fill.Panel2.Controls.Add(Me.Scont_PatternFilling)
        Me.Scont_Fill.Panel2.Controls.Add(Me.Scont_TextureFill)
        Me.Scont_Fill.Panel2.Controls.Add(Me.Scont_GradentFill)
        Me.Scont_Fill.Panel2.Controls.Add(Me.Scont_SolidFill)
        Me.Scont_Fill.Panel2.Controls.Add(Me.Panel_NoFill)
        Me.Scont_Fill.Size = New System.Drawing.Size(245, 450)
        Me.Scont_Fill.TabIndex = 0
        '
        'chkbx_Fill
        '
        Me.chkbx_Fill.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkbx_Fill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkbx_Fill.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.chkbx_Fill.FlatAppearance.BorderSize = 2
        Me.chkbx_Fill.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkbx_Fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.chkbx_Fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkbx_Fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkbx_Fill.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbx_Fill.Location = New System.Drawing.Point(0, 0)
        Me.chkbx_Fill.Name = "chkbx_Fill"
        Me.chkbx_Fill.Size = New System.Drawing.Size(245, 50)
        Me.chkbx_Fill.TabIndex = 0
        Me.chkbx_Fill.Text = "F i l l"
        Me.chkbx_Fill.UseVisualStyleBackColor = True
        '
        'Panel_BackgroundFill
        '
        Me.Panel_BackgroundFill.Controls.Add(Me.Rbtn_BackgroundFill)
        Me.Panel_BackgroundFill.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_BackgroundFill.Location = New System.Drawing.Point(0, 600)
        Me.Panel_BackgroundFill.Name = "Panel_BackgroundFill"
        Me.Panel_BackgroundFill.Size = New System.Drawing.Size(228, 50)
        Me.Panel_BackgroundFill.TabIndex = 4
        '
        'Rbtn_BackgroundFill
        '
        Me.Rbtn_BackgroundFill.AutoCheck = False
        Me.Rbtn_BackgroundFill.AutoSize = True
        Me.Rbtn_BackgroundFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Rbtn_BackgroundFill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Rbtn_BackgroundFill.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbtn_BackgroundFill.Location = New System.Drawing.Point(0, 0)
        Me.Rbtn_BackgroundFill.Name = "Rbtn_BackgroundFill"
        Me.Rbtn_BackgroundFill.Size = New System.Drawing.Size(228, 50)
        Me.Rbtn_BackgroundFill.TabIndex = 3
        Me.Rbtn_BackgroundFill.TabStop = True
        Me.Rbtn_BackgroundFill.Text = "Slide BackGround Fill"
        Me.Rbtn_BackgroundFill.UseVisualStyleBackColor = True
        '
        'Scont_PatternFilling
        '
        Me.Scont_PatternFilling.Dock = System.Windows.Forms.DockStyle.Top
        Me.Scont_PatternFilling.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Scont_PatternFilling.Location = New System.Drawing.Point(0, 550)
        Me.Scont_PatternFilling.Name = "Scont_PatternFilling"
        Me.Scont_PatternFilling.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Scont_PatternFilling.Panel1
        '
        Me.Scont_PatternFilling.Panel1.Controls.Add(Me.Rbtn_PatternFilling)
        '
        'Scont_PatternFilling.Panel2
        '
        Me.Scont_PatternFilling.Panel2.Controls.Add(Me.TLP_Ptrnfill1)
        Me.Scont_PatternFilling.Panel2Collapsed = True
        Me.Scont_PatternFilling.Size = New System.Drawing.Size(228, 50)
        Me.Scont_PatternFilling.TabIndex = 3
        '
        'Rbtn_PatternFilling
        '
        Me.Rbtn_PatternFilling.AutoSize = True
        Me.Rbtn_PatternFilling.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Rbtn_PatternFilling.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Rbtn_PatternFilling.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbtn_PatternFilling.Location = New System.Drawing.Point(0, 0)
        Me.Rbtn_PatternFilling.Name = "Rbtn_PatternFilling"
        Me.Rbtn_PatternFilling.Size = New System.Drawing.Size(228, 50)
        Me.Rbtn_PatternFilling.TabIndex = 0
        Me.Rbtn_PatternFilling.Text = "Pattern fill"
        Me.Rbtn_PatternFilling.UseVisualStyleBackColor = True
        '
        'TLP_Ptrnfill1
        '
        Me.TLP_Ptrnfill1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.TLP_Ptrnfill1.ColumnCount = 1
        Me.TLP_Ptrnfill1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Ptrnfill1.Controls.Add(Me.TLP_Ptrnfill2, 0, 1)
        Me.TLP_Ptrnfill1.Controls.Add(Me.TLP_Patternimage, 0, 0)
        Me.TLP_Ptrnfill1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Ptrnfill1.Location = New System.Drawing.Point(0, 0)
        Me.TLP_Ptrnfill1.Name = "TLP_Ptrnfill1"
        Me.TLP_Ptrnfill1.RowCount = 2
        Me.TLP_Ptrnfill1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Ptrnfill1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TLP_Ptrnfill1.Size = New System.Drawing.Size(150, 46)
        Me.TLP_Ptrnfill1.TabIndex = 0
        '
        'TLP_Ptrnfill2
        '
        Me.TLP_Ptrnfill2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TLP_Ptrnfill2.ColumnCount = 2
        Me.TLP_Ptrnfill2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TLP_Ptrnfill2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Ptrnfill2.Controls.Add(Me.btn_PatternFores, 1, 1)
        Me.TLP_Ptrnfill2.Controls.Add(Me.Label6, 0, 0)
        Me.TLP_Ptrnfill2.Controls.Add(Me.Label7, 0, 1)
        Me.TLP_Ptrnfill2.Controls.Add(Me.btn_patternBacks, 1, 0)
        Me.TLP_Ptrnfill2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Ptrnfill2.Location = New System.Drawing.Point(6, -19)
        Me.TLP_Ptrnfill2.Name = "TLP_Ptrnfill2"
        Me.TLP_Ptrnfill2.RowCount = 2
        Me.TLP_Ptrnfill2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Ptrnfill2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Ptrnfill2.Size = New System.Drawing.Size(138, 59)
        Me.TLP_Ptrnfill2.TabIndex = 0
        '
        'btn_PatternFores
        '
        Me.btn_PatternFores.BackgroundImage = CType(resources.GetObject("btn_PatternFores.BackgroundImage"), System.Drawing.Image)
        Me.btn_PatternFores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_PatternFores.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_PatternFores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_PatternFores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_PatternFores.Location = New System.Drawing.Point(98, 33)
        Me.btn_PatternFores.Name = "btn_PatternFores"
        Me.btn_PatternFores.Size = New System.Drawing.Size(35, 21)
        Me.btn_PatternFores.TabIndex = 3
        Me.btn_PatternFores.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 26)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "BackGround :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 27)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ForeGround :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_patternBacks
        '
        Me.btn_patternBacks.BackgroundImage = CType(resources.GetObject("btn_patternBacks.BackgroundImage"), System.Drawing.Image)
        Me.btn_patternBacks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_patternBacks.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_patternBacks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_patternBacks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_patternBacks.Location = New System.Drawing.Point(98, 5)
        Me.btn_patternBacks.Name = "btn_patternBacks"
        Me.btn_patternBacks.Size = New System.Drawing.Size(35, 20)
        Me.btn_patternBacks.TabIndex = 2
        Me.btn_patternBacks.UseVisualStyleBackColor = True
        '
        'TLP_Patternimage
        '
        Me.TLP_Patternimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TLP_Patternimage.ColumnCount = 6
        Me.TLP_Patternimage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TLP_Patternimage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TLP_Patternimage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TLP_Patternimage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TLP_Patternimage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TLP_Patternimage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton43, 0, 7)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton44, 1, 7)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton45, 2, 7)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton46, 3, 7)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton47, 4, 7)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton48, 5, 7)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton37, 0, 6)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton38, 1, 6)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton39, 2, 6)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton40, 3, 6)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton41, 4, 6)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton42, 5, 6)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton31, 0, 5)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton32, 1, 5)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton33, 2, 5)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton34, 3, 5)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton35, 4, 5)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton36, 5, 5)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton25, 0, 4)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton26, 1, 4)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton27, 2, 4)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton28, 3, 4)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton29, 4, 4)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton30, 5, 4)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton19, 0, 3)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton20, 1, 3)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton21, 2, 3)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton22, 3, 3)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton23, 4, 3)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton24, 5, 3)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton13, 0, 2)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton14, 1, 2)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton15, 2, 2)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton16, 3, 2)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton17, 4, 2)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton18, 5, 2)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton7, 0, 1)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton8, 1, 1)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton9, 2, 1)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton10, 3, 1)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton11, 4, 1)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton12, 5, 1)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton6, 5, 0)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton5, 4, 0)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton4, 3, 0)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton3, 2, 0)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton2, 1, 0)
        Me.TLP_Patternimage.Controls.Add(Me.RadioButton1, 0, 0)
        Me.TLP_Patternimage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Patternimage.Location = New System.Drawing.Point(6, 6)
        Me.TLP_Patternimage.Name = "TLP_Patternimage"
        Me.TLP_Patternimage.RowCount = 8
        Me.TLP_Patternimage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TLP_Patternimage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TLP_Patternimage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TLP_Patternimage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TLP_Patternimage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TLP_Patternimage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TLP_Patternimage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TLP_Patternimage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TLP_Patternimage.Size = New System.Drawing.Size(138, 1)
        Me.TLP_Patternimage.TabIndex = 1
        '
        'RadioButton43
        '
        Me.RadioButton43.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton43.BackgroundImage = CType(resources.GetObject("RadioButton43.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton43.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton43.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton43.FlatAppearance.BorderSize = 0
        Me.RadioButton43.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton43.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton43.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton43.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton43.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton43.Name = "RadioButton43"
        Me.RadioButton43.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton43.TabIndex = 47
        Me.RadioButton43.TabStop = True
        Me.RadioButton43.UseVisualStyleBackColor = True
        '
        'RadioButton44
        '
        Me.RadioButton44.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton44.BackgroundImage = CType(resources.GetObject("RadioButton44.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton44.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton44.FlatAppearance.BorderSize = 0
        Me.RadioButton44.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton44.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton44.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton44.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton44.Location = New System.Drawing.Point(25, 3)
        Me.RadioButton44.Name = "RadioButton44"
        Me.RadioButton44.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton44.TabIndex = 46
        Me.RadioButton44.TabStop = True
        Me.RadioButton44.UseVisualStyleBackColor = True
        '
        'RadioButton45
        '
        Me.RadioButton45.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton45.BackgroundImage = CType(resources.GetObject("RadioButton45.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton45.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton45.FlatAppearance.BorderSize = 0
        Me.RadioButton45.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton45.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton45.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton45.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton45.Location = New System.Drawing.Point(47, 3)
        Me.RadioButton45.Name = "RadioButton45"
        Me.RadioButton45.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton45.TabIndex = 45
        Me.RadioButton45.TabStop = True
        Me.RadioButton45.UseVisualStyleBackColor = True
        '
        'RadioButton46
        '
        Me.RadioButton46.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton46.BackgroundImage = CType(resources.GetObject("RadioButton46.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton46.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton46.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton46.FlatAppearance.BorderSize = 0
        Me.RadioButton46.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton46.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton46.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton46.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton46.Location = New System.Drawing.Point(69, 3)
        Me.RadioButton46.Name = "RadioButton46"
        Me.RadioButton46.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton46.TabIndex = 44
        Me.RadioButton46.TabStop = True
        Me.RadioButton46.UseVisualStyleBackColor = True
        '
        'RadioButton47
        '
        Me.RadioButton47.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton47.BackgroundImage = CType(resources.GetObject("RadioButton47.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton47.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton47.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton47.FlatAppearance.BorderSize = 0
        Me.RadioButton47.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton47.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton47.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton47.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton47.Location = New System.Drawing.Point(91, 3)
        Me.RadioButton47.Name = "RadioButton47"
        Me.RadioButton47.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton47.TabIndex = 43
        Me.RadioButton47.TabStop = True
        Me.RadioButton47.UseVisualStyleBackColor = True
        '
        'RadioButton48
        '
        Me.RadioButton48.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton48.BackgroundImage = CType(resources.GetObject("RadioButton48.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton48.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton48.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton48.FlatAppearance.BorderSize = 0
        Me.RadioButton48.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton48.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton48.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton48.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton48.Location = New System.Drawing.Point(113, 3)
        Me.RadioButton48.Name = "RadioButton48"
        Me.RadioButton48.Size = New System.Drawing.Size(22, 1)
        Me.RadioButton48.TabIndex = 42
        Me.RadioButton48.TabStop = True
        Me.RadioButton48.UseVisualStyleBackColor = True
        '
        'RadioButton37
        '
        Me.RadioButton37.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton37.BackgroundImage = CType(resources.GetObject("RadioButton37.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton37.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton37.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton37.FlatAppearance.BorderSize = 0
        Me.RadioButton37.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton37.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton37.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton37.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton37.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton37.Name = "RadioButton37"
        Me.RadioButton37.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton37.TabIndex = 41
        Me.RadioButton37.TabStop = True
        Me.RadioButton37.UseVisualStyleBackColor = True
        '
        'RadioButton38
        '
        Me.RadioButton38.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton38.BackgroundImage = CType(resources.GetObject("RadioButton38.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton38.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton38.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton38.FlatAppearance.BorderSize = 0
        Me.RadioButton38.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton38.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton38.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton38.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton38.Location = New System.Drawing.Point(25, 3)
        Me.RadioButton38.Name = "RadioButton38"
        Me.RadioButton38.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton38.TabIndex = 40
        Me.RadioButton38.TabStop = True
        Me.RadioButton38.UseVisualStyleBackColor = True
        '
        'RadioButton39
        '
        Me.RadioButton39.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton39.BackgroundImage = CType(resources.GetObject("RadioButton39.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton39.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton39.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton39.FlatAppearance.BorderSize = 0
        Me.RadioButton39.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton39.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton39.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton39.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton39.Location = New System.Drawing.Point(47, 3)
        Me.RadioButton39.Name = "RadioButton39"
        Me.RadioButton39.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton39.TabIndex = 39
        Me.RadioButton39.TabStop = True
        Me.RadioButton39.UseVisualStyleBackColor = True
        '
        'RadioButton40
        '
        Me.RadioButton40.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton40.BackgroundImage = CType(resources.GetObject("RadioButton40.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton40.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton40.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton40.FlatAppearance.BorderSize = 0
        Me.RadioButton40.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton40.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton40.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton40.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton40.Location = New System.Drawing.Point(69, 3)
        Me.RadioButton40.Name = "RadioButton40"
        Me.RadioButton40.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton40.TabIndex = 38
        Me.RadioButton40.TabStop = True
        Me.RadioButton40.UseVisualStyleBackColor = True
        '
        'RadioButton41
        '
        Me.RadioButton41.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton41.BackgroundImage = CType(resources.GetObject("RadioButton41.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton41.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton41.FlatAppearance.BorderSize = 0
        Me.RadioButton41.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton41.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton41.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton41.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton41.Location = New System.Drawing.Point(91, 3)
        Me.RadioButton41.Name = "RadioButton41"
        Me.RadioButton41.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton41.TabIndex = 37
        Me.RadioButton41.TabStop = True
        Me.RadioButton41.UseVisualStyleBackColor = True
        '
        'RadioButton42
        '
        Me.RadioButton42.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton42.BackgroundImage = CType(resources.GetObject("RadioButton42.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton42.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton42.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton42.FlatAppearance.BorderSize = 0
        Me.RadioButton42.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton42.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton42.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton42.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton42.Location = New System.Drawing.Point(113, 3)
        Me.RadioButton42.Name = "RadioButton42"
        Me.RadioButton42.Size = New System.Drawing.Size(22, 1)
        Me.RadioButton42.TabIndex = 36
        Me.RadioButton42.TabStop = True
        Me.RadioButton42.UseVisualStyleBackColor = True
        '
        'RadioButton31
        '
        Me.RadioButton31.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton31.BackgroundImage = CType(resources.GetObject("RadioButton31.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton31.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton31.FlatAppearance.BorderSize = 0
        Me.RadioButton31.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton31.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton31.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton31.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton31.Name = "RadioButton31"
        Me.RadioButton31.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton31.TabIndex = 35
        Me.RadioButton31.TabStop = True
        Me.RadioButton31.UseVisualStyleBackColor = True
        '
        'RadioButton32
        '
        Me.RadioButton32.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton32.BackgroundImage = CType(resources.GetObject("RadioButton32.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton32.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton32.FlatAppearance.BorderSize = 0
        Me.RadioButton32.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton32.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton32.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton32.Location = New System.Drawing.Point(25, 3)
        Me.RadioButton32.Name = "RadioButton32"
        Me.RadioButton32.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton32.TabIndex = 34
        Me.RadioButton32.TabStop = True
        Me.RadioButton32.UseVisualStyleBackColor = True
        '
        'RadioButton33
        '
        Me.RadioButton33.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton33.BackgroundImage = CType(resources.GetObject("RadioButton33.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton33.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton33.FlatAppearance.BorderSize = 0
        Me.RadioButton33.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton33.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton33.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton33.Location = New System.Drawing.Point(47, 3)
        Me.RadioButton33.Name = "RadioButton33"
        Me.RadioButton33.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton33.TabIndex = 33
        Me.RadioButton33.TabStop = True
        Me.RadioButton33.UseVisualStyleBackColor = True
        '
        'RadioButton34
        '
        Me.RadioButton34.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton34.BackgroundImage = CType(resources.GetObject("RadioButton34.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton34.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton34.FlatAppearance.BorderSize = 0
        Me.RadioButton34.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton34.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton34.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton34.Location = New System.Drawing.Point(69, 3)
        Me.RadioButton34.Name = "RadioButton34"
        Me.RadioButton34.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton34.TabIndex = 32
        Me.RadioButton34.TabStop = True
        Me.RadioButton34.UseVisualStyleBackColor = True
        '
        'RadioButton35
        '
        Me.RadioButton35.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton35.BackgroundImage = CType(resources.GetObject("RadioButton35.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton35.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton35.FlatAppearance.BorderSize = 0
        Me.RadioButton35.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton35.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton35.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton35.Location = New System.Drawing.Point(91, 3)
        Me.RadioButton35.Name = "RadioButton35"
        Me.RadioButton35.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton35.TabIndex = 31
        Me.RadioButton35.TabStop = True
        Me.RadioButton35.UseVisualStyleBackColor = True
        '
        'RadioButton36
        '
        Me.RadioButton36.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton36.BackgroundImage = CType(resources.GetObject("RadioButton36.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton36.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton36.FlatAppearance.BorderSize = 0
        Me.RadioButton36.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton36.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton36.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton36.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton36.Location = New System.Drawing.Point(113, 3)
        Me.RadioButton36.Name = "RadioButton36"
        Me.RadioButton36.Size = New System.Drawing.Size(22, 1)
        Me.RadioButton36.TabIndex = 30
        Me.RadioButton36.TabStop = True
        Me.RadioButton36.UseVisualStyleBackColor = True
        '
        'RadioButton25
        '
        Me.RadioButton25.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton25.BackgroundImage = CType(resources.GetObject("RadioButton25.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton25.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton25.FlatAppearance.BorderSize = 0
        Me.RadioButton25.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton25.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton25.Name = "RadioButton25"
        Me.RadioButton25.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton25.TabIndex = 29
        Me.RadioButton25.TabStop = True
        Me.RadioButton25.UseVisualStyleBackColor = True
        '
        'RadioButton26
        '
        Me.RadioButton26.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton26.BackgroundImage = CType(resources.GetObject("RadioButton26.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton26.FlatAppearance.BorderSize = 0
        Me.RadioButton26.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton26.Location = New System.Drawing.Point(25, 3)
        Me.RadioButton26.Name = "RadioButton26"
        Me.RadioButton26.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton26.TabIndex = 28
        Me.RadioButton26.TabStop = True
        Me.RadioButton26.UseVisualStyleBackColor = True
        '
        'RadioButton27
        '
        Me.RadioButton27.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton27.BackgroundImage = CType(resources.GetObject("RadioButton27.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton27.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton27.FlatAppearance.BorderSize = 0
        Me.RadioButton27.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton27.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton27.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton27.Location = New System.Drawing.Point(47, 3)
        Me.RadioButton27.Name = "RadioButton27"
        Me.RadioButton27.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton27.TabIndex = 27
        Me.RadioButton27.TabStop = True
        Me.RadioButton27.UseVisualStyleBackColor = True
        '
        'RadioButton28
        '
        Me.RadioButton28.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton28.BackgroundImage = CType(resources.GetObject("RadioButton28.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton28.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton28.FlatAppearance.BorderSize = 0
        Me.RadioButton28.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton28.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton28.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton28.Location = New System.Drawing.Point(69, 3)
        Me.RadioButton28.Name = "RadioButton28"
        Me.RadioButton28.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton28.TabIndex = 26
        Me.RadioButton28.TabStop = True
        Me.RadioButton28.UseVisualStyleBackColor = True
        '
        'RadioButton29
        '
        Me.RadioButton29.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton29.BackgroundImage = CType(resources.GetObject("RadioButton29.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton29.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton29.FlatAppearance.BorderSize = 0
        Me.RadioButton29.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton29.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton29.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton29.Location = New System.Drawing.Point(91, 3)
        Me.RadioButton29.Name = "RadioButton29"
        Me.RadioButton29.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton29.TabIndex = 25
        Me.RadioButton29.TabStop = True
        Me.RadioButton29.UseVisualStyleBackColor = True
        '
        'RadioButton30
        '
        Me.RadioButton30.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton30.BackgroundImage = CType(resources.GetObject("RadioButton30.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton30.FlatAppearance.BorderSize = 0
        Me.RadioButton30.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton30.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton30.Location = New System.Drawing.Point(113, 3)
        Me.RadioButton30.Name = "RadioButton30"
        Me.RadioButton30.Size = New System.Drawing.Size(22, 1)
        Me.RadioButton30.TabIndex = 24
        Me.RadioButton30.TabStop = True
        Me.RadioButton30.UseVisualStyleBackColor = True
        '
        'RadioButton19
        '
        Me.RadioButton19.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton19.BackgroundImage = CType(resources.GetObject("RadioButton19.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton19.FlatAppearance.BorderSize = 0
        Me.RadioButton19.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton19.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton19.Name = "RadioButton19"
        Me.RadioButton19.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton19.TabIndex = 23
        Me.RadioButton19.TabStop = True
        Me.RadioButton19.UseVisualStyleBackColor = True
        '
        'RadioButton20
        '
        Me.RadioButton20.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton20.BackgroundImage = CType(resources.GetObject("RadioButton20.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton20.FlatAppearance.BorderSize = 0
        Me.RadioButton20.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton20.Location = New System.Drawing.Point(25, 3)
        Me.RadioButton20.Name = "RadioButton20"
        Me.RadioButton20.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton20.TabIndex = 22
        Me.RadioButton20.TabStop = True
        Me.RadioButton20.UseVisualStyleBackColor = True
        '
        'RadioButton21
        '
        Me.RadioButton21.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton21.BackgroundImage = CType(resources.GetObject("RadioButton21.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton21.FlatAppearance.BorderSize = 0
        Me.RadioButton21.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton21.Location = New System.Drawing.Point(47, 3)
        Me.RadioButton21.Name = "RadioButton21"
        Me.RadioButton21.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton21.TabIndex = 21
        Me.RadioButton21.TabStop = True
        Me.RadioButton21.UseVisualStyleBackColor = True
        '
        'RadioButton22
        '
        Me.RadioButton22.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton22.BackgroundImage = CType(resources.GetObject("RadioButton22.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton22.FlatAppearance.BorderSize = 0
        Me.RadioButton22.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton22.Location = New System.Drawing.Point(69, 3)
        Me.RadioButton22.Name = "RadioButton22"
        Me.RadioButton22.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton22.TabIndex = 20
        Me.RadioButton22.TabStop = True
        Me.RadioButton22.UseVisualStyleBackColor = True
        '
        'RadioButton23
        '
        Me.RadioButton23.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton23.BackgroundImage = CType(resources.GetObject("RadioButton23.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton23.FlatAppearance.BorderSize = 0
        Me.RadioButton23.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton23.Location = New System.Drawing.Point(91, 3)
        Me.RadioButton23.Name = "RadioButton23"
        Me.RadioButton23.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton23.TabIndex = 19
        Me.RadioButton23.TabStop = True
        Me.RadioButton23.UseVisualStyleBackColor = True
        '
        'RadioButton24
        '
        Me.RadioButton24.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton24.BackgroundImage = CType(resources.GetObject("RadioButton24.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton24.FlatAppearance.BorderSize = 0
        Me.RadioButton24.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton24.Location = New System.Drawing.Point(113, 3)
        Me.RadioButton24.Name = "RadioButton24"
        Me.RadioButton24.Size = New System.Drawing.Size(22, 1)
        Me.RadioButton24.TabIndex = 18
        Me.RadioButton24.TabStop = True
        Me.RadioButton24.UseVisualStyleBackColor = True
        '
        'RadioButton13
        '
        Me.RadioButton13.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton13.BackgroundImage = CType(resources.GetObject("RadioButton13.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton13.FlatAppearance.BorderSize = 0
        Me.RadioButton13.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton13.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton13.TabIndex = 17
        Me.RadioButton13.TabStop = True
        Me.RadioButton13.UseVisualStyleBackColor = True
        '
        'RadioButton14
        '
        Me.RadioButton14.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton14.BackgroundImage = CType(resources.GetObject("RadioButton14.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton14.FlatAppearance.BorderSize = 0
        Me.RadioButton14.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton14.Location = New System.Drawing.Point(25, 3)
        Me.RadioButton14.Name = "RadioButton14"
        Me.RadioButton14.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton14.TabIndex = 16
        Me.RadioButton14.TabStop = True
        Me.RadioButton14.UseVisualStyleBackColor = True
        '
        'RadioButton15
        '
        Me.RadioButton15.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton15.BackgroundImage = CType(resources.GetObject("RadioButton15.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton15.FlatAppearance.BorderSize = 0
        Me.RadioButton15.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton15.Location = New System.Drawing.Point(47, 3)
        Me.RadioButton15.Name = "RadioButton15"
        Me.RadioButton15.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton15.TabIndex = 15
        Me.RadioButton15.TabStop = True
        Me.RadioButton15.UseVisualStyleBackColor = True
        '
        'RadioButton16
        '
        Me.RadioButton16.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton16.BackgroundImage = CType(resources.GetObject("RadioButton16.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton16.FlatAppearance.BorderSize = 0
        Me.RadioButton16.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton16.Location = New System.Drawing.Point(69, 3)
        Me.RadioButton16.Name = "RadioButton16"
        Me.RadioButton16.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton16.TabIndex = 14
        Me.RadioButton16.TabStop = True
        Me.RadioButton16.UseVisualStyleBackColor = True
        '
        'RadioButton17
        '
        Me.RadioButton17.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton17.BackgroundImage = CType(resources.GetObject("RadioButton17.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton17.FlatAppearance.BorderSize = 0
        Me.RadioButton17.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton17.Location = New System.Drawing.Point(91, 3)
        Me.RadioButton17.Name = "RadioButton17"
        Me.RadioButton17.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton17.TabIndex = 13
        Me.RadioButton17.TabStop = True
        Me.RadioButton17.UseVisualStyleBackColor = True
        '
        'RadioButton18
        '
        Me.RadioButton18.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton18.BackgroundImage = CType(resources.GetObject("RadioButton18.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton18.FlatAppearance.BorderSize = 0
        Me.RadioButton18.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton18.Location = New System.Drawing.Point(113, 3)
        Me.RadioButton18.Name = "RadioButton18"
        Me.RadioButton18.Size = New System.Drawing.Size(22, 1)
        Me.RadioButton18.TabIndex = 12
        Me.RadioButton18.TabStop = True
        Me.RadioButton18.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton7.BackgroundImage = CType(resources.GetObject("RadioButton7.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton7.FlatAppearance.BorderSize = 0
        Me.RadioButton7.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton7.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton7.TabIndex = 11
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton8.BackgroundImage = CType(resources.GetObject("RadioButton8.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton8.FlatAppearance.BorderSize = 0
        Me.RadioButton8.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton8.Location = New System.Drawing.Point(25, 3)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton8.TabIndex = 10
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton9.BackgroundImage = CType(resources.GetObject("RadioButton9.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton9.FlatAppearance.BorderSize = 0
        Me.RadioButton9.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton9.Location = New System.Drawing.Point(47, 3)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton9.TabIndex = 9
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton10.BackgroundImage = CType(resources.GetObject("RadioButton10.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton10.FlatAppearance.BorderSize = 0
        Me.RadioButton10.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton10.Location = New System.Drawing.Point(69, 3)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton10.TabIndex = 8
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton11
        '
        Me.RadioButton11.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton11.BackgroundImage = CType(resources.GetObject("RadioButton11.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton11.FlatAppearance.BorderSize = 0
        Me.RadioButton11.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton11.Location = New System.Drawing.Point(91, 3)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton11.TabIndex = 7
        Me.RadioButton11.TabStop = True
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton12
        '
        Me.RadioButton12.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton12.BackgroundImage = CType(resources.GetObject("RadioButton12.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton12.FlatAppearance.BorderSize = 0
        Me.RadioButton12.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton12.Location = New System.Drawing.Point(113, 3)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(22, 1)
        Me.RadioButton12.TabIndex = 6
        Me.RadioButton12.TabStop = True
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton6.BackgroundImage = CType(resources.GetObject("RadioButton6.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton6.FlatAppearance.BorderSize = 0
        Me.RadioButton6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton6.Location = New System.Drawing.Point(113, 3)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(22, 1)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton5.BackgroundImage = CType(resources.GetObject("RadioButton5.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton5.FlatAppearance.BorderSize = 0
        Me.RadioButton5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton5.Location = New System.Drawing.Point(91, 3)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton4.BackgroundImage = CType(resources.GetObject("RadioButton4.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton4.FlatAppearance.BorderSize = 0
        Me.RadioButton4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton4.Location = New System.Drawing.Point(69, 3)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton3.BackgroundImage = CType(resources.GetObject("RadioButton3.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton3.FlatAppearance.BorderSize = 0
        Me.RadioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton3.Location = New System.Drawing.Point(47, 3)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.BackgroundImage = CType(resources.GetObject("RadioButton2.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton2.FlatAppearance.BorderSize = 0
        Me.RadioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton2.Location = New System.Drawing.Point(25, 3)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.BackgroundImage = CType(resources.GetObject("RadioButton1.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadioButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton1.FlatAppearance.BorderSize = 0
        Me.RadioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton1.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(16, 1)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Scont_TextureFill
        '
        Me.Scont_TextureFill.Dock = System.Windows.Forms.DockStyle.Top
        Me.Scont_TextureFill.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Scont_TextureFill.Location = New System.Drawing.Point(0, 150)
        Me.Scont_TextureFill.Name = "Scont_TextureFill"
        Me.Scont_TextureFill.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Scont_TextureFill.Panel1
        '
        Me.Scont_TextureFill.Panel1.Controls.Add(Me.Rbtn_TextureFill)
        '
        'Scont_TextureFill.Panel2
        '
        Me.Scont_TextureFill.Panel2.Controls.Add(Me.TLP_Texture)
        Me.Scont_TextureFill.Size = New System.Drawing.Size(228, 400)
        Me.Scont_TextureFill.TabIndex = 2
        '
        'Rbtn_TextureFill
        '
        Me.Rbtn_TextureFill.AutoCheck = False
        Me.Rbtn_TextureFill.AutoSize = True
        Me.Rbtn_TextureFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Rbtn_TextureFill.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbtn_TextureFill.Location = New System.Drawing.Point(0, 0)
        Me.Rbtn_TextureFill.Name = "Rbtn_TextureFill"
        Me.Rbtn_TextureFill.Size = New System.Drawing.Size(228, 50)
        Me.Rbtn_TextureFill.TabIndex = 0
        Me.Rbtn_TextureFill.TabStop = True
        Me.Rbtn_TextureFill.Text = "Picture or texture fill"
        Me.Rbtn_TextureFill.UseVisualStyleBackColor = True
        '
        'TLP_Texture
        '
        Me.TLP_Texture.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TLP_Texture.ColumnCount = 1
        Me.TLP_Texture.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Texture.Controls.Add(Me.Gbox_Texture, 0, 0)
        Me.TLP_Texture.Controls.Add(Me.TLP_TranspTexture, 0, 3)
        Me.TLP_Texture.Controls.Add(Me.chkbx_RotateWithShape, 0, 4)
        Me.TLP_Texture.Controls.Add(Me.chkbx_texture, 0, 1)
        Me.TLP_Texture.Controls.Add(Me.Scont_TxtrVsPctr, 0, 2)
        Me.TLP_Texture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Texture.Location = New System.Drawing.Point(0, 0)
        Me.TLP_Texture.Name = "TLP_Texture"
        Me.TLP_Texture.RowCount = 5
        Me.TLP_Texture.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TLP_Texture.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TLP_Texture.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Texture.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TLP_Texture.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TLP_Texture.Size = New System.Drawing.Size(228, 346)
        Me.TLP_Texture.TabIndex = 1
        '
        'Gbox_Texture
        '
        Me.Gbox_Texture.Controls.Add(Me.TLP_InsertTxtureFrom)
        Me.Gbox_Texture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gbox_Texture.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbox_Texture.Location = New System.Drawing.Point(4, 4)
        Me.Gbox_Texture.Name = "Gbox_Texture"
        Me.Gbox_Texture.Size = New System.Drawing.Size(220, 61)
        Me.Gbox_Texture.TabIndex = 2
        Me.Gbox_Texture.TabStop = False
        Me.Gbox_Texture.Text = "Insert Picture From"
        '
        'TLP_InsertTxtureFrom
        '
        Me.TLP_InsertTxtureFrom.ColumnCount = 3
        Me.TLP_InsertTxtureFrom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.26829!))
        Me.TLP_InsertTxtureFrom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.04878!))
        Me.TLP_InsertTxtureFrom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.68293!))
        Me.TLP_InsertTxtureFrom.Controls.Add(Me.btn_ClipboardTexture, 0, 0)
        Me.TLP_InsertTxtureFrom.Controls.Add(Me.btn_FileTexture, 0, 0)
        Me.TLP_InsertTxtureFrom.Controls.Add(Me.btn_TexturePreset, 2, 0)
        Me.TLP_InsertTxtureFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_InsertTxtureFrom.Location = New System.Drawing.Point(3, 21)
        Me.TLP_InsertTxtureFrom.Name = "TLP_InsertTxtureFrom"
        Me.TLP_InsertTxtureFrom.RowCount = 1
        Me.TLP_InsertTxtureFrom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_InsertTxtureFrom.Size = New System.Drawing.Size(214, 37)
        Me.TLP_InsertTxtureFrom.TabIndex = 0
        '
        'btn_ClipboardTexture
        '
        Me.btn_ClipboardTexture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_ClipboardTexture.Location = New System.Drawing.Point(65, 3)
        Me.btn_ClipboardTexture.Name = "btn_ClipboardTexture"
        Me.btn_ClipboardTexture.Size = New System.Drawing.Size(75, 31)
        Me.btn_ClipboardTexture.TabIndex = 3
        Me.btn_ClipboardTexture.Text = "Clipboard"
        Me.btn_ClipboardTexture.UseVisualStyleBackColor = True
        '
        'btn_FileTexture
        '
        Me.btn_FileTexture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_FileTexture.Location = New System.Drawing.Point(3, 3)
        Me.btn_FileTexture.Name = "btn_FileTexture"
        Me.btn_FileTexture.Size = New System.Drawing.Size(56, 31)
        Me.btn_FileTexture.TabIndex = 2
        Me.btn_FileTexture.Text = "File..."
        Me.btn_FileTexture.UseVisualStyleBackColor = True
        '
        'btn_TexturePreset
        '
        Me.btn_TexturePreset.Appearance = System.Windows.Forms.Appearance.Button
        Me.btn_TexturePreset.AutoSize = True
        Me.btn_TexturePreset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_TexturePreset.Location = New System.Drawing.Point(146, 3)
        Me.btn_TexturePreset.Name = "btn_TexturePreset"
        Me.btn_TexturePreset.Size = New System.Drawing.Size(65, 31)
        Me.btn_TexturePreset.TabIndex = 4
        Me.btn_TexturePreset.Text = "Preset"
        Me.btn_TexturePreset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_TexturePreset.UseVisualStyleBackColor = True
        '
        'TLP_TranspTexture
        '
        Me.TLP_TranspTexture.ColumnCount = 2
        Me.TLP_TranspTexture.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.05164!))
        Me.TLP_TranspTexture.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.94836!))
        Me.TLP_TranspTexture.Controls.Add(Me.Label8, 0, 0)
        Me.TLP_TranspTexture.Controls.Add(Me.num_TranspTexture, 1, 0)
        Me.TLP_TranspTexture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_TranspTexture.Location = New System.Drawing.Point(4, 288)
        Me.TLP_TranspTexture.Name = "TLP_TranspTexture"
        Me.TLP_TranspTexture.RowCount = 1
        Me.TLP_TranspTexture.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_TranspTexture.Size = New System.Drawing.Size(220, 26)
        Me.TLP_TranspTexture.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 26)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Transparency"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'num_TranspTexture
        '
        Me.num_TranspTexture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.num_TranspTexture.Location = New System.Drawing.Point(119, 3)
        Me.num_TranspTexture.Name = "num_TranspTexture"
        Me.num_TranspTexture.Size = New System.Drawing.Size(98, 20)
        Me.num_TranspTexture.TabIndex = 1
        Me.num_TranspTexture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkbx_RotateWithShape
        '
        Me.chkbx_RotateWithShape.AutoSize = True
        Me.chkbx_RotateWithShape.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbx_RotateWithShape.Location = New System.Drawing.Point(4, 321)
        Me.chkbx_RotateWithShape.Name = "chkbx_RotateWithShape"
        Me.chkbx_RotateWithShape.Size = New System.Drawing.Size(106, 21)
        Me.chkbx_RotateWithShape.TabIndex = 4
        Me.chkbx_RotateWithShape.Text = "Rotate With Shape"
        Me.chkbx_RotateWithShape.UseVisualStyleBackColor = True
        '
        'chkbx_texture
        '
        Me.chkbx_texture.AutoSize = True
        Me.chkbx_texture.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbx_texture.Location = New System.Drawing.Point(4, 72)
        Me.chkbx_texture.Name = "chkbx_texture"
        Me.chkbx_texture.Size = New System.Drawing.Size(123, 20)
        Me.chkbx_texture.TabIndex = 5
        Me.chkbx_texture.Text = "Tile Picture as texture"
        Me.chkbx_texture.UseVisualStyleBackColor = True
        '
        'Scont_TxtrVsPctr
        '
        Me.Scont_TxtrVsPctr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Scont_TxtrVsPctr.Location = New System.Drawing.Point(4, 99)
        Me.Scont_TxtrVsPctr.Name = "Scont_TxtrVsPctr"
        '
        'Scont_TxtrVsPctr.Panel1
        '
        Me.Scont_TxtrVsPctr.Panel1.Controls.Add(Me.TLP_PictureFill)
        Me.Scont_TxtrVsPctr.Panel1Collapsed = True
        '
        'Scont_TxtrVsPctr.Panel2
        '
        Me.Scont_TxtrVsPctr.Panel2.Controls.Add(Me.TLP_TextureFill)
        Me.Scont_TxtrVsPctr.Size = New System.Drawing.Size(220, 182)
        Me.Scont_TxtrVsPctr.SplitterDistance = 122
        Me.Scont_TxtrVsPctr.TabIndex = 6
        '
        'TLP_PictureFill
        '
        Me.TLP_PictureFill.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TLP_PictureFill.ColumnCount = 2
        Me.TLP_PictureFill.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86.0!))
        Me.TLP_PictureFill.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_PictureFill.Controls.Add(Me.Label10, 0, 0)
        Me.TLP_PictureFill.Controls.Add(Me.Label12, 0, 1)
        Me.TLP_PictureFill.Controls.Add(Me.Label14, 0, 2)
        Me.TLP_PictureFill.Controls.Add(Me.Label16, 0, 3)
        Me.TLP_PictureFill.Controls.Add(Me.num_offsetleft, 1, 0)
        Me.TLP_PictureFill.Controls.Add(Me.num_offsetright, 1, 1)
        Me.TLP_PictureFill.Controls.Add(Me.num_offsettop, 1, 2)
        Me.TLP_PictureFill.Controls.Add(Me.num_offsetbot, 1, 3)
        Me.TLP_PictureFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_PictureFill.Location = New System.Drawing.Point(0, 0)
        Me.TLP_PictureFill.Name = "TLP_PictureFill"
        Me.TLP_PictureFill.RowCount = 4
        Me.TLP_PictureFill.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_PictureFill.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_PictureFill.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_PictureFill.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_PictureFill.Size = New System.Drawing.Size(122, 100)
        Me.TLP_PictureFill.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Location = New System.Drawing.Point(5, 2)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 22)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Offset Left :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Location = New System.Drawing.Point(5, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 22)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Offset Right :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Location = New System.Drawing.Point(5, 50)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 22)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Offset Top :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Location = New System.Drawing.Point(5, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 24)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Offset Bottom :"
        '
        'num_offsetleft
        '
        Me.num_offsetleft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.num_offsetleft.Location = New System.Drawing.Point(93, 5)
        Me.num_offsetleft.Name = "num_offsetleft"
        Me.num_offsetleft.Size = New System.Drawing.Size(24, 20)
        Me.num_offsetleft.TabIndex = 4
        Me.num_offsetleft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_offsetright
        '
        Me.num_offsetright.Dock = System.Windows.Forms.DockStyle.Fill
        Me.num_offsetright.Location = New System.Drawing.Point(93, 29)
        Me.num_offsetright.Name = "num_offsetright"
        Me.num_offsetright.Size = New System.Drawing.Size(24, 20)
        Me.num_offsetright.TabIndex = 5
        Me.num_offsetright.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_offsettop
        '
        Me.num_offsettop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.num_offsettop.Location = New System.Drawing.Point(93, 53)
        Me.num_offsettop.Name = "num_offsettop"
        Me.num_offsettop.Size = New System.Drawing.Size(24, 20)
        Me.num_offsettop.TabIndex = 6
        Me.num_offsettop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_offsetbot
        '
        Me.num_offsetbot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.num_offsetbot.Location = New System.Drawing.Point(93, 77)
        Me.num_offsetbot.Name = "num_offsetbot"
        Me.num_offsetbot.Size = New System.Drawing.Size(24, 20)
        Me.num_offsetbot.TabIndex = 7
        Me.num_offsetbot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TLP_TextureFill
        '
        Me.TLP_TextureFill.ColumnCount = 2
        Me.TLP_TextureFill.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TLP_TextureFill.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_TextureFill.Controls.Add(Me.Label17, 0, 0)
        Me.TLP_TextureFill.Controls.Add(Me.Label18, 0, 1)
        Me.TLP_TextureFill.Controls.Add(Me.Label21, 0, 2)
        Me.TLP_TextureFill.Controls.Add(Me.Label22, 0, 3)
        Me.TLP_TextureFill.Controls.Add(Me.Label20, 0, 4)
        Me.TLP_TextureFill.Controls.Add(Me.Label19, 0, 5)
        Me.TLP_TextureFill.Controls.Add(Me.num_OffsetX, 1, 0)
        Me.TLP_TextureFill.Controls.Add(Me.num_offsetY, 1, 1)
        Me.TLP_TextureFill.Controls.Add(Me.num_ScaleXFill, 1, 2)
        Me.TLP_TextureFill.Controls.Add(Me.num_ScaleYFill, 1, 3)
        Me.TLP_TextureFill.Controls.Add(Me.cbox_AlignmentTexture, 1, 4)
        Me.TLP_TextureFill.Controls.Add(Me.cbox_MirrorTexture, 1, 5)
        Me.TLP_TextureFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_TextureFill.Location = New System.Drawing.Point(0, 0)
        Me.TLP_TextureFill.Name = "TLP_TextureFill"
        Me.TLP_TextureFill.RowCount = 6
        Me.TLP_TextureFill.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TLP_TextureFill.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TLP_TextureFill.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TLP_TextureFill.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TLP_TextureFill.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TLP_TextureFill.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TLP_TextureFill.Size = New System.Drawing.Size(220, 182)
        Me.TLP_TextureFill.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 30)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Offset X :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(3, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 30)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Offset Y :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label21.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(3, 60)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 30)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Scale X:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label22.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(3, 90)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(70, 30)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "Scale Y :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label20.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(3, 120)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 30)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Alignment :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label19.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 150)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 32)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Mirror :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'num_OffsetX
        '
        Me.num_OffsetX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.num_OffsetX.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_OffsetX.Location = New System.Drawing.Point(79, 3)
        Me.num_OffsetX.Name = "num_OffsetX"
        Me.num_OffsetX.Size = New System.Drawing.Size(138, 22)
        Me.num_OffsetX.TabIndex = 6
        Me.num_OffsetX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_offsetY
        '
        Me.num_offsetY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.num_offsetY.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_offsetY.Location = New System.Drawing.Point(79, 33)
        Me.num_offsetY.Name = "num_offsetY"
        Me.num_offsetY.Size = New System.Drawing.Size(138, 22)
        Me.num_offsetY.TabIndex = 7
        Me.num_offsetY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_ScaleXFill
        '
        Me.num_ScaleXFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.num_ScaleXFill.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_ScaleXFill.Location = New System.Drawing.Point(79, 63)
        Me.num_ScaleXFill.Name = "num_ScaleXFill"
        Me.num_ScaleXFill.Size = New System.Drawing.Size(138, 22)
        Me.num_ScaleXFill.TabIndex = 8
        Me.num_ScaleXFill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_ScaleYFill
        '
        Me.num_ScaleYFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.num_ScaleYFill.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_ScaleYFill.Location = New System.Drawing.Point(79, 93)
        Me.num_ScaleYFill.Name = "num_ScaleYFill"
        Me.num_ScaleYFill.Size = New System.Drawing.Size(138, 22)
        Me.num_ScaleYFill.TabIndex = 9
        Me.num_ScaleYFill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbox_AlignmentTexture
        '
        Me.cbox_AlignmentTexture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbox_AlignmentTexture.FormattingEnabled = True
        Me.cbox_AlignmentTexture.Items.AddRange(New Object() {"Top Left", "Top", "Top Right", "Left", "Center", "Right", "Bottom Left", "Bottom", "Bottom Right"})
        Me.cbox_AlignmentTexture.Location = New System.Drawing.Point(79, 123)
        Me.cbox_AlignmentTexture.Name = "cbox_AlignmentTexture"
        Me.cbox_AlignmentTexture.Size = New System.Drawing.Size(138, 21)
        Me.cbox_AlignmentTexture.TabIndex = 10
        '
        'cbox_MirrorTexture
        '
        Me.cbox_MirrorTexture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbox_MirrorTexture.FormattingEnabled = True
        Me.cbox_MirrorTexture.Items.AddRange(New Object() {"None", "Horizontal", "Vertical", "Both"})
        Me.cbox_MirrorTexture.Location = New System.Drawing.Point(79, 153)
        Me.cbox_MirrorTexture.Name = "cbox_MirrorTexture"
        Me.cbox_MirrorTexture.Size = New System.Drawing.Size(138, 21)
        Me.cbox_MirrorTexture.TabIndex = 11
        '
        'Scont_GradentFill
        '
        Me.Scont_GradentFill.Dock = System.Windows.Forms.DockStyle.Top
        Me.Scont_GradentFill.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Scont_GradentFill.Location = New System.Drawing.Point(0, 100)
        Me.Scont_GradentFill.Name = "Scont_GradentFill"
        Me.Scont_GradentFill.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Scont_GradentFill.Panel1
        '
        Me.Scont_GradentFill.Panel1.Controls.Add(Me.Rbtn_Gradient)
        '
        'Scont_GradentFill.Panel2
        '
        Me.Scont_GradentFill.Panel2.Controls.Add(Me.TLP_GradientFill)
        Me.Scont_GradentFill.Panel2Collapsed = True
        Me.Scont_GradentFill.Size = New System.Drawing.Size(228, 50)
        Me.Scont_GradentFill.TabIndex = 2
        '
        'Rbtn_Gradient
        '
        Me.Rbtn_Gradient.AutoSize = True
        Me.Rbtn_Gradient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Rbtn_Gradient.Enabled = False
        Me.Rbtn_Gradient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Rbtn_Gradient.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbtn_Gradient.Location = New System.Drawing.Point(0, 0)
        Me.Rbtn_Gradient.Name = "Rbtn_Gradient"
        Me.Rbtn_Gradient.Size = New System.Drawing.Size(228, 50)
        Me.Rbtn_Gradient.TabIndex = 0
        Me.Rbtn_Gradient.TabStop = True
        Me.Rbtn_Gradient.Text = "Gradient Fill"
        Me.Rbtn_Gradient.UseVisualStyleBackColor = True
        '
        'TLP_GradientFill
        '
        Me.TLP_GradientFill.ColumnCount = 2
        Me.TLP_GradientFill.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TLP_GradientFill.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_GradientFill.Controls.Add(Me.Label4, 0, 0)
        Me.TLP_GradientFill.Controls.Add(Me.Label5, 0, 1)
        Me.TLP_GradientFill.Controls.Add(Me.num_TranspGradient, 1, 1)
        Me.TLP_GradientFill.Controls.Add(Me.btn_ColorGradientFill, 1, 0)
        Me.TLP_GradientFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_GradientFill.Location = New System.Drawing.Point(0, 0)
        Me.TLP_GradientFill.Name = "TLP_GradientFill"
        Me.TLP_GradientFill.RowCount = 2
        Me.TLP_GradientFill.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_GradientFill.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_GradientFill.Size = New System.Drawing.Size(150, 46)
        Me.TLP_GradientFill.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Color :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Angle :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'num_TranspGradient
        '
        Me.num_TranspGradient.Dock = System.Windows.Forms.DockStyle.Right
        Me.num_TranspGradient.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_TranspGradient.Location = New System.Drawing.Point(94, 31)
        Me.num_TranspGradient.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.num_TranspGradient.Name = "num_TranspGradient"
        Me.num_TranspGradient.Size = New System.Drawing.Size(53, 23)
        Me.num_TranspGradient.TabIndex = 1
        Me.num_TranspGradient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_ColorGradientFill
        '
        Me.btn_ColorGradientFill.BackgroundImage = CType(resources.GetObject("btn_ColorGradientFill.BackgroundImage"), System.Drawing.Image)
        Me.btn_ColorGradientFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_ColorGradientFill.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_ColorGradientFill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_ColorGradientFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ColorGradientFill.Location = New System.Drawing.Point(95, 3)
        Me.btn_ColorGradientFill.Name = "btn_ColorGradientFill"
        Me.btn_ColorGradientFill.Size = New System.Drawing.Size(52, 17)
        Me.btn_ColorGradientFill.TabIndex = 2
        Me.btn_ColorGradientFill.UseVisualStyleBackColor = True
        '
        'Scont_SolidFill
        '
        Me.Scont_SolidFill.Dock = System.Windows.Forms.DockStyle.Top
        Me.Scont_SolidFill.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Scont_SolidFill.Location = New System.Drawing.Point(0, 50)
        Me.Scont_SolidFill.Name = "Scont_SolidFill"
        Me.Scont_SolidFill.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Scont_SolidFill.Panel1
        '
        Me.Scont_SolidFill.Panel1.Controls.Add(Me.Rbtn_SolidFill)
        '
        'Scont_SolidFill.Panel2
        '
        Me.Scont_SolidFill.Panel2.Controls.Add(Me.TLP_SolidFill)
        Me.Scont_SolidFill.Panel2Collapsed = True
        Me.Scont_SolidFill.Size = New System.Drawing.Size(228, 50)
        Me.Scont_SolidFill.TabIndex = 1
        '
        'Rbtn_SolidFill
        '
        Me.Rbtn_SolidFill.AutoCheck = False
        Me.Rbtn_SolidFill.AutoSize = True
        Me.Rbtn_SolidFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Rbtn_SolidFill.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbtn_SolidFill.Location = New System.Drawing.Point(0, 0)
        Me.Rbtn_SolidFill.Name = "Rbtn_SolidFill"
        Me.Rbtn_SolidFill.Size = New System.Drawing.Size(228, 50)
        Me.Rbtn_SolidFill.TabIndex = 0
        Me.Rbtn_SolidFill.TabStop = True
        Me.Rbtn_SolidFill.Text = "Solid Fill"
        Me.Rbtn_SolidFill.UseVisualStyleBackColor = True
        '
        'TLP_SolidFill
        '
        Me.TLP_SolidFill.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.TLP_SolidFill.ColumnCount = 2
        Me.TLP_SolidFill.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TLP_SolidFill.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_SolidFill.Controls.Add(Me.Label2, 0, 0)
        Me.TLP_SolidFill.Controls.Add(Me.Label3, 0, 1)
        Me.TLP_SolidFill.Controls.Add(Me.num_Transparency, 1, 1)
        Me.TLP_SolidFill.Controls.Add(Me.btn_SolidFillColor, 1, 0)
        Me.TLP_SolidFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_SolidFill.Location = New System.Drawing.Point(0, 0)
        Me.TLP_SolidFill.Name = "TLP_SolidFill"
        Me.TLP_SolidFill.RowCount = 2
        Me.TLP_SolidFill.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_SolidFill.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_SolidFill.Size = New System.Drawing.Size(150, 46)
        Me.TLP_SolidFill.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Color :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Transparency:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'num_Transparency
        '
        Me.num_Transparency.Dock = System.Windows.Forms.DockStyle.Right
        Me.num_Transparency.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_Transparency.Location = New System.Drawing.Point(100, 32)
        Me.num_Transparency.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.num_Transparency.Name = "num_Transparency"
        Me.num_Transparency.Size = New System.Drawing.Size(44, 23)
        Me.num_Transparency.TabIndex = 1
        Me.num_Transparency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_SolidFillColor
        '
        Me.btn_SolidFillColor.BackgroundImage = CType(resources.GetObject("btn_SolidFillColor.BackgroundImage"), System.Drawing.Image)
        Me.btn_SolidFillColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_SolidFillColor.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_SolidFillColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_SolidFillColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SolidFillColor.Location = New System.Drawing.Point(103, 6)
        Me.btn_SolidFillColor.Name = "btn_SolidFillColor"
        Me.btn_SolidFillColor.Size = New System.Drawing.Size(41, 12)
        Me.btn_SolidFillColor.TabIndex = 2
        Me.btn_SolidFillColor.UseVisualStyleBackColor = True
        '
        'Panel_NoFill
        '
        Me.Panel_NoFill.Controls.Add(Me.Rbtn_NoFill)
        Me.Panel_NoFill.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_NoFill.Location = New System.Drawing.Point(0, 0)
        Me.Panel_NoFill.Name = "Panel_NoFill"
        Me.Panel_NoFill.Size = New System.Drawing.Size(228, 50)
        Me.Panel_NoFill.TabIndex = 5
        '
        'Rbtn_NoFill
        '
        Me.Rbtn_NoFill.AutoCheck = False
        Me.Rbtn_NoFill.AutoSize = True
        Me.Rbtn_NoFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Rbtn_NoFill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Rbtn_NoFill.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbtn_NoFill.Location = New System.Drawing.Point(0, 0)
        Me.Rbtn_NoFill.Name = "Rbtn_NoFill"
        Me.Rbtn_NoFill.Size = New System.Drawing.Size(228, 50)
        Me.Rbtn_NoFill.TabIndex = 3
        Me.Rbtn_NoFill.TabStop = True
        Me.Rbtn_NoFill.Text = "No Fill"
        Me.Rbtn_NoFill.UseVisualStyleBackColor = True
        '
        'btn_ShowNotes2
        '
        Me.btn_ShowNotes2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_ShowNotes2.Location = New System.Drawing.Point(0, 0)
        Me.btn_ShowNotes2.Name = "btn_ShowNotes2"
        Me.btn_ShowNotes2.Size = New System.Drawing.Size(245, 40)
        Me.btn_ShowNotes2.TabIndex = 1
        Me.btn_ShowNotes2.Text = "Show Notes"
        Me.btn_ShowNotes2.UseVisualStyleBackColor = True
        '
        'Scont_C
        '
        Me.Scont_C.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Scont_C.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Scont_C.IsSplitterFixed = True
        Me.Scont_C.Location = New System.Drawing.Point(0, 0)
        Me.Scont_C.Name = "Scont_C"
        Me.Scont_C.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Scont_C.Panel1
        '
        Me.Scont_C.Panel1.Controls.Add(Me.TLP_Notes)
        '
        'Scont_C.Panel2
        '
        Me.Scont_C.Panel2.Controls.Add(Me.TLP_SHOWHIDE)
        Me.Scont_C.Size = New System.Drawing.Size(150, 46)
        Me.Scont_C.SplitterDistance = 75
        Me.Scont_C.TabIndex = 0
        '
        'TLP_Notes
        '
        Me.TLP_Notes.BackColor = System.Drawing.SystemColors.Control
        Me.TLP_Notes.ColumnCount = 1
        Me.TLP_Notes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Notes.Controls.Add(Me.TLP_NotesTools1, 0, 0)
        Me.TLP_Notes.Controls.Add(Me.TLP_NotesTools2, 0, 1)
        Me.TLP_Notes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Notes.Location = New System.Drawing.Point(0, 0)
        Me.TLP_Notes.Name = "TLP_Notes"
        Me.TLP_Notes.RowCount = 2
        Me.TLP_Notes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.66667!))
        Me.TLP_Notes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.33333!))
        Me.TLP_Notes.Size = New System.Drawing.Size(276, 75)
        Me.TLP_Notes.TabIndex = 1
        '
        'TLP_NotesTools1
        '
        Me.TLP_NotesTools1.ColumnCount = 3
        Me.TLP_NotesTools1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.20184!))
        Me.TLP_NotesTools1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.60279!))
        Me.TLP_NotesTools1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.23693!))
        Me.TLP_NotesTools1.Controls.Add(Me.TLP_NotesToolsinner, 2, 0)
        Me.TLP_NotesTools1.Controls.Add(Me.cboxFontSize, 1, 0)
        Me.TLP_NotesTools1.Controls.Add(Me.cboxFontFamily, 0, 0)
        Me.TLP_NotesTools1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_NotesTools1.Location = New System.Drawing.Point(3, 3)
        Me.TLP_NotesTools1.Name = "TLP_NotesTools1"
        Me.TLP_NotesTools1.RowCount = 1
        Me.TLP_NotesTools1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_NotesTools1.Size = New System.Drawing.Size(270, 32)
        Me.TLP_NotesTools1.TabIndex = 2
        '
        'TLP_NotesToolsinner
        '
        Me.TLP_NotesToolsinner.ColumnCount = 4
        Me.TLP_NotesToolsinner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_NotesToolsinner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_NotesToolsinner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_NotesToolsinner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_NotesToolsinner.Controls.Add(Me.btn_IndentInc, 3, 0)
        Me.TLP_NotesToolsinner.Controls.Add(Me.btn_Reset, 0, 0)
        Me.TLP_NotesToolsinner.Controls.Add(Me.btn_IndentDec, 2, 0)
        Me.TLP_NotesToolsinner.Controls.Add(Me.btn_Bullet, 1, 0)
        Me.TLP_NotesToolsinner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_NotesToolsinner.Location = New System.Drawing.Point(174, 3)
        Me.TLP_NotesToolsinner.Name = "TLP_NotesToolsinner"
        Me.TLP_NotesToolsinner.RowCount = 1
        Me.TLP_NotesToolsinner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_NotesToolsinner.Size = New System.Drawing.Size(93, 26)
        Me.TLP_NotesToolsinner.TabIndex = 2
        '
        'btn_IndentInc
        '
        Me.btn_IndentInc.BackgroundImage = CType(resources.GetObject("btn_IndentInc.BackgroundImage"), System.Drawing.Image)
        Me.btn_IndentInc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_IndentInc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_IndentInc.FlatAppearance.BorderSize = 0
        Me.btn_IndentInc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_IndentInc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_IndentInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_IndentInc.Location = New System.Drawing.Point(69, 0)
        Me.btn_IndentInc.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_IndentInc.Name = "btn_IndentInc"
        Me.btn_IndentInc.Size = New System.Drawing.Size(24, 26)
        Me.btn_IndentInc.TabIndex = 9
        Me.btn_IndentInc.UseVisualStyleBackColor = True
        '
        'btn_Reset
        '
        Me.btn_Reset.BackgroundImage = CType(resources.GetObject("btn_Reset.BackgroundImage"), System.Drawing.Image)
        Me.btn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Reset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Reset.FlatAppearance.BorderSize = 0
        Me.btn_Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Reset.Location = New System.Drawing.Point(0, 0)
        Me.btn_Reset.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Size = New System.Drawing.Size(23, 26)
        Me.btn_Reset.TabIndex = 10
        Me.btn_Reset.UseVisualStyleBackColor = True
        '
        'btn_IndentDec
        '
        Me.btn_IndentDec.BackgroundImage = CType(resources.GetObject("btn_IndentDec.BackgroundImage"), System.Drawing.Image)
        Me.btn_IndentDec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_IndentDec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_IndentDec.FlatAppearance.BorderSize = 0
        Me.btn_IndentDec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_IndentDec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_IndentDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_IndentDec.Location = New System.Drawing.Point(46, 0)
        Me.btn_IndentDec.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_IndentDec.Name = "btn_IndentDec"
        Me.btn_IndentDec.Size = New System.Drawing.Size(23, 26)
        Me.btn_IndentDec.TabIndex = 6
        Me.btn_IndentDec.UseVisualStyleBackColor = True
        '
        'btn_Bullet
        '
        Me.btn_Bullet.Appearance = System.Windows.Forms.Appearance.Button
        Me.btn_Bullet.BackgroundImage = CType(resources.GetObject("btn_Bullet.BackgroundImage"), System.Drawing.Image)
        Me.btn_Bullet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Bullet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Bullet.FlatAppearance.BorderSize = 0
        Me.btn_Bullet.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Bullet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_Bullet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Bullet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Bullet.Location = New System.Drawing.Point(23, 0)
        Me.btn_Bullet.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Bullet.Name = "btn_Bullet"
        Me.btn_Bullet.Size = New System.Drawing.Size(23, 26)
        Me.btn_Bullet.TabIndex = 8
        Me.btn_Bullet.UseVisualStyleBackColor = True
        '
        'cboxFontSize
        '
        Me.cboxFontSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboxFontSize.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxFontSize.FormattingEnabled = True
        Me.cboxFontSize.Items.AddRange(New Object() {"8", "8.25", "9", "10", "10.5", "11", "12", "14", "16", "18", "20", "24", "28", "32", "36", "40", "44", "48", "54", "60", "66", "72", "80", "88", "96"})
        Me.cboxFontSize.Location = New System.Drawing.Point(116, 3)
        Me.cboxFontSize.Name = "cboxFontSize"
        Me.cboxFontSize.Size = New System.Drawing.Size(52, 25)
        Me.cboxFontSize.TabIndex = 1
        '
        'cboxFontFamily
        '
        Me.cboxFontFamily.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboxFontFamily.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxFontFamily.FormattingEnabled = True
        Me.cboxFontFamily.Items.AddRange(New Object() {"Agency FB", "Agency FB Bold", "Algerian", "Arial Narrow", "Arial Narrow Bold", "Arial Narrow Bold Italic", "Arial Narrow Italic", "Arial Rounded MT Bold", "Arial Unicode MS", "Baskerville Old Face", "Bauhaus 93", "Bell MT", "Bell MT Bold", "Bell MT Italic", "Berlin Sans FB", "Berlin Sans FB Bold", "Berlin Sans FB Demi Bold", "Bernard MT Condensed", "Blackadder ITC", "Bodoni MT", "Bodoni MT Black", "Bodoni MT Black Italic", "Bodoni MT Bold", "Bodoni MT Bold Italic", "Bodoni MT Condensed", "Bodoni MT Condensed Bold", "Bodoni MT Condensed Bold Italic", "Bodoni MT Condensed Italic", "Bodoni MT Italic", "Bodoni MT Poster Compressed", "Book Antiqua", "Book Antiqua Bold", "Book Antiqua Bold Italic", "Book Antiqua Italic", "Bookman Old Style", "Bookman Old Style Bold", "Bookman Old Style Bold Italic", "Bookman Old Style Italic", "Bradley Hand ITC", "Britannic Bold", "Broadway", "Brush Script MT Italic", "Calibri", "Calibri Bold", "Calibri Bold Italic", "Calibri Italic", "Calibri Light (Headings)", "Californian FB", "Californian FB Bold", "Californian FB Italic", "Calisto MT", "Calisto MT Bold", "Calisto MT Bold Italic", "Calisto MT Italic", "Cambria & Cambria Math", "Cambria Bold", "Candara", "Candara Bold", "Candara Italic", "Candara Bold Italic", "Centaur", "Century", "Century Gothic", "Century Gothic Bold", "Century Gothic Italic", "Century Schoolbook", "Century Schoolbook Bold", "Century Schoolbook Bold Italic", "Century Schoolbook Italic", "Chiller", "Colonna MT", "Consolas", "Consolas Bold", "Consolas Bold Italic", "Consolas Italic", "Constantia", "Constantia Bold", "Constantia Bold Italic", "Constantia Italic", "Cooper Black", "Copperplate Gothic Bold", "Copperplate Gothic Light", "Corbel", "Corbel Bold", "Corbel Bold Italic", "Corbel Italic", "Curlz MT", "Edwardian Script ITC", "Elephant", "Elephant Italic", "Engraveras", "Eras Bold ITC", "Eras Demi ITC", "Eras Light ITC", "Eras Medium ITC", "Felix Titling", "Footlight MT Light", "Forte", "Franklin", "Gothic Book", "Franklin Gothic Book Italic", "Franklin Gothic Demi", "Franklin Gothic Demi Cond", "Franklin Gothic Demi Italic", "Franklin Gothic Heavy", "Franklin Gothic Heavy Italic", "Franklin Gothic Medium Cond", "Freestyle Script", "French Script MT", "Garamond", "Garamond Bold", "Garamond Italic", "Gigi", "Gill Sans MT", "Gill Sans MT Bold", "Gill Sans MT Bold Italic", "Gill Sans MT Condensed", "Gill Sans MT Ext Condensed Bold", "Gill Sans MT Italic", "Gill Sans Ultra Bold", "Gill Sans Ultra Bold Condensed", "Gloucester MT Extra Condensed", "Goudy Old Style", "Goudy Old Style Bold", "Goudy Old Style Italic", "Goudy Stout", "Haettenschweiler", "Harlow Solid Italic", "Harrington", "High Tower Text", "High Tower Text Italic", "Imprint MT Shadow", "Informal Roman", "Jokerman", "Juice ITC", "Kristen ITC", "Kunstler Script", "Lucida Bright", "Lucida Bright Demibold", "Lucida Bright Demibold Italic", "Lucida Bright Italic", "Lucida Calligraphy Italic", "Lucida Fax Demibold", "Lucida Fax Demibold Italic", "Lucida Fax Italic", "Lucida Fax Regular", "Lucida Handwriting Italic", "Lucida Sans Demibold Italic", "Lucida Sans Demibold Roman", "Lucida Sans Italic", "Lucida Sans Regular", "Lucida Sans Typewriter Bold", "Lucida Sans Typewriter Bold Oblique", "Lucida Sans Typewriter Oblique", "Lucida Sans Typewriter Regular", "Magneto Bold", "Maiandra GD", "Matura MT Script Capitals", "Mistral", "Modern No. 20", "Monotype Corsiva", "MS Mincho", "MS Outlook", "MS Reference Sans Serif", "MS Reference Specialty", "MT Extra", "Niagara Engraved", "Niagara Solid", "OCR A Extended", "Old English Text MT", "Onyx", "Palace Script MT", "Palatino Linotype", "Palatino Linotype Bold", "Palatino Linotype Bold Italic", "Palatino Linotype Italic", "Papyrus", "Parchment", "Perpetua", "Perpetua Bold", "Perpetua Bold Italic", "Perpetua Italic", "Perpetua Titling MT Bold", "Perpetua Titling MT Light", "Playbill", "Poor Richard", "Pristina", "Rage Italic", "Ravie Rockwell", "Rockwell Bold", "Rockwell Bold Italic", "Rockwell Condensed", "Rockwell Condensed Bold", "Rockwell Extra Bold", "Rockwell Italic", "Script MT Bold", "Segoe UI*", "Segoe UI Bold*", "Segoe UI Bold Italic*", "Segoe UI Italic*", "Showcard Gothic", "Snap ITC", "Stencil", "Tempus Sans ITC", "Tw Cen MT", "Tw Cen MT Bold", "Tw Cen MT Bold Italic", "Tw Cen MT Condensed", "Tw Cen MT Condensed Bold", "Tw Cen MT Condensed Extra Bold", "Tw Cen MT Italic", "Viner Hand ITC", "Vivaldi Italic", "Vladimir Script", "Wide Latin", "Wingdings 2", "Wingdings 3"})
        Me.cboxFontFamily.Location = New System.Drawing.Point(3, 3)
        Me.cboxFontFamily.Name = "cboxFontFamily"
        Me.cboxFontFamily.Size = New System.Drawing.Size(107, 25)
        Me.cboxFontFamily.TabIndex = 0
        '
        'TLP_NotesTools2
        '
        Me.TLP_NotesTools2.ColumnCount = 10
        Me.TLP_NotesTools2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TLP_NotesTools2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TLP_NotesTools2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TLP_NotesTools2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TLP_NotesTools2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TLP_NotesTools2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TLP_NotesTools2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TLP_NotesTools2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TLP_NotesTools2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TLP_NotesTools2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TLP_NotesTools2.Controls.Add(Me.btnUnderline, 2, 0)
        Me.TLP_NotesTools2.Controls.Add(Me.btn_WrapText, 9, 0)
        Me.TLP_NotesTools2.Controls.Add(Me.btnItalic, 1, 0)
        Me.TLP_NotesTools2.Controls.Add(Me.btnPaste, 8, 0)
        Me.TLP_NotesTools2.Controls.Add(Me.btnBold, 0, 0)
        Me.TLP_NotesTools2.Controls.Add(Me.btnCopy, 7, 0)
        Me.TLP_NotesTools2.Controls.Add(Me.btnCut, 6, 0)
        Me.TLP_NotesTools2.Controls.Add(Me.btnAlignRight, 5, 0)
        Me.TLP_NotesTools2.Controls.Add(Me.btnAlignCenter, 4, 0)
        Me.TLP_NotesTools2.Controls.Add(Me.btnAlignLeft, 3, 0)
        Me.TLP_NotesTools2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_NotesTools2.Location = New System.Drawing.Point(3, 41)
        Me.TLP_NotesTools2.Name = "TLP_NotesTools2"
        Me.TLP_NotesTools2.RowCount = 1
        Me.TLP_NotesTools2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_NotesTools2.Size = New System.Drawing.Size(270, 31)
        Me.TLP_NotesTools2.TabIndex = 0
        '
        'btnUnderline
        '
        Me.btnUnderline.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnUnderline.BackgroundImage = CType(resources.GetObject("btnUnderline.BackgroundImage"), System.Drawing.Image)
        Me.btnUnderline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnUnderline.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUnderline.FlatAppearance.BorderSize = 0
        Me.btnUnderline.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUnderline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUnderline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnderline.Location = New System.Drawing.Point(54, 0)
        Me.btnUnderline.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUnderline.Name = "btnUnderline"
        Me.btnUnderline.Size = New System.Drawing.Size(27, 31)
        Me.btnUnderline.TabIndex = 6
        Me.btnUnderline.UseVisualStyleBackColor = True
        '
        'btn_WrapText
        '
        Me.btn_WrapText.Appearance = System.Windows.Forms.Appearance.Button
        Me.btn_WrapText.BackgroundImage = CType(resources.GetObject("btn_WrapText.BackgroundImage"), System.Drawing.Image)
        Me.btn_WrapText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_WrapText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_WrapText.FlatAppearance.BorderSize = 0
        Me.btn_WrapText.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_WrapText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_WrapText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_WrapText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_WrapText.Location = New System.Drawing.Point(243, 0)
        Me.btn_WrapText.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_WrapText.Name = "btn_WrapText"
        Me.btn_WrapText.Size = New System.Drawing.Size(27, 31)
        Me.btn_WrapText.TabIndex = 9
        Me.btn_WrapText.UseVisualStyleBackColor = True
        '
        'btnItalic
        '
        Me.btnItalic.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnItalic.BackgroundImage = CType(resources.GetObject("btnItalic.BackgroundImage"), System.Drawing.Image)
        Me.btnItalic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnItalic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnItalic.FlatAppearance.BorderSize = 0
        Me.btnItalic.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnItalic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnItalic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItalic.Location = New System.Drawing.Point(27, 0)
        Me.btnItalic.Margin = New System.Windows.Forms.Padding(0)
        Me.btnItalic.Name = "btnItalic"
        Me.btnItalic.Size = New System.Drawing.Size(27, 31)
        Me.btnItalic.TabIndex = 5
        Me.btnItalic.UseVisualStyleBackColor = True
        '
        'btnPaste
        '
        Me.btnPaste.BackgroundImage = CType(resources.GetObject("btnPaste.BackgroundImage"), System.Drawing.Image)
        Me.btnPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPaste.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPaste.FlatAppearance.BorderSize = 0
        Me.btnPaste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPaste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaste.Location = New System.Drawing.Point(216, 0)
        Me.btnPaste.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(27, 31)
        Me.btnPaste.TabIndex = 8
        Me.btnPaste.UseVisualStyleBackColor = True
        '
        'btnBold
        '
        Me.btnBold.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnBold.BackgroundImage = CType(resources.GetObject("btnBold.BackgroundImage"), System.Drawing.Image)
        Me.btnBold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBold.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBold.FlatAppearance.BorderSize = 0
        Me.btnBold.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBold.Location = New System.Drawing.Point(0, 0)
        Me.btnBold.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBold.Name = "btnBold"
        Me.btnBold.Size = New System.Drawing.Size(27, 31)
        Me.btnBold.TabIndex = 4
        Me.btnBold.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.BackgroundImage = CType(resources.GetObject("btnCopy.BackgroundImage"), System.Drawing.Image)
        Me.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCopy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCopy.FlatAppearance.BorderSize = 0
        Me.btnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopy.Location = New System.Drawing.Point(189, 0)
        Me.btnCopy.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(27, 31)
        Me.btnCopy.TabIndex = 7
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnCut
        '
        Me.btnCut.BackgroundImage = CType(resources.GetObject("btnCut.BackgroundImage"), System.Drawing.Image)
        Me.btnCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCut.FlatAppearance.BorderSize = 0
        Me.btnCut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCut.Location = New System.Drawing.Point(162, 0)
        Me.btnCut.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCut.Name = "btnCut"
        Me.btnCut.Size = New System.Drawing.Size(27, 31)
        Me.btnCut.TabIndex = 6
        Me.btnCut.UseVisualStyleBackColor = True
        '
        'btnAlignRight
        '
        Me.btnAlignRight.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnAlignRight.BackgroundImage = CType(resources.GetObject("btnAlignRight.BackgroundImage"), System.Drawing.Image)
        Me.btnAlignRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAlignRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAlignRight.FlatAppearance.BorderSize = 0
        Me.btnAlignRight.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlignRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAlignRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlignRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlignRight.Location = New System.Drawing.Point(135, 0)
        Me.btnAlignRight.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAlignRight.Name = "btnAlignRight"
        Me.btnAlignRight.Size = New System.Drawing.Size(27, 31)
        Me.btnAlignRight.TabIndex = 4
        Me.btnAlignRight.UseVisualStyleBackColor = True
        '
        'btnAlignCenter
        '
        Me.btnAlignCenter.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnAlignCenter.BackgroundImage = CType(resources.GetObject("btnAlignCenter.BackgroundImage"), System.Drawing.Image)
        Me.btnAlignCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAlignCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAlignCenter.FlatAppearance.BorderSize = 0
        Me.btnAlignCenter.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlignCenter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAlignCenter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlignCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlignCenter.Location = New System.Drawing.Point(108, 0)
        Me.btnAlignCenter.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAlignCenter.Name = "btnAlignCenter"
        Me.btnAlignCenter.Size = New System.Drawing.Size(27, 31)
        Me.btnAlignCenter.TabIndex = 5
        Me.btnAlignCenter.UseVisualStyleBackColor = True
        '
        'btnAlignLeft
        '
        Me.btnAlignLeft.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnAlignLeft.BackgroundImage = CType(resources.GetObject("btnAlignLeft.BackgroundImage"), System.Drawing.Image)
        Me.btnAlignLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAlignLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAlignLeft.FlatAppearance.BorderSize = 0
        Me.btnAlignLeft.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlignLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAlignLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlignLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlignLeft.Location = New System.Drawing.Point(81, 0)
        Me.btnAlignLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAlignLeft.Name = "btnAlignLeft"
        Me.btnAlignLeft.Size = New System.Drawing.Size(27, 31)
        Me.btnAlignLeft.TabIndex = 3
        Me.btnAlignLeft.UseVisualStyleBackColor = True
        '
        'TLP_SHOWHIDE
        '
        Me.TLP_SHOWHIDE.ColumnCount = 1
        Me.TLP_SHOWHIDE.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_SHOWHIDE.Controls.Add(Me.txtNotes, 0, 1)
        Me.TLP_SHOWHIDE.Controls.Add(Me.btn_HideNotes, 0, 0)
        Me.TLP_SHOWHIDE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_SHOWHIDE.Location = New System.Drawing.Point(0, 0)
        Me.TLP_SHOWHIDE.Name = "TLP_SHOWHIDE"
        Me.TLP_SHOWHIDE.RowCount = 2
        Me.TLP_SHOWHIDE.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TLP_SHOWHIDE.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_SHOWHIDE.Size = New System.Drawing.Size(276, 68)
        Me.TLP_SHOWHIDE.TabIndex = 1
        '
        'txtNotes
        '
        Me.txtNotes.BackColor = System.Drawing.Color.White
        Me.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNotes.Location = New System.Drawing.Point(3, 39)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(270, 26)
        Me.txtNotes.TabIndex = 0
        Me.txtNotes.Text = ""
        '
        'btn_HideNotes
        '
        Me.btn_HideNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_HideNotes.Location = New System.Drawing.Point(3, 3)
        Me.btn_HideNotes.Name = "btn_HideNotes"
        Me.btn_HideNotes.Size = New System.Drawing.Size(270, 30)
        Me.btn_HideNotes.TabIndex = 1
        Me.btn_HideNotes.Text = "Hide Notes"
        Me.btn_HideNotes.UseVisualStyleBackColor = True
        '
        'ImageList_Pattern
        '
        Me.ImageList_Pattern.ImageStream = CType(resources.GetObject("ImageList_Pattern.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Pattern.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Pattern.Images.SetKeyName(0, "Pattern_0000_1,1.png")
        Me.ImageList_Pattern.Images.SetKeyName(1, "Pattern_0001_1,2.png")
        Me.ImageList_Pattern.Images.SetKeyName(2, "Pattern_0002_1,3.png")
        Me.ImageList_Pattern.Images.SetKeyName(3, "Pattern_0003_1,4.png")
        Me.ImageList_Pattern.Images.SetKeyName(4, "Pattern_0004_1,5.png")
        Me.ImageList_Pattern.Images.SetKeyName(5, "Pattern_0005_1,6.png")
        Me.ImageList_Pattern.Images.SetKeyName(6, "Pattern_0006_2,1.png")
        Me.ImageList_Pattern.Images.SetKeyName(7, "Pattern_0007_2,2.png")
        Me.ImageList_Pattern.Images.SetKeyName(8, "Pattern_0008_2,3.png")
        Me.ImageList_Pattern.Images.SetKeyName(9, "Pattern_0009_2,4.png")
        Me.ImageList_Pattern.Images.SetKeyName(10, "Pattern_0010_2,5.png")
        Me.ImageList_Pattern.Images.SetKeyName(11, "Pattern_0011_2,6.png")
        Me.ImageList_Pattern.Images.SetKeyName(12, "Pattern_0012_3,1.png")
        Me.ImageList_Pattern.Images.SetKeyName(13, "Pattern_0013_3,2.png")
        Me.ImageList_Pattern.Images.SetKeyName(14, "Pattern_0014_3,3.png")
        Me.ImageList_Pattern.Images.SetKeyName(15, "Pattern_0015_3,4.png")
        Me.ImageList_Pattern.Images.SetKeyName(16, "Pattern_0016_3,5.png")
        Me.ImageList_Pattern.Images.SetKeyName(17, "Pattern_0017_3,6.png")
        Me.ImageList_Pattern.Images.SetKeyName(18, "Pattern_0018_4,1.png")
        Me.ImageList_Pattern.Images.SetKeyName(19, "Pattern_0019_4,2.png")
        Me.ImageList_Pattern.Images.SetKeyName(20, "Pattern_0020_4,3.png")
        Me.ImageList_Pattern.Images.SetKeyName(21, "Pattern_0021_4,4.png")
        Me.ImageList_Pattern.Images.SetKeyName(22, "Pattern_0022_4,5.png")
        Me.ImageList_Pattern.Images.SetKeyName(23, "Pattern_0023_4,6.png")
        Me.ImageList_Pattern.Images.SetKeyName(24, "Pattern_0024_5,1.png")
        Me.ImageList_Pattern.Images.SetKeyName(25, "Pattern_0025_5,2.png")
        Me.ImageList_Pattern.Images.SetKeyName(26, "Pattern_0026_5,3.png")
        Me.ImageList_Pattern.Images.SetKeyName(27, "Pattern_0027_5,4.png")
        Me.ImageList_Pattern.Images.SetKeyName(28, "Pattern_0028_5,5.png")
        Me.ImageList_Pattern.Images.SetKeyName(29, "Pattern_0029_5,6.png")
        Me.ImageList_Pattern.Images.SetKeyName(30, "Pattern_0030_6,1.png")
        Me.ImageList_Pattern.Images.SetKeyName(31, "Pattern_0031_6,2.png")
        Me.ImageList_Pattern.Images.SetKeyName(32, "Pattern_0032_6,3.png")
        Me.ImageList_Pattern.Images.SetKeyName(33, "Pattern_0033_6,4.png")
        Me.ImageList_Pattern.Images.SetKeyName(34, "Pattern_0034_6,5.png")
        Me.ImageList_Pattern.Images.SetKeyName(35, "Pattern_0035_6,6.png")
        Me.ImageList_Pattern.Images.SetKeyName(36, "Pattern_0036_7,1.png")
        Me.ImageList_Pattern.Images.SetKeyName(37, "Pattern_0037_7,2.png")
        Me.ImageList_Pattern.Images.SetKeyName(38, "Pattern_0038_7,3.png")
        Me.ImageList_Pattern.Images.SetKeyName(39, "Pattern_0039_7,4.png")
        Me.ImageList_Pattern.Images.SetKeyName(40, "Pattern_0040_7,5.png")
        Me.ImageList_Pattern.Images.SetKeyName(41, "Pattern_0041_7,6.png")
        Me.ImageList_Pattern.Images.SetKeyName(42, "Pattern_0042_8,1.png")
        Me.ImageList_Pattern.Images.SetKeyName(43, "Pattern_0043_8,2.png")
        Me.ImageList_Pattern.Images.SetKeyName(44, "Pattern_0044_8,3.png")
        Me.ImageList_Pattern.Images.SetKeyName(45, "Pattern_0045_8,4.png")
        Me.ImageList_Pattern.Images.SetKeyName(46, "Pattern_0046_8,5.png")
        Me.ImageList_Pattern.Images.SetKeyName(47, "Pattern_0047_8,6.png")
        '
        'OpenFileDialog_PictureFill
        '
        Me.OpenFileDialog_PictureFill.FileName = "OpenFileDialog1"
        '
        'ImageList_Texture
        '
        Me.ImageList_Texture.ImageStream = CType(resources.GetObject("ImageList_Texture.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Texture.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Texture.Images.SetKeyName(0, "1,1.png")
        Me.ImageList_Texture.Images.SetKeyName(1, "1,2.png")
        Me.ImageList_Texture.Images.SetKeyName(2, "1,3.png")
        Me.ImageList_Texture.Images.SetKeyName(3, "1,4.png")
        Me.ImageList_Texture.Images.SetKeyName(4, "1,5.png")
        Me.ImageList_Texture.Images.SetKeyName(5, "2,1.png")
        Me.ImageList_Texture.Images.SetKeyName(6, "2,2.png")
        Me.ImageList_Texture.Images.SetKeyName(7, "2,3.png")
        Me.ImageList_Texture.Images.SetKeyName(8, "2,4.png")
        Me.ImageList_Texture.Images.SetKeyName(9, "2,5.png")
        Me.ImageList_Texture.Images.SetKeyName(10, "3,1.png")
        Me.ImageList_Texture.Images.SetKeyName(11, "3,2.png")
        Me.ImageList_Texture.Images.SetKeyName(12, "3,3.png")
        Me.ImageList_Texture.Images.SetKeyName(13, "3,4.png")
        Me.ImageList_Texture.Images.SetKeyName(14, "3,5.png")
        Me.ImageList_Texture.Images.SetKeyName(15, "4,1.png")
        Me.ImageList_Texture.Images.SetKeyName(16, "4,2.png")
        Me.ImageList_Texture.Images.SetKeyName(17, "4,3.png")
        Me.ImageList_Texture.Images.SetKeyName(18, "4,4.png")
        Me.ImageList_Texture.Images.SetKeyName(19, "4,5.png")
        Me.ImageList_Texture.Images.SetKeyName(20, "5,1.png")
        Me.ImageList_Texture.Images.SetKeyName(21, "5,2.png")
        Me.ImageList_Texture.Images.SetKeyName(22, "5,3.png")
        Me.ImageList_Texture.Images.SetKeyName(23, "5,4.png")
        '
        'PowerPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Scont_A)
        Me.Name = "PowerPanel"
        Me.Size = New System.Drawing.Size(276, 559)
        Me.Scont_A.Panel1.ResumeLayout(False)
        Me.Scont_A.Panel2.ResumeLayout(False)
        CType(Me.Scont_A, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scont_A.ResumeLayout(False)
        Me.TLP_Alignment.ResumeLayout(False)
        Me.Scont_B.Panel1.ResumeLayout(False)
        Me.Scont_B.Panel2.ResumeLayout(False)
        CType(Me.Scont_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scont_B.ResumeLayout(False)
        Me.TabControl_Format.ResumeLayout(False)
        Me.TabPage_SizeProperties.ResumeLayout(False)
        Me.Panel_total.ResumeLayout(False)
        Me.Scont_TextFormat.Panel1.ResumeLayout(False)
        Me.Scont_TextFormat.Panel2.ResumeLayout(False)
        CType(Me.Scont_TextFormat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scont_TextFormat.ResumeLayout(False)
        Me.Panel_TextFormat.ResumeLayout(False)
        Me.TLP_FormatText.ResumeLayout(False)
        Me.TLP_FormatText.PerformLayout()
        Me.Gbox_InternalMargin.ResumeLayout(False)
        Me.TLP_InternalMargin.ResumeLayout(False)
        Me.TLP_TopMargin.ResumeLayout(False)
        Me.TLP_TopMargin.PerformLayout()
        CType(Me.num_TopMargin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLP_LeftMargin.ResumeLayout(False)
        Me.TLP_LeftMargin.PerformLayout()
        CType(Me.num_LeftMargin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLP_RightMargin.ResumeLayout(False)
        Me.TLP_RightMargin.PerformLayout()
        CType(Me.num_RightMargin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLP_BottomMargin.ResumeLayout(False)
        Me.TLP_BottomMargin.PerformLayout()
        CType(Me.num_BotMargin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbox_TextLayout.ResumeLayout(False)
        Me.TLP_TextLayout.ResumeLayout(False)
        Me.TLP_TextLayout.PerformLayout()
        Me.Gbox_AutoFit.ResumeLayout(False)
        Me.TLP_AutoFit.ResumeLayout(False)
        Me.TLP_AutoFit.PerformLayout()
        Me.Scont_ShapeFormat.Panel1.ResumeLayout(False)
        Me.Scont_ShapeFormat.Panel2.ResumeLayout(False)
        CType(Me.Scont_ShapeFormat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scont_ShapeFormat.ResumeLayout(False)
        Me.Panel_ShapeFormat.ResumeLayout(False)
        Me.TLP_FormatShape.ResumeLayout(False)
        Me.Gbox_SizeandRotate.ResumeLayout(False)
        Me.TLP_SizeAndRotate.ResumeLayout(False)
        Me.TLP_Rotation.ResumeLayout(False)
        Me.TLP_Rotation.PerformLayout()
        CType(Me.num_Rot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLP_Height.ResumeLayout(False)
        Me.TLP_Height.PerformLayout()
        CType(Me.num_Height, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLP_Width.ResumeLayout(False)
        Me.TLP_Width.PerformLayout()
        CType(Me.num_Width, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbox_Scale.ResumeLayout(False)
        Me.TLP_Scale.ResumeLayout(False)
        Me.TLP_Scale.PerformLayout()
        Me.TLP_ScaleDimensions.ResumeLayout(False)
        Me.TLP_HeightScale.ResumeLayout(False)
        Me.TLP_HeightScale.PerformLayout()
        CType(Me.num_ScaleHeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLP_WidthScale.ResumeLayout(False)
        Me.TLP_WidthScale.PerformLayout()
        CType(Me.num_ScaleWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbox_OriginalSize.ResumeLayout(False)
        Me.TLP_OriginalSize.ResumeLayout(False)
        Me.TLP_OriginalSizeInner.ResumeLayout(False)
        Me.TLP_OriginalWidth.ResumeLayout(False)
        Me.TLP_OriginalWidth.PerformLayout()
        Me.TLP_OriginalHeight.ResumeLayout(False)
        Me.TLP_OriginalHeight.PerformLayout()
        Me.TabPage_FillAndLine.ResumeLayout(False)
        Me.panel_FillAndLine.ResumeLayout(False)
        Me.Scont_Fill.Panel1.ResumeLayout(False)
        Me.Scont_Fill.Panel2.ResumeLayout(False)
        CType(Me.Scont_Fill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scont_Fill.ResumeLayout(False)
        Me.Panel_BackgroundFill.ResumeLayout(False)
        Me.Panel_BackgroundFill.PerformLayout()
        Me.Scont_PatternFilling.Panel1.ResumeLayout(False)
        Me.Scont_PatternFilling.Panel1.PerformLayout()
        Me.Scont_PatternFilling.Panel2.ResumeLayout(False)
        CType(Me.Scont_PatternFilling, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scont_PatternFilling.ResumeLayout(False)
        Me.TLP_Ptrnfill1.ResumeLayout(False)
        Me.TLP_Ptrnfill2.ResumeLayout(False)
        Me.TLP_Ptrnfill2.PerformLayout()
        Me.TLP_Patternimage.ResumeLayout(False)
        Me.Scont_TextureFill.Panel1.ResumeLayout(False)
        Me.Scont_TextureFill.Panel1.PerformLayout()
        Me.Scont_TextureFill.Panel2.ResumeLayout(False)
        CType(Me.Scont_TextureFill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scont_TextureFill.ResumeLayout(False)
        Me.TLP_Texture.ResumeLayout(False)
        Me.TLP_Texture.PerformLayout()
        Me.Gbox_Texture.ResumeLayout(False)
        Me.TLP_InsertTxtureFrom.ResumeLayout(False)
        Me.TLP_InsertTxtureFrom.PerformLayout()
        Me.TLP_TranspTexture.ResumeLayout(False)
        Me.TLP_TranspTexture.PerformLayout()
        CType(Me.num_TranspTexture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scont_TxtrVsPctr.Panel1.ResumeLayout(False)
        Me.Scont_TxtrVsPctr.Panel2.ResumeLayout(False)
        CType(Me.Scont_TxtrVsPctr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scont_TxtrVsPctr.ResumeLayout(False)
        Me.TLP_PictureFill.ResumeLayout(False)
        Me.TLP_PictureFill.PerformLayout()
        CType(Me.num_offsetleft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_offsetright, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_offsettop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_offsetbot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLP_TextureFill.ResumeLayout(False)
        Me.TLP_TextureFill.PerformLayout()
        CType(Me.num_OffsetX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_offsetY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_ScaleXFill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_ScaleYFill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scont_GradentFill.Panel1.ResumeLayout(False)
        Me.Scont_GradentFill.Panel1.PerformLayout()
        Me.Scont_GradentFill.Panel2.ResumeLayout(False)
        CType(Me.Scont_GradentFill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scont_GradentFill.ResumeLayout(False)
        Me.TLP_GradientFill.ResumeLayout(False)
        Me.TLP_GradientFill.PerformLayout()
        CType(Me.num_TranspGradient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scont_SolidFill.Panel1.ResumeLayout(False)
        Me.Scont_SolidFill.Panel1.PerformLayout()
        Me.Scont_SolidFill.Panel2.ResumeLayout(False)
        CType(Me.Scont_SolidFill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scont_SolidFill.ResumeLayout(False)
        Me.TLP_SolidFill.ResumeLayout(False)
        Me.TLP_SolidFill.PerformLayout()
        CType(Me.num_Transparency, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_NoFill.ResumeLayout(False)
        Me.Panel_NoFill.PerformLayout()
        Me.Scont_C.Panel1.ResumeLayout(False)
        Me.Scont_C.Panel2.ResumeLayout(False)
        CType(Me.Scont_C, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scont_C.ResumeLayout(False)
        Me.TLP_Notes.ResumeLayout(False)
        Me.TLP_NotesTools1.ResumeLayout(False)
        Me.TLP_NotesToolsinner.ResumeLayout(False)
        Me.TLP_NotesTools2.ResumeLayout(False)
        Me.TLP_SHOWHIDE.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Scont_A As System.Windows.Forms.SplitContainer
    Friend WithEvents Scont_B As System.Windows.Forms.SplitContainer
    Friend WithEvents TLP_Alignment As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_FormatShape As System.Windows.Forms.Button
    Friend WithEvents btn_AlignBottom As System.Windows.Forms.Button
    Friend WithEvents btn_AlignRight As System.Windows.Forms.Button
    Friend WithEvents btn_AlignTop As System.Windows.Forms.Button
    Friend WithEvents btn_AlignLeft As System.Windows.Forms.Button
    Friend WithEvents btn_DistVer As System.Windows.Forms.Button
    Friend WithEvents btn_DistHor As System.Windows.Forms.Button
    Friend WithEvents btn_AlignMiddle As System.Windows.Forms.Button
    Friend WithEvents btn_AlignCenter As System.Windows.Forms.Button
    Friend WithEvents btn_Paragraph As System.Windows.Forms.Button
    Friend WithEvents btn_DistRows As System.Windows.Forms.Button
    Friend WithEvents btn_DistColumns As System.Windows.Forms.Button
    Friend WithEvents btn_BorderAll As System.Windows.Forms.Button
    Friend WithEvents btn_BorderRight As System.Windows.Forms.Button
    Friend WithEvents btn_BorderLeft As System.Windows.Forms.Button
    Friend WithEvents btn_BorderBottom As System.Windows.Forms.Button
    Friend WithEvents btn_BorderTop As System.Windows.Forms.Button
    Friend WithEvents btn_BringForward As System.Windows.Forms.Button
    Friend WithEvents btn_SendtoBack As System.Windows.Forms.Button
    Friend WithEvents btn_PasteText As System.Windows.Forms.Button
    Friend WithEvents Scont_C As System.Windows.Forms.SplitContainer
    Friend WithEvents txtNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents TLP_Notes As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TLP_NotesTools2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cboxFontFamily As System.Windows.Forms.ComboBox
    Friend WithEvents cboxFontSize As System.Windows.Forms.ComboBox
    Friend WithEvents TLP_NotesToolsinner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TLP_NotesTools1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnAlignLeft As System.Windows.Forms.CheckBox
    Friend WithEvents btn_WrapText As System.Windows.Forms.CheckBox
    Friend WithEvents btnPaste As System.Windows.Forms.Button
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents btnCut As System.Windows.Forms.Button
    Friend WithEvents btnAlignRight As System.Windows.Forms.CheckBox
    Friend WithEvents btnAlignCenter As System.Windows.Forms.CheckBox
    Friend WithEvents btn_IndentDec As System.Windows.Forms.Button
    Friend WithEvents btn_Bullet As System.Windows.Forms.CheckBox
    Friend WithEvents btn_IndentInc As System.Windows.Forms.Button
    Friend WithEvents btn_Reset As System.Windows.Forms.Button
    Friend WithEvents Scont_TextFormat As System.Windows.Forms.SplitContainer
    Friend WithEvents chkbx_TextFormat As System.Windows.Forms.CheckBox
    Friend WithEvents chkbx_ShapeFormat As System.Windows.Forms.CheckBox
    Friend WithEvents Scont_ShapeFormat As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel_TextFormat As System.Windows.Forms.Panel
    Friend WithEvents Panel_ShapeFormat As System.Windows.Forms.Panel
    Friend WithEvents Panel_total As System.Windows.Forms.Panel
    Friend WithEvents TLP_FormatText As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkbxWrap As System.Windows.Forms.CheckBox
    Friend WithEvents Gbox_InternalMargin As System.Windows.Forms.GroupBox
    Friend WithEvents TLP_InternalMargin As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TLP_LeftMargin As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblLeft As System.Windows.Forms.Label
    Friend WithEvents num_LeftMargin As System.Windows.Forms.NumericUpDown
    Friend WithEvents TLP_TopMargin As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTop As System.Windows.Forms.Label
    Friend WithEvents num_TopMargin As System.Windows.Forms.NumericUpDown
    Friend WithEvents TLP_BottomMargin As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblBottom As System.Windows.Forms.Label
    Friend WithEvents num_BotMargin As System.Windows.Forms.NumericUpDown
    Friend WithEvents TLP_RightMargin As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblRight As System.Windows.Forms.Label
    Friend WithEvents num_RightMargin As System.Windows.Forms.NumericUpDown
    Friend WithEvents Gbox_TextLayout As System.Windows.Forms.GroupBox
    Friend WithEvents Gbox_AutoFit As System.Windows.Forms.GroupBox
    Friend WithEvents TLP_TextLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblVerticalAlignment As System.Windows.Forms.Label
    Friend WithEvents lblTextDirection As System.Windows.Forms.Label
    Friend WithEvents cboxtextalignment As System.Windows.Forms.ComboBox
    Friend WithEvents cboxtextdirection As System.Windows.Forms.ComboBox
    Friend WithEvents TLP_AutoFit As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ResizeShape As System.Windows.Forms.RadioButton
    Friend WithEvents ShrinkText As System.Windows.Forms.RadioButton
    Friend WithEvents Donotautofit As System.Windows.Forms.RadioButton
    Friend WithEvents btnUnderline As System.Windows.Forms.CheckBox
    Friend WithEvents btnItalic As System.Windows.Forms.CheckBox
    Friend WithEvents btnBold As System.Windows.Forms.CheckBox
    Friend WithEvents TLP_FormatShape As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Gbox_SizeandRotate As System.Windows.Forms.GroupBox
    Friend WithEvents TLP_SizeAndRotate As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TLP_Rotation As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Size_Rotation As System.Windows.Forms.Label
    Friend WithEvents num_Rot As System.Windows.Forms.NumericUpDown
    Friend WithEvents TLP_Width As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Size_Width As System.Windows.Forms.Label
    Friend WithEvents num_Width As System.Windows.Forms.NumericUpDown
    Friend WithEvents Gbox_Scale As System.Windows.Forms.GroupBox
    Friend WithEvents TLP_Scale As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkbx_BestScale As System.Windows.Forms.CheckBox
    Friend WithEvents chkbx_RelativeOrig As System.Windows.Forms.CheckBox
    Friend WithEvents chkbx_LockAspectRatio As System.Windows.Forms.CheckBox
    Friend WithEvents TLP_ScaleDimensions As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TLP_WidthScale As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Size_ScaleWidth As System.Windows.Forms.Label
    Friend WithEvents num_ScaleWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents TLP_HeightScale As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Size_ScaleHeight As System.Windows.Forms.Label
    Friend WithEvents num_ScaleHeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents Gbox_OriginalSize As System.Windows.Forms.GroupBox
    Friend WithEvents TLP_OriginalSize As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_ResetOriginalSize As System.Windows.Forms.Button
    Friend WithEvents TLP_OriginalSizeInner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TLP_OriginalWidth As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txt_OriginalWidth As System.Windows.Forms.TextBox
    Friend WithEvents Size_OriginalWidth As System.Windows.Forms.Label
    Friend WithEvents TLP_OriginalHeight As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txt_OriginalHeight As System.Windows.Forms.TextBox
    Friend WithEvents Size_OriginalHeight As System.Windows.Forms.Label
    Friend WithEvents TLP_Height As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Size_Height As System.Windows.Forms.Label
    Friend WithEvents num_Height As System.Windows.Forms.NumericUpDown
    Friend WithEvents TabControl_Format As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_SizeProperties As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_FillAndLine As System.Windows.Forms.TabPage
    Friend WithEvents panel_FillAndLine As System.Windows.Forms.Panel
    Friend WithEvents Scont_Fill As System.Windows.Forms.SplitContainer
    Friend WithEvents chkbx_Fill As System.Windows.Forms.CheckBox
    Friend WithEvents Scont_SolidFill As System.Windows.Forms.SplitContainer
    Friend WithEvents Rbtn_SolidFill As System.Windows.Forms.RadioButton
    Friend WithEvents TLP_SolidFill As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents num_Transparency As System.Windows.Forms.NumericUpDown
    Friend WithEvents btn_SolidFillColor As System.Windows.Forms.Button
    Friend WithEvents ColorDialog_SolidFill As System.Windows.Forms.ColorDialog
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Scont_GradentFill As System.Windows.Forms.SplitContainer
    Friend WithEvents Rbtn_Gradient As System.Windows.Forms.RadioButton
    Friend WithEvents TLP_GradientFill As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents num_TranspGradient As System.Windows.Forms.NumericUpDown
    Friend WithEvents btn_ColorGradientFill As System.Windows.Forms.Button
    Friend WithEvents Panel_NoFill As System.Windows.Forms.Panel
    Friend WithEvents Rbtn_NoFill As System.Windows.Forms.RadioButton
    Friend WithEvents Panel_BackgroundFill As System.Windows.Forms.Panel
    Friend WithEvents Rbtn_BackgroundFill As System.Windows.Forms.RadioButton
    Friend WithEvents ImageList_Pattern As System.Windows.Forms.ImageList
    Friend WithEvents Scont_PatternFilling As System.Windows.Forms.SplitContainer
    Friend WithEvents Rbtn_PatternFilling As System.Windows.Forms.RadioButton
    Friend WithEvents TLP_Ptrnfill1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TLP_Ptrnfill2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_PatternFores As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_patternBacks As System.Windows.Forms.Button
    Friend WithEvents TLP_Patternimage As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TLP_SHOWHIDE As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_HideNotes As System.Windows.Forms.Button
    Friend WithEvents RadioButton43 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton44 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton45 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton46 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton47 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton48 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton37 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton38 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton39 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton40 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton41 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton42 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton31 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton32 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton33 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton34 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton35 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton36 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton25 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton26 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton27 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton28 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton29 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton30 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton19 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton20 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton21 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton22 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton23 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton24 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton13 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton14 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton15 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton16 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton17 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton18 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton11 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton12 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Scont_TextureFill As System.Windows.Forms.SplitContainer
    Friend WithEvents Rbtn_TextureFill As System.Windows.Forms.RadioButton
    Friend WithEvents TLP_Texture As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TLP_InsertTxtureFrom As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_FileTexture As System.Windows.Forms.Button
    Friend WithEvents Gbox_Texture As System.Windows.Forms.GroupBox
    Friend WithEvents btn_ClipboardTexture As System.Windows.Forms.Button
    Friend WithEvents TLP_TranspTexture As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents num_TranspTexture As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkbx_RotateWithShape As System.Windows.Forms.CheckBox
    Friend WithEvents chkbx_texture As System.Windows.Forms.CheckBox
    Friend WithEvents Scont_TxtrVsPctr As System.Windows.Forms.SplitContainer
    Friend WithEvents TLP_PictureFill As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents num_offsetleft As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_offsetright As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_offsettop As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_offsetbot As System.Windows.Forms.NumericUpDown
    Friend WithEvents TLP_TextureFill As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents num_OffsetX As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_offsetY As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_ScaleXFill As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_ScaleYFill As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbox_AlignmentTexture As System.Windows.Forms.ComboBox
    Friend WithEvents cbox_MirrorTexture As System.Windows.Forms.ComboBox
    Friend WithEvents OpenFileDialog_PictureFill As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ImageList_Texture As System.Windows.Forms.ImageList
    Friend WithEvents btn_TexturePreset As System.Windows.Forms.CheckBox
    Friend WithEvents btn_ShowNotes As System.Windows.Forms.Button
    Friend WithEvents btn_ShowNotes2 As System.Windows.Forms.Button

End Class
