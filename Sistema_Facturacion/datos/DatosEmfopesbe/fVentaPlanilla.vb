Imports System.Data.SqlClient
Public Class fVentaPlanilla
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function mostrarVentaPlanilla() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_venta_planilla")
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

    Public Function insertarventaPlanilla(ByVal dts As vVentaPlanillaCAMPOFERIAL) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            '  cmd.Parameters.AddWithValue("@idventa", dts.Gidventa)
            cmd.Parameters.AddWithValue("@idcliente", dts.Gidcliente)
            cmd.Parameters.AddWithValue("@fecha_venta", dts.Gfecha_venta)
            cmd.Parameters.AddWithValue("@tipo_documento", dts.Gtipo_documento)
            cmd.Parameters.AddWithValue("@num_documento", dts.Gnum_documento)
            cmd.Parameters.AddWithValue("@nombre_fac", dts.Gnombre_fac)
            cmd.Parameters.AddWithValue("@estado", dts.Gestado)
            cmd.Parameters.AddWithValue("@pago", dts.Gpago)
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

    Public Function editarVentaPlanilla(ByVal dts As vVentaPlanillaCAMPOFERIAL) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idventa", dts.Gidventaplanilla)
            cmd.Parameters.AddWithValue("@idcliente", dts.Gidcliente)
            cmd.Parameters.AddWithValue("@fecha_venta", dts.Gfecha_venta)
            cmd.Parameters.AddWithValue("@tipo_documento", dts.Gtipo_documento)
            cmd.Parameters.AddWithValue("@num_documento", dts.Gnum_documento)
            cmd.Parameters.AddWithValue("@nombre_fac", dts.Gnombre_fac)
            cmd.Parameters.AddWithValue("@estado", dts.Gestado)
            cmd.Parameters.AddWithValue("@pago", dts.Gpago)
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


    Public Function eliminarventaPlanilla(ByVal dts As vVentaPlanillaCAMPOFERIAL) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idventa", SqlDbType.NVarChar, 50).Value = dts.Gidventaplanilla
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
