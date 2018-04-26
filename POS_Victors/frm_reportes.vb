Imports System.IO
Public Class frm_reportes

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Frm_menu.Show()
        Me.Close()
    End Sub

    Private Sub frm_reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Text = Date.Now
        DateTimePicker2.Text = Date.Now
    End Sub
End Class
