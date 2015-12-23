Public Class frmFactura2

    Private Sub frmFactura2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_factura2' Puede moverla o quitarla según sea necesario.
        Me.mostrar_factura2TableAdapter.Fill(Me.dbfacDataSet.mostrar_factura2, txtnumfactura.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class