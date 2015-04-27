Public Class frmEditarProductoREDRUBI

   
  
    Private Sub btnEditarNombreProd_Click(sender As Object, e As EventArgs) Handles btnEditarNombreProd.Click
        frmEditarProducto2REDRUBI.gbdetalle.Visible = True
        frmEditarProducto2REDRUBI.gbimagen.Visible = False
        frmEditarProducto2REDRUBI.gbFechaVencimiento.Visible = False
        frmEditarProducto2REDRUBI.txtflag.Text = 1
        frmEditarProducto2REDRUBI.txtdescripcion.Text = Me.txtNombre.Text
        frmEditarProducto2REDRUBI.lbnombreproducto.Text = l1.Text
        frmEditarProducto2REDRUBI.dtpfecha_vencimientoNueva.Text = ""
        frmEditarProducto2REDRUBI.txtdescripcionEditada.Text = ""
        frmEditarProducto2REDRUBI.ShowDialog()
    End Sub

    Private Sub btnEditarDescripcion_Click(sender As Object, e As EventArgs) Handles btnEditarDescripcion.Click
        frmEditarProducto2REDRUBI.gbdetalle.Visible = True
        frmEditarProducto2REDRUBI.gbimagen.Visible = False
        frmEditarProducto2REDRUBI.gbFechaVencimiento.Visible = False
        frmEditarProducto2REDRUBI.txtflag.Text = 2
        frmEditarProducto2REDRUBI.txtdescripcion.Text = Me.txtdescripcion.Text
        frmEditarProducto2REDRUBI.lbnombreproducto.Text = l2.Text
        frmEditarProducto2REDRUBI.dtpfecha_vencimientoNueva.Text = ""
        frmEditarProducto2REDRUBI.txtdescripcionEditada.Text = ""
        frmEditarProducto2REDRUBI.ShowDialog()
    End Sub

    Private Sub btnEditarPresioVenta_Click(sender As Object, e As EventArgs) Handles btnEditarPresioVenta.Click
        frmEditarProducto2REDRUBI.gbdetalle.Visible = True
        frmEditarProducto2REDRUBI.gbimagen.Visible = False
        frmEditarProducto2REDRUBI.gbFechaVencimiento.Visible = False
        frmEditarProducto2REDRUBI.txtflag.Text = 5
        frmEditarProducto2REDRUBI.txtdescripcion.Text = Me.txtprecio_venta.Text
        frmEditarProducto2REDRUBI.lbnombreproducto.Text = l5.Text
        frmEditarProducto2REDRUBI.dtpfecha_vencimientoNueva.Text = ""
        frmEditarProducto2REDRUBI.txtdescripcionEditada.Text = ""
        frmEditarProducto2REDRUBI.ShowDialog()
    End Sub

    Private Sub btnEditarFechaVenc_Click(sender As Object, e As EventArgs) Handles btnEditarFechaVenc.Click
        frmEditarProducto2REDRUBI.gbFechaVencimiento.Visible = True
        frmEditarProducto2REDRUBI.gbdetalle.Visible = False
        frmEditarProducto2REDRUBI.gbimagen.Visible = False
        frmEditarProducto2REDRUBI.txtflag.Text = 8
        frmEditarProducto2REDRUBI.dtpfecha_vencimientoActual.Text = Me.txtfecha_vencimiento.Text
        frmEditarProducto2REDRUBI.lbnombreproducto.Text = l6.Text
        frmEditarProducto2REDRUBI.dtpfecha_vencimientoNueva.Text = ""
        frmEditarProducto2REDRUBI.txtdescripcionEditada.Text = ""
        frmEditarProducto2REDRUBI.ShowDialog()
    End Sub

    Private Sub btnEditarMedida_Click(sender As Object, e As EventArgs) Handles btnEditarMedida.Click
        frmEditarProducto2REDRUBI.gbdetalle.Visible = True
        frmEditarProducto2REDRUBI.gbimagen.Visible = False
        frmEditarProducto2REDRUBI.gbFechaVencimiento.Visible = False
        frmEditarProducto2REDRUBI.txtflag.Text = 6
        frmEditarProducto2REDRUBI.txtdescripcion.Text = Me.txtmedida.Text
        frmEditarProducto2REDRUBI.lbnombreproducto.Text = l7.Text
        frmEditarProducto2REDRUBI.dtpfecha_vencimientoNueva.Text = ""
        frmEditarProducto2REDRUBI.txtdescripcionEditada.Text = ""
        frmEditarProducto2REDRUBI.ShowDialog()
    End Sub

    Private Sub btnEditarImagen_Click(sender As Object, e As EventArgs) Handles btnEditarImagen.Click
        frmEditarProducto2REDRUBI.txtflag.Text = 7
        frmEditarProducto2REDRUBI.gbdetalle.Visible = False
        frmEditarProducto2REDRUBI.gbFechaVencimiento.Visible = False
        frmEditarProducto2REDRUBI.gbimagen.Visible = True
        frmEditarProducto2REDRUBI.dtpfecha_vencimientoNueva.Text = ""
        frmEditarProducto2REDRUBI.txtdescripcionEditada.Text = ""
        frmEditarProducto2REDRUBI.imagen.Image = Me.imagen.Image
        frmEditarProducto2REDRUBI.lbnombreproducto.Text = l8.Text
        frmEditarProducto2REDRUBI.ShowDialog()
    End Sub

    Private Sub frmEditarProductoREDRUBI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class