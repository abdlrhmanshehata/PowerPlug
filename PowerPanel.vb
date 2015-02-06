Imports Microsoft.Office.Interop.PowerPoint
Imports Microsoft.Office.Core
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Windows
Public Class PowerPanel
    Dim WithEvents objapp As PowerPoint.Application = Globals.ThisAddIn.Application
    Dim i As Integer
    Dim notesshape As PowerPoint.Shape
    Dim shapename As String
    Dim selectedshape As PowerPoint.Shape
    Dim currentshapename As String = ""
    Dim l As Integer
    Dim relativestate As MsoTriState
    Dim originallength, originalwidth As Integer
    '=====================================================GENERAL GENERAL GENERAL GENERAL GENERAL GENERAL GENERAL GENERAL ================================================================================'
    '=====================================================GENERAL GENERAL GENERAL GENERAL GENERAL GENERAL GENERAL GENERAL ==============================================================================='
#Region "General"
    Sub getnoteshape()
        Try
            getcurrentindex()
            For Each shape As PowerPoint.Shape In objapp.ActivePresentation.Slides(i).NotesPage.Shapes
                If shape.HasTextFrame Then
                    If shape.Width > 300 Then
                        shapename = shape.Name
                        notesshape = objapp.ActivePresentation.Slides(i).NotesPage.Shapes(shapename)
                    End If
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Sub getcurrentindex()
        Try
            i = objapp.ActiveWindow.Selection.SlideRange.SlideNumber
        Catch ex As Exception

        End Try

    End Sub
    Sub selectshape()
        Try
            Dim k, g As Object
            k = objapp.ActiveWindow.Selection.SlideRange.SlideNumber
            g = objapp.ActiveWindow.Selection.ShapeRange.Name
            If currentshapename <> objapp.ActivePresentation.Slides(k).Shapes(g).Name Then
                currentshapename = objapp.ActivePresentation.Slides(k).Shapes(g).Name
                selectedshape = objapp.ActivePresentation.Slides(k).Shapes(g)
                If selectedshape.Type.ToString = "msoPicture" Then
                    ' Picture
                    picturetools()
                Else
                    ' TextBox
                    textboxtools()
                End If
                originallength = selectedshape.Height
                originalwidth = selectedshape.Width
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub EnableFormatButton(ButtonToEnable As CheckBox)
        If ButtonToEnable.Checked = False Then
            For Each scont As SplitContainer In Panel_Total.Controls.OfType(Of SplitContainer)()
                For Each chkbx As CheckBox In scont.Panel1.Controls.OfType(Of CheckBox)()
                    chkbx.Checked = False
                Next
            Next
            ButtonToEnable.Checked = True
        End If
    End Sub
    Sub SuitableFormat()
        Try
            If selectedshape.TextFrame.TextRange.Text.Length > 0 Then
                EnableFormatButton(chkbx_TextFormat)
            Else
                EnableFormatButton(chkbx_ShapeFormat)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub ShowNotes(ByVal show As Boolean)
        If show Then
            Scont_B.SplitterDistance = 110
        Else
            Scont_B.SplitterDistance = 340
        End If
    End Sub
    Private Sub objapp_WindowSelectionChange(Sel As Selection) Handles objapp.WindowSelectionChange
        getcurrentindex()
        getnoteshape()
        selectshape()

        gettextpage()
        getsizepage()
        getnotespage()

        getFillPage()
        SuitableFormat()
        ShowNotes(False)
    End Sub

    Public Overridable Sub ExpandCollapse(chkbx As CheckBox, scont As SplitContainer, max As Integer, min As Integer)
        If chkbx.Checked Then
            scont.Panel2Collapsed = False
            scont.Height = max
        Else
            scont.Panel2Collapsed = True
            scont.Height = min
        End If
    End Sub
    Public Overridable Sub ExpandCollapse(Rbtn As RadioButton, max As Integer, min As Integer)
        Dim Scont As SplitContainer
        scont = Rbtn.Parent.Parent
        If Rbtn.Checked Then
            Scont.Panel2Collapsed = False
            scont.Height = max
        Else
            scont.Panel2Collapsed = True
            scont.Height = min
        End If
    End Sub
    Private Sub chkbx_ShapeFormat_CheckedChanged(sender As Object, e As EventArgs) Handles chkbx_ShapeFormat.CheckedChanged
        ExpandCollapse(chkbx_ShapeFormat, Scont_ShapeFormat, 300, 50)
    End Sub
    Private Sub chkbx_TextFormat_CheckedChanged(sender As Object, e As EventArgs) Handles chkbx_TextFormat.CheckedChanged
        ExpandCollapse(chkbx_TextFormat, Scont_TextFormat, 300, 50)
    End Sub
    Private Sub btn_ShowNotes_Click(sender As Object, e As EventArgs) Handles btn_ShowNotes.Click
        If btn_ShowNotes.Text = "Show Notes" Then
            ShowNotes(True)
            btn_ShowNotes.Text = "Hide Notes"
        Else
            ShowNotes(False)
            btn_ShowNotes.Text = "Show Notes"
        End If
    End Sub
#End Region
    '=======================================NOTES NOTES NOTES NOTES NOTES NOTES NOTES NOTES NOTES============================================================================================='
    '=======================================NOTES NOTES NOTES NOTES NOTES NOTES NOTES NOTES NOTES======================================================================================================='
#Region "Notes"

#Region "Methods"
    '--------------------------------------------------------Get methods-------------------------------------------------'
    Sub getnotespage()
        gettext()
        getfont()
    End Sub
    Sub gettext()
        Try
            If txtNotes.Text <> notesshape.TextFrame.TextRange.Text Then
                txtNotes.Text = notesshape.TextFrame.TextRange.Text
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub getfont()
        Try
            For Each word As TextRange In notesshape.TextFrame.TextRange.Words
                Dim index As Integer = word.Start - 1
                Dim wheretostop As Integer = 0
                Dim bold, italic, underline As MsoTriState
                Dim fontname As String
                Dim fontsize As Single
                Dim style As FontStyle = FontStyle.Regular
                With word.Characters(1, 1).Font
                    bold = .Bold
                    italic = .Italic
                    underline = .Underline
                    fontname = word.Font.Name
                    fontsize = word.Font.Size
                    For Each element As TextRange In word.Characters
                        If element.Text <> " " Then
                            wheretostop += 1
                        End If
                    Next
                End With
                txtNotes.Select(index, wheretostop)
                If bold = 0 And italic = 0 And underline = 0 Then
                    style = FontStyle.Regular
                ElseIf bold = -1 And italic = -1 And underline = -1 Then
                    style = FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline
                ElseIf bold = -1 And italic = 0 And underline = 0 Then
                    style = FontStyle.Bold
                ElseIf bold = 0 And italic = -1 And underline = 0 Then
                    style = FontStyle.Italic
                ElseIf bold = 0 And italic = 0 And underline = -1 Then
                    style = FontStyle.Underline
                ElseIf bold = -1 And italic = -1 And underline = 0 Then
                    style = FontStyle.Bold Or FontStyle.Italic
                ElseIf bold = -1 And italic = 0 And underline = -1 Then
                    style = FontStyle.Bold Or FontStyle.Underline
                ElseIf bold = 0 And italic = -1 And underline = -1 Then
                    style = FontStyle.Underline Or FontStyle.Italic
                End If
                txtNotes.SelectionFont = New Drawing.Font(fontname, fontsize, style)
                txtNotes.Select(0, 1)

            Next
        Catch ex As Exception
        End Try
    End Sub
    '--------------------------------------------------------Set methods-------------------------------------------------'
    Sub settext()
        Try
            If notesshape.TextFrame.TextRange.Text <> txtNotes.Text Then
                notesshape.TextFrame.TextRange.Text = txtNotes.Text
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub setalignment()
        Try
            With notesshape.TextFrame.TextRange.ParagraphFormat
                If txtNotes.SelectionAlignment = HorizontalAlignment.Center Then
                    .Alignment = PpParagraphAlignment.ppAlignCenter
                ElseIf txtNotes.SelectionAlignment = HorizontalAlignment.Left Then
                    .Alignment = PpParagraphAlignment.ppAlignLeft
                ElseIf txtNotes.SelectionAlignment = HorizontalAlignment.Right Then
                    .Alignment = PpParagraphAlignment.ppAlignRight
                End If
            End With
        Catch ex As Exception
        End Try
    End Sub
    Sub setfont() ' makes each word in notes exactly like the word in PowerPlug
        Try
            For Each word As TextRange In notesshape.TextFrame.TextRange.Words
                Dim index As Integer = word.Start - 1
                Dim wheretostop As Integer = 0
                Dim bold, italic, underline As Boolean
                Dim fontname As String
                Dim fontsize As Single
                Dim selectionstart As Integer = txtNotes.SelectionStart
                Dim selectionlength As Integer = txtNotes.SelectedText.Length
                For Each element As TextRange In word.Characters
                    If element.Text <> " " Then
                        wheretostop += 1
                    End If
                Next
                txtNotes.Select(index, wheretostop)
                With txtNotes.SelectionFont
                    bold = .Bold
                    italic = .Italic
                    underline = .Underline
                    fontname = .Name
                    fontsize = .Size
                End With
                With word.Font
                    .Bold = MsoTriState.msoFalse
                    .Italic = MsoTriState.msoFalse
                    .Underline = MsoTriState.msoFalse
                    If bold = True And italic = True And underline = True Then
                        .Bold = MsoTriState.msoTrue
                        .Italic = MsoTriState.msoTrue
                        .Underline = MsoTriState.msoTrue
                    ElseIf bold = True And italic = False And underline = False Then
                        .Bold = MsoTriState.msoTrue
                        .Italic = MsoTriState.msoFalse
                        .Underline = MsoTriState.msoFalse
                    ElseIf bold = False And italic = True And underline = False Then
                        .Italic = MsoTriState.msoTrue
                        .Bold = MsoTriState.msoFalse
                        .Underline = MsoTriState.msoFalse
                    ElseIf bold = False And italic = False And underline = True Then
                        .Underline = MsoTriState.msoTrue
                        .Italic = MsoTriState.msoFalse
                        .Bold = MsoTriState.msoFalse
                    ElseIf bold = True And italic = True And underline = False Then
                        .Bold = MsoTriState.msoTrue
                        .Italic = MsoTriState.msoTrue
                        .Underline = MsoTriState.msoFalse
                    ElseIf bold = True And italic = False And underline = True Then
                        .Bold = MsoTriState.msoTrue
                        .Underline = MsoTriState.msoTrue
                        .Italic = MsoTriState.msoFalse
                    ElseIf bold = False And italic = True And underline = True Then
                        .Italic = MsoTriState.msoTrue
                        .Underline = MsoTriState.msoTrue
                        .Bold = MsoTriState.msoFalse
                    End If
                End With
                word.Font.Name = fontname
                word.Font.Size = fontsize
                txtNotes.Select(selectionstart, selectionlength)

            Next
        Catch ex As Exception
        End Try
    End Sub
    '--------------------------------------------------------General methods-------------------------------------------------'
    Sub B_I_U() 'controls PowerPlug Font_Style
        Try
            Dim bold, italic, underline As Boolean
            Dim fontname As String = txtNotes.SelectionFont.Name
            Dim fontsize As Single = txtNotes.SelectionFont.Size
            Dim style As FontStyle = FontStyle.Regular
            bold = btnBold.Checked
            italic = btnitalic.Checked
            underline = btnunderline.Checked

            If bold = False And italic = False And underline = False Then
                style = FontStyle.Regular
            ElseIf bold = True And italic = True And underline = True Then
                style = FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline
            ElseIf bold = True And italic = False And underline = False Then
                style = FontStyle.Bold
            ElseIf bold = False And italic = True And underline = False Then
                style = FontStyle.Italic
            ElseIf bold = False And italic = False And underline = True Then
                style = FontStyle.Underline
            ElseIf bold = True And italic = True And underline = False Then
                style = FontStyle.Bold Or FontStyle.Italic
            ElseIf bold = True And italic = False And underline = True Then
                style = FontStyle.Bold Or FontStyle.Underline
            ElseIf bold = False And italic = True And underline = True Then
                style = FontStyle.Italic Or FontStyle.Underline
            End If

            txtNotes.SelectionFont = New Drawing.Font(fontname, fontsize, style)
        Catch ex As Exception
        End Try
    End Sub
    Sub check_B_I_U()
        Try
            If txtNotes.SelectionFont.Bold = True Then
                btnBold.Checked = True
            Else
                btnBold.Checked = False
            End If

            If txtNotes.SelectionFont.Italic = True Then
                btnitalic.Checked = True
            Else
                btnitalic.Checked = False
            End If

            If txtNotes.SelectionFont.Underline = True Then
                btnunderline.Checked = True
            Else
                btnunderline.Checked = False
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub check_name_size()
        Try
            cboxFontFamily.SelectedItem = txtNotes.SelectionFont.Name
            cboxFontSize.SelectedItem = CStr(txtNotes.SelectionFont.Size)
        Catch ex As Exception
        End Try
    End Sub
    Sub checkbullets()
        If txtNotes.SelectionBullet = True Then
            btn_Bullet.Checked = True
        Else
            btn_Bullet.Checked = False
        End If
    End Sub
#End Region

#Region "Event Handlers"
    'controls Font 
    Private Sub cboxFontSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxFontSize.SelectionChangeCommitted
        Try
            txtNotes.SelectionFont = New Drawing.Font(txtNotes.SelectionFont.Name, CInt(cboxFontSize.SelectedItem.ToString))
            B_I_U()
            setfont()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cboxFontFamily_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxFontFamily.SelectionChangeCommitted
        txtNotes.SelectionFont = New Drawing.Font(cboxFontFamily.SelectedItem.ToString, txtNotes.SelectionFont.Size)
        B_I_U()
        setfont()
    End Sub

    Private Sub btnunderline_Click(sender As Object, e As EventArgs) Handles btnUnderline.Click
        B_I_U()
        setfont()
    End Sub
    Private Sub btnitalic_Click(sender As Object, e As EventArgs) Handles btnItalic.Click
        B_I_U()
        setfont()
    End Sub
    Private Sub btnBold_Click(sender As Object, e As EventArgs) Handles btnBold.Click
        B_I_U()
        setfont()
    End Sub
    'Bullet & indent
    Private Sub btn_Bullet_CheckedChanged(sender As Object, e As EventArgs) Handles btn_Bullet.CheckedChanged
        If btn_Bullet.Checked Then
            txtNotes.SelectionBullet = True
            Dim start As Integer = txtNotes.SelectionStart
            Dim length As Integer = txtNotes.SelectionLength

            btn_IndentDec.Enabled = True
            btn_IndentInc.Enabled = True
        Else
            txtNotes.SelectionBullet = False

            btn_IndentDec.Enabled = False
            btn_IndentInc.Enabled = False
        End If
    End Sub
    Private Sub btn_IndentInc_Click(sender As Object, e As EventArgs) Handles btn_IndentInc.Click
        Try
            txtNotes.SelectionIndent += 35
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btn_IndentDec_Click(sender As Object, e As EventArgs) Handles btn_IndentDec.Click
        Try
            txtNotes.SelectionIndent -= 35
        Catch ex As Exception
        End Try
    End Sub
    'save & cut & ...
    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        Try
            objapp.CommandBars("standard").Controls(3).Execute()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Try
            If txtNotes.SelectedText.Count <> 0 Then
                txtNotes.Copy()
            Else
                MsgBox("Please Select Text")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnCut_Click(sender As Object, e As EventArgs) Handles btnCut.Click
        Try
            If txtNotes.SelectedText.Length <> 0 Then
                txtNotes.Copy()
                txtNotes.SelectedText = ""
            Else
                MsgBox("Please Select Text")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnPaste_Click(sender As Object, e As EventArgs) Handles btnPaste.Click
        Try
            txtNotes.Paste()
        Catch ex As Exception
        End Try
    End Sub
    'alignment
    Private Sub btnAlignLeft_Click(sender As Object, e As EventArgs) Handles btnAlignLeft.Click
        txtNotes.SelectionAlignment = HorizontalAlignment.Left
        setalignment()
    End Sub
    Private Sub btnAlignRight_Click(sender As Object, e As EventArgs) Handles btnAlignRight.Click
        txtNotes.SelectionAlignment = HorizontalAlignment.Right
        setalignment()
    End Sub
    Private Sub btnAlignCenter_Click(sender As Object, e As EventArgs) Handles btnAlignCenter.Click
        txtNotes.SelectionAlignment = HorizontalAlignment.Center
        setalignment()
    End Sub
     
    'general
    Private Sub txtNotes_MouseLeave(sender As Object, e As EventArgs) Handles txtNotes.Leave, txtNotes.MouseLeave
        settext()
        setfont()
    End Sub
    Private Sub txtNotes_SelectionChanged(sender As Object, e As EventArgs) Handles txtNotes.SelectionChanged
        check_B_I_U()
        check_name_size()
        checkbullets()
    End Sub
    Private Sub btn_WrapText_CheckedChanged(sender As Object, e As EventArgs) Handles btn_WrapText.CheckedChanged
        If btn_WrapText.Checked Then
            txtNotes.WordWrap = True
        Else
            txtNotes.WordWrap = False
        End If
    End Sub
    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click
        txtNotes.SelectionFont = New Drawing.Font("Calibri", 12, FontStyle.Regular)
    End Sub

#End Region

#End Region
    '=======================================FORMAT SHAPE FORMAT SHAPE FORMAT SHAPE FORMAT SHAPE ==================================================================================================='
    '=======================================FORMAT SHAPE FORMAT SHAPE FORMAT SHAPE FORMAT SHAPE ================================================================================================='
#Region "Format Shape"
    '-----------------------------------TEXTBOX TEXTBOX TEXTBOX TEXTBOX TEXTBOX TEXTBOX ------------------------------------'
    Sub cboxselection(cbox As ComboBox, index As Integer)
        If cbox.SelectedIndex <> index Then
            cbox.SelectedIndex = index
            cbox.SelectedText = ""
        End If

    End Sub
    Sub gettextpage()
        Try
            If selectedshape.TextFrame.HasText Then
                '========================================TEXT DIRECTION============================'
                Select Case selectedshape.TextFrame.Orientation
                    Case MsoTextOrientation.msoTextOrientationHorizontal
                        cboxselection(cboxtextalignment, 0)
                    Case MsoTextOrientation.msoTextOrientationDownward
                        cboxselection(cboxtextalignment, 1)
                    Case MsoTextOrientation.msoTextOrientationUpward
                        cboxselection(cboxtextalignment, 2)
                End Select
                '========================================TEXT ALIGNMENT============================'
                With cboxtextalignment
                    Select Case selectedshape.TextFrame.VerticalAnchor
                        Case MsoVerticalAnchor.msoAnchorTop
                            cboxselection(cboxtextdirection, 0)
                        Case MsoVerticalAnchor.msoAnchorMiddle
                            cboxselection(cboxtextdirection, 1)
                        Case MsoVerticalAnchor.msoAnchorBottom
                            cboxselection(cboxtextdirection, 2)
                    End Select
                End With
                '========================================AutoFit=================================='
                Dim RbtnCheck = Sub(rbtn As RadioButton)
                                    If rbtn.Checked = False Then
                                        rbtn.Checked = True
                                    End If
                                End Sub
                Select Case selectedshape.TextFrame2.AutoSize
                    Case MsoAutoSize.msoAutoSizeShapeToFitText
                        RbtnCheck(ResizeShape)
                    Case MsoAutoSize.msoAutoSizeTextToFitShape
                        RbtnCheck(ShrinkText)
                    Case MsoAutoSize.msoAutoSizeNone
                        RbtnCheck(Donotautofit)
                End Select
                '========================================Margin=================================='
                num_LeftMargin.Value = selectedshape.TextFrame.MarginLeft / 72
                num_RightMargin.Value = selectedshape.TextFrame.MarginRight / 72
                num_TopMargin.Value = selectedshape.TextFrame.MarginTop / 72
                num_BotMargin.Value = selectedshape.TextFrame.MarginBottom / 72
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub settextPage()
        Try
            If selectedshape.HasTextFrame Then
                '======================================================TEXT DIRECTION==========================================================='
                With selectedshape.TextFrame
                    Select Case cboxtextdirection.SelectedIndex
                        Case 0
                            .Orientation = MsoTextOrientation.msoTextOrientationHorizontal
                        Case 1
                            .Orientation = MsoTextOrientation.msoTextOrientationDownward
                        Case 2
                            .Orientation = MsoTextOrientation.msoTextOrientationUpward
                    End Select
                End With
                '======================================================TEXT ALIGNMENT==========================================================='
                With selectedshape.TextFrame
                    Select Case cboxtextalignment.SelectedIndex
                        Case 0
                            .VerticalAnchor = MsoVerticalAnchor.msoAnchorTop
                        Case 1
                            .VerticalAnchor = MsoVerticalAnchor.msoAnchorMiddle
                        Case 2
                            .VerticalAnchor = MsoVerticalAnchor.msoAnchorBottom
                    End Select
                End With
                '================================================== AUTOFIT================================================================='
                If Donotautofit.Checked Then
                    selectedshape.TextFrame.AutoSize = PpAutoSize.ppAutoSizeNone
                ElseIf ResizeShape.Checked Then
                    selectedshape.TextFrame2.AutoSize = MsoAutoSize.msoAutoSizeShapeToFitText
                ElseIf ShrinkText.Checked Then
                    selectedshape.TextFrame2.AutoSize = MsoAutoSize.msoAutoSizeTextToFitShape
                End If
            End If
        Catch

        End Try
    End Sub
    Public Sub AutoFitAdjustment()
        If Donotautofit.Checked Then
            selectedshape.TextFrame.AutoSize = PpAutoSize.ppAutoSizeNone
        ElseIf ResizeShape.Checked Then
            selectedshape.TextFrame2.AutoSize = MsoAutoSize.msoAutoSizeShapeToFitText
        ElseIf ShrinkText.Checked Then
            selectedshape.TextFrame2.AutoSize = MsoAutoSize.msoAutoSizeTextToFitShape
        End If
    End Sub

    Private Sub cboxtextalignment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxtextalignment.SelectedIndexChanged
        Try
            With selectedshape.TextFrame
                Select Case cboxtextalignment.SelectedIndex
                    Case 0
                        .VerticalAnchor = MsoVerticalAnchor.msoAnchorTop
                    Case 1
                        .VerticalAnchor = MsoVerticalAnchor.msoAnchorMiddle
                    Case 2
                        .VerticalAnchor = MsoVerticalAnchor.msoAnchorBottom
                End Select
            End With
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cboxtextdirection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxtextdirection.SelectedIndexChanged
        Try
            With selectedshape.TextFrame
                Select Case cboxtextdirection.SelectedIndex
                    Case 0
                        .Orientation = MsoTextOrientation.msoTextOrientationHorizontal
                    Case 1
                        .Orientation = MsoTextOrientation.msoTextOrientationDownward
                    Case 2
                        .Orientation = MsoTextOrientation.msoTextOrientationUpward
                End Select
            End With
        Catch ex As Exception
        End Try
    End Sub


    Private Sub Donnotautofit_CheckedChanged(sender As Object, e As EventArgs) Handles Donotautofit.CheckedChanged
        AutoFitAdjustment()
    End Sub
    Private Sub Shrinktext_CheckedChanged(sender As Object, e As EventArgs) Handles ShrinkText.CheckedChanged
        AutoFitAdjustment()
    End Sub
    Private Sub ResizeShape_CheckedChanged(sender As Object, e As EventArgs) Handles ResizeShape.CheckedChanged
        AutoFitAdjustment()
    End Sub
    Private Sub chkbxWrap_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxWrap.CheckedChanged
        If chkbxWrap.Checked Then
            selectedshape.TextFrame.WordWrap = MsoTriState.msoCTrue
        Else
            selectedshape.TextFrame.WordWrap = MsoTriState.msoFalse
        End If
    End Sub
    Private Sub num_leftmargin_ValueChanged(sender As Object, e As EventArgs) Handles num_LeftMargin.ValueChanged
        Try
            selectedshape.TextFrame.MarginLeft = num_LeftMargin.Value * 72
        Catch ex As Exception
        End Try
    End Sub
    Private Sub num_rightmargin_ValueChanged(sender As Object, e As EventArgs) Handles num_RightMargin.ValueChanged
        Try
            selectedshape.TextFrame.MarginRight = Num_Rightmargin.Value * 72
        Catch ex As Exception
        End Try
    End Sub
    Private Sub num_topmargin_ValueChanged(sender As Object, e As EventArgs) Handles num_TopMargin.ValueChanged
        Try
            selectedshape.TextFrame.MarginTop = num_Topmargin.Value * 72
        Catch ex As Exception
        End Try

    End Sub
    Private Sub num_botmargin_ValueChanged(sender As Object, e As EventArgs) Handles num_BotMargin.ValueChanged
        Try
            selectedshape.TextFrame.MarginBottom = num_botmargin.Value * 72
        Catch ex As Exception
        End Try
    End Sub

    '----------------------------------SIZE SIZE SIZE SIZE SIZE SIZE SIZE SIZE SIZE SIZE ---------------------------------------'
    Sub getsizepage()
        Try

            If selectedshape.LockAspectRatio = MsoTriState.msoTrue Then
                chkbx_LockAspectRatio.Checked = True
            Else
                chkbx_LockAspectRatio.Checked = False
            End If
            num_Height.Value = selectedshape.Height / 72
            num_Width.Value = selectedshape.Width / 72
            num_Rot.Value = selectedshape.Rotation
            If selectedshape.Type.ToString = "msoPicture" Then
                If chkbx_RelativeOrig.Checked Then
                    num_ScaleHeight.Value = (selectedshape.Height * 100) / (txt_OriginalHeight.Text * 72)
                    num_ScaleWidth.Value = (selectedshape.Width * 100) / (txt_OriginalWidth.Text * 72)
                Else
                    num_ScaleHeight.Value = (selectedshape.Height * 100) / (originallength)
                    num_ScaleWidth.Value = (selectedshape.Width * 100) / (originalwidth)
                End If

            Else
                num_ScaleHeight.Value = (selectedshape.Height * 100) / (originallength)
                num_ScaleWidth.Value = (selectedshape.Width * 100) / (originalwidth)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub picturetools() ' got the original width and height of the picture
        chkbx_relativeorig.Enabled = True
        chkbx_BestScale.Enabled = True
        btn_ResetOriginalSize.Enabled = True

        Dim currentlength = selectedshape.Height
        Dim currentwidth = selectedshape.Width
        selectedshape.ScaleHeight(1, MsoTriState.msoTrue)
        selectedshape.ScaleWidth(1, MsoTriState.msoTrue)
        txt_OriginalHeight.Text = selectedshape.Height / 72
        txt_OriginalWidth.Text = selectedshape.Width / 72

        selectedshape.ScaleHeight(currentlength / (txt_OriginalHeight.Text * 72), MsoTriState.msoTrue)
        selectedshape.ScaleWidth(currentwidth / (txt_OriginalWidth.Text * 72), MsoTriState.msoTrue)


    End Sub
    Sub textboxtools()
        chkbx_relativeorig.Enabled = False
        chkbx_BestScale.Enabled = False
        'cbox_Resolution.Enabled = False
        txt_OriginalHeight.Text = ""
        txt_OriginalWidth.Text = ""
        btn_ResetOriginalSize.Enabled = False
    End Sub
    Sub changedimensions(ByVal height As Integer, ByVal width As Integer)
        selectedshape.Height = height
        selectedshape.Width = width
    End Sub
    Sub resolutioncontrol()
        'Select Case cbox_Resolution.SelectedIndex
        '    Case 0
        '        changedimensions(72 * 48.71, 72 * 35.42)
        '    Case 1

        '    Case 2

        '    Case 3

        'End Select
    End Sub

    Private Sub num_Height_ValueChanged(sender As Object, e As EventArgs) Handles num_Height.ValueChanged
        Try
            selectedshape.Height = num_Height.Value * 72
            getsizepage()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub num_Width_ValueChanged(sender As Object, e As EventArgs) Handles num_Width.ValueChanged
        Try
            selectedshape.Width = num_Width.Value * 72
            getsizepage()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub num_Rot_ValueChanged(sender As Object, e As EventArgs) Handles num_Rot.ValueChanged
        Try
            selectedshape.Rotation = num_Rot.Value
            getsizepage()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub chkbx_LockAspectRatio_CheckedChanged(sender As Object, e As EventArgs) Handles chkbx_LockAspectRatio.CheckedChanged
        If chkbx_LockAspectRatio.Checked Then
            selectshape()
            selectedshape.LockAspectRatio = MsoTriState.msoTrue
        Else
            selectedshape.LockAspectRatio = MsoTriState.msoFalse
        End If
    End Sub

    Private Sub num_ScaleHeight_ValueChanged(sender As Object, e As EventArgs) Handles num_ScaleHeight.ValueChanged
        Try
            If chkbx_RelativeOrig.Checked Then
                selectedshape.Height = (num_ScaleHeight.Value / 100) * (txt_OriginalHeight.Text * 72)
                getsizepage()
            Else
                selectedshape.Height = (num_ScaleHeight.Value / 100) * originallength
                getsizepage()
            End If

        Catch ex As Exception
        End Try
    End Sub
    Private Sub num_ScaleWidth_ValueChanged(sender As Object, e As EventArgs) Handles num_ScaleWidth.ValueChanged
        Try
            If chkbx_RelativeOrig.Checked Then
                selectedshape.Width = (num_ScaleWidth.Value / 100) * (txt_OriginalWidth.Text * 72)
            Else
                selectedshape.Width = (num_ScaleWidth.Value / 100) * originalwidth
                getsizepage()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub chkbx_relativeorig_CheckedChanged(sender As Object, e As EventArgs) Handles chkbx_RelativeOrig.CheckedChanged
        getsizepage()
    End Sub
    Private Sub btn_ResetOriginalSize_Click(sender As Object, e As EventArgs) Handles btn_ResetOriginalSize.Click
        selectedshape.Height = txt_OriginalHeight.Text * 72
        selectedshape.Width = txt_OriginalWidth.Text * 72
    End Sub

    '----------------------------------FILL FILL FILL FILL FILL FILL FILL FILL FILL FILL FILL ---------------------------------------'
    Sub getFillPage()
        If NoErros() Then
            If selectedshape.Fill.Visible = MsoTriState.msoFalse Then
                Manuallycheck(Rbtn_NoFill)
            Else
                Select Case selectedshape.Fill.Type
                    Case 1
                        Manuallycheck(Rbtn_SolidFill)
                        ExpandCollapse(Rbtn_SolidFill, 130, 50)
                        num_Transparency.Value = selectedshape.Fill.Transparency * 100
                    Case 2
                        Manuallycheck(Rbtn_PatternFilling)
                        ExpandCollapse(Rbtn_PatternFilling, 400, 50)
                    Case 3
                        Manuallycheck(Rbtn_Gradient)
                    Case 5
                        Manuallycheck(Rbtn_BackgroundFill)
                    Case 6 Or 4
                        Manuallycheck(Rbtn_TextureFill)
                        ExpandCollapse(Rbtn_TextureFill, 400, 50)
                        If selectedshape.Fill.TextureTile = MsoTriState.msoTrue Then
                            chkbx_texture.Checked = True
                        Else
                            chkbx_texture.Checked = False
                        End If
                End Select
            End If
        End If
    End Sub
    Function NoErros() As Boolean
        Dim NoError As Boolean = True
        Try
            selectedshape.GetHashCode()
            If Not selectedshape.HasTextFrame Then
                MsgBox("Please Select a valid shape")
                NoError = False
            End If
        Catch null As NullReferenceException
            PleaseSelect()
            NoError = False
        Catch general As Exception
            PleaseSelect()
            NoError = False
        End Try
        Return NoError
    End Function
    Private Sub chkbx_Fill_CheckedChanged(sender As Object, e As EventArgs) Handles chkbx_Fill.CheckedChanged
        If NoErros() Then
            ExpandCollapse(chkbx_Fill, Scont_Fill, 350, 50)
            ChangePattern()
        End If
    End Sub
    Private Sub Manuallycheck(ByVal Rbtn As RadioButton)
        Dim mycollection As New List(Of RadioButton)
        mycollection.Add(Rbtn_Gradient)
        mycollection.Add(Rbtn_NoFill)
        mycollection.Add(Rbtn_SolidFill)
        mycollection.Add(Rbtn_BackgroundFill)
        mycollection.Add(Rbtn_PatternFilling)
        mycollection.Add(Rbtn_TextureFill)
        For Each control As RadioButton In mycollection
            control.Checked = False
            If TypeOf (control.Parent) Is SplitterPanel Then
                ExpandCollapse(control, 400, 50)
            End If
        Next
        Rbtn.Checked = True
    End Sub
    Sub PleaseSelect()
        MsgBox("Please Select Shape First")
    End Sub
    'Solid Fill
    Sub ChooseColor(TheColor As PowerPoint.ColorFormat)
        Dim r, g, b As Integer
        ColorDialog_SolidFill.ShowDialog()
        With ColorDialog_SolidFill.Color
            r = .R
            g = .G
            b = .B
            TheColor.RGB = Color.FromArgb(0, b, g, r).ToArgb
        End With
    End Sub
    Private Sub Rbtn_SolidFill_Click(sender As Object, e As EventArgs) Handles Rbtn_SolidFill.Click
        If NoErros() Then
            Manuallycheck(Rbtn_SolidFill)
            ExpandCollapse(Rbtn_SolidFill, 130, 50)
            selectedshape.Fill.Solid()
        End If
    End Sub
    Private Sub btn_SolidFillColor_Click(sender As Object, e As EventArgs) Handles btn_SolidFillColor.Click
        If NoErros() Then
            ChooseColor(selectedshape.Fill.ForeColor)
        End If
    End Sub
    Private Sub num_Transparency_ValueChanged(sender As Object, e As EventArgs) Handles num_Transparency.ValueChanged
        Dim Transp As Double
        Transp = num_Transparency.Value / 100
        selectedshape.Fill.Transparency = Transp
    End Sub
    'Pattern Fill
    Function GetPatternType(ByVal index As Integer) As MsoPatternType
        Dim PatternType As MsoPatternType
        Select Case index
            Case 1 To 12
                PatternType = index
            Case 15, 16
                PatternType = index
            Case 13, 14, 17, 18, 21, 22
                PatternType = index + 8
            Case 19
                PatternType = MsoPatternType.msoPatternLightVertical
            Case 20
                PatternType = MsoPatternType.msoPatternLightHorizontal
            Case 23
                PatternType = MsoPatternType.msoPatternDarkVertical
            Case 24
                PatternType = MsoPatternType.msoPatternDarkHorizontal
            Case 25
                PatternType = MsoPatternType.msoPatternDashedDownwardDiagonal
            Case 26
                PatternType = MsoPatternType.msoPatternDashedUpwardDiagonal
            Case 27
                PatternType = MsoPatternType.msoPatternDashedHorizontal
            Case 28
                PatternType = MsoPatternType.msoPatternDashedVertical
            Case 29
                PatternType = MsoPatternType.msoPatternSmallConfetti
            Case 30
                PatternType = MsoPatternType.msoPatternLargeConfetti
            Case 31
                PatternType = MsoPatternType.msoPatternZigZag
            Case 32
                PatternType = MsoPatternType.msoPatternWave
            Case 33
                PatternType = MsoPatternType.msoPatternDiagonalBrick
            Case 34
                PatternType = MsoPatternType.msoPatternHorizontalBrick
            Case 35
                PatternType = MsoPatternType.msoPatternWeave
            Case 36
                PatternType = MsoPatternType.msoPatternPlaid
            Case 37
                PatternType = MsoPatternType.msoPatternDivot
            Case 38
                PatternType = MsoPatternType.msoPatternDottedGrid
            Case 39
                PatternType = MsoPatternType.msoPatternDottedDiamond
            Case 40
                PatternType = MsoPatternType.msoPatternShingle
            Case 41
                PatternType = MsoPatternType.msoPatternTrellis
            Case 42
                PatternType = MsoPatternType.msoPatternSphere
            Case 43
                PatternType = MsoPatternType.msoPatternSmallGrid
            Case 44
                PatternType = MsoPatternType.msoPatternLargeGrid
            Case 45
                PatternType = MsoPatternType.msoPatternSmallCheckerBoard
            Case 46
                PatternType = MsoPatternType.msoPatternLargeCheckerBoard
            Case 47
                PatternType = MsoPatternType.msoPatternOutlinedDiamond
            Case 48
                PatternType = MsoPatternType.msoPatternSolidDiamond
        End Select
        Return PatternType
    End Function
    Function ExtractNumber(Text As String) As Integer
        Dim number As Integer
        Dim stringnumber As String = ""
        For Each bit As String In Text
            If IsNumeric(bit) Then
                stringnumber += bit
            End If
        Next
        number = Integer.Parse(stringnumber)
        Return number
    End Function
    Sub ChangePattern()
        For Each rbtn As RadioButton In TLP_Patternimage.Controls
            Dim index As Integer = ExtractNumber(rbtn.Name)
            AddHandler rbtn.Click, Sub()
                                       selectedshape.Fill.Patterned(GetPatternType(index))
                                   End Sub
        Next
    End Sub
    Private Sub Rbtn_PatternFilling_Click(sender As Object, e As EventArgs) Handles Rbtn_PatternFilling.Click
        If NoErros() Then
            Manuallycheck(Rbtn_PatternFilling)
            ExpandCollapse(Rbtn_PatternFilling, 400, 50)
            RadioButton1.PerformClick()
            selectedshape.Fill.ForeColor.RGB = Color.FromArgb(0, 255, 0, 0).ToArgb
        End If
    End Sub
    Private Sub btn_patternBacks_Click(sender As Object, e As EventArgs) Handles btn_patternBacks.Click
        ChooseColor(selectedshape.Fill.BackColor)
    End Sub
    Private Sub btn_PatternFores_Click(sender As Object, e As EventArgs) Handles btn_PatternFores.Click
        ChooseColor(selectedshape.Fill.ForeColor)
    End Sub
    'No Fill
    Private Sub Rbtn_NoFill_Click(sender As Object, e As EventArgs) Handles Rbtn_NoFill.Click
        If NoErros() Then
            Manuallycheck(Rbtn_NoFill)
            selectedshape.Fill.Visible = MsoTriState.msoFalse
        End If
    End Sub
    'BackGround Fill
    Private Sub Rbtn_BackgroundFill_Click(sender As Object, e As EventArgs) Handles Rbtn_BackgroundFill.Click
        If NoErros() Then
            selectedshape.Fill.Background()
            Manuallycheck(Rbtn_BackgroundFill)
        End If
    End Sub
    'Gradient Fill
    Private Sub Rbtn_Gradient_Click(sender As Object, e As EventArgs) Handles Rbtn_Gradient.Click
        If NoErros() Then
            Manuallycheck(Rbtn_Gradient)
            ExpandCollapse(Rbtn_Gradient, 128, 50)
        End If
    End Sub
    'Texture fill
    Private Sub Rbtn_TextureFill_Click(sender As Object, e As EventArgs) Handles Rbtn_TextureFill.Click
        If NoErros() Then
            Manuallycheck(Rbtn_TextureFill)
            ExpandCollapse(Rbtn_TextureFill, 400, 50)
            selectedshape.Fill.PresetTextured(MsoPresetTexture.msoTexturePapyrus)
            chkbx_texture.Checked = True
        End If
    End Sub
    Public Sub TileAsTexture(ByVal index As Boolean)
        Scont_TxtrVsPctr.Panel1Collapsed = False
        Scont_TxtrVsPctr.Panel2Collapsed = False
        If index Then
            Scont_TxtrVsPctr.Panel1Collapsed = True
        Else
            Scont_TxtrVsPctr.Panel2Collapsed = True
        End If
    End Sub
    Private Sub chkbx_texture_CheckedChanged(sender As Object, e As EventArgs) Handles chkbx_texture.CheckedChanged
        If NoErros() Then
            If chkbx_texture.Checked Then
                TileAsTexture(True)
                selectedshape.Fill.TextureTile = MsoTriState.msoTrue
            Else
                TileAsTexture(False)
                selectedshape.Fill.TextureTile = MsoTriState.msoFalse
            End If
        End If
    End Sub
    Private Sub num_OffsetX_ValueChanged(sender As Object, e As EventArgs) Handles num_OffsetX.ValueChanged
        If NoErros() Then
            selectedshape.Fill.TextureOffsetX = num_OffsetX.Value / 100
        End If
    End Sub
    Private Sub num_offsetY_ValueChanged(sender As Object, e As EventArgs) Handles num_offsetY.ValueChanged
        If NoErros() Then
            selectedshape.Fill.TextureOffsetY = num_offsetY.Value / 100
        End If
    End Sub
    Private Sub num_ScaleXFill_ValueChanged(sender As Object, e As EventArgs) Handles num_ScaleXFill.ValueChanged
        If NoErros() Then
            selectedshape.Fill.TextureHorizontalScale = num_ScaleXFill.Value / 100
        End If
    End Sub
    Private Sub num_ScaleYFill_ValueChanged(sender As Object, e As EventArgs) Handles num_ScaleYFill.ValueChanged
        If NoErros() Then
            selectedshape.Fill.TextureVerticalScale = num_ScaleYFill.Value / 100
        End If
    End Sub
    Private Sub btn_FileTexture_Click(sender As Object, e As EventArgs) Handles btn_FileTexture.Click
        OpenFileDialog_PictureFill.ShowDialog()
        Dim filename As String
        filename = OpenFileDialog_PictureFill.FileName
        If NoErros() Then
            selectedshape.Fill.UserPicture(filename)
            chkbx_texture.Checked = False
        End If
    End Sub
#End Region
    '==================================================================ALIGNMENT ALIGNMENT ALIGNMENT ALIGNMENT ALIGNMENT ALIGNMENT =========================================================================='
    '===================================================================ALIGNMENT ALIGNMENT ALIGNMENT ALIGNMENT ALIGNMENT ALIGNMENT ================================================================='
#Region " Alignment"
    Sub execute(ByVal idmso As String)
        Try
            objapp.CommandBars.ExecuteMso(idmso)
        Catch ex As Exception
            MsgBox(" An Error Occured ")
        End Try
    End Sub
    Private Sub btn_Alignleft_Click(sender As Object, e As EventArgs) Handles btn_AlignLeft.Click
        execute("ObjectsAlignLeftSmart")
    End Sub
    Private Sub btn_AlignTop_Click(sender As Object, e As EventArgs) Handles btn_AlignTop.Click
        execute("ObjectsAlignTopSmart")
    End Sub
    Private Sub btn_AlignRight_Click(sender As Object, e As EventArgs) Handles btn_AlignRight.Click
        execute("ObjectsAlignRightSmart")
    End Sub
    Private Sub btn_AlignBottom_Click(sender As Object, e As EventArgs) Handles btn_AlignBottom.Click
        execute("ObjectsAlignBottomSmart")
    End Sub
    Private Sub btn_AlignCenter_Click(sender As Object, e As EventArgs) Handles btn_AlignCenter.Click
        execute("ObjectsAlignCenterHorizontalSmart")
    End Sub
    Private Sub btn_AlignMiddle_Click(sender As Object, e As EventArgs) Handles btn_AlignMiddle.Click
        execute(" ObjectsAlignMiddleVerticalSmart")
    End Sub
    Private Sub btn_SendtoBack_Click(sender As Object, e As EventArgs) Handles btn_SendtoBack.Click
        execute("ObjectSendToBack")
    End Sub
    Private Sub btn_BringForward_Click(sender As Object, e As EventArgs) Handles btn_BringForward.Click
        execute("ObjectBringForward ")
    End Sub
    Private Sub btn_BorderRight_Click(sender As Object, e As EventArgs) Handles btn_BorderRight.Click
        execute("BorderRight")
    End Sub
    Private Sub btn_BorderTop_Click(sender As Object, e As EventArgs) Handles btn_BorderTop.Click
        execute("BorderTop")
    End Sub
    Private Sub btn_BorderBottom_Click(sender As Object, e As EventArgs) Handles btn_BorderBottom.Click
        execute("BorderBottom")
    End Sub
    Private Sub btn_Borderleft_Click(sender As Object, e As EventArgs) Handles btn_BorderLeft.Click
        execute("BorderLeft")
    End Sub
    Private Sub btn_BorderAll_Click(sender As Object, e As EventArgs) Handles btn_BorderAll.Click
        execute("BordersAll")
    End Sub
    Private Sub btn_DistColumns_Click(sender As Object, e As EventArgs) Handles btn_DistColumns.Click
        execute("TableColumnsDistribute")
    End Sub
    Private Sub btn_DistRows_Click(sender As Object, e As EventArgs) Handles btn_DistRows.Click
        execute("TableRowsDistribute")
    End Sub
    Private Sub btn_PasteText_Click(sender As Object, e As EventArgs) Handles btn_PasteText.Click
        execute("Paste")
    End Sub
    Private Sub btn_FormatShape_Click(sender As Object, e As EventArgs) Handles btn_FormatShape.Click
        execute("ObjectFormatDialog")
    End Sub
    Private Sub btn_Paragraph_Click(sender As Object, e As EventArgs) Handles btn_Paragraph.Click
        execute("PowerPointParagraphDialog")
    End Sub
#End Region

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Scont_TxtrVsPctr.Panel1.Paint

    End Sub
    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub
    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub
    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

  
   

    Private Sub num_offsetleft_ValueChanged(sender As Object, e As EventArgs) Handles num_offsetleft.ValueChanged
        If NoErros() Then
         End If
    End Sub

  
    Private Sub btn_ClipboardTexture_Click(sender As Object, e As EventArgs) Handles btn_ClipboardTexture.Click
        Dim IMG As System.Drawing.Image
        Dim filename As String = Forms.Application.StartupPath
        If NoErros() Then
            If My.Computer.Clipboard.ContainsImage Then
                IMG = My.Computer.Clipboard.GetImage
                IMG.Save(filename)
                selectedshape.Fill.UserPicture(filename)
            Else
                MsgBox("Invalid Image")
                Exit Sub
            End If
        End If
    End Sub
End Class
