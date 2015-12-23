Public Class vDatosImpuestos

    Dim idDatosImp, sucursal As Integer
    Dim nitEmisor, numAutorizacion, llave, detalle As String
    Dim fechalimite As Date
    Public Property gidDatosImp
        Get
            Return idDatosImp
        End Get
        Set(ByVal value)
            idDatosImp = value
        End Set
    End Property

    Public Property gnitEmisor
        Get
            Return nitEmisor
        End Get
        Set(ByVal value)
            nitEmisor = value
        End Set
    End Property

    Public Property gnumAutorizacion
        Get
            Return numAutorizacion
        End Get
        Set(ByVal value)
            numAutorizacion = value
        End Set
    End Property

    Public Property gllave
        Get
            Return llave
        End Get
        Set(ByVal value)
            llave = value
        End Set
    End Property
    Public Property gfechalimite
        Get
            Return fechalimite
        End Get
        Set(ByVal value)
            fechalimite = value
        End Set
    End Property
    Public Property gsucursal
        Get
            Return sucursal
        End Get
        Set(ByVal value)
            sucursal = value
        End Set
    End Property
    Public Property gdetalle
        Get
            Return detalle
        End Get
        Set(ByVal value)
            detalle = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal idDatosImp As Integer, ByVal nitEmisor As String, ByVal numAutorizacion As String, ByVal llave As String, ByVal fechalimite As Date, ByVal sucursal As Integer, ByVal detalle As String)
        gidDatosImp = idDatosImp
        gnitEmisor = nitEmisor
        gnumAutorizacion = numAutorizacion
        gllave = llave
        gfechalimite = fechalimite
        gsucursal = sucursal
        gdetalle = detalle
    End Sub

End Class
