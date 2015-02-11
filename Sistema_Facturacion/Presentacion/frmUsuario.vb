Public Class frmUsuario
    Private dt As New DataTable
    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()

    End Sub
    Public Sub limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtIdUsuario.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtCi.Text = ""
        txtLogin.Text = ""
        txtContraceña.Text = ""
        txtAcceso.Text = ""
        txtRol.Text = "Administrador"


    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fUsuario
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
                '    ocultar_columnas()
            Else
                Inexistente.Visible = True
                datalistado.DataSource = Nothing
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtNombre.Text <> "" And txtApellido.Text <> "" And txtDireccion.Text <> "" And txtTelefono.Text <> "" And txtCi.Text <> "" And txtLogin.Text <> "" And txtContraceña.Text <> "" And txtAcceso.Text <> "" And txtRol.Text <> "" Then
            Try
                Dim dts As New vUsuario
                Dim func As New fUsuario

                dts.gnombre = txtNombre.Text
                dts.gapellidos = txtApellido.Text
                dts.gdireccion = txtDireccion.Text
                dts.gtelefono = txtTelefono.Text
                dts.gci = txtCi.Text
                dts.glogin = txtLogin.Text
                dts.gpassword = txtContraceña.Text
                dts.gacceso = txtAcceso.Text
                dts.grol = txtRol.Text

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

            If Me.ValidateChildren = True And txtNombre.Text <> "" And txtApellido.Text <> "" And txtDireccion.Text <> "" And txtTelefono.Text <> "" And txtCi.Text <> "" And txtIdUsuario.Text <> "" And txtLogin.Text <> "" And txtContraceña.Text <> "" And txtAcceso.Text <> "" And txtRol.Text <> "" Then
                Try
                    Dim dts As New vUsuario
                    Dim func As New fUsuario

                    dts.gidusuario = txtIdUsuario.Text
                    dts.gnombre = txtNombre.Text
                    dts.gapellidos = txtApellido.Text
                    dts.gdireccion = txtDireccion.Text
                    dts.gtelefono = txtTelefono.Text
                    dts.gci = txtCi.Text
                    dts.glogin = txtLogin.Text
                    dts.gpassword = txtContraceña.Text
                    dts.gacceso = txtAcceso.Text
                    dts.grol = txtRol.Text


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

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtIdUsuario.Text = datalistado.SelectedCells.Item(1).Value
        txtNombre.Text = datalistado.SelectedCells.Item(2).Value
        txtApellido.Text = datalistado.SelectedCells.Item(3).Value
        txtCi.Text = datalistado.SelectedCells.Item(4).Value
        txtDireccion.Text = datalistado.SelectedCells.Item(5).Value
        txtTelefono.Text = datalistado.SelectedCells.Item(6).Value

        txtLogin.Text = datalistado.SelectedCells.Item(7).Value
        txtContraceña.Text = datalistado.SelectedCells.Item(8).Value
        txtAcceso.Text = datalistado.SelectedCells.Item(9).Value
        txtRol.Text = datalistado.SelectedCells.Item(10).Value

        btnEditar.Visible = True
        btnGuardar.Visible = False

    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)

    End Sub
End Class