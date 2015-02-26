Imports System.Data.SqlClient
Public Class fDatosImpuestos
    Inherits Conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("Mostrar_datos_impuestos")
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

    Public Function insertar(ByVal dts As vDatosImpuestos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_datos_impuestos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nitEmisor", dts.gnitEmisor)
            cmd.Parameters.AddWithValue("@numAutorizacion", dts.gnumAutorizacion)
            cmd.Parameters.AddWithValue("@llave", dts.gllave)

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
    Public Function editar(ByVal dts As vDatosImpuestos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_datos_impuestos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_datosImp", dts.gidDatosImp)
            cmd.Parameters.AddWithValue("@nitEmisor", dts.gnitEmisor)
            cmd.Parameters.AddWithValue("@numAutorizacion", dts.gnumAutorizacion)
            cmd.Parameters.AddWithValue("@llave", dts.gllave)

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
