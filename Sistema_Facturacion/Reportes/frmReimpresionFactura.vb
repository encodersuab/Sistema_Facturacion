Public Class frmReimpresionFactura

    Private Sub frmReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TODO: This line of code loads data into the 'dtsSistema.Mostrar_datos_factura' table. You can move, or remove it, as needed.
        Me.Mostrar_datos_facturaTableAdapter.Fill(Me.dtsSistema.Mostrar_datos_factura, txtidventa.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class