Public Class FRM_ABCUsuarios

    Private Sub CMD_Agregar_Click(sender As Object, e As EventArgs) Handles CMD_Agregar.Click
        If TXT_USER.Text = "" Then
            Beep()
            MsgBox("No se introdujo usuario")
        ElseIf TXT_Password.Text = "" Then
            Beep()
            MsgBox("No se introdujo contraseña")
        Else
            'Código para añadir usuario


        End If
    End Sub

    Private Sub CMD_Modificar_Click(sender As Object, e As EventArgs) Handles CMD_Modificar.Click
        If TXT_User2.Text = "" Then
            Beep()
            MsgBox("No se introdujo usuario")
        End If
    End Sub
End Class