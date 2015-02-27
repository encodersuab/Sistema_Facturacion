<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteFactura
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
        Me.mostrar_facturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbfacDataSet = New Sistema_Facturacion.dbfacDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtnumfactura = New System.Windows.Forms.TextBox()
        Me.mostrar_facturaTableAdapter = New Sistema_Facturacion.dbfacDataSetTableAdapters.mostrar_facturaTableAdapter()
        Me.mostrar_producto_emfopesbeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mostrar_producto_emfopesbeTableAdapter = New Sistema_Facturacion.dbfacDataSetTableAdapters.mostrar_producto_emfopesbeTableAdapter()
        CType(Me.mostrar_facturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbfacDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrar_producto_emfopesbeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mostrar_facturaBindingSource
        '
        Me.mostrar_facturaBindingSource.DataMember = "mostrar_factura"
        Me.mostrar_facturaBindingSource.DataSource = Me.dbfacDataSet
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
        ReportDataSource1.Value = Me.mostrar_facturaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Facturacion.rptFactura.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1242, 432)
        Me.ReportViewer1.TabIndex = 0
        '
        'txtnumfactura
        '
        Me.txtnumfactura.Location = New System.Drawing.Point(0, 25)
        Me.txtnumfactura.Name = "txtnumfactura"
        Me.txtnumfactura.Size = New System.Drawing.Size(100, 20)
        Me.txtnumfactura.TabIndex = 1
        Me.txtnumfactura.Visible = False
        '
        'mostrar_facturaTableAdapter
        '
        Me.mostrar_facturaTableAdapter.ClearBeforeFill = True
        '
        'mostrar_producto_emfopesbeBindingSource
        '
        Me.mostrar_producto_emfopesbeBindingSource.DataMember = "mostrar_producto_emfopesbe"
        Me.mostrar_producto_emfopesbeBindingSource.DataSource = Me.dbfacDataSet
        '
        'mostrar_producto_emfopesbeTableAdapter
        '
        Me.mostrar_producto_emfopesbeTableAdapter.ClearBeforeFill = True
        '
        'frmReporteFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 432)
        Me.Controls.Add(Me.txtnumfactura)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteFactura"
        Me.Text = "frmReporteFactura"
        CType(Me.mostrar_facturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbfacDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrar_producto_emfopesbeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_facturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbfacDataSet As Sistema_Facturacion.dbfacDataSet
    Friend WithEvents txtnumfactura As System.Windows.Forms.TextBox
    Friend WithEvents mostrar_facturaTableAdapter As Sistema_Facturacion.dbfacDataSetTableAdapters.mostrar_facturaTableAdapter
    Friend WithEvents mostrar_producto_emfopesbeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents mostrar_producto_emfopesbeTableAdapter As Sistema_Facturacion.dbfacDataSetTableAdapters.mostrar_producto_emfopesbeTableAdapter
End Class
