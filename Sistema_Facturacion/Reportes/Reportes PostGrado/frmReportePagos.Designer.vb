﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportePagos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtci = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dbfacDataSetREPORTES = New Sistema_Facturacion.dbfacDataSetREPORTES()
        Me.mostrar_cliente_servicio_pago_postgradoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mostrar_cliente_servicio_pago_postgradoTableAdapter = New Sistema_Facturacion.dbfacDataSetREPORTESTableAdapters.mostrar_cliente_servicio_pago_postgradoTableAdapter()
        CType(Me.dbfacDataSetREPORTES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrar_cliente_servicio_pago_postgradoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(485, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "NOMBRE DEL CURSO"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(610, 48)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(217, 20)
        Me.txtNombre.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(587, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "CI"
        '
        'txtci
        '
        Me.txtci.Location = New System.Drawing.Point(610, 22)
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(217, 20)
        Me.txtci.TabIndex = 9
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(833, 46)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 22)
        Me.btnbuscar.TabIndex = 8
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrar_cliente_servicio_pago_postgradoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Facturacion.rptPagoPG.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(923, 333)
        Me.ReportViewer1.TabIndex = 11
        '
        'dbfacDataSetREPORTES
        '
        Me.dbfacDataSetREPORTES.DataSetName = "dbfacDataSetREPORTES"
        Me.dbfacDataSetREPORTES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mostrar_cliente_servicio_pago_postgradoBindingSource
        '
        Me.mostrar_cliente_servicio_pago_postgradoBindingSource.DataMember = "mostrar_cliente_servicio_pago_postgrado"
        Me.mostrar_cliente_servicio_pago_postgradoBindingSource.DataSource = Me.dbfacDataSetREPORTES
        '
        'mostrar_cliente_servicio_pago_postgradoTableAdapter
        '
        Me.mostrar_cliente_servicio_pago_postgradoTableAdapter.ClearBeforeFill = True
        '
        'frmReportePagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 333)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtci)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReportePagos"
        Me.Text = "frmReportePagos"
        CType(Me.dbfacDataSetREPORTES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrar_cliente_servicio_pago_postgradoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtci As System.Windows.Forms.TextBox
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_cliente_servicio_pago_postgradoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbfacDataSetREPORTES As Sistema_Facturacion.dbfacDataSetREPORTES
    Friend WithEvents mostrar_cliente_servicio_pago_postgradoTableAdapter As Sistema_Facturacion.dbfacDataSetREPORTESTableAdapters.mostrar_cliente_servicio_pago_postgradoTableAdapter
End Class
