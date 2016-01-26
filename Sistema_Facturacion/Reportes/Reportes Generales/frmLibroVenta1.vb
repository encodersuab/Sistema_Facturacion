Public Class frmLibroVenta1

    Private Sub frmLibroVenta1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSetLIBROVENTA.mostrar_libroVentas1' Puede moverla o quitarla según sea necesario.

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub btngenerar_Click(sender As Object, e As EventArgs) Handles btngenerar.Click
        Me.mostrar_libroVentas1TableAdapter.Fill(Me.dbfacDataSetLIBROVENTA.mostrar_libroVentas1, dtpFechaInicio.Value, dtpFechaFin.Value)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class