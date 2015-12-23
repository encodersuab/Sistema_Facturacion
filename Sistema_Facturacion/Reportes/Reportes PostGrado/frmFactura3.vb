Public Class frmFactura3

    Private Sub frmFactura3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_factura3' Puede moverla o quitarla según sea necesario.
        Me.mostrar_factura3TableAdapter.Fill(Me.dbfacDataSet.mostrar_factura3, txtnumfactura.Text)

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportViewer1_Load_1(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class