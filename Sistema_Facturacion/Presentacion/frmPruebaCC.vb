Public Class frmPruebaCC

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtfecha.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtmonto.TextChanged

    End Sub
    Public Function CalcularFechaParaCC() As String
        'CALCULAR LA FECHA
        Dim x As DateTime = DateTime.Now
        Dim FECHA As Integer = ((x.Year * 100) + x.Month) * 100 + x.Day
        Return FECHA.ToString()

    End Function


    Public Function calcularMontoCC(ByRef monto As String) As String
        'CALCULAR EL MONTO
        'System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        Dim real As Double = Double.Parse(monto)
        real = Math.Round(real, 0)
        Dim total As String = real.ToString()
        Return real.ToString()

    End Function
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fecha, monto As String
        fecha = CalcularFechaParaCC()
        monto = calcularMontoCC(txtmonto.Text)

        txtresultCC.Text = CC.generar(txtautorizacion.Text, txtnumero.Text, txtnit.Text, fecha, monto, txtllave.Text)
    End Sub
End Class