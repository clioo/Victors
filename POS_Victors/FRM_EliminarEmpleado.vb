Imports System.IO
Public Class FRM_EliminarEmpleado

    Private Sub CMD_Acaptar_Click(sender As Object, e As EventArgs) Handles CMD_Acaptar.Click
        If txt_Numemp.Text = "" Then
            Beep()
            MsgBox("No ha introducido el número de empleado")
        Else
            MsgBox("Está a punto de eliminar al empleado número" & txt_Numemp.Text)
            'Inserte aquí código para dar de baja




        End If
    End Sub

    Private Sub CMD_Cancelar_Click(sender As Object, e As EventArgs) Handles CMD_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim progFiles As String = "C:\Program Files\Common Files\Microsoft Shared\ink"
        Dim keyboardPath As String = Path.Combine(progFiles, "TabTip.exe")
        Process.Start(keyboardPath)
    End Sub
End Class