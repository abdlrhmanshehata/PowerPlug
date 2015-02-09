Imports System.Windows.Forms
Imports SemiFinalApproach.Ribbon1
Public Class ThisAddIn
    Private Sub Application_AfterNewPresentation(Pres As PowerPoint.Presentation) Handles Application.AfterNewPresentation
        Globals.Ribbons.Ribbon1.ShowPlug.Checked = False
        ShowPlug_Click()
        Globals.Ribbons.Ribbon1.ShowPlug.Checked = True
        ShowPlug_Click()
    End Sub

    Private Sub Application_WindowSelectionChange(Sel As PowerPoint.Selection) Handles Application.WindowSelectionChange

    End Sub
End Class
