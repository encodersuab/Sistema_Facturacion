Public Class frmLibroVentas

    Private Sub frmLibroVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSetLIBROVENTA.mostrar_libroVentas' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSetLIBROVENTA.mostrar_libroVentas' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSetLIBROVENTA.mostrar_libroVentas' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSetLIBROVENTA.mostrar_libroVentas' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_datos_QR' Puede moverla o quitarla según sea necesario.

    End Sub

    Private Sub btngenerar_Click(sender As Object, e As EventArgs) Handles btngenerar.Click

        Me.mostrar_libroVentasTableAdapter.Fill(Me.dbfacDataSetLIBROVENTA.mostrar_libroVentas, dtpFechaInicio.Value, dtpFechaFin.Value)
            Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub dtpFechaFin_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaFin.ValueChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub dtpFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicio.ValueChanged

    End Sub
End Class