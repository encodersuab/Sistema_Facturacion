Public Class frmReporteCategoriaPostGrado

    Private Sub frmReporteCategoriaPostGrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_categoria_postgrado' Puede moverla o quitarla según sea necesario.
        Me.mostrar_categoria_postgradoTableAdapter.Fill(Me.dbfacDataSet.mostrar_categoria_postgrado)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class