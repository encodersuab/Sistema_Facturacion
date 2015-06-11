Public Class frmReporteCategoriaCampoFerial

    Private Sub frmReporteCategoriaCampoFerial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_categoria_campoferial' Puede moverla o quitarla según sea necesario.
        Me.mostrar_categoria_campoferialTableAdapter.Fill(Me.dbfacDataSet.mostrar_categoria_campoferial)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class