Public Class frmrptReImpresionFactura

    Private Sub rptReImpresionFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSetFACTURAS.mostrar_factura0' Puede moverla o quitarla según sea necesario.
       
        Try
            'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_factura' Puede moverla o quitarla según sea necesario.
            Me.mostrar_factura0TableAdapter.Fill(Me.dbfacDataSetFACTURAS.mostrar_factura0, txtNumFactura.Text)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("ingrese un numero de factura")

        End Try





        Me.ReportViewer1.RefreshReport()
    End Sub

    

   
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub
End Class