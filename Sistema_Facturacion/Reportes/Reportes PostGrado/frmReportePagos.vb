Public Class frmReportePagos

    Private Sub frmReportePagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.mostrar_cliente_servicio_pago_postgrado' Puede moverla o quitarla según sea necesario.


    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Me.mostrar_cliente_servicio_pago_postgradoTableAdapter.Fill(Me.DataSet1.mostrar_cliente_servicio_pago_postgrado, txtci.Text, txtNombre.Text)


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class