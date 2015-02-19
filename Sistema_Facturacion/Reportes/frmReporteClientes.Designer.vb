<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteClientes
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dtsCategoria = New Sistema_Facturacion.dtsCategoria()
        Me.mostrar_clienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mostrar_clienteTableAdapter = New Sistema_Facturacion.dtsCategoriaTableAdapters.mostrar_clienteTableAdapter()
        CType(Me.dtsCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrar_clienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrar_clienteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Facturacion.rptclientes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(698, 433)
        Me.ReportViewer1.TabIndex = 0
        '
        'dtsCategoria
        '
        Me.dtsCategoria.DataSetName = "dtsCategoria"
        Me.dtsCategoria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mostrar_clienteBindingSource
        '
        Me.mostrar_clienteBindingSource.DataMember = "mostrar_cliente"
        Me.mostrar_clienteBindingSource.DataSource = Me.dtsCategoria
        '
        'mostrar_clienteTableAdapter
        '
        Me.mostrar_clienteTableAdapter.ClearBeforeFill = True
        '
        'frmReporteClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 433)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteClientes"
        Me.Text = "frmReporteClientes"
        CType(Me.dtsCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrar_clienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_clienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtsCategoria As Sistema_Facturacion.dtsCategoria
    Friend WithEvents mostrar_clienteTableAdapter As Sistema_Facturacion.dtsCategoriaTableAdapters.mostrar_clienteTableAdapter
End Class
