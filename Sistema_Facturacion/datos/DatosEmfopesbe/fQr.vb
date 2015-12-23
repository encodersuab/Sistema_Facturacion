Imports System.Data.SqlClient
Public Class fQr
    Inherits Conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_datos_QR")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()

        End Try
    End Function
    Public Function mostrar1() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_datos_QR1")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()

        End Try
    End Function
    Public Function mostrar2() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_datos_QR2")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()

        End Try
    End Function
    Public Function mostrar3() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_datos_QR3")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()

        End Try
    End Function
    Public Function mostrarUltimoQR() As Integer
        Try
            conectado()
            cmd = New SqlCommand("mostrar_ultimo_qr0")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cnn
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataTable

            da.Fill(ds)

            If (ds.Rows.Count > 0) Then
                Dim row = ds.Rows(0)
                Dim a As Integer
                a = row("IDCodQr")
                Return a

            End If
            Return False

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
    Public Function mostrarUltimoQR1() As Integer
        Try
            conectado()
            cmd = New SqlCommand("mostrar_ultimo_qr1")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cnn
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataTable

            da.Fill(ds)

            If (ds.Rows.Count > 0) Then
                Dim row = ds.Rows(0)
                Dim a As Integer
                a = row("IDCodQr")
                Return a

            End If
            Return False

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function mostrarUltimoQR2() As Integer
        Try
            conectado()
            cmd = New SqlCommand("mostrar_ultimo_qr2")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cnn
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataTable

            da.Fill(ds)

            If (ds.Rows.Count > 0) Then
                Dim row = ds.Rows(0)
                Dim a As Integer
                a = row("IDCodQr")
                Return a

            End If
            Return False

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
    Public Function mostrarUltimoQR3() As Integer
        Try
            conectado()
            cmd = New SqlCommand("mostrar_ultimo_qr3")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cnn
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataTable

            da.Fill(ds)

            If (ds.Rows.Count > 0) Then
                Dim row = ds.Rows(0)
                Dim a As Integer
                a = row("IDCodQr")
                Return a

            End If
            Return False

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
    Public Function insertar0(ByVal dts As vQr) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_DatosQr0")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Nit_Emisor", dts.gNit_Emisor)
            cmd.Parameters.AddWithValue("@Num_Factura", dts.gNum_Factura)
            cmd.Parameters.AddWithValue("@Num_Autorizacion", dts.gNum_Autorizacion)
            cmd.Parameters.AddWithValue("@Fecha_emision", dts.gfecha_emision)
            cmd.Parameters.AddWithValue("@Total", dts.gTotal)
            cmd.Parameters.AddWithValue("@Codigo_Control", dts.gCodigo_Control)
            cmd.Parameters.AddWithValue("@Ci_Nit_Comprador", dts.gCi_Nit_Comprador)
            cmd.Parameters.AddWithValue("@imagen", dts.gimagen)
            cmd.Parameters.AddWithValue("@IdVenta", dts.gIdVenta)
            cmd.Parameters.AddWithValue("@validez", dts.gvalidez)
            cmd.Parameters.AddWithValue("@literal", dts.gliteral)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function insertar1(ByVal dts As vQr) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_DatosQr1")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Nit_Emisor", dts.gNit_Emisor)
            cmd.Parameters.AddWithValue("@Num_Factura", dts.gNum_Factura)
            cmd.Parameters.AddWithValue("@Num_Autorizacion", dts.gNum_Autorizacion)
            cmd.Parameters.AddWithValue("@Fecha_emision", dts.gfecha_emision)
            cmd.Parameters.AddWithValue("@Total", dts.gTotal)
            cmd.Parameters.AddWithValue("@Codigo_Control", dts.gCodigo_Control)
            cmd.Parameters.AddWithValue("@Ci_Nit_Comprador", dts.gCi_Nit_Comprador)
            cmd.Parameters.AddWithValue("@imagen", dts.gimagen)
            cmd.Parameters.AddWithValue("@IdVenta", dts.gIdVenta)
            cmd.Parameters.AddWithValue("@validez", dts.gvalidez)
            cmd.Parameters.AddWithValue("@literal", dts.gliteral)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function insertar2(ByVal dts As vQr) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_DatosQr2")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Nit_Emisor", dts.gNit_Emisor)
            cmd.Parameters.AddWithValue("@Num_Factura", dts.gNum_Factura)
            cmd.Parameters.AddWithValue("@Num_Autorizacion", dts.gNum_Autorizacion)
            cmd.Parameters.AddWithValue("@Fecha_emision", dts.gfecha_emision)
            cmd.Parameters.AddWithValue("@Total", dts.gTotal)
            cmd.Parameters.AddWithValue("@Codigo_Control", dts.gCodigo_Control)
            cmd.Parameters.AddWithValue("@Ci_Nit_Comprador", dts.gCi_Nit_Comprador)
            cmd.Parameters.AddWithValue("@imagen", dts.gimagen)
            cmd.Parameters.AddWithValue("@IdVenta", dts.gIdVenta)
            cmd.Parameters.AddWithValue("@validez", dts.gvalidez)
            cmd.Parameters.AddWithValue("@literal", dts.gliteral)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function insertar3(ByVal dts As vQr) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_DatosQr3")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Nit_Emisor", dts.gNit_Emisor)
            cmd.Parameters.AddWithValue("@Num_Factura", dts.gNum_Factura)
            cmd.Parameters.AddWithValue("@Num_Autorizacion", dts.gNum_Autorizacion)
            cmd.Parameters.AddWithValue("@Fecha_emision", dts.gfecha_emision)
            cmd.Parameters.AddWithValue("@Total", dts.gTotal)
            cmd.Parameters.AddWithValue("@Codigo_Control", dts.gCodigo_Control)
            cmd.Parameters.AddWithValue("@Ci_Nit_Comprador", dts.gCi_Nit_Comprador)
            cmd.Parameters.AddWithValue("@imagen", dts.gimagen)
            cmd.Parameters.AddWithValue("@IdVenta", dts.gIdVenta)
            cmd.Parameters.AddWithValue("@validez", dts.gvalidez)
            cmd.Parameters.AddWithValue("@literal", dts.gliteral)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function editar(ByVal dts As vQr) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Editar_DatosQr")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IDCodQr", dts.gIDCodQr)
            cmd.Parameters.AddWithValue("@Nit_Emisor", dts.gNit_Emisor)
            cmd.Parameters.AddWithValue("@Num_Factura", dts.gNum_Factura)
            cmd.Parameters.AddWithValue("@Num_Autorizacion", dts.gNum_Autorizacion)
            cmd.Parameters.AddWithValue("@Fecha_emision", dts.gfecha_emision)
            cmd.Parameters.AddWithValue("@Total", dts.gTotal)
            cmd.Parameters.AddWithValue("@Codigo_Control", dts.gCodigo_Control)
            cmd.Parameters.AddWithValue("@Ci_Nit_Comprador", dts.gCi_Nit_Comprador)
            'cmd.Parameters.AddWithValue("@imagen", dts.gimagen)
            cmd.Parameters.AddWithValue("@IdVenta", dts.gIdVenta)
            cmd.Parameters.AddWithValue("@validez", dts.gvalidez)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function editar1(ByVal dts As vQr) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Editar_DatosQr1")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IDCodQr", dts.gIDCodQr)
            cmd.Parameters.AddWithValue("@Nit_Emisor", dts.gNit_Emisor)
            cmd.Parameters.AddWithValue("@Num_Factura", dts.gNum_Factura)
            cmd.Parameters.AddWithValue("@Num_Autorizacion", dts.gNum_Autorizacion)
            cmd.Parameters.AddWithValue("@Fecha_emision", dts.gfecha_emision)
            cmd.Parameters.AddWithValue("@Total", dts.gTotal)
            cmd.Parameters.AddWithValue("@Codigo_Control", dts.gCodigo_Control)
            cmd.Parameters.AddWithValue("@Ci_Nit_Comprador", dts.gCi_Nit_Comprador)
            'cmd.Parameters.AddWithValue("@imagen", dts.gimagen)
            cmd.Parameters.AddWithValue("@IdVenta", dts.gIdVenta)
            cmd.Parameters.AddWithValue("@validez", dts.gvalidez)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function editar2(ByVal dts As vQr) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Editar_DatosQr2")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IDCodQr", dts.gIDCodQr)
            cmd.Parameters.AddWithValue("@Nit_Emisor", dts.gNit_Emisor)
            cmd.Parameters.AddWithValue("@Num_Factura", dts.gNum_Factura)
            cmd.Parameters.AddWithValue("@Num_Autorizacion", dts.gNum_Autorizacion)
            cmd.Parameters.AddWithValue("@Fecha_emision", dts.gfecha_emision)
            cmd.Parameters.AddWithValue("@Total", dts.gTotal)
            cmd.Parameters.AddWithValue("@Codigo_Control", dts.gCodigo_Control)
            cmd.Parameters.AddWithValue("@Ci_Nit_Comprador", dts.gCi_Nit_Comprador)
            'cmd.Parameters.AddWithValue("@imagen", dts.gimagen)
            cmd.Parameters.AddWithValue("@IdVenta", dts.gIdVenta)
            cmd.Parameters.AddWithValue("@validez", dts.gvalidez)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function editar3(ByVal dts As vQr) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Editar_DatosQr3")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IDCodQr", dts.gIDCodQr)
            cmd.Parameters.AddWithValue("@Nit_Emisor", dts.gNit_Emisor)
            cmd.Parameters.AddWithValue("@Num_Factura", dts.gNum_Factura)
            cmd.Parameters.AddWithValue("@Num_Autorizacion", dts.gNum_Autorizacion)
            cmd.Parameters.AddWithValue("@Fecha_emision", dts.gfecha_emision)
            cmd.Parameters.AddWithValue("@Total", dts.gTotal)
            cmd.Parameters.AddWithValue("@Codigo_Control", dts.gCodigo_Control)
            cmd.Parameters.AddWithValue("@Ci_Nit_Comprador", dts.gCi_Nit_Comprador)
            'cmd.Parameters.AddWithValue("@imagen", dts.gimagen)
            cmd.Parameters.AddWithValue("@IdVenta", dts.gIdVenta)
            cmd.Parameters.AddWithValue("@validez", dts.gvalidez)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
End Class
