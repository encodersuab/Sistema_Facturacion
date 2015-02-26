Public Class frmrptReImpresionFactura

    Private Sub rptReImpresionFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click

        Try
            'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_factura' Puede moverla o quitarla según sea necesario.
            Me.mostrar_facturaTableAdapter.Fill(Me.dbfacDataSet.mostrar_factura, txtNumFactura.Text)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("ingrese un numero de factura")

        End Try


    End Sub
End Class