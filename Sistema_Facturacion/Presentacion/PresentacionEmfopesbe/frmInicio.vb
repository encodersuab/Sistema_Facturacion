Imports System.Windows.Forms

Public Class frmInicioF

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        '     Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'AdministradorEMFOPESBE()
        'UsuarioEMFOPESBE()
        'AdministradorREDRUBI()
        'UsuarioREDRUBI()
        'AdministradorPOSGRADO()
        'UsuarioPOSGRADO()
        'AdministradorFEXPOBENI()
        'UsuarioFEXPOBENI()
        If lbrol.Text = "SUPER USUARIO" Then
           
        Else
            If lbrol.Text = "UsuarioEMFOPESBE" Then
                fexpobeni.Enabled = False
                redrubi.Enabled = False
                emfopesbe.Enabled = True
                postgrado.Enabled = False
                registroE.Enabled = False
                SUPERADMIN.Enabled = False

            Else
                If lbrol.Text = "AdministradorEMFOPESBE" Then
                    redrubi.Enabled = False
                    emfopesbe.Enabled = True
                    postgrado.Enabled = False
                    fexpobeni.Enabled = False
                    SUPERADMIN.Enabled = False
                Else
                    If lbrol.Text = "UsuarioREDRUBI" Then
                        fexpobeni.Enabled = False
                        redrubi.Enabled = True
                        emfopesbe.Enabled = False
                        postgrado.Enabled = False
                        registroR.Enabled = False
                        SUPERADMIN.Enabled = False
                    Else
                        If lbrol.Text = "AdministradorREDRUBI" Then
                            fexpobeni.Enabled = False
                            redrubi.Enabled = True
                            emfopesbe.Enabled = False
                            postgrado.Enabled = False
                            SUPERADMIN.Enabled = False
                        Else
                            If lbrol.Text = "UsuarioPOSTGRADO" Then
                                fexpobeni.Enabled = False
                                redrubi.Enabled = False
                                emfopesbe.Enabled = False
                                postgrado.Enabled = True
                                registroP.Enabled = False
                                SUPERADMIN.Enabled = False
                            Else
                                If lbrol.Text = "AdministradorPOSTGRADO" Then
                                    fexpobeni.Enabled = False
                                    redrubi.Enabled = False
                                    emfopesbe.Enabled = False
                                    postgrado.Enabled = True
                                    SUPERADMIN.Enabled = False
                                Else
                                    If lbrol.Text = "UsuarioCAMPOFERIAL" Then
                                        fexpobeni.Enabled = True
                                        redrubi.Enabled = False
                                        emfopesbe.Enabled = False
                                        postgrado.Enabled = False
                                        registroF.Enabled = False
                                        SUPERADMIN.Enabled = False
                                    Else
                                        If lbrol.Text = "AdministradorCAMPOFERIAL" Then
                                            fexpobeni.Enabled = True
                                            redrubi.Enabled = False
                                            emfopesbe.Enabled = False
                                            postgrado.Enabled = False
                                            SUPERADMIN.Enabled = False
                                        Else
                                            MessageBox.Show("USAURIO INCORRECTO")
                                            Me.Close()
                                            frmLogin.Show()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmCategoria.MdiParent = Me
        frmCategoria.Show()
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmProducto.MdiParent = Me
        frmProducto.Show()

    End Sub

    Private Sub RegistroDeVentaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmVenta.MdiParent = Me
        frmVenta.Show()


    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmCliente.MdiParent = Me
        frmCliente.Show()


    End Sub

    Private Sub ReporteDeProductoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub ReportesQrToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmQR.MdiParent = Me
        frmQR.Show()

    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientessmenuEmfopesbe.Click
        frmCliente.MdiParent = Me
        frmCliente.Show()

    End Sub

    Private Sub ProductoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductossmenuEmfopesbe.Click
        frmProducto.MdiParent = Me
        frmProducto.Show()

    End Sub


    Private Sub CategoriaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CategoriassmenuEmfopesbe.Click
        frmCategoria.MdiParent = Me
        frmCategoria.Show()

    End Sub

    Private Sub EMFOPESBEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles emfopesbe.Click


    End Sub

    Private Sub MenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub

    Private Sub VentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ventaE.Click

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles fexpobeni.Click

    End Sub



    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        frmProductoCAMPOFERIAL.MdiParent = Me
        frmProductoCAMPOFERIAL.Show()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        frmCategoriaCAMPOFERIAL.MdiParent = Me
        frmCategoriaCAMPOFERIAL.Show()
    End Sub


    Private Sub RpteProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RpteProductoToolStripMenuItem.Click
        'frmReporteProductos.MdiParent = Me
        'frmReporteProductos.Show()

    End Sub

    Private Sub RpteClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RpteClienteToolStripMenuItem.Click
        'frmReporteCliente.MdiParent = Me
        'frmReporteCliente.Show()

    End Sub

    Private Sub CategoriaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem2.Click
        'frmReporteCatergotria.MdiParent = Me
        'frmReporteCatergotria.Show()

    End Sub

    Private Sub ToolStripMenuItem25_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem25.Click
        frmClienteREDRUBI.MdiParent = Me
        frmClienteREDRUBI.Show()
    End Sub

    Private Sub ToolStripMenuItem26_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem26.Click
        frmProductoREDRUBI.MdiParent = Me
        frmProductoREDRUBI.Show()
    End Sub

    Private Sub ToolStripMenuItem27_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem27.Click
        frmCategoriaREDRUBI.MdiParent = Me
        frmCategoriaREDRUBI.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        frmClienteCAMPOFERIAL.MdiParent = Me
        frmClienteCAMPOFERIAL.Show()
    End Sub

    Private Sub ventaF_Click(sender As Object, e As EventArgs) Handles ventaF.Click

    End Sub



    Private Sub RptUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RptUsuariosToolStripMenuItem.Click
        frmReporteUsuarios.MdiParent = Me
        frmReporteUsuarios.Show()
    End Sub

    Private Sub ContadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContadoToolStripMenuItem.Click
        frmVenta.MdiParent = Me
        frmVenta.Show()
    End Sub

    Private Sub PorPlanillaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorPlanillaToolStripMenuItem.Click
        frmVentaPlanilla.MdiParent = Me
        frmVentaPlanilla.Show()
    End Sub

    Private Sub AnularFacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnularFacturaToolStripMenuItem.Click
        frmQR.MdiParent = Me
        frmQR.Show()
    End Sub


    Private Sub RptVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RptVentaToolStripMenuItem.Click
     
    End Sub

    Private Sub reporteF_Click(sender As Object, e As EventArgs) Handles reporteF.Click

    End Sub

    Private Sub reImprecionF_Click(sender As Object, e As EventArgs) Handles reImprecionF.Click
        frmQR.MdiParent = Me
        frmQR.Show()

    End Sub

    Private Sub ContadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContadoToolStripMenuItem1.Click
        frmVentaCAMPOFERIAL.MdiParent = Me
        frmVentaCAMPOFERIAL.Show()
    End Sub

    Private Sub PorPlanillaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PorPlanillaToolStripMenuItem1.Click
        frmVentaPlanillaCAMPOFERIAL.MdiParent = Me
        frmVentaPlanillaCAMPOFERIAL.Show()

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles registroP.Click

    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        frmClientePostGrado.MdiParent = Me
        frmClientePostGrado.Show()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        frmProductoPostGrado.MdiParent = Me
        frmProductoPostGrado.Show()
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        frmCategoriaPostGrado.MdiParent = Me
        frmCategoriaPostGrado.Show()
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        frmVentaPostGrado.MdiParent = Me
        frmVentaPostGrado.Show()
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        frmVentaPlanillaPostGrado.MdiParent = Me
        frmVentaPlanillaPostGrado.Show()
    End Sub

    Private Sub ToolStripMenuItem33_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem33.Click
        frmQR.MdiParent = Me
        frmQR.Show()
    End Sub

    Private Sub ContadoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ContadoToolStripMenuItem2.Click
        frmVentaREDRUBI.MdiParent = Me
        frmVentaREDRUBI.Show()
    End Sub

    Private Sub PorPlanillaToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        frmVentaPlanillaREDRUBI.MdiParent = Me
        frmVentaPlanillaREDRUBI.Show()
    End Sub

    Private Sub REImprecionR_Click(sender As Object, e As EventArgs) Handles REImprecionR.Click
        frmQR.MdiParent = Me
        frmQR.Show()
    End Sub

    Private Sub ToolStripMenuItem28_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem28.Click
        'frmReporteCliente.MdiParent = Me
        'frmReporteCliente.Show()
    End Sub

    Private Sub ToolStripMenuItem29_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem29.Click
        frmReporteUsuarios.MdiParent = Me
        frmReporteUsuarios.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        ''frmReporteCliente.MdiParent = Me
        ''frmReporteCliente.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        frmReporteUsuarios.MdiParent = Me
        frmReporteUsuarios.Show()
    End Sub

    Private Sub DatosImpuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SUPERADMIN.Click

    End Sub

    Private Sub PorPlanillaToolStripMenuItem2_Click_1(sender As Object, e As EventArgs) Handles PorPlanillaToolStripMenuItem2.Click
        frmVentaPlanillaREDRUBI.MdiParent = Me
        frmVentaPlanillaREDRUBI.Show()

    End Sub

    Private Sub lbUsurio_Click(sender As Object, e As EventArgs) Handles lbUsurio.Click

    End Sub

    Private Sub DATOSIMPUESTOSToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DATOSIMPUESTOSToolStripMenuItem.Click
        frmDatosImpuestos.MdiParent = Me
        frmDatosImpuestos.Show()
    End Sub

    Private Sub REGISTRODEUSUARIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTRODEUSUARIOSToolStripMenuItem.Click
        frmUsuario.MdiParent = Me
        frmUsuario.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub reporteE_Click(sender As Object, e As EventArgs) Handles reporteE.Click

    End Sub

    Private Sub VentasPorTipoDeClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasPorTipoDeClienteToolStripMenuItem.Click
        frmReporteVentasGeneralCliente.MdiParent = Me
        frmReporteVentasGeneralCliente.Show()

    End Sub

    Private Sub VentasEnGeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasEnGeneralToolStripMenuItem.Click
      
    End Sub

    Private Sub REPORTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REPORTESToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        frmReporteXclienteCAMPOFERIAL.MdiParent = Me
        frmReporteXclienteCAMPOFERIAL.Show()
    End Sub

    Private Sub PorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorClienteToolStripMenuItem.Click
        frmReporteVentasXclienteEmfopesbe.MdiParent = Me
        frmReporteVentasXclienteEmfopesbe.Show()



    End Sub

    Private Sub GeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralToolStripMenuItem.Click
        frmReporteVentasGeneralEmfopesbe.MdiParent = Me
        frmReporteVentasGeneralEmfopesbe.Show()
    End Sub

    Private Sub redrubi_Click(sender As Object, e As EventArgs) Handles redrubi.Click

    End Sub

    Private Sub PorClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorClientesToolStripMenuItem.Click
        frmReporteVentasXClienteRedRubi.MdiParent = Me
        frmReporteVentasXClienteRedRubi.Show()

    End Sub

    Private Sub GeneralToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GeneralToolStripMenuItem1.Click
        frmReporteVentasGeneralRedRubi.MdiParent = Me
        frmReporteVentasGeneralRedRubi.Show()

    End Sub
End Class
