Public Class frmImprimirOrdenPAgo
    Dim i As Integer = 0
    Private Sub frmImprimirOrdenPAgo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmOrdenPago.Show()
    End Sub

    Private Sub frmImprimirOrdenPAgo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim printFont As System.Drawing.Font = New Font("Arial", 10)
        Dim printFont1 As System.Drawing.Font = New Font("Arial", 10, FontStyle.Bold)
        Dim topMargin As Double = e.MarginBounds.Top
        Dim yPos As Double = 0
        Dim linesPerPage As Double = 0
        Dim count As Integer = 0
        Dim texto As String = ""
        Dim texto2 As String = ""
        Dim row As System.Windows.Forms.DataGridViewRow


        Dim prFont As New Font("Arial", 9, FontStyle.Bold)
        Dim prFont1 As New Font("Arial", 12, FontStyle.Bold)
        Dim prFont2 As New Font("Arial", 9)

        e.Graphics.DrawString("SISTEMA DE FACTURACION 'HIVE' ORDEN DE PAGO", prFont1, Brushes.Black, 10, 30)
        e.Graphics.DrawLine(Pens.Black, 10, 50, 900, 50)

        e.Graphics.DrawString("FECHA Y HORA", prFont, Brushes.Black, 10, 55)
        e.Graphics.DrawString("TIPO DOCUMENTO", prFont, Brushes.Black, 10, 70)
        e.Graphics.DrawString("CI / NIT", prFont, Brushes.Black, 10, 85)
        e.Graphics.DrawString("NOMBRE", prFont, Brushes.Black, 10, 100)
        e.Graphics.DrawString("MONTO TOTAL A PAGAR", prFont, Brushes.Black, 10, 115)


        e.Graphics.DrawString("AUTORIZACION:.......................................................................................................", prFont, Brushes.Black, 10, 145)
        e.Graphics.DrawString("ELABORACION:........................................................................................................", prFont, Brushes.Black, 10, 175)
        'e.Graphics.DrawString("FECHA y HORA", prFont, Brushes.Black, 10, 120)

        e.Graphics.DrawString(DateTime.Now.ToString("dd/MMMM/yyyy   hh:mm"), prFont2, Brushes.Black, 180, 55)
        e.Graphics.DrawString(frmOrdenPago.cbTipoDoc.Text, prFont2, Brushes.Black, 180, 70)
        e.Graphics.DrawString(frmOrdenPago.txtNumDoc.Text, prFont2, Brushes.Black, 180, 85)
        e.Graphics.DrawString(frmOrdenPago.txtNombreFac.Text, prFont2, Brushes.Black, 180, 100)
        e.Graphics.DrawString(frmOrdenPago.txttotal.Text + " Bs.", prFont2, Brushes.Black, 180, 115)

        'e.Graphics.DrawString(DateAndTime.TimeOfDay(), prFont, Brushes.Black, 10, 120)

        e.Graphics.DrawLine(Pens.Black, 10, 190, 900, 190)
        'e.Graphics.DrawLine(Pens.Black, 10, 100, 900, 100)

        ' Calculamos el número de líneas que caben en cada página 
        linesPerPage = e.MarginBounds.Height / printFont1.GetHeight(e.Graphics)
        ' Imprimimos las cabeceras
        Dim header As DataGridViewHeaderCell
        

        'yPos = topMargin + (count * printFont1.GetHeight(e.Graphics))
        
        ' Dejamos una línea de separación


        ' Recorremos las filas del DataGridView hasta que llegemos
        ' a las líneas que nos caben en cada página o al final del grid.
        While count < linesPerPage AndAlso i < frmOrdenPago.dgvDetalleOrdenPago.Rows.Count
            For Each column As DataGridViewColumn In frmOrdenPago.dgvDetalleOrdenPago.Columns
                header = column.HeaderCell
                texto2 += vbCrLf + header.FormattedValue.ToString()
            Next
            yPos = 200 + (count * 10)
            e.Graphics.DrawString(texto2, printFont1, System.Drawing.Brushes.Black, 10, yPos)
            row = frmOrdenPago.dgvDetalleOrdenPago.Rows(i)
            texto2 = ""

            For Each celda As System.Windows.Forms.DataGridViewCell In row.Cells
                'Comprobamos que la celda tenga algún valor, en caso de 
                'permitir añadir filas esto es muy importante
                If celda.Value IsNot Nothing Then

                    texto += vbCrLf + celda.Value.ToString()
                End If
            Next

            ' Calculamos la posición en la que se escribe la línea
            'yPos = topMargin + (count * printFont.GetHeight(e.Graphics))
            ' yPos = 205 + (count * 10)

            ' Escribimos la línea con el objeto Graphics
            e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 150, yPos)
            ' Incrementamos los contadores
            texto = ""
            count += 10
            i += 1
        End While

        ' Una vez fuera del bucle comprobamos si nos quedan más filas
        ' por imprimir, si quedan saldrán en la siguente página
        If i < frmOrdenPago.dgvDetalleOrdenPago.Rows.Count Then
            e.HasMorePages = True
        Else
            ' si llegamos al final, se establece HasMorePages a
            ' false para que se acabe la impresión
            e.HasMorePages = False
            ' Es necesario poner el contador a 0 porque, por ejemplo si se hace
            ' una impresión desde PrintPreviewDialog, se vuelve disparar este
            ' evento como si fuese la primera vez, y si i está con el valor de la
            ' última fila del grid no se imprime nada
            i = 0
        End If
    End Sub

    Private Sub PrintPreviewControl1_Click(sender As Object, e As EventArgs) Handles PrintPreviewControl1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintDocument1.Print()
    End Sub
End Class