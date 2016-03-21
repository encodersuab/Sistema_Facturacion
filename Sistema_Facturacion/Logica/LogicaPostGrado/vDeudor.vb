Public Class vDeudor
    Dim iddeudor, idcliente, idproducto As Integer
    Dim cantidad_deuda As Double
    Dim modulo As String
    Public Property giddeudor

        Get
            Return iddeudor
        End Get
        Set(ByVal value)
            iddeudor = value
        End Set
    End Property
    Public Property gidcliente

        Get
            Return idcliente
        End Get
        Set(ByVal value)
            idcliente = value
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
    Public Property gcantidad_deuda

        Get
            Return cantidad_deuda
        End Get
        Set(ByVal value)
            cantidad_deuda = value
        End Set
    End Property
    Public Property gmodulo
        Get
            Return modulo
        End Get
        Set(value)
            modulo = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal iddeudor As Integer, ByVal idcliente As Integer, ByVal idproducto As Integer, ByVal cantidad_deuda As Double, ByVal modulo As String)
        giddeudor = iddeudor
        gidcliente = idcliente
        gidproducto = idproducto
        gcantidad_deuda = cantidad_deuda
        gmodulo = modulo
    End Sub
End Class
