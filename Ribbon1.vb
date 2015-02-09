Imports Microsoft.Office.Tools.Ribbon
Imports Microsoft.Office.Tools
Imports SemiFinalApproach.PowerPanel
Public Class Ribbon1
    Public Shared Sub addtaskpane()
        Dim ctp As CustomTaskPane
        ctp = Globals.ThisAddIn.CustomTaskPanes.Add(New PowerPanel, " PowerPlug")
        ctp.Width = 338
        ctp.Visible = True
    End Sub
    Public Shared Sub removetaskpane()
        Try
            For Each ctp As CustomTaskPane In Globals.ThisAddIn.CustomTaskPanes
                Globals.ThisAddIn.CustomTaskPanes.Remove(ctp)
            Next
        Catch ex As Exception
        End Try
    End Sub
    Public Shared Sub ShowPlug_Click() Handles ShowPlug.Click
        Dim objbtn As RibbonToggleButton
        objbtn = Globals.Ribbons.Ribbon1.ShowPlug
        Try
            If objbtn.Checked Then
                addtaskpane()
            Else
                removetaskpane()
            End If
        Catch ex As Exception
            MsgBox(" Please Open at least one presentation ")
            objbtn.Checked = False
        End Try
    End Sub

End Class
