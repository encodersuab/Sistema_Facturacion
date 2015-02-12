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
Partial Public Class frmDetalleVenta
    Private dt As New DataTable
    Private Sub frmDetalleVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        QrCodeImgControl1.Visible = False
        limpiar()
        mostrarDatosImpuestos()

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
        txtCantidad.Text = 1
        txtStock.Text = 1
        txtImpCreFis.Text = 0


    End Sub

    Private Sub mostrar()
        txttotal.Text = 0

        Try
            Dim func As New fDetalleVenta
            dt = func.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                datalistado.ColumnHeadersVisible = False
                Inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                datalistado.ColumnHeadersVisible = False
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
        'datalistado.Columns(1).Visible = False
        'datalistado.Columns(2).Visible = False
        'datalistado.Columns(3).Visible = False
    End Sub



    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        mostrar()

    End Sub



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtIdProducto.Text <> "" And txtCantidad.Text <> "" And txtPrecioUnitario.Text <> "" Then
            Try



                Dim dts As New vDetalleVenta
                Dim func As New fDetalleVenta

                dts.gidventa = txtIdVenta.Text
                dts.gidproducto = txtIdProducto.Text
                dts.gcantidad = txtCantidad.Text
                dts.gprecio_unitario = txtPrecioUnitario.Text

                '''''''''''''''''''''''''''''''''''''''''''
                Dim ms As New IO.MemoryStream()


                'cmd.Parameters.AddWithValue("nombre", txtNombre.Text)
                'Dim memoriaImagenQR As MemoryStream = New MemoryStream
                'QrCodeImgControl1.Image.Save(memoriaImagenQR, ImageFormat.Jpeg)
                'Dim byteqr() As Byte = New Byte((memoriaImagenQR.Length) - 1) {}
                'memoriaImagenQR.Position = 0
                'memoriaImagenQR.Read(byteqr, 0, Convert.ToInt32(memoriaImagenQR.Length))
                'cmd.Parameters.AddWithValue("foto", byteqr)


                QrCodeImgControl1.Image.Save(ms, QrCodeImgControl1.Image.RawFormat)
                ''QrCodeImgControl1.Image = My.Resources.fondo_transparente_fotos
                ''QrCodeImgControl1.Image.Save(ms, QrCodeImgControl1.Image.RawFormat)



                'imagen.Image.Save(ms, imagen.Image.RawFormat)
                '        Else
                'imagen.Image = My.Resources.fondo_transparente_fotos
                'imagen.Image.Save(ms, imagen.Image.RawFormat)
                '        End If

                dts.gimagen = ms.GetBuffer

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                If func.insertar(dts) Then
                    If func.disminuir_stock(dts) Then

                    End If
                    MessageBox.Show("articulo añadido correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    txttotal.Text = sumar().ToString
                    limpiar()


                    QrCodeImgControl1.Visible = True
                    QrCodeImgControl1.Text = txtnituab.Text + "|" + txtIdVenta.Text + "|" + dtpFecha.Text + "|" + txttotal.Text
                    QrCodeImgControl1.Enabled = True




                Else
                    MessageBox.Show("articulo no registrada", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                        Dim vdb As New vDetalleVenta
                        Dim func As New fDetalleVenta
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

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()

    End Sub

    Private Sub btnquitar_Click(sender As Object, e As EventArgs) Handles btnquitar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea quitar los seleccionados?", "Eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("iddetalle_venta").Value)
                        Dim vdb As New vDetalleVenta
                        Dim func As New fDetalleVenta
                        vdb.giddedatlle_venta = onekey
                        vdb.gidproducto = datalistado.SelectedCells.Item(3).Value
                        vdb.gidventa = datalistado.SelectedCells.Item(2).Value
                        vdb.gcantidad = datalistado.SelectedCells.Item(5).Value
                        If func.eliminar(vdb) Then
                            If func.aumentar_stock(vdb) Then

                            End If
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
    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        frmProducto.txtTag.Text = "1"
        frmProducto.ShowDialog()
    End Sub

    Private Sub txtCantidad_ValueChanged(sender As Object, e As EventArgs) Handles txtCantidad.ValueChanged
        Dim cant As Double
        cant = txtCantidad.Value
        If txtCantidad.Value > txtStock.Value Then
            MessageBox.Show("La cantidad que intenta vender supera el stock", "Error al vender")
            btnGuardar.Visible = 0
            txtCantidad.Value = txtStock.Value
        Else
            btnGuardar.Visible = 1
        End If
        If txtCantidad.Value = 0 Then
            btnGuardar.Visible = 0
        Else
            btnGuardar.Visible = 1
        End If

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


    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click





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
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        Dim real As Double = Double.Parse(monto)
        real = Math.Round(real, 0)
        Dim total As String = real.ToString()
        Return real.ToString()

    End Function

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'para generar el codigo Control

        Dim fecha, monto As String
        fecha = CalcularFechaParaCC()
        monto = calcularMontoCC(txttotal.Text)

        lbCC.Text = fCC.generar(lbnumAutor.Text, txtIdVenta.Text, txtNumDoc.Text, fecha, monto, lbllave.Text).ToString
        ''''''''''''''''''''''''''''''''''
        Try
            Dim ms As New IO.MemoryStream()
            Dim dts As New vQr
            Dim func As New fQr

            QrCodeImgControl1.Visible = True
            QrCodeImgControl1.Text = txtnituab.Text + "|" + txtIdVenta.Text + "|" + lbnumAutor.Text + "|" + dtpFecha.Text + "|" + txttotal.Text + "|" + txtImpCreFis.Text + "|" + lbCC.Text + "|" + txtNumDoc.Text
            QrCodeImgControl1.Enabled = True
            QrCodeImgControl1.Image.Save(ms, QrCodeImgControl1.Image.RawFormat)




            ' '''''''''''''
            dts.gNit_Emisor = txtnituab.Text
            dts.gNum_Factura = txtIdVenta.Text

            dts.gNum_Autorizacion = lbnumAutor.Text
            dts.gTotal = txttotal.Text
            dts.gCodigo_Control = txtImpCreFis.Text
            dts.gCi_Nit_Comprador = txtNumDoc.Text
            dts.gimagen = ms.GetBuffer
            dts.gIdVenta = txtIdVenta.Text
            dts.gfecha_emision = dtpFecha.Text

            ''''''''

            If func.insertar(dts) Then

                MessageBox.Show("Venta realizada Correctamente", "Guardando Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()

            Else
                MessageBox.Show("No se a podido guardar la venta  Correctamente", "Guardando Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If














        Catch ex As Exception

        End Try

    End Sub
End Class