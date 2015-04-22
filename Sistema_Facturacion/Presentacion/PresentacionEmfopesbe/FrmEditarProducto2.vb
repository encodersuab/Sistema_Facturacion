﻿Public Class FrmEditarProducto2
    Private Sub FrmEditarProducto2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      


    End Sub
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
                dts.gdescripcion = frmProducto.txtdescripcion.Text
                dts.gstock = frmProducto.txtstock.Text
                dts.gprecio_compra = frmProducto.txtprecio_compra.Text
                dts.gprecio_venta = frmProducto.txtprecio_venta.Text
                dts.gfecha_vencimiento = frmProducto.txtfecha_vencimiento.Text
                dts.gmodulo = frmProducto.cbbmodulo.Text
                dts.gmedida = frmProducto.txtmedida.Text
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
                    frmeditarproducto.txtNombre.Text = txtdescripcionEditada.Text
                Else
                    If txtflag.Text = 2 Then
                        dts.gdescripcion = Me.txtdescripcionEditada.Text
                        frmeditarproducto.txtdescripcion.Text = txtdescripcionEditada.Text
                    Else
                        If txtflag.Text = 3 Then
                            dts.gstock = Me.txtdescripcionEditada.Text
                            frmeditarproducto.txtstock.Text = txtdescripcionEditada.Text
                        Else
                            If txtflag.Text = 4 Then
                                dts.gprecio_compra = Me.txtdescripcionEditada.Text
                                frmeditarproducto.txtprecio_compra.Text = txtdescripcionEditada.Text
                            Else
                                If txtflag.Text = 5 Then
                                    dts.gprecio_venta = Me.txtdescripcionEditada.Text
                                    frmeditarproducto.txtprecio_venta.Text = txtdescripcionEditada.Text
                                Else
                                    If txtflag.Text = 6 Then
                                        dts.gmedida = Me.txtdescripcionEditada.Text
                                        frmeditarproducto.txtmedida.Text = txtdescripcionEditada.Text
                                    Else
                                        If txtflag.Text = 8 Then
                                            dts.gfecha_vencimiento = Me.dtpfecha_vencimientoNueva.Text()
                                            frmeditarproducto.txtfecha_vencimiento.Text = txtdescripcionEditada.Text
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
                    frmeditarproducto.imagen.Image = imagen.Image
                    dts.gimagen = ms.GetBuffer

                End If

                dts1.gidproducto = frmeditarproducto.txtIdproducto.Text
                dts1.gidusuario = frmInicioF.lbidusuario.Text
                dts1.gfechaModificacion = dtpfechaModificacion.Text
                dts1.gdescripcionAct = txtdescripcion.Text
                dts1.gdescripcionEdit = txtdescripcionEditada.Text
                dts1.gdetalle = txtdetalle.Text
                If txtflag.Text = 8 Then
                    dts1.gdescripcionAct = dtpfecha_vencimientoActual.Text
                    dts1.gdescripcionEdit = dtpfecha_vencimientoNueva.Text

                End If
                If Not frmeditarproducto.imagen.Image Is Nothing Then
                    frmeditarproducto.imagen.Image.Save(ms, frmeditarproducto.imagen.Image.RawFormat)
                Else
                    frmeditarproducto.imagen.Image = My.Resources.fondo_transparente_fotos
                    frmeditarproducto.imagen.Image.Save(ms, frmeditarproducto.imagen.Image.RawFormat)
                End If

                dts.gimagen = ms.GetBuffer

                If (func1.insertar(dts1) And func.editar(dts)) Then
                    MessageBox.Show("Producto modificado correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("Producto no fue modificado", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)



                End If
               
                Me.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("error de datos faltante", "error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

   

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        imagen.Image = Nothing
        imagen.BackgroundImage = My.Resources.fondo_transparente_fotos
        imagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub imagen_Click(sender As Object, e As EventArgs) Handles imagen.Click

    End Sub

    Private Sub btncargar_Click(sender As Object, e As EventArgs) Handles btncargar.Click

        If dlg.ShowDialog() = DialogResult.OK Then
            imagen.BackgroundImage = Nothing
            imagen.Image = New Bitmap(dlg.FileName)
            imagen.SizeMode = PictureBoxSizeMode.StretchImage


        End If
    End Sub

 
    Private Sub txtdetalle_TextChanged(sender As Object, e As EventArgs) Handles txtdetalle.TextChanged

    End Sub
End Class