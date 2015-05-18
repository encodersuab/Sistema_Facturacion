<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrptVentas
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
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cbfuncionario = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mostrar_venta_porFechaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbfacDataSet = New Sistema_Facturacion.dbfacDataSet()
        Me.mostrar_venta_porFechaTableAdapter = New Sistema_Facturacion.dbfacDataSetTableAdapters.mostrar_venta_porFechaTableAdapter()
        CType(Me.mostrar_venta_porFechaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbfacDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(173, 33)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(98, 20)
        Me.dtpFechaInicio.TabIndex = 0
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(405, 33)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(95, 20)
        Me.dtpFechaFin.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha de Inicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(310, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Final"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(767, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 39)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "MOSTRAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrar_venta_porFechaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Facturacion.rptReporte VentasXFecha.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 71)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1004, 520)
        Me.ReportViewer1.TabIndex = 5
        '
        'cbfuncionario
        '
        Me.cbfuncionario.FormattingEnabled = True
        Me.cbfuncionario.Items.AddRange(New Object() {"UAB", "---"})
        Me.cbfuncionario.Location = New System.Drawing.Point(623, 33)
        Me.cbfuncionario.Name = "cbfuncionario"
        Me.cbfuncionario.Size = New System.Drawing.Size(121, 21)
        Me.cbfuncionario.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(542, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Funcionario"
        '
        'mostrar_venta_porFechaBindingSource
        '
        Me.mostrar_venta_porFechaBindingSource.DataMember = "mostrar_venta_porFecha"
        Me.mostrar_venta_porFechaBindingSource.DataSource = Me.dbfacDataSet
        '
        'dbfacDataSet
        '
        Me.dbfacDataSet.DataSetName = "dbfacDataSet"
        Me.dbfacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mostrar_venta_porFechaTableAdapter
        '
        Me.mostrar_venta_porFechaTableAdapter.ClearBeforeFill = True
        '
        'frmrptVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 587)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbfuncionario)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Name = "frmrptVentas"
        Me.Text = "frmVistaProducto"
        CType(Me.mostrar_venta_porFechaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbfacDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_venta_porFechaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbfacDataSet As Sistema_Facturacion.dbfacDataSet
    Friend WithEvents mostrar_venta_porFechaTableAdapter As Sistema_Facturacion.dbfacDataSetTableAdapters.mostrar_venta_porFechaTableAdapter
    Friend WithEvents cbfuncionario As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
