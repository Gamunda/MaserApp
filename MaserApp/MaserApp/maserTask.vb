Public Class maserTask
    Private skippedValue As Boolean
    Private finishedValue As Boolean
    Private statusValue As Integer

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

    Public Property Status() As Integer ' Task Failed?
        Get
            Return statusValue
        End Get
        Set(ByVal value As Integer)
            statusValue = value
        End Set
    End Property
    Public Sub New(ByVal skippedValue As Boolean, ByVal finishedValue As Boolean)
        Me.finishedValue = finishedValue
        Me.skippedValue = skippedValue
    End Sub


End Class
