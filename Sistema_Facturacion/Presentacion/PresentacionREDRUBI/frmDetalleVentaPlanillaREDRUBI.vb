﻿Imports System.Collections.Generic
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
Public Class frmDetalleVentaPlanillaREDRUBI
    Private dt As New DataTable
    Private Sub frmDetalleVentaPlanillaREDRUBI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarDVPlanilla()
        limpiar()
        mostrardatosimpuestos()

    End Sub

    Public Sub mostrarDatosImpuestos()
        Dim dt1 As New DataTable
        Dim fdatosImp As New fDatosImpuestos
        dt1 = fdatosImp.mostrar

        txtnituab.Text = dt1.Rows(0)("nitEmisor").ToString
        lbllave.Text = dt1.Rows(0)("llave").ToString
        lbnumAutor.Text = dt1.Rows(0)("numAutorizacion").ToString
    End Sub



    Public Sub limpiar()
        btnGuardar.Visible = True
        txtIdProducto.Text = ""
        txtNombreProducto.Text = ""
        txtPrecioUnitario.Text = ""
        txtCantidad.Text = 0
        txtStock.Text = 0



    End Sub

    Private Sub mostrarDVPlanilla()
        txttotal.Text = 0

        Try
            Dim func As New fDetalleVentaPlanillaREDRUBI
            dt = func.mostrarDVPlanilla
            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                datalistado.ColumnHeadersVisible = True
                Inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                datalistado.ColumnHeadersVisible = True
                Inexistente.Visible = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnNuevo.Visible = True

        Buscar()

    End Sub

    Private Sub Buscar()

        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = " IDVenta='" & txtIdVenta.Text & "'"

            If dv.Count <> 0 Then
                Inexistente.Visible = False
                datalistado.DataSource = dv
                'ocultar_columnas()
            Else
                Inexistente.Visible = True
                datalistado.DataSource = Nothing
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ocultar_columnas()
        'datalistado.Columns(1).Visible = False
        'datalistado.Columns(2).Visible = False
        'datalistado.Columns(3).Visible = False
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtCantidad.Text = 0 Then
            MessageBox.Show("CANTIDAD INCORRECTA")
        Else
            If Me.ValidateChildren = True And txtIdProducto.Text <> "" And txtCantidad.Text <> "" And txtPrecioUnitario.Text <> "" Then
                'System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
                Try

                    Dim dtsp As New vDetalleVentaPlanillaREDRUBI
                    Dim funcp As New fDetalleVentaPlanillaREDRUBI

                    dtsp.gidproducto = txtIdProducto.Text
                    dtsp.gcantidad = txtCantidad.Text
                    dtsp.gprecio_unitario = txtPrecioUnitario.Text
                    dtsp.gidventaplanilla = txtIdVenta.Text
                    dtsp.gvalidez = "V"
                    '''''''''''''''''''''''''''''''''''''''''''
                    Dim ms As New IO.MemoryStream()
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    If funcp.insertarDVPlanilla(dtsp) Then
                        If funcp.disminuir_stock(dtsp) Then
                        End If
                        MessageBox.Show("articulo añadido correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrarDVPlanilla()
                        txttotal.Text = sumar().ToString
                        limpiar()
                    Else
                        MessageBox.Show("articulo no registrada", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrarDVPlanilla()
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
    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If

    End Sub

    Private Sub btnquitar_Click(sender As Object, e As EventArgs) Handles btnquitar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea quitar los productos seleccionados?", "Eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("iddetalle_venta_planilla").Value)
                        Dim vdb As New vDetalleVentaPlanillaREDRUBI
                        Dim func As New fDetalleVentaPlanillaREDRUBI
                        vdb.giddedatlle_venta = onekey
                        vdb.gidproducto = datalistado.SelectedCells.Item(3).Value
                        vdb.gidventaplanilla = datalistado.SelectedCells.Item(9).Value
                        vdb.gcantidad = datalistado.SelectedCells.Item(5).Value
                        vdb.gvalidez = "V"
                        If func.eliminar(vdb) Then
                            If func.aumentar_stock(vdb) Then
                            End If
                        Else
                            MessageBox.Show("Fue eliminado", "Eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                        End If
                    End If
                Next
                Call mostrarDVPlanilla()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminacion de registro", "Eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrarDVPlanilla()

        End If
        mostrarDVPlanilla()
        txttotal.Text = sumar().ToString
        limpiar()
        cbeliminar.Checked = False


    End Sub
    Private Sub cbeliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("Eliminar").Visible = True
        Else
            datalistado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub
    Public Function sumar() As Double

        Dim total As Double

        For Each rowtotal As DataGridViewRow In datalistado.Rows
            total += Convert.ToDouble(rowtotal.Cells("Total Parcial").Value)

        Next

        Return total

    End Function


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        mostrarDVPlanilla()

    End Sub


    'Private Sub btnquitar_Click(sender As Object, e As EventArgs) Handles btnquitar.Click
    '    Dim result As DialogResult

    '    result = MessageBox.Show("Realmente desea quitar los seleccionados?", "Eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
    '    If result = DialogResult.OK Then
    '        Try
    '            For Each row As DataGridViewRow In datalistado.Rows
    '                Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

    '                If marcado Then
    '                    Dim onekey As Integer = Convert.ToInt32(row.Cells("iddetalle_venta").Value)
    '                    Dim vdb As New vDetalleVenta
    '                    Dim func As New fDetalleVenta
    '                    vdb.giddedatlle_venta = onekey
    '                    vdb.gidproducto = datalistado.SelectedCells.Item(3).Value
    '                    vdb.gidventa = datalistado.SelectedCells.Item(2).Value
    '                    vdb.gcantidad = datalistado.SelectedCells.Item(5).Value
    '                    If func.eliminar(vdb) Then
    '                        If func.aumentar_stock(vdb) Then
    '                        End If
    '                    Else
    '                        MessageBox.Show("Fue eliminado", "Eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
    '                    End If
    '                End If
    '            Next
    '            Call mostrar()
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    Else
    '        MessageBox.Show("Cancelando eliminacion de registro", "Eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Call mostrar()

    '    End If
    '    mostrar()
    '    txttotal.Text = sumar().ToString
    '    limpiar()
    '    cbeliminar.Checked = False

    'End Sub




    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        frmProductoREDRUBI.txtTag.Text = "2"
        frmProductoREDRUBI.ShowDialog()

    End Sub



    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()

    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar = _
                Threading.Thread.CurrentThread. _
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
    End Sub

    Private Sub txtCantidad_ValueChanged(sender As Object, e As EventArgs) Handles txtCantidad.ValueChanged
        Dim cant As Double
        cant = txtCantidad.Text
        If txtCantidad.Text > txtStock.Value Then
            MessageBox.Show("La cantidad que intenta vender supera el stock", "Error al vender")
            'btnGuardar.Visible = 0
            txtCantidad.Text = txtStock.Value
        Else
            btnGuardar.Visible = 1
        End If
        'If txtCantidad.Text = 0 Then
        '    btnGuardar.Visible = 0
        'Else
        '    btnGuardar.Visible = 1
        'End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmReporteVentasPlanillas.MdiParent = frmInicioF
        frmReporteVentasPlanillas.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult
        Dim dts As New vDetalleVentaPlanillaREDRUBI
        Dim func As New fDetalleVentaPlanillaREDRUBI

        result = MessageBox.Show("Realmente desea eliminar la venta?", "Eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then

            dts.gidventaplanilla = txtIdVenta.Text
            ' func.eliminarproductoVenta(dts)

            Dim dtsDV As New vVentaPlanillaREDRUBI
            Dim funcDV As New fVentaPlanillaREDRUBI

            dtsDV.Gidventaplanilla = txtIdVenta.Text
            '  funcDV.eliminar(dtsDV)

            If (func.eliminarproductoVenta(dts) And funcDV.eliminarventaPlanilla(dtsDV)) Then
                MessageBox.Show("Venta Eliminada", "eliminando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.Close()
        End If
    End Sub
End Class