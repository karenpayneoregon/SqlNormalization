Namespace Classes
    Public Class Course
        Public Property CourseID As Integer
        Public Property Title As String
        Public Property Credits As Integer
        Public Property DepartmentID As Integer

        Public Overrides Function ToString() As String
            Return Title
        End Function
    End Class
End Namespace