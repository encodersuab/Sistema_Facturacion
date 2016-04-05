Public Class frmOrdenPago

    Dim i As Integer = -1
    Private dt As New DataTable

    Dim dt2 As New DataTable
    Dim dr2 As DataRow
    'Dim dcCiNit As New DataColumn("CI/NIT", GetType(System.String))
    'Dim dcNumDocumento As New DataColumn("NUMERO DOC", GetType(System.String))
    'Dim dcNombre As New DataColumn("NOMBRE", GetType(System.String))
    Dim dcCategoria As New DataColumn("CATEGORIA", GetType(System.String))
    Dim dcProducto As New DataColumn("PRODUCTO", GetType(System.String))
    Dim dcCantidad As New DataColumn("CANTIDAD ", GetType(System.Double))
    Dim dcPrecioUnitario As New DataColumn("PRECIO UNITARIO", GetType(System.Double))
    Dim dcTotalParcial As New DataColumn("TOTAL PARCIAL", GetType(System.Double))

    Private Sub frmOrdenPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dt2.Columns.Add(dcCiNit)
        'dt2.Columns.Add(dcNumDocumento)
        'dt2.Columns.Add(dcNombre)
        dt2.Columns.Add(dcCategoria)
        dt2.Columns.Add(dcProducto)
        dt2.Columns.Add(dcCantidad)
        dt2.Columns.Add(dcPrecioUnitario)
        dt2.Columns.Add(dcTotalParcial)

        Me.dgvDetalleOrdenPago.DataSource = dt2
        'lbusuario.Text = frmInicioF.lbidusuario.Text
        mostrar()
    End Sub

    Public Sub limpiar()
        txtCantidad.Text = 0
        txtNombreCategoria.Text = ""
        txtIdProducto.Text = ""
        txtNombreProducto.Text = ""
        txtPrecioUnitario.Text = ""
    End Sub

    Private Sub mostrar()
        'Try
        '    Dim func As New fVentaREDRUBI
        '    dt = func.mostrar
        '    datalistado.Columns.Item("Eliminar").Visible = False

        '    If dt.Rows.Count <> 0 Then
        '        datalistado.DataSource = dt
        '        '           txtBuscar.Enabled = True
        '        datalistado.ColumnHeadersVisible = True
        '        Inexistente.Visible = False
        '    Else
        '        datalistado.DataSource = Nothing
        '        '          txtBuscar.Enabled = False
        '        datalistado.ColumnHeadersVisible = True
        '        Inexistente.Visible = True
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'btnNuevo.Visible = True
        'btnEditar.Visible = False
        'ocultar_columnas()


        '       Buscar()

    End Sub

    'Private Sub Buscar()

    '    Try
    '        Dim ds As New DataSet
    '        ds.Tables.Add(dt.Copy)
    '        Dim dv As New DataView(ds.Tables(0))

    '        dv.RowFilter = cbxListadoClientes.Text & " Like '" & txtBuscar.Text & "%'"

    '        If dv.Count <> 0 Then
    '            Inexistente.Visible = False
    '            datalistado.DataSource = dv
    '            ocultar_columnas()
    '        Else
    '            Inexistente.Visible = True
    '            datalistado.DataSource = Nothing
    '        End If


    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub ocultar_columnas()
        'datalistado.Columns(1).Visible = False
        'datalistado.Columns(2).Visible = False
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs)
        frmClienteREDRUBI.txtFlag.Text = "1"
        frmClienteREDRUBI.ShowDialog()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            If txtidCliente.Text <> "" And txtIdProducto.Text <> "" And txtCantidad.Text <> 0 Then
                txtTotalParcial.Text = CDbl(txtCantidad.Text) * CDbl(txtPrecioUnitario.Text)
                dr2 = dt2.NewRow
                'dr2(dcCiNit) = Me.cbTipoDoc.Text
                'dr2(dcNumDocumento) = Me.txtNumDoc.Text
                'dr2(dcNombre) = Me.txtNombreFac.Text
                dr2(dcProducto) = Me.txtNombreProducto.Text
                dr2(dcCategoria) = Me.txtNombreCategoria.Text
                dr2(dcCantidad) = Me.txtCantidad.Text
                dr2(dcPrecioUnitario) = Me.txtPrecioUnitario.Text
                dr2(dcTotalParcial) = Me.txtTotalParcial.Text
                'dr2(dcCategoria) = Me

                dt2.Rows.Add(dr2)

                txttotal.Text = sumar().ToString
                limpiar()
            Else
                MessageBox.Show("CANTIDAD INCORRECTA")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Function sumar() As Double

        Dim total As Double

        For Each rowtotal As DataGridViewRow In dgvDetalleOrdenPago.Rows
            total += Convert.ToDouble(rowtotal.Cells("TOTAL PARCIAL").Value)

        Next

        Return total

    End Function
    Private Sub btnBuscarCliente_Click_1(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        frmClienteREDRUBI.txtFlag.Text = "3"
        frmClienteREDRUBI.ShowDialog()
    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        frmProductoREDRUBI.txtTag.Text = "3"
        frmProductoREDRUBI.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

    End Sub

    Private Sub btnFinalizarVenta_Click(sender As Object, e As EventArgs) Handles btnFinalizarVenta.Click
        frmImprimirOrdenPAgo.Show()

        'PrintDocument1.Print()
    End Sub

    Private Sub PrintPreviewControl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Dim printFont As System.Drawing.Font = New Font("Arial", 10)
        'Dim topMargin As Double = e.MarginBounds.Top
        'Dim yPos As Double = 0
        'Dim linesPerPage As Double = 0
        'Dim count As Integer = 0
        'Dim texto As String = ""
        'Dim row As System.Windows.Forms.DataGridViewRow

        '' Calculamos el número de líneas que caben en cada página. 
        'linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics)
        '' Recorremos las filas del DataGridView hasta que llegemos
        '' a las líneas que nos caben en cada página o al final del grid. 
        'While count < linesPerPage AndAlso i < dgvDetalleOrdenPago.Rows.Count
        '    row = dgvDetalleOrdenPago.Rows(i)
        '    texto = ""
        '    For Each celda As System.Windows.Forms.DataGridViewCell In row.Cells
        '        texto += vbCrLf + celda.Value.ToString()
        '    Next
        '    ' Calculamos la posición en la que se escribe la línea 
        '    yPos = topMargin + (count * printFont.GetHeight(e.Graphics))
        '    ' Escribimos la línea con el objeto Graphics 
        '    e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 10, yPos)
        '    count += 1
        '    i += 1
        'End While
        '' Una vez fuera del bucle comprobamos si nos quedan más filas 
        '' por imprimir, si quedan saldrán en la siguente página 
        'If i < dgvDetalleOrdenPago.Rows.Count Then
        '    e.HasMorePages = True
        'Else
        '    ' si llegamos al final, se establece HasMorePages a 
        '    ' false para que se acabe la impresión 
        '    e.HasMorePages = False
        '    ' Es necesario poner el contador a 0 porque, por ejemplo si se hace 
        '    ' una impresión desde PrintPreviewDialog, se vuelve disparar este 
        '    ' evento como si fuese la primera vez, y si i está con el valor de la 
        '    ' última fila del grid no se imprime nada 
        '    i = 0
        'End If
    End Sub
End Class