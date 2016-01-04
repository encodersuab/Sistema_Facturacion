Public Class frmFACTURA

    Private dt As New DataTable
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
        'datalistado.Columns(1).Visible = False
        'datalistado.Columns(2).Visible = False
        'datalistado.Columns(3).Visible = False
    End Sub
    Private Sub frmFACTURA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
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

    Private Sub datalistado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentDoubleClick

    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value

        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub txtIDCodQr_Validated(sender As Object, e As EventArgs) Handles txtIDCodQr.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtNit_Emisor_Validated(sender As Object, e As EventArgs) Handles txtNit_Emisor.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtNum_Factura_Validated(sender As Object, e As EventArgs) Handles txtNum_Factura.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtINum_Autorizacion_Validated(sender As Object, e As EventArgs) Handles txtINum_Autorizacion.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtfechaEmision_Validated(sender As Object, e As EventArgs) Handles txtfechaEmision.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtTotalPagar_Validated(sender As Object, e As EventArgs) Handles txtTotalPagar.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtCodigoControl_Validated(sender As Object, e As EventArgs) Handles txtCodigoControl.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtCiNitComprador_Validated(sender As Object, e As EventArgs) Handles txtCiNitComprador.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txttxtIdVenta_Validated(sender As Object, e As EventArgs) Handles txttxtIdVenta.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtvalidez_Validated(sender As Object, e As EventArgs) Handles txtvalidez.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub btnAnularFactura_Click(sender As Object, e As EventArgs) Handles btnAnularFactura.Click
        Dim result As DialogResult
        result = MessageBox.Show("realizar la anulacion de la factuara?", "Anulando Factura", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            If Me.ValidateChildren = True And txtIDCodQr.Text <> "" And txtNit_Emisor.Text <> "" And txtNum_Factura.Text <> "" And txtINum_Autorizacion.Text <> "" And txtfechaEmision.Text <> "" And txtTotalPagar.Text <> "" And txtCodigoControl.Text <> "" And txtCiNitComprador.Text <> "" Then
                Try
                    Dim dts As New vQr
                    Dim func As New fQr
                    Dim dts1 As New vDetalleVenta
                    Dim func1 As New fDetalleVenta
                    Dim dts2 As New vDetalleVenta
                    Dim func2 As New fDetalleVenta

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



                    Dim res As DialogResult
                    res = MessageBox.Show("REALMENTE QUIERE ANULAR LA FACTURA", "FACTURA ANULADA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    dts1.gidventa = txttxtIdVenta.Text
                    If (res = Windows.Forms.DialogResult.Yes) Then
                        func.editar(dts)
                        Do While func1.mostraridprodXidventa(dts1) <> 0

                            dts2.gidproducto = func1.mostraridprodXidventa(dts1)
                            dts2.gcantidad = func1.mostrarCantidadXidventa(dts1)
                            func2.aumentar_stock(dts2)
                            dts2.giddedatlle_venta = func1.mostrariddetalleventaXidventa(dts1)
                            dts2.gvalidez = "A"
                            func2.editarValidez(dts2)
                            ' func1.eliminar(dts2)
                        Loop
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

    Private Sub btnReImpreisionFactura_Click(sender As Object, e As EventArgs) Handles btnReImpreisionFactura.Click
        frmFactura0.txtnumfactura.Text = txtIDCodQr.Text
        frmFactura0.MdiParent = frmInicioF
        frmFactura0.Show()
    End Sub
End Class