Public Class frmReporteCategoria

    Private Sub frmReporteCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dtsCategoria.mostrar_categoria' table. You can move, or remove it, as needed.
        Me.mostrar_categoriaTableAdapter.Fill(Me.dtsCategoria.mostrar_categoria)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class