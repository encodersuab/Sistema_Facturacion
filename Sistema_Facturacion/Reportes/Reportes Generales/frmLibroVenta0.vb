Public Class frmLibroVenta0

    Private Sub frmLibroVenta0_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSetLIBROVENTA.mostrar_libroVentas0' Puede moverla o quitarla según sea necesario.

    End Sub

    Private Sub btngenerar_Click(sender As Object, e As EventArgs) Handles btngenerar.Click
        Me.mostrar_libroVentas0TableAdapter.Fill(Me.dbfacDataSetLIBROVENTA.mostrar_libroVentas0, dtpFechaInicio.Value, dtpFechaFin.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class