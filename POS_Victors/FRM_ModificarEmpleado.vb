Imports System.IO
Public Class FRM_ModificarEmpleado

    Private Sub CMD_Acaptar_Click(sender As Object, e As EventArgs) Handles CMD_Acaptar.Click
        If txt_Numemp.Text = "" Then
            Beep()
            MsgBox("Error, no has introducido el número de empleado")
        ElseIf txt_colonia.Text = "" Then
            Beep()
            MsgBox("Error, no has introducido la colonia")
        ElseIf txt_calle.Text = "" Then
            Beep()
            MsgBox("Error, no has introducido la calle")
        ElseIf txt_numext.Text = "" Then
            Beep()
            MsgBox("Error, no has introducido él número exterior")
        ElseIf txt_cp.Text = "" Then
            Beep()
            MsgBox("Error, no has introducido el código postal")
        ElseIf txt_telefono.Text = "" And txt_celular.Text = "" Then
            Beep()
            MsgBox("Error, no has introducido algún teléfono")
        Else 'Introduce el código de agregar trabajadores




        End If
    End Sub

    Private Sub CMD_Cancelar_Click(sender As Object, e As EventArgs) Handles CMD_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub txt_Numemp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Numemp.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim progFiles As String = "C:\Program Files\Common Files\Microsoft Shared\ink"
        Dim keyboardPath As String = Path.Combine(progFiles, "TabTip.exe")
        Process.Start(keyboardPath)
    End Sub
    Private Sub txt_numint_Keypress(sender As Object, e As KeyPressEventArgs) Handles txt_numint.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_numext_Keypress(sender As Object, e As KeyPressEventArgs) Handles txt_numext.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txt_telefono_Keypress(sender As Object, e As KeyPressEventArgs) Handles txt_telefono.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txt_celular_Keypress(sender As Object, e As KeyPressEventArgs) Handles txt_celular.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txt_cp_Keypress(sender As Object, e As KeyPressEventArgs) Handles txt_cp.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class