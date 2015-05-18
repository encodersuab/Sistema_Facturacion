Public Class frmReporteCuotas

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbservicio.SelectedIndexChanged

    End Sub

    Private Sub frmReporteCuotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'DbfacDataSet.mostrar_producto_postgrado' Puede moverla o quitarla según sea necesario.
        Me.Mostrar_producto_postgradoTableAdapter.Fill(Me.DbfacDataSet.mostrar_producto_postgrado)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click

        'TODO: esta línea de código carga datos en la tabla 'DbfacDataSet.mostrar_cliente_servicio_cuota' Puede moverla o quitarla según sea necesario.
        Me.mostrar_cliente_servicio_cuotaTableAdapter.Fill(Me.DbfacDataSet.mostrar_cliente_servicio_cuota, cbservicio.Text, txtci.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class