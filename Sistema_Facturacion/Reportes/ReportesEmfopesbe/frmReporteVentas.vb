﻿Public Class frmReporteVentas

    Private Sub frmReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbfacDataSet.mostrar_datos_QR' Puede moverla o quitarla según sea necesario.
        Me.mostrar_datos_QRTableAdapter.Fill(Me.dbfacDataSet.mostrar_datos_QR)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class