Public Class frmEditarProducto2PostGrado

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Me.ValidateChildren = True And txtdetalle.Text <> "" Then

            Dim result As DialogResult
            result = MessageBox.Show("Realmente desea realizar los cambios en el Producto?", "Modificando registro", MessageBoxButtons.OKCancel)

            If result = DialogResult.OK Then


                Try



                    Dim dts As New vProducto
                    Dim func As New fProducto
                    Dim dts1 As New vHistorialProducto
                    Dim func1 As New fHistorialProducto

                    dts.gidproducto = frmProductoPostGrado.txtIdproducto.Text
                    dts.gnombre = frmProductoPostGrado.txtNombre.Text
                    dts.gidcategoria = frmProductoPostGrado.txtidcategoria.Text
                    dts.gdescripcion = frmProductoPostGrado.txtdescripcion.Text
                    dts.gstock = frmProductoPostGrado.txtstock.Text
                    dts.gprecio_compra = frmProductoPostGrado.txtprecio_compra.Text
                    dts.gprecio_venta = frmProductoPostGrado.txtprecio_venta.Text
                    dts.gfecha_vencimiento = frmProductoPostGrado.txtfecha_vencimiento.Text
                    dts.gmodulo = frmProductoPostGrado.cbbmodulo.Text
                    dts.gmedida = frmProductoPostGrado.txtmedida.Text
                    Dim ms As New IO.MemoryStream()


                    'If Not imagen.Image Is Nothing Then
                    '    imagen.Image.Save(ms, imagen.Image.RawFormat)
                    'Else
                    '    imagen.Image = My.Resources.fondo_transparente_fotos
                    '    imagen.Image.Save(ms, imagen.Image.RawFormat)
                    'End If

                    'dts.gimagen = ms.GetBuffer


                    If txtflag.Text = 1 Then
                        dts.gnombre = Me.txtdescripcionEditada.Text
                        frmEditarProductoPostGrado.txtNombre.Text = txtdescripcionEditada.Text
                    Else
                        If txtflag.Text = 2 Then
                            dts.gdescripcion = Me.txtdescripcionEditada.Text
                            frmEditarProductoPostGrado.txtdescripcion.Text = txtdescripcionEditada.Text
                        Else
                            If txtflag.Text = 3 Then
                                dts.gstock = Me.txtdescripcionEditada.Text
                                frmEditarProductoPostGrado.txtstock.Text = txtdescripcionEditada.Text
                            Else
                                If txtflag.Text = 4 Then
                                    dts.gprecio_compra = Me.txtdescripcionEditada.Text
                                    frmEditarProductoPostGrado.txtprecio_compra.Text = txtdescripcionEditada.Text
                                Else
                                    If txtflag.Text = 5 Then
                                        dts.gprecio_venta = Me.txtdescripcionEditada.Text
                                        frmEditarProductoPostGrado.txtprecio_venta.Text = txtdescripcionEditada.Text
                                    Else
                                        If txtflag.Text = 6 Then
                                            dts.gmedida = Me.txtdescripcionEditada.Text
                                            frmEditarProductoPostGrado.txtmedida.Text = txtdescripcionEditada.Text
                                        Else
                                            If txtflag.Text = 8 Then
                                                dts.gfecha_vencimiento = Me.dtpfecha_vencimientoNueva.Text()
                                                frmEditarProductoPostGrado.txtfecha_vencimiento.Text = txtdescripcionEditada.Text
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    If txtflag.Text = 7 Then
                        gbdetalle.Visible = False
                        gbimagen.Visible = True
                        If Not imagen.Image Is Nothing Then
                            imagen.Image.Save(ms, imagen.Image.RawFormat)
                        Else
                            imagen.Image = My.Resources.fondo_transparente_fotos
                            imagen.Image.Save(ms, imagen.Image.RawFormat)

                        End If
                        frmEditarProductoPostGrado.imagen.Image = imagen.Image
                        dts.gimagen = ms.GetBuffer

                    End If

                    dts1.gidproducto = frmEditarProductoPostGrado.txtIdproducto.Text
                    dts1.gidusuario = frmInicioF.lbidusuario.Text
                    dts1.gfechaModificacion = dtpfechaModificacion.Text
                    dts1.gdescripcionAct = txtdescripcion.Text
                    dts1.gdescripcionEdit = txtdescripcionEditada.Text
                    dts1.gdetalle = txtdetalle.Text
                    If txtflag.Text = 8 Then
                        dts1.gdescripcionAct = dtpfecha_vencimientoActual.Text
                        dts1.gdescripcionEdit = dtpfecha_vencimientoNueva.Text

                    End If
                    If Not frmEditarProductoPostGrado.imagen.Image Is Nothing Then
                        frmEditarProductoPostGrado.imagen.Image.Save(ms, frmeditarproducto.imagen.Image.RawFormat)
                    Else
                        frmEditarProductoPostGrado.imagen.Image = My.Resources.fondo_transparente_fotos
                        frmEditarProductoPostGrado.imagen.Image.Save(ms, frmeditarproducto.imagen.Image.RawFormat)
                    End If

                    dts.gimagen = ms.GetBuffer

                    If (func1.insertar(dts1) And func.editar(dts)) Then
                        MessageBox.Show("Producto modificado correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        MessageBox.Show("Producto no fue modificado", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)



                    End If

                    frmEditarProductoPostGrado.Close()
                    frmProductoPostGrado.frmProductoPostGrado_Load()
                    Me.Close()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("error de datos faltante", "error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Else
            MessageBox.Show("error de datos faltante", "error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub frmEditarProducto2PostGrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdetalle.Text = ""
    End Sub
End Class