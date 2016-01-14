<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFactura3
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
        Me.txtnumfactura = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dbfacDataSetFACTURAS = New Sistema_Facturacion.dbfacDataSetFACTURAS()
        Me.mostrar_factura3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mostrar_factura3TableAdapter = New Sistema_Facturacion.dbfacDataSetFACTURASTableAdapters.mostrar_factura3TableAdapter()
        CType(Me.dbfacDataSetFACTURAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrar_factura3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnumfactura
        '
        Me.txtnumfactura.AutoSize = True
        Me.txtnumfactura.Location = New System.Drawing.Point(728, 0)
        Me.txtnumfactura.Name = "txtnumfactura"
        Me.txtnumfactura.Size = New System.Drawing.Size(39, 13)
        Me.txtnumfactura.TabIndex = 1
        Me.txtnumfactura.Text = "Label1"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrar_factura3BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Facturacion.rptFactu3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(883, 475)
        Me.ReportViewer1.TabIndex = 2
        '
        'dbfacDataSetFACTURAS
        '
        Me.dbfacDataSetFACTURAS.DataSetName = "dbfacDataSetFACTURAS"
        Me.dbfacDataSetFACTURAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mostrar_factura3BindingSource
        '
        Me.mostrar_factura3BindingSource.DataMember = "mostrar_factura3"
        Me.mostrar_factura3BindingSource.DataSource = Me.dbfacDataSetFACTURAS
        '
        'mostrar_factura3TableAdapter
        '
        Me.mostrar_factura3TableAdapter.ClearBeforeFill = True
        '
        'frmFactura3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 475)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.txtnumfactura)
        Me.Name = "frmFactura3"
        Me.Text = "frmFactura3"
        CType(Me.dbfacDataSetFACTURAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrar_factura3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnumfactura As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_factura3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbfacDataSetFACTURAS As Sistema_Facturacion.dbfacDataSetFACTURAS
    Friend WithEvents mostrar_factura3TableAdapter As Sistema_Facturacion.dbfacDataSetFACTURASTableAdapters.mostrar_factura3TableAdapter
End Class
