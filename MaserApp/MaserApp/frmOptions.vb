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
End Class