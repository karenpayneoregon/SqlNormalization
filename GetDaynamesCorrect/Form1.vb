Imports BackendLibrary
Imports BackendLibrary.Classes
Imports Equin.ApplicationFramework

Public Class Form1

    Private DataOperations As DataOperations
    Private CoursesView As BindingListView(Of Course)

    ''' <summary>
    ''' 1. Populate Departments ListBox and Courses ListBox
    ''' 2. Set filter for courses in current selected department
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        DataOperations = New DataOperations()

        DepartmentsListBox.DataSource = DataOperations.Departments()

        CoursesView = New BindingListView(Of Course)(DataOperations.OnSiteCourses)
        CoursesListBox.DataSource = CoursesView

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

        CoursesView.ApplyFilter(Function(customer As Course)
                                    Return customer.DepartmentID =
                                           CType(DepartmentsListBox.SelectedItem,
                                                 Department).DepartmentID
                                End Function)

        CoursesListBox.SelectedIndex = 0

        DaysCourseAvailableListBox.DataSource =
            DataOperations.DayNamesFromReferences(
                CType(CoursesListBox.SelectedItem, ObjectView(Of Course)).Object.CourseID)

    End Sub
    ''' <summary>
    ''' Get days current course is offered
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CoursesListBox_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles CoursesListBox.SelectedIndexChanged

        DaysCourseAvailableListBox.DataSource = DataOperations.DayNamesFromSingleField(
            CType(CoursesListBox.SelectedItem, ObjectView(Of Course)).Object.CourseID)

    End Sub
    ''' <summary>
    ''' Demonstrates obtaining properties of the selected day.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SelectedDayButton_Click(sender As Object, e As EventArgs) Handles SelectedDayButton.Click
        Dim SelectedDay As CourseDay = CType(DaysCourseAvailableListBox.SelectedItem, CourseDay)

        MessageBox.Show($"Course: {SelectedDay.CourseID} Day index {SelectedDay.DayIndex}")

    End Sub
End Class
