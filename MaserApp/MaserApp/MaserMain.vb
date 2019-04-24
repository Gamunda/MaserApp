Imports System.ComponentModel

Public Class MaserMain
    Dim taxa1332 As New maserTask(False, False)
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub MaserMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        toggleGUI()
        bgwQueue.RunWorkerAsync()
    End Sub

    Private Sub BgwQueue_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwQueue.DoWork

    End Sub

    Private Sub bgwQueue_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgwQueue.ProgressChanged

    End Sub

    Private Sub bgwQueue_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwQueue.RunWorkerCompleted

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
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        toggleGUI()
    End Sub
End Class
