Public Class frmReporteventasGeneralPostGrado

    Private Sub frmReporteventasGeneralPostGrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_v_XFecha_G_postgrado' Puede moverla o quitarla según sea necesario.
       
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_venta_porFecha_postgrado_general' Puede moverla o quitarla según sea necesario.
        Me.mostrar_v_XFecha_G_postgradoTableAdapter.Fill(Me.dbfacDataSet.mostrar_v_XFecha_G_postgrado, dtpFechaInicio.Value, dtpFechaFin.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class