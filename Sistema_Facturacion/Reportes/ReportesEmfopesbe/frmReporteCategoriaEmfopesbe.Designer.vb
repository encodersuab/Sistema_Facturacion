﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteCategoriaEmfopesbe
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
        Me.dbfacDataSet = New Sistema_Facturacion.dbfacDataSet()
        Me.mostrar_categoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mostrar_categoriaTableAdapter = New Sistema_Facturacion.dbfacDataSetTableAdapters.mostrar_categoriaTableAdapter()
        CType(Me.dbfacDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrar_categoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrar_categoriaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Facturacion.rptReportecategoriaEmfopesbe.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(671, 476)
        Me.ReportViewer1.TabIndex = 0
        '
        'dbfacDataSet
        '
        Me.dbfacDataSet.DataSetName = "dbfacDataSet"
        Me.dbfacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mostrar_categoriaBindingSource
        '
        Me.mostrar_categoriaBindingSource.DataMember = "mostrar_categoria"
        Me.mostrar_categoriaBindingSource.DataSource = Me.dbfacDataSet
        '
        'mostrar_categoriaTableAdapter
        '
        Me.mostrar_categoriaTableAdapter.ClearBeforeFill = True
        '
        'frmReporteCategoriaEmfopesbe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 476)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteCategoriaEmfopesbe"
        Me.Text = "frmReporteCategoriaEmfopesbe"
        CType(Me.dbfacDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrar_categoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_categoriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbfacDataSet As Sistema_Facturacion.dbfacDataSet
    Friend WithEvents mostrar_categoriaTableAdapter As Sistema_Facturacion.dbfacDataSetTableAdapters.mostrar_categoriaTableAdapter
End Class
