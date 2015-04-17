<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditarProducto2
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdescripcionEditada = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpfechaModificacion = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.txtdetalle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Descripcion"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescripcion.Location = New System.Drawing.Point(141, 76)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdescripcion.Size = New System.Drawing.Size(172, 39)
        Me.txtdescripcion.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Descripcion"
        '
        'txtdescripcionEditada
        '
        Me.txtdescripcionEditada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescripcionEditada.Location = New System.Drawing.Point(141, 175)
        Me.txtdescripcionEditada.Multiline = True
        Me.txtdescripcionEditada.Name = "txtdescripcionEditada"
        Me.txtdescripcionEditada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdescripcionEditada.Size = New System.Drawing.Size(172, 39)
        Me.txtdescripcionEditada.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(183, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 26)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Actual "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(183, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 26)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Nuevo"
        '
        'dtpfechaModificacion
        '
        Me.dtpfechaModificacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaModificacion.Location = New System.Drawing.Point(141, 3)
        Me.dtpfechaModificacion.Name = "dtpfechaModificacion"
        Me.dtpfechaModificacion.Size = New System.Drawing.Size(172, 20)
        Me.dtpfechaModificacion.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Fecha de Modificacion"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(89, 237)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 58)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 411)
        Me.Splitter1.TabIndex = 25
        Me.Splitter1.TabStop = False
        '
        'txtdetalle
        '
        Me.txtdetalle.Location = New System.Drawing.Point(333, 129)
        Me.txtdetalle.Multiline = True
        Me.txtdetalle.Name = "txtdetalle"
        Me.txtdetalle.Size = New System.Drawing.Size(235, 189)
        Me.txtdetalle.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(347, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 26)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Detalle"
        '
        'FrmEditarProducto2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 411)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtdetalle)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtpfechaModificacion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdescripcionEditada)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Name = "FrmEditarProducto2"
        Me.Text = "FrmEditarProducto2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcionEditada As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaModificacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents txtdetalle As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
