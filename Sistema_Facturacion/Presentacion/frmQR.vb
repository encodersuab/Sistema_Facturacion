﻿Public Class frmQR
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
                datalistado.ColumnHeadersVisible = False
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

  
End Class