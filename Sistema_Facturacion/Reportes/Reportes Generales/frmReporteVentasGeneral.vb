Public Class frmReporteVentasGeneral

    Private Sub frmReporteVentasGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.mostrar_v_XFecha_G' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSetLIBROVENTA.mostrar_libroVentas' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_v_XFecha_G' Puede moverla o quitarla según sea necesario.
        'Me.mostrar_v_XFecha_GTableAdapter.Fill(Me.dbfacDataSet.mostrar_v_XFecha_G)
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_v_XFecha_G' Puede moverla o quitarla según sea necesario.
        'Me.mostrar_v_XFecha_GTableAdapter.Fill(Me.dbfacDataSet.mostrar_v_XFecha_G)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
8:      'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_venta_porFecha_General' Puede moverla o quitarla según sea necesario.
        Me.mostrar_v_XFecha_GTableAdapter.Fill(Me.DataSet1.mostrar_v_XFecha_G, dtpFechaInicio.Value, dtpFechaFin.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportViewer1_Load_1(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class