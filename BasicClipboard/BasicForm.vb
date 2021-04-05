Public Class BasicForm

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles BaseTimer.Tick
        If Me.WindowState = FormWindowState.Minimized Then
            Me.TopMost = False
        Else
            Me.TopMost = True
        End If
        Try
            If Not Clipboard.Items.Contains(My.Computer.Clipboard.GetText) Then
                Clipboard.Items.Add(My.Computer.Clipboard.GetText)
            End If
        Finally
        End Try
    End Sub

    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        Try
            My.Computer.Clipboard.SetText(Clipboard.SelectedItem)
        Catch
            MsgBox("Non hai selezionato un elemento da copiare.", MsgBoxStyle.Critical, "BasicClipboard")
        End Try
    End Sub

    Private Sub Icon_Click(sender As Object, e As EventArgs) Handles TrayIcon.Click
        TrayContextMenu.Show()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Size = New Size(285, 177)
    End Sub

    Private Sub ChiudiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiudiToolStripMenuItem.Click
        End
    End Sub

    Private Sub MostraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostraToolStripMenuItem.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Minimized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class
