Public Class frmImprimirOrdenPAgo
    Dim i As Integer = 0
    Private Sub frmImprimirOrdenPAgo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmOrdenPago.Show()
    End Sub

    Private Sub frmImprimirOrdenPAgo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim printFont As System.Drawing.Font = New Font("Arial", 8)
        Dim topMargin As Double = e.MarginBounds.Top
        Dim yPos As Double = 0
        Dim linesPerPage As Double = 0
        Dim count As Integer = 0
        Dim texto As String = ""
        Dim texto2 As String = ""
        Dim row As System.Windows.Forms.DataGridViewRow


        Dim prFont As New Font("Arial", 8, FontStyle.Bold)
        e.Graphics.DrawString("TIPO DOCUMENTO", prFont, Brushes.Black, 10, 20)
        e.Graphics.DrawString("NUMERO DOCUMENTO", prFont, Brushes.Black, 10, 35)
        e.Graphics.DrawString("NOMBRE DOCUMENTO", prFont, Brushes.Black, 10, 50)

        e.Graphics.DrawString("MONTO TOTAL A PAGAR", prFont, Brushes.Black, 10, 70)

        e.Graphics.DrawString(frmOrdenPago.cbTipoDoc.Text, prFont, Brushes.Black, 150, 20)
        e.Graphics.DrawString(frmOrdenPago.txtNumDoc.Text, prFont, Brushes.Black, 150, 35)
        e.Graphics.DrawString(frmOrdenPago.txtNombreFac.Text, prFont, Brushes.Black, 150, 50)

        e.Graphics.DrawString(frmOrdenPago.txttotal.Text, prFont, Brushes.Black, 150, 70)

        ' Calculamos el número de líneas que caben en cada página 
        linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics)
        ' Imprimimos las cabeceras
        Dim header As DataGridViewHeaderCell
        For Each column As DataGridViewColumn In frmOrdenPago.dgvDetalleOrdenPago.Columns
            header = column.HeaderCell
            texto += vbTab + header.FormattedValue.ToString()
        Next

        yPos = topMargin + (count * printFont.GetHeight(e.Graphics))
        e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 10, yPos)
        ' Dejamos una línea de separación
        count += 2

        ' Recorremos las filas del DataGridView hasta que llegemos
        ' a las líneas que nos caben en cada página o al final del grid.
        While count < linesPerPage AndAlso i < frmOrdenPago.dgvDetalleOrdenPago.Rows.Count
            row = frmOrdenPago.dgvDetalleOrdenPago.Rows(i)
            texto = ""

            For Each celda As System.Windows.Forms.DataGridViewCell In row.Cells
                'Comprobamos que la celda tenga algún valor, en caso de 
                'permitir añadir filas esto es muy importante
                If celda.Value IsNot Nothing Then

                    texto += vbTab + celda.Value.ToString()
                End If
            Next

            ' Calculamos la posición en la que se escribe la línea
            yPos = topMargin + (count * printFont.GetHeight(e.Graphics))

            ' Escribimos la línea con el objeto Graphics
            e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 10, yPos)
            ' Incrementamos los contadores
            count += 1
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