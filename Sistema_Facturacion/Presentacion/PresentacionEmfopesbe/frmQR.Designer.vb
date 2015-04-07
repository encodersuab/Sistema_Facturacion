<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQR
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cbxListadoClientes = New System.Windows.Forms.ComboBox()
        Me.Inexistente = New System.Windows.Forms.LinkLabel()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtvalidez = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAnularFactura = New System.Windows.Forms.Button()
        Me.txtfechaEmision = New System.Windows.Forms.TextBox()
        Me.txtCiNitComprador = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIDCodQr = New System.Windows.Forms.TextBox()
        Me.txttxtIdVenta = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodigoControl = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtINum_Autorizacion = New System.Windows.Forms.TextBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalPagar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNum_Factura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNit_Emisor = New System.Windows.Forms.TextBox()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.Controls.Add(Me.cbxListadoClientes)
        Me.GroupBox2.Controls.Add(Me.Inexistente)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Location = New System.Drawing.Point(387, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(557, 345)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de articulos de Venta"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(133, 25)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(405, 20)
        Me.txtBuscar.TabIndex = 5
        '
        'cbxListadoClientes
        '
        Me.cbxListadoClientes.FormattingEnabled = True
        Me.cbxListadoClientes.Items.AddRange(New Object() {"CI_Nit_Comprador"})
        Me.cbxListadoClientes.Location = New System.Drawing.Point(6, 24)
        Me.cbxListadoClientes.Name = "cbxListadoClientes"
        Me.cbxListadoClientes.Size = New System.Drawing.Size(121, 21)
        Me.cbxListadoClientes.TabIndex = 4
        Me.cbxListadoClientes.Text = "CI_Nit_Comprador"
        '
        'Inexistente
        '
        Me.Inexistente.AutoSize = True
        Me.Inexistente.Location = New System.Drawing.Point(234, 203)
        Me.Inexistente.Name = "Inexistente"
        Me.Inexistente.Size = New System.Drawing.Size(94, 13)
        Me.Inexistente.TabIndex = 3
        Me.Inexistente.TabStop = True
        Me.Inexistente.Text = "Datos Inexistentes"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar})
        Me.datalistado.Location = New System.Drawing.Point(6, 51)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(532, 279)
        Me.datalistado.TabIndex = 0
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtvalidez)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnAnularFactura)
        Me.GroupBox1.Controls.Add(Me.txtfechaEmision)
        Me.GroupBox1.Controls.Add(Me.txtCiNitComprador)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtIDCodQr)
        Me.GroupBox1.Controls.Add(Me.txttxtIdVenta)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCodigoControl)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtINum_Autorizacion)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTotalPagar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNum_Factura)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNit_Emisor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 345)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 42)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Re-Impresion de Factura"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtvalidez
        '
        Me.txtvalidez.AcceptsReturn = True
        Me.txtvalidez.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtvalidez.Enabled = False
        Me.txtvalidez.Location = New System.Drawing.Point(144, 258)
        Me.txtvalidez.Name = "txtvalidez"
        Me.txtvalidez.Size = New System.Drawing.Size(173, 20)
        Me.txtvalidez.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Validez"
        '
        'btnAnularFactura
        '
        Me.btnAnularFactura.Location = New System.Drawing.Point(143, 288)
        Me.btnAnularFactura.Name = "btnAnularFactura"
        Me.btnAnularFactura.Size = New System.Drawing.Size(117, 42)
        Me.btnAnularFactura.TabIndex = 35
        Me.btnAnularFactura.Text = "Anular Factura"
        Me.btnAnularFactura.UseVisualStyleBackColor = True
        '
        'txtfechaEmision
        '
        Me.txtfechaEmision.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfechaEmision.Enabled = False
        Me.txtfechaEmision.Location = New System.Drawing.Point(144, 130)
        Me.txtfechaEmision.Name = "txtfechaEmision"
        Me.txtfechaEmision.Size = New System.Drawing.Size(173, 20)
        Me.txtfechaEmision.TabIndex = 34
        '
        'txtCiNitComprador
        '
        Me.txtCiNitComprador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCiNitComprador.Enabled = False
        Me.txtCiNitComprador.Location = New System.Drawing.Point(144, 206)
        Me.txtCiNitComprador.Name = "txtCiNitComprador"
        Me.txtCiNitComprador.Size = New System.Drawing.Size(173, 20)
        Me.txtCiNitComprador.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(75, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "IDCodQr"
        '
        'txtIDCodQr
        '
        Me.txtIDCodQr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIDCodQr.Enabled = False
        Me.txtIDCodQr.Location = New System.Drawing.Point(144, 24)
        Me.txtIDCodQr.Name = "txtIDCodQr"
        Me.txtIDCodQr.Size = New System.Drawing.Size(173, 20)
        Me.txtIDCodQr.TabIndex = 31
        '
        'txttxtIdVenta
        '
        Me.txttxtIdVenta.AcceptsReturn = True
        Me.txttxtIdVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttxtIdVenta.Enabled = False
        Me.txttxtIdVenta.Location = New System.Drawing.Point(144, 232)
        Me.txttxtIdVenta.Name = "txttxtIdVenta"
        Me.txttxtIdVenta.Size = New System.Drawing.Size(173, 20)
        Me.txttxtIdVenta.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(79, 235)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "IdVenta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Ci_Nit_Comprador"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Codigo_Control"
        '
        'txtCodigoControl
        '
        Me.txtCodigoControl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoControl.Enabled = False
        Me.txtCodigoControl.Location = New System.Drawing.Point(144, 180)
        Me.txtCodigoControl.Name = "txtCodigoControl"
        Me.txtCodigoControl.Size = New System.Drawing.Size(173, 20)
        Me.txtCodigoControl.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(92, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Total"
        '
        'txtINum_Autorizacion
        '
        Me.txtINum_Autorizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtINum_Autorizacion.Enabled = False
        Me.txtINum_Autorizacion.Location = New System.Drawing.Point(144, 104)
        Me.txtINum_Autorizacion.Name = "txtINum_Autorizacion"
        Me.txtINum_Autorizacion.Size = New System.Drawing.Size(173, 20)
        Me.txtINum_Autorizacion.TabIndex = 20
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(266, 288)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(67, 42)
        Me.btncancelar.TabIndex = 13
        Me.btncancelar.Text = "Salir"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fecha_emision"
        '
        'txtTotalPagar
        '
        Me.txtTotalPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalPagar.Enabled = False
        Me.txtTotalPagar.Location = New System.Drawing.Point(144, 154)
        Me.txtTotalPagar.Name = "txtTotalPagar"
        Me.txtTotalPagar.Size = New System.Drawing.Size(173, 20)
        Me.txtTotalPagar.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Num_Autorizacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Num_Factura"
        '
        'txtNum_Factura
        '
        Me.txtNum_Factura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNum_Factura.Enabled = False
        Me.txtNum_Factura.Location = New System.Drawing.Point(144, 76)
        Me.txtNum_Factura.Name = "txtNum_Factura"
        Me.txtNum_Factura.Size = New System.Drawing.Size(173, 20)
        Me.txtNum_Factura.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nit_Emisor"
        '
        'txtNit_Emisor
        '
        Me.txtNit_Emisor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNit_Emisor.Enabled = False
        Me.txtNit_Emisor.Location = New System.Drawing.Point(144, 50)
        Me.txtNit_Emisor.Name = "txtNit_Emisor"
        Me.txtNit_Emisor.Size = New System.Drawing.Size(173, 20)
        Me.txtNit_Emisor.TabIndex = 0
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'frmQR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 366)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmQR"
        Me.Text = ".:. QR .:."
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Inexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtIDCodQr As System.Windows.Forms.TextBox
    Friend WithEvents txttxtIdVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoControl As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtINum_Autorizacion As System.Windows.Forms.TextBox
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPagar As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNum_Factura As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNit_Emisor As System.Windows.Forms.TextBox
    Friend WithEvents txtCiNitComprador As System.Windows.Forms.TextBox
    Friend WithEvents txtfechaEmision As System.Windows.Forms.TextBox
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents cbxListadoClientes As System.Windows.Forms.ComboBox
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnAnularFactura As System.Windows.Forms.Button
    Friend WithEvents txtvalidez As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
