Public Class frmReporteCLiente

    Private Sub frmReporteCLiente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSetREPORTES.mostrar_cliente' Puede moverla o quitarla según sea necesario.
        Me.mostrar_clienteTableAdapter.Fill(Me.dbfacDataSetREPORTES.mostrar_cliente)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class