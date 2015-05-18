Public Class frmReporteVentasGeneral

    Private Sub frmReporteVentasGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
    End Sub


  

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_venta_generalXfecha1' Puede moverla o quitarla según sea necesario.
        Me.mostrar_venta_generalXfecha1TableAdapter.Fill(Me.dbfacDataSet.mostrar_venta_generalXfecha1, dtpInicio.Value, dtpfin.Value)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class