<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmeditarproducto
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
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cbbmodulo = New System.Windows.Forms.Label()
        Me.txtmedida = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnlimpiar = New System.Windows.Forms.PictureBox()
        Me.btncargar = New System.Windows.Forms.PictureBox()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtfecha_vencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnom_categoria = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtidcategoria = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtprecio_venta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtprecio_compra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdproducto = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button12)
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.cbbmodulo)
        Me.GroupBox1.Controls.Add(Me.txtmedida)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnlimpiar)
        Me.GroupBox1.Controls.Add(Me.btncargar)
        Me.GroupBox1.Controls.Add(Me.imagen)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtfecha_vencimiento)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtnom_categoria)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtidcategoria)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtprecio_venta)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtprecio_compra)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtstock)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtIdproducto)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(803, 499)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(413, 82)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 20)
        Me.Button12.TabIndex = 42
        Me.Button12.Text = "Editar"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(413, 108)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 39)
        Me.Button11.TabIndex = 41
        Me.Button11.Text = "Editar"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(413, 153)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 20)
        Me.Button10.TabIndex = 40
        Me.Button10.Text = "Editar"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(413, 179)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 20)
        Me.Button9.TabIndex = 39
        Me.Button9.Text = "Editar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(413, 230)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 20)
        Me.Button8.TabIndex = 38
        Me.Button8.Text = "Editar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(414, 284)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 21)
        Me.Button7.TabIndex = 37
        Me.Button7.Text = "Editar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(414, 312)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 123)
        Me.Button6.TabIndex = 36
        Me.Button6.Text = "Editar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(413, 205)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 20)
        Me.Button5.TabIndex = 35
        Me.Button5.Text = "Editar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(413, 52)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 20)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Editar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(414, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 20)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Editar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cbbmodulo
        '
        Me.cbbmodulo.AutoSize = True
        Me.cbbmodulo.Location = New System.Drawing.Point(151, 260)
        Me.cbbmodulo.Name = "cbbmodulo"
        Me.cbbmodulo.Size = New System.Drawing.Size(72, 13)
        Me.cbbmodulo.TabIndex = 30
        Me.cbbmodulo.Text = "EMFOPESBE"
        '
        'txtmedida
        '
        Me.txtmedida.FormattingEnabled = True
        Me.txtmedida.Items.AddRange(New Object() {"UNIDAD", "KILOS"})
        Me.txtmedida.Location = New System.Drawing.Point(154, 284)
        Me.txtmedida.Name = "txtmedida"
        Me.txtmedida.Size = New System.Drawing.Size(107, 21)
        Me.txtmedida.TabIndex = 29
        Me.txtmedida.Text = "UNIDAD"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(95, 287)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Medida"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(95, 260)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Modulo"
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackgroundImage = Global.Sistema_Facturacion.My.Resources.Resources.descarga__1_
        Me.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlimpiar.Location = New System.Drawing.Point(331, 387)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(45, 48)
        Me.btnlimpiar.TabIndex = 25
        Me.btnlimpiar.TabStop = False
        '
        'btncargar
        '
        Me.btncargar.BackgroundImage = Global.Sistema_Facturacion.My.Resources.Resources.descarga__3_
        Me.btncargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncargar.Location = New System.Drawing.Point(331, 333)
        Me.btncargar.Name = "btncargar"
        Me.btncargar.Size = New System.Drawing.Size(45, 48)
        Me.btncargar.TabIndex = 24
        Me.btncargar.TabStop = False
        '
        'imagen
        '
        Me.imagen.BackgroundImage = Global.Sistema_Facturacion.My.Resources.Resources.fondo_transparente_fotos
        Me.imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imagen.Image = Global.Sistema_Facturacion.My.Resources.Resources.fondo_transparente_fotos
        Me.imagen.Location = New System.Drawing.Point(154, 312)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(171, 133)
        Me.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagen.TabIndex = 23
        Me.imagen.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(95, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Imagen"
        '
        'txtfecha_vencimiento
        '
        Me.txtfecha_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha_vencimiento.Location = New System.Drawing.Point(154, 231)
        Me.txtfecha_vencimiento.Name = "txtfecha_vencimiento"
        Me.txtfecha_vencimiento.Size = New System.Drawing.Size(171, 20)
        Me.txtfecha_vencimiento.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Fecha de vencimiento"
        '
        'txtnom_categoria
        '
        Me.txtnom_categoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnom_categoria.Location = New System.Drawing.Point(189, 82)
        Me.txtnom_categoria.Name = "txtnom_categoria"
        Me.txtnom_categoria.Size = New System.Drawing.Size(137, 20)
        Me.txtnom_categoria.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(85, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Categoria"
        '
        'txtidcategoria
        '
        Me.txtidcategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtidcategoria.Location = New System.Drawing.Point(154, 82)
        Me.txtidcategoria.Name = "txtidcategoria"
        Me.txtidcategoria.Size = New System.Drawing.Size(29, 20)
        Me.txtidcategoria.TabIndex = 16
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(167, 473)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(67, 26)
        Me.btnGuardar.TabIndex = 15
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(167, 454)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(67, 26)
        Me.btnEditar.TabIndex = 14
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(252, 454)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(67, 26)
        Me.btncancelar.TabIndex = 13
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(83, 454)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(67, 26)
        Me.btnNuevo.TabIndex = 12
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Precio de Venta"
        '
        'txtprecio_venta
        '
        Me.txtprecio_venta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtprecio_venta.Location = New System.Drawing.Point(154, 205)
        Me.txtprecio_venta.Name = "txtprecio_venta"
        Me.txtprecio_venta.Size = New System.Drawing.Size(172, 20)
        Me.txtprecio_venta.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Precio de Compra"
        '
        'txtprecio_compra
        '
        Me.txtprecio_compra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtprecio_compra.Location = New System.Drawing.Point(154, 179)
        Me.txtprecio_compra.Name = "txtprecio_compra"
        Me.txtprecio_compra.Size = New System.Drawing.Size(172, 20)
        Me.txtprecio_compra.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(102, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Stock"
        '
        'txtstock
        '
        Me.txtstock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtstock.Location = New System.Drawing.Point(154, 153)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(172, 20)
        Me.txtstock.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descripcion"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescripcion.Location = New System.Drawing.Point(154, 108)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdescripcion.Size = New System.Drawing.Size(172, 39)
        Me.txtdescripcion.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre del Producto"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(154, 52)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(172, 20)
        Me.txtNombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id Producto"
        '
        'txtIdproducto
        '
        Me.txtIdproducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdproducto.Enabled = False
        Me.txtIdproducto.Location = New System.Drawing.Point(154, 25)
        Me.txtIdproducto.Name = "txtIdproducto"
        Me.txtIdproducto.Size = New System.Drawing.Size(172, 20)
        Me.txtIdproducto.TabIndex = 0
        '
        'frmeditarproducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 520)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmeditarproducto"
        Me.Text = "frmeditarproducto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbbmodulo As System.Windows.Forms.Label
    Friend WithEvents txtmedida As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnlimpiar As System.Windows.Forms.PictureBox
    Friend WithEvents btncargar As System.Windows.Forms.PictureBox
    Friend WithEvents imagen As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtfecha_vencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtnom_categoria As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtidcategoria As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtprecio_venta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtprecio_compra As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtstock As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIdproducto As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
