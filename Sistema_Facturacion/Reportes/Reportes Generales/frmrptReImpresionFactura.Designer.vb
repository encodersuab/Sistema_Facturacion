<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrptReImpresionFactura
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
        Me.txtNumFactura = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dbfacDataSetFACTURAS = New Sistema_Facturacion.dbfacDataSetFACTURAS()
        Me.mostrar_factura0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mostrar_factura0TableAdapter = New Sistema_Facturacion.dbfacDataSetFACTURASTableAdapters.mostrar_factura0TableAdapter()
        CType(Me.dbfacDataSetFACTURAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrar_factura0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNumFactura
        '
        Me.txtNumFactura.Location = New System.Drawing.Point(29, 32)
        Me.txtNumFactura.Name = "txtNumFactura"
        Me.txtNumFactura.Size = New System.Drawing.Size(100, 20)
        Me.txtNumFactura.TabIndex = 2
        Me.txtNumFactura.Visible = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrar_factura0BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Facturacion.rptFac0.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(712, 441)
        Me.ReportViewer1.TabIndex = 3
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
        'frmrptReImpresionFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 441)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.txtNumFactura)
        Me.Name = "frmrptReImpresionFactura"
        Me.Text = "rptReImpresionFactura"
        CType(Me.dbfacDataSetFACTURAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrar_factura0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumFactura As System.Windows.Forms.TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_factura0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbfacDataSetFACTURAS As Sistema_Facturacion.dbfacDataSetFACTURAS
    Friend WithEvents mostrar_factura0TableAdapter As Sistema_Facturacion.dbfacDataSetFACTURASTableAdapters.mostrar_factura0TableAdapter
End Class
