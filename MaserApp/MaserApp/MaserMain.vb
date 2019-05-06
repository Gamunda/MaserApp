Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports Microsoft.VisualBasic.FileIO

Public Class MaserMain
    Dim taxa1332 As New maserTask(False, False)
    Dim percMultiplier As Integer = 6
    Dim timercount As Integer = 0
    Public Class ImportArguments
        Public _textfile As String
        Public _fieldarray As Array
        Public _table As String
    End Class

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
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
        If pgbOverall.Value = 0 Then
            tmrTask.Enabled = True
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
        tmrTask.Enabled = False
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
    Public Sub WriteLog(logentry As String)
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

        If (compactDatabase() <> 0) Then
            Return 1
            Exit Function
        End If

        If (sendToFtp() <> 0) Then
            Return 1
            Exit Function
        End If

        Return 0
    End Function
    Private Function funTaxa1332() As Integer
        If My.Settings.SecTaxa1332 = False Then
            FormatProgressReport(0, "", "#Taxa1332 Skipped #", 1 * percMultiplier)
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

        FormatProgressReport(0, "", "# Taxa1332 Completed #", 1 * percMultiplier)
        Return 0
    End Function
    Private Function funAcegis() As Integer
        If My.Settings.SecAcegis = False Then
            FormatProgressReport(0, "", "# Acegis Skipped #", 2 * percMultiplier)
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

        FormatProgressReport(0, "", "# Acegis Completed #", 2 * percMultiplier)
        Return 0
    End Function
    Private Function funModiv() As Integer
        If My.Settings.SecModiv = False Then
            FormatProgressReport(0, "", "# Modiv Skipped #", 3 * percMultiplier)
            Return 0
            Exit Function
        End If
        FormatProgressReport(0, "", "# Modiv Started #")

        wait(1)

        ' File Copies
        If CopyFile(My.Settings.WorkDir + "\acegis.txt", "\\appserver3\mitchellhumphrey\taxconvert\acegis.txt") <> 0 Then
            FormatProgressReport(0, "", "!! Warning Encountered !!")

        End If
        If CopyFile(My.Settings.WorkDir + "\acegis.txt", "\\mtcrm2016main\E$\FTGPropImport\NewUploads\acegis.txt") <> 0 Then
            FormatProgressReport(0, "", "!! Warning Encountered !!")

        End If
        If CopyFile(My.Settings.WorkDir + "\acegis.txt", "\\mtfinance2\programs\mcsj\importfiles\acegis.txt") <> 0 Then
            FormatProgressReport(0, "", "!! Warning Encountered !!")

        End If
        If CopyFile(My.Settings.WorkDir + "\acegis.txt", "\\mtfinance2\programs\mcsj\importfiles\taxa1332.dat") <> 0 Then
            FormatProgressReport(0, "", "!! Warning Encountered !!")

        End If

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
        Dim mod4Fields(,) As String =
            {{"Pin", "Text", "255"},
            {"BLOCK", "Text", "255"},
            {"LOT", "Text", "255"},
            {"QUALIFIER", "Text", "255"},
            {"NEWGISID", "Text", "255"},
            {"GISKEY", "Text", "255"},
            {"ACCOUNT", "Text", "255"},
            {"PROP_CLASS", "Text", "255"},
            {"PROP_LOCAT", "Text", "255"},
            {"BUILD_DESC", "Text", "255"},
            {"LAND_DESC", "Text", "255"},
            {"ACREAGE", "Text", "255"},
            {"ADDIT_LOTS", "Text", "255"},
            {"ZONING", "Text", "255"},
            {"TAX_MAP_PG", "Text", "255"},
            {"LAND_VAL", "Text", "255"},
            {"IMPROV_VAL", "Text", "255"},
            {"NET_TAX_VAL", "Text", "255"},
            {"OWNER", "Text", "255"},
            {"OWNER_ADDR", "Text", "255"},
            {"OWNER_CITY", "Text", "255"},
            {"OWNER_STATE", "Text", "255"},
            {"OWNER_ZIP", "Text", "255"},
            {"MTG_ACCT", "Text", "255"},
            {"PRIOR_YR_TX", "Text", "255"},
            {"CURR_YR_TX", "Text", "255"},
            {"DEED_BOOK", "Text", "255"},
            {"DEED_PAGE", "Text", "255"},
            {"DEED_DATE", "Text", "255"},
            {"SALES_PRICE", "Text", "255"},
            {"SENIOR_DED", "Text", "255"},
            {"VETERAN_DED", "Text", "255"},
            {"NUM_OWNERS", "Text", "255"},
            {"DEDUC_AMT", "Text", "255"},
            {"BILL_CODE", "Text", "255"},
            {"NUM_DWELLING", "Text", "255"},
            {"COMM_DWEL", "Text", "255"},
            {"TAX_DEL_CO", "Text", "255"},
            {"BUILD_CODE", "Text", "255"},
            {"YEAR_BUILT", "Text", "255"},
            {"ASSES_CODE", "Text", "255"},
            {"SPEC_TX_CO", "Text", "255"},
            {"EX_CODE1", "Text", "255"},
            {"EX_AMT1", "Text", "255"},
            {"EX_CODE2", "Text", "255"},
            {"EX_AMT2", "Text", "255"},
            {"EX_CODE3", "Text", "255"},
            {"EX_AMT3", "Text", "255"},
            {"EX_CODE4", "Text", "255"},
            {"EX_AMT4", "Text", "255"},
            {"UNSTRIPPED", "Text", "255"},
            {"CENSUS_TRK", "Text", "255"},
            {"CENSUS_BLK", "Text", "255"},
            {"DED_WIDOWS", "Text", "255"},
            {"DED_SURV_SPOUSE", "Text", "255"},
            {"DED_DISABLED", "Text", "255"},
            {"EPL_OWNER", "Text", "255"},
            {"EPL_USE", "Text", "255"},
            {"EPL_DESC", "Text", "255"},
            {"EPL_FILE_DATE", "Text", "255"},
            {"EPL_FURTHER_DATE", "Text", "255"},
            {"EPL_STATUTE", "Text", "255"},
            {"EPL_FNAME", "Text", "255"},
            {"OLD_BLOCK", "Text", "255"},
            {"OLD_LOT", "Text", "255"},
            {"OLD_QUAL", "Text", "255"},
            {"SALE_NU_CD", "Text", "255"},
            {"TENANT_REB_FLAG", "Text", "255"},
            {"TENANT_REB_YEAR", "Text", "255"},
            {"TENANT_REB_TAX", "Text", "255"},
            {"TENANT_REB_ASSMT", "Text", "255"},
            {"NEIGHBORHOOD", "Text", "255"},
            {"GIS_INDEX", "Text", "255"},
            {"NEWGISID2", "Text", "255"}
            }
        If ExportAccess(mod4Fields, My.Settings.WorkDB, My.Settings.SendDB, "mod4") <> 0 Then
            FormatProgressReport(0, "", "# Modiv Failed #")
            Return 1
            Exit Function
        End If

        ' Export mod4qfarm
        Dim mod4qfarmFields(,) As String =
            {{"Pin", "Text", "255"},
            {"BLOCK", "Text", "255"},
            {"LOT", "Text", "255"},
            {"QUALIFIER", "Text", "255"},
            {"NEWGISID", "Text", "255"},
            {"TAX_MAP_PG", "Text", "255"},
            {"GISKEY", "Text", "255"},
            {"ACCOUNT", "Text", "255"},
            {"PROP_CLASS", "Text", "255"},
            {"PROP_LOCAT", "Text", "255"},
            {"BUILD_DESC", "Text", "255"},
            {"LAND_DESC", "Text", "255"},
            {"ACREAGE", "Text", "255"},
            {"ADDIT_LOTS", "Text", "255"},
            {"ZONING", "Text", "255"},
            {"LAND_VAL", "Text", "255"},
            {"IMPROV_VAL", "Text", "255"},
            {"NET_TAX_VAL", "Text", "255"},
            {"OWNER", "Text", "255"},
            {"OWNER_ADDR", "Text", "255"},
            {"OWNER_CITY", "Text", "255"},
            {"OWNER_STATE", "Text", "255"},
            {"OWNER_ZIP", "Text", "255"},
            {"MTG_ACCT", "Text", "255"}
            }
        If ExportAccess(mod4qfarmFields, My.Settings.WorkDB, My.Settings.SendDB, "mod4qfarm") <> 0 Then
            FormatProgressReport(0, "", "# Modiv Failed #")
            Return 1
            Exit Function
        End If

        FormatProgressReport(0, "", "# Modiv Completed #", 3 * percMultiplier)
        Return 0
    End Function

    Private Function funCo() As Integer
        If My.Settings.SecCo = False Then
            FormatProgressReport(0, "", "# CO Skipped #", 4 * percMultiplier)
            Return 0
            Exit Function
        End If
        FormatProgressReport(0, "", "# CO Started #")

        wait(1)

        ' Delete comain records
        If RunAccessQuery("DELETE * FROM CO_Main;") <> 0 Then
            FormatProgressReport(0, "", "# CO Failed #")

        End If

        ' Import production comain
        Dim comainFields(,) As String =
            {{"Co_number", "Text", "50"},
            {"BLOCK", "Text", "15"},
            {"LOT", "Text", "15"},
            {"Property_Owner_last", "Text", "50"},
            {"Property_Owner_First", "Text", "50"},
            {"Property_Owner_PHone", "Text", "50"},
            {"Property_Address", "Text", "50"},
            {"Property_aptnum", "Text", "50"},
            {"Property_City", "Text", "50"},
            {"Property_state", "Text", "50"},
            {"Property_Zip", "Text", "50"},
            {"Diff_Address", "Text", "50"},
            {"Diff_City", "Text", "50"},
            {"Diff_State", "Text", "50"},
            {"Diff_zip", "Text", "50"},
            {"Prospect_occ_LName", "Text", "50"},
            {"Prospect_occ_First", "Text", "50"},
            {"No_in_Family", "Text", "3"},
            {"No_Bedrooms", "Text", "3"},
            {"Sale_Rental", "Text", "50"},
            {"Transfer_date", "Date/Time", "50"},
            {"Landlord_Reg", "Yes/No", "50"},
            {"Occupied", "Yes/No", "50"},
            {"Tenitive_Insp_date", "Date/Time", "50"},
            {"Received_By", "Text", "50"},
            {"Received_Date", "Date/Time", "50"},
            {"Payment_Type", "Text", "50"},
            {"Type_Structure", "Text", "50"},
            {"Mail_Report", "Yes/No", "50"},
            {"Mail_To", "Text", "50"},
            {"Mail_to2", "Text", "50"},
            {"Mail_to3", "Text", "50"},
            {"Mail_to4", "Text", "50"},
            {"Insp_By", "Text", "50"},
            {"Insp_Date", "Date/Time", "50"},
            {"Reinsp_by", "Text", "50"},
            {"Reinsp_date", "Date/Time", "50"},
            {"Conservation", "Text", "50"},
            {"Out_of_Town", "Yes/No", "50"},
            {"IssuedDate", "Date/Time", "50"},
            {"Conditional", "Yes/No", "50"},
            {"Termite_insp_req", "Yes/No", "50"},
            {"Termite_insp_Exp", "Memo", "50"},
            {"Electric_insp", "Yes/No", "50"},
            {"Electric_insp_Exp", "Memo", "50"},
            {"PressRelief", "Yes/No", "50"},
            {"PressRelief_exp", "Memo", "50"},
            {"fire_door_Required", "Yes/No", "50"},
            {"Fire_Door_Exp", "Memo", "50"},
            {"Dummy_Circuit_Breakers", "Yes/No", "50"},
            {"Dummy_Circuit_Exp", "Memo", "50"},
            {"Backflow_circuit_Breakers", "Yes/No", "50"},
            {"Backflow_Circuit_exp", "Memo", "50"},
            {"GFCI_Garage_Outlet", "Yes/No", "50"},
            {"GFCI_Garage_exp", "Memo", "50"},
            {"GFCI_Kitchen_Outlet", "Yes/No", "50"},
            {"GFCI_Kitchen_exp", "Memo", "50"},
            {"GFCI_Slop_sink_outlet", "Yes/No", "50"},
            {"GFCI_Slop_sink_exp", "Memo", "50"},
            {"GFCI_Bathroom_outlet", "Yes/No", "50"},
            {"GFCI_Bathroom_exp", "Memo", "50"},
            {"GFCI_Basement_Outlet", "Yes/No", "50"},
            {"GFCI_Basement_exp", "Memo", "50"},
            {"GFCI_Outside_Outlets", "Yes/No", "50"},
            {"GFCI_Outside_exp", "Memo", "50"},
            {"Garage_Door_opener", "Yes/No", "50"},
            {"Garage_Door_exp", "Memo", "50"},
            {"Recement_Flue_pipe", "Yes/No", "50"},
            {"Recement_Flue_exp", "Memo", "50"},
            {"Metallic_dryer_hose", "Yes/No", "50"},
            {"Metallic_dryer_exp", "Memo", "50"},
            {"Front_Door_Thumb_lock", "Yes/No", "50"},
            {"Front_Door_Thumb_exp", "Memo", "50"},
            {"Back_Door_thumb_lock", "Yes/No", "50"},
            {"Back_Door_Thumb_Exp", "Memo", "50"},
            {"Debris_in_yard", "Yes/No", "50"},
            {"Debris_Exp", "Memo", "50"},
            {"Smoke_Detector_alllevels", "Yes/No", "50"},
            {"Smoke_Alllevels_exp", "Memo", "50"},
            {"Smoke_dectector_Crawl", "Yes/No", "50"},
            {"Smoke_Crawl_exp", "Memo", "50"},
            {"Smoke_Detector_attic", "Yes/No", "50"},
            {"Smoke_attic_exp", "Memo", "50"},
            {"Smoke_Detector_Bedroom", "Yes/No", "50"},
            {"Smoke_bedroom_exp", "Memo", "50"},
            {"this1", "Memo", "50"},
            {"OpenItemsMain", "Number", "50"},
            {"OPenItemsOther", "Number", "50"},
            {"EmailAddress", "Text", "50"},
            {"Flagged", "Yes/No", "50"},
            {"GFCI_Powder", "Yes/No", "50"},
            {"GFCI_Powder_Exp", "Memo", "50"},
            {"GFCI_Protect_Shed", "Yes/No", "50"},
            {"GFCI_Protect_Shed_Exp", "Memo", "50"},
            {"Broken_Window", "Yes/No", "50"},
            {"Broken_Window_Exp", "Memo", "50"},
            {"INstall_BOCA", "Yes/No", "50"},
            {"Install_Boca_Exp", "Memo", "50"},
            {"Carbon_Mono", "Yes/No", "50"},
            {"Carbon_Mono_exp", "Memo", "50"},
            {"House_Number", "Yes/No", "50"},
            {"House_Num_Exp", "Memo", "50"}
            }

        If ExportAccess(comainFields, My.Settings.CONewDB, My.Settings.WorkDB, "CO_MAIN",,,, "brenda", "") <> 0 Then
            FormatProgressReport(0, "", "# CO Failed #")
            Return 1
            Exit Function
        End If


        ' Delete Null records (deleteCONull)
        If RunAccessQuery("DELETE CO_MAIN.Co_number FROM CO_MAIN WHERE (((CO_MAIN.Co_number) Is Null));") <> 0 Then
            FormatProgressReport(0, "", "# CO Failed #")
            Return 1
            Exit Function
        End If

        ' Run CO query (coquery)
        If RunAccessQuery("DROP TABLE CO") <> 0 Then
            FormatProgressReport(0, "", "# Modiv Failed #")
            Return 1
            Exit Function
        End If

        If RunAccessQuery("SELECT CO_Main.Co_number, CO_Main.BLOCK, CO_Main.LOT, CO_Main.No_Bedrooms, CO_Main.Transfer_date, CO_Main.Sale_Rental, CO_Main.Occupied, CO_Main.Insp_Date, CO_Main.IssuedDate, '32_'+CO_Main!block+'_'+CO_Main!lot AS PIN INTO CO FROM CO_Main;") <> 0 Then
            FormatProgressReport(0, "", "# CO Failed #")
            Return 1
            Exit Function
        End If

        ' Export
        Dim coFields(,) As String =
            {{"Co_number", "Text", "50"},
            {"BLOCK", "Text", "15"},
            {"LOT", "Text", "15"},
            {"No_Bedrooms", "Text", "3"},
            {"Transfer_date", "Date/Time", "50"},
            {"Sale_Rental", "Text", "50"},
            {"Occupied", "Yes/No", "50"},
            {"Insp_Date", "Date/Time", "50"},
            {"IssuedDate", "Date/Time", "50"},
            {"PIN", "Text", "255"}
            }

        If ExportAccess(coFields, My.Settings.WorkDB, My.Settings.SendDB, "co") <> 0 Then
            FormatProgressReport(0, "", "# CO Failed #")
            Return 1
            Exit Function
        End If
        FormatProgressReport(0, "", "# CO Completed #", 4 * percMultiplier)
        Return 0
    End Function

    Private Function funSeptics() As Integer
        If My.Settings.SecSeptics = False Then
            FormatProgressReport(0, "", "# Septics Skipped #", 5 * percMultiplier)
            Return 0
            Exit Function
        End If
        FormatProgressReport(0, "", "# Septics Started #")

        wait(1)

        ' Copy Septics #### FILE DOESN'T EXIST! #####
        'If CopyFile("s:\health\wells and septics\2016 septic  well spreadsheet.xlsx", My.Settings.WorkDir + "\septics.xlsx") <> 0 Then
        'FormatProgressReport(0, "", "# Septics Failed #")
        'Return 1
        'Exit Function
        'End If

        ' Delete application records (DeleteSeptics) 
        'If RunAccessQuery("DELETE septics.* FROM septics;") <> 0 Then
        'FormatProgressReport(0, "", "# Septics Failed #")
        'Return 1
        'Exit Function
        'End If

        ' Import production application db
        ' (septics.xlsx)

        ' Run septics query (SepticsDeleteNUll)

        ' (SepticsQ)

        ' Export to SendDB



        FormatProgressReport(0, "", "# Septics Completed #", 5 * percMultiplier)
        Return 0
    End Function

    Private Function funBco() As Integer
        If My.Settings.SecBCO = False Then
            FormatProgressReport(0, "", "# BCO Skipped #", 6 * percMultiplier)
            Return 0
            Exit Function
        End If
        FormatProgressReport(0, "", "# BCO Started #")

        wait(1)

        ' Run BCO Query (bcoquery)
        Dim bco1Fields(,) As String =
            {{"Block", "Text", "6"},
            {"Lot", "Text", "6"},
            {"Address", "Text", "255"},
            {"Company Name", "Text", "255"},
            {"Prior\Present Use", "Text", "255"},
            {"Proposed Use", "Text", "255"},
            {"Issuance Date", "Date/Time", "50"},
            {"Application Date", "Date/Time", "50"},
            {"PIN", "Text", "255"}
            }

        If ExportAccess(bco1Fields, "http://mtsharepoint2:14871/sites/Middletown/BCO/;LIST={36BB088F-6011-4E2C-9203-F4528F43EB99}", My.Settings.WorkDB, "BCO", "Sharepoint") <> 0 Then
            FormatProgressReport(0, "", "# BCO Failed #")
            Return 1
            Exit Function
        End If

        ' Export
        Dim bcoFields(,) As String =
            {{"Block", "Text", "6"},
            {"Lot", "Text", "6"},
            {"Address", "Text", "255"},
            {"Company Name", "Text", "255"},
            {"Prior\Present Use", "Text", "255"},
            {"Proposed Use", "Text", "255"},
            {"Issuance Date", "Date/Time", "50"},
            {"Application Date", "Date/Time", "50"},
            {"PIN", "Text", "255"}
            }

        If ExportAccess(bcoFields, My.Settings.WorkDB, My.Settings.SendDB, "BCO") <> 0 Then
            FormatProgressReport(0, "", "# BCO Failed #")
            Return 1
            Exit Function
        End If

        FormatProgressReport(0, "", "# BCO Started #", 6 * percMultiplier)
        Return 0
    End Function

    Private Function funZba() As Integer
        If My.Settings.SecZBA = False Then
            FormatProgressReport(0, "", "# ZBA Skipped #", 7 * percMultiplier)
            Return 0
            Exit Function
        End If
        FormatProgressReport(0, "", "# ZBA started #")

        wait(1)

        ' Delete zba database (drop table zoning)
        If RunAccessQuery("DELETE * FROM zoning") <> 0 Then
            FormatProgressReport(0, "", "# ZBA Failed #")
            Return 1
            Exit Function
        End If

        ' Import production zba
        Dim zbaFields(,) As String =
            {{"Applicant", "Text", "255"},
            {"Zone", "Text", "255"},
            {"File #", "Number", "50"},
            {"Block", "Text", "50"},
            {"Lot", "Text", "50"},
            {"Variance/Application Type", "Text", "255"},
            {"Explanation", "Text", "255"},
            {"Decision", "Text", "255"},
            {"Date", "Date/Time", "50"},
            {"Additional Lot 1", "Text", "255"},
            {"Additional Lot 2", "Text", "255"},
            {"Additional Lot 3", "Text", "255"},
            {"Additional Lot 4", "Text", "50"}
            }
        If ExportAccess(zbaFields, My.Settings.PlanningDB, My.Settings.WorkDB, "zoning") <> 0 Then
            FormatProgressReport(0, "", "# ZBA Failed #")
            Return 1
            Exit Function
        End If

        ' Run zba query (ZoneBoard)
        If RunAccessQuery("DROP TABLE ZBA") <> 0 Then
            FormatProgressReport(0, "", "# ZBA Failed #")

        End If

        If RunAccessQuery("SELECT [zoning].[Applicant], [zoning].[Zone], [zoning].[File #], [zoning].[Block], [zoning].[Lot], [zoning].[Explanation], [zoning].[Decision], [zoning].[Date], '32'+'_'+[zoning].[Block]+'_'+[zoning].[Lot] AS Pin, [zoning].[Additional Lot 2], [zoning].[Additional Lot 3], [zoning].[Additional Lot 4] INTO ZBA FROM [zoning];") <> 0 Then
            FormatProgressReport(0, "", "# ZBA Failed #")
            Return 1
            Exit Function
        End If

        ' Output to ftp site
        Dim zba1Fields(,) As String =
            {{"Applicant", "Text", "255"},
            {"Zone", "Text", "255"},
            {"File #", "Number", "50"},
            {"Block", "Text", "50"},
            {"Lot", "Text", "50"},
            {"Explanation", "Text", "255"},
            {"Decision", "Text", "255"},
            {"Date", "Date/Time", "50"},
            {"Pin", "Text", "255"},
            {"Additional Lot 2", "Text", "255"},
            {"Additional Lot 3", "Text", "255"},
            {"Additional Lot 4", "Text", "50"}
            }
        If ExportAccess(zba1Fields, My.Settings.WorkDB, My.Settings.SendDB, "ZBA") <> 0 Then
            FormatProgressReport(0, "", "# ZBA Failed #")
            Return 1
            Exit Function
        End If

        FormatProgressReport(0, "", "# ZBA Completed #", 7 * percMultiplier)
        Return 0
    End Function

    Private Function funPla() As Integer
        If My.Settings.SecPLA = False Then
            FormatProgressReport(0, "", "# PLA Skipped #", 8 * percMultiplier)
            Return 0
            Exit Function
        End If
        FormatProgressReport(0, "", "# PLA Started #")

        wait(1)

        ' Delete pla database (delete planning table)
        If RunAccessQuery("DELETE * FROM planning") <> 0 Then
            FormatProgressReport(0, "", "# PLA Failed #")
            Return 1
            Exit Function
        End If

        ' Import production pla
        Dim plaFields(,) As String =
            {{"Applicant", "Text", "255"},
            {"Zone", "Text", "255"},
            {"File #", "Number", "50"},
            {"Block", "Text", "50"},
            {"Lot", "Text", "50"},
            {"Variance/Application Type", "Text", "255"},
            {"Explanation", "Text", "255"},
            {"Decision", "Text", "255"},
            {"Date", "Date/Time", "50"},
            {"TYPE", "Text", "255"},
            {"Additional Lot 1", "Text", "255"},
            {"Additional Lot 2", "Text", "255"},
            {"Additional Lot 3", "Text", "255"},
            {"Additional Lot 4", "Text", "50"}
            }
        If ExportAccess(plaFields, My.Settings.PlanningDB, My.Settings.WorkDB, "planning") <> 0 Then
            FormatProgressReport(0, "", "# PLA Failed #")
            Return 1
            Exit Function
        End If

        ' Run pla query (PlanBoard)
        If RunAccessQuery("DROP TABLE PLA") <> 0 Then
            FormatProgressReport(0, "", "# PLA Failed #")

        End If

        If RunAccessQuery("SELECT [planning].[Applicant], [planning].[Zone], [planning].[File #], [planning].[Block], [planning].[Lot], [planning].[Variance/Application Type], [planning].[Explanation], [planning].[Decision], [planning].[Date], [planning].[TYPE], [planning].[Additional Lot 1], [planning].[Additional Lot 2], [planning].[Additional Lot 3], [planning].[Additional Lot 4], '32'+'_'+[planning].[Block]+'_'+[planning].[Lot] AS Pin INTO PLA FROM [planning];") <> 0 Then
            FormatProgressReport(0, "", "# PLA Failed #")
            Return 1
            Exit Function
        End If

        ' Output to ftp site
        Dim pla1Fields(,) As String =
            {{"Applicant", "Text", "255"},
            {"Zone", "Text", "255"},
            {"File #", "Number", "50"},
            {"Block", "Text", "50"},
            {"Lot", "Text", "50"},
            {"Variance/Application Type", "Text", "255"},
            {"Explanation", "Text", "255"},
            {"Decision", "Text", "255"},
            {"Date", "Date/Time", "50"},
            {"TYPE", "Text", "255"},
            {"Pin", "Text", "255"},
            {"Additional Lot 1", "Text", "255"},
            {"Additional Lot 2", "Text", "255"},
            {"Additional Lot 3", "Text", "255"},
            {"Additional Lot 4", "Text", "50"}
            }
        If ExportAccess(pla1Fields, My.Settings.WorkDB, My.Settings.SendDB, "PLA") <> 0 Then
            FormatProgressReport(0, "", "# PLA Failed #")
            Return 1
            Exit Function
        End If

        FormatProgressReport(0, "", "# PLA Completed #", 8 * percMultiplier)
        Return 0
    End Function

    Private Function funMac() As Integer
        ' Replaced by FTG No longer in use
        If My.Settings.SecMac = False Then
            FormatProgressReport(0, "", "# MAC Skipped #", 9 * percMultiplier)
            Return 0
            Exit Function
        End If
        FormatProgressReport(0, "", "# MAC Started #")

        wait(1)

        FormatProgressReport(0, "", "# MAC Completed #", 9 * percMultiplier)
        Return 0
    End Function

    Private Function funCd() As Integer
        If My.Settings.SecCD = False Then
            FormatProgressReport(0, "", "# CD Skipped #", 10 * percMultiplier)
            Return 0
            Exit Function
        End If
        FormatProgressReport(0, "", "# CD Started #")

        wait(1)

        ' Delete cdbg database (delete table cdbg)
        If RunAccessQuery("DELETE * FROM CDBG") <> 0 Then
            FormatProgressReport(0, "", "# CD Failed #")
            Return 1
            Exit Function
        End If

        ' Import production cdbg
        Dim cdFields(,) As String =
            {{"Year Control", "Number", "255"},
            {"Year", "Number", "255"},
            {"StartMonth", "Text", "50"},
            {"EndMonth", "Text", "50"},
            {"Application_Number", "Text", "5"},
            {"Application_Date", "Date/Time", "255"},
            {"Applicant_Name", "Text", "255"},
            {"Applicant Phone", "Text", "255"},
            {"Street_Address", "Text", "255"},
            {"City", "Text", "50"},
            {"State", "Text", "2"},
            {"Zip", "Text", "50"},
            {"CoOwnerName", "Text", "50"},
            {"Block", "Text", "50"},
            {"Lot", "Text", "50"},
            {"Census_Tract", "Text", "255"},
            {"Census_Block", "Text", "255"},
            {"Household Members", "Number", "255"},
            {"HouseholdSize", "Number", "255"},
            {"NumFemales", "Number", "255"},
            {"FemAge1", "Number", "255"},
            {"FemAge2", "Number", "255"},
            {"FemAge3", "Number", "255"},
            {"FemAge4", "Number", "255"},
            {"FemAge5", "Number", "255"},
            {"FemAge6", "Number", "255"},
            {"FemAge7", "Number", "255"},
            {"FemAge8", "Number", "255"},
            {"RelAge", "Number", "255"},
            {"FemSSNum1", "Text", "10"},
            {"FemSSNum2", "Text", "50"},
            {"FemSSNum3", "Text", "50"},
            {"FemSSNum4", "Text", "50"},
            {"FemSSNum5", "Text", "50"},
            {"FemSSNum6", "Text", "50"},
            {"FemSSNum7", "Text", "50"},
            {"FemSSNum8", "Text", "50"},
            {"RelSSNum", "Number", "255"},
            {"Relatives", "Number", "255"},
            {"NumMales", "Number", "255"},
            {"MaleAge1", "Number", "255"},
            {"MaleAge2", "Number", "255"},
            {"MaleAge3", "Number", "255"},
            {"MaleAge4", "Number", "255"},
            {"MaleAge5", "Number", "255"},
            {"MaleAge6", "Number", "255"},
            {"MaleAge7", "Number", "255"},
            {"MaleAge8", "Number", "255"},
            {"MaleSSNum1", "Text", "50"},
            {"MaleSSNum2", "Text", "50"},
            {"MaleSSNum3", "Text", "50"},
            {"MaleSSNum4", "Text", "50"},
            {"MaleSSNum5", "Text", "50"},
            {"MaleSSNum6", "Text", "50"},
            {"MaleSSNum7", "Text", "50"},
            {"MaleSSNum8", "Text", "50"},
            {"Female HH", "Number", "255"},
            {"Elderly", "Number", "255"},
            {"Handicapped", "Text", "3"},
            {"HandicappedNo", "Number", "255"},
            {"Household Race", "Text", "255"},
            {"FloodHazzard", "Text", "50"},
            {"FloodInsurance", "Text", "50"},
            {"Employer", "Text", "50"},
            {"EmpAddress", "Text", "50"},
            {"EmpPhone", "Text", "50"},
            {"YearsEmp", "Number", "255"},
            {"Salary", "Currency", "255"},
            {"coOwnerEmp", "Text", "50"},
            {"coOwnerEmpAddr", "Text", "50"},
            {"coOwnerEmpPhone", "Text", "50"},
            {"coOwnerYearsEmp", "Number", "255"},
            {"coOwnerYearSalary", "Currency", "255"},
            {"TotalFamilyIncome", "Currency", "255"},
            {"More20000", "Text", "50"},
            {"PropTaxesCurrent", "Text", "50"},
            {"SewageCurrent", "Text", "50"},
            {"CDGrant", "Text", "50"},
            {"Ethnicity", "Text", "50"},
            {"Comments", "Text", "255"},
            {"Income Qualified", "Text", "255"},
            {"IncomeQualificationDate", "Date/Time", "255"},
            {"Initial Inspection Due Date", "Date/Time", "255"},
            {"Initial Inspection", "Date/Time", "255"},
            {"WorkWrite-up Due", "Date/Time", "255"},
            {"WorkWriteup", "Date/Time", "255"},
            {"WorkWriteupComp", "Date/Time", "255"},
            {"Emergency Repair", "Text", "50"},
            {"Insulation", "Text", "11"},
            {"Septic", "Text", "6"},
            {"Water", "Text", "5"},
            {"Sump", "Text", "4"},
            {"SmokeDetector", "Text", "13"},
            {"Roof", "Text", "4"},
            {"Electric", "Text", "8"},
            {"Plumbing", "Text", "8"},
            {"Structural", "Text", "10"},
            {"HC Access", "Text", "9"},
            {"Windows/Doors", "Text", "13"},
            {"Sheetrock", "Text", "9"},
            {"Stairs", "Text", "6"},
            {"Heat", "Text", "255"},
            {"Pest", "Text", "4"},
            {"Misc", "Text", "5"},
            {"MiscExplain", "Text", "255"},
            {"ContractorName", "Text", "50"},
            {"ContractorAddress", "Text", "50"},
            {"ContractorCity", "Text", "50"},
            {"ContractorState", "Text", "50"},
            {"ContractorZip", "Text", "5"},
            {"ContractorPhone", "Text", "50"},
            {"ContractorName2", "Text", "50"},
            {"ContractorAddress2", "Text", "50"},
            {"ContractorCity2", "Text", "50"},
            {"ContractorState2", "Text", "50"},
            {"ContractorZip2", "Text", "5"},
            {"ContractorPhone2", "Text", "50"},
            {"ContractorName3", "Text", "50"},
            {"ContractorAddress3", "Text", "50"},
            {"ContractorCity3", "Text", "50"},
            {"ContractorState3", "Text", "50"},
            {"ContractorZip3", "Text", "5"},
            {"ContractorName4", "Text", "50"},
            {"ContractorAddress4", "Text", "50"},
            {"ContractorCity4", "Text", "50"},
            {"ContractorState4", "Text", "50"},
            {"ContractorZip4", "Text", "5"},
            {"BidDueDate", "Date/Time", "255"},
            {"Bid Date", "Date/Time", "255"},
            {"Contract Awarded", "Date/Time", "255"},
            {"TotalLienAmt", "Currency", "255"},
            {"BidAmount", "Currency", "255"},
            {"AddWorkAmt", "Currency", "255"},
            {"TotalGrantAmt", "Currency", "255"},
            {"Building Permit Application", "Date/Time", "255"},
            {"Building Permit Issued", "Date/Time", "255"},
            {"FirstInspectionDate", "Date/Time", "255"},
            {"ReInspectionDate", "Date/Time", "255"},
            {"Progress Inspection #3", "Date/Time", "255"},
            {"Progress Inspection #4", "Date/Time", "255"},
            {"Final Inspection/Sign-off", "Date/Time", "255"},
            {"Check Release", "Date/Time", "255"},
            {"Mortgage Mailed", "Date/Time", "255"},
            {"Mortgage Recorded", "Date/Time", "255"},
            {"Mortgage Repayment Date", "Date/Time", "255"},
            {"MortgageRepayPriorExp", "Text", "3"},
            {"Mortgage Release", "Date/Time", "255"},
            {"MortgageTotalAmt", "Currency", "255"},
            {"Life Lien Mailed", "Date/Time", "255"},
            {"Life Lien Recorded", "Date/Time", "255"},
            {"Life Lien Paid", "Date/Time", "255"},
            {"LiefLienAmount", "Currency", "255"},
            {"Subordination Agreement", "Date/Time", "255"},
            {"LifeLienAmt", "Currency", "255"},
            {"GrantQual", "Date/Time", "255"},
            {"c1VoucherNum1", "Text", "50"},
            {"c1VoucherDate1", "Date/Time", "255"},
            {"c1VoucherAmt1", "Currency", "255"},
            {"c1VoucherNum2", "Text", "50"},
            {"c1VoucherDate2", "Date/Time", "255"},
            {"c1VouchAmt2", "Currency", "255"},
            {"c1VoucherNum3", "Text", "50"},
            {"c1VoucherDate3", "Date/Time", "255"},
            {"c1VouchAmt3", "Currency", "255"},
            {"c1VoucherNum4", "Text", "50"},
            {"c1VoucherDate4", "Date/Time", "255"},
            {"c1VouchAmt4", "Currency", "255"},
            {"c1VouchTotal", "Currency", "255"},
            {"c2VoucherNum1", "Text", "50"},
            {"c2VoucherDate1", "Date/Time", "255"},
            {"c2VoucherAmt1", "Currency", "255"},
            {"c2VoucherNum2", "Text", "50"},
            {"c2VoucherDate2", "Date/Time", "255"},
            {"c2VoucherAmt2", "Currency", "255"},
            {"c2VoucherNum3", "Text", "50"},
            {"c2VoucherDate3", "Date/Time", "255"},
            {"c2VoucherAmt3", "Currency", "255"},
            {"c2VoucherNum4", "Text", "50"},
            {"c2VoucherDate4", "Date/Time", "255"},
            {"c2VoucherAmt4", "Currency", "255"},
            {"c2VouchTotal", "Currency", "255"},
            {"c3VoucherNum1", "Text", "50"},
            {"c3VoucherDate1", "Date/Time", "255"},
            {"c3VoucherAmt1", "Currency", "255"},
            {"c3VoucherNum2", "Text", "50"},
            {"c3VoucherDate2", "Date/Time", "255"},
            {"c3VoucherAmt2", "Currency", "255"},
            {"c3VoucherNum3", "Text", "50"},
            {"c3VoucherDate3", "Date/Time", "255"},
            {"c3VoucherAmt3", "Currency", "255"},
            {"c3VoucherNum4", "Text", "50"},
            {"c3VoucherDate4", "Date/Time", "255"},
            {"c3VoucherAmt4", "Currency", "255"},
            {"c3VouchTotal", "Currency", "255"},
            {"c4VoucherNum1", "Text", "50"},
            {"c4VoucherDate1", "Date/Time", "255"},
            {"c4VoucherAmt1", "Currency", "255"},
            {"c4VoucherNum2", "Text", "50"},
            {"c4VoucherDate2", "Date/Time", "255"},
            {"c4VoucherAmt2", "Currency", "255"},
            {"c4VoucherNum3", "Text", "50"},
            {"c4VoucherDate3", "Date/Time", "255"},
            {"c4VoucherAmt3", "Currency", "255"},
            {"c4VoucherNum4", "Text", "50"},
            {"c4VoucherDate4", "Date/Time", "255"},
            {"c4VoucherAmt4", "Currency", "255"},
            {"c4VouchTotal", "Currency", "255"},
            {"CheckAmt", "Currency", "255"},
            {"CheckNum", "Number", "255"},
            {"CompletionDate", "Date/Time", "255"},
            {"Status", "Text", "50"},
            {"notes", "Memo", "255"}
            }
        If ExportAccess(cdFields, My.Settings.PlanningDB, My.Settings.WorkDB, "CDBG") <> 0 Then
            FormatProgressReport(0, "", "# CD Failed #")
            Return 1
            Exit Function
        End If

        ' Run cd query (CDQuery)
        If RunAccessQuery("DROP TABLE CD") <> 0 Then
            FormatProgressReport(0, "", "# CD Failed #")

        End If

        If RunAccessQuery("SELECT '32_'+[CDBG].[Block]+'_'+[CDBG].[Lot] AS Pin, CDBG.Status, CDBG.Application_Number, CDBG.Application_Date, CDBG.Applicant_Name, CDBG.[Applicant Phone], CDBG.Street_Address, CDBG.City, CDBG.State, CDBG.Zip, CDBG.CoOwnerName, CDBG.[Household Members], CDBG.HouseholdSize, CDBG.NumFemales, CDBG.NumMales, CDBG.Relatives, CDBG.Elderly, CDBG.Handicapped, CDBG.HandicappedNo, CDBG.FloodHazzard, CDBG.FloodInsurance, CDBG.[Emergency Repair], CDBG.Insulation, CDBG.Septic, CDBG.Water, CDBG.Sump, CDBG.SmokeDetector, CDBG.Roof, CDBG.Electric, CDBG.Plumbing, CDBG.Structural, CDBG.[HC Access], CDBG.[Windows/Doors], CDBG.Sheetrock, CDBG.Stairs, CDBG.Heat, CDBG.Pest, CDBG.Misc, CDBG.MiscExplain INTO CD FROM CDBG;") <> 0 Then
            FormatProgressReport(0, "", "# CD Failed #")
            Return 1
            Exit Function
        End If

        ' Output to ftp site
        Dim cd1Fields(,) As String =
            {{"Pin", "Text", "255"},
            {"Status", "Text", "50"},
            {"Application_Number", "Text", "5"},
            {"Application_Date", "Date/Time", "50"},
            {"Applicant_Name", "Text", "255"},
            {"Applicant Phone", "Text", "255"},
            {"Street_Address", "Text", "255"},
            {"City", "Text", "50"},
            {"State", "Text", "2"},
            {"Zip", "Text", "50"},
            {"CoOwnerName", "Text", "50"},
            {"Household Members", "Number", "50"},
            {"HouseholdSize", "Number", "50"},
            {"NumFemales", "Number", "50"},
            {"NumMales", "Number", "50"},
            {"Relatives", "Number", "50"},
            {"Elderly", "Number", "50"},
            {"Handicapped", "Text", "3"},
            {"HandicappedNo", "Number", "50"},
            {"FloodHazzard", "Text", "50"},
            {"FloodInsurance", "Text", "50"},
            {"Emergency Repair", "Text", "50"},
            {"Insulation", "Text", "11"},
            {"Septic", "Text", "6"},
            {"Water", "Text", "5"},
            {"Sump", "Text", "4"},
            {"SmokeDetector", "Text", "13"},
            {"Roof", "Text", "4"},
            {"Electric", "Text", "8"},
            {"Plumbing", "Text", "8"},
            {"Structural", "Text", "10"},
            {"HC Access", "Text", "9"},
            {"Windows/Doors", "Text", "13"},
            {"Sheetrock", "Text", "9"},
            {"Stairs", "Text", "6"},
            {"Heat", "Text", "255"},
            {"Pest", "Text", "4"},
            {"Misc", "Text", "5"},
            {"MiscExplain", "Text", "255"}
            }
        If ExportAccess(cd1Fields, My.Settings.WorkDB, My.Settings.SendDB, "CD") <> 0 Then
            FormatProgressReport(0, "", "# CD Failed #")
            Return 1
            Exit Function
        End If

        FormatProgressReport(0, "", "# CD Completed #", 10 * percMultiplier)
        Return 0
    End Function

    Private Function funCpm() As Integer
        If My.Settings.SecCPM = False Then
            FormatProgressReport(0, "", "# CPM Skipped #", 11 * percMultiplier)
            Return 0
            Exit Function
        End If
        FormatProgressReport(0, "", "# CPM Started #")

        wait(1)

        ' Delete CPM database (delete table CPM)
        If RunAccessQuery("DELETE * FROM CPM") <> 0 Then
            FormatProgressReport(0, "", "# CPM Failed #")
            Return 1
            Exit Function
        End If

        ' Run cpm query (cpmquery)
        Dim cpmqueryFields(,) As String =
            {{"PERNO", "Number", "50"},
            {"U_PERNO", "Text", "12"},
            {"BLKNO", "Text", "10"},
            {"LOTNO", "Text", "10"},
            {"QUAL", "Text", "10"},
            {"TRKDT", "Date/Time", "50"},
            {"PERDT", "Date/Time", "50"},
            {"CLOSE_DT", "Date/Time", "50"},
            {"CERT_TYPE", "Text", "3"},
            {"DESC", "Text", "255"},
            {"SUBCODE", "Text", "1"},
            {"INSP_DT", "Date/Time", "50"},
            {"TYPE_INSP1", "Text", "30"},
            {"RESULT", "Text", "1"},
            {"TYPE_INSP2", "Text", "30"},
            {"RESULT2", "Text", "1"},
            {"TYPE_INSP3", "Text", "30"},
            {"RESULT3", "Text", "1"},
            {"INSPECTOR", "Text", "3"},
            {"CO_DT", "Date/Time", "50"},
            {"CCONO", "Number", "50"},
            {"CCO_DT", "Date/Time", "50"},
            {"PIN", "Text", "255"}
            }
        Dim cpmSelectQuery As String = "SELECT dbo.T44_Applications.[PERNO], dbo.T44_Applications.[U_PERNO], dbo.T44_Applications.[BLKNO], dbo.T44_Applications.[LOTNO], dbo.T44_Applications.[QUAL], dbo.T44_Applications.[TRKDT], dbo.T44_Applications.[PERDT], dbo.T44_Applications.[CLOSE_DT], dbo.T44_Applications.[CERT_TYPE], dbo.T44_Applications.[DESC], dbo.T24_Inspections.[SUBCODE], dbo.T24_Inspections.[INSP_DT], dbo.T24_Inspections.[TYPE_INSP1], dbo.T24_Inspections.[RESULT], dbo.T24_Inspections.[TYPE_INSP2], dbo.T24_Inspections.[RESULT2], dbo.T24_Inspections.[TYPE_INSP3], dbo.T24_Inspections.[RESULT3], dbo.T24_Inspections.[INSPECTOR], dbo.T44_Applications.[CO_DT], dbo.T44_Applications.[CCONO], dbo.T44_Applications.[CCO_DT], '32_'+dbo.T44_APPLICATIONS.[Blkno]+'_'+dbo.T44_APPLICATIONS.[lotno] AS PIN FROM dbo.T44_Applications INNER JOIN dbo.T24_Inspections ON dbo.T44_Applications.[PERNO] = dbo.T24_Inspections.[PERNO] WHERE (((dbo.T44_Applications.[PERDT])>'2006-03-31') AND ((dbo.T44_Applications.[UPSUF])=0));"
        If ExportAccess(cpmqueryFields, "APPSERVER3\CPM", My.Settings.WorkDB, "CPM", "DSN", cpmSelectQuery, "CPM") <> 0 Then
            FormatProgressReport(0, "", "# CPM Failed #")
            Return 1
            Exit Function
        End If

        ' Export to send
        Dim cpmFields(,) As String =
            {{"PERNO", "Number", "50"},
            {"U_PERNO", "Text", "12"},
            {"BLKNO", "Text", "10"},
            {"LOTNO", "Text", "10"},
            {"QUAL", "Text", "10"},
            {"TRKDT", "Date/Time", "50"},
            {"PERDT", "Date/Time", "50"},
            {"CLOSE_DT", "Date/Time", "50"},
            {"CERT_TYPE", "Text", "3"},
            {"DESC", "Text", "255"},
            {"SUBCODE", "Text", "1"},
            {"INSP_DT", "Date/Time", "50"},
            {"TYPE_INSP1", "Text", "30"},
            {"RESULT", "Text", "1"},
            {"TYPE_INSP2", "Text", "30"},
            {"RESULT2", "Text", "1"},
            {"TYPE_INSP3", "Text", "30"},
            {"RESULT3", "Text", "1"},
            {"INSPECTOR", "Text", "3"},
            {"CO_DT", "Date/Time", "50"},
            {"CCONO", "Number", "50"},
            {"CCO_DT", "Date/Time", "50"},
            {"PIN", "Text", "255"}
            }
        If ExportAccess(cpmFields, My.Settings.WorkDB, My.Settings.SendDB, "CPM") <> 0 Then
            FormatProgressReport(0, "", "# CD Failed #")
            Return 1
            Exit Function
        End If

        FormatProgressReport(0, "", "# CPM Completed #", 11 * percMultiplier)
        Return 0
    End Function

    Private Function funFtg() As Integer
        ' Not in use
        If My.Settings.SecFTG = False Then
            FormatProgressReport(0, "", "# FTG Skipped #", 12 * percMultiplier)
            Return 0
            Exit Function
        End If
        FormatProgressReport(0, "", "# FTG Started #")

        wait(1)

        FormatProgressReport(0, "", "# FTG Completed #", 12 * percMultiplier)
        Return 0
    End Function

    Private Function funZone() As Integer
        If My.Settings.SecZone = False Then
            FormatProgressReport(0, "", "# Zone Skipped #", 13 * percMultiplier)
            Return 0
            Exit Function
        End If
        FormatProgressReport(0, "", "# Zone Started #")

        wait(1)

        ' Run Zone query (SharepointZone)
        Dim zoningApplicationFields(,) As String =
            {{"PIN", "Text", "255"},
            {"Block", "Text", "255"},
            {"Lot", "Text", "255"},
            {"Application Date", "Date/Time", "255"},
            {"Date Of Review", "Date/Time", "255"},
            {"Status", "Text", "255"},
            {"Zone", "Text", "255"},
            {"Proposed Development", "Text", "255"},
            {"Comments", "Text", "255"}
            }

        If ExportAccess(zoningApplicationFields, "http://mtsharepoint2:14871/sites/Middletown/zoning/;LIST={2C161244-978B-4FB6-8BF3-4300171BEE07}", My.Settings.WorkDB, "Zoning Applications", "Sharepoint", "", "NewZone") <> 0 Then
            FormatProgressReport(0, "", "# Zone Failed #")
            Return 1
            Exit Function
        End If

        ' Run Query (PrimeZone)
        If RunAccessQuery("DROP TABLE TempZone") <> 0 Then
            FormatProgressReport(0, "", "# Zone Failed #")

        End If
        If RunAccessQuery("SELECT [PIN], [BLOCK], [LOT], [Application Date], [DATE OF REVIEW], [Status], [Zone], [Proposed Development], [Comments] INTO [TempZone] FROM [zone];") <> 0 Then
            FormatProgressReport(0, "", "# Zone Failed #")
            Return 1
            Exit Function
        End If

        ' Run Query (AppendZone)
        If RunAccessQuery("INSERT INTO TempZone SELECT NewZone.* FROM NewZone;") <> 0 Then
            FormatProgressReport(0, "", "# Zone Failed #")
            Return 1
            Exit Function
        End If

        ' Export to Send (tempzone to zone)
        Dim tempzoneFields(,) As String =
            {{"PIN", "Text", "255"},
            {"BLOCK", "Text", "255"},
            {"LOT", "Text", "255"},
            {"Application Date", "Text", "255"},
            {"DATE OF REVIEW", "Text", "255"},
            {"Status", "Text", "255"},
            {"Zone", "Text", "255"},
            {"Proposed Development", "Text", "255"},
            {"Comments", "Text", "255"}
            }
        If ExportAccess(tempzoneFields, My.Settings.WorkDB, My.Settings.SendDB, "TempZone", "Access", "", "zone") <> 0 Then
            FormatProgressReport(0, "", "# Zone Failed #")
            Return 1
            Exit Function
        End If

        FormatProgressReport(0, "", "# Zone Completed #", 13 * percMultiplier)
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

            Do Until bytesIn <1
                                 bytesIn= stream.Read(buffer, 0, 1024)
                If bytesIn > 0 Then
                    output.Write(buffer, 0, bytesIn)
                    TotalBytesIn += bytesIn
                    If filelength > 0 Then
                        Dim perc As Integer = (TotalBytesIn / filelength) * 1000
                        FormatProgressReport(perc, ftpfile + " Download", "")
                    End If
                End If
            Loop
            output.Close()
            stream.Close()
        Catch ex As Exception
            FormatProgressReport(1000, ftpfile + " Download", "Download of " + ftpfile + " failed.")
            FormatProgressReport(1000, "", ex.Message)
            Return 1

            Exit Function
        End Try

        FormatProgressReport(1000, ftpfile + " Download", ftpfile + " downloaded successfully")

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

    Private Function CopyFile(fromPath As String, toPath As String) As Integer
        Try

            System.IO.File.Copy(fromPath, toPath, True)
        Catch ex As Exception
            FormatProgressReport(0, "", ex.Message)
            FormatProgressReport(0, "", "Unable to copy file from " + fromPath + " to " + toPath)
            Return 1
            Exit Function
        End Try
        FormatProgressReport(0, "", fromPath + " copied to " + toPath)
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
                Dim perc As Integer = x / linecount * 1000
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
            FormatProgressReport(1000, "", ex.Message)
            FormatProgressReport(1000, "", "Import of " + textFile + " Failed")
            Return 1
            Exit Function
        End Try

        FormatProgressReport(1000, "", "Import of " + textFile + " Successful")
        Return 0
    End Function
    Private Function ExportAccess(fieldArray(,) As String, fromDB As String, toDB As String, fromTableName As String, Optional connectionType As String = "Access", Optional selectOveride As String = "", Optional toTableName As String = "", Optional UserID As String = "", Optional Password As String = "") As Integer
        Dim selectText As String = ""
        Dim valueText As String = ""
        Dim fieldText As String = ""
        Dim insertText As String = ""

        For i = 0 To fieldArray.GetLength(0) - 1
            fieldText += "[" + fieldArray(i, 0).ToString + "],"
            valueText += "[@" + fieldArray(i, 0).ToString + "],"
        Next

        fieldText = fieldText.Trim().Remove(fieldText.Length - 1)
        valueText = valueText.Trim().Remove(valueText.Length - 1)
        If selectOveride = "" Then
            selectText = "SELECT " + fieldText + " FROM [" + fromTableName + "];"
        Else
            selectText = selectOveride
        End If

        If toTableName = "" Then
            toTableName = fromTableName
        End If
        insertText = "INSERT INTO [" + toTableName + "] (" + fieldText + ") VALUES (" + valueText + ");"

        FormatProgressReport(0, "Importing " + fromTableName, "Importing " + fromTableName + " from " + fromDB + " to " + toDB)

        Try
            Dim fromConString As String = ""
            Select Case connectionType
                Case "Access"
                    fromConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fromDB + ";"
                    If UserID <> "" Then
                        fromConString += "User ID=" + UserID + ";Password=" + Password + ";Jet OLEDB:System Database=S:\Co system\Security.mdw"
                    End If
                Case "Sharepoint"
                    fromConString = "Provider=Microsoft.ACE.OLEDB.12.0;WSS;IMEX=2;RetrieveIds=Yes;DATABASE=" + fromDB + ";"
                Case "DSN"
                    Dim serverSplit As String() = fromDB.Split(New Char() {"\"c})
                    fromConString = "Provider=sqloledb;Data Source=" + serverSplit(0) + ";Initial Catalog=" + serverSplit(1) + ";Integrated Security=SSPI;"
            End Select

            Dim fromDBCon As New OleDb.OleDbConnection(fromConString)
            Dim toDBCon As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + toDB)

            fromDBCon.Open()
            toDBCon.Open()

            'Create the data adapter with a SelectCommand using the first connection.
            Dim da As New OleDb.OleDbDataAdapter(selectText, fromDBCon)
            AddHandler da.RowUpdated, New OleDb.OleDbRowUpdatedEventHandler(AddressOf OnRowUpdate)

            'Add the InsertCommand with the second connection.
            da.InsertCommand = New OleDb.OleDbCommand(insertText, toDBCon)

            'Add the insert parameters.
            For i = 0 To fieldArray.GetLength(0) - 1
                Select Case fieldArray(i, 1).ToString
                    Case "Text"
                        Dim fieldType As OleDb.OleDbType = OleDb.OleDbType.VarWChar
                        da.InsertCommand.Parameters.Add("@" + fieldArray(i, 0).ToString, fieldType, Convert.ToInt32(fieldArray(i, 2)), fieldArray(i, 0).ToString)
                    Case "Date/Time"
                        Dim fieldType As OleDb.OleDbType = OleDb.OleDbType.Date
                        da.InsertCommand.Parameters.Add("@" + fieldArray(i, 0).ToString, fieldType, Convert.ToInt32(fieldArray(i, 2)), fieldArray(i, 0).ToString)
                    Case "Yes/No"
                        Dim fieldType As OleDb.OleDbType = OleDb.OleDbType.Boolean
                        da.InsertCommand.Parameters.Add("@" + fieldArray(i, 0).ToString, fieldType, Convert.ToInt32(fieldArray(i, 2)), fieldArray(i, 0).ToString)
                    Case "Memo"
                        Dim fieldType As OleDb.OleDbType = OleDb.OleDbType.LongVarWChar
                        da.InsertCommand.Parameters.Add("@" + fieldArray(i, 0).ToString, fieldType, Convert.ToInt32(fieldArray(i, 2)), fieldArray(i, 0).ToString)
                    Case "Number"
                        Dim fieldType As OleDb.OleDbType = OleDb.OleDbType.Integer
                        da.InsertCommand.Parameters.Add("@" + fieldArray(i, 0).ToString, fieldType, Convert.ToInt32(fieldArray(i, 2)), fieldArray(i, 0).ToString)
                    Case "Currency"
                        Dim fieldType As OleDb.OleDbType = OleDb.OleDbType.Numeric
                        da.InsertCommand.Parameters.Add("@" + fieldArray(i, 0).ToString, fieldType, Convert.ToInt32(fieldArray(i, 2)), fieldArray(i, 0).ToString)
                End Select
            Next


            'Keep the records ina state where they can be inserted into the destination table.
            da.AcceptChangesDuringFill = False

            Dim dt As New DataTable

            'Get the data from the source database.
            da.Fill(dt)

            'Save the data to the destination database.
            da.Update(dt)

            toDBCon.Close()
            fromDBCon.Close()

        Catch ex As Exception
            FormatProgressReport(1000, "", ex.Message)
            FormatProgressReport(1000, "", "Import of " + fromTableName + " from " + fromDB + " to " + toDB + " Failed")
            FormatProgressReport(1000, "", "Select Query:" + selectText)
            FormatProgressReport(1000, "", "Insert Query:" + insertText)
            Return 1
            Exit Function
        End Try
        FormatProgressReport(1000, "Importing " + fromTableName, "Import of " + fromTableName + " from " + fromDB + " to " + toDB + " Successful")
        Return 0
    End Function
    Sub OnRowUpdate(ByVal sender As Object, ByVal args As OleDb.OleDbRowUpdatedEventArgs)
        Dim tick As Integer = pgbTask.Value + 1
        If tick > pgbTask.Maximum Then
            tick = 0
        End If
        FormatProgressReport(tick, "", "")
    End Sub
    Private Sub FormatProgressReport(taskPerc As Integer, taskStatus As String, consoleStatus As String, Optional overPerc As Integer = vbNull)
        If overPerc = vbNull Then
            Dim fullStatus As String = taskStatus + "|" + consoleStatus
            bgwQueue.ReportProgress(taskPerc, fullStatus)
        Else
            Dim fullStatus As String = taskStatus + "|" + consoleStatus + "|" + overPerc.ToString
            bgwQueue.ReportProgress(taskPerc, fullStatus)
        End If
    End Sub
    Private Function compactDatabase() As Integer
        ' #TODO
        If My.Settings.CompactDB = False Then
            FormatProgressReport(0, "", "# Compact Database Skipped #", 14 * percMultiplier)
            Return 0
            Exit Function
        End If

        FormatProgressReport(0, "", "# Compact Database Completed #", 14 * percMultiplier)
        Return 0
    End Function
    Private Function sendToFtp() As Integer
        ' #TODO
        If My.Settings.SendToFTP = False Then
            FormatProgressReport(0, "", "# Send to FTP Skipped #", 15 * percMultiplier)
            Return 0
            Exit Function
        End If

        FormatProgressReport(0, "", "# Send to FTP Completed #", 15 * percMultiplier)
        Return 0
    End Function
    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        frmOptions.ShowDialog()
    End Sub

    Private Sub TmrTask_Tick(sender As Object, e As EventArgs) Handles tmrTask.Tick
        timercount += 1
        With TimeSpan.FromSeconds(timercount)
            lblHours.Text = .Hours.ToString("D2")
            lblMinutes.Text = .Minutes.ToString("D2")
            lblSeconds.Text = .Seconds.ToString("D2")
        End With
    End Sub
End Class
