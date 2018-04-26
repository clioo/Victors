Imports System.IO
Public Class FRM_Añadirempleado
    Private Sub CMD_Acaptar_Click(sender As Object, e As EventArgs) Handles CMD_Acaptar.Click
        If txt_appa.Text = "" Then
            Beep()
            MsgBox("Error, no has introducido el apellido paterno")
        ElseIf txt_apma.Text = "" Then
            Beep()
            MsgBox("Error, no has introducido el apellido materno")
        ElseIf txt_nombre.Text = "" Then
            Beep()
            MsgBox("Error, no has introducido el nombre")
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
        ElseIf txt_curp.Text = "" Then
            Beep()
            MsgBox("Error, no has introducido la CURP")
        ElseIf txt_nss.Text = "" Then
            Beep()
            MsgBox("Error, no has introducido el NSS")
        Else 'Introduce el código de agregar trabajadores




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