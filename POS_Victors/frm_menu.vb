Imports System
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms
Public Class Frm_menu
    Public archivo_tacos As New StreamWriter("C:\TICKETS\TACOS.TXT")
    Public archivo_flautas As New StreamWriter("C:\TICKETS\FLAUTAS.TXT")
    Public archivo_empaques As New StreamWriter("C:\TICKETS\EMPAQUES.TXT")
    Public archivo_cliente As New StreamWriter("C:\TICKETS\CLIENTES.TXT")
    Private printFont As Font
    Private streamToPrint As StreamReader
    Public conexion As New Conexion
    Structure Struc_Productos
        Dim ID_producto As Integer
        Dim nombre, tipo_producto As String
        Dim precio_venta As Double
    End Structure
    Structure Struc_vendidos
        Dim ID_producto, cantidad As Integer
        Dim nombre, servicio As String
        Dim precio, importe As Double
    End Structure
    Dim productos(100) As Struc_Productos
    Dim vendidos(100) As Struc_vendidos
    Dim contador_vendidos As Integer
    Public Sub MostrarDatos()
        conexion.Consulta("SELECT * FROM PRODUCTO", "PRODUCTO")
        dgv_productos.DataSource = conexion.ds.Tables("PRODUCTO")

    End Sub
    Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        conexion.Conectar()
        MostrarDatos()
        For x = 0 To dgv_productos.Rows.Count - 1
            productos(x).ID_producto = Convert.ToInt32(dgv_productos.Rows(x).Cells(0).Value)
            productos(x).tipo_producto = Convert.ToString(dgv_productos.Rows(x).Cells(1).Value)
            productos(x).nombre = Convert.ToString(dgv_productos.Rows(x).Cells(2).Value)
            productos(x).precio_venta = Convert.ToDouble(dgv_productos.Rows(x).Cells(3).Value)
        Next
        limpiar()
    End Sub
    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        End
    End Sub

    Private Sub txt_clave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_clave.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
            '**************************************************
        ElseIf e.KeyChar = Chr(13) Then
            vender_producto()
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        Dim progFiles As String = "C:\Program Files\Common Files\Microsoft Shared\ink"
        Dim keyboardPath As String = Path.Combine(progFiles, "TabTip.exe")
        Process.Start(keyboardPath)
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles CMD_Reportes.Click
        frm_reportes.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles CMD_Clientes.Click
        FRM_ABCClientes.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CMD_Empleados.Click
        FRM_ABCEmpleados.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles CMD_Usuarios.Click
        FRM_ABCUsuarios.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CMD_Proveedor.Click
        FRM_ABCProveedor.Show()
    End Sub


    Private Sub Button13_Click(sender As Object, e As EventArgs)
        FRM_Ticket.Show()
    End Sub

    Private Sub CMD_Productos_Click(sender As Object, e As EventArgs) Handles CMD_Productos.Click
        frm_productos.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles cmd_terminar_venta.Click
        archivo_tacos.Close()
        archivo_flautas.Close()
        archivo_cliente.Close()
        archivo_empaques.Close()
        archivo_tacos = New StreamWriter("C:\TICKETS\TACOS.TXT")
        archivo_flautas = New StreamWriter("C:\TICKETS\FLAUTAS.TXT")
        archivo_empaques = New StreamWriter("C:\TICKETS\EMPAQUES.TXT")
        archivo_cliente = New StreamWriter("C:\TICKETS\CLIENTES.TXT")
        If txt_clave.Text <> "" Then
            MsgBox("Termine su pedido antes de continuar")
            txt_clave.Focus()
        ElseIf txt_nombre.Text = "" Then
            MsgBox("Ingrese nombre del cliente")
            txt_nombre.Focus()
        ElseIf bol_empaques() = False And bol_para_llevar() = True Then
            MsgBox("Se detectó una venta para llevar, pero no estás cobrando empaque, verifícalo")
            txt_clave.Focus()
        ElseIf bol_empaques() = True And bol_para_llevar() = False Then
            MsgBox("Se detectó un cobro por empaque pero no hay venta para llevar, veríficalo")
            txt_clave.Focus()
        ElseIf Val(txt_total.Text) = 0 Then
            MsgBox("Necesita haber una venta para continuar")
            txt_clave.Focus()
        ElseIf cb_tipo_pago.Text = "Seleccione" Then
            MsgBox("Seleccione un tipo de pago")
            cb_tipo_pago.Focus()
        ElseIf cb_tipo_pago.Text = "Efectivo" Then
            If txt_dinero.Text = "" Then
                MsgBox("Pregunte amablemente con que cantidad le van a pagar")
                txt_dinero.Focus()
            ElseIf Val(txt_cambio.Text) < 0 Then
                MsgBox("Al cliente no le alcanza")
                txt_dinero.Focus()
            ElseIf MsgBox("Le pagan con: $" & txt_dinero.Text & Environment.NewLine & "El toal es de: " & txt_total.Text & Environment.NewLine & "El cambio es: $" & Val(txt_dinero.Text) - Val(txt_total.Text) & Environment.NewLine & Environment.NewLine & "¿Desea continuar?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                'aqui va comandos sql

                escribir_tickets()
                limpiar()
            End If
        ElseIf cb_tipo_pago.Text = "Tarjeta" Then
            If MsgBox("Inserte la tarjeta " & Environment.NewLine & "NO PRESIONE 'SI' HASTA QUE SEA APROBADA" & Environment.NewLine & "¿Fue aprobada?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                'aqui va comando insert sql
                escribir_tickets()
                limpiar()
            End If
        ElseIf cb_tipo_pago.Text = "Credito" Then
            If cb_cliente.Text = "" Then
                MsgBox("Seleccione cliente")
                cb_cliente.Focus()
            ElseIf MsgBox("¿Todo esta correcto?" & Environment.NewLine & "Cliente: " & cb_cliente.Text & Environment.NewLine & "Total: " & txt_total.Text, MessageBoxButtons.YesNo) = DialogResult.Yes Then
                'aqui va comando insert sql

                limpiar()
            End If
        End If
    End Sub

    Private Sub cb_tipo_pago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_tipo_pago.SelectedIndexChanged
        If cb_tipo_pago.Text = "Credito" Then
            gb_cliente.Visible = True
            gb_dinero.Visible = False
            txt_cambio.Visible = False
            txt_recibe.Visible = False
        ElseIf cb_tipo_pago.Text = "Efectivo" Then
            gb_dinero.Visible = True
            gb_cliente.Visible = False
            txt_cambio.Visible = True
            txt_recibe.Visible = True
        Else
            gb_cliente.Visible = False
            gb_dinero.Visible = False
            txt_cambio.Visible = False
            txt_recibe.Visible = False
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            dgv_tickets.Rows.Remove(dgv_tickets.CurrentRow)
            actualizar_vendidos()
            calcular_total()
        Catch ex As Exception
            MsgBox("La lista está vacía, no puede eliminar")
        End Try
    End Sub
    Private Sub cb_servicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_servicio.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
            '**************************************************
        ElseIf e.KeyChar = Chr(13) Then
            vender_producto()
        Else
            e.Handled = True
        End If
    End Sub
    Sub vender_producto()
        If cb_servicio.Text = "Seleccione" Then
            MsgBox("Seleccione si es para llevar o para comer aquí")
            cb_servicio.Focus()
        ElseIf txt_clave.Text = "" Then
            MsgBox("Ingrese la clave del producto antes de ingresar")
            txt_clave.Focus()
        ElseIf numeric_cantidad.Value = 0 Then
            MsgBox("No puede veder 0 productos")
            numeric_cantidad.Focus()
        ElseIf buscar_vendidos(Convert.ToInt32(txt_clave.Text), cb_servicio.Text) Then
            MsgBox("Ya ingresaste esa venta")
            txt_clave.Focus()
        ElseIf buscar_producto(txt_clave.Text) = True Then
            vendidos(contador_vendidos).ID_producto = Convert.ToInt32(txt_clave.Text)
            vendidos(contador_vendidos).nombre = obtener_nombre_producto(txt_clave.Text)
            vendidos(contador_vendidos).precio = obtener_precio_producto(txt_clave.Text)
            vendidos(contador_vendidos).cantidad = numeric_cantidad.Value
            vendidos(contador_vendidos).importe = numeric_cantidad.Value * vendidos(contador_vendidos).precio
            vendidos(contador_vendidos).servicio = cb_servicio.Text
            If txt_clave.Text = "0" Then
                dgv_tickets.Rows.Add(vendidos(contador_vendidos).ID_producto, vendidos(contador_vendidos).nombre, vendidos(contador_vendidos).precio, numeric_cantidad.Value, vendidos(contador_vendidos).importe, "Empacado")
            Else
                dgv_tickets.Rows.Add(vendidos(contador_vendidos).ID_producto, vendidos(contador_vendidos).nombre, vendidos(contador_vendidos).precio, numeric_cantidad.Value, vendidos(contador_vendidos).importe, cb_servicio.Text)
            End If
            actualizar_vendidos()
            cb_tipo_pago.Text = "Efectivo"
            numeric_cantidad.Value = 1
            cb_servicio.Text = "Comer aqui"
            gb_cliente.Visible = False
            gb_dinero.Visible = True
            numeric_cantidad.Focus()
            txt_clave.Clear()
            calcular_total()
        End If


    End Sub
    Function obtener_nombre_producto(ByVal clave As Integer) As String
        For x = 0 To dgv_productos.Rows.Count - 1
            If productos(x).ID_producto = clave Then
                Return productos(x).nombre
            End If

        Next

        Return ""
    End Function
    Function buscar_producto(ByVal clave As Integer) As Boolean
        For x = 0 To dgv_productos.Rows.Count - 1
            If productos(x).ID_producto = clave Then
                Return True
            End If
        Next

        Return False
    End Function
    Function obtener_precio_producto(ByVal clave As Integer) As Double
        For x = 0 To dgv_productos.Rows.Count - 1
            If productos(x).ID_producto = clave Then
                Return productos(x).precio_venta
            End If
        Next
        Return 0
    End Function
    Function buscar_vendidos(ByVal clave As Integer, ByVal servicio As String) As Boolean
        For x = 0 To contador_vendidos
            If vendidos(x).ID_producto = clave And vendidos(x).servicio = servicio Then
                Return True
            End If
        Next

        Return False
    End Function
    Private Sub cb_tipo_pago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_tipo_pago.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
            '**************************************************
        ElseIf e.KeyChar = Chr(13) Then
            vender_producto()
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
        '**************************************************
        If e.KeyChar = Chr(13) Then
            vender_producto()
        End If
    End Sub
    Private Sub cb_cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_cliente.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
            '**************************************************
        ElseIf e.KeyChar = Chr(13) Then
            vender_producto()
        Else
            e.Handled = True
        End If
    End Sub
    Sub calcular_total()
        Dim total As Double
        For x = 0 To contador_vendidos
            total = total + vendidos(x).importe
        Next
        txt_total.Text = total
        txt_cambio.Text = Val(txt_dinero.Text) - total
    End Sub

    Private Sub txt_total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_total.KeyPress
        e.Handled = True
    End Sub

    Private Sub txt_recibe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_recibe.KeyPress
        e.Handled = True
    End Sub

    Private Sub txt_dinero_TextChanged(sender As Object, e As EventArgs) Handles txt_dinero.TextChanged
        txt_recibe.Text = txt_dinero.Text
        txt_cambio.Text = Val(txt_recibe.Text) - Val(txt_total.Text)
    End Sub
    Sub limpiar()
        ReDim vendidos(100)
        txt_nombre.Clear()
        cb_tipo_pago.Text = "Efectivo"
        numeric_cantidad.Value = 1
        cb_servicio.Text = "Comer aqui"
        gb_cliente.Visible = False
        gb_dinero.Visible = True
        dgv_tickets.Rows.Clear()
        txt_total.Text = 0
        txt_cambio.Text = 0
        txt_recibe.Text = 0
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        dgv_tickets.CurrentRow.Cells(3).Value = dgv_tickets.CurrentRow.Cells(3).Value + 1
        dgv_tickets.CurrentRow.Cells(4).Value = dgv_tickets.CurrentRow.Cells(3).Value * dgv_tickets.CurrentRow.Cells(2).Value
        actualizar_vendidos()
        calcular_total()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If dgv_tickets.CurrentRow.Cells(3).Value = 1 Then
            MsgBox("Ya no puede restar mas a la cantidad")
        Else
            dgv_tickets.CurrentRow.Cells(3).Value = dgv_tickets.CurrentRow.Cells(3).Value - 1
            dgv_tickets.CurrentRow.Cells(4).Value = dgv_tickets.CurrentRow.Cells(3).Value * dgv_tickets.CurrentRow.Cells(2).Value
            actualizar_vendidos()
            calcular_total()
        End If


    End Sub
    Sub actualizar_vendidos()
        ReDim vendidos(100)
        contador_vendidos = 0
        For x = 0 To dgv_tickets.Rows.Count - 1
            vendidos(contador_vendidos).ID_producto = dgv_tickets.Rows(x).Cells(0).Value
            vendidos(contador_vendidos).nombre = dgv_tickets.Rows(x).Cells(1).Value
            vendidos(contador_vendidos).precio = dgv_tickets.Rows(x).Cells(2).Value
            vendidos(contador_vendidos).cantidad = dgv_tickets.Rows(x).Cells(3).Value
            vendidos(contador_vendidos).importe = dgv_tickets.Rows(x).Cells(4).Value
            vendidos(contador_vendidos).servicio = dgv_tickets.Rows(x).Cells(5).Value
            contador_vendidos = contador_vendidos + 1
        Next
    End Sub

    Private Sub cmd_cancelar_venta_Click(sender As Object, e As EventArgs) Handles cmd_cancelar_venta.Click
        limpiar()
    End Sub
    Function bol_para_llevar() As Boolean
        For x = 0 To contador_vendidos - 1
            If vendidos(x).servicio = "para llevar" Then
                Return True
            End If
        Next
        Return False
    End Function
    Function bol_empaques() As Boolean
        For x = 0 To contador_vendidos - 1
            If vendidos(x).ID_producto = 0 Then
                Return True
            End If
        Next
        Return False
    End Function


   

    Sub escribir_tickets()
        Dim fecha As String
        Dim total As Double
        Dim caracter As String
        Dim empaques, tacos, flautas As Boolean
        fecha = Date.Now
        archivo_cliente.WriteLine("_________________________________________________")
        archivo_cliente.WriteLine("TACTOS Y FLAUTAS VICTOR'S")
        archivo_cliente.WriteLine("FECHA: " & fecha)
        archivo_cliente.WriteLine("Producto" & dar_espacios(8, 27) & "Cantidad    Importe")
        archivo_cliente.Flush()
        For x = 0 To contador_vendidos - 1
            caracter = Mid(vendidos(x).ID_producto, 1, 1)
            If vendidos(x).servicio = "Para llevar" Or vendidos(x).nombre = "Empaque" Then
                If empaques = False Then
                    archivo_empaques.WriteLine("____________________PARA LLEVAR_______________________")
                    archivo_empaques.WriteLine("Producto" & dar_espacios(8, 27) & "Cantidad")
                End If
                empaques = True
                archivo_empaques.WriteLine(vendidos(x).nombre & dar_espacios(vendidos(x).nombre.Length, 29) & vendidos(x).cantidad)
            End If
            If caracter = "1" Then
                If flautas = False Then
                    archivo_flautas.WriteLine("____________________FLAUTAS_______________________")
                    archivo_flautas.WriteLine("Producto" & dar_espacios(8, 27) & "Cantidad")
                End If
                flautas = True
                archivo_flautas.WriteLine(vendidos(x).nombre & dar_espacios(vendidos(x).nombre.Length, 29) & vendidos(x).cantidad)
            End If

            If caracter = "2" Then
                If tacos = False Then
                    archivo_tacos.WriteLine("____________________TACOS_______________________")
                    archivo_tacos.WriteLine("Producto" & dar_espacios(8, 27) & "Cantidad")
                End If
                tacos = True
                archivo_tacos.WriteLine(vendidos(x).nombre & dar_espacios(vendidos(x).nombre.Length, 29) & vendidos(x).cantidad)
            End If



            archivo_cliente.WriteLine(vendidos(x).nombre & dar_espacios(vendidos(x).nombre.Length, 29) & vendidos(x).cantidad & dar_espacios(1, 10) & FormatNumber(vendidos(x).importe, 2))
            total = total + vendidos(x).importe
        Next
        archivo_cliente.WriteLine()
        archivo_cliente.WriteLine(dar_espacios(1, 34) & "TOTAL: " & FormatNumber(txt_total.Text, 2))
        archivo_cliente.WriteLine("NOMBRE DEL CLIENTE: " & UCase(txt_nombre.Text))
        If empaques = True Then
            archivo_empaques.WriteLine("NOMBRE DEL CLIENTE: " & UCase(txt_nombre.Text))
            archivo_empaques.Flush()
        End If
        If flautas = True Then
            archivo_flautas.WriteLine("NOMBRE DEL CLIENTE: " & UCase(txt_nombre.Text))
            archivo_flautas.Flush()
        End If
        If tacos = True Then
            archivo_tacos.WriteLine("NOMBRE DEL CLIENTE: " & UCase(txt_nombre.Text))
            archivo_tacos.Flush()
        End If
        archivo_cliente.Flush()
        imprimir("C:\TICKETS\CLIENTES.TXT", "CLIENTES")
        If tacos = True Then
            imprimir("C:\TICKETS\TACOS.TXT", "TACOS")
        End If
        If flautas = True Then
            imprimir("C:\TICKETS\FLAUTAS.TXT", "FLAUTAS")
        End If
        If empaques = True Then
            imprimir("C:\TICKETS\EMPAQUES.TXT", "EMPAQUES")
        End If

    End Sub

    Function dar_espacios(ByVal caracteres As Integer, ByVal maximo As Integer) As String
        Dim cadena As String = ""

        If caracteres < maximo Then
            For x = caracteres To maximo
                cadena = cadena & " "
            Next
        End If
        Return cadena
    End Function

    Private Sub txt_dinero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_dinero.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Function imprimir(ByVal ubicacion As String, ByVal impresora As String) As Boolean
        Try
            streamToPrint = New StreamReader(ubicacion)
            Try
                printFont = New Font("Courier New", 6)
                Dim pd As New PrintDocument()
                AddHandler pd.PrintPage, AddressOf Me.pd_PrintPage
                pd.PrinterSettings.PrinterName = impresora
                pd.Print()
            Finally
                streamToPrint.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim linesPerPage As Single = 0
        Dim yPos As Single = 0
        Dim count As Integer = 0
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim line As String = Nothing

        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)

        ' Print each line of the file.
        While count < linesPerPage
            line = streamToPrint.ReadLine()
            If line Is Nothing Then
                Exit While
            End If
            yPos = topMargin + count * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, New StringFormat())
            count += 1
        End While

        ' If more lines exist, print another page.
        If (line IsNot Nothing) Then
            ev.HasMorePages = True
        Else
            ev.HasMorePages = False
        End If
    End Sub

End Class