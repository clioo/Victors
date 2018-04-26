Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-FL58SDV;Initial Catalog=BD_Viktor's;Integrated Security=True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public comando As SqlCommand

    Public Sub Conectar()
        Try
            conexion.Open()
        Catch ex As Exception
            MessageBox.Show("Error al conectar.")
        Finally
            conexion.Close()
        End Try
    End Sub
    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub
End Class
