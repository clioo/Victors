Public Class FRM_ABCEmpleados
    Private Sub CMD_Agregar_Click(sender As Object, e As EventArgs) Handles CMD_Agregar.Click
        FRM_Añadirempleado.Show()
    End Sub

    Private Sub CMD_Modificar_Click(sender As Object, e As EventArgs) Handles CMD_Modificar.Click
        FRM_ModificarEmpleado.Show()
    End Sub

    Private Sub CMD_Eliminar_Click(sender As Object, e As EventArgs) Handles CMD_Eliminar.Click
        FRM_EliminarEmpleado.Show()
    End Sub

    Private Sub CMD_Salir_Click(sender As Object, e As EventArgs) Handles CMD_Salir.Click
        Me.Close()
    End Sub
 
End Class