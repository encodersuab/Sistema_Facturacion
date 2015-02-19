Imports System.Data.SqlClient
Public Class frmDatosImpuestos
    Private dt As New DataTable
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmDatosImpuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Public Sub limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtidDATosIMp.Text = ""
        txtNitEmisor.Text = ""
        txtNumAutorizacion.Text = ""
        txtLLAVE.Text = ""
    End Sub
    Private Sub mostrar()
        Try
            Dim func As New fDatosImpuestos
            dt = func.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                ' txtBuscar.Enabled = True
                datalistado.ColumnHeadersVisible = False
                Inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                '   txtBuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                Inexistente.Visible = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnNuevo.Visible = True
        btnEditar.Visible = False

        Buscar()

    End Sub

    Private Sub Buscar()

        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            '     dv.RowFilter = cbxListadoClientes.Text & " Like '" & txtBuscar.Text & "%'"

            If dv.Count <> 0 Then
                Inexistente.Visible = False
                datalistado.DataSource = dv
                '       ocultar_columnas()
            Else
                Inexistente.Visible = True
                datalistado.DataSource = Nothing
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtidDATosIMp.Text = datalistado.SelectedCells.Item(1).Value
        txtNitEmisor.Text = datalistado.SelectedCells.Item(2).Value
        txtNumAutorizacion.Text = datalistado.SelectedCells.Item(3).Value
        txtLLAVE.Text = datalistado.SelectedCells.Item(4).Value
        'txtDireccion.Text = datalistado.SelectedCells.Item(4).Value
        'txtTelefono.Text = datalistado.SelectedCells.Item(5).Value
        'txtCi.Text = datalistado.SelectedCells.Item(6).Value

        btnEditar.Visible = True
        btnGuardar.Visible = False

    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("realizar los cambios?", "Modificardo registro", MessageBoxButtons.OKCancel)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtNumAutorizacion.Text <> "" And txtidDATosIMp.Text <> "" And txtNitEmisor.Text <> "" And txtLLAVE.Text <> "" Then
                Try
                    Dim dts As New vDatosImpuestos
                    Dim func As New fDatosImpuestos

                    dts.gidDatosImp = txtidDATosIMp.Text
                    dts.gnitEmisor = txtNitEmisor.Text
                    dts.gnumAutorizacion = txtNumAutorizacion.Text
                    dts.gllave = txtLLAVE.Text

              
                    If func.editar(dts) Then
                        MessageBox.Show("cliente modificado correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("cliente no modificado", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
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

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()

        mostrar()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtNumAutorizacion.Text <> "" And txtNitEmisor.Text <> "" And txtLLAVE.Text <> "" Then
            Try
                Dim dts As New vDatosImpuestos
                Dim func As New fDatosImpuestos

                '   dts.gidDatosImp = txtidDATosIMp.Text
                dts.gnitEmisor = txtNitEmisor.Text
                dts.gnumAutorizacion = txtNumAutorizacion.Text
                dts.gllave = txtLLAVE.Text

                If func.insertar(dts) Then
                    MessageBox.Show("cliente registrado correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("cliente no registrado", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("error de datos faltante", "error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub txtidDATosIMp_TextChanged(sender As Object, e As EventArgs) Handles txtidDATosIMp.TextChanged

    End Sub

    Private Sub txtidDATosIMp_Validated(sender As Object, e As EventArgs) Handles txtidDATosIMp.Validated
        
    End Sub

    Private Sub txtNitEmisor_TextChanged(sender As Object, e As EventArgs) Handles txtNitEmisor.TextChanged

    End Sub

    Private Sub txtNitEmisor_Validated(sender As Object, e As EventArgs) Handles txtNitEmisor.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese nit emisor, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtNumAutorizacion_TextChanged(sender As Object, e As EventArgs) Handles txtNumAutorizacion.TextChanged

    End Sub

    Private Sub txtNumAutorizacion_Validated(sender As Object, e As EventArgs) Handles txtNumAutorizacion.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese numero de autorizacion, ese dato es obligatorio")
        End If
    End Sub

    Private Sub txtLLAVE_TextChanged(sender As Object, e As EventArgs) Handles txtLLAVE.TextChanged

    End Sub

    Private Sub txtLLAVE_Validated(sender As Object, e As EventArgs) Handles txtLLAVE.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese apellidos del cliente, ese dato es obligatorio")
        End If
    End Sub
End Class