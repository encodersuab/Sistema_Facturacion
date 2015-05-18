Public Class frmrptReImpresionFactura

    Private Sub rptReImpresionFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_factura' Puede moverla o quitarla según sea necesario.
            Me.mostrar_facturaTableAdapter.Fill(Me.dbfacDataSet.mostrar_factura, txtNumFactura.Text)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("ingrese un numero de factura")

        End Try





    End Sub

    

   
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class