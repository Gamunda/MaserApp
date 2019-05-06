Public Class frmOptions
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Close()
    End Sub

    Private Sub BtnChooseMaser_Click(sender As Object, e As EventArgs) Handles btnChooseMaser.Click
        If (fbdWorkDir.ShowDialog() = DialogResult.OK) Then
            txbWorkDir.Text = fbdWorkDir.SelectedPath
        End If
    End Sub

    Private Sub BtnChooseWorkDB_Click(sender As Object, e As EventArgs) Handles btnChooseWorkDB.Click
        If (ofdWorkDB.ShowDialog() = DialogResult.OK) Then
            txbWorkDB.Text = ofdWorkDB.FileName
        End If
    End Sub

    Private Sub BtnChooseCODB_Click(sender As Object, e As EventArgs) Handles btnChooseCODB.Click
        If (ofdCODB.ShowDialog() = DialogResult.OK) Then
            txbCODB.Text = ofdCODB.FileName
        End If
    End Sub

    Private Sub BtnChooseSend_Click(sender As Object, e As EventArgs) Handles btnChooseSend.Click
        If (ofdSendDB.ShowDialog() = DialogResult.OK) Then
            txbSendDB.Text = ofdSendDB.FileName
        End If
    End Sub

    Private Sub BtnChoosePlanning_Click(sender As Object, e As EventArgs) Handles btnChoosePlanning.Click
        If (ofdPlanningDB.ShowDialog() = DialogResult.OK) Then
            txbPlanningDB.Text = ofdPlanningDB.FileName
        End If
    End Sub

    Private Sub BtnChooseLog_Click(sender As Object, e As EventArgs) Handles btnChooseLog.Click
        If (fbdLogFile.ShowDialog() = DialogResult.OK) Then
            If System.IO.File.Exists(fbdLogFile.SelectedPath + "\maserlog.txt") = False Then
                System.IO.File.Create(fbdLogFile.SelectedPath + "\maserlog.txt")
                MaserMain.WriteLog("!!! LOG FILE CREATED !!!")
            End If
            txbLogFile.Text = fbdLogFile.SelectedPath + "\maserlog.txt"
            End If
    End Sub

    Private Sub BtnClearLog_Click(sender As Object, e As EventArgs) Handles btnClearLog.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to clear the Log?", "Clear Log?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            If System.IO.File.Exists(My.Settings.LogPath) = True Then
                System.IO.File.WriteAllText(My.Settings.LogPath, "")
                MaserMain.WriteLog("!!! LOG CLEARED !!!")
            Else
                System.IO.File.Create(My.Settings.LogPath)
                MaserMain.WriteLog("!!! LOG CLEARED !!!")
            End If
        End If

    End Sub
End Class