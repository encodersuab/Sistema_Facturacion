Public Class frmeditarproductoCAMPOFERIAL

    Private Sub btnEditarNombreProd_Click(sender As Object, e As EventArgs) Handles btnEditarNombreProd.Click
        frmEditarProducto2CAMPOFERIAL.gbdetalle.Visible = True
        frmEditarProducto2CAMPOFERIAL.gbimagen.Visible = False
        frmEditarProducto2CAMPOFERIAL.gbFechaVencimiento.Visible = False
        frmEditarProducto2CAMPOFERIAL.txtflag.Text = 1
        frmEditarProducto2CAMPOFERIAL.txtdescripcion.Text = Me.txtNombre.Text
        frmEditarProducto2CAMPOFERIAL.lbnombreproducto.Text = l1.Text
        frmEditarProducto2CAMPOFERIAL.ShowDialog()
    End Sub

    Private Sub btnEditarDescripcion_Click(sender As Object, e As EventArgs) Handles btnEditarDescripcion.Click
        frmEditarProducto2CAMPOFERIAL.gbdetalle.Visible = True
        frmEditarProducto2CAMPOFERIAL.gbimagen.Visible = False
        frmEditarProducto2CAMPOFERIAL.gbFechaVencimiento.Visible = False
        frmEditarProducto2CAMPOFERIAL.txtflag.Text = 2
        frmEditarProducto2CAMPOFERIAL.txtdescripcion.Text = Me.txtdescripcion.Text
        frmEditarProducto2CAMPOFERIAL.lbnombreproducto.Text = l2.Text
        frmEditarProducto2CAMPOFERIAL.ShowDialog()
    End Sub

    Private Sub btnEditarStock_Click(sender As Object, e As EventArgs) Handles btnEditarStock.Click
        frmEditarProducto2CAMPOFERIAL.gbdetalle.Visible = True
        frmEditarProducto2CAMPOFERIAL.gbimagen.Visible = False
        frmEditarProducto2CAMPOFERIAL.gbFechaVencimiento.Visible = False
        frmEditarProducto2CAMPOFERIAL.txtflag.Text = 3
        frmEditarProducto2CAMPOFERIAL.txtdescripcion.Text = Me.txtstock.Text
        frmEditarProducto2CAMPOFERIAL.lbnombreproducto.Text = l4.Text
        frmEditarProducto2CAMPOFERIAL.ShowDialog()
    End Sub

    Private Sub btnEditarPresioCompra_Click(sender As Object, e As EventArgs) Handles btnEditarPresioCompra.Click
        frmEditarProducto2CAMPOFERIAL.gbdetalle.Visible = True
        frmEditarProducto2CAMPOFERIAL.gbimagen.Visible = False
        frmEditarProducto2CAMPOFERIAL.gbFechaVencimiento.Visible = False
        frmEditarProducto2CAMPOFERIAL.txtflag.Text = 4
        frmEditarProducto2CAMPOFERIAL.txtdescripcion.Text = Me.txtprecio_compra.Text
        frmEditarProducto2CAMPOFERIAL.lbnombreproducto.Text = txtprecio_compra.Text
        frmEditarProducto2CAMPOFERIAL.ShowDialog()
    End Sub

    Private Sub btnEditarPresioVenta_Click(sender As Object, e As EventArgs) Handles btnEditarPresioVenta.Click
        frmEditarProducto2CAMPOFERIAL.gbdetalle.Visible = True
        frmEditarProducto2CAMPOFERIAL.gbimagen.Visible = False
        frmEditarProducto2CAMPOFERIAL.gbFechaVencimiento.Visible = False
        frmEditarProducto2CAMPOFERIAL.txtflag.Text = 5
        frmEditarProducto2CAMPOFERIAL.txtdescripcion.Text = Me.txtprecio_venta.Text
        frmEditarProducto2CAMPOFERIAL.lbnombreproducto.Text = l3.Text
        frmEditarProducto2CAMPOFERIAL.ShowDialog()
    End Sub

    Private Sub btnEditarFechaVenc_Click(sender As Object, e As EventArgs) Handles btnEditarFechaVenc.Click
        frmEditarProducto2CAMPOFERIAL.gbFechaVencimiento.Visible = True
        frmEditarProducto2CAMPOFERIAL.gbdetalle.Visible = False
        frmEditarProducto2CAMPOFERIAL.gbimagen.Visible = False
        frmEditarProducto2CAMPOFERIAL.txtflag.Text = 8
        frmEditarProducto2CAMPOFERIAL.dtpfecha_vencimientoActual.Text = Me.txtfecha_vencimiento.Text
        frmEditarProducto2CAMPOFERIAL.lbnombreproducto.Text = l5.Text
        frmEditarProducto2CAMPOFERIAL.ShowDialog()
    End Sub

    Private Sub btnEditarMedida_Click(sender As Object, e As EventArgs) Handles btnEditarMedida.Click
        frmEditarProducto2CAMPOFERIAL.gbFechaVencimiento.Visible = False
        frmEditarProducto2CAMPOFERIAL.gbdetalle.Visible = True
        frmEditarProducto2CAMPOFERIAL.gbimagen.Visible = False
        frmEditarProducto2CAMPOFERIAL.txtflag.Text = 6
        frmEditarProducto2CAMPOFERIAL.txtdescripcion.Text = Me.txtmedida.Text
        frmEditarProducto2CAMPOFERIAL.lbnombreproducto.Text = l6.Text
        frmEditarProducto2CAMPOFERIAL.ShowDialog()
    End Sub

    Private Sub btnEditarImagen_Click(sender As Object, e As EventArgs) Handles btnEditarImagen.Click
        frmEditarProducto2CAMPOFERIAL.txtflag.Text = 7
        frmEditarProducto2CAMPOFERIAL.gbdetalle.Visible = False
        frmEditarProducto2CAMPOFERIAL.gbFechaVencimiento.Visible = False
        frmEditarProducto2CAMPOFERIAL.gbimagen.Visible = True
        frmEditarProducto2CAMPOFERIAL.imagen.Image = Me.imagen.Image
        frmEditarProducto2CAMPOFERIAL.lbnombreproducto.Text = l7.Text
        frmEditarProducto2CAMPOFERIAL.ShowDialog()
    End Sub

    Private Sub frmeditarproductoCAMPOFERIAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class