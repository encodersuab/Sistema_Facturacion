Imports System.Data.SqlClient
Public Class fDeudor
    Inherits Conexion
    Dim cmd As New SqlCommand
    Dim retornarValor As Object
    Public Function disminuir_monto_adeudado(ByVal dts As vDeudor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("disminuir_monto_adeudado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad_deuda)
            cmd.Parameters.AddWithValue("@iddeudor", dts.giddeudor)

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
    Public Function insertar(ByVal dts As vDeudor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_deudor_postgrado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            ' cmd.Parameters.AddWithValue("@iddetalle_venta", dts.giddedatlle_venta)
            cmd.Parameters.AddWithValue("@iddeudor", dts.giddeudor)
            cmd.Parameters.AddWithValue("@idcliente", dts.gidcliente)
            cmd.Parameters.AddWithValue("@idproducto", dts.gidproducto)
            cmd.Parameters.AddWithValue("@cantidad_deuda", dts.gcantidad_deuda)
            cmd.Parameters.AddWithValue("@modulo", dts.gmodulo)
            'cmd.Parameters.AddWithValue("@imagen", dts.gimagen)
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
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_deudores")
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
    Public Function mostrar_ultimo_ncuota(ByVal dts As vDeudor) As Integer
        Try
            conectado()
            cmd = New SqlCommand("mostrar_ultimo_ncuota")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idcliente", dts.gidcliente)
            cmd.Parameters.AddWithValue("@idproducto", dts.gidproducto)
            retornarValor = cmd.ExecuteScalar()

            Return retornarValor
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
End Class
