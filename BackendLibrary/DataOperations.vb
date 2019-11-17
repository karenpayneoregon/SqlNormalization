Imports System.Data.SqlClient
Imports BackendLibrary.Classes
Imports BaseConnectionLibrary.ConnectionClasses

Public Class DataOperations
    Inherits SqlServerConnection

    Public Sub New()
        DatabaseServer = "KARENS-PC"
        DefaultCatalog = "School"
    End Sub

    Public Function Departments() As List(Of Department)
        Dim departmentList As New List(Of Department)

        Using cn As New SqlConnection With {.ConnectionString = ConnectionString}
            Using cmd As New SqlCommand With {.Connection = cn}
                cmd.CommandText = "SELECT DepartmentID,Name FROM dbo.Department"
                cn.Open()

                Dim reader = cmd.ExecuteReader()

                While reader.Read()
                    departmentList.Add(New Department() With {.DepartmentID = reader.GetInt32(0), .Name = reader.GetString(1)})
                End While
            End Using
        End Using

        Return departmentList

    End Function
    Public Function OnSiteCourses() As List(Of Course)
        Dim departmentList As New List(Of Course)

        Using cn As New SqlConnection With {.ConnectionString = ConnectionString}
            Using cmd As New SqlCommand With {.Connection = cn}

                cmd.CommandText = "SELECT CourseID,Title,Credits,DepartmentID FROM dbo.Course WHERE CourseID IN (1045,1050,1061,2042,4022,4061)"

                cn.Open()

                Dim reader = cmd.ExecuteReader()

                While reader.Read()
                    departmentList.Add(New Course() With {.CourseID = reader.GetInt32(0), .Title = reader.GetString(1), .Credits = reader.GetInt32(2), .DepartmentID = reader.GetInt32(3)})
                End While
            End Using
        End Using

        Return departmentList
    End Function

    ''' <summary>
    ''' Get day names course is offered where one field is used to hold days
    ''' </summary>
    ''' <param name="CourseIdentifier"></param>
    ''' <returns></returns>
    Public Function DayNamesFromSingleField(CourseIdentifier As Integer) As List(Of String)

        Dim dayList As New List(Of String)

        Using cn As New SqlConnection With {.ConnectionString = ConnectionString}
            Using cmd As New SqlCommand With {.Connection = cn}
                cmd.CommandText =
                    <SQL>
                        SELECT SUBSTRING(a.b, v.number + 1, 1) AS DayParts
                        FROM   ( SELECT (   SELECT Days
                                            FROM   OnsiteCourse
                                            WHERE  ( CourseID = @CourseIdentifier )) AS b ) AS a
                               INNER JOIN master.dbo.spt_values AS v ON v.number &lt;LEN(a.b)
                        WHERE  ( v.type = 'P' );
                    </SQL>.Value

                cmd.Parameters.AddWithValue("@CourseIdentifier", CourseIdentifier)

                cn.Open()

                Dim reader = cmd.ExecuteReader()

                While reader.Read()
                    Select Case reader.GetString(0)
                        Case "X"
                            dayList.Add("Sunday")
                        Case "M"
                            dayList.Add("Monday")
                        Case "T"
                            dayList.Add("Tuesday")
                        Case "W"
                            dayList.Add("Wednesday")
                        Case "H"
                            dayList.Add("Thursday")
                        Case "F"
                            dayList.Add("Friday")
                        Case "S"
                            dayList.Add("Saturday")
                        Case Else
                            dayList.Add("Unknown")
                    End Select


                End While
            End Using
        End Using

        Return dayList

    End Function


End Class
