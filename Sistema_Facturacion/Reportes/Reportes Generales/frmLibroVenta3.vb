Public Class frmLibroVenta3

    Private Sub frmLibroVenta3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSetLIBROVENTA.mostrar_libroVentas3' Puede moverla o quitarla según sea necesario.

    End Sub

    Private Sub btngenerar_Click(sender As Object, e As EventArgs) Handles btngenerar.Click
        Me.mostrar_libroVentas3TableAdapter.Fill(Me.dbfacDataSetLIBROVENTA.mostrar_libroVentas3, dtpFechaInicio.Value, dtpFechaFin.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class