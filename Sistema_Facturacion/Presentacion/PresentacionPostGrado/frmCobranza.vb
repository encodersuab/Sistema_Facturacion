Public Class frmCobranza
    Private dt As New DataTable
    Private dt2 As New DataTable
    Private Sub frmCobranza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        mostrar2()
    End Sub
    Public Sub limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtidCliente.Text = ""
        txtNombreCLiente.Text = ""
        cbTipoDoc.Text = ""
        txtNumDoc.Text = ""
        txtIdVenta.Text = ""
        txtNombreFac.Text = ""

        txtIdeProducto.Text = ""
        txtNombreCurso.Text = ""
        ' txtCi.Text = ""

    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fVentaPostGrado
            dt = func.mostrardeudor
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
        'btnNuevo.Visible = True
        btnEditar.Visible = False
        'buscar
    End Sub
    Private Sub Buscar()

        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cbxListadoClientes.Text & " Like '%" & txtBuscar.Text & "%'"

            If dv.Count <> 0 Then
                Inexistente.Visible = False
                datalistado.DataSource = dv
                'ocultar_columnas()
            Else
                Inexistente.Visible = True
                datalistado.DataSource = Nothing
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub mostrar2()
        Try
            Dim func As New fVentaPostGrado
            dt2 = func.mostrar
            'datalistado2.Columns.Item("Eliminar").Visible = False

            If dt2.Rows.Count <> 0 Then
                datalistado2.DataSource = dt2
                '           txtBuscar.Enabled = True
                datalistado2.ColumnHeadersVisible = True
                Inexistente.Visible = False
            Else
                datalistado2.DataSource = Nothing
                '          txtBuscar.Enabled = False
                datalistado2.ColumnHeadersVisible = True
                Inexistente.Visible = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'btnNuevo.Visible = True
        'btnEditar.Visible = False
        'buscar
    End Sub
    Private Sub Buscar2()

        Try
            Dim ds2 As New DataSet
            ds2.Tables.Add(dt2.Copy)
            Dim dv2 As New DataView(ds2.Tables(0))

            dv2.RowFilter = cbxListadoClientes.Text & " Like '%" & txtBuscar.Text & "%'"

            If dv2.Count <> 0 Then
                Inexistente.Visible = False
                datalistado2.DataSource = dv2
                'ocultar_columnas()
            Else
                Inexistente.Visible = True
                datalistado2.DataSource = Nothing
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        'If txtFlag.Text = "1" Then
        txtidCliente.Text = datalistado.SelectedCells.Item(1).Value
        txtNombreCLiente.Text = datalistado.SelectedCells.Item(2).Value
        txtNumDoc.Text = datalistado.SelectedCells.Item(6).Value
        txtNombreFac.Text = datalistado.SelectedCells.Item(2).Value + " " + datalistado.SelectedCells.Item(3).Value
        txtMontoAdeudado.Text = datalistado.SelectedCells.Item(8).Value
        txtNombreCurso.Text = datalistado.SelectedCells.Item(9).Value
        txtIdeProducto.Text = datalistado.SelectedCells.Item(10).Value
        txtidDeudor.Text = datalistado.SelectedCells.Item(11).Value
        'txtFlag.Text = "0"
        'Me.Close()

        'ElseIf txtFlag.Text = "2" Then
        '    frmVentaPlanillaPostGrado.txtidCliente.Text = datalistado.SelectedCells.Item(1).Value
        '    frmVentaPlanillaPostGrado.txtNombreCLiente.Text = datalistado.SelectedCells.Item(2).Value
        '    frmVentaPlanillaPostGrado.txtNumDoc.Text = datalistado.SelectedCells.Item(6).Value
        '    frmVentaPlanillaPostGrado.txtNombreFac.Text = datalistado.SelectedCells.Item(2).Value + " " + datalistado.SelectedCells.Item(3).Value
        '    'txtFlag.Text = "0"
        '    Me.Close()
        'End If
    End Sub
    Private Sub cargar_detalle()

        frmDetalleVentaPostGrado.txtidCliente.Text = datalistado2.SelectedCells.Item(2).Value
        frmDetalleVentaPostGrado.txtIdVenta.Text = datalistado2.SelectedCells.Item(1).Value
        frmDetalleVentaPostGrado.txtNombreCLiente.Text = datalistado2.SelectedCells.Item(3).Value
        frmDetalleVentaPostGrado.dtpFecha.Text = datalistado2.SelectedCells.Item(5).Value
        frmDetalleVentaPostGrado.cbTipoDoc.Text = datalistado2.SelectedCells.Item(6).Value
        frmDetalleVentaPostGrado.txtNumDoc.Text = datalistado2.SelectedCells.Item(7).Value
        frmDetalleVentaPostGrado.txtNombreFac.Text = datalistado2.SelectedCells.Item(8).Value
        frmDetalleVentaPostGrado.txtNombreProducto.Text = datalistado.SelectedCells.Item(9).Value
        frmDetalleVentaPostGrado.txtPrecioUnitario.Text = datalistado.SelectedCells.Item(8).Value
        frmDetalleVentaPostGrado.txtIdProducto.Text = datalistado.SelectedCells.Item(10).Value
        frmDetalleVentaPostGrado.txtIdDeudor.Text = datalistado.SelectedCells.Item(11).Value
        frmDetalleVentaPostGrado.txtDD.Text = 0
        'frmDetalleVenta.txtidCliente.Text = txtidCliente.Text
        'frmDetalleVenta.txtIdVenta.Text = txtIdVenta.Text
        'frmDetalleVenta.txtNombreCLiente.Text = txtNombreCLiente.Text
        'frmDetalleVenta.dtpFecha.Text = dtpFecha.Text
        'frmDetalleVenta.cbTipoDoc.Text = cbTipoDoc.Text
        'frmDetalleVenta.txtNumDoc.Text = txtNumDoc.Text
        'frmDetalleVenta.txtNombreFac.Text = txtNombreFac.Text
        frmDetalleVentaPostGrado.CodCobranza.Text = CodCobranza.Text
        frmDetalleVentaPostGrado.ShowDialog()

    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtidCliente.Text <> "" And txtNombreCLiente.Text <> "" And txtNumDoc.Text <> "" Then
            Try
                Dim dts As New vVentaPostGrado
                Dim func As New fVentaPostGrado

                dts.Gidcliente = txtidCliente.Text
                dts.Gfecha_venta = dtpFecha.Value.Date.ToString
                dts.Gtipo_documento = cbTipoDoc.Text
                dts.Gnum_documento = txtNumDoc.Text
                dts.Gnombre_fac = txtNombreFac.Text
                dts.Gestado = 0
                dts.Gpago = "CONTADO"
                dts.Gidusuario = frmInicioF.lbidusuario.Text
                dts.Gmodulo = "POSTGRADO"
                If func.insertar(dts) Then
                    MessageBox.Show("venta registrada correctamente vamos a añadir porductos", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    mostrar2()
                    cargar_detalle()
                    limpiar()


                Else
                    MessageBox.Show("venta no registrada", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar2()
                    limpiar()

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("error de datos faltante", "error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
End Class