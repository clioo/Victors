<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_EliminarEmpleado
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
        Me.CMD_Cancelar = New System.Windows.Forms.Button()
        Me.CMD_Acaptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_Numemp = New System.Windows.Forms.TextBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CMD_Cancelar
        '
        Me.CMD_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_Cancelar.Location = New System.Drawing.Point(315, 102)
        Me.CMD_Cancelar.Name = "CMD_Cancelar"
        Me.CMD_Cancelar.Size = New System.Drawing.Size(271, 125)
        Me.CMD_Cancelar.TabIndex = 26
        Me.CMD_Cancelar.Text = "Cancelar"
        Me.CMD_Cancelar.UseVisualStyleBackColor = True
        '
        'CMD_Acaptar
        '
        Me.CMD_Acaptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_Acaptar.Location = New System.Drawing.Point(26, 102)
        Me.CMD_Acaptar.Name = "CMD_Acaptar"
        Me.CMD_Acaptar.Size = New System.Drawing.Size(277, 125)
        Me.CMD_Acaptar.TabIndex = 25
        Me.CMD_Acaptar.Text = "Guardar cambios"
        Me.CMD_Acaptar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_Numemp)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 62)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "* Número de empleado"
        '
        'txt_Numemp
        '
        Me.txt_Numemp.Location = New System.Drawing.Point(6, 27)
        Me.txt_Numemp.Name = "txt_Numemp"
        Me.txt_Numemp.Size = New System.Drawing.Size(265, 29)
        Me.txt_Numemp.TabIndex = 0
        '
        'Button12
        '
        Me.Button12.Image = Global.POS_Victors.My.Resources.Resources.Teclado2
        Me.Button12.Location = New System.Drawing.Point(582, 2)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(30, 30)
        Me.Button12.TabIndex = 27
        Me.Button12.Text = " "
        Me.Button12.UseVisualStyleBackColor = True
        '
        'FRM_EliminarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 273)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.CMD_Cancelar)
        Me.Controls.Add(Me.CMD_Acaptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FRM_EliminarEmpleado"
        Me.Text = "Eliminar empleado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMD_Cancelar As System.Windows.Forms.Button
    Friend WithEvents CMD_Acaptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Numemp As System.Windows.Forms.TextBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
End Class
