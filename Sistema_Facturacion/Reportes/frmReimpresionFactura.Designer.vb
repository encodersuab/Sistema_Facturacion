<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReimpresionFactura
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
        Me.Mostrar_datos_facturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtsSistema = New Sistema_Facturacion.dtsSistema()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Mostrar_datos_facturaTableAdapter = New Sistema_Facturacion.dtsSistemaTableAdapters.Mostrar_datos_facturaTableAdapter()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Mostrar_datos_facturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtsSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mostrar_datos_facturaBindingSource
        '
        Me.Mostrar_datos_facturaBindingSource.DataMember = "Mostrar_datos_factura"
        Me.Mostrar_datos_facturaBindingSource.DataSource = Me.dtsSistema
        '
        'dtsSistema
        '
        Me.dtsSistema.DataSetName = "dtsSistema"
        Me.dtsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Mostrar_datos_facturaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Facturacion.rptReimpresionFactura.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-12, 44)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1150, 315)
        Me.ReportViewer1.TabIndex = 0
        '
        'Mostrar_datos_facturaTableAdapter
        '
        Me.Mostrar_datos_facturaTableAdapter.ClearBeforeFill = True
        '
        'txtidventa
        '
        Me.txtidventa.Location = New System.Drawing.Point(80, 13)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.Size = New System.Drawing.Size(100, 20)
        Me.txtidventa.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(232, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmReimpresionFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 371)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtidventa)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReimpresionFactura"
        Me.Text = "frmReporteVentas"
        CType(Me.Mostrar_datos_facturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtsSistema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Mostrar_datos_facturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtsSistema As Sistema_Facturacion.dtsSistema
    Friend WithEvents Mostrar_datos_facturaTableAdapter As Sistema_Facturacion.dtsSistemaTableAdapters.Mostrar_datos_facturaTableAdapter
    Friend WithEvents txtidventa As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
