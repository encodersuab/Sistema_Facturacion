Public Class frmUsuarioRR
    Public Sub limpiar()
        txtLogin.Text = ""
        txtContraceña.Text = ""
    End Sub
    Private Sub frmUsuarioRR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idusuario.Text = frmInicioF.lbidusuario.Text
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("realizar los cambios?", "Modificardo registro", MessageBoxButtons.OKCancel)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtLogin.Text <> "" And txtContraceña.Text <> "" Then
                Try
                    Dim dts As New vUsuario
                    Dim func As New fUsuario

                    dts.glogin = txtLogin.Text
                    dts.gpassword = txtContraceña.Text
                    dts.gidusuario = idusuario.Text

                    If func.editarPassUser(dts) Then

                        MessageBox.Show("cliente modificado correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        limpiar()
                        frmLogin.Show()
                    Else
                        MessageBox.Show("cliente no modificado", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        limpiar()
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("error de datos faltante", "error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtLogin_Validated(sender As Object, e As EventArgs) Handles txtLogin.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtContraceña_Validated(sender As Object, e As EventArgs) Handles txtContraceña.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
        End If
    End Sub
End Class