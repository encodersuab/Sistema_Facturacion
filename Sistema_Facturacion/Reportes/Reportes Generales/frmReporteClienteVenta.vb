Public Class frmReporteClienteVenta

    Private Sub frmReporteClienteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSetREPORTES.mostrar_cliente_venta' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSetREPORTES.mostrar_cliente_venta' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSetREPORTES.mostrar_cliente_venta' Puede moverla o quitarla según sea necesario.
        '  Me.mostrar_cliente_ventaTableAdapter.Fill(Me.dbfacDataSetREPORTES.mostrar_cliente_venta)
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSetREPORTES.mostrar_cliente' Puede moverla o quitarla según sea necesario.


        ' Me.ReportViewer1.RefreshReport()
        '  Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBuscarCi_Click(sender As Object, e As EventArgs) Handles btnBuscarCi.Click
        Me.mostrar_cliente_ventaTableAdapter.Fill(Me.dbfacDataSetREPORTES.mostrar_cliente_venta, txtBuscarCI.Text)
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSetREPORTES.mostrar_cliente' Puede moverla o quitarla según sea necesario.


        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load_1(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class