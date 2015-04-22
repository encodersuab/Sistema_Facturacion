<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarProducto2CAMPOFERIAL
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
        Me.gbimagen = New System.Windows.Forms.GroupBox()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.btnlimpiar = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btncargar = New System.Windows.Forms.PictureBox()
        Me.gbFechaVencimiento = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpfecha_vencimientoNueva = New System.Windows.Forms.DateTimePicker()
        Me.dtpfecha_vencimientoActual = New System.Windows.Forms.DateTimePicker()
        Me.gbdetalle = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtdescripcionEditada = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.lbnombreproducto = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdetalle = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpfechaModificacion = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gbimagen.SuspendLayout()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncargar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFechaVencimiento.SuspendLayout()
        Me.gbdetalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbimagen
        '
        Me.gbimagen.Controls.Add(Me.imagen)
        Me.gbimagen.Controls.Add(Me.btnlimpiar)
        Me.gbimagen.Controls.Add(Me.Label9)
        Me.gbimagen.Controls.Add(Me.btncargar)
        Me.gbimagen.Location = New System.Drawing.Point(11, 94)
        Me.gbimagen.Name = "gbimagen"
        Me.gbimagen.Size = New System.Drawing.Size(311, 205)
        Me.gbimagen.TabIndex = 32
        Me.gbimagen.TabStop = False
        Me.gbimagen.Text = "imagen"
        '
        'imagen
        '
        Me.imagen.BackgroundImage = Global.Sistema_Facturacion.My.Resources.Resources.fondo_transparente_fotos
        Me.imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imagen.Image = Global.Sistema_Facturacion.My.Resources.Resources.fondo_transparente_fotos
        Me.imagen.Location = New System.Drawing.Point(69, 33)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(171, 133)
        Me.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagen.TabIndex = 31
        Me.imagen.TabStop = False
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackgroundImage = Global.Sistema_Facturacion.My.Resources.Resources.descarga__1_
        Me.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlimpiar.Location = New System.Drawing.Point(246, 108)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(45, 48)
        Me.btnlimpiar.TabIndex = 33
        Me.btnlimpiar.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Imagen"
        '
        'btncargar
        '
        Me.btncargar.BackgroundImage = Global.Sistema_Facturacion.My.Resources.Resources.descarga__3_
        Me.btncargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncargar.Location = New System.Drawing.Point(246, 54)
        Me.btncargar.Name = "btncargar"
        Me.btncargar.Size = New System.Drawing.Size(45, 48)
        Me.btncargar.TabIndex = 32
        Me.btncargar.TabStop = False
        '
        'gbFechaVencimiento
        '
        Me.gbFechaVencimiento.Controls.Add(Me.Label7)
        Me.gbFechaVencimiento.Controls.Add(Me.Label6)
        Me.gbFechaVencimiento.Controls.Add(Me.dtpfecha_vencimientoNueva)
        Me.gbFechaVencimiento.Controls.Add(Me.dtpfecha_vencimientoActual)
        Me.gbFechaVencimiento.Location = New System.Drawing.Point(11, 113)
        Me.gbFechaVencimiento.Name = "gbFechaVencimiento"
        Me.gbFechaVencimiento.Size = New System.Drawing.Size(311, 205)
        Me.gbFechaVencimiento.TabIndex = 31
        Me.gbFechaVencimiento.TabStop = False
        Me.gbFechaVencimiento.Text = "Modificacion Fecha Vencimiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(66, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Fecha de Vencimiento  Nueva"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(66, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Fecha de Vencimiento Actual"
        '
        'dtpfecha_vencimientoNueva
        '
        Me.dtpfecha_vencimientoNueva.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_vencimientoNueva.Location = New System.Drawing.Point(69, 125)
        Me.dtpfecha_vencimientoNueva.Name = "dtpfecha_vencimientoNueva"
        Me.dtpfecha_vencimientoNueva.Size = New System.Drawing.Size(171, 20)
        Me.dtpfecha_vencimientoNueva.TabIndex = 23
        '
        'dtpfecha_vencimientoActual
        '
        Me.dtpfecha_vencimientoActual.Enabled = False
        Me.dtpfecha_vencimientoActual.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_vencimientoActual.Location = New System.Drawing.Point(69, 65)
        Me.dtpfecha_vencimientoActual.Name = "dtpfecha_vencimientoActual"
        Me.dtpfecha_vencimientoActual.Size = New System.Drawing.Size(171, 20)
        Me.dtpfecha_vencimientoActual.TabIndex = 22
        '
        'gbdetalle
        '
        Me.gbdetalle.Controls.Add(Me.Label3)
        Me.gbdetalle.Controls.Add(Me.txtdescripcion)
        Me.gbdetalle.Controls.Add(Me.txtdescripcionEditada)
        Me.gbdetalle.Controls.Add(Me.Label1)
        Me.gbdetalle.Controls.Add(Me.Label2)
        Me.gbdetalle.Controls.Add(Me.Label4)
        Me.gbdetalle.Location = New System.Drawing.Point(11, 137)
        Me.gbdetalle.Name = "gbdetalle"
        Me.gbdetalle.Size = New System.Drawing.Size(311, 202)
        Me.gbdetalle.TabIndex = 30
        Me.gbdetalle.TabStop = False
        Me.gbdetalle.Text = "Detalle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Descripcion"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescripcion.Enabled = False
        Me.txtdescripcion.Location = New System.Drawing.Point(113, 42)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdescripcion.Size = New System.Drawing.Size(172, 39)
        Me.txtdescripcion.TabIndex = 6
        '
        'txtdescripcionEditada
        '
        Me.txtdescripcionEditada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescripcionEditada.Location = New System.Drawing.Point(113, 142)
        Me.txtdescripcionEditada.Multiline = True
        Me.txtdescripcionEditada.Name = "txtdescripcionEditada"
        Me.txtdescripcionEditada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdescripcionEditada.Size = New System.Drawing.Size(172, 39)
        Me.txtdescripcionEditada.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(155, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 26)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Actual "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(155, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 26)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Nuevo"
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(48, 0)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(45, 20)
        Me.txtflag.TabIndex = 39
        '
        'lbnombreproducto
        '
        Me.lbnombreproducto.AutoSize = True
        Me.lbnombreproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbnombreproducto.Location = New System.Drawing.Point(177, 9)
        Me.lbnombreproducto.Name = "lbnombreproducto"
        Me.lbnombreproducto.Size = New System.Drawing.Size(114, 38)
        Me.lbnombreproducto.TabIndex = 38
        Me.lbnombreproducto.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(369, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 26)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Detalle"
        '
        'txtdetalle
        '
        Me.txtdetalle.Location = New System.Drawing.Point(356, 152)
        Me.txtdetalle.Multiline = True
        Me.txtdetalle.Name = "txtdetalle"
        Me.txtdetalle.Size = New System.Drawing.Size(194, 104)
        Me.txtdetalle.TabIndex = 37
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(383, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 58)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpfechaModificacion
        '
        Me.dtpfechaModificacion.Enabled = False
        Me.dtpfechaModificacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaModificacion.Location = New System.Drawing.Point(137, 68)
        Me.dtpfechaModificacion.Name = "dtpfechaModificacion"
        Me.dtpfechaModificacion.Size = New System.Drawing.Size(172, 20)
        Me.dtpfechaModificacion.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Fecha de Modificacion"
        '
        'frmEditarProducto2CAMPOFERIAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 350)
        Me.Controls.Add(Me.gbimagen)
        Me.Controls.Add(Me.gbFechaVencimiento)
        Me.Controls.Add(Me.gbdetalle)
        Me.Controls.Add(Me.txtflag)
        Me.Controls.Add(Me.lbnombreproducto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtdetalle)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtpfechaModificacion)
        Me.Controls.Add(Me.Label8)
        Me.Name = "frmEditarProducto2CAMPOFERIAL"
        Me.Text = "frmEditarProducto2CAMPOFERIAL"
        Me.gbimagen.ResumeLayout(False)
        Me.gbimagen.PerformLayout()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncargar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFechaVencimiento.ResumeLayout(False)
        Me.gbFechaVencimiento.PerformLayout()
        Me.gbdetalle.ResumeLayout(False)
        Me.gbdetalle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbimagen As System.Windows.Forms.GroupBox
    Friend WithEvents imagen As System.Windows.Forms.PictureBox
    Friend WithEvents btnlimpiar As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btncargar As System.Windows.Forms.PictureBox
    Friend WithEvents gbFechaVencimiento As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha_vencimientoNueva As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfecha_vencimientoActual As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbdetalle As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcionEditada As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtflag As System.Windows.Forms.TextBox
    Friend WithEvents lbnombreproducto As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtdetalle As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtpfechaModificacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
