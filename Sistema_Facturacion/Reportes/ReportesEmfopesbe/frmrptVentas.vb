﻿Public Class frmrptVentas

  
 
    Private Sub dtpFechaFin_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaFin.ValueChanged

    End Sub

    Private Sub frmrptVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_venta_porFecha' Puede moverla o quitarla según sea necesario.
            Me.mostrar_venta_porFechaTableAdapter.Fill(Me.dbfacDataSet.mostrar_venta_porFecha, dtpFechaInicio.Value, dtpFechaFin.Value)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class