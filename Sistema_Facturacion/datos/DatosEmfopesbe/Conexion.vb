﻿Imports System.Data.SqlClient


Public Class Conexion
    Protected cnn As New SqlConnection
    Public idusuario As Integer

    Protected Function conectado()
        Try
            cnn = New SqlConnection("Data Source=192.168.1.125;Initial Catalog=BDFactu;User ID=union;Password=123456789")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
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
