Public Class frmReporteClientes

    Private Sub frmReporteClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'dtsCategoria.mostrar_cliente' table. You can move, or remove it, as needed.
        Me.mostrar_clienteTableAdapter.Fill(Me.dtsCategoria.mostrar_cliente)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class