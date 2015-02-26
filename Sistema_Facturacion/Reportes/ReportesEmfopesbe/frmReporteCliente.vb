Public Class frmReporteCliente

    Private Sub frmReporteCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_cliente' Puede moverla o quitarla según sea necesario.
        Me.mostrar_clienteTableAdapter.Fill(Me.dbfacDataSet.mostrar_cliente)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class