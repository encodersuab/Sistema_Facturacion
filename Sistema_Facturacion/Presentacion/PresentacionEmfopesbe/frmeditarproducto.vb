Public Class frmeditarproducto

    

    
  
  

    Private Sub btnEditar_Click(sender As Object, e As EventArgs)

    End Sub



  
    Private Sub btnEditarNombreProd_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub btnEditarDescripcion_Click(sender As Object, e As EventArgs)
    
    End Sub

    Private Sub btnEditarStock_Click(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub btnEditarPresioCompra_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub btnEditarPresioVenta_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub btnEditarMedida_Click(sender As Object, e As EventArgs)
        
    End Sub

 
    Private Sub btnEditarImagen_Click(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub btnEditarFechaVenc_Click(sender As Object, e As EventArgs)

        
    End Sub

 
    Private Sub btnEditarNombreProd_Click_1(sender As Object, e As EventArgs) Handles btnEditarNombreProd.Click
        FrmEditarProducto2.gbdetalle.Visible = True
        FrmEditarProducto2.gbimagen.Visible = False
        FrmEditarProducto2.gbFechaVencimiento.Visible = False
        FrmEditarProducto2.txtflag.Text = 1
        FrmEditarProducto2.txtdescripcion.Text = Me.txtNombre.Text
        FrmEditarProducto2.lbnombreproducto.Text = l1.Text
        FrmEditarProducto2.dtpfecha_vencimientoNueva.Text = ""
        FrmEditarProducto2.txtdescripcionEditada.Text = ""
        FrmEditarProducto2.ShowDialog()
    End Sub

    Private Sub btnEditarDescripcion_Click_1(sender As Object, e As EventArgs) Handles btnEditarDescripcion.Click
        FrmEditarProducto2.gbdetalle.Visible = True
        FrmEditarProducto2.gbimagen.Visible = False
        FrmEditarProducto2.gbFechaVencimiento.Visible = False
        FrmEditarProducto2.txtflag.Text = 2
        FrmEditarProducto2.txtdescripcion.Text = Me.txtdescripcion.Text
        FrmEditarProducto2.lbnombreproducto.Text = l2.Text
        FrmEditarProducto2.dtpfecha_vencimientoNueva.Text = ""
        FrmEditarProducto2.txtdescripcionEditada.Text = ""
        FrmEditarProducto2.ShowDialog()
    End Sub

    Private Sub btnEditarStock_Click_1(sender As Object, e As EventArgs) Handles btnEditarStock.Click
        FrmEditarProducto2.gbdetalle.Visible = True
        FrmEditarProducto2.gbimagen.Visible = False
        FrmEditarProducto2.gbFechaVencimiento.Visible = False
        FrmEditarProducto2.txtflag.Text = 3
        FrmEditarProducto2.txtdescripcion.Text = Me.txtstock.Text
        FrmEditarProducto2.lbnombreproducto.Text = l3.Text
        FrmEditarProducto2.dtpfecha_vencimientoNueva.Text = ""
        FrmEditarProducto2.txtdescripcionEditada.Text = ""
        FrmEditarProducto2.ShowDialog()
    End Sub

    Private Sub btnEditarPresioCompra_Click_1(sender As Object, e As EventArgs) Handles btnEditarPresioCompra.Click
        FrmEditarProducto2.gbdetalle.Visible = True
        FrmEditarProducto2.gbimagen.Visible = False
        FrmEditarProducto2.gbFechaVencimiento.Visible = False
        FrmEditarProducto2.txtflag.Text = 4
        FrmEditarProducto2.txtdescripcion.Text = Me.txtprecio_compra.Text
        FrmEditarProducto2.lbnombreproducto.Text = l4.Text
        FrmEditarProducto2.dtpfecha_vencimientoNueva.Text = ""
        FrmEditarProducto2.txtdescripcionEditada.Text = ""
        FrmEditarProducto2.ShowDialog()
    End Sub

    Private Sub btnEditarPresioVenta_Click_1(sender As Object, e As EventArgs) Handles btnEditarPresioVenta.Click
        FrmEditarProducto2.gbdetalle.Visible = True
        FrmEditarProducto2.gbimagen.Visible = False
        FrmEditarProducto2.gbFechaVencimiento.Visible = False
        FrmEditarProducto2.txtflag.Text = 5
        FrmEditarProducto2.txtdescripcion.Text = Me.txtprecio_venta.Text
        FrmEditarProducto2.lbnombreproducto.Text = l5.Text
        FrmEditarProducto2.dtpfecha_vencimientoNueva.Text = ""
        FrmEditarProducto2.txtdescripcionEditada.Text = ""
        FrmEditarProducto2.ShowDialog()
    End Sub

    Private Sub btnEditarFechaVenc_Click_1(sender As Object, e As EventArgs) Handles btnEditarFechaVenc.Click
        FrmEditarProducto2.gbFechaVencimiento.Visible = True
        FrmEditarProducto2.gbdetalle.Visible = False
        FrmEditarProducto2.gbimagen.Visible = False
        FrmEditarProducto2.txtflag.Text = 8
        FrmEditarProducto2.dtpfecha_vencimientoActual.Text = Me.txtfecha_vencimiento.Text
        FrmEditarProducto2.lbnombreproducto.Text = l6.Text
        FrmEditarProducto2.dtpfecha_vencimientoNueva.Text = ""
        FrmEditarProducto2.txtdescripcionEditada.Text = ""
        FrmEditarProducto2.ShowDialog()
    End Sub

    Private Sub btnEditarMedida_Click_1(sender As Object, e As EventArgs) Handles btnEditarMedida.Click
        FrmEditarProducto2.gbdetalle.Visible = True
        FrmEditarProducto2.gbimagen.Visible = False
        FrmEditarProducto2.gbFechaVencimiento.Visible = False
        FrmEditarProducto2.txtflag.Text = 6
        FrmEditarProducto2.txtdescripcion.Text = Me.txtmedida.Text
        FrmEditarProducto2.lbnombreproducto.Text = l7.Text
        FrmEditarProducto2.dtpfecha_vencimientoNueva.Text = ""
        FrmEditarProducto2.txtdescripcionEditada.Text = ""
        FrmEditarProducto2.ShowDialog()
    End Sub

    Private Sub btnEditarImagen_Click_1(sender As Object, e As EventArgs) Handles btnEditarImagen.Click
        FrmEditarProducto2.txtflag.Text = 7
        FrmEditarProducto2.gbdetalle.Visible = False
        FrmEditarProducto2.gbFechaVencimiento.Visible = False
        FrmEditarProducto2.gbimagen.Visible = True
        FrmEditarProducto2.imagen.Image = Me.imagen.Image
        FrmEditarProducto2.lbnombreproducto.Text = l8.Text
        FrmEditarProducto2.dtpfecha_vencimientoNueva.Text = ""
        FrmEditarProducto2.txtdescripcionEditada.Text = ""
        FrmEditarProducto2.ShowDialog()
    End Sub

    Private Sub frmeditarproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class