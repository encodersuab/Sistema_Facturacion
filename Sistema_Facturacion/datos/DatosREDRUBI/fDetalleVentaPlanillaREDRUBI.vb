Imports System.Data.SqlClient
Public Class fDetalleVentaPlanillaREDRUBI
    Inherits Conexion
    Dim cmd As New SqlCommand


    Public Function mostrarDVPlanilla() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_detalle_ventaXidplanilla")
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
    Public Function insertarDVPlanilla(ByVal dts As vDetalleVentaPlanillaREDRUBI) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_detalle_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idventa", dts.gidventaplanilla)
            cmd.Parameters.AddWithValue("@idproducto", dts.gidproducto)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@precio_unitario", dts.gprecio_unitario)
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
    Public Function editar(ByVal dts As vDetalleVentaPlanillaREDRUBI) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_detalle_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@iddetalle_venta", dts.giddedatlle_venta)
            cmd.Parameters.AddWithValue("@idventaplanilla", dts.gidventaplanilla)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@idproducto", dts.gidproducto)
            cmd.Parameters.AddWithValue("@precio_unitario", dts.gprecio_unitario)
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

    Public Function eliminar(ByVal dts As vDetalleVentaPlanillaREDRUBI) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_detalle_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@iddetalleventa", SqlDbType.NVarChar, 50).Value = dts.giddedatlle_venta
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


    Public Function eliminarproductoVenta(ByVal dts As vDetalleVentaPlanillaREDRUBI) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_dventa_x_idventaplanilla")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idventaplanilla", SqlDbType.NVarChar, 50).Value = dts.gidventaplanilla
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
    Public Function aumentar_stock(ByVal dts As vDetalleVentaPlanillaREDRUBI) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("aumentar_stock")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@idproducto", dts.gidproducto)



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
    Public Function disminuir_stock(ByVal dts As vDetalleVentaPlanillaREDRUBI) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("disminuir_stock")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@idproducto", dts.gidproducto)

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
