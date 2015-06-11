Public Class frmReporteProductosCampoFerial

    Private Sub frmReporteProductosCampoFerial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_producto_capoferial' Puede moverla o quitarla según sea necesario.
        Me.mostrar_producto_capoferialTableAdapter.Fill(Me.dbfacDataSet.mostrar_producto_capoferial)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class