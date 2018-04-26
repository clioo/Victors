Public Class FRM_Efectivo
    Dim numerolinea As Integer = 3
    Dim leerdocumento As New ArrayList

    Private Sub FRM_Efectivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        leerdocumento.Add("")
        leerdocumento.Add("Hola")
        leerdocumento.Add("Total: 300$")
        leerdocumento.Add("Abono: 0$")
        GUARDARENLB()
    End Sub
    Sub GUARDARENLB()
        LB_Ticket.Items.Clear()
        For x = 1 To numerolinea
            LB_Ticket.Items.Add(leerdocumento(x))
        Next
    End Sub
    Private Sub TXT_Recibido_TextChanged(sender As Object, e As EventArgs) Handles TXT_Recibido.TextChanged
        leerdocumento(numerolinea) = "Abono: " & TXT_Recibido.Text & "$"
        GUARDARENLB()
    End Sub
End Class