<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.ButClose = New System.Windows.Forms.Button()
        Me.FolderSelect = New System.Windows.Forms.Button()
        Me.TxtFolder = New System.Windows.Forms.TextBox()
        Me.ListTracks = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TrackNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayPauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepeatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepeatAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepeatOneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShuffleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(12, 146)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(260, 45)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'ButClose
        '
        Me.ButClose.Location = New System.Drawing.Point(12, 226)
        Me.ButClose.Name = "ButClose"
        Me.ButClose.Size = New System.Drawing.Size(260, 23)
        Me.ButClose.TabIndex = 1
        Me.ButClose.Text = "Hide"
        Me.ButClose.UseVisualStyleBackColor = True
        '
        'FolderSelect
        '
        Me.FolderSelect.Location = New System.Drawing.Point(167, 197)
        Me.FolderSelect.Name = "FolderSelect"
        Me.FolderSelect.Size = New System.Drawing.Size(105, 23)
        Me.FolderSelect.TabIndex = 2
        Me.FolderSelect.Text = "Select Folder"
        Me.FolderSelect.UseVisualStyleBackColor = True
        '
        'TxtFolder
        '
        Me.TxtFolder.Enabled = False
        Me.TxtFolder.Location = New System.Drawing.Point(13, 198)
        Me.TxtFolder.Name = "TxtFolder"
        Me.TxtFolder.Size = New System.Drawing.Size(139, 20)
        Me.TxtFolder.TabIndex = 3
        '
        'ListTracks
        '
        Me.ListTracks.FormattingEnabled = True
        Me.ListTracks.Location = New System.Drawing.Point(13, 13)
        Me.ListTracks.Name = "ListTracks"
        Me.ListTracks.Size = New System.Drawing.Size(259, 121)
        Me.ListTracks.TabIndex = 4
        Me.ListTracks.UseWaitCursor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrackNameToolStripMenuItem, Me.ToolStripSeparator1, Me.PlayPauseToolStripMenuItem, Me.NextToolStripMenuItem, Me.PreviousToolStripMenuItem, Me.ModeToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(139, 148)
        '
        'NotifyIcon
        '
        Me.NotifyIcon.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "NotifyIcon1"
        Me.NotifyIcon.Visible = True
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(135, 6)
        '
        'TrackNameToolStripMenuItem
        '
        Me.TrackNameToolStripMenuItem.Name = "TrackNameToolStripMenuItem"
        Me.TrackNameToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.TrackNameToolStripMenuItem.Text = "Track Name"
        '
        'PlayPauseToolStripMenuItem
        '
        Me.PlayPauseToolStripMenuItem.Name = "PlayPauseToolStripMenuItem"
        Me.PlayPauseToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.PlayPauseToolStripMenuItem.Text = "Play/Pause"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.NextToolStripMenuItem.Text = "Next"
        '
        'PreviousToolStripMenuItem
        '
        Me.PreviousToolStripMenuItem.Name = "PreviousToolStripMenuItem"
        Me.PreviousToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.PreviousToolStripMenuItem.Text = "Previous"
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RepeatToolStripMenuItem, Me.RepeatAllToolStripMenuItem, Me.RepeatOneToolStripMenuItem, Me.ShuffleToolStripMenuItem})
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        Me.ModeToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ModeToolStripMenuItem.Text = "Mode"
        '
        'RepeatToolStripMenuItem
        '
        Me.RepeatToolStripMenuItem.Name = "RepeatToolStripMenuItem"
        Me.RepeatToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RepeatToolStripMenuItem.Text = "Repeat"
        '
        'RepeatAllToolStripMenuItem
        '
        Me.RepeatAllToolStripMenuItem.Name = "RepeatAllToolStripMenuItem"
        Me.RepeatAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RepeatAllToolStripMenuItem.Text = "Repeat All"
        '
        'RepeatOneToolStripMenuItem
        '
        Me.RepeatOneToolStripMenuItem.Name = "RepeatOneToolStripMenuItem"
        Me.RepeatOneToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RepeatOneToolStripMenuItem.Text = "Repeat One"
        '
        'ShuffleToolStripMenuItem
        '
        Me.ShuffleToolStripMenuItem.Name = "ShuffleToolStripMenuItem"
        Me.ShuffleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ShuffleToolStripMenuItem.Text = "Shuffle"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(135, 6)
        '
        'FolderBrowserDialog
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.ListTracks)
        Me.Controls.Add(Me.TxtFolder)
        Me.Controls.Add(Me.FolderSelect)
        Me.Controls.Add(Me.ButClose)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Name = "Form1"
        Me.Text = "MP3 Player"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents ButClose As System.Windows.Forms.Button
    Friend WithEvents FolderSelect As System.Windows.Forms.Button
    Friend WithEvents TxtFolder As System.Windows.Forms.TextBox
    Friend WithEvents ListTracks As System.Windows.Forms.ListBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents TrackNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PlayPauseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepeatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepeatAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepeatOneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShuffleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog

End Class
