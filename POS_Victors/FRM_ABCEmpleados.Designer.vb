<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ABCEmpleados
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
        Me.CMD_Salir = New System.Windows.Forms.Button()
        Me.CMD_Eliminar = New System.Windows.Forms.Button()
        Me.CMD_Modificar = New System.Windows.Forms.Button()
        Me.CMD_Agregar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmn_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmn_ap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmn_am = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmn_direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmn_tel1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmn_tel2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmn_sueldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmn_NSS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmn_curp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CMD_Salir
        '
        Me.CMD_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_Salir.Location = New System.Drawing.Point(708, 416)
        Me.CMD_Salir.Name = "CMD_Salir"
        Me.CMD_Salir.Size = New System.Drawing.Size(146, 78)
        Me.CMD_Salir.TabIndex = 12
        Me.CMD_Salir.Text = "Regresar"
        Me.CMD_Salir.UseVisualStyleBackColor = True
        '
        'CMD_Eliminar
        '
        Me.CMD_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_Eliminar.Location = New System.Drawing.Point(319, 416)
        Me.CMD_Eliminar.Name = "CMD_Eliminar"
        Me.CMD_Eliminar.Size = New System.Drawing.Size(146, 78)
        Me.CMD_Eliminar.TabIndex = 11
        Me.CMD_Eliminar.Text = "Eliminar empleado"
        Me.CMD_Eliminar.UseVisualStyleBackColor = True
        '
        'CMD_Modificar
        '
        Me.CMD_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_Modificar.Location = New System.Drawing.Point(167, 416)
        Me.CMD_Modificar.Name = "CMD_Modificar"
        Me.CMD_Modificar.Size = New System.Drawing.Size(146, 78)
        Me.CMD_Modificar.TabIndex = 10
        Me.CMD_Modificar.Text = "Modificar empleado"
        Me.CMD_Modificar.UseVisualStyleBackColor = True
        '
        'CMD_Agregar
        '
        Me.CMD_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_Agregar.Location = New System.Drawing.Point(15, 416)
        Me.CMD_Agregar.Name = "CMD_Agregar"
        Me.CMD_Agregar.Size = New System.Drawing.Size(146, 78)
        Me.CMD_Agregar.TabIndex = 9
        Me.CMD_Agregar.Text = "Agregar empleado"
        Me.CMD_Agregar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Clave, Me.clmn_nombre, Me.clmn_ap, Me.clmn_am, Me.clmn_direccion, Me.clmn_tel1, Me.clmn_tel2, Me.clmn_sueldo, Me.clmn_NSS, Me.clmn_curp})
        Me.DataGridView1.Location = New System.Drawing.Point(15, 15)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1043, 395)
        Me.DataGridView1.TabIndex = 8
        '
        'Clave
        '
        Me.Clave.HeaderText = "Clave"
        Me.Clave.Name = "Clave"
        Me.Clave.ReadOnly = True
        '
        'clmn_nombre
        '
        Me.clmn_nombre.HeaderText = "Nombre"
        Me.clmn_nombre.Name = "clmn_nombre"
        Me.clmn_nombre.ReadOnly = True
        '
        'clmn_ap
        '
        Me.clmn_ap.HeaderText = "Apellido paterno"
        Me.clmn_ap.Name = "clmn_ap"
        Me.clmn_ap.ReadOnly = True
        '
        'clmn_am
        '
        Me.clmn_am.HeaderText = "Apellido materno"
        Me.clmn_am.Name = "clmn_am"
        Me.clmn_am.ReadOnly = True
        '
        'clmn_direccion
        '
        Me.clmn_direccion.HeaderText = "Dirección"
        Me.clmn_direccion.Name = "clmn_direccion"
        Me.clmn_direccion.ReadOnly = True
        '
        'clmn_tel1
        '
        Me.clmn_tel1.HeaderText = "Teléfono local"
        Me.clmn_tel1.Name = "clmn_tel1"
        Me.clmn_tel1.ReadOnly = True
        '
        'clmn_tel2
        '
        Me.clmn_tel2.HeaderText = "Teléfono celular"
        Me.clmn_tel2.Name = "clmn_tel2"
        Me.clmn_tel2.ReadOnly = True
        '
        'clmn_sueldo
        '
        Me.clmn_sueldo.HeaderText = "Sueldo"
        Me.clmn_sueldo.Name = "clmn_sueldo"
        Me.clmn_sueldo.ReadOnly = True
        '
        'clmn_NSS
        '
        Me.clmn_NSS.HeaderText = "NSS"
        Me.clmn_NSS.Name = "clmn_NSS"
        Me.clmn_NSS.ReadOnly = True
        '
        'clmn_curp
        '
        Me.clmn_curp.HeaderText = "Curp"
        Me.clmn_curp.Name = "clmn_curp"
        Me.clmn_curp.ReadOnly = True
        '
        'FRM_ABCEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 509)
        Me.Controls.Add(Me.CMD_Salir)
        Me.Controls.Add(Me.CMD_Eliminar)
        Me.Controls.Add(Me.CMD_Modificar)
        Me.Controls.Add(Me.CMD_Agregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FRM_ABCEmpleados"
        Me.Text = "ABC de Empleados"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMD_Salir As System.Windows.Forms.Button
    Friend WithEvents CMD_Eliminar As System.Windows.Forms.Button
    Friend WithEvents CMD_Modificar As System.Windows.Forms.Button
    Friend WithEvents CMD_Agregar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Clave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmn_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmn_ap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmn_am As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmn_direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmn_tel1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmn_tel2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmn_sueldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmn_NSS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmn_curp As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
