Public Class frmReporteProducto

    Private Sub frmReporteProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dtsCategoria.mostrar_producto_emfopesbe' table. You can move, or remove it, as needed.
        Me.mostrar_producto_emfopesbeTableAdapter.Fill(Me.dtsCategoria.mostrar_producto_emfopesbe)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class