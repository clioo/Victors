<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MasterPassword
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
        Me.TXT_contraseña = New System.Windows.Forms.TextBox()
        Me.CMD_ACEPTAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TXT_contraseña
        '
        Me.TXT_contraseña.Location = New System.Drawing.Point(56, 49)
        Me.TXT_contraseña.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXT_contraseña.Name = "TXT_contraseña"
        Me.TXT_contraseña.Size = New System.Drawing.Size(292, 26)
        Me.TXT_contraseña.TabIndex = 3
        '
        'CMD_ACEPTAR
        '
        Me.CMD_ACEPTAR.Location = New System.Drawing.Point(356, 36)
        Me.CMD_ACEPTAR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CMD_ACEPTAR.Name = "CMD_ACEPTAR"
        Me.CMD_ACEPTAR.Size = New System.Drawing.Size(184, 53)
        Me.CMD_ACEPTAR.TabIndex = 2
        Me.CMD_ACEPTAR.Text = "Aceptar"
        Me.CMD_ACEPTAR.UseVisualStyleBackColor = True
        '
        'FRM_MasterPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 143)
        Me.Controls.Add(Me.TXT_contraseña)
        Me.Controls.Add(Me.CMD_ACEPTAR)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FRM_MasterPassword"
        Me.Text = "Contraseña Maestra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_contraseña As System.Windows.Forms.TextBox
    Friend WithEvents CMD_ACEPTAR As System.Windows.Forms.Button
End Class
