Public Class vProductoREDRUBI
    Dim idproducto, idcategoria As Integer
    Dim nombre, descripcion, modulo, medida As String
    Dim stock, precio_compra, precio_venta As Double
    Dim fecha_vencimiento As Date
    Dim imagen() As Byte
    Public Property gidproducto
        Get
            Return idproducto
        End Get
        Set(ByVal value)
            idproducto = value
        End Set
    End Property
    Public Property gidcategoria
        Get
            Return idcategoria
        End Get
        Set(ByVal value)
            idcategoria = value
        End Set
    End Property

    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(ByVal value)
            nombre = value
        End Set
    End Property
    Public Property gdescripcion
        Get
            Return descripcion
        End Get
        Set(ByVal value)
            descripcion = value
        End Set
    End Property
    Public Property gstock
        Get
            Return stock
        End Get
        Set(ByVal value)
            stock = value
        End Set
    End Property
    Public Property gprecio_compra
        Get
            Return precio_compra
        End Get
        Set(ByVal value)
            precio_compra = value
        End Set
    End Property
    Public Property gprecio_venta
        Get
            Return precio_venta
        End Get
        Set(ByVal value)
            precio_venta = value
        End Set
    End Property
    Public Property gfecha_vencimiento
        Get
            Return fecha_vencimiento
        End Get
        Set(ByVal value)
            fecha_vencimiento = value
        End Set
    End Property
    Public Property gimagen
        Get
            Return imagen
        End Get
        Set(ByVal value)
            imagen = value
        End Set
    End Property
    Public Property gmodulo
        Get
            Return modulo
        End Get
        Set(ByVal value)
            modulo = value
        End Set
    End Property
    Public Property gmedida
        Get
            Return medida
        End Get
        Set(ByVal value)
            medida = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal idproducto As Integer, ByVal idcategoria As Integer, ByVal nombre As String, ByVal descripcion As String, ByVal stock As Double, ByVal precio_venta As Double, ByVal precio_compra As Double, ByVal fecha_Vencimiento As Date, ByVal imagen As Image, ByVal modulo As String, ByVal medida As String)
        gidproducto = idproducto
        gidcategoria = idcategoria
        gnombre = nombre
        gdescripcion = descripcion
        gstock = stock
        gprecio_venta = precio_venta
        gprecio_compra = precio_compra
        gfecha_vencimiento = fecha_Vencimiento
        gimagen = imagen
        gmodulo = modulo
        gmedida = medida
    End Sub

End Class
