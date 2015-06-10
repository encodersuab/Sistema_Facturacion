Public Class frmReporteProductosRedRubi

    Private Sub frmReporteProductosRedRubi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_producto_redrubi' Puede moverla o quitarla según sea necesario.
        Me.mostrar_producto_redrubiTableAdapter.Fill(Me.dbfacDataSet.mostrar_producto_redrubi)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class