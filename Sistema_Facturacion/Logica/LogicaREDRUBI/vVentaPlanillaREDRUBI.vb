﻿Public Class vVentaPlanillaREDRUBI
    Dim idventaplanilla, idcliente, idusuario As Integer
    Dim fecha_venta As Date
    Dim tipo_documento, num_documento, nombre_fac, estado, pago, modulo As String

    Public Property Gidventaplanilla
        Get
            Return idventaplanilla
        End Get
        Set(ByVal value)
            idventaplanilla = value
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
    Public Property Gestado
        Get
            Return estado
        End Get
        Set(ByVal value)
            estado = value
        End Set
    End Property
    Public Property Gpago
        Get
            Return pago
        End Get
        Set(ByVal value)
            pago = value
        End Set
    End Property
    Public Property Gidusuario
        Get
            Return idusuario
        End Get
        Set(ByVal value)
            idusuario = value
        End Set
    End Property
    Public Property Gmodulo
        Get
            Return modulo
        End Get
        Set(ByVal value)
            modulo = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal idventaplanilla As Integer, ByVal idcliente As Integer, ByVal fecha_venta As Date, ByVal tipo_documento As String, ByVal num_documento As String, ByVal nombre_fac As String, ByVal estado As String, ByVal pago As String, ByVal idusuario As Integer, ByVal modulo As String)
        Gidventaplanilla = idventaplanilla
        Gidcliente = idcliente
        Gfecha_venta = fecha_venta
        Gtipo_documento = tipo_documento
        Gnum_documento = num_documento
        Gnombre_fac = nombre_fac
        Gestado = estado
        Gpago = pago
        Gidusuario = idusuario
        Gmodulo = modulo
    End Sub
End Class
