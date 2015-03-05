Public Class vQr
    Dim IDCodQr, Num_Factura, IdVenta As Integer
    Dim validez, Nit_Emisor, Codigo_Control, Ci_Nit_Comprador, Num_Autorizacion As String
    Dim Total As Double
    Dim fecha_emision As Date
    Dim imagen() As Byte

    Public Property gIDCodQr
        Get
            Return IDCodQr
        End Get
        Set(value)
            IDCodQr = value

        End Set
    End Property
    Public Property gNum_Factura
        Get
            Return Num_Factura
        End Get
        Set(value)
            Num_Factura = value

        End Set
    End Property
    Public Property gNum_Autorizacion
        Get
            Return Num_Autorizacion
        End Get
        Set(value)
            Num_Autorizacion = value

        End Set
    End Property
    Public Property gIdVenta
        Get
            Return IdVenta
        End Get
        Set(value)
            IdVenta = value

        End Set
    End Property
    Public Property gNit_Emisor
        Get
            Return Nit_Emisor
        End Get
        Set(value)
            Nit_Emisor = value

        End Set
    End Property
    Public Property gCodigo_Control
        Get
            Return Codigo_Control
        End Get
        Set(value)
            Codigo_Control = value

        End Set
    End Property
    Public Property gCi_Nit_Comprador
        Get
            Return Ci_Nit_Comprador
        End Get
        Set(value)
            Ci_Nit_Comprador = value

        End Set
    End Property
    Public Property gTotal
        Get
            Return Total
        End Get
        Set(value)
            Total = value

        End Set
    End Property
    Public Property gfecha_emision
        Get
            Return fecha_emision
        End Get
        Set(value)
            fecha_emision = value

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
    Public Sub New()

    End Sub
    Public Sub New(ByVal IDCodQr As Integer, ByVal Num_Factura As Integer, ByVal Num_Autorizacion As String, ByVal IdVenta As Integer, ByVal Nit_emisor As String,
                   ByVal Codigo_Control As String, ByVal Ci_Nit_Comprador As String, ByVal Total As Double, ByVal fecha_emision As Date, ByVal imagen As Byte, ByVal validez As String)


        gIDCodQr = IDCodQr
        gNum_Factura = Num_Factura
        gNum_Autorizacion = Num_Autorizacion
        gIdVenta = IdVenta
        gNit_Emisor = Nit_emisor
        gCodigo_Control = Codigo_Control
        gCi_Nit_Comprador = Ci_Nit_Comprador
        gTotal = Total
        gfecha_emision = fecha_emision
        gimagen = imagen
        gvalidez = validez

    End Sub
End Class
