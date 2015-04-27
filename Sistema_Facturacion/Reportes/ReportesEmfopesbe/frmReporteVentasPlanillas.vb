Public Class frmReporteVentasPlanillas

  
    Private Sub frmReporteVentasPlanillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_recibo' Puede moverla o quitarla según sea necesario.
        Me.mostrar_reciboTableAdapter.Fill(Me.dbfacDataSet.mostrar_recibo, txtidventa.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class