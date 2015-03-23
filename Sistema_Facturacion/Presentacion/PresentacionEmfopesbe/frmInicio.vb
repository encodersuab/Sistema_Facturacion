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
        If lbrol.Text = "UsuarioEMFOPESBE" Then
            fexpobeni.Enabled = False
            redrubi.Enabled = False
            emfopesbe.Enabled = True
            postgrado.Enabled = False
            registroE.Enabled = False
        Else
            If lbrol.Text = "AdministradorEMFOPESBE" Then
                redrubi.Enabled = False
                emfopesbe.Enabled = True
                postgrado.Enabled = False
                fexpobeni.Enabled = False
            Else
                If lbrol.Text = "UsuarioREDRUBI" Then
                    fexpobeni.Enabled = False
                    redrubi.Enabled = True
                    emfopesbe.Enabled = False
                    postgrado.Enabled = False
                    registroR.Enabled = False
                Else
                    If lbrol.Text = "AdministradorREDRUBI" Then
                        fexpobeni.Enabled = False
                        redrubi.Enabled = True
                        emfopesbe.Enabled = False
                        postgrado.Enabled = False
                    Else
                        If lbrol.Text = "UsuarioPOSGRADO" Then
                            fexpobeni.Enabled = False
                            redrubi.Enabled = False
                            emfopesbe.Enabled = False
                            postgrado.Enabled = True
                            registroP.Enabled = False
                        Else
                            If lbrol.Text = "AdministradorPOSGRADO" Then
                                fexpobeni.Enabled = False
                                redrubi.Enabled = False
                                emfopesbe.Enabled = False
                                postgrado.Enabled = True
                            Else
                                If lbrol.Text = "UsuarioFEXPOBENI" Then
                                    fexpobeni.Enabled = True
                                    redrubi.Enabled = False
                                    emfopesbe.Enabled = False
                                    postgrado.Enabled = False
                                    registroF.Enabled = False
                                Else
                                    If lbrol.Text = "AdministradorFEXPOBENI" Then
                                        fexpobeni.Enabled = True
                                        redrubi.Enabled = False
                                        emfopesbe.Enabled = False
                                        postgrado.Enabled = False
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
        frmProductoFEXPOBENI.MdiParent = Me
        frmProductoFEXPOBENI.Show()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        frmCategoriaFEXPOBENI.MdiParent = Me
        frmCategoriaFEXPOBENI.Show()
    End Sub


    Private Sub RpteProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RpteProductoToolStripMenuItem.Click
        frmReporteProductos.MdiParent = Me
        frmReporteProductos.Show()

    End Sub

    Private Sub RpteClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RpteClienteToolStripMenuItem.Click
        frmReporteCliente.MdiParent = Me
        frmReporteCliente.Show()

    End Sub

    Private Sub CategoriaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem2.Click
        frmReporteCatergotria.MdiParent = Me
        frmReporteCatergotria.Show()

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

    Private Sub VentaR_Click(sender As Object, e As EventArgs) Handles VentaR.Click
        frmVentaREDRUBI.MdiParent = Me
        frmVentaREDRUBI.Show()
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        frmClientePostGrado.MdiParent = Me
        frmClientePostGrado.Show()
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem15.Click
        frmProductoPostGrado.MdiParent = Me
        frmProductoPostGrado.Show()
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem16.Click
        frmCategoriaPostGrado.MdiParent = Me
        frmCategoriaPostGrado.Show()
    End Sub

    Private Sub ventaP_Click(sender As Object, e As EventArgs) Handles ventaP.Click
        frmVentaPostGrado.MdiParent = Me
        frmVentaPostGrado.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        frmCategoriaFEXPOBENI.MdiParent = Me
        frmCategoriaFEXPOBENI.Show()
    End Sub

    Private Sub ventaF_Click(sender As Object, e As EventArgs) Handles ventaF.Click
        frmVentaFEXPOBENI.MdiParent = Me
        frmVentaFEXPOBENI.Show()
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
        frmrptVentas.MdiParent = Me
        frmrptVentas.Show()
    End Sub

    Private Sub ContadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContadoToolStripMenuItem1.Click
        frmVentaPostGrado.MdiParent = Me
        frmVentaPostGrado.Show()
    End Sub

    Private Sub PorPlanillaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PorPlanillaToolStripMenuItem1.Click
        frmVentaPlanillaPostGrado.MdiParent = Me
        frmVentaPlanillaPostGrado.Show()
    End Sub

    Private Sub ToolStripMenuItem19_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem19.Click
        frmrptVentas.MdiParent = Me
        frmrptVentas.Show()
    End Sub

    Private Sub ToolStripMenuItem20_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem20.Click
        frmReporteProductos.MdiParent = Me
        frmReporteProductos.Show()
    End Sub

    Private Sub ToolStripMenuItem21_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem21.Click
        frmReporteCatergotria.MdiParent = Me
        frmReporteCatergotria.Show()
    End Sub

    Private Sub RpteClienteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RpteClienteToolStripMenuItem1.Click
        frmReporteCliente.MdiParent = Me
        frmReporteCliente.Show()
    End Sub

    Private Sub RptUsuariosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RptUsuariosToolStripMenuItem1.Click
        frmReporteUsuarios.MdiParent = Me
        frmReporteUsuarios.Show()
    End Sub

    Private Sub AnularFacturaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AnularFacturaToolStripMenuItem1.Click
        frmQR.MdiParent = Me
        frmQR.Show()
    End Sub
End Class
