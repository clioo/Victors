<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Efectivo
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
        Me.LB_Ticket = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_Recibido = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LB_Ticket
        '
        Me.LB_Ticket.FormattingEnabled = True
        Me.LB_Ticket.ItemHeight = 20
        Me.LB_Ticket.Location = New System.Drawing.Point(12, 106)
        Me.LB_Ticket.Name = "LB_Ticket"
        Me.LB_Ticket.Size = New System.Drawing.Size(261, 284)
        Me.LB_Ticket.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cantidad recibida:"
        '
        'TXT_Recibido
        '
        Me.TXT_Recibido.Location = New System.Drawing.Point(150, 16)
        Me.TXT_Recibido.Name = "TXT_Recibido"
        Me.TXT_Recibido.Size = New System.Drawing.Size(107, 26)
        Me.TXT_Recibido.TabIndex = 5
        '
        'FRM_Efectivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 402)
        Me.Controls.Add(Me.TXT_Recibido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LB_Ticket)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FRM_Efectivo"
        Me.Text = "FRM_Efectivo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LB_Ticket As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_Recibido As System.Windows.Forms.TextBox
End Class
