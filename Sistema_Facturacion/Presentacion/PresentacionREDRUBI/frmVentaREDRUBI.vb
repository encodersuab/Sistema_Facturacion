Public Class frmVentaREDRUBI
    Private dt As New DataTable
    Private Sub frmVenta_LoadREDRUBI(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Public Sub limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtidCliente.Text = ""
        txtNombreCLiente.Text = ""
        cbTipoDoc.Text = ""
        txtNumDoc.Text = ""
        txtIdVenta.Text = ""
        ' txtCi.Text = ""

    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fVentaREDRUBI
            dt = func.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                '           txtBuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                Inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                '          txtBuscar.Enabled = False
                datalistado.ColumnHeadersVisible = True
                Inexistente.Visible = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnNuevo.Visible = True
        btnEditar.Visible = False

        '      Buscar()

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



    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtidCliente.Text <> "" And txtNombreCLiente.Text <> "" And txtNumDoc.Text <> "" Then
            Try
                Dim dts As New vVentaREDRUBI
                Dim func As New fVentaREDRUBI

                dts.Gidcliente = txtidCliente.Text
                dts.Gfecha_venta = dtpFecha.Value.Date.ToString
                dts.Gtipo_documento = cbTipoDoc.Text
                dts.Gnum_documento = txtNumDoc.Text
                dts.Gnombre_fac = txtNombreFac.Text
                If func.insertar(dts) Then
                    MessageBox.Show("venta registrada correctamente vamos a añadir porductos", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    mostrar()
                    cargar_detalle()
                    limpiar()


                Else
                    MessageBox.Show("venta no registrada", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("error de datos faltante", "error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("realizar los cambios?", "Modificardo registro", MessageBoxButtons.OKCancel)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtidCliente.Text <> "" And txtNumDoc.Text <> "" And txtIdVenta.Text <> "" Then
                Try
                    Dim dts As New vVentaREDRUBI
                    Dim func As New fVentaREDRUBI

                    dts.Gidventa = txtIdVenta.Text
                    dts.Gidcliente = txtidCliente.Text
                    dts.Gfecha_venta = dtpFecha.Text
                    dts.Gtipo_documento = cbTipoDoc.Text
                    dts.Gnum_documento = txtNumDoc.Text
                    dts.Gnombre_fac = txtNombreFac.Text

                    If func.editar(dts) Then
                        MessageBox.Show("cliente modificado correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("cliente no modificado", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        'txtIdVenta.Text = datalistado.SelectedCells.Item(1).Value
        'txtidCliente.Text = datalistado.SelectedCells.Item(2).Value
        'txtNombreCLiente.Text = datalistado.SelectedCells.Item(3).Value
        'dtpFecha.Text = datalistado.SelectedCells.Item(5).Value
        'cbTipoDoc.Text = datalistado.SelectedCells.Item(6).Value
        'txtNumDoc.Text = datalistado.SelectedCells.Item(7).Value

        'btnEditar.Visible = True
        'btnGuardar.Visible = False


    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
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
        'Buscar()

    End Sub

    Private Sub cargar_detalle()
        frmDetalleVenta.txtidCliente.Text = datalistado.SelectedCells.Item(2).Value
        frmDetalleVenta.txtIdVenta.Text = datalistado.SelectedCells.Item(1).Value
        frmDetalleVenta.txtNombreCLiente.Text = datalistado.SelectedCells.Item(3).Value
        frmDetalleVenta.dtpFecha.Text = datalistado.SelectedCells.Item(5).Value
        frmDetalleVenta.cbTipoDoc.Text = datalistado.SelectedCells.Item(6).Value
        frmDetalleVenta.txtNumDoc.Text = datalistado.SelectedCells.Item(7).Value
        frmDetalleVenta.txtNombreFac.Text = datalistado.SelectedCells.Item(8).Value
        'frmDetalleVenta.txtidCliente.Text = txtidCliente.Text
        'frmDetalleVenta.txtIdVenta.Text = txtIdVenta.Text
        'frmDetalleVenta.txtNombreCLiente.Text = txtNombreCLiente.Text
        'frmDetalleVenta.dtpFecha.Text = dtpFecha.Text
        'frmDetalleVenta.cbTipoDoc.Text = cbTipoDoc.Text
        'frmDetalleVenta.txtNumDoc.Text = txtNumDoc.Text
        'frmDetalleVenta.txtNombreFac.Text = txtNombreFac.Text



        frmDetalleVentaREDRUBI.ShowDialog()

    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        cargar_detalle()

    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        frmCliente.txtFlag.Text = "1"
        frmClienteREDRUBI.ShowDialog()

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()


    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txtNumDoc_TextChanged(sender As Object, e As EventArgs) Handles txtNumDoc.TextChanged

    End Sub

    Private Sub txtNumDoc_Validated(sender As Object, e As EventArgs) Handles txtNumDoc.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub
End Class