Imports System.IO
Public Class FRM_AgregarProducto
    Dim puntos As Boolean = False
    Private Sub CMD_Cancelar_Click(sender As Object, e As EventArgs) Handles CMD_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub CMD_Acaptar_Click(sender As Object, e As EventArgs) Handles CMD_Acaptar.Click
        If txt_clave.Text = "" Then
            Beep()
            MsgBox("Error, no se ha introducido la clave del producto")
        ElseIf txt_producto.Text = "" Then
            Beep()
            MsgBox("Error, no se ha introducido el nombre del producto")
        ElseIf Val(txt_CANTIDAD.Text) <= 0 Then
            Beep()
            MsgBox("Error, no se ha introducido la cantidad o es cero")
        ElseIf Val(txt_precioC.Text) <= 0 Then
            Beep()
            MsgBox("Error, no se ha introducido el precio o es cero")
        Else
            'Inserte código de agregar producto

        End If
    End Sub
    Private Sub txt_clave_Keypress(sender As Object, e As KeyPressEventArgs) Handles txt_clave.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txt_precio_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CANTIDAD.KeyPress
        e.Handled = txtNumericoentero(txt_CANTIDAD, e.KeyChar, False)
    End Sub


    Private Sub txt_CANTIDAD_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CANTIDAD.KeyPress
        e.Handled = txtNumericoentero(txt_CANTIDAD, e.KeyChar, True)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim progFiles As String = "C:\Program Files\Common Files\Microsoft Shared\ink"
        Dim keyboardPath As String = Path.Combine(progFiles, "TabTip.exe")
        Process.Start(keyboardPath)
    End Sub
End Class