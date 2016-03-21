Public Class frmReporteCuotas

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmReporteCuotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.mostrar_cliente_servicio_cuota_postgrado' Puede moverla o quitarla según sea necesario.

        ''TODO: esta línea de código carga datos en la tabla 'DataSet1.mostrar_cliente_servicio_cuota_postgrado' Puede moverla o quitarla según sea necesario.
        'Me.mostrar_cliente_servicio_cuota_postgradoTableAdapter.Fill(Me.DataSet1.mostrar_cliente_servicio_cuota_postgrado)
        ''TODO: esta línea de código carga datos en la tabla 'DataSet1.mostrar_cliente_servicio_cuota_postgrado' Puede moverla o quitarla según sea necesario.
        'Me.mostrar_cliente_servicio_cuota_postgradoTableAdapter.Fill(Me.DataSet1.mostrar_cliente_servicio_cuota_postgrado)
        ''TODO: esta línea de código carga datos en la tabla 'DataSet1.mostrar_cliente_servicio_cuota_postgrado' Puede moverla o quitarla según sea necesario.
        'Me.mostrar_cliente_servicio_cuota_postgradoTableAdapter.Fill(Me.DataSet1.mostrar_cliente_servicio_cuota_postgrado)
        ''TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_cliente_servicio_cuota' Puede moverla o quitarla según sea necesario.
        'Me.mostrar_cliente_servicio_cuotaTableAdapter.Fill(Me.dbfacDataSet.mostrar_cliente_servicio_cuota)
        ''TODO: esta línea de código carga datos en la tabla 'DataSet1.mostrar_cliente_servicio_cuota_postgrado' Puede moverla o quitarla según sea necesario.
         'TODO: esta línea de código carga datos en la tabla 'dbfacDataSetLIBROVENTA.mostrar_libroVentas' Puede moverla o quitarla según sea necesario.
        'Me.mostrar_libroVentasTableAdapter.Fill(Me.dbfacDataSetLIBROVENTA.mostrar_libroVentas)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.mostrar_cliente_servicio_cuota_postgrado' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.mostrar_cliente_servicio_cuota_postgrado' Puede moverla o quitarla según sea necesario.
         'TODO: esta línea de código carga datos en la tabla 'DataSet1.mostrar_cliente_servicio_cuota_postgrado' Puede moverla o quitarla según sea necesario.


        'TODO: esta línea de código carga datos en la tabla 'DbfacDataSet.mostrar_producto_postgrado' Puede moverla o quitarla según sea necesario.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click

        'TODO: esta línea de código carga datos en la tabla 'DbfacDataSet.mostrar_cliente_servicio_cuota' Puede moverla o quitarla según sea necesario.
        'Me.mostrar_cliente_servicio_cuota_postgradoTableAdapter.Fill(Me.DataSet1.mostrar_cliente_servicio_cuota_postgrado)
        Me.mostrar_cliente_servicio_cuota_postgradoTableAdapter.Fill(Me.DataSet1.mostrar_cliente_servicio_cuota_postgrado, txtci.Text, txtNombre.Text)

        Me.ReportViewer1.RefreshReport()
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
End Class