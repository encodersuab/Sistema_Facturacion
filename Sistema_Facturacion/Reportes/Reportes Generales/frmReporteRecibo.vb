Public Class frmReporteRecibo


    Private Sub frmReporteVentasPlanillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_recibo' Puede moverla o quitarla según sea necesario.
        Me.mostrar_reciboTableAdapter.Fill(Me.dbfacDataSet.mostrar_recibo, txtidventa.Text)
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_recibo' Puede moverla o quitarla según sea necesario.
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub
End Class