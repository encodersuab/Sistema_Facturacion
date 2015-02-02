<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteComprobante
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.generar_comprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbfacDataSet = New Sistema_Facturacion.dbfacDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.generar_comprobanteTableAdapter = New Sistema_Facturacion.dbfacDataSetTableAdapters.generar_comprobanteTableAdapter()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        Me.qrdataset1 = New Sistema_Facturacion.qrdataset1()
        Me.TDetalleVentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TDetalleVentaTableAdapter = New Sistema_Facturacion.qrdataset1TableAdapters.TDetalleVentaTableAdapter()
        CType(Me.generar_comprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbfacDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qrdataset1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TDetalleVentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'generar_comprobanteBindingSource
        '
        Me.generar_comprobanteBindingSource.DataMember = "generar_comprobante"
        Me.generar_comprobanteBindingSource.DataSource = Me.dbfacDataSet
        '
        'dbfacDataSet
        '
        Me.dbfacDataSet.DataSetName = "dbfacDataSet"
        Me.dbfacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.TDetalleVentaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Facturacion.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(854, 411)
        Me.ReportViewer1.TabIndex = 0
        '
        'generar_comprobanteTableAdapter
        '
        Me.generar_comprobanteTableAdapter.ClearBeforeFill = True
        '
        'txtidventa
        '
        Me.txtidventa.Location = New System.Drawing.Point(77, 66)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.Size = New System.Drawing.Size(100, 20)
        Me.txtidventa.TabIndex = 1
        Me.txtidventa.Visible = False
        '
        'qrdataset1
        '
        Me.qrdataset1.DataSetName = "qrdataset1"
        Me.qrdataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TDetalleVentaBindingSource
        '
        Me.TDetalleVentaBindingSource.DataMember = "TDetalleVenta"
        Me.TDetalleVentaBindingSource.DataSource = Me.qrdataset1
        '
        'TDetalleVentaTableAdapter
        '
        Me.TDetalleVentaTableAdapter.ClearBeforeFill = True
        '
        'frmReporteComprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 411)
        Me.Controls.Add(Me.txtidventa)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteComprobante"
        Me.Text = ".: Reporte de Comprobante :."
        CType(Me.generar_comprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbfacDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qrdataset1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TDetalleVentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents generar_comprobanteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbfacDataSet As Sistema_Facturacion.dbfacDataSet
    Friend WithEvents generar_comprobanteTableAdapter As Sistema_Facturacion.dbfacDataSetTableAdapters.generar_comprobanteTableAdapter
    Friend WithEvents txtidventa As System.Windows.Forms.TextBox
    Friend WithEvents TDetalleVentaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents qrdataset1 As Sistema_Facturacion.qrdataset1
    Friend WithEvents TDetalleVentaTableAdapter As Sistema_Facturacion.qrdataset1TableAdapters.TDetalleVentaTableAdapter
End Class
