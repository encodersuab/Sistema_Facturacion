Public Class frmQR
    Private dt As New DataTable
    Private Sub frmQR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()

    End Sub


    ''''''''''''''''
    Public Sub limpiar()


        txtIDCodQr.Text = ""
        txtNit_Emisor.Text = ""
        txtNum_Factura.Text = ""
        txtINum_Autorizacion.Text = ""
        txtfechaEmision.Text = ""
        txtTotalPagar.Text = ""
        txtCodigoControl.Text = ""
        txtCiNitComprador.Text = ""
        txttxtIdVenta.Text = ""
        txtvalidez.Text = ""

    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fQr
            dt = func.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                datalistado.ColumnHeadersVisible = True
                Inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                datalistado.ColumnHeadersVisible = True
                Inexistente.Visible = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Buscar()

    End Sub

    Private Sub Buscar()

        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cbxListadoClientes.Text & " Like '" & txtBuscar.Text & "%'"

            If dv.Count <> 0 Then
                Inexistente.Visible = False
                datalistado.DataSource = dv
                ocultar_columnas()
            Else
                Inexistente.Visible = True
                datalistado.DataSource = Nothing
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ocultar_columnas()
        '   datalistado.Columns(1).Visible = False
        '  datalistado.Columns(2).Visible = False
        '  datalistado.Columns(3).Visible = False
    End Sub





    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick

        txtIDCodQr.Text = datalistado.SelectedCells.Item(1).Value
        txtNit_Emisor.Text = datalistado.SelectedCells.Item(2).Value
        txtNum_Factura.Text = datalistado.SelectedCells.Item(3).Value
        txtINum_Autorizacion.Text = datalistado.SelectedCells.Item(4).Value
        txtfechaEmision.Text = datalistado.SelectedCells.Item(5).Value
        txtTotalPagar.Text = datalistado.SelectedCells.Item(6).Value
        txtCodigoControl.Text = datalistado.SelectedCells.Item(7).Value
        txtCiNitComprador.Text = datalistado.SelectedCells.Item(8).Value
        txttxtIdVenta.Text = datalistado.SelectedCells.Item(10).Value
        txtvalidez.Text = datalistado.SelectedCells.Item(11).Value

    End Sub



    'Private Sub btnGuardar_Click(sender As Object, e As EventArgs)
    '    If Me.ValidateChildren = True And txtINum_Autorizacion.Text <> "" And txtCantidad.Text <> "" And txtPrecioUnitario.Text <> "" Then
    '        Try



    '            Dim dts As New vDetalleVenta
    '            Dim func As New fDetalleVenta

    '            dts.gidventa = txtNit_Emisor.Text
    '            dts.gidproducto = txtINum_Autorizacion.Text
    '            dts.gcantidad = txtCantidad.Text
    '            dts.gprecio_unitario = txttxtIdVenta.Text

    '            '''''''''''''''''''''''''''''''''''''''''''
    '            Dim ms As New IO.MemoryStream()


    '            'cmd.Parameters.AddWithValue("nombre", txtNombre.Text)
    '            'Dim memoriaImagenQR As MemoryStream = New MemoryStream
    '            'QrCodeImgControl1.Image.Save(memoriaImagenQR, ImageFormat.Jpeg)
    '            'Dim byteqr() As Byte = New Byte((memoriaImagenQR.Length) - 1) {}
    '            'memoriaImagenQR.Position = 0
    '            'memoriaImagenQR.Read(byteqr, 0, Convert.ToInt32(memoriaImagenQR.Length))
    '            'cmd.Parameters.AddWithValue("foto", byteqr)


    '            QrCodeImgControl1.Image.Save(ms, QrCodeImgControl1.Image.RawFormat)
    '            ''QrCodeImgControl1.Image = My.Resources.fondo_transparente_fotos
    '            ''QrCodeImgControl1.Image.Save(ms, QrCodeImgControl1.Image.RawFormat)



    '            'imagen.Image.Save(ms, imagen.Image.RawFormat)
    '            '        Else
    '            'imagen.Image = My.Resources.fondo_transparente_fotos
    '            'imagen.Image.Save(ms, imagen.Image.RawFormat)
    '            '        End If

    '            dts.gimagen = ms.GetBuffer

    '            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    '            If func.insertar(dts) Then
    '                If func.disminuir_stock(dts) Then

    '                End If
    '                MessageBox.Show("articulo añadido correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                mostrar()
    '                txttotal.Text = sumar().ToString
    '                limpiar()


    '                QrCodeImgControl1.Visible = True
    '                QrCodeImgControl1.Text = txtIDCodQr.Text + "|" + txtNit_Emisor.Text + "|" + dtpFecha.Text + "|" + txttotal.Text
    '                QrCodeImgControl1.Enabled = True




    '            Else
    '                MessageBox.Show("articulo no registrada", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                mostrar()
    '                limpiar()


    '            End If


    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    Else
    '        MessageBox.Show("error de datos faltante", "error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '    End If

    'End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value

        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar los clientes seleccionados?", "Eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idcliente").Value)
                        Dim vdb As New vDetalleVenta
                        Dim func As New fDetalleVenta
                        vdb.giddedatlle_venta = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("Clioente no fue eliminado", "Eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                        End If
                    End If
                Next
                Call mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminacion de registro", "Eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()

        End If
    End Sub

    Private Sub cbeliminar_CheckedChanged(sender As Object, e As EventArgs)
        'If cbeliminar.CheckState = CheckState.Checked Then
        '    datalistado.Columns.Item("Eliminar").Visible = True
        'Else
        '    datalistado.Columns.Item("Eliminar").Visible = False
        'End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs)
        Buscar()

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()

    End Sub

   



    'Private Sub txtCantidad_ValueChanged(sender As Object, e As EventArgs)
    '    Dim cant As Double
    '    cant = txtCantidad.Value
    '    If txtCantidad.Value > txtStock.Value Then
    '        MessageBox.Show("La cantidad que intenta vender supera el stock", "Error al vender")
    '        btnGuardar.Visible = 0
    '        txtCantidad.Value = txtStock.Value
    '    Else
    '        btnGuardar.Visible = 1
    '    End If
    '    If txtCantidad.Value = 0 Then
    '        btnGuardar.Visible = 0
    '    Else
    '        btnGuardar.Visible = 1
    '    End If

    'End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

   
   

 

  
    '''''''''''''

  
 

   
 
  
    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick

    End Sub

    Private Sub txtBuscar_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()
    End Sub

  
    Private Sub txtNit_Emisor_TextChanged(sender As Object, e As EventArgs) Handles txtNit_Emisor.TextChanged

    End Sub

    Private Sub txtNit_Emisor_Validated(sender As Object, e As EventArgs) Handles txtNit_Emisor.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtNum_Factura_TextChanged(sender As Object, e As EventArgs) Handles txtNum_Factura.TextChanged
        
    End Sub

    Private Sub txtNum_Factura_Validated(sender As Object, e As EventArgs) Handles txtNum_Factura.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtINum_Autorizacion_TextChanged(sender As Object, e As EventArgs) Handles txtINum_Autorizacion.TextChanged

    End Sub

    Private Sub txtINum_Autorizacion_Validated(sender As Object, e As EventArgs) Handles txtINum_Autorizacion.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtfechaEmision_TextChanged(sender As Object, e As EventArgs) Handles txtfechaEmision.TextChanged

    End Sub

    Private Sub txtfechaEmision_Validated(sender As Object, e As EventArgs) Handles txtfechaEmision.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtTotalPagar_TextChanged(sender As Object, e As EventArgs) Handles txtTotalPagar.TextChanged

    End Sub

    Private Sub txtTotalPagar_Validated(sender As Object, e As EventArgs) Handles txtTotalPagar.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtCodigoControl_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoControl.TextChanged

    End Sub

    Private Sub txtCodigoControl_Validated(sender As Object, e As EventArgs) Handles txtCodigoControl.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtCiNitComprador_TextChanged(sender As Object, e As EventArgs) Handles txtCiNitComprador.TextChanged

    End Sub

    Private Sub txtCiNitComprador_Validated(sender As Object, e As EventArgs) Handles txtCiNitComprador.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txttxtIdVenta_TextChanged(sender As Object, e As EventArgs) Handles txttxtIdVenta.TextChanged

    End Sub

    Private Sub txttxtIdVenta_Validated(sender As Object, e As EventArgs) Handles txttxtIdVenta.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAnularFactura.Click
        Dim result As DialogResult
        result = MessageBox.Show("realizar la anulacion de la factuara?", "Anulando Factura", MessageBoxButtons.OKCancel)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtIDCodQr.Text <> "" And txtNit_Emisor.Text <> "" And txtNum_Factura.Text <> "" And txtINum_Autorizacion.Text <> "" And txtfechaEmision.Text <> "" And txtTotalPagar.Text <> "" And txtCodigoControl.Text <> "" And txtCiNitComprador.Text <> "" Then
                Try
                    Dim dts As New vQr
                    Dim func As New fQr

                    dts.gIDCodQr = txtIDCodQr.Text
                    dts.gNit_Emisor = txtNit_Emisor.Text
                    dts.gNum_Factura = txtNum_Factura.Text
                    dts.gNum_Autorizacion = txtINum_Autorizacion.Text
                    dts.gfecha_emision = txtfechaEmision.Text
                    dts.gTotal = "0"
                    dts.gCodigo_Control = txtCodigoControl.Text
                    dts.gCi_Nit_Comprador = "0"
                    dts.gIdVenta = txttxtIdVenta.Text
                    dts.gvalidez = "A"

                    If func.editar(dts) Then
                        MessageBox.Show("FACTURA ANULADA", "FACTURA ANULADA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("ERROR AL ANULAR ESTA FACTURA", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()

                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("error de datos faltante", "error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub
End Class