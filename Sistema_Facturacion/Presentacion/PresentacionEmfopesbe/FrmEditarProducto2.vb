Public Class FrmEditarProducto2

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcionEditada.TextChanged

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea realizar los cambios en el Producto?", "Modificando registro", MessageBoxButtons.OKCancel)

        If result = DialogResult.OK Then


            Try
                Dim dts As New vProducto
                Dim func As New fProducto
                Dim dts1 As New vHistorialProducto
                Dim func1 As New fHistorialProducto

                dts.gidproducto = frmProducto.txtIdproducto.Text
                dts.gnombre = frmProducto.txtNombre.Text
                dts.gidcategoria = frmProducto.txtidcategoria.Text
                dts.gdescripcion = Me.txtdescripcionEditada.Text
                dts.gstock = frmProducto.txtstock.Text
                dts.gprecio_compra = frmProducto.txtprecio_compra.Text
                dts.gprecio_venta = frmProducto.txtprecio_venta.Text
                dts.gfecha_vencimiento = frmProducto.txtfecha_vencimiento.Text
                dts.gmodulo = frmProducto.cbbmodulo.Text
                dts.gmedida = frmProducto.txtmedida.Text
                Dim ms As New IO.MemoryStream()


                dts1.gidproducto = frmeditarproducto.txtIdproducto.Text
                dts1.gidusuario = 3
                dts1.gfechaModificacion = dtpfechaModificacion.Text
                dts1.gdescripcionAct = txtdescripcion.Text
                dts1.gdescripcionEdit = txtdescripcionEditada.Text
                dts1.gdetalle = txtdetalle.Text

                If Not frmeditarproducto.imagen.Image Is Nothing Then
                    frmeditarproducto.imagen.Image.Save(ms, frmeditarproducto.imagen.Image.RawFormat)
                Else
                    frmeditarproducto.imagen.Image = My.Resources.fondo_transparente_fotos
                    frmeditarproducto.imagen.Image.Save(ms, frmeditarproducto.imagen.Image.RawFormat)
                End If

                dts.gimagen = ms.GetBuffer

                If (func.editar(dts) And func1.insertar(dts1)) Then
                    MessageBox.Show("Producto modificado correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("Producto no fue modificado", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)


                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("error de datos faltante", "error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub FrmEditarProducto2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class