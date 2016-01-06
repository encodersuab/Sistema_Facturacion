Public Class frmDetalladoVenta

    Private Sub frmDetalladoVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.mostrar_detalleventas' Puede moverla o quitarla según sea necesario.
        'Me.mostrar_detalleventasTableAdapter.Fill(Me.DataSet1.mostrar_detalleventas)

        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btngenerar_Click(sender As Object, e As EventArgs) Handles btngenerar.Click
        Me.mostrar_detalleventasTableAdapter.Fill(Me.DataSet1.mostrar_detalleventas, dtpFechaInicio.Value, dtpFechaFin.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class