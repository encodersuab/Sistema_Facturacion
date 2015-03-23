Public Class frmVentaPlanillaPostGrado
    Private dt As New DataTable
    Private Sub frmVentaPlanillaPostGrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarVentaPlanilla()

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
        txtPago.Text = ""
        txtEstado.Text = ""
        ' txtCi.Text = ""
    End Sub

    Private Sub mostrarVentaPlanilla()
        Try
            Dim func As New fVentaPlanilla
            dt = func.mostrarVentaPlanilla
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
        datalistado.Enabled = False
        '       Buscar()

    End Sub
    Private Sub ocultar_columnas()
        'datalistado.Columns(1).Visible = False
        'datalistado.Columns(2).Visible = False
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        mostrarVentaPlanilla()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtidCliente.Text <> "" And txtNombreCLiente.Text <> "" And txtNumDoc.Text <> "" Then
            Try
                Dim dts As New vVentaPlanilla
                Dim func As New fVentaPlanilla

                dts.Gidcliente = txtidCliente.Text
                dts.Gfecha_venta = dtpFecha.Value.Date.ToString
                dts.Gtipo_documento = cbTipoDoc.Text
                dts.Gnum_documento = txtNumDoc.Text
                dts.Gnombre_fac = txtNombreFac.Text
                dts.Gestado = 1
                dts.Gpago = "PLANILLA"
                If func.insertarventaPlanilla(dts) Then
                    MessageBox.Show("venta registrada correctamente vamos a añadir porductos", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    mostrarVentaPlanilla()
                    cargar_detalle()
                    limpiar()


                Else
                    MessageBox.Show("venta no registrada", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrarVentaPlanilla()
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
        If Me.ValidateChildren = True And txtidCliente.Text <> "" And txtNumDoc.Text <> "" And txtIdVenta.Text <> "" Then
            Try
                Dim dts As New vVentaPlanilla
                Dim func As New fVentaPlanilla

                dts.Gidventaplanilla = txtIdVenta.Text
                dts.Gidcliente = txtidCliente.Text
                dts.Gfecha_venta = dtpFecha.Text
                dts.Gtipo_documento = cbTipoDoc.Text
                dts.Gnum_documento = txtNumDoc.Text
                dts.Gnombre_fac = txtNombreFac.Text
                dts.Gestado = txtEstado.Text
                dts.Gpago = txtPago.Text

                If func.editarVentaPlanilla(dts) Then
                    MessageBox.Show("cliente modificado correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrarVentaPlanilla()
                    limpiar()
                Else
                    MessageBox.Show("cliente no modificado", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrarVentaPlanilla()
                    limpiar()

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("error de datos faltante", "error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'Private Sub cargar_detalle_venta()

    '    frmDetalleVentaplanilla.txtidCliente.Text = datalistado.SelectedCells.Item(2).Value
    '    frmDetalleVentaplanilla.txtIdVenta.Text = datalistado.SelectedCells.Item(1).Value
    '    frmDetalleVentaplanilla.txtNombreCLiente.Text = datalistado.SelectedCells.Item(3).Value
    '    frmDetalleVentaplanilla.dtpFecha.Text = datalistado.SelectedCells.Item(5).Value
    '    frmDetalleVentaplanilla.cbTipoDoc.Text = datalistado.SelectedCells.Item(6).Value
    '    frmDetalleVentaplanilla.txtNumDoc.Text = datalistado.SelectedCells.Item(7).Value
    '    frmDetalleVentaplanilla.txtNombreFac.Text = datalistado.SelectedCells.Item(8).Value
    '    frmDetalleVentaplanilla.txtestado.Text = datalistado.SelectedCells.Item(9).Value
    '    'frmDetalleVenta.txtidCliente.Text = txtidCliente.Text
    '    'frmDetalleVenta.txtIdVenta.Text = txtIdVenta.Text
    '    'frmDetalleVenta.txtNombreCLiente.Text = txtNombreCLiente.Text
    '    'frmDetalleVenta.dtpFecha.Text = dtpFecha.Text
    '    'frmDetalleVenta.cbTipoDoc.Text = cbTipoDoc.Text
    '    'frmDetalleVenta.txtNumDoc.Text = txtNumDoc.Text
    '    'frmDetalleVenta.txtNombreFac.Text = txtNombreFac.Text

    '    frmDetalleVentaplanilla.ShowDialog()

    'End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtIdVenta.Text = datalistado.SelectedCells.Item(1).Value
        txtidCliente.Text = datalistado.SelectedCells.Item(2).Value
        txtNombreCLiente.Text = datalistado.SelectedCells.Item(3).Value
        dtpFecha.Text = datalistado.SelectedCells.Item(5).Value
        cbTipoDoc.Text = datalistado.SelectedCells.Item(6).Value
        txtNumDoc.Text = datalistado.SelectedCells.Item(7).Value
        txtNombreFac.Text = datalistado.SelectedCells.Item(8).Value
        txtEstado.Text = datalistado.SelectedCells.Item(9).Value
        txtPago.Text = datalistado.SelectedCells.Item(10).Value
        btnEditar.Visible = True
        btnGuardar.Visible = False
    End Sub

    Private Sub cargar_detalle_factura()



        frmDetalleVenta.txtidCliente.Text = datalistado.SelectedCells.Item(2).Value
        frmDetalleVenta.txtIdVenta.Text = datalistado.SelectedCells.Item(1).Value
        frmDetalleVenta.txtNombreCLiente.Text = datalistado.SelectedCells.Item(3).Value
        frmDetalleVenta.dtpFecha.Text = datalistado.SelectedCells.Item(5).Value
        frmDetalleVenta.cbTipoDoc.Text = datalistado.SelectedCells.Item(6).Value
        frmDetalleVenta.txtNumDoc.Text = datalistado.SelectedCells.Item(7).Value
        frmDetalleVenta.txtNombreFac.Text = datalistado.SelectedCells.Item(8).Value
        frmDetalleVenta.txtDD.Text = 1
        frmDetalleVenta.ShowDialog()

    End Sub
    Private Sub cargar_detalle()



        frmDetalleVentaplanilla.txtidCliente.Text = datalistado.SelectedCells.Item(2).Value
        frmDetalleVentaplanilla.txtIdVenta.Text = datalistado.SelectedCells.Item(1).Value
        frmDetalleVentaplanilla.txtNombreCLiente.Text = datalistado.SelectedCells.Item(3).Value
        frmDetalleVentaplanilla.dtpFecha.Text = datalistado.SelectedCells.Item(5).Value
        frmDetalleVentaplanilla.cbTipoDoc.Text = datalistado.SelectedCells.Item(6).Value
        frmDetalleVentaplanilla.txtNumDoc.Text = datalistado.SelectedCells.Item(7).Value
        frmDetalleVentaplanilla.txtNombreFac.Text = datalistado.SelectedCells.Item(8).Value

        frmDetalleVentaplanilla.ShowDialog()

    End Sub




    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        frmCliente.txtFlag.Text = "2"
        frmCliente.ShowDialog()
    End Sub

    Private Sub btnImprimirFacturaPlanilla_Click(sender As Object, e As EventArgs) Handles btnImprimirFacturaPlanilla.Click
        Try
            Dim result As Integer = MessageBox.Show("DESEA IMPRIMIR LAS FACTURAS DE VENTAS POR PLANILLA ", "IMPRIMIR FACTURAS", MessageBoxButtons.YesNoCancel)

            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                datalistado.Enabled = True


                If datalistado.SelectedCells.Item(9).Value = 1 Then
                    frmDetalleVenta.txtDD.Text = 1
                End If
            Else
                MessageBox.Show("venta no registrada", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mostrarVentaPlanilla()
                limpiar()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick

        Dim result As DialogResult
        result = MessageBox.Show("IMPRIMIR FACTURAS POR PLANILLA", "FACTURAS", MessageBoxButtons.OKCancel)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtidCliente.Text <> "" And txtNumDoc.Text <> "" And txtIdVenta.Text <> "" Then
                Try
                    Dim dts As New vVentaPlanilla
                    Dim func As New fVentaPlanilla

                    dts.Gidventaplanilla = txtIdVenta.Text
                    dts.Gidcliente = txtidCliente.Text
                    dts.Gfecha_venta = dtpFecha.Value.Date.ToString
                    dts.Gtipo_documento = cbTipoDoc.Text
                    dts.Gnum_documento = txtNumDoc.Text
                    dts.Gnombre_fac = txtNombreFac.Text
                    dts.Gestado = CInt(0)
                    dts.Gpago = "PLANILLA"
                    If func.editarVentaPlanilla(dts) Then
                        cargar_detalle_factura()
                        mostrarVentaPlanilla()
                    Else
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("error de datos faltante", "error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If

    End Sub


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
End Class


