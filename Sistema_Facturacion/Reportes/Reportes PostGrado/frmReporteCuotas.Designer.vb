<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteCuotas
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.mostrar_cliente_servicio_cuotaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbfacDataSet = New Sistema_Facturacion.dbfacDataSet()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.cbservicio = New System.Windows.Forms.ComboBox()
        Me.MostrarproductopostgradoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtci = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Mostrar_producto_postgradoTableAdapter = New Sistema_Facturacion.dbfacDataSetTableAdapters.mostrar_producto_postgradoTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.mostrar_cliente_servicio_cuotaTableAdapter = New Sistema_Facturacion.dbfacDataSetTableAdapters.mostrar_cliente_servicio_cuotaTableAdapter()
        CType(Me.mostrar_cliente_servicio_cuotaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbfacDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostrarproductopostgradoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mostrar_cliente_servicio_cuotaBindingSource
        '
        Me.mostrar_cliente_servicio_cuotaBindingSource.DataMember = "mostrar_cliente_servicio_cuota"
        Me.mostrar_cliente_servicio_cuotaBindingSource.DataSource = Me.DbfacDataSet
        '
        'DbfacDataSet
        '
        Me.DbfacDataSet.DataSetName = "dbfacDataSet"
        Me.DbfacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(612, 6)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 22)
        Me.btnbuscar.TabIndex = 0
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'cbservicio
        '
        Me.cbservicio.DataSource = Me.MostrarproductopostgradoBindingSource
        Me.cbservicio.DisplayMember = "NombreProducto"
        Me.cbservicio.FormattingEnabled = True
        Me.cbservicio.Location = New System.Drawing.Point(300, 6)
        Me.cbservicio.Name = "cbservicio"
        Me.cbservicio.Size = New System.Drawing.Size(284, 21)
        Me.cbservicio.TabIndex = 1
        Me.cbservicio.ValueMember = "NombreProducto"
        '
        'MostrarproductopostgradoBindingSource
        '
        Me.MostrarproductopostgradoBindingSource.DataMember = "mostrar_producto_postgrado"
        Me.MostrarproductopostgradoBindingSource.DataSource = Me.DbfacDataSet
        '
        'txtci
        '
        Me.txtci.Location = New System.Drawing.Point(74, 6)
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(162, 20)
        Me.txtci.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(249, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Servicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "CI"
        '
        'Mostrar_producto_postgradoTableAdapter
        '
        Me.Mostrar_producto_postgradoTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrar_cliente_servicio_cuotaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Facturacion.ReporteCuotas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 34)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(919, 363)
        Me.ReportViewer1.TabIndex = 5
        '
        'mostrar_cliente_servicio_cuotaTableAdapter
        '
        Me.mostrar_cliente_servicio_cuotaTableAdapter.ClearBeforeFill = True
        '
        'frmReporteCuotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 397)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtci)
        Me.Controls.Add(Me.cbservicio)
        Me.Controls.Add(Me.btnbuscar)
        Me.Name = "frmReporteCuotas"
        Me.Text = "frmReporteCuotas"
        CType(Me.mostrar_cliente_servicio_cuotaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbfacDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostrarproductopostgradoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents cbservicio As System.Windows.Forms.ComboBox
    Friend WithEvents txtci As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DbfacDataSet As Sistema_Facturacion.dbfacDataSet
    Friend WithEvents MostrarproductopostgradoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mostrar_producto_postgradoTableAdapter As Sistema_Facturacion.dbfacDataSetTableAdapters.mostrar_producto_postgradoTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_cliente_servicio_cuotaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents mostrar_cliente_servicio_cuotaTableAdapter As Sistema_Facturacion.dbfacDataSetTableAdapters.mostrar_cliente_servicio_cuotaTableAdapter
End Class
