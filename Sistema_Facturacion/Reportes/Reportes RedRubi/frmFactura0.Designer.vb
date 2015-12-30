<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFactura0
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
        Me.mostrar_facturaTableAdapter = New Sistema_Facturacion.dbfacDataSetTableAdapters.mostrar_facturaTableAdapter()
        Me.txtnumfactura = New System.Windows.Forms.Label()
        Me.dbfacDataSetFACTURAS = New Sistema_Facturacion.dbfacDataSetFACTURAS()
        Me.mostrar_factura0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mostrar_factura0TableAdapter = New Sistema_Facturacion.dbfacDataSetFACTURASTableAdapters.mostrar_factura0TableAdapter()
        CType(Me.mostrar_facturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbfacDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbfacDataSetFACTURAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrar_factura0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrar_factura0BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Facturacion.rptFac0.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(850, 459)
        Me.ReportViewer1.TabIndex = 0
        '
        'mostrar_facturaTableAdapter
        '
        Me.mostrar_facturaTableAdapter.ClearBeforeFill = True
        '
        'txtnumfactura
        '
        Me.txtnumfactura.AutoSize = True
        Me.txtnumfactura.Location = New System.Drawing.Point(741, 9)
        Me.txtnumfactura.Name = "txtnumfactura"
        Me.txtnumfactura.Size = New System.Drawing.Size(39, 13)
        Me.txtnumfactura.TabIndex = 1
        Me.txtnumfactura.Text = "Label1"
        '
        'dbfacDataSetFACTURAS
        '
        Me.dbfacDataSetFACTURAS.DataSetName = "dbfacDataSetFACTURAS"
        Me.dbfacDataSetFACTURAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mostrar_factura0BindingSource
        '
        Me.mostrar_factura0BindingSource.DataMember = "mostrar_factura0"
        Me.mostrar_factura0BindingSource.DataSource = Me.dbfacDataSetFACTURAS
        '
        'mostrar_factura0TableAdapter
        '
        Me.mostrar_factura0TableAdapter.ClearBeforeFill = True
        '
        'frmFactura0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 463)
        Me.Controls.Add(Me.txtnumfactura)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmFactura0"
        Me.Text = "frmFactura0"
        CType(Me.mostrar_facturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbfacDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbfacDataSetFACTURAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrar_factura0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_facturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbfacDataSet As Sistema_Facturacion.dbfacDataSet
    Friend WithEvents mostrar_facturaTableAdapter As Sistema_Facturacion.dbfacDataSetTableAdapters.mostrar_facturaTableAdapter
    Friend WithEvents txtnumfactura As System.Windows.Forms.Label
    Friend WithEvents mostrar_factura0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbfacDataSetFACTURAS As Sistema_Facturacion.dbfacDataSetFACTURAS
    Friend WithEvents mostrar_factura0TableAdapter As Sistema_Facturacion.dbfacDataSetFACTURASTableAdapters.mostrar_factura0TableAdapter
End Class
