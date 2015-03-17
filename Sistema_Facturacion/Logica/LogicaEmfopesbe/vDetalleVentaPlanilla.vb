Public Class vDetalleVentaPlanilla
    Dim iddetalle_venta, idventa, idventaplanilla, idproducto As Integer
    Dim cantidad, precio_unitario As Double
    Dim imagen() As Byte
    Dim validez As String
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
    Public Property gidventaplanilla

        Get
            Return idventaplanilla
        End Get
        Set(ByVal value)
            idventaplanilla = value
        End Set
    End Property
    Public Property gvalidez

        Get
            Return validez
        End Get
        Set(ByVal value)
            validez = value
        End Set
    End Property
    Public Sub New()

    End Sub


    Public Sub New(ByVal iddetalle_venta As Integer, ByVal idventa As Integer, ByVal idproducto As Integer, ByVal cantidad As Double, ByVal precio_unitario As Double, ByVal iddetalleventa As Integer, ByVal validez As String)
        giddedatlle_venta = iddetalle_venta
        gidventaplanilla = idventaplanilla
        gidproducto = idproducto
        gcantidad = cantidad
        gprecio_unitario = precio_unitario
        gidventa = idventa
        gvalidez = validez
    End Sub

End Class
