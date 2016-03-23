<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenPago
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
        Me.txtTotalParcial = New System.Windows.Forms.Label()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.lbmedida = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNombreFac = New System.Windows.Forms.TextBox()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.cbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtNombreCLiente = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumDoc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidCliente = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvDetalleOrdenPago = New System.Windows.Forms.DataGridView()
        Me.btnFinalizarVenta = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.txtNombreCategoria = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDetalleOrdenPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNombreCategoria)
        Me.GroupBox1.Controls.Add(Me.txtTotalParcial)
        Me.GroupBox1.Controls.Add(Me.btnBuscarCliente)
        Me.GroupBox1.Controls.Add(Me.lbmedida)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtNombreFac)
        Me.GroupBox1.Controls.Add(Me.txtPrecioUnitario)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnBuscarProducto)
        Me.GroupBox1.Controls.Add(Me.txtNombreProducto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtIdProducto)
        Me.GroupBox1.Controls.Add(Me.cbTipoDoc)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.txtNombreCLiente)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNumDoc)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtidCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 400)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'txtTotalParcial
        '
        Me.txtTotalParcial.AutoSize = True
        Me.txtTotalParcial.Location = New System.Drawing.Point(142, 298)
        Me.txtTotalParcial.Name = "txtTotalParcial"
        Me.txtTotalParcial.Size = New System.Drawing.Size(74, 13)
        Me.txtTotalParcial.TabIndex = 37
        Me.txtTotalParcial.Text = "txtTotalParcial"
        Me.txtTotalParcial.Visible = False
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Location = New System.Drawing.Point(323, 29)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(29, 26)
        Me.btnBuscarCliente.TabIndex = 36
        Me.btnBuscarCliente.Text = "..."
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'lbmedida
        '
        Me.lbmedida.AutoSize = True
        Me.lbmedida.Location = New System.Drawing.Point(284, 235)
        Me.lbmedida.Name = "lbmedida"
        Me.lbmedida.Size = New System.Drawing.Size(0, 13)
        Me.lbmedida.TabIndex = 35
        '
        'txtCantidad
        '
        Me.txtCantidad.DecimalPlaces = 3
        Me.txtCantidad.Location = New System.Drawing.Point(144, 233)
        Me.txtCantidad.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(134, 20)
        Me.txtCantidad.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(42, 141)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Nombre Factura"
        '
        'txtNombreFac
        '
        Me.txtNombreFac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreFac.Enabled = False
        Me.txtNombreFac.Location = New System.Drawing.Point(144, 138)
        Me.txtNombreFac.Name = "txtNombreFac"
        Me.txtNombreFac.Size = New System.Drawing.Size(173, 20)
        Me.txtNombreFac.TabIndex = 33
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(142, 259)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(173, 20)
        Me.txtPrecioUnitario.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(52, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "PrecioUnitario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(76, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Cantidad"
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.Location = New System.Drawing.Point(323, 203)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(29, 26)
        Me.btnBuscarProducto.TabIndex = 23
        Me.btnBuscarProducto.Text = "..."
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreProducto.Enabled = False
        Me.txtNombreProducto.Location = New System.Drawing.Point(170, 207)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(147, 20)
        Me.txtNombreProducto.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(75, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Producto"
        '
        'txtIdProducto
        '
        Me.txtIdProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdProducto.Enabled = False
        Me.txtIdProducto.Location = New System.Drawing.Point(144, 207)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(20, 20)
        Me.txtIdProducto.TabIndex = 20
        '
        'cbTipoDoc
        '
        Me.cbTipoDoc.FormattingEnabled = True
        Me.cbTipoDoc.Items.AddRange(New Object() {"CI", "NIT"})
        Me.cbTipoDoc.Location = New System.Drawing.Point(144, 85)
        Me.cbTipoDoc.Name = "cbTipoDoc"
        Me.cbTipoDoc.Size = New System.Drawing.Size(173, 21)
        Me.cbTipoDoc.TabIndex = 19
        Me.cbTipoDoc.Text = "CI"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(144, 59)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(92, 20)
        Me.dtpFecha.TabIndex = 18
        '
        'txtNombreCLiente
        '
        Me.txtNombreCLiente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreCLiente.Enabled = False
        Me.txtNombreCLiente.Location = New System.Drawing.Point(170, 33)
        Me.txtNombreCLiente.Name = "txtNombreCLiente"
        Me.txtNombreCLiente.Size = New System.Drawing.Size(147, 20)
        Me.txtNombreCLiente.TabIndex = 16
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(226, 331)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(67, 35)
        Me.btnGuardar.TabIndex = 15
        Me.btnGuardar.Text = "Agregar Articulo"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(142, 331)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(67, 35)
        Me.btnNuevo.TabIndex = 12
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Numero Doc"
        '
        'txtNumDoc
        '
        Me.txtNumDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumDoc.Location = New System.Drawing.Point(144, 112)
        Me.txtNumDoc.Name = "txtNumDoc"
        Me.txtNumDoc.Size = New System.Drawing.Size(173, 20)
        Me.txtNumDoc.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tipo Doc"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cliente"
        '
        'txtidCliente
        '
        Me.txtidCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtidCliente.Enabled = False
        Me.txtidCliente.Location = New System.Drawing.Point(144, 33)
        Me.txtidCliente.Name = "txtidCliente"
        Me.txtidCliente.Size = New System.Drawing.Size(20, 20)
        Me.txtidCliente.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvDetalleOrdenPago)
        Me.GroupBox2.Controls.Add(Me.btnFinalizarVenta)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txttotal)
        Me.GroupBox2.Location = New System.Drawing.Point(376, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(581, 400)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de articulos de Venta"
        '
        'dgvDetalleOrdenPago
        '
        Me.dgvDetalleOrdenPago.AllowUserToAddRows = False
        Me.dgvDetalleOrdenPago.AllowUserToDeleteRows = False
        Me.dgvDetalleOrdenPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleOrdenPago.Location = New System.Drawing.Point(0, 75)
        Me.dgvDetalleOrdenPago.Name = "dgvDetalleOrdenPago"
        Me.dgvDetalleOrdenPago.ReadOnly = True
        Me.dgvDetalleOrdenPago.Size = New System.Drawing.Size(581, 261)
        Me.dgvDetalleOrdenPago.TabIndex = 41
        '
        'btnFinalizarVenta
        '
        Me.btnFinalizarVenta.Location = New System.Drawing.Point(440, 347)
        Me.btnFinalizarVenta.Name = "btnFinalizarVenta"
        Me.btnFinalizarVenta.Size = New System.Drawing.Size(135, 47)
        Me.btnFinalizarVenta.TabIndex = 40
        Me.btnFinalizarVenta.Text = "IMPRIMIR ORDEN DE PAGO"
        Me.btnFinalizarVenta.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(407, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 47)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(243, 364)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Total a Pagar"
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(320, 353)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(100, 29)
        Me.txttotal.TabIndex = 34
        '
        'PrintDocument1
        '
        '
        'txtNombreCategoria
        '
        Me.txtNombreCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreCategoria.Enabled = False
        Me.txtNombreCategoria.Location = New System.Drawing.Point(168, 181)
        Me.txtNombreCategoria.Name = "txtNombreCategoria"
        Me.txtNombreCategoria.Size = New System.Drawing.Size(147, 20)
        Me.txtNombreCategoria.TabIndex = 38
        '
        'frmOrdenPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 424)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmOrdenPago"
        Me.Text = "frmOrdenPago"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvDetalleOrdenPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbmedida As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNombreFac As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioUnitario As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarProducto As System.Windows.Forms.Button
    Friend WithEvents txtNombreProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIdProducto As System.Windows.Forms.TextBox
    Friend WithEvents cbTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNombreCLiente As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNumDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtidCliente As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFinalizarVenta As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents dgvDetalleOrdenPago As System.Windows.Forms.DataGridView
    Friend WithEvents txtTotalParcial As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents txtNombreCategoria As System.Windows.Forms.TextBox
End Class
