<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgv_tickets = New System.Windows.Forms.DataGridView()
        Me.clmn_clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmn_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmn_precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmn_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmn_importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.numeric_cantidad = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cb_servicio = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CMD_Utencilios = New System.Windows.Forms.Button()
        Me.CMD_Empleados = New System.Windows.Forms.Button()
        Me.CMD_Usuarios = New System.Windows.Forms.Button()
        Me.CMD_Proveedor = New System.Windows.Forms.Button()
        Me.CMD_Productos = New System.Windows.Forms.Button()
        Me.cmd_cancelar_venta = New System.Windows.Forms.Button()
        Me.cmd_terminar_venta = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.CMD_Clientes = New System.Windows.Forms.Button()
        Me.CMD_Reportes = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cb_tipo_pago = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gb_cliente = New System.Windows.Forms.GroupBox()
        Me.cb_cliente = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.dgv_productos = New System.Windows.Forms.DataGridView()
        Me.gb_dinero = New System.Windows.Forms.GroupBox()
        Me.txt_dinero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_recibe = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_cambio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.dgv_tickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.numeric_cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gb_cliente.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgv_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_dinero.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_tickets
        '
        Me.dgv_tickets.AllowUserToAddRows = False
        Me.dgv_tickets.AllowUserToDeleteRows = False
        Me.dgv_tickets.AllowUserToOrderColumns = True
        Me.dgv_tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tickets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmn_clave, Me.clmn_nombre, Me.clmn_precio, Me.clmn_cantidad, Me.clmn_importe, Me.Column1})
        Me.dgv_tickets.Location = New System.Drawing.Point(9, 213)
        Me.dgv_tickets.Name = "dgv_tickets"
        Me.dgv_tickets.Size = New System.Drawing.Size(672, 321)
        Me.dgv_tickets.TabIndex = 30
        Me.dgv_tickets.TabStop = False
        '
        'clmn_clave
        '
        Me.clmn_clave.HeaderText = "Clave"
        Me.clmn_clave.Name = "clmn_clave"
        Me.clmn_clave.ReadOnly = True
        Me.clmn_clave.Width = 50
        '
        'clmn_nombre
        '
        Me.clmn_nombre.HeaderText = "Nombre"
        Me.clmn_nombre.Name = "clmn_nombre"
        Me.clmn_nombre.ReadOnly = True
        Me.clmn_nombre.Width = 300
        '
        'clmn_precio
        '
        Me.clmn_precio.HeaderText = "Precio"
        Me.clmn_precio.Name = "clmn_precio"
        Me.clmn_precio.ReadOnly = True
        Me.clmn_precio.Width = 50
        '
        'clmn_cantidad
        '
        Me.clmn_cantidad.HeaderText = "Cantidad"
        Me.clmn_cantidad.Name = "clmn_cantidad"
        Me.clmn_cantidad.ReadOnly = True
        Me.clmn_cantidad.Width = 60
        '
        'clmn_importe
        '
        Me.clmn_importe.HeaderText = "Importe"
        Me.clmn_importe.Name = "clmn_importe"
        Me.clmn_importe.ReadOnly = True
        Me.clmn_importe.Width = 70
        '
        'Column1
        '
        Me.Column1.HeaderText = "Servicio"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 65)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Producto"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txt_clave)
        Me.GroupBox6.Location = New System.Drawing.Point(89, 9)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(109, 47)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Clave"
        '
        'txt_clave
        '
        Me.txt_clave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clave.Location = New System.Drawing.Point(6, 18)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(89, 26)
        Me.txt_clave.TabIndex = 2
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.numeric_cantidad)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 13)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(75, 46)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Cantidad"
        '
        'numeric_cantidad
        '
        Me.numeric_cantidad.Location = New System.Drawing.Point(6, 17)
        Me.numeric_cantidad.Name = "numeric_cantidad"
        Me.numeric_cantidad.Size = New System.Drawing.Size(63, 22)
        Me.numeric_cantidad.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cb_servicio)
        Me.GroupBox3.Location = New System.Drawing.Point(204, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(129, 44)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Servicio"
        '
        'cb_servicio
        '
        Me.cb_servicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_servicio.FormattingEnabled = True
        Me.cb_servicio.Items.AddRange(New Object() {"Para llevar", "Comer aqui"})
        Me.cb_servicio.Location = New System.Drawing.Point(6, 14)
        Me.cb_servicio.Name = "cb_servicio"
        Me.cb_servicio.Size = New System.Drawing.Size(121, 24)
        Me.cb_servicio.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(546, 584)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 32)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 629)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "# Folio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(105, 629)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Usuario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 655)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "----"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(114, 655)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "----"
        '
        'CMD_Utencilios
        '
        Me.CMD_Utencilios.Image = Global.POS_Victors.My.Resources.Resources.xapple_icon_60x60_png_pagespeed_ic_HyPRIXhW_A
        Me.CMD_Utencilios.Location = New System.Drawing.Point(632, 13)
        Me.CMD_Utencilios.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CMD_Utencilios.Name = "CMD_Utencilios"
        Me.CMD_Utencilios.Size = New System.Drawing.Size(83, 83)
        Me.CMD_Utencilios.TabIndex = 45
        Me.CMD_Utencilios.TabStop = False
        Me.CMD_Utencilios.Text = "Utencilios"
        Me.CMD_Utencilios.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMD_Utencilios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.CMD_Utencilios.UseVisualStyleBackColor = True
        '
        'CMD_Empleados
        '
        Me.CMD_Empleados.Image = Global.POS_Victors.My.Resources.Resources._1fa31bbfa14409e7f4ad4c985a21d1a2
        Me.CMD_Empleados.Location = New System.Drawing.Point(365, 13)
        Me.CMD_Empleados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CMD_Empleados.Name = "CMD_Empleados"
        Me.CMD_Empleados.Size = New System.Drawing.Size(83, 83)
        Me.CMD_Empleados.TabIndex = 24
        Me.CMD_Empleados.TabStop = False
        Me.CMD_Empleados.Text = "Empleados"
        Me.CMD_Empleados.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMD_Empleados.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.CMD_Empleados.UseVisualStyleBackColor = True
        '
        'CMD_Usuarios
        '
        Me.CMD_Usuarios.Image = Global.POS_Victors.My.Resources.Resources.Usuarios
        Me.CMD_Usuarios.Location = New System.Drawing.Point(454, 13)
        Me.CMD_Usuarios.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CMD_Usuarios.Name = "CMD_Usuarios"
        Me.CMD_Usuarios.Size = New System.Drawing.Size(83, 83)
        Me.CMD_Usuarios.TabIndex = 23
        Me.CMD_Usuarios.TabStop = False
        Me.CMD_Usuarios.Text = "Usuarios"
        Me.CMD_Usuarios.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMD_Usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.CMD_Usuarios.UseVisualStyleBackColor = True
        '
        'CMD_Proveedor
        '
        Me.CMD_Proveedor.Image = Global.POS_Victors.My.Resources.Resources.camion
        Me.CMD_Proveedor.Location = New System.Drawing.Point(276, 13)
        Me.CMD_Proveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CMD_Proveedor.Name = "CMD_Proveedor"
        Me.CMD_Proveedor.Size = New System.Drawing.Size(83, 83)
        Me.CMD_Proveedor.TabIndex = 22
        Me.CMD_Proveedor.TabStop = False
        Me.CMD_Proveedor.Text = "Proveedor"
        Me.CMD_Proveedor.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMD_Proveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.CMD_Proveedor.UseVisualStyleBackColor = True
        '
        'CMD_Productos
        '
        Me.CMD_Productos.Image = Global.POS_Victors.My.Resources.Resources.images
        Me.CMD_Productos.Location = New System.Drawing.Point(187, 13)
        Me.CMD_Productos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CMD_Productos.Name = "CMD_Productos"
        Me.CMD_Productos.Size = New System.Drawing.Size(83, 83)
        Me.CMD_Productos.TabIndex = 21
        Me.CMD_Productos.TabStop = False
        Me.CMD_Productos.Text = "Productos"
        Me.CMD_Productos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMD_Productos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.CMD_Productos.UseVisualStyleBackColor = True
        '
        'cmd_cancelar_venta
        '
        Me.cmd_cancelar_venta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmd_cancelar_venta.Image = Global.POS_Victors.My.Resources.Resources.Cancelar
        Me.cmd_cancelar_venta.Location = New System.Drawing.Point(687, 280)
        Me.cmd_cancelar_venta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd_cancelar_venta.Name = "cmd_cancelar_venta"
        Me.cmd_cancelar_venta.Size = New System.Drawing.Size(60, 60)
        Me.cmd_cancelar_venta.TabIndex = 14
        Me.cmd_cancelar_venta.UseVisualStyleBackColor = True
        '
        'cmd_terminar_venta
        '
        Me.cmd_terminar_venta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmd_terminar_venta.Image = Global.POS_Victors.My.Resources.Resources.Paloma
        Me.cmd_terminar_venta.Location = New System.Drawing.Point(687, 212)
        Me.cmd_terminar_venta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd_terminar_venta.Name = "cmd_terminar_venta"
        Me.cmd_terminar_venta.Size = New System.Drawing.Size(60, 60)
        Me.cmd_terminar_venta.TabIndex = 12
        Me.cmd_terminar_venta.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button9.Image = Global.POS_Victors.My.Resources.Resources.Cruz
        Me.Button9.Location = New System.Drawing.Point(150, 541)
        Me.Button9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(60, 60)
        Me.Button9.TabIndex = 76
        Me.Button9.TabStop = False
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button8.Image = Global.POS_Victors.My.Resources.Resources.Menos
        Me.Button8.Location = New System.Drawing.Point(84, 541)
        Me.Button8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(60, 60)
        Me.Button8.TabIndex = 70
        Me.Button8.TabStop = False
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button7.Image = Global.POS_Victors.My.Resources.Resources.Mas
        Me.Button7.Location = New System.Drawing.Point(18, 541)
        Me.Button7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(60, 60)
        Me.Button7.TabIndex = 60
        Me.Button7.TabStop = False
        Me.Button7.UseVisualStyleBackColor = True
        '
        'CMD_Clientes
        '
        Me.CMD_Clientes.Image = Global.POS_Victors.My.Resources.Resources._60s
        Me.CMD_Clientes.Location = New System.Drawing.Point(543, 13)
        Me.CMD_Clientes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CMD_Clientes.Name = "CMD_Clientes"
        Me.CMD_Clientes.Size = New System.Drawing.Size(83, 83)
        Me.CMD_Clientes.TabIndex = 40
        Me.CMD_Clientes.TabStop = False
        Me.CMD_Clientes.Text = "Clientes"
        Me.CMD_Clientes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMD_Clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.CMD_Clientes.UseVisualStyleBackColor = True
        '
        'CMD_Reportes
        '
        Me.CMD_Reportes.Image = Global.POS_Victors.My.Resources.Resources.Barras
        Me.CMD_Reportes.Location = New System.Drawing.Point(98, 13)
        Me.CMD_Reportes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CMD_Reportes.Name = "CMD_Reportes"
        Me.CMD_Reportes.Size = New System.Drawing.Size(83, 83)
        Me.CMD_Reportes.TabIndex = 50
        Me.CMD_Reportes.TabStop = False
        Me.CMD_Reportes.Text = "Reportes"
        Me.CMD_Reportes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMD_Reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.CMD_Reportes.UseVisualStyleBackColor = True
        '
        'cmd_salir
        '
        Me.cmd_salir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmd_salir.Image = Global.POS_Victors.My.Resources.Resources.Apagado
        Me.cmd_salir.Location = New System.Drawing.Point(9, 13)
        Me.cmd_salir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(83, 83)
        Me.cmd_salir.TabIndex = 20
        Me.cmd_salir.TabStop = False
        Me.cmd_salir.Text = "Salir"
        Me.cmd_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'cb_tipo_pago
        '
        Me.cb_tipo_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tipo_pago.FormattingEnabled = True
        Me.cb_tipo_pago.Items.AddRange(New Object() {"Efectivo", "Tarjeta", "Credito"})
        Me.cb_tipo_pago.Location = New System.Drawing.Point(6, 17)
        Me.cb_tipo_pago.Name = "cb_tipo_pago"
        Me.cb_tipo_pago.Size = New System.Drawing.Size(121, 24)
        Me.cb_tipo_pago.TabIndex = 27
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cb_tipo_pago)
        Me.GroupBox2.Location = New System.Drawing.Point(374, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(130, 44)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo pago"
        '
        'gb_cliente
        '
        Me.gb_cliente.Controls.Add(Me.cb_cliente)
        Me.gb_cliente.Location = New System.Drawing.Point(510, 157)
        Me.gb_cliente.Name = "gb_cliente"
        Me.gb_cliente.Size = New System.Drawing.Size(130, 44)
        Me.gb_cliente.TabIndex = 7
        Me.gb_cliente.TabStop = False
        Me.gb_cliente.Text = "Cliente"
        Me.gb_cliente.Visible = False
        '
        'cb_cliente
        '
        Me.cb_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_cliente.FormattingEnabled = True
        Me.cb_cliente.Items.AddRange(New Object() {"DEBATE"})
        Me.cb_cliente.Location = New System.Drawing.Point(6, 17)
        Me.cb_cliente.Name = "cb_cliente"
        Me.cb_cliente.Size = New System.Drawing.Size(121, 24)
        Me.cb_cliente.TabIndex = 27
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_nombre)
        Me.GroupBox4.Location = New System.Drawing.Point(647, 157)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(145, 44)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Nombre"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(6, 17)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(133, 22)
        Me.txt_nombre.TabIndex = 0
        '
        'dgv_productos
        '
        Me.dgv_productos.AllowUserToAddRows = False
        Me.dgv_productos.AllowUserToDeleteRows = False
        Me.dgv_productos.AllowUserToOrderColumns = True
        Me.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_productos.Location = New System.Drawing.Point(753, 212)
        Me.dgv_productos.Name = "dgv_productos"
        Me.dgv_productos.ReadOnly = True
        Me.dgv_productos.Size = New System.Drawing.Size(446, 322)
        Me.dgv_productos.TabIndex = 77
        Me.dgv_productos.TabStop = False
        '
        'gb_dinero
        '
        Me.gb_dinero.Controls.Add(Me.txt_dinero)
        Me.gb_dinero.Location = New System.Drawing.Point(510, 157)
        Me.gb_dinero.Name = "gb_dinero"
        Me.gb_dinero.Size = New System.Drawing.Size(130, 44)
        Me.gb_dinero.TabIndex = 7
        Me.gb_dinero.TabStop = False
        Me.gb_dinero.Text = "Recibe"
        Me.gb_dinero.Visible = False
        '
        'txt_dinero
        '
        Me.txt_dinero.Location = New System.Drawing.Point(6, 16)
        Me.txt_dinero.Name = "txt_dinero"
        Me.txt_dinero.Size = New System.Drawing.Size(118, 22)
        Me.txt_dinero.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(626, 584)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 32)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "$"
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.SystemColors.Window
        Me.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.ForeColor = System.Drawing.Color.Red
        Me.txt_total.Location = New System.Drawing.Point(647, 584)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(100, 39)
        Me.txt_total.TabIndex = 79
        Me.txt_total.TabStop = False
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_recibe
        '
        Me.txt_recibe.BackColor = System.Drawing.SystemColors.Window
        Me.txt_recibe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_recibe.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_recibe.ForeColor = System.Drawing.Color.Red
        Me.txt_recibe.Location = New System.Drawing.Point(647, 539)
        Me.txt_recibe.Name = "txt_recibe"
        Me.txt_recibe.Size = New System.Drawing.Size(100, 39)
        Me.txt_recibe.TabIndex = 82
        Me.txt_recibe.TabStop = False
        Me.txt_recibe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(626, 539)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 32)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "$"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(533, 539)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 32)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Recibe:"
        '
        'txt_cambio
        '
        Me.txt_cambio.BackColor = System.Drawing.SystemColors.Window
        Me.txt_cambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cambio.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cambio.ForeColor = System.Drawing.Color.Red
        Me.txt_cambio.Location = New System.Drawing.Point(647, 629)
        Me.txt_cambio.Name = "txt_cambio"
        Me.txt_cambio.Size = New System.Drawing.Size(100, 39)
        Me.txt_cambio.TabIndex = 84
        Me.txt_cambio.TabStop = False
        Me.txt_cambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(517, 631)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 32)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Cambio: $"
        '
        'Frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 676)
        Me.Controls.Add(Me.txt_cambio)
        Me.Controls.Add(Me.gb_dinero)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_recibe)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv_productos)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gb_cliente)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CMD_Utencilios)
        Me.Controls.Add(Me.CMD_Empleados)
        Me.Controls.Add(Me.CMD_Usuarios)
        Me.Controls.Add(Me.CMD_Proveedor)
        Me.Controls.Add(Me.CMD_Productos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_cancelar_venta)
        Me.Controls.Add(Me.cmd_terminar_venta)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv_tickets)
        Me.Controls.Add(Me.CMD_Clientes)
        Me.Controls.Add(Me.CMD_Reportes)
        Me.Controls.Add(Me.cmd_salir)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Frm_menu"
        Me.Text = "frm_menu"
        CType(Me.dgv_tickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.numeric_cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.gb_cliente.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgv_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_dinero.ResumeLayout(False)
        Me.gb_dinero.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents CMD_Reportes As System.Windows.Forms.Button
    Friend WithEvents CMD_Clientes As System.Windows.Forms.Button
    Friend WithEvents dgv_tickets As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_clave As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents cmd_terminar_venta As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar_venta As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CMD_Empleados As System.Windows.Forms.Button
    Friend WithEvents CMD_Usuarios As System.Windows.Forms.Button
    Friend WithEvents CMD_Proveedor As System.Windows.Forms.Button
    Friend WithEvents CMD_Productos As System.Windows.Forms.Button
    Friend WithEvents CMD_Utencilios As System.Windows.Forms.Button
    Friend WithEvents numeric_cantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents cb_tipo_pago As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents gb_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents cb_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents cb_servicio As System.Windows.Forms.ComboBox
    Friend WithEvents clmn_clave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmn_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmn_precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmn_cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmn_importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents dgv_productos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents gb_dinero As System.Windows.Forms.GroupBox
    Friend WithEvents txt_dinero As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents txt_recibe As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_cambio As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
