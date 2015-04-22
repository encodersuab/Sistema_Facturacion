Public Class frmEditarProductoPostGrado

    Private Sub btnEditarNombreProd_Click(sender As Object, e As EventArgs) Handles btnEditarNombreProd.Click
        frmEditarProducto2PostGrado.gbdetalle.Visible = True
        frmEditarProducto2PostGrado.gbimagen.Visible = False
        frmEditarProducto2PostGrado.gbFechaVencimiento.Visible = False
        frmEditarProducto2PostGrado.txtflag.Text = 1
        frmEditarProducto2PostGrado.txtdescripcion.Text = Me.txtNombre.Text
        frmEditarProducto2PostGrado.lbnombreproducto.Text = l1.Text
        frmEditarProducto2PostGrado.ShowDialog()
    End Sub
End Class