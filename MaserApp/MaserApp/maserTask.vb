Public Class maserTask
    Private skippedValue As Boolean
    Private finishedValue As Boolean

    Public Property Skipped() As Boolean 'Is this task skipped?
        Get
            Return skippedValue
        End Get
        Set(ByVal value As Boolean)
            skippedValue = value
        End Set
    End Property

    Public Property Finished() As Boolean 'Is this task completed?
        Get
            Return finishedValue
        End Get
        Set(ByVal value As Boolean)
            finishedValue = value
        End Set
    End Property
    Public Sub New(ByVal skippedValue As Boolean, ByVal finishedValue As Boolean)
        Me.finishedValue = finishedValue
        Me.skippedValue = skippedValue
    End Sub

    Public Sub RunAccessQuery(sqlCmd As String)
        ' Set up connection string to Access database based on saved options
        Dim Connection As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + My.Settings.WorkDB)
        Dim Command As New System.Data.OleDb.OleDbCommand()
        Dim intRC As Integer

        ' Connect to the database and run the query
        Try
            Command.CommandType = System.Data.CommandType.Text
            Command.CommandText = sqlCmd
            Command.Connection = Connection

            Connection.Open()
            intRC = Command.ExecuteNonQuery()
            Connection.Close()
        Catch ex As Exception
            ' If any errors occur, mark this as complete but failed and log it to console and log file
            'WriteLog(ex.Message)
        End Try
    End Sub
End Class
