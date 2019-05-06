<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnChooseSend = New System.Windows.Forms.Button()
        Me.lblUnzip = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMaserWorkDir = New System.Windows.Forms.Label()
        Me.btnChooseMaser = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnChooseCODB = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnChooseWorkDB = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnChoosePlanning = New System.Windows.Forms.Button()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblPwd = New System.Windows.Forms.Label()
        Me.txbUserName = New System.Windows.Forms.TextBox()
        Me.txbPassword = New System.Windows.Forms.TextBox()
        Me.cbCompactDB = New System.Windows.Forms.CheckBox()
        Me.cbSendToFTP = New System.Windows.Forms.CheckBox()
        Me.txbPlanningDB = New System.Windows.Forms.TextBox()
        Me.txbWorkDB = New System.Windows.Forms.TextBox()
        Me.txbCODB = New System.Windows.Forms.TextBox()
        Me.txbSendDB = New System.Windows.Forms.TextBox()
        Me.txbAcegisUnzip = New System.Windows.Forms.TextBox()
        Me.txbTaxa1332Unzip = New System.Windows.Forms.TextBox()
        Me.cbZone = New System.Windows.Forms.CheckBox()
        Me.cbFTG = New System.Windows.Forms.CheckBox()
        Me.cbCPM = New System.Windows.Forms.CheckBox()
        Me.cbCD = New System.Windows.Forms.CheckBox()
        Me.cbMAC = New System.Windows.Forms.CheckBox()
        Me.cbPLA = New System.Windows.Forms.CheckBox()
        Me.cbZBA = New System.Windows.Forms.CheckBox()
        Me.cbBCO = New System.Windows.Forms.CheckBox()
        Me.cbSeptics = New System.Windows.Forms.CheckBox()
        Me.cbCO = New System.Windows.Forms.CheckBox()
        Me.cbModiv = New System.Windows.Forms.CheckBox()
        Me.cbAcegis = New System.Windows.Forms.CheckBox()
        Me.cbTaxa1332 = New System.Windows.Forms.CheckBox()
        Me.tbxAcegisFile = New System.Windows.Forms.TextBox()
        Me.tbxTaxa1332File = New System.Windows.Forms.TextBox()
        Me.tbxAcegisPwd = New System.Windows.Forms.TextBox()
        Me.tbxAcegisUser = New System.Windows.Forms.TextBox()
        Me.tbxAcegisFTP = New System.Windows.Forms.TextBox()
        Me.tbxTaxa1332Pwd = New System.Windows.Forms.TextBox()
        Me.tbxTaxa1332User = New System.Windows.Forms.TextBox()
        Me.tbxTaxa1332FTP = New System.Windows.Forms.TextBox()
        Me.txbWorkDir = New System.Windows.Forms.TextBox()
        Me.ofdPlanningDB = New System.Windows.Forms.OpenFileDialog()
        Me.ofdWorkDB = New System.Windows.Forms.OpenFileDialog()
        Me.fbdWorkDir = New System.Windows.Forms.FolderBrowserDialog()
        Me.ofdCODB = New System.Windows.Forms.OpenFileDialog()
        Me.ofdSendDB = New System.Windows.Forms.OpenFileDialog()
        Me.lblLogFile = New System.Windows.Forms.Label()
        Me.btnChooseLog = New System.Windows.Forms.Button()
        Me.txbLogFile = New System.Windows.Forms.TextBox()
        Me.btnClearLog = New System.Windows.Forms.Button()
        Me.fbdLogFile = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(53, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Send Database"
        '
        'btnChooseSend
        '
        Me.btnChooseSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseSend.Location = New System.Drawing.Point(600, 94)
        Me.btnChooseSend.Name = "btnChooseSend"
        Me.btnChooseSend.Size = New System.Drawing.Size(87, 23)
        Me.btnChooseSend.TabIndex = 75
        Me.btnChooseSend.Text = "Choose DB"
        Me.btnChooseSend.UseVisualStyleBackColor = True
        '
        'lblUnzip
        '
        Me.lblUnzip.AutoSize = True
        Me.lblUnzip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnzip.Location = New System.Drawing.Point(643, 261)
        Me.lblUnzip.Name = "lblUnzip"
        Me.lblUnzip.Size = New System.Drawing.Size(84, 13)
        Me.lblUnzip.TabIndex = 73
        Me.lblUnzip.Text = "Unzipped File"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(521, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(397, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "User"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(277, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "FTP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(150, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "FileName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(101, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Acegis"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Taxa1332"
        '
        'lblMaserWorkDir
        '
        Me.lblMaserWorkDir.AutoSize = True
        Me.lblMaserWorkDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaserWorkDir.Location = New System.Drawing.Point(55, 151)
        Me.lblMaserWorkDir.Name = "lblMaserWorkDir"
        Me.lblMaserWorkDir.Size = New System.Drawing.Size(92, 13)
        Me.lblMaserWorkDir.TabIndex = 43
        Me.lblMaserWorkDir.Text = "Work Directory"
        '
        'btnChooseMaser
        '
        Me.btnChooseMaser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseMaser.Location = New System.Drawing.Point(600, 146)
        Me.btnChooseMaser.Name = "btnChooseMaser"
        Me.btnChooseMaser.Size = New System.Drawing.Size(87, 23)
        Me.btnChooseMaser.TabIndex = 42
        Me.btnChooseMaser.Text = "Choose Dir"
        Me.btnChooseMaser.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(834, 415)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(87, 23)
        Me.btnOK.TabIndex = 40
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(65, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "CO Database"
        '
        'btnChooseCODB
        '
        Me.btnChooseCODB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseCODB.Location = New System.Drawing.Point(600, 68)
        Me.btnChooseCODB.Name = "btnChooseCODB"
        Me.btnChooseCODB.Size = New System.Drawing.Size(87, 23)
        Me.btnChooseCODB.TabIndex = 78
        Me.btnChooseCODB.Text = "Choose DB"
        Me.btnChooseCODB.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(55, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Work Database"
        '
        'btnChooseWorkDB
        '
        Me.btnChooseWorkDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseWorkDB.Location = New System.Drawing.Point(600, 42)
        Me.btnChooseWorkDB.Name = "btnChooseWorkDB"
        Me.btnChooseWorkDB.Size = New System.Drawing.Size(87, 23)
        Me.btnChooseWorkDB.TabIndex = 81
        Me.btnChooseWorkDB.Text = "Choose DB"
        Me.btnChooseWorkDB.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 13)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "Planning Database"
        '
        'btnChoosePlanning
        '
        Me.btnChoosePlanning.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChoosePlanning.Location = New System.Drawing.Point(600, 120)
        Me.btnChoosePlanning.Name = "btnChoosePlanning"
        Me.btnChoosePlanning.Size = New System.Drawing.Size(87, 23)
        Me.btnChoosePlanning.TabIndex = 84
        Me.btnChoosePlanning.Text = "Choose DB"
        Me.btnChoosePlanning.UseVisualStyleBackColor = True
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(82, 214)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(65, 13)
        Me.lblUserName.TabIndex = 86
        Me.lblUserName.Text = "UserName"
        '
        'lblPwd
        '
        Me.lblPwd.AutoSize = True
        Me.lblPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPwd.Location = New System.Drawing.Point(87, 240)
        Me.lblPwd.Name = "lblPwd"
        Me.lblPwd.Size = New System.Drawing.Size(61, 13)
        Me.lblPwd.TabIndex = 87
        Me.lblPwd.Text = "Password"
        '
        'txbUserName
        '
        Me.txbUserName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "UserName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbUserName.Location = New System.Drawing.Point(153, 211)
        Me.txbUserName.Name = "txbUserName"
        Me.txbUserName.Size = New System.Drawing.Size(420, 20)
        Me.txbUserName.TabIndex = 88
        Me.txbUserName.Text = Global.MaserApp.My.MySettings.Default.UserName
        '
        'txbPassword
        '
        Me.txbPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "Password", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbPassword.Location = New System.Drawing.Point(153, 237)
        Me.txbPassword.Name = "txbPassword"
        Me.txbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbPassword.Size = New System.Drawing.Size(420, 20)
        Me.txbPassword.TabIndex = 89
        Me.txbPassword.Text = Global.MaserApp.My.MySettings.Default.Password
        '
        'cbCompactDB
        '
        Me.cbCompactDB.AutoSize = True
        Me.cbCompactDB.Checked = Global.MaserApp.My.MySettings.Default.CompactDB
        Me.cbCompactDB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCompactDB.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.MaserApp.My.MySettings.Default, "CompactDB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbCompactDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCompactDB.Location = New System.Drawing.Point(615, 419)
        Me.cbCompactDB.Name = "cbCompactDB"
        Me.cbCompactDB.Size = New System.Drawing.Size(103, 17)
        Me.cbCompactDB.TabIndex = 90
        Me.cbCompactDB.Text = "Compact DB?"
        Me.cbCompactDB.UseVisualStyleBackColor = True
        '
        'cbSendToFTP
        '
        Me.cbSendToFTP.AutoSize = True
        Me.cbSendToFTP.Checked = Global.MaserApp.My.MySettings.Default.SendToFTP
        Me.cbSendToFTP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSendToFTP.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.MaserApp.My.MySettings.Default, "SendToFTP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbSendToFTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSendToFTP.Location = New System.Drawing.Point(724, 419)
        Me.cbSendToFTP.Name = "cbSendToFTP"
        Me.cbSendToFTP.Size = New System.Drawing.Size(104, 17)
        Me.cbSendToFTP.TabIndex = 91
        Me.cbSendToFTP.Text = "Send to FTP?"
        Me.cbSendToFTP.UseVisualStyleBackColor = True
        '
        'txbPlanningDB
        '
        Me.txbPlanningDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "PlanningDB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbPlanningDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbPlanningDB.Location = New System.Drawing.Point(153, 122)
        Me.txbPlanningDB.Name = "txbPlanningDB"
        Me.txbPlanningDB.Size = New System.Drawing.Size(418, 20)
        Me.txbPlanningDB.TabIndex = 83
        Me.txbPlanningDB.Text = Global.MaserApp.My.MySettings.Default.PlanningDB
        '
        'txbWorkDB
        '
        Me.txbWorkDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "WorkDB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbWorkDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbWorkDB.Location = New System.Drawing.Point(153, 44)
        Me.txbWorkDB.Name = "txbWorkDB"
        Me.txbWorkDB.Size = New System.Drawing.Size(418, 20)
        Me.txbWorkDB.TabIndex = 80
        Me.txbWorkDB.Text = Global.MaserApp.My.MySettings.Default.WorkDB
        '
        'txbCODB
        '
        Me.txbCODB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "CONewDB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbCODB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbCODB.Location = New System.Drawing.Point(153, 70)
        Me.txbCODB.Name = "txbCODB"
        Me.txbCODB.Size = New System.Drawing.Size(418, 20)
        Me.txbCODB.TabIndex = 77
        Me.txbCODB.Text = Global.MaserApp.My.MySettings.Default.CONewDB
        '
        'txbSendDB
        '
        Me.txbSendDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "SendDB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbSendDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbSendDB.Location = New System.Drawing.Point(153, 96)
        Me.txbSendDB.Name = "txbSendDB"
        Me.txbSendDB.Size = New System.Drawing.Size(418, 20)
        Me.txbSendDB.TabIndex = 74
        Me.txbSendDB.Text = Global.MaserApp.My.MySettings.Default.SendDB
        '
        'txbAcegisUnzip
        '
        Me.txbAcegisUnzip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "AcegisUnzipFile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbAcegisUnzip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbAcegisUnzip.Location = New System.Drawing.Point(646, 304)
        Me.txbAcegisUnzip.Name = "txbAcegisUnzip"
        Me.txbAcegisUnzip.Size = New System.Drawing.Size(116, 20)
        Me.txbAcegisUnzip.TabIndex = 72
        Me.txbAcegisUnzip.Text = Global.MaserApp.My.MySettings.Default.AcegisUnzipFile
        '
        'txbTaxa1332Unzip
        '
        Me.txbTaxa1332Unzip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "Taxa1332UnzipFile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbTaxa1332Unzip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbTaxa1332Unzip.Location = New System.Drawing.Point(646, 278)
        Me.txbTaxa1332Unzip.Name = "txbTaxa1332Unzip"
        Me.txbTaxa1332Unzip.Size = New System.Drawing.Size(116, 20)
        Me.txbTaxa1332Unzip.TabIndex = 71
        Me.txbTaxa1332Unzip.Text = Global.MaserApp.My.MySettings.Default.Taxa1332UnzipFile
        '
        'cbZone
        '
        Me.cbZone.AutoSize = True
        Me.cbZone.Checked = Global.MaserApp.My.MySettings.Default.SecZone
        Me.cbZone.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbZone.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.MaserApp.My.MySettings.Default, "SecZone", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbZone.Location = New System.Drawing.Point(387, 379)
        Me.cbZone.Name = "cbZone"
        Me.cbZone.Size = New System.Drawing.Size(49, 17)
        Me.cbZone.TabIndex = 70
        Me.cbZone.Text = "zone"
        Me.cbZone.UseVisualStyleBackColor = True
        '
        'cbFTG
        '
        Me.cbFTG.AutoSize = True
        Me.cbFTG.Checked = Global.MaserApp.My.MySettings.Default.SecFTG
        Me.cbFTG.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.MaserApp.My.MySettings.Default, "SecFTG", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbFTG.ForeColor = System.Drawing.Color.DarkRed
        Me.cbFTG.Location = New System.Drawing.Point(303, 379)
        Me.cbFTG.Name = "cbFTG"
        Me.cbFTG.Size = New System.Drawing.Size(47, 17)
        Me.cbFTG.TabIndex = 69
        Me.cbFTG.Text = "FTG"
        Me.cbFTG.UseVisualStyleBackColor = True
        '
        'cbCPM
        '
        Me.cbCPM.AutoSize = True
        Me.cbCPM.Checked = Global.MaserApp.My.MySettings.Default.SecCPM
        Me.cbCPM.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCPM.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.MaserApp.My.MySettings.Default, "SecCPM", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbCPM.Location = New System.Drawing.Point(200, 379)
        Me.cbCPM.Name = "cbCPM"
        Me.cbCPM.Size = New System.Drawing.Size(49, 17)
        Me.cbCPM.TabIndex = 68
        Me.cbCPM.Text = "CPM"
        Me.cbCPM.UseVisualStyleBackColor = True
        '
        'cbCD
        '
        Me.cbCD.AutoSize = True
        Me.cbCD.Checked = Global.MaserApp.My.MySettings.Default.SecCD
        Me.cbCD.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCD.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.MaserApp.My.MySettings.Default, "SecCD", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbCD.Location = New System.Drawing.Point(104, 379)
        Me.cbCD.Name = "cbCD"
        Me.cbCD.Size = New System.Drawing.Size(41, 17)
        Me.cbCD.TabIndex = 67
        Me.cbCD.Text = "CD"
        Me.cbCD.UseVisualStyleBackColor = True
        '
        'cbMAC
        '
        Me.cbMAC.AutoSize = True
        Me.cbMAC.Checked = Global.MaserApp.My.MySettings.Default.SecMac
        Me.cbMAC.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.MaserApp.My.MySettings.Default, "SecMac", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbMAC.ForeColor = System.Drawing.Color.DarkRed
        Me.cbMAC.Location = New System.Drawing.Point(635, 356)
        Me.cbMAC.Name = "cbMAC"
        Me.cbMAC.Size = New System.Drawing.Size(49, 17)
        Me.cbMAC.TabIndex = 66
        Me.cbMAC.Text = "MAC"
        Me.cbMAC.UseVisualStyleBackColor = True
        '
        'cbPLA
        '
        Me.cbPLA.AutoSize = True
        Me.cbPLA.Checked = Global.MaserApp.My.MySettings.Default.SecPLA
        Me.cbPLA.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbPLA.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.MaserApp.My.MySettings.Default, "SecPLA", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbPLA.Location = New System.Drawing.Point(558, 379)
        Me.cbPLA.Name = "cbPLA"
        Me.cbPLA.Size = New System.Drawing.Size(46, 17)
        Me.cbPLA.TabIndex = 65
        Me.cbPLA.Text = "PLA"
        Me.cbPLA.UseVisualStyleBackColor = True
        '
        'cbZBA
        '
        Me.cbZBA.AutoSize = True
        Me.cbZBA.Checked = Global.MaserApp.My.MySettings.Default.SecZBA
        Me.cbZBA.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbZBA.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.MaserApp.My.MySettings.Default, "SecZBA", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbZBA.Location = New System.Drawing.Point(558, 356)
        Me.cbZBA.Name = "cbZBA"
        Me.cbZBA.Size = New System.Drawing.Size(47, 17)
        Me.cbZBA.TabIndex = 64
        Me.cbZBA.Text = "ZBA"
        Me.cbZBA.UseVisualStyleBackColor = True
        '
        'cbBCO
        '
        Me.cbBCO.AutoSize = True
        Me.cbBCO.Checked = Global.MaserApp.My.MySettings.Default.SecBCO
        Me.cbBCO.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbBCO.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.MaserApp.My.MySettings.Default, "SecBCO", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbBCO.Location = New System.Drawing.Point(446, 379)
        Me.cbBCO.Name = "cbBCO"
        Me.cbBCO.Size = New System.Drawing.Size(48, 17)
        Me.cbBCO.TabIndex = 63
        Me.cbBCO.Text = "BCO"
        Me.cbBCO.UseVisualStyleBackColor = True
        '
        'cbSeptics
        '
        Me.cbSeptics.AutoSize = True
        Me.cbSeptics.Checked = Global.MaserApp.My.MySettings.Default.SecSeptics
        Me.cbSeptics.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSeptics.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.MaserApp.My.MySettings.Default, "SecSeptics", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbSeptics.ForeColor = System.Drawing.Color.DarkRed
        Me.cbSeptics.Location = New System.Drawing.Point(446, 356)
        Me.cbSeptics.Name = "cbSeptics"
        Me.cbSeptics.Size = New System.Drawing.Size(59, 17)
        Me.cbSeptics.TabIndex = 62
        Me.cbSeptics.Text = "septics"
        Me.cbSeptics.UseVisualStyleBackColor = True
        '
        'cbCO
        '
        Me.cbCO.AutoSize = True
        Me.cbCO.Checked = Global.MaserApp.My.MySettings.Default.SecCo
        Me.cbCO.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.MaserApp.My.MySettings.Default, "SecCo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbCO.Location = New System.Drawing.Point(387, 356)
        Me.cbCO.Name = "cbCO"
        Me.cbCO.Size = New System.Drawing.Size(41, 17)
        Me.cbCO.TabIndex = 61
        Me.cbCO.Text = "CO"
        Me.cbCO.UseVisualStyleBackColor = True
        '
        'cbModiv
        '
        Me.cbModiv.AutoSize = True
        Me.cbModiv.Checked = Global.MaserApp.My.MySettings.Default.SecModiv
        Me.cbModiv.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbModiv.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.MaserApp.My.MySettings.Default, "SecModiv", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbModiv.Location = New System.Drawing.Point(303, 356)
        Me.cbModiv.Name = "cbModiv"
        Me.cbModiv.Size = New System.Drawing.Size(54, 17)
        Me.cbModiv.TabIndex = 60
        Me.cbModiv.Text = "modiv"
        Me.cbModiv.UseVisualStyleBackColor = True
        '
        'cbAcegis
        '
        Me.cbAcegis.AutoSize = True
        Me.cbAcegis.Checked = Global.MaserApp.My.MySettings.Default.SecAcegis
        Me.cbAcegis.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.MaserApp.My.MySettings.Default, "SecAcegis", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbAcegis.Location = New System.Drawing.Point(200, 356)
        Me.cbAcegis.Name = "cbAcegis"
        Me.cbAcegis.Size = New System.Drawing.Size(57, 17)
        Me.cbAcegis.TabIndex = 59
        Me.cbAcegis.Text = "acegis"
        Me.cbAcegis.UseVisualStyleBackColor = True
        '
        'cbTaxa1332
        '
        Me.cbTaxa1332.AutoSize = True
        Me.cbTaxa1332.Checked = Global.MaserApp.My.MySettings.Default.SecTaxa1332
        Me.cbTaxa1332.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.MaserApp.My.MySettings.Default, "SecTaxa1332", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbTaxa1332.Location = New System.Drawing.Point(104, 356)
        Me.cbTaxa1332.Name = "cbTaxa1332"
        Me.cbTaxa1332.Size = New System.Drawing.Size(70, 17)
        Me.cbTaxa1332.TabIndex = 58
        Me.cbTaxa1332.Text = "taxa1332"
        Me.cbTaxa1332.UseVisualStyleBackColor = True
        '
        'tbxAcegisFile
        '
        Me.tbxAcegisFile.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "AcegisFile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbxAcegisFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAcegisFile.Location = New System.Drawing.Point(153, 304)
        Me.tbxAcegisFile.Name = "tbxAcegisFile"
        Me.tbxAcegisFile.Size = New System.Drawing.Size(116, 20)
        Me.tbxAcegisFile.TabIndex = 51
        Me.tbxAcegisFile.Text = Global.MaserApp.My.MySettings.Default.AcegisFile
        '
        'tbxTaxa1332File
        '
        Me.tbxTaxa1332File.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "Taxa1332File", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbxTaxa1332File.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxTaxa1332File.Location = New System.Drawing.Point(153, 277)
        Me.tbxTaxa1332File.Name = "tbxTaxa1332File"
        Me.tbxTaxa1332File.Size = New System.Drawing.Size(116, 20)
        Me.tbxTaxa1332File.TabIndex = 50
        Me.tbxTaxa1332File.Text = Global.MaserApp.My.MySettings.Default.Taxa1332File
        '
        'tbxAcegisPwd
        '
        Me.tbxAcegisPwd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "AcegisPwd", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbxAcegisPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAcegisPwd.Location = New System.Drawing.Point(524, 304)
        Me.tbxAcegisPwd.Name = "tbxAcegisPwd"
        Me.tbxAcegisPwd.Size = New System.Drawing.Size(116, 20)
        Me.tbxAcegisPwd.TabIndex = 49
        Me.tbxAcegisPwd.Text = Global.MaserApp.My.MySettings.Default.AcegisPwd
        '
        'tbxAcegisUser
        '
        Me.tbxAcegisUser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "AcegisUser", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbxAcegisUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAcegisUser.Location = New System.Drawing.Point(400, 304)
        Me.tbxAcegisUser.Name = "tbxAcegisUser"
        Me.tbxAcegisUser.Size = New System.Drawing.Size(116, 20)
        Me.tbxAcegisUser.TabIndex = 48
        Me.tbxAcegisUser.Text = Global.MaserApp.My.MySettings.Default.AcegisUser
        '
        'tbxAcegisFTP
        '
        Me.tbxAcegisFTP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "AcegisFTP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbxAcegisFTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAcegisFTP.Location = New System.Drawing.Point(277, 304)
        Me.tbxAcegisFTP.Name = "tbxAcegisFTP"
        Me.tbxAcegisFTP.Size = New System.Drawing.Size(116, 20)
        Me.tbxAcegisFTP.TabIndex = 47
        Me.tbxAcegisFTP.Text = Global.MaserApp.My.MySettings.Default.AcegisFTP
        '
        'tbxTaxa1332Pwd
        '
        Me.tbxTaxa1332Pwd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "Taxa1332Pwd", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbxTaxa1332Pwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxTaxa1332Pwd.Location = New System.Drawing.Point(524, 278)
        Me.tbxTaxa1332Pwd.Name = "tbxTaxa1332Pwd"
        Me.tbxTaxa1332Pwd.Size = New System.Drawing.Size(116, 20)
        Me.tbxTaxa1332Pwd.TabIndex = 46
        Me.tbxTaxa1332Pwd.Text = Global.MaserApp.My.MySettings.Default.Taxa1332Pwd
        '
        'tbxTaxa1332User
        '
        Me.tbxTaxa1332User.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "Taxa1332User", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbxTaxa1332User.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxTaxa1332User.Location = New System.Drawing.Point(400, 278)
        Me.tbxTaxa1332User.Name = "tbxTaxa1332User"
        Me.tbxTaxa1332User.Size = New System.Drawing.Size(116, 20)
        Me.tbxTaxa1332User.TabIndex = 45
        Me.tbxTaxa1332User.Text = Global.MaserApp.My.MySettings.Default.Taxa1332User
        '
        'tbxTaxa1332FTP
        '
        Me.tbxTaxa1332FTP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "Taxa1332FTP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbxTaxa1332FTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxTaxa1332FTP.Location = New System.Drawing.Point(277, 278)
        Me.tbxTaxa1332FTP.Name = "tbxTaxa1332FTP"
        Me.tbxTaxa1332FTP.Size = New System.Drawing.Size(116, 20)
        Me.tbxTaxa1332FTP.TabIndex = 44
        Me.tbxTaxa1332FTP.Text = Global.MaserApp.My.MySettings.Default.Taxa1332FTP
        '
        'txbWorkDir
        '
        Me.txbWorkDir.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "WorkDir", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbWorkDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbWorkDir.Location = New System.Drawing.Point(153, 148)
        Me.txbWorkDir.Name = "txbWorkDir"
        Me.txbWorkDir.Size = New System.Drawing.Size(418, 20)
        Me.txbWorkDir.TabIndex = 41
        Me.txbWorkDir.Text = Global.MaserApp.My.MySettings.Default.WorkDir
        '
        'ofdPlanningDB
        '
        Me.ofdPlanningDB.FileName = Global.MaserApp.My.MySettings.Default.PlanningDB
        Me.ofdPlanningDB.InitialDirectory = Global.MaserApp.My.MySettings.Default.PlanningDB
        '
        'ofdWorkDB
        '
        Me.ofdWorkDB.FileName = Global.MaserApp.My.MySettings.Default.WorkDB
        Me.ofdWorkDB.InitialDirectory = Global.MaserApp.My.MySettings.Default.WorkDB
        '
        'fbdWorkDir
        '
        Me.fbdWorkDir.SelectedPath = Global.MaserApp.My.MySettings.Default.WorkDir
        '
        'ofdCODB
        '
        Me.ofdCODB.FileName = Global.MaserApp.My.MySettings.Default.CONewDB
        Me.ofdCODB.InitialDirectory = Global.MaserApp.My.MySettings.Default.CONewDB
        '
        'ofdSendDB
        '
        Me.ofdSendDB.FileName = Global.MaserApp.My.MySettings.Default.SendDB
        Me.ofdSendDB.InitialDirectory = Global.MaserApp.My.MySettings.Default.SendDB
        '
        'lblLogFile
        '
        Me.lblLogFile.AutoSize = True
        Me.lblLogFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogFile.Location = New System.Drawing.Point(93, 177)
        Me.lblLogFile.Name = "lblLogFile"
        Me.lblLogFile.Size = New System.Drawing.Size(52, 13)
        Me.lblLogFile.TabIndex = 94
        Me.lblLogFile.Text = "Log File"
        '
        'btnChooseLog
        '
        Me.btnChooseLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseLog.Location = New System.Drawing.Point(600, 172)
        Me.btnChooseLog.Name = "btnChooseLog"
        Me.btnChooseLog.Size = New System.Drawing.Size(87, 23)
        Me.btnChooseLog.TabIndex = 93
        Me.btnChooseLog.Text = "Choose Dir"
        Me.btnChooseLog.UseVisualStyleBackColor = True
        '
        'txbLogFile
        '
        Me.txbLogFile.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "LogPath", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbLogFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbLogFile.Location = New System.Drawing.Point(153, 174)
        Me.txbLogFile.Name = "txbLogFile"
        Me.txbLogFile.Size = New System.Drawing.Size(418, 20)
        Me.txbLogFile.TabIndex = 92
        Me.txbLogFile.Text = Global.MaserApp.My.MySettings.Default.LogPath
        '
        'btnClearLog
        '
        Me.btnClearLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearLog.Location = New System.Drawing.Point(693, 172)
        Me.btnClearLog.Name = "btnClearLog"
        Me.btnClearLog.Size = New System.Drawing.Size(87, 23)
        Me.btnClearLog.TabIndex = 95
        Me.btnClearLog.Text = "Clear Log"
        Me.btnClearLog.UseVisualStyleBackColor = True
        '
        'fbdLogFile
        '
        Me.fbdLogFile.SelectedPath = Global.MaserApp.My.MySettings.Default.LogPath
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClearLog)
        Me.Controls.Add(Me.lblLogFile)
        Me.Controls.Add(Me.btnChooseLog)
        Me.Controls.Add(Me.txbLogFile)
        Me.Controls.Add(Me.cbSendToFTP)
        Me.Controls.Add(Me.cbCompactDB)
        Me.Controls.Add(Me.txbPassword)
        Me.Controls.Add(Me.txbUserName)
        Me.Controls.Add(Me.lblPwd)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txbPlanningDB)
        Me.Controls.Add(Me.btnChoosePlanning)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txbWorkDB)
        Me.Controls.Add(Me.btnChooseWorkDB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txbCODB)
        Me.Controls.Add(Me.btnChooseCODB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txbSendDB)
        Me.Controls.Add(Me.btnChooseSend)
        Me.Controls.Add(Me.lblUnzip)
        Me.Controls.Add(Me.txbAcegisUnzip)
        Me.Controls.Add(Me.txbTaxa1332Unzip)
        Me.Controls.Add(Me.cbZone)
        Me.Controls.Add(Me.cbFTG)
        Me.Controls.Add(Me.cbCPM)
        Me.Controls.Add(Me.cbCD)
        Me.Controls.Add(Me.cbMAC)
        Me.Controls.Add(Me.cbPLA)
        Me.Controls.Add(Me.cbZBA)
        Me.Controls.Add(Me.cbBCO)
        Me.Controls.Add(Me.cbSeptics)
        Me.Controls.Add(Me.cbCO)
        Me.Controls.Add(Me.cbModiv)
        Me.Controls.Add(Me.cbAcegis)
        Me.Controls.Add(Me.cbTaxa1332)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbxAcegisFile)
        Me.Controls.Add(Me.tbxTaxa1332File)
        Me.Controls.Add(Me.tbxAcegisPwd)
        Me.Controls.Add(Me.tbxAcegisUser)
        Me.Controls.Add(Me.tbxAcegisFTP)
        Me.Controls.Add(Me.tbxTaxa1332Pwd)
        Me.Controls.Add(Me.tbxTaxa1332User)
        Me.Controls.Add(Me.tbxTaxa1332FTP)
        Me.Controls.Add(Me.lblMaserWorkDir)
        Me.Controls.Add(Me.btnChooseMaser)
        Me.Controls.Add(Me.txbWorkDir)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmOptions"
        Me.Text = "Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents txbSendDB As TextBox
    Friend WithEvents ofdWorkDB As OpenFileDialog
    Friend WithEvents fbdWorkDir As FolderBrowserDialog
    Friend WithEvents btnChooseSend As Button
    Friend WithEvents lblUnzip As Label
    Friend WithEvents txbAcegisUnzip As TextBox
    Friend WithEvents txbTaxa1332Unzip As TextBox
    Friend WithEvents cbZone As CheckBox
    Friend WithEvents cbFTG As CheckBox
    Friend WithEvents cbCPM As CheckBox
    Friend WithEvents cbCD As CheckBox
    Friend WithEvents cbMAC As CheckBox
    Friend WithEvents cbPLA As CheckBox
    Friend WithEvents cbZBA As CheckBox
    Friend WithEvents cbBCO As CheckBox
    Friend WithEvents cbSeptics As CheckBox
    Friend WithEvents cbCO As CheckBox
    Friend WithEvents cbModiv As CheckBox
    Friend WithEvents cbAcegis As CheckBox
    Friend WithEvents cbTaxa1332 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxAcegisFile As TextBox
    Friend WithEvents tbxTaxa1332File As TextBox
    Friend WithEvents tbxAcegisPwd As TextBox
    Friend WithEvents tbxAcegisUser As TextBox
    Friend WithEvents tbxAcegisFTP As TextBox
    Friend WithEvents tbxTaxa1332Pwd As TextBox
    Friend WithEvents tbxTaxa1332User As TextBox
    Friend WithEvents tbxTaxa1332FTP As TextBox
    Friend WithEvents lblMaserWorkDir As Label
    Friend WithEvents btnChooseMaser As Button
    Friend WithEvents txbWorkDir As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txbCODB As TextBox
    Friend WithEvents btnChooseCODB As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txbWorkDB As TextBox
    Friend WithEvents btnChooseWorkDB As Button
    Friend WithEvents ofdCODB As OpenFileDialog
    Friend WithEvents ofdSendDB As OpenFileDialog
    Friend WithEvents Label10 As Label
    Friend WithEvents txbPlanningDB As TextBox
    Friend WithEvents btnChoosePlanning As Button
    Friend WithEvents ofdPlanningDB As OpenFileDialog
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblPwd As Label
    Friend WithEvents txbUserName As TextBox
    Friend WithEvents txbPassword As TextBox
    Friend WithEvents cbCompactDB As CheckBox
    Friend WithEvents cbSendToFTP As CheckBox
    Friend WithEvents lblLogFile As Label
    Friend WithEvents btnChooseLog As Button
    Friend WithEvents txbLogFile As TextBox
    Friend WithEvents btnClearLog As Button
    Friend WithEvents fbdLogFile As FolderBrowserDialog
End Class
