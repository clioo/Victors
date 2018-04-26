Public Class FRM_MasterPassword
    Dim masterpassword As String = "12345"
    Dim contador As Integer = 0
    Private Sub FRM_MasterCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Beep()
        MsgBox("Por favor introduzca la contraseña maestra")
    End Sub

    Private Sub CMD_ACEPTAR_Click(sender As Object, e As EventArgs) Handles CMD_ACEPTAR.Click
        If masterpassword = TXT_contraseña.Text Then
            Permisomaestro = True
            MsgBox("Vuelva a seleccionar el area a donde quería entrar")
            Me.Close()
        End If
    End Sub

  
End Class