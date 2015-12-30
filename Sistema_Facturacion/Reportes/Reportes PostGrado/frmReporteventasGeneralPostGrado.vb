Public Class frmReporteventasGeneralPostGrado

    Private Sub frmReporteventasGeneralPostGrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.mostrar_v_XFecha_G_postgrado' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DataSet1.mostrar_v_XFecha_G_postgrado' Puede moverla o quitarla según sea necesario.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_venta_porFecha_postgrado_general' Puede moverla o quitarla según sea necesario.
        Me.mostrar_v_XFecha_G_postgradoTableAdapter.Fill(Me.DataSet1.mostrar_v_XFecha_G_postgrado, dtpFechaInicio.Value, dtpFechaFin.Value)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportViewer1_Load_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportViewer1_Load_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportViewer1_Load_3(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class