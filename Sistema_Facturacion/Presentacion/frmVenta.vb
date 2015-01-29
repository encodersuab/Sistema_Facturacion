Public Class frmVenta
    Private dt As New DataTable
    Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim func As New fVenta
            dt = func.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtBuscar.Enabled = True
                datalistado.ColumnHeadersVisible = False
                Inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                txtBuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                Inexistente.Visible = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnNuevo.Visible = True
        btnEditar.Visible = False

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
        datalistado.Columns(1).Visible = False
        datalistado.Columns(2).Visible = False
    End Sub

   

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtidCliente.Text <> "" And txtNombreCLiente.Text <> "" And txtNumDoc.Text <> "" Then
            Try
                Dim dts As New vVenta
                Dim func As New fVenta

                dts.Gidcliente = txtidCliente.Text
                dts.Gfecha_venta = dtpFecha.Text
                dts.Gtipo_documento = cbTipoDoc.Text
                dts.Gnum_documento = txtNumDoc.Text
                '   dts.gci = txtCi.Text

                If func.insertar(dts) Then
                    MessageBox.Show("venta registrada correctamente vamos a añadir porductos", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    cargar_detalle()

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
                    Dim dts As New vCliente
                    Dim func As New fCliente

                    dts.gicliente = txtIdVenta.Text
                    dts.gnombre = txtidCliente.Text
                    ' dts.gapellidos = txtApellido.Text
                    'dts.gdireccion = txtDireccion.Text
                    dts.gtelefono = txtNumDoc.Text
                    '        dts.gci = txtCi.Text

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
        txtIdVenta.Text = datalistado.SelectedCells.Item(1).Value
        txtidCliente.Text = datalistado.SelectedCells.Item(4).Value
        txtNombreCLiente.Text = datalistado.SelectedCells.Item(3).Value
        dtpFecha.Text = datalistado.SelectedCells.Item(5).Value
        cbTipoDoc.Text = datalistado.SelectedCells.Item(6).Value
        txtNumDoc.Text = datalistado.SelectedCells.Item(7).Value

        btnEditar.Visible = True
        btnGuardar.Visible = False


    End Sub

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
                        Dim vdb As New vCliente
                        Dim func As New fCliente
                        vdb.gicliente = onekey

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

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()

    End Sub

    Private Sub cargar_detalle()
        frmDetalleVenta.txtIdVenta.Text = datalistado.SelectedCells.Item(1).Value
        frmDetalleVenta.txtidCliente.Text = datalistado.SelectedCells.Item(2).Value
        frmDetalleVenta.txtNombreCLiente.Text = datalistado.SelectedCells.Item(3).Value
        frmDetalleVenta.dtpFecha.Text = datalistado.SelectedCells.Item(5).Value
        frmDetalleVenta.cbTipoDoc.Text = datalistado.SelectedCells.Item(6).Value
        frmDetalleVenta.txtNumDoc.Text = datalistado.SelectedCells.Item(7).Value


        frmDetalleVenta.ShowDialog()

    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        cargar_detalle()

    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        frmCliente.txtFlag.Text = "1"
        frmCliente.ShowDialog()

    End Sub
End Class