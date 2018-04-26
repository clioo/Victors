Public Class FRM_Ticket

    Private Sub CMD_Pagar_Click(sender As Object, e As EventArgs) Handles CMD_Pagar.Click
        If CB_Pago.Text = "Efectivo" Then
            FRM_Efectivo.Show()
        ElseIf CB_Pago.Text = "Tarjeta" Then


        ElseIf CB_Pago.Text = "Crédito" Then


        End If
    End Sub
End Class