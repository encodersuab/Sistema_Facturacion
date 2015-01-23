Public Class frmCliente

    Private dt As New DataTable
    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()

    End Sub
    Private Sub mostrar()
        Try
            Dim func As New fCliente
        Catch ex As Exception

        End Try
    End Sub



    'Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged

    'End Sub

    'Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    'End Sub
End Class