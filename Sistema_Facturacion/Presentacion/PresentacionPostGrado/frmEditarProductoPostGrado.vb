Public Class frmEditarProductoPostGrado

    Private Sub btnEditarNombreProd_Click(sender As Object, e As EventArgs) Handles btnEditarNombreProd.Click
        frmEditarProducto2PostGrado.gbdetalle.Visible = True
        frmEditarProducto2PostGrado.gbimagen.Visible = False
        frmEditarProducto2PostGrado.gbFechaVencimiento.Visible = False
        frmEditarProducto2PostGrado.txtflag.Text = 1
        frmEditarProducto2PostGrado.txtdescripcion.Text = Me.txtNombre.Text
        frmEditarProducto2PostGrado.lbnombreproducto.Text = l1.Text
        frmEditarProducto2PostGrado.dtpfecha_vencimientoNueva.Text = ""
        frmEditarProducto2PostGrado.txtdescripcionEditada.Text = ""
        frmEditarProducto2PostGrado.ShowDialog()
    End Sub

    Private Sub btnEditarDescripcion_Click(sender As Object, e As EventArgs) Handles btnEditarDescripcion.Click
        frmEditarProducto2PostGrado.gbdetalle.Visible = True
        frmEditarProducto2PostGrado.gbimagen.Visible = False
        frmEditarProducto2PostGrado.gbFechaVencimiento.Visible = False
        frmEditarProducto2PostGrado.txtflag.Text = 2
        frmEditarProducto2PostGrado.txtdescripcion.Text = Me.txtdescripcion.Text
        frmEditarProducto2PostGrado.lbnombreproducto.Text = l2.Text
        frmEditarProducto2PostGrado.dtpfecha_vencimientoNueva.Text = ""
        frmEditarProducto2PostGrado.txtdescripcionEditada.Text = ""
        frmEditarProducto2PostGrado.ShowDialog()
    End Sub

    Private Sub btnEditarPresioVenta_Click(sender As Object, e As EventArgs) Handles btnEditarPresioVenta.Click
        frmEditarProducto2PostGrado.gbdetalle.Visible = True
        frmEditarProducto2PostGrado.gbimagen.Visible = False
        frmEditarProducto2PostGrado.gbFechaVencimiento.Visible = False
        frmEditarProducto2PostGrado.txtflag.Text = 5
        frmEditarProducto2PostGrado.txtdescripcion.Text = Me.txtprecio_venta.Text
        frmEditarProducto2PostGrado.lbnombreproducto.Text = l3.Text
        frmEditarProducto2PostGrado.dtpfecha_vencimientoNueva.Text = ""
        frmEditarProducto2PostGrado.txtdescripcionEditada.Text = ""
        frmEditarProducto2PostGrado.ShowDialog()
    End Sub

    Private Sub btnEditarStock_Click(sender As Object, e As EventArgs) Handles btnEditarStock.Click
        frmEditarProducto2PostGrado.gbdetalle.Visible = True
        frmEditarProducto2PostGrado.gbimagen.Visible = False
        frmEditarProducto2PostGrado.gbFechaVencimiento.Visible = False
        frmEditarProducto2PostGrado.txtflag.Text = 3
        frmEditarProducto2PostGrado.txtdescripcion.Text = Me.txtstock.Text
        frmEditarProducto2PostGrado.lbnombreproducto.Text = l4.Text
        frmEditarProducto2PostGrado.dtpfecha_vencimientoNueva.Text = ""
        frmEditarProducto2PostGrado.txtdescripcionEditada.Text = ""
        frmEditarProducto2PostGrado.ShowDialog()
    End Sub

    Private Sub btnEditarFechaVenc_Click(sender As Object, e As EventArgs) Handles btnEditarFechaVenc.Click
        frmEditarProducto2PostGrado.gbFechaVencimiento.Visible = True
        frmEditarProducto2PostGrado.gbdetalle.Visible = False
        frmEditarProducto2PostGrado.gbimagen.Visible = False
        frmEditarProducto2PostGrado.txtflag.Text = 8
        frmEditarProducto2PostGrado.dtpfecha_vencimientoActual.Text = Me.txtfecha_vencimiento.Text
        frmEditarProducto2PostGrado.lbnombreproducto.Text = l5.Text
        frmEditarProducto2PostGrado.dtpfecha_vencimientoNueva.Text = ""
        frmEditarProducto2PostGrado.txtdescripcionEditada.Text = ""
        frmEditarProducto2PostGrado.ShowDialog()
    End Sub

    Private Sub btnEditarMedida_Click(sender As Object, e As EventArgs) Handles btnEditarMedida.Click
        frmEditarProducto2PostGrado.gbdetalle.Visible = True
        frmEditarProducto2PostGrado.gbimagen.Visible = False
        frmEditarProducto2PostGrado.gbFechaVencimiento.Visible = False
        frmEditarProducto2PostGrado.txtflag.Text = 6
        frmEditarProducto2PostGrado.txtdescripcion.Text = Me.txtmedida.Text
        frmEditarProducto2PostGrado.lbnombreproducto.Text = l6.Text
        frmEditarProducto2PostGrado.dtpfecha_vencimientoNueva.Text = ""
        frmEditarProducto2PostGrado.txtdescripcionEditada.Text = ""
        frmEditarProducto2PostGrado.ShowDialog()
    End Sub

    Private Sub btnEditarImagen_Click(sender As Object, e As EventArgs) Handles btnEditarImagen.Click
        frmEditarProducto2PostGrado.txtflag.Text = 7
        frmEditarProducto2PostGrado.gbdetalle.Visible = False
        frmEditarProducto2PostGrado.gbFechaVencimiento.Visible = False
        frmEditarProducto2PostGrado.gbimagen.Visible = True
        frmEditarProducto2PostGrado.dtpfecha_vencimientoNueva.Text = ""
        frmEditarProducto2PostGrado.txtdescripcionEditada.Text = ""
        frmEditarProducto2PostGrado.imagen.Image = Me.imagen.Image
        frmEditarProducto2PostGrado.lbnombreproducto.Text = l7.Text
        frmEditarProducto2PostGrado.ShowDialog()
    End Sub

    Private Sub frmEditarProductoPostGrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class