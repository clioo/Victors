<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_AgregarProducto
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
        Me.txt_CANTIDAD = New System.Windows.Forms.TextBox()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMD_Cancelar = New System.Windows.Forms.Button()
        Me.CMD_Acaptar = New System.Windows.Forms.Button()
        Me.txt_precioC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_PrecioV = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_CANTIDAD
        '
        Me.txt_CANTIDAD.Location = New System.Drawing.Point(104, 122)
        Me.txt_CANTIDAD.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_CANTIDAD.Name = "txt_CANTIDAD"
        Me.txt_CANTIDAD.Size = New System.Drawing.Size(228, 26)
        Me.txt_CANTIDAD.TabIndex = 18
        '
        'txt_producto
        '
        Me.txt_producto.Location = New System.Drawing.Point(126, 80)
        Me.txt_producto.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.Size = New System.Drawing.Size(206, 26)
        Me.txt_producto.TabIndex = 17
        '
        'txt_clave
        '
        Me.txt_clave.Location = New System.Drawing.Point(82, 38)
        Me.txt_clave.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(250, 26)
        Me.txt_clave.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 125)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Cantidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Clave:"
        '
        'CMD_Cancelar
        '
        Me.CMD_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_Cancelar.Location = New System.Drawing.Point(182, 240)
        Me.CMD_Cancelar.Name = "CMD_Cancelar"
        Me.CMD_Cancelar.Size = New System.Drawing.Size(145, 106)
        Me.CMD_Cancelar.TabIndex = 21
        Me.CMD_Cancelar.Text = "Cancelar"
        Me.CMD_Cancelar.UseVisualStyleBackColor = True
        '
        'CMD_Acaptar
        '
        Me.CMD_Acaptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_Acaptar.Location = New System.Drawing.Point(22, 240)
        Me.CMD_Acaptar.Name = "CMD_Acaptar"
        Me.CMD_Acaptar.Size = New System.Drawing.Size(145, 106)
        Me.CMD_Acaptar.TabIndex = 20
        Me.CMD_Acaptar.Text = "Aceptar"
        Me.CMD_Acaptar.UseVisualStyleBackColor = True
        '
        'txt_precioC
        '
        Me.txt_precioC.Location = New System.Drawing.Point(147, 164)
        Me.txt_precioC.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_precioC.Name = "txt_precioC"
        Me.txt_precioC.Size = New System.Drawing.Size(185, 26)
        Me.txt_precioC.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 167)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Precio Compra:"
        '
        'TXT_PrecioV
        '
        Me.TXT_PrecioV.Location = New System.Drawing.Point(126, 203)
        Me.TXT_PrecioV.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.TXT_PrecioV.Name = "TXT_PrecioV"
        Me.TXT_PrecioV.Size = New System.Drawing.Size(206, 26)
        Me.TXT_PrecioV.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 206)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Precio Venta:"
        '
        'Button12
        '
        Me.Button12.Image = Global.POS_Victors.My.Resources.Resources.Teclado2
        Me.Button12.Location = New System.Drawing.Point(326, 1)
        Me.Button12.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(33, 37)
        Me.Button12.TabIndex = 26
        Me.Button12.Text = " "
        Me.Button12.UseVisualStyleBackColor = True
        '
        'FRM_AgregarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 363)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.TXT_PrecioV)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_precioC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CMD_Cancelar)
        Me.Controls.Add(Me.CMD_Acaptar)
        Me.Controls.Add(Me.txt_CANTIDAD)
        Me.Controls.Add(Me.txt_producto)
        Me.Controls.Add(Me.txt_clave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FRM_AgregarProducto"
        Me.Text = "FRM_AgregarProducto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_CANTIDAD As System.Windows.Forms.TextBox
    Friend WithEvents txt_producto As System.Windows.Forms.TextBox
    Friend WithEvents txt_clave As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CMD_Cancelar As System.Windows.Forms.Button
    Friend WithEvents CMD_Acaptar As System.Windows.Forms.Button
    Friend WithEvents txt_precioC As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXT_PrecioV As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button12 As System.Windows.Forms.Button
End Class
