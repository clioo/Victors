Imports System.Data.SqlClient
Public Class Usuario

    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion1 = New SqlConnection("Data Source=(local)\\SQLEXPRESS; initial Catalog = Escuela; Integrated Security=true")

    End Sub
End Class
