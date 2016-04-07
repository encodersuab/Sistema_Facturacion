<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteClienteVenta
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
        Me.mostrar_cliente_ventaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbfacDataSetREPORTES = New Sistema_Facturacion.dbfacDataSetREPORTES()
        Me.btnBuscarCi = New System.Windows.Forms.Button()
        Me.txtBuscarCI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.mostrar_cliente_ventaTableAdapter = New Sistema_Facturacion.dbfacDataSetREPORTESTableAdapters.mostrar_cliente_ventaTableAdapter()
        CType(Me.mostrar_cliente_ventaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbfacDataSetREPORTES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mostrar_cliente_ventaBindingSource
        '
        Me.mostrar_cliente_ventaBindingSource.DataMember = "mostrar_cliente_venta"
        Me.mostrar_cliente_ventaBindingSource.DataSource = Me.dbfacDataSetREPORTES
        '
        'dbfacDataSetREPORTES
        '
        Me.dbfacDataSetREPORTES.DataSetName = "dbfacDataSetREPORTES"
        Me.dbfacDataSetREPORTES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnBuscarCi
        '
        Me.btnBuscarCi.Location = New System.Drawing.Point(805, 28)
        Me.btnBuscarCi.Name = "btnBuscarCi"
        Me.btnBuscarCi.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarCi.TabIndex = 1
        Me.btnBuscarCi.Text = "BUSCAR"
        Me.btnBuscarCi.UseVisualStyleBackColor = True
        '
        'txtBuscarCI
        '
        Me.txtBuscarCI.Location = New System.Drawing.Point(633, 31)
        Me.txtBuscarCI.Name = "txtBuscarCI"
        Me.txtBuscarCI.Size = New System.Drawing.Size(166, 20)
        Me.txtBuscarCI.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(610, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CI"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrar_cliente_ventaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Facturacion.rptClienteDetalleVenta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(921, 418)
        Me.ReportViewer1.TabIndex = 4
        '
        'mostrar_cliente_ventaTableAdapter
        '
        Me.mostrar_cliente_ventaTableAdapter.ClearBeforeFill = True
        '
        'frmReporteClienteVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 418)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscarCI)
        Me.Controls.Add(Me.btnBuscarCi)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteClienteVenta"
        Me.Text = "frmReporteClienteVenta"
        CType(Me.mostrar_cliente_ventaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbfacDataSetREPORTES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscarCi As System.Windows.Forms.Button
    Friend WithEvents txtBuscarCI As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_cliente_ventaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbfacDataSetREPORTES As Sistema_Facturacion.dbfacDataSetREPORTES
    Friend WithEvents mostrar_cliente_ventaTableAdapter As Sistema_Facturacion.dbfacDataSetREPORTESTableAdapters.mostrar_cliente_ventaTableAdapter
End Class
