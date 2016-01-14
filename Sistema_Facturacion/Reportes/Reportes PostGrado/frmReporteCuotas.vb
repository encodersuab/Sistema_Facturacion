Public Class frmReporteCuotas

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmReporteCuotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.mostrar_cliente_servicio_cuota_postgrado' Puede moverla o quitarla según sea necesario.


        'TODO: esta línea de código carga datos en la tabla 'DbfacDataSet.mostrar_producto_postgrado' Puede moverla o quitarla según sea necesario.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click

        'TODO: esta línea de código carga datos en la tabla 'DbfacDataSet.mostrar_cliente_servicio_cuota' Puede moverla o quitarla según sea necesario.
        Me.mostrar_cliente_servicio_cuota_postgradoTableAdapter.Fill(Me.DataSet1.mostrar_cliente_servicio_cuota_postgrado, txtci.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class