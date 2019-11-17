Namespace Classes
    Public Class CourseDay
        Public Property Id() As Integer
        Public Property Name() As String
        Public Property DayIndex() As Integer
        Public Property Offered() As Boolean
        Public Property CourseID() As Integer
        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class
End Namespace