<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLibroVenta0
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.btngenerar = New System.Windows.Forms.Button()
        Me.dbfacDataSetLIBROVENTA = New Sistema_Facturacion.dbfacDataSetLIBROVENTA()
        Me.mostrar_libroVentas0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mostrar_libroVentas0TableAdapter = New Sistema_Facturacion.dbfacDataSetLIBROVENTATableAdapters.mostrar_libroVentas0TableAdapter()
        CType(Me.dbfacDataSetLIBROVENTA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrar_libroVentas0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.mostrar_libroVentas0BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Facturacion.rptLibroVenta0.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1058, 401)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(814, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Fecha Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(624, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Fecha de Inicio"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(882, 30)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(95, 20)
        Me.dtpFechaFin.TabIndex = 40
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(710, 30)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(98, 20)
        Me.dtpFechaInicio.TabIndex = 39
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(983, 27)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(75, 23)
        Me.btngenerar.TabIndex = 38
        Me.btngenerar.Text = "generar"
        Me.btngenerar.UseVisualStyleBackColor = True
        '
        'dbfacDataSetLIBROVENTA
        '
        Me.dbfacDataSetLIBROVENTA.DataSetName = "dbfacDataSetLIBROVENTA"
        Me.dbfacDataSetLIBROVENTA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mostrar_libroVentas0BindingSource
        '
        Me.mostrar_libroVentas0BindingSource.DataMember = "mostrar_libroVentas0"
        Me.mostrar_libroVentas0BindingSource.DataSource = Me.dbfacDataSetLIBROVENTA
        '
        'mostrar_libroVentas0TableAdapter
        '
        Me.mostrar_libroVentas0TableAdapter.ClearBeforeFill = True
        '
        'frmLibroVenta0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 401)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.btngenerar)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmLibroVenta0"
        Me.Text = "frmLibroVenta0"
        CType(Me.dbfacDataSetLIBROVENTA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrar_libroVentas0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents btngenerar As System.Windows.Forms.Button
    Friend WithEvents mostrar_libroVentas0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbfacDataSetLIBROVENTA As Sistema_Facturacion.dbfacDataSetLIBROVENTA
    Friend WithEvents mostrar_libroVentas0TableAdapter As Sistema_Facturacion.dbfacDataSetLIBROVENTATableAdapters.mostrar_libroVentas0TableAdapter
End Class
