<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MaserMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtbConsole = New System.Windows.Forms.RichTextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.bgwQueue = New System.ComponentModel.BackgroundWorker()
        Me.pgbTask = New System.Windows.Forms.ProgressBar()
        Me.pgbOverall = New System.Windows.Forms.ProgressBar()
        Me.lblTaskStatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tmrTask = New System.Windows.Forms.Timer(Me.components)
        Me.lblHours = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.lblPercOverall = New System.Windows.Forms.Label()
        Me.lblPercTask = New System.Windows.Forms.Label()
        Me.msMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMain
        '
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(800, 24)
        Me.msMain.TabIndex = 0
        Me.msMain.Text = "Menu"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(119, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'rtbConsole
        '
        Me.rtbConsole.BackColor = System.Drawing.Color.Black
        Me.rtbConsole.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbConsole.ForeColor = System.Drawing.Color.White
        Me.rtbConsole.Location = New System.Drawing.Point(31, 27)
        Me.rtbConsole.Name = "rtbConsole"
        Me.rtbConsole.ReadOnly = True
        Me.rtbConsole.Size = New System.Drawing.Size(738, 318)
        Me.rtbConsole.TabIndex = 1
        Me.rtbConsole.Text = ""
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.DarkGreen
        Me.btnStart.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(669, 371)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(100, 40)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnPause
        '
        Me.btnPause.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnPause.Enabled = False
        Me.btnPause.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPause.ForeColor = System.Drawing.Color.White
        Me.btnPause.Location = New System.Drawing.Point(669, 417)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(48, 23)
        Me.btnPause.TabIndex = 3
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = False
        Me.btnPause.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkRed
        Me.btnCancel.Enabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(721, 417)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(48, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        Me.btnCancel.Visible = False
        '
        'bgwQueue
        '
        Me.bgwQueue.WorkerReportsProgress = True
        Me.bgwQueue.WorkerSupportsCancellation = True
        '
        'pgbTask
        '
        Me.pgbTask.BackColor = System.Drawing.SystemColors.Control
        Me.pgbTask.ForeColor = System.Drawing.Color.Khaki
        Me.pgbTask.Location = New System.Drawing.Point(31, 371)
        Me.pgbTask.Maximum = 1000
        Me.pgbTask.Name = "pgbTask"
        Me.pgbTask.Size = New System.Drawing.Size(632, 20)
        Me.pgbTask.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgbTask.TabIndex = 6
        '
        'pgbOverall
        '
        Me.pgbOverall.ForeColor = System.Drawing.Color.LawnGreen
        Me.pgbOverall.Location = New System.Drawing.Point(31, 418)
        Me.pgbOverall.Name = "pgbOverall"
        Me.pgbOverall.Size = New System.Drawing.Size(632, 20)
        Me.pgbOverall.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgbOverall.TabIndex = 7
        '
        'lblTaskStatus
        '
        Me.lblTaskStatus.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaskStatus.Location = New System.Drawing.Point(31, 348)
        Me.lblTaskStatus.Name = "lblTaskStatus"
        Me.lblTaskStatus.Size = New System.Drawing.Size(632, 23)
        Me.lblTaskStatus.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 397)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Overall"
        '
        'tmrTask
        '
        Me.tmrTask.Interval = 1000
        '
        'lblHours
        '
        Me.lblHours.Location = New System.Drawing.Point(559, 395)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(20, 18)
        Me.lblHours.TabIndex = 10
        Me.lblHours.Text = "00"
        Me.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(585, 398)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = ":"
        '
        'lblMinutes
        '
        Me.lblMinutes.Location = New System.Drawing.Point(601, 395)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(20, 18)
        Me.lblMinutes.TabIndex = 12
        Me.lblMinutes.Text = "00"
        Me.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(627, 397)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = ":"
        '
        'lblSeconds
        '
        Me.lblSeconds.Location = New System.Drawing.Point(643, 395)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(20, 18)
        Me.lblSeconds.TabIndex = 14
        Me.lblSeconds.Text = "00"
        Me.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPercOverall
        '
        Me.lblPercOverall.AutoSize = True
        Me.lblPercOverall.BackColor = System.Drawing.Color.White
        Me.lblPercOverall.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercOverall.ForeColor = System.Drawing.Color.Black
        Me.lblPercOverall.Location = New System.Drawing.Point(348, 422)
        Me.lblPercOverall.Name = "lblPercOverall"
        Me.lblPercOverall.Size = New System.Drawing.Size(23, 13)
        Me.lblPercOverall.TabIndex = 15
        Me.lblPercOverall.Text = "0%"
        '
        'lblPercTask
        '
        Me.lblPercTask.AutoSize = True
        Me.lblPercTask.BackColor = System.Drawing.Color.White
        Me.lblPercTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercTask.ForeColor = System.Drawing.Color.Black
        Me.lblPercTask.Location = New System.Drawing.Point(348, 376)
        Me.lblPercTask.Name = "lblPercTask"
        Me.lblPercTask.Size = New System.Drawing.Size(23, 13)
        Me.lblPercTask.TabIndex = 16
        Me.lblPercTask.Text = "0%"
        '
        'MaserMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblPercTask)
        Me.Controls.Add(Me.lblPercOverall)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblMinutes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTaskStatus)
        Me.Controls.Add(Me.pgbOverall)
        Me.Controls.Add(Me.pgbTask)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.rtbConsole)
        Me.Controls.Add(Me.msMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.msMain
        Me.Name = "MaserMain"
        Me.Text = "Maser"
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rtbConsole As RichTextBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnPause As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents bgwQueue As System.ComponentModel.BackgroundWorker
    Friend WithEvents pgbTask As ProgressBar
    Friend WithEvents pgbOverall As ProgressBar
    Friend WithEvents lblTaskStatus As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tmrTask As Timer
    Friend WithEvents lblHours As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMinutes As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblSeconds As Label
    Friend WithEvents lblPercOverall As Label
    Friend WithEvents lblPercTask As Label
End Class
