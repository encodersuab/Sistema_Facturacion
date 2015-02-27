Public Class frmReporteUsuarios

    Private Sub frmReporteUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_usuario' Puede moverla o quitarla según sea necesario.
        Me.mostrar_usuarioTableAdapter.Fill(Me.dbfacDataSet.mostrar_usuario)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class