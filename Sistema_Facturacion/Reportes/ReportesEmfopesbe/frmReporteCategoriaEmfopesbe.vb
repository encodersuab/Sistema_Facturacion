Public Class frmReporteCategoriaEmfopesbe

    Private Sub frmReporteCategoriaEmfopesbe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_categoria' Puede moverla o quitarla según sea necesario.
        Me.mostrar_categoriaTableAdapter.Fill(Me.dbfacDataSet.mostrar_categoria)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class