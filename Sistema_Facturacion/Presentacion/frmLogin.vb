﻿Public Class frmLogin

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHOra.Text = TimeOfDay
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHOra.Text = TimeOfDay
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
    'Public Sub mostrarRolUsuario()
    '    Dim dt1 As New DataTable
    '    Dim fdato As New fUsuario
    '    dt1 = fdato.mostrarROL
    '    lbROL.Text = dt1.Rows(0)("rol").ToString
    'End Sub

    Public Sub mostrarUsuario()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            Dim dts As New vUsuario
            Dim func As New fUsuario

            dts.glogin = txtLogin.Text
            dts.gpassword = txtPassord.Text

            If func.validar_usuario(dts) = True Then
                frmInicioF.Show()
                Me.Hide()
            Else
                MsgBox("Ingrese nuevamente sus datos correctos", MsgBoxStyle.Information, "accesos denegados al sistema")
                txtPassord.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtPassord_TextChanged(sender As Object, e As EventArgs) Handles txtPassord.TextChanged

    End Sub

    Private Sub lblHOra_Click(sender As Object, e As EventArgs) Handles lblHOra.Click

    End Sub

    Private Sub txtLogin_TextChanged(sender As Object, e As EventArgs) Handles txtLogin.TextChanged

    End Sub

    Private Sub txtLogin_Validated(sender As Object, e As EventArgs) Handles txtLogin.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese login, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtPassord_Validated(sender As Object, e As EventArgs) Handles txtPassord.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese password, ese dato es obligatorio")
        End If
    End Sub
End Class