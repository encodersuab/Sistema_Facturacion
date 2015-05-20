Public Class frmReporteVentasGeneralEmfopesbe

    Private Sub frmReporteVentasGeneralEmfopesbe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_venta_generalXfecha' Puede moverla o quitarla según sea necesario.
        Me.mostrar_venta_generalXfechaTableAdapter.Fill(Me.dbfacDataSet.mostrar_venta_generalXfecha, dtpFechaInicio.Value, dtpFechaFin.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class