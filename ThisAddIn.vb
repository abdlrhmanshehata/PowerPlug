Imports System.Windows.Forms

Public Class ThisAddIn
    
    
    Private Sub Application_WindowSelectionChange(Sel As PowerPoint.Selection) Handles Application.WindowSelectionChange
        If Globals.Ribbons.Ribbon1.ShowPlug.Checked = False Then
            Globals.Ribbons.Ribbon1.ShowPlug.Checked = True
            Ribbon1.ShowPlug_Click()
        End If
    End Sub
End Class
