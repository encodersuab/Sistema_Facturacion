Public Class frmProducto

    Private dt As New DataTable
    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmInicioF.lbrol.Text = "UsuarioEMFOPESBE" Then
            btnEditar.Enabled = False
            btnNuevo.Enabled = False

        End If



        mostrar()

    End Sub

    Public Sub limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtNombre.Text = ""
        txtdescripcion.Text = ""
        txtstock.Text = "0"
        txtprecio_compra.Text = "0"
        txtprecio_venta.Text = "0"
        txtIdproducto.Text = ""
        cbbmodulo.Text = ""

        imagen.Image = Nothing
        '   imagen.BackgroundImage = My.Resources.fondo_transparente_fotos
        imagen.SizeMode = PictureBoxSizeMode.StretchImage



    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fProducto
            dt = func.mostrar
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
        datalistado.Columns(2).Visible = False

    End Sub

    Private Sub txtNombre_Validated(sender As Object, e As EventArgs) Handles txtNombre.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtNombre.Text <> "" And txtdescripcion.Text <> "" And txtstock.Text <> "" And txtprecio_compra.Text <> "" And txtprecio_venta.Text <> "" Then
            Try
                Dim dts As New vProducto
                Dim func As New fProducto

                dts.gnombre = txtNombre.Text
                dts.gidcategoria = txtidcategoria.Text
                dts.gdescripcion = txtdescripcion.Text
                dts.gstock = txtstock.Text
                dts.gprecio_compra = txtprecio_compra.Text
                dts.gprecio_venta = txtprecio_venta.Text
                dts.gfecha_vencimiento = txtfecha_vencimiento.Text
                dts.gmodulo = cbbmodulo.Text

                Dim ms As New IO.MemoryStream()
                If Not imagen.Image Is Nothing Then
                    imagen.Image.Save(ms, imagen.Image.RawFormat)
                Else
                    '              imagen.Image = My.Resources.fondo_transparente_fotos
                    imagen.Image.Save(ms, imagen.Image.RawFormat)
                End If

                dts.gimagen = ms.GetBuffer

                If func.insertar(dts) Then
                    MessageBox.Show("Producto registrado correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Producto no fue registrado", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        result = MessageBox.Show("Realmente desea realizar los cambios en el Producto?", "Modificando registro", MessageBoxButtons.OKCancel)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtNombre.Text <> "" And txtdescripcion.Text <> "" And txtstock.Text <> "" And txtprecio_compra.Text <> "" And txtprecio_venta.Text <> "" And txtIdproducto.Text <> "" Then
                Try
                    Dim dts As New vProducto
                    Dim func As New fProducto

                    dts.gidproducto = txtIdproducto.Text
                    dts.gnombre = txtNombre.Text
                    dts.gidcategoria = txtidcategoria.Text
                    dts.gdescripcion = txtdescripcion.Text
                    dts.gstock = txtstock.Text
                    dts.gprecio_compra = txtprecio_compra.Text
                    dts.gprecio_venta = txtprecio_venta.Text
                    dts.gfecha_vencimiento = txtfecha_vencimiento.Text
                    dts.gmodulo = cbbmodulo.Text
                    Dim ms As New IO.MemoryStream()
                    If Not imagen.Image Is Nothing Then
                        imagen.Image.Save(ms, imagen.Image.RawFormat)
                    Else
                        '    imagen.Image = My.Resources.fondo_transparente_fotos
                        imagen.Image.Save(ms, imagen.Image.RawFormat)
                    End If

                    dts.gimagen = ms.GetBuffer

                    If func.editar(dts) Then
                        MessageBox.Show("Producto modificado correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Producto no fue modificado", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtIdproducto.Text = datalistado.SelectedCells.Item(1).Value
        txtidcategoria.Text = datalistado.SelectedCells.Item(2).Value
        txtnom_categoria.Text = datalistado.SelectedCells.Item(3).Value
        txtNombre.Text = datalistado.SelectedCells.Item(4).Value
        txtdescripcion.Text = datalistado.SelectedCells.Item(5).Value
        txtstock.Text = datalistado.SelectedCells.Item(6).Value
        txtprecio_compra.Text = datalistado.SelectedCells.Item(7).Value
        txtprecio_venta.Text = datalistado.SelectedCells.Item(8).Value
        txtfecha_vencimiento.Text = datalistado.SelectedCells.Item(9).Value
        cbbmodulo.Text = datalistado.SelectedCells.Item(11).Value

        imagen.BackgroundImage = Nothing
        Dim b() As Byte = datalistado.SelectedCells.Item(10).Value
        Dim ms As New IO.MemoryStream(b)

        imagen.Image = Image.FromStream(ms)
        imagen.SizeMode = PictureBoxSizeMode.StretchImage


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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btncargar_Click(sender As Object, e As EventArgs) Handles btncargar.Click

        If dlg.ShowDialog() = DialogResult.OK Then
            imagen.BackgroundImage = Nothing
            imagen.Image = New Bitmap(dlg.FileName)
            imagen.SizeMode = PictureBoxSizeMode.StretchImage


        End If


    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        imagen.Image = Nothing
        '  imagen.BackgroundImage = My.Resources.fondo_transparente_fotos
        imagen.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub btncategoria_Click(sender As Object, e As EventArgs) Handles btncategoria.Click
        frmCategoria.txtflag.Text = "1"
        frmCategoria.ShowDialog()
    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If txtTag.Text = "1" Then
            frmDetalleVenta.txtIdProducto.Text = datalistado.SelectedCells.Item(1).Value
            frmDetalleVenta.txtNombreProducto.Text = datalistado.SelectedCells.Item(4).Value
            frmDetalleVenta.txtPrecioUnitario.Text = datalistado.SelectedCells.Item(8).Value
            frmDetalleVenta.txtStock.Text = datalistado.SelectedCells.Item(6).Value

            Me.Close()
        End If
    End Sub

    Private Sub datalistado_CellErrorTextChanged(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellErrorTextChanged


    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub cbxListadoClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxListadoClientes.SelectedIndexChanged

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtIdproducto_TextChanged(sender As Object, e As EventArgs) Handles txtIdproducto.TextChanged

    End Sub

    Private Sub txtstock_TextChanged(sender As Object, e As EventArgs) Handles txtstock.TextChanged

    End Sub

    Private Sub txtstock_Validated(sender As Object, e As EventArgs) Handles txtstock.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtdescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcion.TextChanged

    End Sub

    Private Sub txtdescripcion_Validated(sender As Object, e As EventArgs) Handles txtdescripcion.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtprecio_compra_TextChanged(sender As Object, e As EventArgs) Handles txtprecio_compra.TextChanged

    End Sub

    Private Sub txtprecio_compra_Validated(sender As Object, e As EventArgs) Handles txtprecio_compra.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtprecio_venta_TextChanged(sender As Object, e As EventArgs) Handles txtprecio_venta.TextChanged

    End Sub

    Private Sub txtprecio_venta_Validated(sender As Object, e As EventArgs) Handles txtprecio_venta.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub
End Class