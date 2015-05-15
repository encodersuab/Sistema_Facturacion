Public Class frmrptVentas

    Private Sub frmrptVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_venta_porFecha' Puede moverla o quitarla según sea necesario.
            Me.mostrar_venta_porFechaTableAdapter.Fill(Me.dbfacDataSet.mostrar_venta_porFecha, dtpFechaInicio.Value, dtpFechaFin.Value, cbfuncionario.Text)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub


    Private Sub dtpFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicio.ValueChanged

    End Sub
    Private Sub dtpFechaFin_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaFin.ValueChanged

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub cbfuncionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbfuncionario.SelectedIndexChanged

    End Sub
End Class