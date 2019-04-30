Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports Microsoft.VisualBasic.FileIO

Public Class MaserMain
    Dim taxa1332 As New maserTask(False, False)
    Public Class ImportArguments
        Public _textfile As String
        Public _fieldarray As Array
        Public _table As String
    End Class

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub MaserMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        toggleGUI()
        bgwQueue.RunWorkerAsync()
    End Sub

    Public Sub BgwQueue_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwQueue.DoWork

        ' Run through the tasks
        e.Result = dataCollection()


    End Sub

    Public Sub bgwQueue_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgwQueue.ProgressChanged
        Dim consoleUpdate As String
        Dim taskUpdate As String
        Dim overPerc As Integer

        If e.UserState.ToString.Contains("|") Then
            Dim updateSplit As String() = e.UserState.ToString.Split(New Char() {"|"c})
            consoleUpdate = updateSplit(1)
            taskUpdate = updateSplit(0)
            If updateSplit.Length > 2 Then
                overPerc = updateSplit(2)
            Else
                overPerc = pgbOverall.Value
            End If
        Else
            consoleUpdate = ""
            taskUpdate = e.UserState.ToString
            overPerc = pgbOverall.Value
        End If

        pgbTask.Value = e.ProgressPercentage
        pgbOverall.Value = overPerc
        If consoleUpdate <> "" Then
            WriteLog(consoleUpdate)
        End If
        lblTaskStatus.Text = taskUpdate
    End Sub

    Public Sub bgwQueue_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwQueue.RunWorkerCompleted
        toggleGUI()

        If e.Result = 0 Then
            WriteLog("### Data Collection Completed Successfully ###")
            pgbOverall.Value = 100
        Else
            WriteLog("### Data Collection Failed ###")
            pgbOverall.ForeColor = Color.DarkRed
            pgbOverall.Value = 100
        End If
    End Sub
    Private Sub toggleGUI()

        ' Change the stae of GUI items based on condition
        If ExitToolStripMenuItem.Enabled = False Then
            ExitToolStripMenuItem.Enabled = True
        Else
            ExitToolStripMenuItem.Enabled = False
        End If
        If btnStart.Enabled = False Then
            btnStart.Enabled = True
            btnStart.Text = "Start"
            btnStart.BackColor = Color.DarkGreen
            btnStart.ForeColor = Color.White
            btnPause.Enabled = False
            btnCancel.Enabled = False
            btnPause.Visible = False
            btnCancel.Visible = False
        Else
            btnStart.Enabled = False
            btnStart.Text = "Running"
            btnStart.BackColor = Color.Green
            btnStart.ForeColor = Color.Gray
            btnPause.Enabled = True
            btnCancel.Enabled = True
            btnPause.Visible = True
            btnCancel.Visible = True
            pgbOverall.Value = 0
            pgbOverall.ForeColor = Color.Lime
            pgbTask.Value = 0
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        toggleGUI()
        bgwQueue.CancelAsync()
    End Sub
    Private Sub updateConsole(updateText As String)
        rtbConsole.AppendText("$ [" + DateTime.Now + "]: " + updateText + vbNewLine)
    End Sub
    Private Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
    Private Sub WriteLog(logentry As String)
        Dim logfilename As String = "maserlog.txt"
        Dim logpath As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\" + logfilename
        Dim logfile As IO.StreamWriter

        If Not (IO.File.Exists(logpath)) Then
            logfile = IO.File.CreateText(logpath)
        Else
            logfile = IO.File.AppendText(logpath)
        End If

        logfile.WriteLine(DateTime.Now + " :: " + logentry)
        logfile.Close()
        updateConsole(logentry)
    End Sub
    Private Function dataCollection() As Integer
        FormatProgressReport(0, "", "### Data Collection Started ###", 0)
        If (funTaxa1332() <> 0) Then
            Return 1
            Exit Function
        End If

        If (funAcegis() <> 0) Then
            Return 1
            Exit Function
        End If

        If (funModiv() <> 0) Then
            Return 1
            Exit Function
        End If

        If (funCo() <> 0) Then
            Return 1
            Exit Function
        End If

        If (funSeptics() <> 0) Then
            Return 1
            Exit Function
        End If

        If (funBco() <> 0) Then
            Return 1
            Exit Function
        End If

        If (funZba() <> 0) Then
            Return 1
            Exit Function
        End If

        If (funPla() <> 0) Then
            Return 1
            Exit Function
        End If

        If (funMac() <> 0) Then
            Return 1
            Exit Function
        End If

        If (funCd() <> 0) Then
            Return 1
            Exit Function
        End If

        If (funCpm() <> 0) Then
            Return 1
            Exit Function
        End If

        If (funFtg() <> 0) Then
            Return 1
            Exit Function
        End If

        If (funZone() <> 0) Then
            Return 1
            Exit Function
        End If

        Return 0
    End Function
    Private Function funTaxa1332() As Integer
        If My.Settings.SecTaxa1332 = False Then
            FormatProgressReport(0, "", "#Taxa1332 Skipped #")
            Return 0
            Exit Function
        End If

        FormatProgressReport(0, "", "# Taxa1332 Started #")

        wait(1)

        If (ftpDownloadwProg(My.Settings.Taxa1332FTP, My.Settings.Taxa1332File, My.Settings.Taxa1332User, My.Settings.Taxa1332Pwd, My.Settings.WorkDir) <> 0) Then
            FormatProgressReport(0, "", "# Taxa1332 Failed #")
            Return 1
            Exit Function
        End If

        If (UnZip(My.Settings.WorkDir, My.Settings.WorkDir + "\" + My.Settings.Taxa1332File, My.Settings.Taxa1332UnzipFile) <> 0) Then
            FormatProgressReport(0, "", "# Taxa1332 failed #")
            Return 1
            Exit Function
        End If

        FormatProgressReport(0, "", "# Taxa1332 Completed #", 8)
        Return 0
    End Function
    Private Function funAcegis() As Integer
        If My.Settings.SecAcegis = False Then
            FormatProgressReport(0, "", "# Acegis Skipped #")
            Return 0
            Exit Function
        End If
        FormatProgressReport(0, "", "# Acegis Started #")

        wait(1)

        If (ftpDownloadwProg(My.Settings.AcegisFTP, My.Settings.AcegisFile, My.Settings.AcegisUser, My.Settings.AcegisPwd, My.Settings.WorkDir) <> 0) Then
            FormatProgressReport(0, "", "# Acegis Failed #")
            Return 1
            Exit Function

        End If

        If (UnZip(My.Settings.WorkDir, My.Settings.WorkDir + "\" + My.Settings.AcegisFile, My.Settings.AcegisUnzipFile) <> 0) Then
            FormatProgressReport(0, "", "# Acegis Failed #")
            Return 1
            Exit Function
        End If

        If (DeleteFile(My.Settings.WorkDir + "\acegis.txt") <> 0) Then
            FormatProgressReport(0, "", "# Acegis Failed #")
            Return 1
            Exit Function
        End If

        If (MoveFile(My.Settings.WorkDir + "\" + My.Settings.AcegisUnzipFile, My.Settings.WorkDir + "\acegis.txt") <> 0) Then
            FormatProgressReport(0, "", "# Acegis Failed #")
            Return 1
            Exit Function
        End If

        FormatProgressReport(0, "", "# Acegis Completed #", 16)
        Return 0
    End Function
    Private Function funModiv() As Integer
        If My.Settings.SecModiv = False Then
            FormatProgressReport(0, "", "# Modiv Skipped #")
            Return 0
            Exit Function
        End If
        FormatProgressReport(0, "", "# Modiv Started #")

        wait(1)

        ' Delete Mod4 records (deleteModivRecords)
        If RunAccessQuery("DELETE FROM modivup;") <> 0 Then
            FormatProgressReport(0, "", "# Modiv Failed #")
            Return 1
            Exit Function
        End If

        ' Import acegis.txt
        Dim modivFields As String() = {"BLOCK", "LOT", "QUALIFIER", "NEWGISID", "GISKEY", "ACCOUNT", "PROP_CLASS", "PROP_LOCAT", "BUILD_DESC", "LAND_DESC", "ACREAGE", "ADDIT_LOTS", "ZONING", "TAX_MAP_PG", "LAND_VAL", "IMPROV_VAL", "NET_TAX_VAL", "OWNER", "OWNER_ADDR", "OWNER_CITY", "OWNER_STATE", "OWNER_ZIP", "MTG_ACCT", "PRIOR_YR_TX", "CURR_YR_TX", "DEED_BOOK", "DEED_PAGE", "DEED_DATE", "SALES_PRICE", "SENIOR_DED", "VETERAN_DED", "NUM_OWNERS", "DEDUC_AMT", "BILL_CODE", "NUM_DWELLING", "COMM_DWEL", "TAX_DEL_CO", "BUILD_CODE", "YEAR_BUILT", "ASSES_CODE", "SPEC_TX_CO", "EX_CODE1", "EX_AMT1", "EX_CODE2", "EX_AMT2", "EX_CODE3", "EX_AMT3", "EX_CODE4", "EX_AMT4", "UNSTRIPPED", "CENSUS_TRK", "CENSUS_BLK", "DED_WIDOWS", "DED_SURV_SPOUSE", "DED_DISABLED", "EPL_OWNER", "EPL_USE", "EPL_DESC", "EPL_FILE_DATE", "EPL_FURTHER_DATE", "EPL_STATUTE", "EPL_FNAME", "OLD_BLOCK", "OLD_LOT", "OLD_QUAL", "SALE_NU_CD", "TENANT_REB_FLAG", "TENANT_REB_YEAR", "TENANT_REB_TAX", "TENANT_REB_ASSMT", "NEIGHBORHOOD", "GIS_INDEX", "NEWGISID2"}

        If (ImportToAccess(modivFields, My.Settings.WorkDir + "\acegis.txt", "modivup")) Then
            FormatProgressReport(0, "", "# Modiv Failed #")
            Return 1
            Exit Function
        End If

        'Delete Null modiv records if they exist (deleteModivNull)
        If RunAccessQuery("DELETE modivup.BLOCK, modivup.LOT FROM modivup WHERE (((modivup.BLOCK) Is Null) AND ((modivup.LOT) Is Null));") <> 0 Then
            FormatProgressReport(0, "", "# Modiv Failed #")
            Return 1
            Exit Function
        End If

        ' Set zoning to Null (nullZoning)
        If RunAccessQuery("UPDATE modivup SET modivup.ZONING = Null;") <> 0 Then
            FormatProgressReport(0, "", "# Modiv Failed #")
            Return 1
            Exit Function
        End If

        ' Create WIP table with condos (insertModivQ)
        If RunAccessQuery("DROP TABLE mod4Q;") <> 0 Then
            FormatProgressReport(0, "", "# Modiv Failed #")
            Return 1
            Exit Function
        End If

        If RunAccessQuery("SELECT '32'+'_'+[BLOCK]+'_'+[LOT]+'_'+[QUALIFIER] AS Pin, modivup.BLOCK, modivup.LOT, modivup.QUALIFIER, modivup.NEWGISID, modivup.GISKEY, modivup.ACCOUNT, modivup.PROP_CLASS, modivup.PROP_LOCAT, modivup.BUILD_DESC, modivup.LAND_DESC, modivup.ACREAGE, modivup.ADDIT_LOTS, modivup.ZONING, modivup.TAX_MAP_PG, modivup.LAND_VAL, modivup.IMPROV_VAL, modivup.NET_TAX_VAL, modivup.OWNER, modivup.OWNER_ADDR, modivup.OWNER_CITY, modivup.OWNER_STATE, modivup.OWNER_ZIP, modivup.MTG_ACCT, modivup.PRIOR_YR_TX, modivup.CURR_YR_TX, modivup.DEED_BOOK, modivup.DEED_PAGE, modivup.DEED_DATE, modivup.SALES_PRICE, modivup.SENIOR_DED, modivup.VETERAN_DED, modivup.NUM_OWNERS, modivup.DEDUC_AMT, modivup.BILL_CODE, modivup.NUM_DWELLING, modivup.COMM_DWEL, modivup.TAX_DEL_CO, modivup.BUILD_CODE, modivup.YEAR_BUILT, modivup.ASSES_CODE, modivup.SPEC_TX_CO, modivup.EX_CODE1, modivup.EX_AMT1, modivup.EX_CODE2, modivup.EX_AMT2, modivup.EX_CODE3, modivup.EX_AMT3, modivup.EX_CODE4, modivup.EX_AMT4, modivup.UNSTRIPPED, modivup.CENSUS_TRK, modivup.CENSUS_BLK, modivup.DED_SURV_SPOUSE, modivup.DED_DISABLED, modivup.EPL_OWNER, modivup.EPL_USE, modivup.EPL_DESC, modivup.EPL_FILE_DATE, modivup.EPL_FURTHER_DATE, modivup.EPL_STATUTE, modivup.EPL_FNAME, modivup.OLD_BLOCK, modivup.OLD_LOT, modivup.OLD_QUAL, modivup.SALE_NU_CD, modivup.TENANT_REB_FLAG, modivup.TENANT_REB_YEAR, modivup.TENANT_REB_TAX, modivup.TENANT_REB_ASSMT, modivup.NEIGHBORHOOD, modivup.GIS_INDEX, modivup.NEWGISID2 INTO mod4Q FROM modivup WHERE (((modivup.QUALIFIER) Like 'C*' Or (modivup.QUALIFIER) Like 'c*'));") <> 0 Then
            FormatProgressReport(0, "", "# Modiv Failed #")
            Return 1
            Exit Function
        End If

        ' Delete condo records from mod4 (DeleteMod4Q)
        If RunAccessQuery("DELETE modivup.QUALIFIER FROM modivup WHERE (((modivup.QUALIFIER) Like 'c*'));") <> 0 Then
            FormatProgressReport(0, "", "# Modiv Failed #")
            Return 1
            Exit Function
        End If

        ' Create Maser table (modivquery)
        If RunAccessQuery("DROP TABLE mod4;") <> 0 Then
            FormatProgressReport(0, "", "# Modiv Failed #")
            Return 1
            Exit Function
        End If

        If RunAccessQuery("SELECT '32'+'_'+[BLOCK]+'_'+[LOT] AS Pin, modivup.BLOCK, modivup.LOT, modivup.QUALIFIER, modivup.NEWGISID, modivup.GISKEY, modivup.ACCOUNT, modivup.PROP_CLASS, modivup.PROP_LOCAT, modivup.BUILD_DESC, modivup.LAND_DESC, modivup.ACREAGE, modivup.ADDIT_LOTS, modivup.ZONING, modivup.TAX_MAP_PG, modivup.LAND_VAL, modivup.IMPROV_VAL, modivup.NET_TAX_VAL, modivup.OWNER, modivup.OWNER_ADDR, modivup.OWNER_CITY, modivup.OWNER_STATE, modivup.OWNER_ZIP, modivup.MTG_ACCT, modivup.PRIOR_YR_TX, modivup.CURR_YR_TX, modivup.DEED_BOOK, modivup.DEED_PAGE, modivup.DEED_DATE, modivup.SALES_PRICE, modivup.SENIOR_DED, modivup.VETERAN_DED, modivup.NUM_OWNERS, modivup.DEDUC_AMT, modivup.BILL_CODE, modivup.NUM_DWELLING, modivup.COMM_DWEL, modivup.TAX_DEL_CO, modivup.BUILD_CODE, modivup.YEAR_BUILT, modivup.ASSES_CODE, modivup.SPEC_TX_CO, modivup.EX_CODE1, modivup.EX_AMT1, modivup.EX_CODE2, modivup.EX_AMT2, modivup.EX_CODE3, modivup.EX_AMT3, modivup.EX_CODE4, modivup.EX_AMT4, modivup.UNSTRIPPED, modivup.CENSUS_TRK, modivup.CENSUS_BLK, modivup.DED_WIDOWS, modivup.DED_SURV_SPOUSE, modivup.DED_DISABLED, modivup.EPL_OWNER, modivup.EPL_USE, modivup.EPL_DESC, modivup.EPL_FILE_DATE, modivup.EPL_FURTHER_DATE, modivup.EPL_STATUTE, modivup.EPL_FNAME, modivup.OLD_BLOCK, modivup.OLD_LOT, modivup.OLD_QUAL, modivup.SALE_NU_CD, modivup.TENANT_REB_FLAG, modivup.TENANT_REB_YEAR, modivup.TENANT_REB_TAX, modivup.TENANT_REB_ASSMT, modivup.NEIGHBORHOOD, modivup.GIS_INDEX, modivup.NEWGISID2 INTO mod4 FROM modivup;") <> 0 Then
            FormatProgressReport(0, "", "# Modiv Failed #")
            Return 1
            Exit Function
        End If

        ' Append condo data to maser mod4 (AppendMod4)
        If RunAccessQuery("INSERT INTO mod4 SELECT mod4Q.* FROM mod4Q;") <> 0 Then
            FormatProgressReport(0, "", "# Modiv Failed #")
            Return 1
            Exit Function
        End If

        ' Make Qfarm records (MakeQfarm)
        If RunAccessQuery("DROP TABLE MOD4QFARM;") <> 0 Then
            FormatProgressReport(0, "", "# Modiv Failed #")
            Return 1
            Exit Function
        End If

        If RunAccessQuery("SELECT '32_'+[modivup].[BLOCK]+'_'+[LOT]+'_'+[QUALIFIER] AS Pin, modivup.BLOCK, modivup.LOT, modivup.QUALIFIER, modivup.NEWGISID, modivup.TAX_MAP_PG, modivup.GISKEY, modivup.ACCOUNT, modivup.PROP_CLASS, modivup.PROP_LOCAT, modivup.BUILD_DESC, modivup.LAND_DESC, modivup.ACREAGE, modivup.ADDIT_LOTS, modivup.ZONING, modivup.LAND_VAL, modivup.IMPROV_VAL, modivup.NET_TAX_VAL, modivup.OWNER, modivup.OWNER_ADDR, modivup.OWNER_CITY, modivup.OWNER_STATE, modivup.OWNER_ZIP, modivup.MTG_ACCT INTO MOD4QFARM FROM modivup WHERE (((modivup.QUALIFIER)='QFARM'));") <> 0 Then
            FormatProgressReport(0, "", "# Modiv Failed #")
            Return 1
            Exit Function
        End If

        ' Delete QFARM records from MOD4 (DeleteMod4QFARM)
        If RunAccessQuery("DELETE mod4.QUALIFIER FROM mod4 WHERE (((mod4.QUALIFIER) Like 'Q*'));") <> 0 Then
            FormatProgressReport(0, "", "# Modiv Failed #")
            Return 1
            Exit Function
        End If

        ' Append FARMQ to MOD4 (AppendMod4QFARM)
        If RunAccessQuery("INSERT INTO mod4 SELECT MOD4QFARM.* FROM MOD4QFARM;") <> 0 Then
            FormatProgressReport(0, "", "# Modiv Failed #")
            Return 1
            Exit Function
        End If

        ' Export mod4

        ' Export mod4qfarm


        FormatProgressReport(0, "", "# Modiv Completed #", 24)
        Return 0
    End Function

    Private Function funCo() As Integer
        If My.Settings.SecCo = False Then
            FormatProgressReport(0, "", "# CO Skipped #")
            Return 0
            Exit Function
        End If
        FormatProgressReport(0, "", "# CO Started #")

        wait(1)

        ' Delete comain records
        If RunAccessQuery("DROP TABLE CO_Main;") <> 0 Then
            FormatProgressReport(0, "", "# Modiv Failed #")
            Return 1
            Exit Function
        End If

        ' Import production comain

        ' Delete Null records (deleteCONull)

        ' Run CO query (coquery)

        ' Export

        FormatProgressReport(0, "", "# CO Completed #", 32)
        Return 0
    End Function

    Private Function funSeptics() As Integer
        If My.Settings.SecSeptics = False Then
            FormatProgressReport(0, "", "# Septics Skipped #")
            Return 0
            Exit Function
        End If
        FormatProgressReport(0, "", "# Septics Started #")

        wait(1)

        FormatProgressReport(0, "", "# Septics Completed #", 40)
        Return 0
    End Function

    Private Function funBco() As Integer
        If My.Settings.SecBCO = False Then
            FormatProgressReport(0, "", "# BCO Skipped #")
            Return 0
            Exit Function
        End If
        FormatProgressReport(0, "", "# BCO Started #")

        wait(1)

        FormatProgressReport(0, "", "# BCO Started #", 48)
        Return 0
    End Function

    Private Function funZba() As Integer
        If My.Settings.SecZBA = False Then
            FormatProgressReport(0, "", "# ZBA Skipped #")
            Return 0
            Exit Function
        End If
        FormatProgressReport(0, "", "# ZBA started #")

        wait(1)

        FormatProgressReport(0, "", "# ZBA Completed #", 56)
        Return 0
    End Function

    Private Function funPla() As Integer
        If My.Settings.SecPLA = False Then
            FormatProgressReport(0, "", "# PLA Skipped #")
            Return 0
            Exit Function
        End If
        FormatProgressReport(0, "", "# PLA Started #")

        wait(1)

        FormatProgressReport(0, "", "# PLA Completed #", 64)
        Return 0
    End Function

    Private Function funMac() As Integer
        If My.Settings.SecMac = False Then
            FormatProgressReport(0, "", "# MAC Skipped #")
            Return 0
            Exit Function
        End If
        FormatProgressReport(0, "", "# MAC Started #")

        wait(1)

        FormatProgressReport(0, "", "# MAC Completed #", 72)
        Return 0
    End Function

    Private Function funCd() As Integer
        If My.Settings.SecCD = False Then
            FormatProgressReport(0, "", "# CD Skipped #")
            Return 0
            Exit Function
        End If
        FormatProgressReport(0, "", "# CD Started #")

        wait(1)

        FormatProgressReport(0, "", "# CD Completed #", 80)
        Return 0
    End Function

    Private Function funCpm() As Integer
        If My.Settings.SecCPM = False Then
            FormatProgressReport(0, "", "# CPM Skipped #")
            Return 0
            Exit Function
        End If
        FormatProgressReport(0, "", "# CPM Started #")

        wait(1)

        FormatProgressReport(0, "", "# CPM Completed #", 88)
        Return 0
    End Function

    Private Function funFtg() As Integer
        If My.Settings.SecFTG = False Then
            FormatProgressReport(0, "", "# FTG Skipped #")
            Return 0
            Exit Function
        End If
        FormatProgressReport(0, "", "# FTG Started #")

        wait(1)

        FormatProgressReport(0, "", "# FTG Completed #", 96)
        Return 0
    End Function

    Private Function funZone() As Integer
        If My.Settings.SecZone = False Then
            FormatProgressReport(0, "", "# Zone Skipped #")
            Return 0
            Exit Function
        End If
        FormatProgressReport(0, "", "# Zone Started #")

        wait(1)

        FormatProgressReport(0, "", "# Zone Completed #", 100)
        Return 0
    End Function
    Private Function RunAccessQuery(sqlCmd As String) As Integer
        ' Set up connection string to Access database based on saved options
        Dim Connection As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + My.Settings.WorkDB)
        Dim Command As New System.Data.OleDb.OleDbCommand()
        Dim intRC As Integer

        FormatProgressReport(0, "", "Starting Query {" + sqlCmd + "}")
        ' Connect to the database and run the query
        Try
            Command.CommandType = System.Data.CommandType.Text
            Command.CommandText = sqlCmd
            Command.Connection = Connection

            Connection.Open()
            intRC = Command.ExecuteNonQuery()
            Connection.Close()
        Catch ex As Exception
            FormatProgressReport(0, "", ex.Message)
            FormatProgressReport(0, "", "Query Failed")
            Return 1
            Exit Function
        End Try

        FormatProgressReport(0, "", "Query Successful")
        Return 0
    End Function
    Private Function ftpDownloadwProg(ftpserver As String, ftpfile As String, ftpuser As String, ftppwd As String, downdir As String) As Integer
        Dim buffer(1023) As Byte
        Dim bytesIn As Integer
        Dim TotalBytesIn As Integer
        Dim output As IO.Stream
        Dim filelength As Integer
        Dim filePath As String = "ftp://" & ftpserver & "/" & ftpfile

        FormatProgressReport(0, ftpfile + " Download", "Started download of " + ftpfile)

        Try
            Dim FTPRequest As FtpWebRequest = DirectCast(WebRequest.Create(filePath), FtpWebRequest)
            FTPRequest.Credentials = New NetworkCredential(ftpuser, ftppwd)
            FTPRequest.Method = Net.WebRequestMethods.Ftp.GetFileSize
            filelength = CInt(FTPRequest.GetResponse.ContentLength)

        Catch ex As Exception

            FormatProgressReport(0, "", "Unable to get file size")
        End Try

        Try
            Dim FTPRequest As FtpWebRequest = DirectCast(WebRequest.Create(filePath), FtpWebRequest)
            FTPRequest.Credentials = New NetworkCredential(ftpuser, ftppwd)
            FTPRequest.Method = WebRequestMethods.Ftp.DownloadFile
            Dim stream As System.IO.Stream = FTPRequest.GetResponse.GetResponseStream
            Dim OutputFilePath As String = downdir & "\" & IO.Path.GetFileName(ftpfile)
            output = System.IO.File.Create(OutputFilePath)
            bytesIn = 1

            Do Until bytesIn < 1
                bytesIn = stream.Read(buffer, 0, 1024)
                If bytesIn > 0 Then
                    output.Write(buffer, 0, bytesIn)
                    TotalBytesIn += bytesIn
                    If filelength > 0 Then
                        Dim perc As Integer = (TotalBytesIn / filelength) * 100
                        FormatProgressReport(perc, ftpfile + " Download", "")
                    End If
                End If
            Loop
            output.Close()
            stream.Close()
        Catch ex As Exception
            FormatProgressReport(100, ftpfile + " Download", "Download of " + ftpfile + " failed.")
            FormatProgressReport(100, "", ex.Message)
            Return 1

            Exit Function
        End Try

        FormatProgressReport(100, ftpfile + " Download", ftpfile + " downloaded successfully")

        wait(1)
        Return 0

    End Function

    Private Function UnZip(outputFolder As String, inputZip As String, unzipFile As String) As Integer

        If System.IO.File.Exists(outputFolder + "\" + unzipFile) = True Then
            System.IO.File.Delete(outputFolder + "\" + unzipFile)
            FormatProgressReport(0, "", unzipFile + " file deleted")

        End If

        Try
            Dim shObj As Object = Activator.CreateInstance(Type.GetTypeFromProgID("Shell.Application"))

            Dim output As Object = shObj.NameSpace((outputFolder))
            Dim input As Object = shObj.NameSpace((inputZip))

            output.CopyHere((input.Items), 4)
        Catch ex As Exception
            FormatProgressReport(0, "", ex.Message)
            FormatProgressReport(0, "", "Unzip of " + inputZip + " failed.")


            Return 1

            Exit Function
        End Try

        If System.IO.File.Exists(inputZip) = True Then
            System.IO.File.Delete(inputZip)
            FormatProgressReport(0, "", inputZip + " deleted")

        End If

        FormatProgressReport(0, "", inputZip + " unzipped successfully")
        wait(1)
        Return 0

    End Function
    Private Function DeleteFile(filePath As String) As Integer
        If System.IO.File.Exists(filePath) = True Then
            Try
                System.IO.File.Delete(filePath)
            Catch ex As Exception
                FormatProgressReport(0, "", ex.Message)
                FormatProgressReport(0, "", filePath + " was not deleted")

                Return 1
                Exit Function
            End Try


        End If

        FormatProgressReport(0, "", filePath + " file deleted")

        Return 0
    End Function

    Private Function MoveFile(fromPath As String, toPath As String) As Integer
        Try
            System.IO.File.Move(fromPath, toPath)
        Catch ex As Exception
            FormatProgressReport(0, "", ex.Message)
            FormatProgressReport(0, "", "Unable to move/rename file from " + fromPath + " to " + toPath)
            Return 1
            Exit Function
        End Try

        FormatProgressReport(0, "", fromPath + " moved/renamed to " + toPath)
        Return 0
    End Function
    Private Function ImportToAccess(fieldArray As Array, textFile As String, table As String) As Integer


        Dim csvTextParser As TextFieldParser = FileSystem.OpenTextFieldParser(textFile)
        Dim valueText As String = ""
        csvTextParser.TextFieldType = FieldType.Delimited
        csvTextParser.Delimiters = New String() {ControlChars.Tab}
        Dim linecount = File.ReadAllLines(textFile).Length


        For Each field In fieldArray
            valueText += field + ","
        Next
        valueText = valueText.Trim().Remove(valueText.Length - 1)
        Dim preText As String = "INSERT INTO " + table + " (" + valueText + ") VALUES ("""
        Dim cmdText As String = ""

        FormatProgressReport(0, textFile + " Import", "Importing " + textFile + " to " + My.Settings.WorkDB + " " + table + " table")

        Try

            Dim Connection As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + My.Settings.WorkDB)
            Dim Command As New System.Data.OleDb.OleDbCommand()
            Dim intRC As Integer

            Command.CommandType = System.Data.CommandType.Text

            Command.Connection = Connection

            Dim currentLineValues() As String

            Connection.Open()
            Dim x As Integer = 0
            Do While Not csvTextParser.EndOfData
                x += 1
                cmdText = preText
                currentLineValues = csvTextParser.ReadFields
                Dim perc As Integer = x / linecount * 100
                FormatProgressReport(perc, textFile + " Import", "")

                For i = 0 To fieldArray.Length - 1
                    cmdText += currentLineValues(i).Replace("""", """""") + ""","""
                Next
                cmdText = cmdText.Trim().Remove(cmdText.Length - 2)
                cmdText += ")"

                Command.CommandText = cmdText
                intRC = Command.ExecuteNonQuery()

            Loop

            Connection.Close()
            csvTextParser.Close()

        Catch ex As Exception
            FormatProgressReport(100, "", ex.Message)
            FormatProgressReport(100, "", "Import of " + textFile + " Failed")
            Return 1
            Exit Function
        End Try

        FormatProgressReport(100, "", "Import of " + textFile + " Successful")
        Return 0
    End Function
    Private Sub FormatProgressReport(taskPerc As Integer, taskStatus As String, consoleStatus As String, Optional overPerc As Integer = vbNull)
        If overPerc = vbNull Then
            Dim fullStatus As String = taskStatus + "|" + consoleStatus
            bgwQueue.ReportProgress(taskPerc, fullStatus)
        Else
            Dim fullStatus As String = taskStatus + "|" + consoleStatus + "|" + overPerc.ToString
            bgwQueue.ReportProgress(taskPerc, fullStatus)
        End If
    End Sub
End Class
