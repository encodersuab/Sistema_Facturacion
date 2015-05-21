<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteVentasGeneralRedRubi
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dbfacDataSet = New Sistema_Facturacion.dbfacDataSet()
        Me.mostrar_venta_porFecha_redrubi_generalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mostrar_venta_porFecha_redrubi_generalTableAdapter = New Sistema_Facturacion.dbfacDataSetTableAdapters.mostrar_venta_porFecha_redrubi_generalTableAdapter()
        CType(Me.dbfacDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrar_venta_porFecha_redrubi_generalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(492, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 39)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "MOSTRAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(268, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Fecha Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Fecha de Inicio"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(363, 19)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(95, 20)
        Me.dtpFechaFin.TabIndex = 21
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(131, 19)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(98, 20)
        Me.dtpFechaInicio.TabIndex = 20
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.mostrar_venta_porFecha_redrubi_generalBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Facturacion.rptventasGeneralRedRubi.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 60)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(911, 423)
        Me.ReportViewer1.TabIndex = 25
        '
        'dbfacDataSet
        '
        Me.dbfacDataSet.DataSetName = "dbfacDataSet"
        Me.dbfacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mostrar_venta_porFecha_redrubi_generalBindingSource
        '
        Me.mostrar_venta_porFecha_redrubi_generalBindingSource.DataMember = "mostrar_venta_porFecha_redrubi_general"
        Me.mostrar_venta_porFecha_redrubi_generalBindingSource.DataSource = Me.dbfacDataSet
        '
        'mostrar_venta_porFecha_redrubi_generalTableAdapter
        '
        Me.mostrar_venta_porFecha_redrubi_generalTableAdapter.ClearBeforeFill = True
        '
        'frmReporteVentasGeneralRedRubi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 483)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Name = "frmReporteVentasGeneralRedRubi"
        Me.Text = "frmReporteVentasGeneralRedRubi"
        CType(Me.dbfacDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrar_venta_porFecha_redrubi_generalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_venta_porFecha_redrubi_generalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbfacDataSet As Sistema_Facturacion.dbfacDataSet
    Friend WithEvents mostrar_venta_porFecha_redrubi_generalTableAdapter As Sistema_Facturacion.dbfacDataSetTableAdapters.mostrar_venta_porFecha_redrubi_generalTableAdapter
End Class
