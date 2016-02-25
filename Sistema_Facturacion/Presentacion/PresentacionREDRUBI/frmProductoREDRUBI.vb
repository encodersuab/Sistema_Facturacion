Public Class frmProductoREDRUBI
    Private dt As New DataTable
    Public Sub estadoCamposEdicion()
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btncategoria.Enabled = False
        txtstock.Enabled = False
        txtNombre.Enabled = False
        txtdescripcion.Enabled = False
        txtprecio_compra.Enabled = False
        txtprecio_venta.Enabled = False
        txtIdproducto.Enabled = False
        cbbModulo.Enabled = False
        txtfecha_vencimiento.Enabled = False
        btncargar.Enabled = False
        btnlimpiar.Enabled = False
        txtidcategoria.Enabled = False
        txtnom_categoria.Enabled = False
        txtmedida.Enabled = False
    End Sub
    Public Sub mostrarBotonEditar()
        If (frmInicioF.lbrol.Text = "CajeroREDRUBI") Then
            btnEditar.Visible = False
            btnGuardar.Visible = False
            btnNuevo.Visible = False
            btncargar.Visible = False
            btnlimpiar.Visible = False
        Else
            btnGuardar.Visible = False
            btnEditar.Visible = True
            btnNuevo.Visible = True
        End If

    End Sub
    Public Sub mostrarBotonGuardar()
        If (frmInicioF.lbrol.Text = "CajeroREDRUBI") Then
            btnEditar.Visible = False
            btnGuardar.Visible = False
            btnNuevo.Visible = False
            btncargar.Visible = False
            btnlimpiar.Visible = False
        Else
            btnGuardar.Visible = True
            btnEditar.Visible = False
            btnNuevo.Visible = True
        End If
    End Sub
    Public Sub frmProductoREDRUBI_Load() Handles MyBase.Load
        If frmInicioF.lbrol.Text = "UsuarioEMFOPESBE" Then
            btnEditar.Enabled = False
            btnNuevo.Enabled = False
            btncategoria.Enabled = False
            txtstock.Enabled = False
            txtNombre.Enabled = False
            txtdescripcion.Enabled = False
            txtprecio_compra.Enabled = False
            txtprecio_venta.Enabled = False
            txtIdproducto.Enabled = False
            cbbmodulo.Enabled = False
            txtfecha_vencimiento.Enabled = False
            btncargar.Enabled = False
            btnlimpiar.Enabled = False
            txtidcategoria.Enabled = False
            txtnom_categoria.Enabled = False
            txtmedida.Enabled = False
        End If
        limpiar()
        mostrar()
    End Sub

    Public Sub limpiar()
        mostrarBotonGuardar()
        txtNombre.Text = ""
        txtdescripcion.Text = ""
        'txtstock.Text = ""
        'txtprecio_compra.Text = ""
        txtprecio_venta.Text = ""
        txtIdproducto.Text = ""
        txtidcategoria.Text = ""
        txtnom_categoria.Text = ""
        'cbbmodulo.Text = ""

        imagen.Image = Nothing
        imagen.BackgroundImage = My.Resources.fondo_transparente_fotos
        imagen.SizeMode = PictureBoxSizeMode.StretchImage



    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fProductoREDRUBI
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
        mostrarBotonGuardar()

        Buscar()

    End Sub

    Private Sub Buscar()

        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            'dv.RowFilter = cbxListadoClientes.Text & " Like '" & txtBuscar.Text & "%'"
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
        datalistado.Columns(2).Visible = False
        datalistado.Columns(7).Visible = False
        datalistado.Columns(6).Visible = False
        datalistado.Columns(12).Visible = False
    End Sub

    'Private Sub txtNombre_Validated(sender As Object, e As EventArgs) Handles txtNombre.Validated
    '    If DirectCast(sender, TextBox).Text.Length > 0 Then
    '        Me.erroricono.SetError(sender, "")
    '    Else
    '        Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
    '    End If
    'End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtNombre.Text <> "" And txtstock.Text <> "" And txtprecio_compra.Text <> "" And txtprecio_venta.Text <> "" Then
            Try
                Dim dts As New vProductoREDRUBI
                Dim func As New fProductoREDRUBI

                dts.gnombre = txtNombre.Text
                dts.gidcategoria = txtidcategoria.Text
                dts.gdescripcion = txtdescripcion.Text
                dts.gstock = txtstock.Text
                dts.gprecio_compra = txtprecio_compra.Text
                dts.gprecio_venta = txtprecio_venta.Text
                dts.gfecha_vencimiento = txtfecha_vencimiento.Text
                dts.gmodulo = cbbmodulo.Text
                dts.gmedida = txtmedida.Text

                Dim ms As New IO.MemoryStream()
                If Not imagen.Image Is Nothing Then
                    imagen.Image.Save(ms, imagen.Image.RawFormat)
                Else
                    imagen.Image = My.Resources.fondo_transparente_fotos
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
        frmEditarProductoREDRUBI.txtIdproducto.Text = Me.txtIdproducto.Text
        frmEditarProductoREDRUBI.txtNombre.Text = Me.txtNombre.Text
        frmEditarProductoREDRUBI.txtidcategoria.Text = Me.txtidcategoria.Text
        frmEditarProductoREDRUBI.txtnom_categoria.Text = Me.txtnom_categoria.Text
        frmEditarProductoREDRUBI.txtdescripcion.Text = Me.txtdescripcion.Text
        frmEditarProductoREDRUBI.txtstock.Text = Me.txtstock.Text
        frmEditarProductoREDRUBI.txtprecio_compra.Text = Me.txtprecio_compra.Text
        frmEditarProductoREDRUBI.txtprecio_venta.Text = Me.txtprecio_venta.Text
        frmEditarProductoREDRUBI.txtfecha_vencimiento.Text = Me.txtfecha_vencimiento.Text
        frmEditarProductoREDRUBI.txtmedida.Text = Me.txtmedida.Text
        frmEditarProductoREDRUBI.imagen.Image = Me.imagen.Image



        frmEditarProductoREDRUBI.ShowDialog()
        'Dim result As DialogResult
        'result = MessageBox.Show("Realmente desea realizar los cambios en el Producto?", "Modificando registro", MessageBoxButtons.OKCancel)

        'If result = DialogResult.OK Then

        '    If Me.ValidateChildren = True And txtNombre.Text <> "" And txtdescripcion.Text <> "" And txtstock.Text <> "" And txtprecio_compra.Text <> "" And txtprecio_venta.Text <> "" And txtIdproducto.Text <> "" Then
        '        Try
        '            Dim dts As New vProductoREDRUBI
        '            Dim func As New fProductoREDRUBI

        '            dts.gidproducto = txtIdproducto.Text
        '            dts.gnombre = txtNombre.Text
        '            dts.gidcategoria = txtidcategoria.Text
        '            dts.gdescripcion = txtdescripcion.Text
        '            dts.gstock = txtstock.Text
        '            dts.gprecio_compra = txtprecio_compra.Text
        '            dts.gprecio_venta = txtprecio_venta.Text
        '            dts.gfecha_vencimiento = txtfecha_vencimiento.Text
        '            dts.gmodulo = cbbmodulo.Text
        '            dts.gmedida = txtmedida.Text
        '            Dim ms As New IO.MemoryStream()
        '            If Not imagen.Image Is Nothing Then
        '                imagen.Image.Save(ms, imagen.Image.RawFormat)
        '            Else
        '                imagen.Image = My.Resources.fondo_transparente_fotos
        '                imagen.Image.Save(ms, imagen.Image.RawFormat)
        '            End If

        '            dts.gimagen = ms.GetBuffer

        '            If func.editar(dts) Then
        '                MessageBox.Show("Producto modificado correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '                mostrar()
        '                limpiar()
        '            Else
        '                MessageBox.Show("Producto no fue modificado", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                mostrar()
        '                limpiar()

        '            End If

        '        Catch ex As Exception
        '            MsgBox(ex.Message)
        '        End Try
        '    Else
        '        MessageBox.Show("error de datos faltante", "error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

        '    End If
        'End If
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
        txtmedida.Text = datalistado.SelectedCells.Item(12).Value
        imagen.BackgroundImage = Nothing
        Dim b() As Byte = datalistado.SelectedCells.Item(10).Value
        Dim ms As New IO.MemoryStream(b)

        imagen.Image = Image.FromStream(ms)
        imagen.SizeMode = PictureBoxSizeMode.StretchImage


        mostrarBotonEditar()


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
        imagen.BackgroundImage = My.Resources.fondo_transparente_fotos
        imagen.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub btncategoria_Click(sender As Object, e As EventArgs) Handles btncategoria.Click
        frmCategoriaREDRUBI.txtflag.Text = "1"
        frmCategoriaREDRUBI.ShowDialog()
    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        Try
            If txtTag.Text = "1" Then
                frmDetalleVentaREDRUBI.txtIdProducto.Text = datalistado.SelectedCells.Item(1).Value
                frmDetalleVentaREDRUBI.txtNombreProducto.Text = datalistado.SelectedCells.Item(4).Value
                frmDetalleVentaREDRUBI.lbdetalle.Text = datalistado.SelectedCells.Item(5).Value
                frmDetalleVentaREDRUBI.txtPrecioUnitario.Text = datalistado.SelectedCells.Item(8).Value
                frmDetalleVentaREDRUBI.txtStock.Text = datalistado.SelectedCells.Item(6).Value
                frmDetalleVentaREDRUBI.lbmedida.Text = datalistado.SelectedCells.Item(12).Value
                Me.Close()

            Else
                frmDetalleVentaplanillaREDRUBI.txtIdProducto.Text = datalistado.SelectedCells.Item(1).Value
                frmDetalleVentaPlanillaREDRUBI.txtNombreProducto.Text = datalistado.SelectedCells.Item(4).Value
                frmDetalleVentaPlanillaREDRUBI.lbdetalle.Text = datalistado.SelectedCells.Item(5).Value
                frmDetalleVentaplanillaREDRUBI.txtPrecioUnitario.Text = datalistado.SelectedCells.Item(8).Value
                frmDetalleVentaplanillaREDRUBI.txtStock.Text = datalistado.SelectedCells.Item(6).Value
                frmDetalleVentaplanillaREDRUBI.lbmedida.Text = datalistado.SelectedCells.Item(12).Value
                Me.Close()


            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




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



    Private Sub txtprecio_compra_TextChanged(sender As Object, e As EventArgs) Handles txtprecio_compra.TextChanged

    End Sub

    Private Sub txtprecio_compra_Validated(sender As Object, e As EventArgs) Handles txtprecio_compra.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtprecio_venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio_venta.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar = _
                Threading.Thread.CurrentThread. _
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

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

    Private Sub imagen_Click(sender As Object, e As EventArgs) Handles imagen.Click

    End Sub

End Class