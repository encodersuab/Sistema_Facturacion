﻿Public Class frmReporteVentasGeneralCampoFerial

    Private Sub frmReporteVentasGeneralCampoFerial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_venta_porFecha_campoferial_general' Puede moverla o quitarla según sea necesario.
        Me.mostrar_venta_porFecha_campoferial_generalTableAdapter.Fill(Me.dbfacDataSet.mostrar_venta_porFecha_campoferial_general, dtpFechaInicio.Value, dtpFechaFin.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class