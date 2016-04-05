<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprimirOrdenPAgo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.AutoZoom = False
        Me.PrintPreviewControl1.Document = Me.PrintDocument1
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(1, 1)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(888, 326)
        Me.PrintPreviewControl1.TabIndex = 0
        Me.PrintPreviewControl1.Zoom = 1.0R
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(409, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "IMPRIMIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmImprimirOrdenPAgo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 373)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PrintPreviewControl1)
        Me.Name = "frmImprimirOrdenPAgo"
        Me.Text = "frmImprimirOrdenPAgo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewControl1 As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
