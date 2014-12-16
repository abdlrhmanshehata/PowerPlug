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
        Me.Scont_C = New System.Windows.Forms.SplitContainer()
        Me.TLP_Notes = New System.Windows.Forms.TableLayoutPanel()
        Me.TLP_NotesTools1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_IndentInc = New System.Windows.Forms.Button()
        Me.btn_Reset = New System.Windows.Forms.Button()
        Me.btn_IndentDec = New System.Windows.Forms.Button()
        Me.btn_Bullet = New System.Windows.Forms.CheckBox()
        Me.cboxFontSize = New System.Windows.Forms.ComboBox()
        Me.cboxFontFamily = New System.Windows.Forms.ComboBox()
        Me.TLP_NotesTools2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_WrapText = New System.Windows.Forms.CheckBox()
        Me.btnPaste = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnCut = New System.Windows.Forms.Button()
        Me.btnAlignRight = New System.Windows.Forms.CheckBox()
        Me.btnAlignCenter = New System.Windows.Forms.CheckBox()
        Me.btnitalic = New System.Windows.Forms.Button()
        Me.btnunderline = New System.Windows.Forms.Button()
        Me.btnAlignLeft = New System.Windows.Forms.CheckBox()
        Me.btnBold = New System.Windows.Forms.Button()
        Me.txtNotes = New System.Windows.Forms.RichTextBox()
        Me.Scont_TextFormat = New System.Windows.Forms.SplitContainer()
        Me.chkbx_TextFormat = New System.Windows.Forms.CheckBox()
        Me.chkbx_ShapeFormat = New System.Windows.Forms.CheckBox()
        Me.Scont_ShapeFormat = New System.Windows.Forms.SplitContainer()
        Me.Panel_TextFormat = New System.Windows.Forms.Panel()
        Me.Panel_ShapeFormat = New System.Windows.Forms.Panel()
        Me.Panel_total = New System.Windows.Forms.Panel()
        Me.TLP_FormatText = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Gbox_InternalMargin = New System.Windows.Forms.GroupBox()
        CType(Me.Scont_A, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scont_A.Panel1.SuspendLayout()
        Me.Scont_A.Panel2.SuspendLayout()
        Me.Scont_A.SuspendLayout()
        Me.TLP_Alignment.SuspendLayout()
        CType(Me.Scont_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scont_B.Panel1.SuspendLayout()
        Me.Scont_B.Panel2.SuspendLayout()
        Me.Scont_B.SuspendLayout()
        CType(Me.Scont_C, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scont_C.Panel1.SuspendLayout()
        Me.Scont_C.Panel2.SuspendLayout()
        Me.Scont_C.SuspendLayout()
        Me.TLP_Notes.SuspendLayout()
        Me.TLP_NotesTools1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TLP_NotesTools2.SuspendLayout()
        CType(Me.Scont_TextFormat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scont_TextFormat.Panel1.SuspendLayout()
        Me.Scont_TextFormat.Panel2.SuspendLayout()
        Me.Scont_TextFormat.SuspendLayout()
        CType(Me.Scont_ShapeFormat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scont_ShapeFormat.Panel1.SuspendLayout()
        Me.Scont_ShapeFormat.Panel2.SuspendLayout()
        Me.Scont_ShapeFormat.SuspendLayout()
        Me.Panel_total.SuspendLayout()
        Me.TLP_FormatText.SuspendLayout()
        Me.SuspendLayout()
        '
        'Scont_A
        '
        Me.Scont_A.Dock = System.Windows.Forms.DockStyle.Left
        Me.Scont_A.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
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
        Me.Scont_A.Size = New System.Drawing.Size(293, 553)
        Me.Scont_A.SplitterDistance = 60
        Me.Scont_A.TabIndex = 0
        '
        'TLP_Alignment
        '
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
        Me.TLP_Alignment.Size = New System.Drawing.Size(293, 60)
        Me.TLP_Alignment.TabIndex = 1
        '
        'btn_FormatShape
        '
        Me.btn_FormatShape.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._32
        Me.btn_FormatShape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_FormatShape.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_FormatShape.FlatAppearance.BorderSize = 0
        Me.btn_FormatShape.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_FormatShape.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_FormatShape.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_FormatShape.Location = New System.Drawing.Point(208, 30)
        Me.btn_FormatShape.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_FormatShape.Name = "btn_FormatShape"
        Me.btn_FormatShape.Size = New System.Drawing.Size(26, 30)
        Me.btn_FormatShape.TabIndex = 21
        Me.btn_FormatShape.UseVisualStyleBackColor = True
        '
        'btn_AlignBottom
        '
        Me.btn_AlignBottom.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._9
        Me.btn_AlignBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_AlignBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_AlignBottom.FlatAppearance.BorderSize = 0
        Me.btn_AlignBottom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_AlignBottom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AlignBottom.Location = New System.Drawing.Point(182, 30)
        Me.btn_AlignBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_AlignBottom.Name = "btn_AlignBottom"
        Me.btn_AlignBottom.Size = New System.Drawing.Size(26, 30)
        Me.btn_AlignBottom.TabIndex = 20
        Me.btn_AlignBottom.UseVisualStyleBackColor = True
        '
        'btn_AlignRight
        '
        Me.btn_AlignRight.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._3
        Me.btn_AlignRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_AlignRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_AlignRight.FlatAppearance.BorderSize = 0
        Me.btn_AlignRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_AlignRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AlignRight.Location = New System.Drawing.Point(156, 30)
        Me.btn_AlignRight.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_AlignRight.Name = "btn_AlignRight"
        Me.btn_AlignRight.Size = New System.Drawing.Size(26, 30)
        Me.btn_AlignRight.TabIndex = 19
        Me.btn_AlignRight.UseVisualStyleBackColor = True
        '
        'btn_AlignTop
        '
        Me.btn_AlignTop.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._4
        Me.btn_AlignTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_AlignTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_AlignTop.FlatAppearance.BorderSize = 0
        Me.btn_AlignTop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_AlignTop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AlignTop.Location = New System.Drawing.Point(130, 30)
        Me.btn_AlignTop.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_AlignTop.Name = "btn_AlignTop"
        Me.btn_AlignTop.Size = New System.Drawing.Size(26, 30)
        Me.btn_AlignTop.TabIndex = 18
        Me.btn_AlignTop.UseVisualStyleBackColor = True
        '
        'btn_AlignLeft
        '
        Me.btn_AlignLeft.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._5
        Me.btn_AlignLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_AlignLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_AlignLeft.FlatAppearance.BorderSize = 0
        Me.btn_AlignLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_AlignLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AlignLeft.Location = New System.Drawing.Point(104, 30)
        Me.btn_AlignLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_AlignLeft.Name = "btn_AlignLeft"
        Me.btn_AlignLeft.Size = New System.Drawing.Size(26, 30)
        Me.btn_AlignLeft.TabIndex = 17
        Me.btn_AlignLeft.UseVisualStyleBackColor = True
        '
        'btn_DistVer
        '
        Me.btn_DistVer.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._8
        Me.btn_DistVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_DistVer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_DistVer.FlatAppearance.BorderSize = 0
        Me.btn_DistVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_DistVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_DistVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DistVer.Location = New System.Drawing.Point(78, 30)
        Me.btn_DistVer.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_DistVer.Name = "btn_DistVer"
        Me.btn_DistVer.Size = New System.Drawing.Size(26, 30)
        Me.btn_DistVer.TabIndex = 16
        Me.btn_DistVer.UseVisualStyleBackColor = True
        '
        'btn_DistHor
        '
        Me.btn_DistHor.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._7
        Me.btn_DistHor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_DistHor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_DistHor.FlatAppearance.BorderSize = 0
        Me.btn_DistHor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_DistHor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_DistHor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DistHor.Location = New System.Drawing.Point(52, 30)
        Me.btn_DistHor.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_DistHor.Name = "btn_DistHor"
        Me.btn_DistHor.Size = New System.Drawing.Size(26, 30)
        Me.btn_DistHor.TabIndex = 15
        Me.btn_DistHor.UseVisualStyleBackColor = True
        '
        'btn_AlignMiddle
        '
        Me.btn_AlignMiddle.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._6
        Me.btn_AlignMiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_AlignMiddle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_AlignMiddle.FlatAppearance.BorderSize = 0
        Me.btn_AlignMiddle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_AlignMiddle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AlignMiddle.Location = New System.Drawing.Point(26, 30)
        Me.btn_AlignMiddle.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_AlignMiddle.Name = "btn_AlignMiddle"
        Me.btn_AlignMiddle.Size = New System.Drawing.Size(26, 30)
        Me.btn_AlignMiddle.TabIndex = 14
        Me.btn_AlignMiddle.UseVisualStyleBackColor = True
        '
        'btn_AlignCenter
        '
        Me.btn_AlignCenter.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._2_
        Me.btn_AlignCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_AlignCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_AlignCenter.FlatAppearance.BorderSize = 0
        Me.btn_AlignCenter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_AlignCenter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AlignCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AlignCenter.Location = New System.Drawing.Point(0, 30)
        Me.btn_AlignCenter.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_AlignCenter.Name = "btn_AlignCenter"
        Me.btn_AlignCenter.Size = New System.Drawing.Size(26, 30)
        Me.btn_AlignCenter.TabIndex = 13
        Me.btn_AlignCenter.UseVisualStyleBackColor = True
        '
        'btn_Paragraph
        '
        Me.btn_Paragraph.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._21
        Me.btn_Paragraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Paragraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Paragraph.FlatAppearance.BorderSize = 0
        Me.btn_Paragraph.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_Paragraph.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Paragraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Paragraph.Location = New System.Drawing.Point(234, 0)
        Me.btn_Paragraph.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Paragraph.Name = "btn_Paragraph"
        Me.btn_Paragraph.Size = New System.Drawing.Size(26, 30)
        Me.btn_Paragraph.TabIndex = 11
        Me.btn_Paragraph.UseVisualStyleBackColor = True
        '
        'btn_DistRows
        '
        Me.btn_DistRows.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._18
        Me.btn_DistRows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_DistRows.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_DistRows.FlatAppearance.BorderSize = 0
        Me.btn_DistRows.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_DistRows.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_DistRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DistRows.Location = New System.Drawing.Point(208, 0)
        Me.btn_DistRows.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_DistRows.Name = "btn_DistRows"
        Me.btn_DistRows.Size = New System.Drawing.Size(26, 30)
        Me.btn_DistRows.TabIndex = 10
        Me.btn_DistRows.UseVisualStyleBackColor = True
        '
        'btn_DistColumns
        '
        Me.btn_DistColumns.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._17
        Me.btn_DistColumns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_DistColumns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_DistColumns.FlatAppearance.BorderSize = 0
        Me.btn_DistColumns.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_DistColumns.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_DistColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DistColumns.Location = New System.Drawing.Point(182, 0)
        Me.btn_DistColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_DistColumns.Name = "btn_DistColumns"
        Me.btn_DistColumns.Size = New System.Drawing.Size(26, 30)
        Me.btn_DistColumns.TabIndex = 9
        Me.btn_DistColumns.UseVisualStyleBackColor = True
        '
        'btn_BorderAll
        '
        Me.btn_BorderAll.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._13
        Me.btn_BorderAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_BorderAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_BorderAll.FlatAppearance.BorderSize = 0
        Me.btn_BorderAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_BorderAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_BorderAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_BorderAll.Location = New System.Drawing.Point(156, 0)
        Me.btn_BorderAll.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_BorderAll.Name = "btn_BorderAll"
        Me.btn_BorderAll.Size = New System.Drawing.Size(26, 30)
        Me.btn_BorderAll.TabIndex = 8
        Me.btn_BorderAll.UseVisualStyleBackColor = True
        '
        'btn_BorderRight
        '
        Me.btn_BorderRight.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._16
        Me.btn_BorderRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_BorderRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_BorderRight.FlatAppearance.BorderSize = 0
        Me.btn_BorderRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_BorderRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_BorderRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_BorderRight.Location = New System.Drawing.Point(130, 0)
        Me.btn_BorderRight.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_BorderRight.Name = "btn_BorderRight"
        Me.btn_BorderRight.Size = New System.Drawing.Size(26, 30)
        Me.btn_BorderRight.TabIndex = 7
        Me.btn_BorderRight.UseVisualStyleBackColor = True
        '
        'btn_BorderLeft
        '
        Me.btn_BorderLeft.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._15
        Me.btn_BorderLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_BorderLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_BorderLeft.FlatAppearance.BorderSize = 0
        Me.btn_BorderLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_BorderLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_BorderLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_BorderLeft.Location = New System.Drawing.Point(104, 0)
        Me.btn_BorderLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_BorderLeft.Name = "btn_BorderLeft"
        Me.btn_BorderLeft.Size = New System.Drawing.Size(26, 30)
        Me.btn_BorderLeft.TabIndex = 6
        Me.btn_BorderLeft.UseVisualStyleBackColor = True
        '
        'btn_BorderBottom
        '
        Me.btn_BorderBottom.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._12
        Me.btn_BorderBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_BorderBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_BorderBottom.FlatAppearance.BorderSize = 0
        Me.btn_BorderBottom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_BorderBottom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_BorderBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_BorderBottom.Location = New System.Drawing.Point(78, 0)
        Me.btn_BorderBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_BorderBottom.Name = "btn_BorderBottom"
        Me.btn_BorderBottom.Size = New System.Drawing.Size(26, 30)
        Me.btn_BorderBottom.TabIndex = 5
        Me.btn_BorderBottom.UseVisualStyleBackColor = True
        '
        'btn_BorderTop
        '
        Me.btn_BorderTop.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._14
        Me.btn_BorderTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_BorderTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_BorderTop.FlatAppearance.BorderSize = 0
        Me.btn_BorderTop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_BorderTop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_BorderTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_BorderTop.Location = New System.Drawing.Point(52, 0)
        Me.btn_BorderTop.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_BorderTop.Name = "btn_BorderTop"
        Me.btn_BorderTop.Size = New System.Drawing.Size(26, 30)
        Me.btn_BorderTop.TabIndex = 4
        Me.btn_BorderTop.UseVisualStyleBackColor = True
        '
        'btn_BringForward
        '
        Me.btn_BringForward.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._11_
        Me.btn_BringForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_BringForward.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_BringForward.FlatAppearance.BorderSize = 0
        Me.btn_BringForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_BringForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_BringForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_BringForward.Location = New System.Drawing.Point(26, 0)
        Me.btn_BringForward.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_BringForward.Name = "btn_BringForward"
        Me.btn_BringForward.Size = New System.Drawing.Size(26, 30)
        Me.btn_BringForward.TabIndex = 3
        Me.btn_BringForward.UseVisualStyleBackColor = True
        '
        'btn_SendtoBack
        '
        Me.btn_SendtoBack.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._10
        Me.btn_SendtoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_SendtoBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_SendtoBack.FlatAppearance.BorderSize = 0
        Me.btn_SendtoBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_SendtoBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_SendtoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SendtoBack.Location = New System.Drawing.Point(0, 0)
        Me.btn_SendtoBack.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_SendtoBack.Name = "btn_SendtoBack"
        Me.btn_SendtoBack.Size = New System.Drawing.Size(26, 30)
        Me.btn_SendtoBack.TabIndex = 2
        Me.btn_SendtoBack.UseVisualStyleBackColor = True
        '
        'btn_PasteText
        '
        Me.btn_PasteText.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._20
        Me.btn_PasteText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_PasteText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_PasteText.FlatAppearance.BorderSize = 0
        Me.btn_PasteText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_PasteText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_PasteText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_PasteText.Location = New System.Drawing.Point(260, 0)
        Me.btn_PasteText.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_PasteText.Name = "btn_PasteText"
        Me.btn_PasteText.Size = New System.Drawing.Size(33, 30)
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
        Me.Scont_B.Panel1.Controls.Add(Me.Panel_total)
        '
        'Scont_B.Panel2
        '
        Me.Scont_B.Panel2.Controls.Add(Me.Scont_C)
        Me.Scont_B.Size = New System.Drawing.Size(293, 489)
        Me.Scont_B.SplitterDistance = 249
        Me.Scont_B.TabIndex = 0
        '
        'Scont_C
        '
        Me.Scont_C.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.Scont_C.Panel2.Controls.Add(Me.txtNotes)
        Me.Scont_C.Size = New System.Drawing.Size(293, 236)
        Me.Scont_C.SplitterDistance = 75
        Me.Scont_C.TabIndex = 0
        '
        'TLP_Notes
        '
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
        Me.TLP_Notes.Size = New System.Drawing.Size(293, 75)
        Me.TLP_Notes.TabIndex = 1
        '
        'TLP_NotesTools1
        '
        Me.TLP_NotesTools1.ColumnCount = 3
        Me.TLP_NotesTools1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.20184!))
        Me.TLP_NotesTools1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.60279!))
        Me.TLP_NotesTools1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.23693!))
        Me.TLP_NotesTools1.Controls.Add(Me.TableLayoutPanel1, 2, 0)
        Me.TLP_NotesTools1.Controls.Add(Me.cboxFontSize, 1, 0)
        Me.TLP_NotesTools1.Controls.Add(Me.cboxFontFamily, 0, 0)
        Me.TLP_NotesTools1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_NotesTools1.Location = New System.Drawing.Point(3, 3)
        Me.TLP_NotesTools1.Name = "TLP_NotesTools1"
        Me.TLP_NotesTools1.RowCount = 1
        Me.TLP_NotesTools1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_NotesTools1.Size = New System.Drawing.Size(287, 32)
        Me.TLP_NotesTools1.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_IndentInc, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Reset, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_IndentDec, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Bullet, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(185, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(99, 26)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'btn_IndentInc
        '
        Me.btn_IndentInc.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._34
        Me.btn_IndentInc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_IndentInc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_IndentInc.FlatAppearance.BorderSize = 0
        Me.btn_IndentInc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_IndentInc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_IndentInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_IndentInc.Location = New System.Drawing.Point(72, 0)
        Me.btn_IndentInc.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_IndentInc.Name = "btn_IndentInc"
        Me.btn_IndentInc.Size = New System.Drawing.Size(27, 26)
        Me.btn_IndentInc.TabIndex = 9
        Me.btn_IndentInc.UseVisualStyleBackColor = True
        '
        'btn_Reset
        '
        Me.btn_Reset.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._33
        Me.btn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Reset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Reset.FlatAppearance.BorderSize = 0
        Me.btn_Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Reset.Location = New System.Drawing.Point(0, 0)
        Me.btn_Reset.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Size = New System.Drawing.Size(24, 26)
        Me.btn_Reset.TabIndex = 10
        Me.btn_Reset.UseVisualStyleBackColor = True
        '
        'btn_IndentDec
        '
        Me.btn_IndentDec.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._35
        Me.btn_IndentDec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_IndentDec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_IndentDec.FlatAppearance.BorderSize = 0
        Me.btn_IndentDec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_IndentDec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_IndentDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_IndentDec.Location = New System.Drawing.Point(48, 0)
        Me.btn_IndentDec.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_IndentDec.Name = "btn_IndentDec"
        Me.btn_IndentDec.Size = New System.Drawing.Size(24, 26)
        Me.btn_IndentDec.TabIndex = 6
        Me.btn_IndentDec.UseVisualStyleBackColor = True
        '
        'btn_Bullet
        '
        Me.btn_Bullet.Appearance = System.Windows.Forms.Appearance.Button
        Me.btn_Bullet.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._29
        Me.btn_Bullet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Bullet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Bullet.FlatAppearance.BorderSize = 0
        Me.btn_Bullet.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Bullet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_Bullet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Bullet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Bullet.Location = New System.Drawing.Point(24, 0)
        Me.btn_Bullet.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Bullet.Name = "btn_Bullet"
        Me.btn_Bullet.Size = New System.Drawing.Size(24, 26)
        Me.btn_Bullet.TabIndex = 8
        Me.btn_Bullet.UseVisualStyleBackColor = True
        '
        'cboxFontSize
        '
        Me.cboxFontSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboxFontSize.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxFontSize.FormattingEnabled = True
        Me.cboxFontSize.Location = New System.Drawing.Point(124, 3)
        Me.cboxFontSize.Name = "cboxFontSize"
        Me.cboxFontSize.Size = New System.Drawing.Size(55, 25)
        Me.cboxFontSize.TabIndex = 1
        '
        'cboxFontFamily
        '
        Me.cboxFontFamily.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboxFontFamily.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxFontFamily.FormattingEnabled = True
        Me.cboxFontFamily.Location = New System.Drawing.Point(3, 3)
        Me.cboxFontFamily.Name = "cboxFontFamily"
        Me.cboxFontFamily.Size = New System.Drawing.Size(115, 25)
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
        Me.TLP_NotesTools2.Controls.Add(Me.btn_WrapText, 9, 0)
        Me.TLP_NotesTools2.Controls.Add(Me.btnPaste, 8, 0)
        Me.TLP_NotesTools2.Controls.Add(Me.btnCopy, 7, 0)
        Me.TLP_NotesTools2.Controls.Add(Me.btnCut, 6, 0)
        Me.TLP_NotesTools2.Controls.Add(Me.btnAlignRight, 5, 0)
        Me.TLP_NotesTools2.Controls.Add(Me.btnAlignCenter, 4, 0)
        Me.TLP_NotesTools2.Controls.Add(Me.btnitalic, 1, 0)
        Me.TLP_NotesTools2.Controls.Add(Me.btnunderline, 2, 0)
        Me.TLP_NotesTools2.Controls.Add(Me.btnAlignLeft, 3, 0)
        Me.TLP_NotesTools2.Controls.Add(Me.btnBold, 0, 0)
        Me.TLP_NotesTools2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_NotesTools2.Location = New System.Drawing.Point(3, 41)
        Me.TLP_NotesTools2.Name = "TLP_NotesTools2"
        Me.TLP_NotesTools2.RowCount = 1
        Me.TLP_NotesTools2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_NotesTools2.Size = New System.Drawing.Size(287, 31)
        Me.TLP_NotesTools2.TabIndex = 0
        '
        'btn_WrapText
        '
        Me.btn_WrapText.Appearance = System.Windows.Forms.Appearance.Button
        Me.btn_WrapText.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._70
        Me.btn_WrapText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_WrapText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_WrapText.FlatAppearance.BorderSize = 0
        Me.btn_WrapText.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_WrapText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_WrapText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_WrapText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_WrapText.Location = New System.Drawing.Point(252, 0)
        Me.btn_WrapText.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_WrapText.Name = "btn_WrapText"
        Me.btn_WrapText.Size = New System.Drawing.Size(35, 31)
        Me.btn_WrapText.TabIndex = 9
        Me.btn_WrapText.UseVisualStyleBackColor = True
        '
        'btnPaste
        '
        Me.btnPaste.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._20
        Me.btnPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPaste.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPaste.FlatAppearance.BorderSize = 0
        Me.btnPaste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPaste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaste.Location = New System.Drawing.Point(224, 0)
        Me.btnPaste.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(28, 31)
        Me.btnPaste.TabIndex = 8
        Me.btnPaste.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._31__
        Me.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCopy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCopy.FlatAppearance.BorderSize = 0
        Me.btnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopy.Location = New System.Drawing.Point(196, 0)
        Me.btnCopy.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(28, 31)
        Me.btnCopy.TabIndex = 7
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnCut
        '
        Me.btnCut.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._28
        Me.btnCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCut.FlatAppearance.BorderSize = 0
        Me.btnCut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCut.Location = New System.Drawing.Point(168, 0)
        Me.btnCut.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCut.Name = "btnCut"
        Me.btnCut.Size = New System.Drawing.Size(28, 31)
        Me.btnCut.TabIndex = 6
        Me.btnCut.UseVisualStyleBackColor = True
        '
        'btnAlignRight
        '
        Me.btnAlignRight.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnAlignRight.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._27
        Me.btnAlignRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAlignRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAlignRight.FlatAppearance.BorderSize = 0
        Me.btnAlignRight.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlignRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAlignRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlignRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlignRight.Location = New System.Drawing.Point(140, 0)
        Me.btnAlignRight.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAlignRight.Name = "btnAlignRight"
        Me.btnAlignRight.Size = New System.Drawing.Size(28, 31)
        Me.btnAlignRight.TabIndex = 4
        Me.btnAlignRight.UseVisualStyleBackColor = True
        '
        'btnAlignCenter
        '
        Me.btnAlignCenter.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnAlignCenter.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._25
        Me.btnAlignCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAlignCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAlignCenter.FlatAppearance.BorderSize = 0
        Me.btnAlignCenter.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlignCenter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAlignCenter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlignCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlignCenter.Location = New System.Drawing.Point(112, 0)
        Me.btnAlignCenter.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAlignCenter.Name = "btnAlignCenter"
        Me.btnAlignCenter.Size = New System.Drawing.Size(28, 31)
        Me.btnAlignCenter.TabIndex = 5
        Me.btnAlignCenter.UseVisualStyleBackColor = True
        '
        'btnitalic
        '
        Me.btnitalic.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._24_g
        Me.btnitalic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnitalic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnitalic.FlatAppearance.BorderSize = 0
        Me.btnitalic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnitalic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnitalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnitalic.Location = New System.Drawing.Point(28, 0)
        Me.btnitalic.Margin = New System.Windows.Forms.Padding(0)
        Me.btnitalic.Name = "btnitalic"
        Me.btnitalic.Size = New System.Drawing.Size(28, 31)
        Me.btnitalic.TabIndex = 4
        Me.btnitalic.UseVisualStyleBackColor = True
        '
        'btnunderline
        '
        Me.btnunderline.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._22_g
        Me.btnunderline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnunderline.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnunderline.FlatAppearance.BorderSize = 0
        Me.btnunderline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnunderline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnunderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnunderline.Location = New System.Drawing.Point(56, 0)
        Me.btnunderline.Margin = New System.Windows.Forms.Padding(0)
        Me.btnunderline.Name = "btnunderline"
        Me.btnunderline.Size = New System.Drawing.Size(28, 31)
        Me.btnunderline.TabIndex = 2
        Me.btnunderline.UseVisualStyleBackColor = True
        '
        'btnAlignLeft
        '
        Me.btnAlignLeft.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnAlignLeft.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._26
        Me.btnAlignLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAlignLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAlignLeft.FlatAppearance.BorderSize = 0
        Me.btnAlignLeft.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlignLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAlignLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlignLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlignLeft.Location = New System.Drawing.Point(84, 0)
        Me.btnAlignLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAlignLeft.Name = "btnAlignLeft"
        Me.btnAlignLeft.Size = New System.Drawing.Size(28, 31)
        Me.btnAlignLeft.TabIndex = 3
        Me.btnAlignLeft.UseVisualStyleBackColor = True
        '
        'btnBold
        '
        Me.btnBold.BackgroundImage = Global.SemiFinalApproach.My.Resources.Resources._23_g
        Me.btnBold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBold.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBold.FlatAppearance.BorderSize = 0
        Me.btnBold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBold.Location = New System.Drawing.Point(0, 0)
        Me.btnBold.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBold.Name = "btnBold"
        Me.btnBold.Size = New System.Drawing.Size(28, 31)
        Me.btnBold.TabIndex = 5
        Me.btnBold.UseVisualStyleBackColor = True
        '
        'txtNotes
        '
        Me.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNotes.Location = New System.Drawing.Point(0, 0)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(293, 157)
        Me.txtNotes.TabIndex = 0
        Me.txtNotes.Text = ""
        '
        'Scont_TextFormat
        '
        Me.Scont_TextFormat.Dock = System.Windows.Forms.DockStyle.Top
        Me.Scont_TextFormat.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Scont_TextFormat.Location = New System.Drawing.Point(0, 0)
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
        Me.Scont_TextFormat.Size = New System.Drawing.Size(276, 130)
        Me.Scont_TextFormat.TabIndex = 1
        '
        'chkbx_TextFormat
        '
        Me.chkbx_TextFormat.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkbx_TextFormat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkbx_TextFormat.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbx_TextFormat.Location = New System.Drawing.Point(0, 0)
        Me.chkbx_TextFormat.Name = "chkbx_TextFormat"
        Me.chkbx_TextFormat.Size = New System.Drawing.Size(276, 50)
        Me.chkbx_TextFormat.TabIndex = 2
        Me.chkbx_TextFormat.Text = "Text Format"
        Me.chkbx_TextFormat.UseVisualStyleBackColor = True
        '
        'chkbx_ShapeFormat
        '
        Me.chkbx_ShapeFormat.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkbx_ShapeFormat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkbx_ShapeFormat.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbx_ShapeFormat.Location = New System.Drawing.Point(0, 0)
        Me.chkbx_ShapeFormat.Name = "chkbx_ShapeFormat"
        Me.chkbx_ShapeFormat.Size = New System.Drawing.Size(276, 50)
        Me.chkbx_ShapeFormat.TabIndex = 3
        Me.chkbx_ShapeFormat.Text = "Shape Format"
        Me.chkbx_ShapeFormat.UseVisualStyleBackColor = True
        '
        'Scont_ShapeFormat
        '
        Me.Scont_ShapeFormat.Dock = System.Windows.Forms.DockStyle.Top
        Me.Scont_ShapeFormat.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Scont_ShapeFormat.Location = New System.Drawing.Point(0, 130)
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
        Me.Scont_ShapeFormat.Size = New System.Drawing.Size(276, 207)
        Me.Scont_ShapeFormat.TabIndex = 4
        '
        'Panel_TextFormat
        '
        Me.Panel_TextFormat.AutoScroll = True
        Me.Panel_TextFormat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_TextFormat.Location = New System.Drawing.Point(0, 0)
        Me.Panel_TextFormat.Name = "Panel_TextFormat"
        Me.Panel_TextFormat.Size = New System.Drawing.Size(276, 76)
        Me.Panel_TextFormat.TabIndex = 0
        '
        'Panel_ShapeFormat
        '
        Me.Panel_ShapeFormat.AutoScroll = True
        Me.Panel_ShapeFormat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_ShapeFormat.Location = New System.Drawing.Point(0, 0)
        Me.Panel_ShapeFormat.Name = "Panel_ShapeFormat"
        Me.Panel_ShapeFormat.Size = New System.Drawing.Size(276, 153)
        Me.Panel_ShapeFormat.TabIndex = 0
        '
        'Panel_total
        '
        Me.Panel_total.AutoScroll = True
        Me.Panel_total.Controls.Add(Me.Scont_ShapeFormat)
        Me.Panel_total.Controls.Add(Me.Scont_TextFormat)
        Me.Panel_total.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_total.Location = New System.Drawing.Point(0, 0)
        Me.Panel_total.Name = "Panel_total"
        Me.Panel_total.Size = New System.Drawing.Size(293, 249)
        Me.Panel_total.TabIndex = 0
        '
        'TLP_FormatText
        '
        Me.TLP_FormatText.ColumnCount = 1
        Me.TLP_FormatText.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_FormatText.Controls.Add(Me.CheckBox1, 0, 3)
        Me.TLP_FormatText.Controls.Add(Me.Gbox_InternalMargin, 0, 2)
        Me.TLP_FormatText.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLP_FormatText.Location = New System.Drawing.Point(339, 30)
        Me.TLP_FormatText.Name = "TLP_FormatText"
        Me.TLP_FormatText.RowCount = 4
        Me.TLP_FormatText.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_FormatText.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_FormatText.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101.0!))
        Me.TLP_FormatText.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TLP_FormatText.Size = New System.Drawing.Size(290, 380)
        Me.TLP_FormatText.TabIndex = 1
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox1.Location = New System.Drawing.Point(3, 351)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(284, 26)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Wrap text in shape"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Gbox_InternalMargin
        '
        Me.Gbox_InternalMargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gbox_InternalMargin.Location = New System.Drawing.Point(3, 250)
        Me.Gbox_InternalMargin.Name = "Gbox_InternalMargin"
        Me.Gbox_InternalMargin.Size = New System.Drawing.Size(284, 95)
        Me.Gbox_InternalMargin.TabIndex = 1
        Me.Gbox_InternalMargin.TabStop = False
        Me.Gbox_InternalMargin.Text = "Internal Margin"
        '
        'PowerPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TLP_FormatText)
        Me.Controls.Add(Me.Scont_A)
        Me.Name = "PowerPanel"
        Me.Size = New System.Drawing.Size(820, 553)
        Me.Scont_A.Panel1.ResumeLayout(False)
        Me.Scont_A.Panel2.ResumeLayout(False)
        CType(Me.Scont_A, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scont_A.ResumeLayout(False)
        Me.TLP_Alignment.ResumeLayout(False)
        Me.Scont_B.Panel1.ResumeLayout(False)
        Me.Scont_B.Panel2.ResumeLayout(False)
        CType(Me.Scont_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scont_B.ResumeLayout(False)
        Me.Scont_C.Panel1.ResumeLayout(False)
        Me.Scont_C.Panel2.ResumeLayout(False)
        CType(Me.Scont_C, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scont_C.ResumeLayout(False)
        Me.TLP_Notes.ResumeLayout(False)
        Me.TLP_NotesTools1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TLP_NotesTools2.ResumeLayout(False)
        Me.Scont_TextFormat.Panel1.ResumeLayout(False)
        Me.Scont_TextFormat.Panel2.ResumeLayout(False)
        CType(Me.Scont_TextFormat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scont_TextFormat.ResumeLayout(False)
        Me.Scont_ShapeFormat.Panel1.ResumeLayout(False)
        Me.Scont_ShapeFormat.Panel2.ResumeLayout(False)
        CType(Me.Scont_ShapeFormat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scont_ShapeFormat.ResumeLayout(False)
        Me.Panel_total.ResumeLayout(False)
        Me.TLP_FormatText.ResumeLayout(False)
        Me.TLP_FormatText.PerformLayout()
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
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TLP_NotesTools1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnunderline As System.Windows.Forms.Button
    Friend WithEvents btnAlignLeft As System.Windows.Forms.CheckBox
    Friend WithEvents btnitalic As System.Windows.Forms.Button
    Friend WithEvents btnBold As System.Windows.Forms.Button
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
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Gbox_InternalMargin As System.Windows.Forms.GroupBox

End Class
