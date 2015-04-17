Imports System.Data.SqlClient
Public Class fHistorialProducto
    Inherits Conexion
    Dim cmd As New SqlCommand


    Public Function insertar(ByVal dts As vHistorialProducto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_edicion_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@idproducto", dts.gidproducto)
            cmd.Parameters.AddWithValue("@idusuario", dts.gidusuario)
            cmd.Parameters.AddWithValue("@fechaModificacion", dts.gfechaModificacion)
            cmd.Parameters.AddWithValue("@detalleActual", dts.gdescripcionAct)
            cmd.Parameters.AddWithValue("@detalleEditado", dts.gdescripcionEdit)
            cmd.Parameters.AddWithValue("@detalle", dts.gdetalle)
          
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function


End Class
