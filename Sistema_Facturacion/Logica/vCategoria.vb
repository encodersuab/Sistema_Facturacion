﻿
Imports System.Data.SqlClient
Public Class vCategoria
    Dim idcategoria As Integer
    Dim nombre_categoria As String


    Public Property gidcategoria
        Get
            Return idcategoria
        End Get
        Set(value)
            idcategoria = value
        End Set
    End Property


    Public Property gnombre_categoria
        Get
            Return nombre_categoria
        End Get
        Set(value)
            nombre_categoria = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New()
        gidcategoria = idcategoria
        gnombre_categoria = nombre_categoria
    End Sub


End Class
