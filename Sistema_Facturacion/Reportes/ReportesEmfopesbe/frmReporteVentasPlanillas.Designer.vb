<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteVentasPlanillas
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
        Me.mostrar_reciboBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbfacDataSet = New Sistema_Facturacion.dbfacDataSet()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        Me.mostrar_reciboTableAdapter = New Sistema_Facturacion.dbfacDataSetTableAdapters.mostrar_reciboTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.mostrar_reciboBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbfacDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mostrar_reciboBindingSource
        '
        Me.mostrar_reciboBindingSource.DataMember = "mostrar_recibo"
        Me.mostrar_reciboBindingSource.DataSource = Me.dbfacDataSet
        '
        'dbfacDataSet
        '
        Me.dbfacDataSet.DataSetName = "dbfacDataSet"
        Me.dbfacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtidventa
        '
        Me.txtidventa.Location = New System.Drawing.Point(78, 13)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.Size = New System.Drawing.Size(100, 20)
        Me.txtidventa.TabIndex = 2
        Me.txtidventa.Visible = False
        '
        'mostrar_reciboTableAdapter
        '
        Me.mostrar_reciboTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrar_reciboBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Facturacion.rptreporte.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(670, 427)
        Me.ReportViewer1.TabIndex = 3
        '
        'frmReporteVentasPlanillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 427)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.txtidventa)
        Me.Name = "frmReporteVentasPlanillas"
        Me.Text = "frmReporteVentasPlanillas"
        CType(Me.mostrar_reciboBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbfacDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mostrar_reciboBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbfacDataSet As Sistema_Facturacion.dbfacDataSet
    Friend WithEvents txtidventa As System.Windows.Forms.TextBox
    Friend WithEvents mostrar_reciboTableAdapter As Sistema_Facturacion.dbfacDataSetTableAdapters.mostrar_reciboTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
