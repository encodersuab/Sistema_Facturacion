Public Class vHistorialProducto

    Dim idHistorialProducto, idproducto As Integer
    Dim descripcionAct, descripcionEdit, detalle, idusuario As String
    Dim fechaModificacion As Date
    Public Property gidHistorialProducto
        Get
            Return idHistorialProducto
        End Get
        Set(ByVal value)
            idHistorialProducto = value

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
    Public Property gidusuario
        Get
            Return idusuario
        End Get
        Set(ByVal value)
            idusuario = value

        End Set
    End Property
    Public Property gfechaModificacion
        Get
            Return fechaModificacion
        End Get
        Set(ByVal value)
            fechaModificacion = value
        End Set
    End Property
    Public Property gdescripcionAct
        Get
            Return descripcionAct
        End Get
        Set(ByVal value)
            descripcionAct = value
        End Set
    End Property
    Public Property gdescripcionEdit
        Get
            Return descripcionEdit
        End Get
        Set(ByVal value)
            descripcionEdit = value
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
  

 
End Class
