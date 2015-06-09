Public Class frmReporteProductoPostGrado

    Private Sub frmReporteProductoPostGrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_producto_postgrado' Puede moverla o quitarla según sea necesario.
        Me.mostrar_producto_postgradoTableAdapter.Fill(Me.dbfacDataSet.mostrar_producto_postgrado)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class