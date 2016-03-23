Public Class frmReportePagos

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click

    End Sub

    Private Sub frmReportePagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSetREPORTES.mostrar_cliente_servicio_pago_postgrado' Puede moverla o quitarla según sea necesario.
        Me.mostrar_cliente_servicio_pago_postgradoTableAdapter.Fill(Me.dbfacDataSetREPORTES.mostrar_cliente_servicio_pago_postgrado, txtci.Text, txtNombre.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class