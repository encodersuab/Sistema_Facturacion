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
Public Class frmDetalleVentaPostGrado
    Private dt As New DataTable
    Private Sub frmDetalleVentaPostGrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        QrCodeImgControl1.Visible = False
        limpiar()
        mostrarDatosImpuestos()

        '  txtIdVenta.Text = datalistado.SelectedCells.Item(8).Value
    End Sub


    Public Sub mostrarDatosImpuestos()
        Dim dt1 As New DataTable
        Dim fdatosImp As New fDatosImpuestos
        dt1 = fdatosImp.mostrar3

        txtnituab.Text = dt1.Rows(0)("nitEmisor").ToString
        lbllave.Text = dt1.Rows(0)("llave").ToString
        lbnumAutor.Text = dt1.Rows(0)("numAutorizacion").ToString
        lbFechaLimite.Text = dt1.Rows(0)("fechaLimite").ToString
    End Sub
    Public Sub limpiar()
        btnGuardar.Visible = True



        txtCantidad.Text = 1
        txtncuota.Text = 0
        If txtDD.Text = 1 Then
            Button2.Enabled = False
            btnBuscarProducto.Enabled = False
            '  txtCantidad.Enabled = False
            txtPrecioUnitario.Enabled = False
            lbmedida.Visible = False
            '     btncancelar.Enabled = False
            btnGuardar.Enabled = False
            btnNuevo.Enabled = False
        Else
            Button2.Enabled = True
            btnBuscarProducto.Enabled = True
            ' txtCantidad.Enabled = True
            txtPrecioUnitario.Enabled = True
            lbmedida.Visible = True
            '   btncancelar.Enabled = True
            btnGuardar.Enabled = True
            btnNuevo.Enabled = True
        End If
        If CodCobranza.Text = 8 Then
            btnBuscarProducto.Enabled = False
            btnNuevo.Enabled = False
            txtCantidad.Enabled = False

            btnConsultarCuotas.Visible = False
            btnConsultarPagos.Visible = True
            Label8.Visible = False
            txtncuota.Visible = False

            'txtIdProducto.Text = ""
            'txtNombreProducto.Text = ""
            'txtPrecioUnitario.Text = ""
        Else
            txtIdProducto.Text = ""
            txtNombreProducto.Text = ""
            txtPrecioUnitario.Text = ""

            btnConsultarCuotas.Visible = True
            btnConsultarPagos.Visible = False

            Label8.Visible = True
            txtncuota.Visible = True
        End If
    End Sub

    Private Sub mostrar()
        txttotal.Text = 0

        Try
            Dim func As New fDetalleVentaPostGrado
            dt = func.mostrar



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
                ocultar_columnas()
            Else
                Inexistente.Visible = True
                datalistado.DataSource = Nothing
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ocultar_columnas()
        If dt.Rows.Count <> 0 Then
            datalistado.Columns(1).Visible = False
            datalistado.Columns(2).Visible = False
        End If

    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        mostrar()

    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtCantidad.Text = 0 Then
            MessageBox.Show("CANTIDAD INCORRECTA")
        Else

            If Me.ValidateChildren = True And txtIdProducto.Text <> "" And txtCantidad.Text <> "" And txtPrecioUnitario.Text <> "" Then
                'System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
                Try

                    Dim dts As New vDetalleVentaPostGrado
                    Dim func As New fDetalleVentaPostGrado

                    dts.gidventa = txtIdVenta.Text
                    dts.gidproducto = txtIdProducto.Text
                    dts.gcantidad = txtCantidad.Text
                    dts.gprecio_unitario = txtPrecioUnitario.Text
                    dts.gvalidez = "V"
                    dts.gncuota = txtncuota.Text
                    dts.gdetalle = lbdetalle.Text
                    '''''''''''''''''''''''''''''''''''''''''''
                    Dim ms As New IO.MemoryStream()

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                    If func.insertar(dts) Then
                        'If func.disminuir_stock(dts) Then

                        'End If
                        MessageBox.Show("Cuota registrada correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        txttotal.Text = sumar().ToString
                        lbliteral.Text = Numalet.ToCardinal(CDbl(txttotal.Text)).ToString
                        limpiar()
                    Else
                        MessageBox.Show("Cuota no registrada", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value

        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar los clientes seleccionados?", "Eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idcliente").Value)
                        Dim vdb As New vDetalleVentaPostGrado
                        Dim func As New fDetalleVentaPostGrado
                        vdb.giddedatlle_venta = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("Clioente no fue eliminado", "Eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                        End If
                    End If
                Next
                Call mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminacion de registro", "Eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()

        End If
    End Sub

    Private Sub cbeliminar_CheckedChanged(sender As Object, e As EventArgs)
        'If cbeliminar.CheckState = CheckState.Checked Then
        '    datalistado.Columns.Item("Eliminar").Visible = True
        'Else
        '    datalistado.Columns.Item("Eliminar").Visible = False
        'End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs)
        Buscar()

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub btnquitar_Click(sender As Object, e As EventArgs) Handles btnquitar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea quitar los productos seleccionados?", "Eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("iddetalle_venta").Value)
                        Dim vdb As New vDetalleVentaPostGrado
                        Dim func As New fDetalleVentaPostGrado
                        vdb.giddedatlle_venta = onekey
                        vdb.gidproducto = datalistado.SelectedCells.Item(3).Value
                        vdb.gidventa = datalistado.SelectedCells.Item(2).Value
                        vdb.gcantidad = datalistado.SelectedCells.Item(5).Value
                        vdb.gvalidez = "V"
                        If func.eliminar(vdb) Then
                            'If func.aumentar_stock(vdb) Then
                            'End If
                        Else
                            MessageBox.Show("Fue eliminado", "Eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                        End If
                    End If
                Next
                Call mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminacion de registro", "Eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()

        End If
        mostrar()
        txttotal.Text = sumar().ToString
        limpiar()
        cbeliminar.Checked = False


    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        lbdetalle.Text = ""
        frmProductoPostGrado.txtidcliente.Text = txtidCliente.Text
        frmProductoPostGrado.txtTag.Text = "1"
        frmProductoPostGrado.ShowDialog()
        lbdetalle.Text = "/PRODUCTO:" + lbdetalle.Text + "nCUOTA:" + txtncuota.Text + "/FACTURADO:" + txtNombreFac.Text + "/DOCUMENTO:" + txtNumDoc.Text + "/USUARIO:" + frmInicioF.lbUsurio.Text
    End Sub



    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub cbeliminar_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("Eliminar").Visible = True
        Else
            datalistado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub




    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick

    End Sub


    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    
    'End Sub

    'Private Sub QrCodeImgControl1_Click(sender As Object, e As EventArgs) Handles QrCodeImgControl1.Click

    'End Sub

    ''Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    ''    QrCodeImgControl1.Visible = True
    ''    QrCodeImgControl1.Text = txtnituab.Text + "|" + txtIdVenta.Text + "|" + dtpFecha.Text
    ''    QrCodeImgControl1.Enabled = True
    ''End Sub


    Public Function sumar() As Double

        Dim total As Double
        For Each rowtotal As DataGridViewRow In datalistado.Rows
            total += Convert.ToDouble(rowtotal.Cells("Total Parcial").Value)
        Next
        Return total
    End Function


    Public Function CalcularFechaParaCC() As String
        'CALCULAR LA FECHA
        Dim x As DateTime = DateTime.Now
        Dim FECHA As Integer = ((x.Year * 100) + x.Month) * 100 + x.Day
        Return FECHA.ToString()

    End Function


    Public Function calcularMontoCC(ByRef monto As String) As String
        'CALCULAR EL MONTO
        '  System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        Dim real As Double = Double.Parse(monto)
        real = Math.Round(real, 0)
        Dim total As String = real.ToString()
        Return real.ToString()

    End Function

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFinalizarVenta.Click
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        txttotal.Text = sumar().ToString
        lbliteral.Text = Numalet.ToCardinal(CDbl(txttotal.Text)).ToString
        If txttotal.Text = 0 Then
            MessageBox.Show("SELECCIONAR ARTICULOS")
        Else
            'para generar el codigo Control

            Dim fecha, monto As String
            fecha = CalcularFechaParaCC()
            monto = calcularMontoCC(txttotal.Text)



            ''''''''''''''''''''''''''''''''''
            Try


                Dim ms As New IO.MemoryStream()
                Dim dts As New vQr
                Dim func As New fQr
                Dim f, aux As String

                aux = func.mostrarUltimoQR3.ToString + 1

                lbCC.Text = CC.generar(lbnumAutor.Text, aux, txtNumDoc.Text, fecha, monto, lbllave.Text).ToString

                f = dtpFecha.Value.Date.ToString("dd/MM/yyyy")
                ' QrCodeImgControl1.Visible = True
                QrCodeImgControl1.Text = txtnituab.Text + "|" + aux + "|" + lbnumAutor.Text + "|" + f.ToString + "|" + txttotal.Text + "|" + txttotal.Text + "|" + lbCC.Text + "|" + txtNumDoc.Text + "|" + "0" + "|" + "0" + "|" + "0" + "|" + "0"
                'QrCodeImgControl1.Enabled = True
                QrCodeImgControl1.Image.Save(ms, QrCodeImgControl1.Image.RawFormat)
                '''''''' 
                dts.gfecha_emision = dtpFecha.Value.Date
                dts.gNit_Emisor = txtnituab.Text
                dts.gNum_Factura = aux
                dts.gNum_Autorizacion = lbnumAutor.Text
                dts.gTotal = txttotal.Text
                dts.gCodigo_Control = lbCC.Text
                dts.gCi_Nit_Comprador = txtNumDoc.Text
                dts.gimagen = ms.GetBuffer
                dts.gIdVenta = txtIdVenta.Text
                dts.gvalidez = "V"
                dts.gliteral = lbliteral.text
                dts.gfecha_limite = lbFechaLimite.Value.Date
                ''''''''
                If func.insertar3(dts) Then
                    frmFactura3.txtnumfactura.Text = aux
                    MessageBox.Show("Venta realizada Correctamente", "Guardando Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If CodCobranza.Text = 8 Then
                        Dim dts2 As New vDeudor
                        Dim func2 As New fDeudor

                        dts2.giddeudor = txtIdDeudor.Text
                        dts2.gcantidad_deuda = txttotal.Text
                        func2.disminuir_monto_adeudado(dts2)
                    End If

                    frmFactura3.MdiParent = frmInicioF
                    frmFactura3.Show()
                    Me.Close()
                    CodCobranza.Text = "0"
                Else
                    MessageBox.Show("No se a podido guardar la venta  Correctamente", "Guardando Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CodCobranza.Text = "0"
                End If
            Catch ex As Exception
                CancelarVentaPG()
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtnituab_TextChanged(sender As Object, e As EventArgs) Handles txtnituab.TextChanged

    End Sub

    Private Sub txtnituab_Validated(sender As Object, e As EventArgs) Handles txtnituab.Validated

    End Sub

    Private Sub cbTipoDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoDoc.SelectedIndexChanged

    End Sub

    Private Sub cbTipoDoc_Validated(sender As Object, e As EventArgs) Handles cbTipoDoc.Validated

    End Sub

    Private Sub txtNumDoc_TextChanged(sender As Object, e As EventArgs) Handles txtNumDoc.TextChanged

    End Sub

    Private Sub txtNumDoc_Validated(sender As Object, e As EventArgs) Handles txtNumDoc.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese numero de documento, ese dato es obligatorio")
        End If
    End Sub

    Private Sub lbllave_Click(sender As Object, e As EventArgs) Handles lbllave.Click

    End Sub

    Public Sub CancelarVentaPG()
        Dim result As DialogResult
        result = MessageBox.Show("realizar la anulacion de la venta?", "Anulando venta", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            If Me.ValidateChildren = True And txtIdVenta.Text <> "" Then
                Try

                    Dim dts1 As New vDetalleVentaPostGrado
                    Dim func1 As New fDetalleVentaPostGrado
                    Dim dts2 As New vDetalleVentaPostGrado
                    Dim func2 As New fDetalleVentaPostGrado
                    Dim dts3 As New vVentaPostGrado
                    Dim func3 As New fVentaPostGrado

                    Dim res As DialogResult
                    res = MessageBox.Show("REALMENTE QUIERE ANULAR LA VENTA", "VENTA ANULADA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    dts1.gidventa = txtIdVenta.Text
                    dts3.Gidventa = txtIdVenta.Text
                    If (res = Windows.Forms.DialogResult.Yes) Then
                        'func.editar(dts)
                        Do While func1.mostraridprodXidventa(dts1) <> 0

                            dts2.gidproducto = func1.mostraridprodXidventa(dts1)
                            dts2.gcantidad = func1.mostrarCantidadXidventa(dts1)
                            'func2.aumentar_stock(dts2)
                            dts2.giddedatlle_venta = func1.mostrariddetalleventaXidventa(dts1)
                            dts2.gvalidez = "A"
                            func2.editarValidez(dts2)
                            func1.eliminar(dts2)
                        Loop
                        func3.eliminar(dts3)
                        mostrar()
                        limpiar()
                        CodCobranza.Text = "0"
                    Else
                        MessageBox.Show("ERROR AL ANULAR ESTA VENTA", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                        CodCobranza.Text = "0"
                    End If
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("error de datos faltante", "error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        CancelarVentaPG()

    End Sub


    ''''''''''''''

    '''''''''''

    Private Sub txtPrecioUnitario_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioUnitario.TextChanged

    End Sub



    Private Sub txtCantidad_KeyPress1(sender As Object, e As KeyPressEventArgs)
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar = _
                Threading.Thread.CurrentThread. _
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
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



    'Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs)



    '    Try
    '        Dim cant As Double
    '        cant = txtCantidad.Text
    '        If txtCantidad.Text > txtStock.Value Then
    '            MessageBox.Show("La cantidad que intenta vender supera el stock", "Error al vender")
    '            btnGuardar.Visible = 0
    '            txtCantidad.Text = txtStock.Value
    '        Else
    '            btnGuardar.Visible = 1
    '        End If
    '        If txtCantidad.Text = 0 Then
    '            btnGuardar.Visible = 0
    '        Else
    '            btnGuardar.Visible = 1
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show("ingrese un monto  a vender")
    '    End Try
    'End Sub
    Private Sub txtCantidad_ValueChanged(sender As Object, e As EventArgs) Handles txtCantidad.ValueChanged
        Dim cant As Double
        cant = txtCantidad.Text
        If txtCantidad.Text > txtncuota.Value Then
            MessageBox.Show("error numero de cuota", "Error al vender")
            'btnGuardar.Visible = 0
            txtCantidad.Text = txtncuota.Value
        Else
            btnGuardar.Visible = 1
        End If
        If txtCantidad.Text = 0 Then
            btnGuardar.Visible = 0
        Else
            btnGuardar.Visible = 1
        End If
    End Sub



    Private Sub btnConsultarCuotas_Click(sender As Object, e As EventArgs) Handles btnConsultarCuotas.Click
        frmReporteCuotas.txtci.Text = txtNumDoc.Text
        frmReporteCuotas.txtNombre.Text = txtNombreProducto.Text

        '   frmReporteCuotas.MdiParent = frmInicioF
        frmReporteCuotas.Show()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub lbliteral_Click(sender As Object, e As EventArgs) Handles lbliteral.Click

    End Sub

    Private Sub txtncuota_ValueChanged(sender As Object, e As EventArgs) Handles txtncuota.ValueChanged

    End Sub

    Private Sub btnConsultarPagos_Click(sender As Object, e As EventArgs) Handles btnConsultarPagos.Click
        frmReportePagos.txtci.Text = txtNumDoc.Text
        frmReportePagos.txtNombre.Text = txtNombreProducto.Text

        '   frmReporteCuotas.MdiParent = frmInicioF
        frmReportePagos.Show()
    End Sub
End Class