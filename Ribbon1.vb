Imports Microsoft.Office.Tools.Ribbon
Imports Microsoft.Office.Tools
Imports SemiFinalApproach.PowerPanel
Public Class Ribbon1
    Public Shared ctp As CustomTaskPane
    Public Shared Sub addtaskpane()
        ctp = Globals.ThisAddIn.CustomTaskPanes.Add(New PowerPanel, " PowerPlug")
        ctp.Width = 335
        ctp.Visible = True
    End Sub
    Public Shared Sub removetaskpane()
        Globals.ThisAddIn.CustomTaskPanes.Remove(ctp)
    End Sub
    Public Shared Sub ShowPlug_Click() Handles ShowPlug.Click
        Dim objbtn As RibbonToggleButton
        objbtn = Globals.Ribbons.Ribbon1.ShowPlug
        If Globals.ThisAddIn.Application.Presentations.Count <> 0 Then
            If objbtn.Checked Then
                addtaskpane()
            Else
                removetaskpane()
            End If
        Else
            MsgBox(" Please Open at least one presentation ")
        End If
    End Sub
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        Try
            If ctp.Visible = False Then
                ShowPlug.Checked = False
                removetaskpane()
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class
