Imports System.Data.SqlClient


Public Class fUsuario
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function validar_usuario(ByVal dts As vUsuario)
        Try
            conectado()
            cmd = New SqlCommand("validar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@login", dts.glogin)
            cmd.Parameters.AddWithValue("@password", dts.gpassword)
            Dim dr As SqlDataReader

            dr = cmd.ExecuteReader
            If dr.HasRows = True Then

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
    Public Function mostrar_rol(ByVal dts As vUsuario)
        Try
            conectado()
            cmd = New SqlCommand("validar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@login", dts.glogin)
            cmd.Parameters.AddWithValue("@password", dts.gpassword)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return cmd
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
            cmd = New SqlCommand("mostrar_usuario")
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

    Public Function mostrarROL(ByVal dts As vUsuario)

        Dim cmd = New SqlCommand("validar_usuario", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@login", dts.glogin)
        cmd.Parameters.AddWithValue("@password", dts.gpassword)

        Dim da = New SqlDataAdapter(cmd)
        Dim ds = New DataTable()
        da.Fill(ds)

        If (ds.Rows.Count > 0) Then
            Dim row = ds.Rows(0)
            Dim a As String
            a = Convert.ToString(row("rol"))
            Return a
        Else
            Return False
        End If

    End Function
    Public Function mostrarIDUSUARIO(ByVal dts As vUsuario)

        Dim cmd = New SqlCommand("validar_usuario_idusuario", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@login", dts.glogin)
        cmd.Parameters.AddWithValue("@password", dts.gpassword)

        Dim da = New SqlDataAdapter(cmd)
        Dim ds = New DataTable()
        da.Fill(ds)

        If (ds.Rows.Count > 0) Then
            Dim row = ds.Rows(0)
            Dim a As String
            a = Convert.ToString(row("idusuario"))
            Return a
        Else
            Return False
        End If

    End Function

    Public Function insertar(ByVal dts As vUsuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellidos", dts.gapellidos)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@ci", dts.gci)
            cmd.Parameters.AddWithValue("@login", dts.glogin)
            cmd.Parameters.AddWithValue("@password", dts.gpassword)
            cmd.Parameters.AddWithValue("@acceso", dts.gacceso)
            cmd.Parameters.AddWithValue("@rol", dts.grol)

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
    Public Function editar(ByVal dts As vUsuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idusuario", dts.gidusuario)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellidos", dts.gapellidos)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@ci", dts.gci)
            cmd.Parameters.AddWithValue("@login", dts.glogin)
            cmd.Parameters.AddWithValue("@password", dts.gpassword)
            cmd.Parameters.AddWithValue("@acceso", dts.gacceso)
            cmd.Parameters.AddWithValue("@rol", dts.grol)

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
