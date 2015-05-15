Imports System.Data.SqlClient
Public Class fClientePostGrado
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function mostrarUAB() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("Mostrar_ClienteUAB")
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
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("Mostrar_Cliente")
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

    Public Function insertar(ByVal dts As vClientePostGrado) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellidos", dts.gapellidos)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@ci", dts.gci)

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
    Public Function editar(ByVal dts As vClientePostGrado) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idcliente", dts.gicliente)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellidos", dts.gapellidos)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@ci", dts.gci)

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
    Public Function eliminar(ByVal dts As vClientePostGrado) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idcliente", SqlDbType.NVarChar, 50).Value = dts.gicliente
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class
