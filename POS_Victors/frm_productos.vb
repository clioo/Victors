Imports System.IO
Public Class frm_productos

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim progFiles As String = "C:\Program Files\Common Files\Microsoft Shared\ink"
        Dim keyboardPath As String = Path.Combine(progFiles, "TabTip.exe")
        Process.Start(keyboardPath)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FRM_AgregarProducto.Show()
    End Sub
End Class