Public Class vVenta
    Dim idventa, idcliente As Integer
    Dim fecha_venta As Date
    Dim tipo_documento, num_documento, nombre_fac As String

    Public Property Gidventa
        Get
            Return idventa
        End Get
        Set(ByVal value)
            idventa = value
        End Set
    End Property
    Public Property Gidcliente
        Get
            Return idcliente
        End Get
        Set(ByVal value)
            idcliente = value
        End Set
    End Property
    Public Property Gfecha_venta
        Get
            Return fecha_venta
        End Get
        Set(ByVal value)
            fecha_venta = value
        End Set
    End Property
    Public Property Gtipo_documento
        Get
            Return tipo_documento
        End Get
        Set(ByVal value)
            tipo_documento = value
        End Set
    End Property
    Public Property Gnum_documento
        Get
            Return num_documento
        End Get
        Set(ByVal value)
            num_documento = value
        End Set
    End Property
    Public Property Gnombre_fac
        Get
            Return nombre_fac
        End Get
        Set(ByVal value)
            nombre_fac = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idventa As Integer, ByVal idcliente As Integer, ByVal fecha_venta As Date, ByVal tipo_documento As String, ByVal num_documento As String, ByVal nombre_fac As String)
        Gidventa = idventa
        Gidcliente = idventa
        Gfecha_venta = fecha_venta
        Gtipo_documento = tipo_documento
        Gnum_documento = num_documento
        Gnombre_fac = nombre_fac
    End Sub


End Class
