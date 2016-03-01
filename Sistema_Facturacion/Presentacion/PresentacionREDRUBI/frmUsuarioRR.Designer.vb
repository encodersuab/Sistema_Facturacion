<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarioRR
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
        Me.components = New System.ComponentModel.Container()
        Me.idusuario = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtContraceña = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'idusuario
        '
        Me.idusuario.AutoSize = True
        Me.idusuario.Location = New System.Drawing.Point(295, 2)
        Me.idusuario.Name = "idusuario"
        Me.idusuario.Size = New System.Drawing.Size(39, 13)
        Me.idusuario.TabIndex = 5
        Me.idusuario.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtContraceña)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtLogin)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 203)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(179, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "NUEVA CONTRASEÑA"
        '
        'txtContraceña
        '
        Me.txtContraceña.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContraceña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraceña.Location = New System.Drawing.Point(196, 88)
        Me.txtContraceña.Name = "txtContraceña"
        Me.txtContraceña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraceña.Size = New System.Drawing.Size(214, 26)
        Me.txtContraceña.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "NUEVO USUARIO"
        '
        'txtLogin
        '
        Me.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.Location = New System.Drawing.Point(196, 62)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(214, 26)
        Me.txtLogin.TabIndex = 16
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(156, 145)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(67, 26)
        Me.btnEditar.TabIndex = 14
        Me.btnEditar.Text = "CAMBIAR"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(241, 145)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(67, 26)
        Me.btncancelar.TabIndex = 13
        Me.btncancelar.Text = "SALIR"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'frmUsuarioRR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 225)
        Me.Controls.Add(Me.idusuario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmUsuarioRR"
        Me.Text = "CAMBIO DE USUARIO Y CONTRASEÑA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents idusuario As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtContraceña As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
End Class
