Public Class frmReporteCuotas

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmReporteCuotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSetREPORTES.mostrar_cliente_servicio_cuota_postgrado' Puede moverla o quitarla según sea necesario.
        'Me.mostrar_cliente_servicio_cuota_postgradoTableAdapter.Fill(Me.dbfacDataSetREPORTES.mostrar_cliente_servicio_cuota_postgrado, txtci.Text, txtNombre.Text)
        ''TODO: esta línea de código carga datos en la tabla 'dbfacDataSetLIBROVENTA.mostrar_libroVentas' Puede moverla o quitarla según sea necesario.


        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Me.mostrar_cliente_servicio_cuota_postgradoTableAdapter.Fill(Me.dbfacDataSetREPORTES.mostrar_cliente_servicio_cuota_postgrado, txtci.Text, txtNombre.Text)

        Me.ReportViewer1.RefreshReport()
        'TODO: esta línea de código carga datos en la tabla 'DbfacDataSet.mostrar_cliente_servicio_cuota' Puede moverla o quitarla según sea necesario.
        'Me.mostrar_cliente_servicio_cuota_postgradoTableAdapter.Fill(Me.DataSet1.mostrar_cliente_servicio_cuota_postgrado)
        'Me.mostrar_cliente_servicio_cuota_postgradoTableAdapter.Fill(Me.DataSet1.mostrar_cliente_servicio_cuota_postgrado, txtci.Text, txtNombre.Text)

        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtci_TextChanged(sender As Object, e As EventArgs) Handles txtci.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frmProductoPostGrado.txtTag.Text = "2"
        frmProductoPostGrado.ShowDialog()
    End Sub
End Class