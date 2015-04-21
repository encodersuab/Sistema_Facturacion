Public Class frmUsuarios
    Private dt As New DataTable

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Public Sub limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtUsuario.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtCi.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtLogin.Text = ""
        txtPassword.Text = ""
        txtacceso.Text = ""

    End Sub
    Private Sub mostrar()
        Try
            Dim func As New fUsuario
            'If txtFlag.Text = 2 Then
            '    btnNuevo.Enabled = False
            '    btnGuardar.Enabled = False
            '    btnEditar.Enabled = False
            '    dt = func.mostrarUAB

            'ElseIf txtFlag.Text = 1 Or txtFlag.Text = 0 Then
            btnNuevo.Enabled = True
            btnGuardar.Enabled = True
            btnEditar.Enabled = True
            dt = func.mostrar
            'End If

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
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese apellidos del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged

    End Sub

    Private Sub txtDireccion_Validated(sender As Object, e As EventArgs) Handles txtDireccion.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese direccion del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged

    End Sub

    Private Sub txtTelefono_Validated(sender As Object, e As EventArgs) Handles txtTelefono.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el telefono del cliente, ese dato es obligatorio")
        End If
    End Sub

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
        If Me.ValidateChildren = True And txtNombre.Text <> "" And txtApellido.Text <> "" And txtDireccion.Text <> "" And txtTelefono.Text <> "" And txtCi.Text <> "" Then
            Try
                Dim dts As New vUsuario
                Dim func As New fUsuario

                dts.gnombre = txtNombre.Text
                dts.gapellidos = txtApellido.Text
                dts.gci = txtCi.Text
                dts.gdireccion = txtDireccion.Text
                dts.gtelefono = txtTelefono.Text
                dts.glogin = txtLogin.Text
                dts.gpassword = txtPassword.Text
                dts.gacceso = txtacceso.Text
                dts.grol = cbRol.Text



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

            If Me.ValidateChildren = True And txtNombre.Text <> "" And txtApellido.Text <> "" And txtDireccion.Text <> "" And txtTelefono.Text <> "" And txtCi.Text <> "" And txtUsuario.Text <> "" Then
                Try
                    Dim dts As New vUsuario
                    Dim func As New fUsuario

                    dts.gidusuario = txtUsuario.Text

                    dts.gnombre = txtNombre.Text
                    dts.gapellidos = txtApellido.Text
                    dts.gci = txtCi.Text
                    dts.gdireccion = txtDireccion.Text
                    dts.gtelefono = txtTelefono.Text
                    dts.glogin = txtLogin.Text
                    dts.gpassword = txtPassword.Text
                    dts.gacceso = txtacceso.Text
                    dts.grol = cbRol.Text


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

        txtUsuario.Text = datalistado.SelectedCells.Item(1).Value
        txtNombre.Text = datalistado.SelectedCells.Item(2).Value
        txtApellido.Text = datalistado.SelectedCells.Item(3).Value

        txtTelefono.Text = datalistado.SelectedCells.Item(4).Value

        txtDireccion.Text = datalistado.SelectedCells.Item(5).Value
        txtCi.Text = datalistado.SelectedCells.Item(6).Value
        txtLogin.Text = datalistado.SelectedCells.Item(7).Value
        txtPassword.Text = datalistado.SelectedCells.Item(8).Value
        txtacceso.Text = datalistado.SelectedCells.Item(9).Value
        cbRol.Text = datalistado.SelectedCells.Item(10).Value

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
            frmVenta.txtidCliente.Text = datalistado.SelectedCells.Item(1).Value
            frmVenta.txtNombreCLiente.Text = datalistado.SelectedCells.Item(2).Value
            frmVenta.txtNumDoc.Text = datalistado.SelectedCells.Item(6).Value
            frmVenta.txtNombreFac.Text = datalistado.SelectedCells.Item(2).Value + " " + datalistado.SelectedCells.Item(3).Value
            txtFlag.Text = "0"
            Me.Close()

        ElseIf txtFlag.Text = "2" Then
            frmVentaPlanilla.txtidCliente.Text = datalistado.SelectedCells.Item(1).Value
            frmVentaPlanilla.txtNombreCLiente.Text = datalistado.SelectedCells.Item(2).Value
            frmVentaPlanilla.txtNumDoc.Text = datalistado.SelectedCells.Item(6).Value
            frmVentaPlanilla.txtNombreFac.Text = datalistado.SelectedCells.Item(2).Value + " " + datalistado.SelectedCells.Item(3).Value
            txtFlag.Text = "0"
            Me.Close()
        End If


    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()

    End Sub

    Private Sub txtLogin_TextChanged(sender As Object, e As EventArgs) Handles txtLogin.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese un Valor de Login del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtLogin_Validated(sender As Object, e As EventArgs) Handles txtLogin.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese apellidos del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub txtPassword_Validated(sender As Object, e As EventArgs) Handles txtPassword.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese Un Password del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtacceso_TextChanged(sender As Object, e As EventArgs) Handles txtacceso.TextChanged

    End Sub

    Private Sub txtacceso_Validated(sender As Object, e As EventArgs) Handles txtacceso.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese un valor para Acceso, ese dato es obligatorio")
        End If
    End Sub

 
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class