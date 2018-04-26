<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ABCUsuarios
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_USER = New System.Windows.Forms.TextBox()
        Me.TXT_Password = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CMD_Agregar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CMD_Modificar = New System.Windows.Forms.Button()
        Me.TXT_Password2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_User2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RB_Activo = New System.Windows.Forms.RadioButton()
        Me.RB_Inactivo = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CMD_Agregar)
        Me.GroupBox1.Controls.Add(Me.TXT_Password)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXT_USER)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 155)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'TXT_USER
        '
        Me.TXT_USER.Location = New System.Drawing.Point(110, 31)
        Me.TXT_USER.Name = "TXT_USER"
        Me.TXT_USER.Size = New System.Drawing.Size(136, 26)
        Me.TXT_USER.TabIndex = 1
        '
        'TXT_Password
        '
        Me.TXT_Password.Location = New System.Drawing.Point(110, 63)
        Me.TXT_Password.Name = "TXT_Password"
        Me.TXT_Password.Size = New System.Drawing.Size(136, 26)
        Me.TXT_Password.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'CMD_Agregar
        '
        Me.CMD_Agregar.Location = New System.Drawing.Point(110, 112)
        Me.CMD_Agregar.Name = "CMD_Agregar"
        Me.CMD_Agregar.Size = New System.Drawing.Size(135, 33)
        Me.CMD_Agregar.TabIndex = 4
        Me.CMD_Agregar.Text = "Agregar"
        Me.CMD_Agregar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RB_Inactivo)
        Me.GroupBox2.Controls.Add(Me.RB_Activo)
        Me.GroupBox2.Controls.Add(Me.CMD_Modificar)
        Me.GroupBox2.Controls.Add(Me.TXT_Password2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TXT_User2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(293, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(263, 155)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Modificar"
        '
        'CMD_Modificar
        '
        Me.CMD_Modificar.Location = New System.Drawing.Point(110, 112)
        Me.CMD_Modificar.Name = "CMD_Modificar"
        Me.CMD_Modificar.Size = New System.Drawing.Size(135, 33)
        Me.CMD_Modificar.TabIndex = 4
        Me.CMD_Modificar.Text = "Guardar"
        Me.CMD_Modificar.UseVisualStyleBackColor = True
        '
        'TXT_Password2
        '
        Me.TXT_Password2.Location = New System.Drawing.Point(110, 80)
        Me.TXT_Password2.Name = "TXT_Password2"
        Me.TXT_Password2.Size = New System.Drawing.Size(136, 26)
        Me.TXT_Password2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 40)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nueva" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "password:"
        '
        'TXT_User2
        '
        Me.TXT_User2.Location = New System.Drawing.Point(110, 31)
        Me.TXT_User2.Name = "TXT_User2"
        Me.TXT_User2.Size = New System.Drawing.Size(136, 26)
        Me.TXT_User2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Usuario:"
        '
        'RB_Activo
        '
        Me.RB_Activo.AutoSize = True
        Me.RB_Activo.Checked = True
        Me.RB_Activo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Activo.Location = New System.Drawing.Point(26, 109)
        Me.RB_Activo.Name = "RB_Activo"
        Me.RB_Activo.Size = New System.Drawing.Size(63, 20)
        Me.RB_Activo.TabIndex = 5
        Me.RB_Activo.Text = "Activo"
        Me.RB_Activo.UseVisualStyleBackColor = True
        '
        'RB_Inactivo
        '
        Me.RB_Inactivo.AutoSize = True
        Me.RB_Inactivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Inactivo.Location = New System.Drawing.Point(26, 130)
        Me.RB_Inactivo.Name = "RB_Inactivo"
        Me.RB_Inactivo.Size = New System.Drawing.Size(72, 20)
        Me.RB_Inactivo.TabIndex = 6
        Me.RB_Inactivo.Text = "Inactivo"
        Me.RB_Inactivo.UseVisualStyleBackColor = True
        '
        'FRM_ABCUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 252)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FRM_ABCUsuarios"
        Me.Text = "ABC Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CMD_Agregar As System.Windows.Forms.Button
    Friend WithEvents TXT_Password As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_USER As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Inactivo As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Activo As System.Windows.Forms.RadioButton
    Friend WithEvents CMD_Modificar As System.Windows.Forms.Button
    Friend WithEvents TXT_Password2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXT_User2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
