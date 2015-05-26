Public Class frmReporteProductosEmfopesbe

    Private Sub frmReporteProductosEmfopesbe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_producto_emfopesbe' Puede moverla o quitarla según sea necesario.
        Me.mostrar_producto_emfopesbeTableAdapter.Fill(Me.dbfacDataSet.mostrar_producto_emfopesbe)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class