Public Class frmFactura0

    Private Sub frmFactura0_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSetFACTURAS.mostrar_factura0' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_factura' Puede moverla o quitarla según sea necesario.
        Me.mostrar_factura0TableAdapter.Fill(Me.dbfacDataSetFACTURAS.mostrar_factura0, txtnumfactura.Text)



        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportViewer1_Load_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportViewer1_Load_2(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class