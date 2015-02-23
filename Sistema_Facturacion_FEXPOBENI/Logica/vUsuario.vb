Public Class vUsuario
    Dim idusuario As Integer
    Dim nombre, apellidos, ci, direccion, telefono, login, password, acceso, rol As String

    Public Property gidusuario
        Get
            Return idusuario
        End Get
        Set(ByVal value)
            idusuario = value
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
    Public Property gci
        Get
            Return ci
        End Get
        Set(ByVal value)
            ci = value
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
    Public Property glogin
        Get
            Return login
        End Get
        Set(ByVal value)
            login = value
        End Set
    End Property
    Public Property gpassword
        Get
            Return password
        End Get
        Set(ByVal value)
            password = value
        End Set
    End Property
    Public Property gacceso
        Get
            Return acceso
        End Get
        Set(ByVal value)
            acceso = value
        End Set
    End Property

    Public Property grol
        Get
            Return rol
        End Get
        Set(ByVal value)
            rol = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal idusuario As Integer, ByVal nombre As String, ByVal apellidos As String, ByVal ci As String, ByVal direccion As String, ByVal telefono As String, ByVal login As String, ByVal password As String, ByVal acceso As String, ByVal rol As String)
        gidusuario = idusuario
        gnombre = nombre
        gapellidos = apellidos
        gci = ci
        gdireccion = direccion
        gtelefono = telefono
        glogin = login
        gpassword = password
        gacceso = acceso
        grol = rol

    End Sub

End Class
