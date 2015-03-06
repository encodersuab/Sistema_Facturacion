<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpresionfacturaPlanilla
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNombreFac = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtnituab = New System.Windows.Forms.TextBox()
        Me.cbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtNombreCLiente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumDoc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdVenta = New System.Windows.Forms.TextBox()
        Me.btnFinalizarVenta = New System.Windows.Forms.Button()
        Me.lbnumAutor = New System.Windows.Forms.Label()
        Me.lbllave = New System.Windows.Forms.Label()
        Me.lbCC = New System.Windows.Forms.Label()
        Me.Inexistente = New System.Windows.Forms.LinkLabel()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cbxListadoClientes = New System.Windows.Forms.ComboBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(59, 219)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Total a Pagar"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(144, 216)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(100, 20)
        Me.txttotal.TabIndex = 36
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFinalizarVenta)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txttotal)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtNombreFac)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtnituab)
        Me.GroupBox1.Controls.Add(Me.cbTipoDoc)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.txtNombreCLiente)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNumDoc)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtidCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtIdVenta)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 429)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(44, 183)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Nombre Factura"
        '
        'txtNombreFac
        '
        Me.txtNombreFac.Enabled = False
        Me.txtNombreFac.Location = New System.Drawing.Point(144, 180)
        Me.txtNombreFac.Name = "txtNombreFac"
        Me.txtNombreFac.Size = New System.Drawing.Size(173, 20)
        Me.txtNombreFac.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(44, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Nit UAB"
        '
        'txtnituab
        '
        Me.txtnituab.Enabled = False
        Me.txtnituab.Location = New System.Drawing.Point(144, 24)
        Me.txtnituab.Name = "txtnituab"
        Me.txtnituab.Size = New System.Drawing.Size(173, 20)
        Me.txtnituab.TabIndex = 31
        '
        'cbTipoDoc
        '
        Me.cbTipoDoc.Enabled = False
        Me.cbTipoDoc.FormattingEnabled = True
        Me.cbTipoDoc.Items.AddRange(New Object() {"Factura"})
        Me.cbTipoDoc.Location = New System.Drawing.Point(144, 128)
        Me.cbTipoDoc.Name = "cbTipoDoc"
        Me.cbTipoDoc.Size = New System.Drawing.Size(173, 21)
        Me.cbTipoDoc.TabIndex = 19
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(144, 103)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(92, 20)
        Me.dtpFecha.TabIndex = 18
        '
        'txtNombreCLiente
        '
        Me.txtNombreCLiente.Enabled = False
        Me.txtNombreCLiente.Location = New System.Drawing.Point(170, 76)
        Me.txtNombreCLiente.Name = "txtNombreCLiente"
        Me.txtNombreCLiente.Size = New System.Drawing.Size(147, 20)
        Me.txtNombreCLiente.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Numero Doc"
        '
        'txtNumDoc
        '
        Me.txtNumDoc.Enabled = False
        Me.txtNumDoc.Location = New System.Drawing.Point(144, 154)
        Me.txtNumDoc.Name = "txtNumDoc"
        Me.txtNumDoc.Size = New System.Drawing.Size(173, 20)
        Me.txtNumDoc.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tipo Doc"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cliente"
        '
        'txtidCliente
        '
        Me.txtidCliente.Enabled = False
        Me.txtidCliente.Location = New System.Drawing.Point(144, 76)
        Me.txtidCliente.Name = "txtidCliente"
        Me.txtidCliente.Size = New System.Drawing.Size(20, 20)
        Me.txtidCliente.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IdVenta"
        '
        'txtIdVenta
        '
        Me.txtIdVenta.Enabled = False
        Me.txtIdVenta.Location = New System.Drawing.Point(144, 50)
        Me.txtIdVenta.Name = "txtIdVenta"
        Me.txtIdVenta.Size = New System.Drawing.Size(173, 20)
        Me.txtIdVenta.TabIndex = 0
        '
        'btnFinalizarVenta
        '
        Me.btnFinalizarVenta.Location = New System.Drawing.Point(100, 276)
        Me.btnFinalizarVenta.Name = "btnFinalizarVenta"
        Me.btnFinalizarVenta.Size = New System.Drawing.Size(161, 85)
        Me.btnFinalizarVenta.TabIndex = 41
        Me.btnFinalizarVenta.Text = "Finalizar Venta"
        Me.btnFinalizarVenta.UseVisualStyleBackColor = True
        '
        'lbnumAutor
        '
        Me.lbnumAutor.AutoSize = True
        Me.lbnumAutor.Location = New System.Drawing.Point(442, 474)
        Me.lbnumAutor.Name = "lbnumAutor"
        Me.lbnumAutor.Size = New System.Drawing.Size(98, 13)
        Me.lbnumAutor.TabIndex = 44
        Me.lbnumAutor.Text = "lbnum AUtorizacion"
        Me.lbnumAutor.Visible = False
        '
        'lbllave
        '
        Me.lbllave.AutoSize = True
        Me.lbllave.Location = New System.Drawing.Point(442, 459)
        Me.lbllave.Name = "lbllave"
        Me.lbllave.Size = New System.Drawing.Size(37, 13)
        Me.lbllave.TabIndex = 43
        Me.lbllave.Text = "lbllave"
        Me.lbllave.Visible = False
        '
        'lbCC
        '
        Me.lbCC.AutoSize = True
        Me.lbCC.Location = New System.Drawing.Point(442, 488)
        Me.lbCC.Name = "lbCC"
        Me.lbCC.Size = New System.Drawing.Size(76, 13)
        Me.lbCC.TabIndex = 42
        Me.lbCC.Text = "Codigo Control"
        '
        'Inexistente
        '
        Me.Inexistente.AutoSize = True
        Me.Inexistente.Location = New System.Drawing.Point(717, 235)
        Me.Inexistente.Name = "Inexistente"
        Me.Inexistente.Size = New System.Drawing.Size(94, 13)
        Me.Inexistente.TabIndex = 48
        Me.Inexistente.TabStop = True
        Me.Inexistente.Text = "Datos Inexistentes"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(661, 58)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(274, 20)
        Me.txtBuscar.TabIndex = 47
        '
        'cbxListadoClientes
        '
        Me.cbxListadoClientes.FormattingEnabled = True
        Me.cbxListadoClientes.Items.AddRange(New Object() {"NombreProducto", "NombreCategoria"})
        Me.cbxListadoClientes.Location = New System.Drawing.Point(512, 57)
        Me.cbxListadoClientes.Name = "cbxListadoClientes"
        Me.cbxListadoClientes.Size = New System.Drawing.Size(121, 21)
        Me.cbxListadoClientes.TabIndex = 46
        Me.cbxListadoClientes.Text = "NombreProducto"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar})
        Me.datalistado.Location = New System.Drawing.Point(423, 88)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(681, 344)
        Me.datalistado.TabIndex = 45
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        '
        'frmImpresionfacturaPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 543)
        Me.Controls.Add(Me.Inexistente)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.cbxListadoClientes)
        Me.Controls.Add(Me.datalistado)
        Me.Controls.Add(Me.lbnumAutor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbllave)
        Me.Controls.Add(Me.lbCC)
        Me.Name = "frmImpresionfacturaPlanilla"
        Me.Text = "frmImpresionfacturaPlanilla"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNombreFac As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtnituab As System.Windows.Forms.TextBox
    Friend WithEvents cbTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNombreCLiente As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNumDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtidCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIdVenta As System.Windows.Forms.TextBox
    Friend WithEvents btnFinalizarVenta As System.Windows.Forms.Button
    Friend WithEvents lbnumAutor As System.Windows.Forms.Label
    Friend WithEvents lbllave As System.Windows.Forms.Label
    Friend WithEvents lbCC As System.Windows.Forms.Label
    Friend WithEvents Inexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents cbxListadoClientes As System.Windows.Forms.ComboBox
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
