Public Class frmReporteComprobante

    Private Sub frmReporteComprobante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'qrdataset1.TDetalleVenta' table. You can move, or remove it, as needed.
        Me.TDetalleVentaTableAdapter.Fill(Me.qrdataset1.TDetalleVenta)
        'TODO: This line of code loads data into the 'dbfacDataSet.generar_comprobante' table. You can move, or remove it, as needed.
        Me.generar_comprobanteTableAdapter.Fill(Me.dbfacDataSet.generar_comprobante, idventa:=Me.txtidventa.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtidventa.TextChanged

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class