<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasicForm
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BasicForm))
        Me.Clipboard = New System.Windows.Forms.ListBox()
        Me.BaseTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TrayContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MostraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChiudiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Clipboard
        '
        Me.Clipboard.FormattingEnabled = True
        Me.Clipboard.Location = New System.Drawing.Point(12, 12)
        Me.Clipboard.Name = "Clipboard"
        Me.Clipboard.Size = New System.Drawing.Size(245, 82)
        Me.Clipboard.TabIndex = 0
        '
        'BaseTimer
        '
        Me.BaseTimer.Enabled = True
        Me.BaseTimer.Interval = 1
        '
        'CopyButton
        '
        Me.CopyButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CopyButton.Location = New System.Drawing.Point(12, 103)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(245, 23)
        Me.CopyButton.TabIndex = 2
        Me.CopyButton.Text = "Copia"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'TrayIcon
        '
        Me.TrayIcon.BalloonTipTitle = "BasicClipboard"
        Me.TrayIcon.ContextMenuStrip = Me.TrayContextMenu
        Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
        Me.TrayIcon.Text = "BasicClipboard"
        Me.TrayIcon.Visible = True
        '
        'TrayContextMenu
        '
        Me.TrayContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MostraToolStripMenuItem, Me.ChiudiToolStripMenuItem})
        Me.TrayContextMenu.Name = "ContextMenu"
        Me.TrayContextMenu.Size = New System.Drawing.Size(167, 48)
        '
        'MostraToolStripMenuItem
        '
        Me.MostraToolStripMenuItem.Name = "MostraToolStripMenuItem"
        Me.MostraToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.MostraToolStripMenuItem.Text = "Mostra/Nascondi"
        '
        'ChiudiToolStripMenuItem
        '
        Me.ChiudiToolStripMenuItem.Name = "ChiudiToolStripMenuItem"
        Me.ChiudiToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ChiudiToolStripMenuItem.Text = "Chiudi"
        '
        'BasicForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 138)
        Me.ControlBox = False
        Me.Controls.Add(Me.CopyButton)
        Me.Controls.Add(Me.Clipboard)
        Me.MaximizeBox = False
        Me.Name = "BasicForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "BasicClipboard"
        Me.TopMost = True
        Me.TrayContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Clipboard As ListBox
    Friend WithEvents BaseTimer As Timer
    Friend WithEvents CopyButton As Button
    Friend WithEvents TrayIcon As NotifyIcon
    Friend WithEvents TrayContextMenu As ContextMenuStrip
    Friend WithEvents MostraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChiudiToolStripMenuItem As ToolStripMenuItem
End Class
