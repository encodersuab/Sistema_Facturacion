Public Class vDetalleVentaPostGrado
    Dim iddetalle_venta, idventa, idproducto As Integer
    Dim cantidad, precio_unitario As Double
    Dim imagen() As Byte
    Dim validez, ncuota As String


    Public Property giddedatlle_venta

        Get
            Return iddetalle_venta
        End Get
        Set(ByVal value)
            iddetalle_venta = value
        End Set
    End Property
    Public Property gidventa

        Get
            Return idventa
        End Get
        Set(ByVal value)
            idventa = value
        End Set
    End Property
    Public Property gidproducto

        Get
            Return idproducto
        End Get
        Set(ByVal value)
            idproducto = value
        End Set
    End Property
    Public Property gcantidad

        Get
            Return cantidad
        End Get
        Set(ByVal value)
            cantidad = value
        End Set
    End Property
    Public Property gprecio_unitario

        Get
            Return precio_unitario
        End Get
        Set(ByVal value)
            precio_unitario = value
        End Set
    End Property
    Public Property gimagen
        Get
            Return imagen
        End Get
        Set(value)
            imagen = value
        End Set
    End Property
    Public Property gvalidez
        Get
            Return validez
        End Get
        Set(value)
            validez = value
        End Set
    End Property
    Public Property gncuota
        Get
            Return ncuota
        End Get
        Set(value)
            ncuota = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal iddetalle_venta As Integer, ByVal idventa As Integer, ByVal idproducto As Integer, ByVal cantidad As Double, ByVal precio_unitario As Double, ByVal imagen As Byte, ByVal validez As String, ByVal ncuota As String)
        giddedatlle_venta = iddetalle_venta
        gidventa = idventa
        gidproducto = idproducto
        gcantidad = cantidad
        gprecio_unitario = precio_unitario
        gimagen = imagen
        gvalidez = validez
        gncuota = ncuota
    End Sub

    Private Function total()
        Return gcantidad * gprecio_unitario
    End Function
End Class
