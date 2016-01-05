Public Class frmImpuestos

    Private Sub frmImpuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.mostrar_reporte_impuestos' Puede moverla o quitarla según sea necesario.
        
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub btngenerar_Click(sender As Object, e As EventArgs) Handles btngenerar.Click
        Me.mostrar_reporte_impuestosTableAdapter.Fill(Me.DataSet1.mostrar_reporte_impuestos, dtpFechaInicio.Value, dtpFechaFin.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class