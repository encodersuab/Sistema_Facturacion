Public Class frmClienteREDRUBI
    Private dt As New DataTable
    Private Sub frmClienteREDRUBI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Public Sub limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtIdCliente.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtCi.Text = ""


    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fClienteREDRUBI
            If txtFlag.Text = 2 Then
                btnNuevo.Enabled = False
                btnGuardar.Enabled = False
                btnEditar.Enabled = False
                dt = func.mostrarUAB

            ElseIf txtFlag.Text = 1 Or txtFlag.Text = 0 Then
                btnNuevo.Enabled = True
                btnGuardar.Enabled = True
                btnEditar.Enabled = True
                dt = func.mostrar
            End If

            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtBuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                Inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                txtBuscar.Enabled = False
                datalistado.ColumnHeadersVisible = True
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

            dv.RowFilter = cbxListadoClientes.Text & " Like '%" & txtBuscar.Text & "%'"

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
    End Sub

    'Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged

    'End Sub

    'Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    'End Sub

    Private Sub txtIdCliente_TextChanged(sender As Object, e As EventArgs) Handles txtIdCliente.TextChanged

    End Sub

    Private Sub txtIdCliente_Validated(sender As Object, e As EventArgs) Handles txtIdCliente.Validated

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtNombre_Validated(sender As Object, e As EventArgs) Handles txtNombre.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged

    End Sub

    Private Sub txtApellido_Validated(sender As Object, e As EventArgs) Handles txtApellido.Validated
        'If DirectCast(sender, TextBox).Text.Length > 0 Then
        '    Me.erroricono.SetError(sender, "")
        'Else
        '    Me.erroricono.SetError(sender, "ingrese apellidos del cliente, ese dato es obligatorio")
        'End If
    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged

    End Sub

    'Private Sub txtDireccion_Validated(sender As Object, e As EventArgs) Handles txtDireccion.Validated
    '    If DirectCast(sender, TextBox).Text.Length > 0 Then
    '        Me.erroricono.SetError(sender, "")
    '    Else
    '        Me.erroricono.SetError(sender, "ingrese direccion del cliente, ese dato es obligatorio")
    '    End If
    'End Sub

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged

    End Sub

    'Private Sub txtTelefono_Validated(sender As Object, e As EventArgs) Handles txtTelefono.Validated
    '    If DirectCast(sender, TextBox).Text.Length > 0 Then
    '        Me.erroricono.SetError(sender, "")
    '    Else
    '        Me.erroricono.SetError(sender, "ingrese el telefono del cliente, ese dato es obligatorio")
    '    End If
    'End Sub

    Private Sub txtCi_TextChanged(sender As Object, e As EventArgs) Handles txtCi.TextChanged

    End Sub

    Private Sub txtCi_Validated(sender As Object, e As EventArgs) Handles txtCi.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese carnet de identidad del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtNombre.Text <> "" And txtCi.Text <> "" Then
            Try
                Dim dts As New vClienteREDRUBI
                Dim func As New fClienteREDRUBI

                dts.gnombre = txtNombre.Text
                dts.gapellidos = txtApellido.Text
                dts.gdireccion = txtDireccion.Text
                dts.gtelefono = txtTelefono.Text
                dts.gci = txtCi.Text
                dts.gfuncionario = "---"

                If func.insertar(dts) Then
                    MessageBox.Show("cliente registrado correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("cliente no registrado", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

            If Me.ValidateChildren = True And txtNombre.Text <> "" And txtCi.Text <> "" And txtIdCliente.Text <> "" Then
                Try
                    Dim dts As New vClienteREDRUBI
                    Dim func As New fClienteREDRUBI

                    dts.gicliente = txtIdCliente.Text
                    dts.gnombre = txtNombre.Text
                    dts.gapellidos = txtApellido.Text
                    dts.gdireccion = txtDireccion.Text
                    dts.gtelefono = txtTelefono.Text
                    dts.gci = txtCi.Text

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
        txtIdCliente.Text = datalistado.SelectedCells.Item(1).Value
        txtNombre.Text = datalistado.SelectedCells.Item(2).Value
        txtApellido.Text = datalistado.SelectedCells.Item(3).Value
        txtDireccion.Text = datalistado.SelectedCells.Item(4).Value
        txtTelefono.Text = datalistado.SelectedCells.Item(5).Value
        txtCi.Text = datalistado.SelectedCells.Item(6).Value

        btnEditar.Visible = True
        btnGuardar.Visible = False


    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub





    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()

    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If txtFlag.Text = "1" Then
            frmVentaREDRUBI.txtidCliente.Text = datalistado.SelectedCells.Item(1).Value
            frmVentaREDRUBI.txtNombreCLiente.Text = datalistado.SelectedCells.Item(2).Value
            frmVentaREDRUBI.txtNumDoc.Text = datalistado.SelectedCells.Item(6).Value
            frmVentaREDRUBI.txtNombreFac.Text = datalistado.SelectedCells.Item(2).Value + " " + datalistado.SelectedCells.Item(3).Value
            txtFlag.Text = "0"
            Me.Close()

        ElseIf txtFlag.Text = "2" Then
            frmVentaPlanillaREDRUBI.txtidCliente.Text = datalistado.SelectedCells.Item(1).Value
            frmVentaPlanillaREDRUBI.txtNombreCLiente.Text = datalistado.SelectedCells.Item(2).Value
            frmVentaPlanillaREDRUBI.txtNumDoc.Text = datalistado.SelectedCells.Item(6).Value
            frmVentaPlanillaREDRUBI.txtNombreFac.Text = datalistado.SelectedCells.Item(2).Value + " " + datalistado.SelectedCells.Item(3).Value
            txtFlag.Text = "0"
            Me.Close()
        End If


    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()

    End Sub

    Private Sub Inexistente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Inexistente.LinkClicked

    End Sub

    Private Sub cbxListadoClientes_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

End Class