﻿Imports System.Data.SqlClient
Public Class fDetalleVentaPostGrado
    Inherits Conexion
    Dim cmd As New SqlCommand
    Dim retornarValor As Object

   
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_detalle_venta_PG")
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

    Public Function insertar(ByVal dts As vDetalleVentaPostGrado) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_detalle_venta_PG")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            ' cmd.Parameters.AddWithValue("@iddetalle_venta", dts.giddedatlle_venta)
            cmd.Parameters.AddWithValue("@idventa", dts.gidventa)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@idproducto", dts.gidproducto)
            cmd.Parameters.AddWithValue("@precio_unitario", dts.gprecio_unitario)
            cmd.Parameters.AddWithValue("@validez", dts.gvalidez)
            cmd.Parameters.AddWithValue("@ncuota", dts.gncuota)
            cmd.Parameters.AddWithValue("@detalle", dts.gdetalle)
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
    Public Function editar(ByVal dts As vDetalleVentaPostGrado) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_detalle_venta_PG")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@iddetalle_venta", dts.giddedatlle_venta)
            cmd.Parameters.AddWithValue("@idventa", dts.gidventa)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@idproducto", dts.gidproducto)
            cmd.Parameters.AddWithValue("@precio_unitario", dts.gprecio_unitario)
            cmd.Parameters.AddWithValue("@validez", dts.gvalidez)
            cmd.Parameters.AddWithValue("@ncuota", dts.gncuota)
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

    Public Function editarValidez(ByVal dts As vDetalleVentaPostGrado) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_detalle_venta_validez")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@iddetalle_venta", dts.giddedatlle_venta)
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
    Public Function mostraridprodXidventa(ByVal dts As vDetalleVentaPostGrado) As Integer
        Try
            conectado()
            cmd = New SqlCommand("mostrar_idproductoXidventa")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idventa", dts.gidventa)

            retornarValor = cmd.ExecuteScalar()

            Return retornarValor
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function mostrariddetalleventaXidventa(ByVal dts As vDetalleVentaPostGrado) As Integer
        Try
            conectado()
            cmd = New SqlCommand("mostrar_iddetalleventaXidventa")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idventa", dts.gidventa)
            retornarValor = cmd.ExecuteScalar()

            Return retornarValor
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function mostrarCantidadXidventa(ByVal dts As vDetalleVentaPostGrado) As Double
        Try
            conectado()
            cmd = New SqlCommand("mostrar_idproductoCAntidad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idventa", dts.gidventa)

            retornarValor = cmd.ExecuteScalar()

            Return retornarValor
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function eliminar(ByVal dts As vDetalleVentaPostGrado) As Boolean
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

    Public Function validezDetallaVenta(ByVal dts As vDetalleVentaPostGrado) As Boolean
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

    Public Function eliminarproductoVenta(ByVal dts As vDetalleVentaPostGrado) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_dventa_x_idventa")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idventa", SqlDbType.NVarChar, 50).Value = dts.gidventa
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
    Public Function aumentar_stock(ByVal dts As vDetalleVentaPostGrado) As Boolean
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
    Public Function disminuir_stock(ByVal dts As vDetalleVentaPostGrado) As Boolean
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
