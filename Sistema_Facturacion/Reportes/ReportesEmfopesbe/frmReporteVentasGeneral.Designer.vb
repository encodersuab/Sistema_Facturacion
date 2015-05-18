<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteVentasGeneral
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpfin = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dbfacDataSet = New Sistema_Facturacion.dbfacDataSet()
        Me.mostrar_venta_generalXfecha1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mostrar_venta_generalXfecha1TableAdapter = New Sistema_Facturacion.dbfacDataSetTableAdapters.mostrar_venta_generalXfecha1TableAdapter()
        CType(Me.dbfacDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrar_venta_generalXfecha1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrar_venta_generalXfecha1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Facturacion.rptVentasGeneral.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 110)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(867, 462)
        Me.ReportViewer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(575, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 43)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Mostrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpInicio
        '
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(147, 48)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(94, 20)
        Me.dtpInicio.TabIndex = 2
        '
        'dtpfin
        '
        Me.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfin.Location = New System.Drawing.Point(393, 48)
        Me.dtpfin.Name = "dtpfin"
        Me.dtpfin.Size = New System.Drawing.Size(96, 20)
        Me.dtpfin.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Fecha Inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(290, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha Fin"
        '
        'dbfacDataSet
        '
        Me.dbfacDataSet.DataSetName = "dbfacDataSet"
        Me.dbfacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mostrar_venta_generalXfecha1BindingSource
        '
        Me.mostrar_venta_generalXfecha1BindingSource.DataMember = "mostrar_venta_generalXfecha1"
        Me.mostrar_venta_generalXfecha1BindingSource.DataSource = Me.dbfacDataSet
        '
        'mostrar_venta_generalXfecha1TableAdapter
        '
        Me.mostrar_venta_generalXfecha1TableAdapter.ClearBeforeFill = True
        '
        'frmReporteVentasGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 569)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpfin)
        Me.Controls.Add(Me.dtpInicio)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteVentasGeneral"
        Me.Text = "frmReporteVentasGeneral"
        CType(Me.dbfacDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrar_venta_generalXfecha1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_venta_generalXfecha1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbfacDataSet As Sistema_Facturacion.dbfacDataSet
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mostrar_venta_generalXfecha1TableAdapter As Sistema_Facturacion.dbfacDataSetTableAdapters.mostrar_venta_generalXfecha1TableAdapter
End Class
