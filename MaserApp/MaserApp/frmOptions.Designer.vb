﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txbSendDB = New System.Windows.Forms.TextBox()
        Me.ofdWorkDB = New System.Windows.Forms.OpenFileDialog()
        Me.fbdWorkDir = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnChooseSend = New System.Windows.Forms.Button()
        Me.lblUnzip = New System.Windows.Forms.Label()
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxAcegisFile = New System.Windows.Forms.TextBox()
        Me.tbxTaxa1332File = New System.Windows.Forms.TextBox()
        Me.tbxAcegisPwd = New System.Windows.Forms.TextBox()
        Me.tbxAcegisUser = New System.Windows.Forms.TextBox()
        Me.tbxAcegisFTP = New System.Windows.Forms.TextBox()
        Me.tbxTaxa1332Pwd = New System.Windows.Forms.TextBox()
        Me.tbxTaxa1332User = New System.Windows.Forms.TextBox()
        Me.tbxTaxa1332FTP = New System.Windows.Forms.TextBox()
        Me.lblMaserWorkDir = New System.Windows.Forms.Label()
        Me.btnChooseMaser = New System.Windows.Forms.Button()
        Me.txbWorkDir = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txbCODB = New System.Windows.Forms.TextBox()
        Me.btnChooseCODB = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txbWorkDB = New System.Windows.Forms.TextBox()
        Me.btnChooseWorkDB = New System.Windows.Forms.Button()
        Me.ofdCODB = New System.Windows.Forms.OpenFileDialog()
        Me.ofdSendDB = New System.Windows.Forms.OpenFileDialog()
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
        'ofdWorkDB
        '
        Me.ofdWorkDB.FileName = Global.MaserApp.My.MySettings.Default.WorkDB
        Me.ofdWorkDB.InitialDirectory = Global.MaserApp.My.MySettings.Default.WorkDB
        '
        'fbdWorkDir
        '
        Me.fbdWorkDir.SelectedPath = Global.MaserApp.My.MySettings.Default.WorkDir
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
        Me.lblUnzip.Location = New System.Drawing.Point(643, 245)
        Me.lblUnzip.Name = "lblUnzip"
        Me.lblUnzip.Size = New System.Drawing.Size(84, 13)
        Me.lblUnzip.TabIndex = 73
        Me.lblUnzip.Text = "Unzipped File"
        '
        'txbAcegisUnzip
        '
        Me.txbAcegisUnzip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "AcegisUnzipFile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbAcegisUnzip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbAcegisUnzip.Location = New System.Drawing.Point(646, 288)
        Me.txbAcegisUnzip.Name = "txbAcegisUnzip"
        Me.txbAcegisUnzip.Size = New System.Drawing.Size(116, 20)
        Me.txbAcegisUnzip.TabIndex = 72
        Me.txbAcegisUnzip.Text = Global.MaserApp.My.MySettings.Default.AcegisUnzipFile
        '
        'txbTaxa1332Unzip
        '
        Me.txbTaxa1332Unzip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "Taxa1332UnzipFile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbTaxa1332Unzip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbTaxa1332Unzip.Location = New System.Drawing.Point(646, 262)
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
        Me.cbZone.Location = New System.Drawing.Point(387, 363)
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
        Me.cbFTG.Location = New System.Drawing.Point(303, 363)
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
        Me.cbCPM.Location = New System.Drawing.Point(200, 363)
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
        Me.cbCD.Location = New System.Drawing.Point(104, 363)
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
        Me.cbMAC.Location = New System.Drawing.Point(635, 340)
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
        Me.cbPLA.Location = New System.Drawing.Point(558, 363)
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
        Me.cbZBA.Location = New System.Drawing.Point(558, 340)
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
        Me.cbBCO.Location = New System.Drawing.Point(446, 363)
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
        Me.cbSeptics.Location = New System.Drawing.Point(446, 340)
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
        Me.cbCO.Location = New System.Drawing.Point(387, 340)
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
        Me.cbModiv.Location = New System.Drawing.Point(303, 340)
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
        Me.cbAcegis.Location = New System.Drawing.Point(200, 340)
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
        Me.cbTaxa1332.Location = New System.Drawing.Point(104, 340)
        Me.cbTaxa1332.Name = "cbTaxa1332"
        Me.cbTaxa1332.Size = New System.Drawing.Size(70, 17)
        Me.cbTaxa1332.TabIndex = 58
        Me.cbTaxa1332.Text = "taxa1332"
        Me.cbTaxa1332.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(521, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(397, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "User"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(277, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "FTP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(150, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "FileName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(101, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Acegis"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Taxa1332"
        '
        'tbxAcegisFile
        '
        Me.tbxAcegisFile.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "AcegisFile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbxAcegisFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAcegisFile.Location = New System.Drawing.Point(153, 288)
        Me.tbxAcegisFile.Name = "tbxAcegisFile"
        Me.tbxAcegisFile.Size = New System.Drawing.Size(116, 20)
        Me.tbxAcegisFile.TabIndex = 51
        Me.tbxAcegisFile.Text = Global.MaserApp.My.MySettings.Default.AcegisFile
        '
        'tbxTaxa1332File
        '
        Me.tbxTaxa1332File.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "Taxa1332File", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbxTaxa1332File.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxTaxa1332File.Location = New System.Drawing.Point(153, 261)
        Me.tbxTaxa1332File.Name = "tbxTaxa1332File"
        Me.tbxTaxa1332File.Size = New System.Drawing.Size(116, 20)
        Me.tbxTaxa1332File.TabIndex = 50
        Me.tbxTaxa1332File.Text = Global.MaserApp.My.MySettings.Default.Taxa1332File
        '
        'tbxAcegisPwd
        '
        Me.tbxAcegisPwd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "AcegisPwd", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbxAcegisPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAcegisPwd.Location = New System.Drawing.Point(524, 288)
        Me.tbxAcegisPwd.Name = "tbxAcegisPwd"
        Me.tbxAcegisPwd.Size = New System.Drawing.Size(116, 20)
        Me.tbxAcegisPwd.TabIndex = 49
        Me.tbxAcegisPwd.Text = Global.MaserApp.My.MySettings.Default.AcegisPwd
        '
        'tbxAcegisUser
        '
        Me.tbxAcegisUser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "AcegisUser", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbxAcegisUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAcegisUser.Location = New System.Drawing.Point(400, 288)
        Me.tbxAcegisUser.Name = "tbxAcegisUser"
        Me.tbxAcegisUser.Size = New System.Drawing.Size(116, 20)
        Me.tbxAcegisUser.TabIndex = 48
        Me.tbxAcegisUser.Text = Global.MaserApp.My.MySettings.Default.AcegisUser
        '
        'tbxAcegisFTP
        '
        Me.tbxAcegisFTP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "AcegisFTP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbxAcegisFTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAcegisFTP.Location = New System.Drawing.Point(277, 288)
        Me.tbxAcegisFTP.Name = "tbxAcegisFTP"
        Me.tbxAcegisFTP.Size = New System.Drawing.Size(116, 20)
        Me.tbxAcegisFTP.TabIndex = 47
        Me.tbxAcegisFTP.Text = Global.MaserApp.My.MySettings.Default.AcegisFTP
        '
        'tbxTaxa1332Pwd
        '
        Me.tbxTaxa1332Pwd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "Taxa1332Pwd", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbxTaxa1332Pwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxTaxa1332Pwd.Location = New System.Drawing.Point(524, 262)
        Me.tbxTaxa1332Pwd.Name = "tbxTaxa1332Pwd"
        Me.tbxTaxa1332Pwd.Size = New System.Drawing.Size(116, 20)
        Me.tbxTaxa1332Pwd.TabIndex = 46
        Me.tbxTaxa1332Pwd.Text = Global.MaserApp.My.MySettings.Default.Taxa1332Pwd
        '
        'tbxTaxa1332User
        '
        Me.tbxTaxa1332User.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "Taxa1332User", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbxTaxa1332User.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxTaxa1332User.Location = New System.Drawing.Point(400, 262)
        Me.tbxTaxa1332User.Name = "tbxTaxa1332User"
        Me.tbxTaxa1332User.Size = New System.Drawing.Size(116, 20)
        Me.tbxTaxa1332User.TabIndex = 45
        Me.tbxTaxa1332User.Text = Global.MaserApp.My.MySettings.Default.Taxa1332User
        '
        'tbxTaxa1332FTP
        '
        Me.tbxTaxa1332FTP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "Taxa1332FTP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbxTaxa1332FTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxTaxa1332FTP.Location = New System.Drawing.Point(277, 262)
        Me.tbxTaxa1332FTP.Name = "tbxTaxa1332FTP"
        Me.tbxTaxa1332FTP.Size = New System.Drawing.Size(116, 20)
        Me.tbxTaxa1332FTP.TabIndex = 44
        Me.tbxTaxa1332FTP.Text = Global.MaserApp.My.MySettings.Default.Taxa1332FTP
        '
        'lblMaserWorkDir
        '
        Me.lblMaserWorkDir.AutoSize = True
        Me.lblMaserWorkDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaserWorkDir.Location = New System.Drawing.Point(55, 125)
        Me.lblMaserWorkDir.Name = "lblMaserWorkDir"
        Me.lblMaserWorkDir.Size = New System.Drawing.Size(92, 13)
        Me.lblMaserWorkDir.TabIndex = 43
        Me.lblMaserWorkDir.Text = "Work Directory"
        '
        'btnChooseMaser
        '
        Me.btnChooseMaser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseMaser.Location = New System.Drawing.Point(600, 120)
        Me.btnChooseMaser.Name = "btnChooseMaser"
        Me.btnChooseMaser.Size = New System.Drawing.Size(87, 23)
        Me.btnChooseMaser.TabIndex = 42
        Me.btnChooseMaser.Text = "Choose Dir"
        Me.btnChooseMaser.UseVisualStyleBackColor = True
        '
        'txbWorkDir
        '
        Me.txbWorkDir.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MaserApp.My.MySettings.Default, "WorkDir", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txbWorkDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbWorkDir.Location = New System.Drawing.Point(153, 122)
        Me.txbWorkDir.Name = "txbWorkDir"
        Me.txbWorkDir.Size = New System.Drawing.Size(418, 20)
        Me.txbWorkDir.TabIndex = 41
        Me.txbWorkDir.Text = Global.MaserApp.My.MySettings.Default.WorkDir
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
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 450)
        Me.ControlBox = False
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
End Class