Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System
Public Class CC
    ''Private Sub New()
    'End Sub
    ' Verhoeff Digit table variables
    Shared table_d As Integer(,) = New Integer(,) {{0, 1, 2, 3, 4, 5, _
        6, 7, 8, 9}, {1, 2, 3, 4, 0, 6, _
        7, 8, 9, 5}, {2, 3, 4, 0, 1, 7, _
        8, 9, 5, 6}, {3, 4, 0, 1, 2, 8, _
        9, 5, 6, 7}, {4, 0, 1, 2, 3, 9, _
        5, 6, 7, 8}, {5, 9, 8, 7, 6, 0, _
        4, 3, 2, 1}, _
        {6, 5, 9, 8, 7, 1, _
        0, 4, 3, 2}, {7, 6, 5, 9, 8, 2, _
        1, 0, 4, 3}, {8, 7, 6, 5, 9, 3, _
        2, 1, 0, 4}, {9, 8, 7, 6, 5, 4, _
        3, 2, 1, 0}}
    Shared table_p As Integer(,) = New Integer(,) {{0, 1, 2, 3, 4, 5, _
        6, 7, 8, 9}, {1, 5, 7, 6, 2, 8, _
        3, 0, 9, 4}, {5, 8, 0, 3, 7, 9, _
        6, 1, 4, 2}, {8, 9, 1, 6, 0, 4, _
        3, 5, 2, 7}, {9, 4, 5, 3, 1, 2, _
        6, 8, 7, 0}, {4, 2, 8, 6, 5, 7, _
        3, 9, 0, 1}, _
        {2, 7, 9, 3, 8, 0, _
        6, 4, 1, 5}, {7, 0, 4, 6, 9, 1, _
        3, 2, 5, 8}}
    Shared table_inv As Integer() = New Integer() {0, 4, 3, 2, 1, 5, 6, 7, 8, 9}

    Public Shared Function generar(autorizacion As String, numero As String, nitci As String, fecha As String, monto As String, llave As String) As String
        ' paso 1
        numero = verhoeff_add_recursive(numero, 2)
        nitci = verhoeff_add_recursive(nitci, 2)
        fecha = verhoeff_add_recursive(fecha, 2)
        monto = verhoeff_add_recursive(monto, 2)
        Dim suma As String = CLng(Long.Parse(numero) + Long.Parse(nitci) + Long.Parse(fecha) + Long.Parse(monto)).ToString()
        suma = verhoeff_add_recursive(suma, 5)
        '  MessageBox.Show("1 " & suma & "")
        ' paso2
        Dim digitos As String = "" & suma.Substring(suma.Length - 5, 5)
        Dim digitossum As Integer() = New Integer() {0, 0, 0, 0, 0}
        Dim cadenas As String() = New String() {"", "", "", "", ""}
        Dim inicio As Integer = 0
        Dim x As Integer = 0
        For Each d As Char In digitos.ToCharArray()
            digitossum(x) = Integer.Parse(d.ToString()) + 1
            cadenas(x) = llave.Substring(inicio, Integer.Parse(d.ToString()) + 1)
            inicio += Integer.Parse(d.ToString()) + 1
            x += 1
        Next
        autorizacion += cadenas(0)
        numero += cadenas(1)
        nitci += cadenas(2)
        fecha += cadenas(3)
        monto += cadenas(4)
        ' MessageBox.Show("2" & autorizacion & numero & nitci & fecha & monto & "")
        ' paso3
        Dim arc4 As String = allegedrc4(autorizacion & numero & nitci & fecha & monto, llave & digitos)
        ' MessageBox.Show("3" & arc4 & "")
        ' paso4
        Dim suma_total As Long = 0
        Dim sumas As Long() = New Long() {0, 0, 0, 0, 0}
        Dim strlen_arc4 As Integer = arc4.Length
        For i As Integer = 0 To strlen_arc4 - 1
            x = AscW(arc4(i))
            sumas(i Mod 5) += x
            suma_total += x
        Next
        ' MessageBox.Show("4" & suma_total.ToString() & "")
        ' paso5
        Dim total As Long = 0
        For i As Integer = 0 To sumas.Length - 1
            total += suma_total * sumas(i) \ digitossum(i)
        Next
        Dim mensaje As String = big_base_convert(total, 64)
        Dim last As String = allegedrc4(mensaje, llave & digitos).Insert(2, "-").Insert(5, "-").Insert(8, "-")
        If last.Length > 11 Then
            last = last.Insert(11, "-")
        End If
        ' MessageBox.Show("5" & last & "")
        Return last
    End Function

    Private Shared Function big_base_convert(numero As Long, baseconv As Long) As String
        Dim dic As Char() = New Char() {"0"c, "1"c, "2"c, "3"c, "4"c, "5"c, _
            "6"c, "7"c, "8"c, "9"c, "A"c, "B"c, _
            "C"c, "D"c, "E"c, "F"c, "G"c, "H"c, _
            "I"c, "J"c, "K"c, "L"c, "M"c, "N"c, _
            "O"c, "P"c, "Q"c, "R"c, "S"c, "T"c, _
            "U"c, "V"c, "W"c, "X"c, "Y"c, "Z"c, _
            "a"c, "b"c, "c"c, "d"c, "e"c, "f"c, _
            "g"c, "h"c, "i"c, "j"c, "k"c, "l"c, _
            "m"c, "n"c, "o"c, "p"c, "q"c, "r"c, _
            "s"c, "t"c, "u"c, "v"c, "w"c, "x"c, _
            "y"c, "z"c, "+"c, "/"c}
        Dim cociente As Long = 1
        Dim resto As Long = 0
        Dim palabra As String = ""
        While cociente > 0
            cociente = numero \ baseconv
            resto = numero Mod baseconv
            palabra = dic(resto) & palabra
            numero = cociente
        End While
        Return palabra
    End Function
    Private Shared Sub swap(ByRef num1 As Integer, ByRef num2 As Integer)
        Dim temp As Integer = num2
        num2 = num1
        num1 = temp
    End Sub
    Private Shared Function allegedrc4(mensaje As String, llaverc4 As String) As String
        Dim state As Integer() = New Integer(255) {}
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim index1 As Integer = 0
        Dim index2 As Integer = 0
        Dim nmen As Integer = 0
        Dim i As Integer = 0
        Dim cifrado As String = ""

        For i = 0 To 255
            state(i) = i
        Next

        Dim strlen_llave As Integer = llaverc4.Length
        Dim strlen_mensaje As Integer = mensaje.Length
        For i = 0 To 255
            index2 = ((AscW(llaverc4(index1))) + state(i) + index2) Mod 256
            swap(state(index2), state(i))
            index1 = (index1 + 1) Mod strlen_llave
        Next
        Dim cadtemp As String = ""
        For i = 0 To strlen_mensaje - 1
            x = (x + 1) Mod 256
            y = (state(x) + y) Mod 256
            swap(state(y), state(x))
            ' ^ = XOR function
            nmen = AscW(mensaje(i)) Xor state((state(x) + state(y)) Mod 256)
            cadtemp = "0" & big_base_convert(nmen, 16)
            cifrado += cadtemp.Substring(cadtemp.Length - 2, 2)
        Next
        Return cifrado
    End Function
    '*
    '		 * Digito Verhoeff
    '		 

    Private Shared Function calcsum(number As String) As Integer
        Dim c As Integer = 0
        Dim n As String = reverse(number)

        Dim len As Integer = n.Length
        Dim nchar As Char() = n.ToCharArray()
        For i As Integer = 0 To len - 1
            c = table_d(c, table_p((i + 1) Mod 8, Integer.Parse(nchar(i).ToString())))

        Next
        ' MsgBox(table_inv(c))
        Return table_inv(c)
    End Function
    Private Shared Function verhoeff_add_recursive(number As String, digits As Integer) As String
        Dim temp As Long = Long.Parse(number)
        Dim x As Integer
        While digits > 0
            '   MsgBox(temp)
            x = calcsum(temp)
            temp = (temp * 10) + x

            digits = digits - 1
        End While
        Return temp
    End Function
    Private Shared Function reverse(cadena As String) As String
        Dim str As Char() = cadena.ToCharArray()
        Array.Reverse(str)
        Return New String(str)
    End Function
End Class
