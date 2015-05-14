Public Class vClienteREDRUBI

    Dim idcliente As Integer
    Dim nombre, apellidos, direccion, telefono, ci, funcionario As String

    Public Property gicliente
        Get
            Return idcliente
        End Get
        Set(ByVal value)
            idcliente = value
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

    Public Property gapellidos
        Get
            Return apellidos
        End Get
        Set(ByVal value)
            apellidos = value
        End Set
    End Property

    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(ByVal value)
            direccion = value
        End Set
    End Property

    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(ByVal value)
            telefono = value
        End Set
    End Property

    Public Property gci
        Get
            Return ci
        End Get
        Set(ByVal value)
            ci = value
        End Set
    End Property
    Public Property gfuncionario
        Get
            Return funcionario
        End Get
        Set(ByVal value)
            funcionario = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal idcliente As Integer, ByVal nombre As String, ByVal apellidos As String, ByVal direccion As String, ByVal telefono As String, ByVal ci As String, ByVal funcionario As String)
        gicliente = idcliente
        gnombre = nombre
        gapellidos = apellidos
        gdireccion = direccion
        gtelefono = telefono
        gci = ci
        gfuncionario = funcionario
    End Sub

End Class
