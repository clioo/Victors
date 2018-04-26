<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Ticket
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LB_Ticket = New System.Windows.Forms.ListBox()
        Me.CMD_Pagar = New System.Windows.Forms.Button()
        Me.CB_Pago = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pagar con:"
        '
        'LB_Ticket
        '
        Me.LB_Ticket.FormattingEnabled = True
        Me.LB_Ticket.ItemHeight = 20
        Me.LB_Ticket.Location = New System.Drawing.Point(17, 47)
        Me.LB_Ticket.Name = "LB_Ticket"
        Me.LB_Ticket.Size = New System.Drawing.Size(261, 284)
        Me.LB_Ticket.TabIndex = 2
        '
        'CMD_Pagar
        '
        Me.CMD_Pagar.Location = New System.Drawing.Point(204, 6)
        Me.CMD_Pagar.Name = "CMD_Pagar"
        Me.CMD_Pagar.Size = New System.Drawing.Size(74, 28)
        Me.CMD_Pagar.TabIndex = 3
        Me.CMD_Pagar.Text = "Aceptar"
        Me.CMD_Pagar.UseVisualStyleBackColor = True
        '
        'CB_Pago
        '
        Me.CB_Pago.FormattingEnabled = True
        Me.CB_Pago.Items.AddRange(New Object() {"Efectivo", "Tarjeta", "Crédito"})
        Me.CB_Pago.Location = New System.Drawing.Point(105, 6)
        Me.CB_Pago.Name = "CB_Pago"
        Me.CB_Pago.Size = New System.Drawing.Size(93, 28)
        Me.CB_Pago.TabIndex = 4
        Me.CB_Pago.Text = "Efectivo"
        '
        'FRM_Ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 353)
        Me.Controls.Add(Me.CB_Pago)
        Me.Controls.Add(Me.CMD_Pagar)
        Me.Controls.Add(Me.LB_Ticket)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FRM_Ticket"
        Me.Text = "TICKET"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LB_Ticket As System.Windows.Forms.ListBox
    Friend WithEvents CMD_Pagar As System.Windows.Forms.Button
    Friend WithEvents CB_Pago As System.Windows.Forms.ComboBox
End Class
