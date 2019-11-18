Imports BackendLibrary
Imports BackendLibrary.Classes
Imports Equin.ApplicationFramework

Public Class Form1

    Private _dataOperations As DataOperations
    Private _coursesView As BindingListView(Of Course)

    ''' <summary>
    ''' 1. Populate Departments ListBox and Courses ListBox
    ''' 2. Set filter for courses in current selected department
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        _dataOperations = New DataOperations()
        DepartmentsListBox.DataSource = _dataOperations.Departments()

        Dim courses = _dataOperations.OnSiteCourses
        _coursesView = New BindingListView(Of Course)(courses)

        CoursesListBox.DataSource = _coursesView

        FilterCourses()

    End Sub
    ''' <summary>
    ''' When the selected department changes in the department listbox, apply
    ''' a filter to the courses listbox for available courses under the selected
    ''' department.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DepartmentsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles DepartmentsListBox.SelectedIndexChanged

        FilterCourses()

    End Sub
    ''' <summary>
    ''' Filter courses to current selected department
    ''' </summary>
    Private Sub FilterCourses()

        If CoursesListBox.SelectedItem Is Nothing Then
            Exit Sub
        End If

        _coursesView.ApplyFilter(Function(course As Course)
                                    Return course.DepartmentID = CType(DepartmentsListBox.SelectedItem, Department).DepartmentID
                                End Function)

        CoursesListBox.SelectedIndex = 0

        DaysCourseAvailableListBox.DataSource =
            _dataOperations.DayNamesFromReferences(
                CType(CoursesListBox.SelectedItem, ObjectView(Of Course)).Object.CourseID)

    End Sub
    ''' <summary>
    ''' Get days current course is offered
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CoursesListBox_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles CoursesListBox.SelectedIndexChanged

        DaysCourseAvailableListBox.DataSource = _dataOperations.DayNamesFromReferences(
            CType(CoursesListBox.SelectedItem, ObjectView(Of Course)).Object.CourseID)

    End Sub
    ''' <summary>
    ''' Demonstrates obtaining properties of the selected day.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SelectedDayButton_Click(sender As Object, e As EventArgs) Handles SelectedDayButton.Click
        Dim selectedDay As CourseDay = CType(DaysCourseAvailableListBox.SelectedItem, CourseDay)

        MessageBox.Show($"Course: {selectedDay.CourseID} Day index {selectedDay.DayIndex}")

    End Sub
End Class
