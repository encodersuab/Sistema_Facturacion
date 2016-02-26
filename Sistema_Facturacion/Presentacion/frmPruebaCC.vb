Public Class frmPruebaCC

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtmonto.TextChanged

    End Sub
    Public Function CalcularFechaParaCC() As String
        'CALCULAR LA FECHA
        Dim x As DateTime = dtpfecha.Value.Date
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtautorizacion.Clear()
        txtllave.Clear()
        txtmonto.Clear()
        txtnit.Clear()
        txtnumero.Clear()
        txtresultCC.Clear()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub frmPruebaCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        txtautorizacion.Text = 20040010113
        txtllave.Text = "442F3w5AggG7644D737asd4BH5677sasdL4%44643(3C3674F4"
        txtmonto.Text = 905.23
        txtnit.Text = 1004141023
        txtnumero.Text = 665
        dtpfecha.Value = "08/01/2007"
    End Sub
End Class