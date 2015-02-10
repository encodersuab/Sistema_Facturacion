Public Class vDatosImpuestos

    Dim idDatosImp As Integer
    Dim nitEmisor, numAutorizacion, llave As String

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

    Public Sub New()

    End Sub

    Public Sub New(ByVal idDatosImp As Integer, ByVal nitEmisor As String, ByVal numAutorizacion As String, ByVal llave As String)
        gidDatosImp = idDatosImp
        gnitEmisor = nitEmisor
        gnumAutorizacion = numAutorizacion
        gllave = llave
    End Sub

End Class
