Public Class Form1

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening, ContextMenuStrip1.Opening

    End Sub

    Private Sub ButClose_Click(sender As Object, e As EventArgs) Handles ButClose.Click
        Me.Visible = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FolderBrowserDialog_HelpRequest(sender As Object, e As EventArgs) Handles FolderBrowserDialog.HelpRequest
        
    End Sub

    Private Sub FolderSelect_Click(sender As Object, e As EventArgs) Handles FolderSelect.Click
        If FolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TxtFolder.Text = FolderBrowserDialog.SelectedPath.ToString
        End If
    End Sub

    Private Sub TxtFolder_TextChanged(sender As Object, e As EventArgs) Handles TxtFolder.TextChanged
        ListTracks.Items.Clear()
        If Not TxtFolder.Text = "" Then
            For Each file As String In My.Computer.FileSystem.GetFiles(TxtFolder.Text, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "*.mp3")
                ListTracks.Items.Add(file)
            Next
        End If
    End Sub
End Class
