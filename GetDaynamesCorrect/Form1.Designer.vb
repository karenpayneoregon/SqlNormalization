<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DepartmentsListBox = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CoursesListBox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DaysCourseAvailableListBox = New System.Windows.Forms.ListBox()
        Me.SelectedDayButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Departments"
        '
        'DepartmentsListBox
        '
        Me.DepartmentsListBox.FormattingEnabled = True
        Me.DepartmentsListBox.Location = New System.Drawing.Point(12, 30)
        Me.DepartmentsListBox.Name = "DepartmentsListBox"
        Me.DepartmentsListBox.Size = New System.Drawing.Size(120, 160)
        Me.DepartmentsListBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Courses"
        '
        'CoursesListBox
        '
        Me.CoursesListBox.FormattingEnabled = True
        Me.CoursesListBox.Location = New System.Drawing.Point(147, 30)
        Me.CoursesListBox.Name = "CoursesListBox"
        Me.CoursesListBox.Size = New System.Drawing.Size(120, 160)
        Me.CoursesListBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(282, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Day available"
        '
        'DaysCourseAvailableListBox
        '
        Me.DaysCourseAvailableListBox.FormattingEnabled = True
        Me.DaysCourseAvailableListBox.Location = New System.Drawing.Point(285, 30)
        Me.DaysCourseAvailableListBox.Name = "DaysCourseAvailableListBox"
        Me.DaysCourseAvailableListBox.Size = New System.Drawing.Size(97, 160)
        Me.DaysCourseAvailableListBox.TabIndex = 7
        '
        'SelectedDayButton
        '
        Me.SelectedDayButton.Location = New System.Drawing.Point(285, 196)
        Me.SelectedDayButton.Name = "SelectedDayButton"
        Me.SelectedDayButton.Size = New System.Drawing.Size(97, 23)
        Me.SelectedDayButton.TabIndex = 8
        Me.SelectedDayButton.Text = "Selected day"
        Me.SelectedDayButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 248)
        Me.Controls.Add(Me.SelectedDayButton)
        Me.Controls.Add(Me.DaysCourseAvailableListBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CoursesListBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DepartmentsListBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Day names in one field (recommended)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DepartmentsListBox As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CoursesListBox As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DaysCourseAvailableListBox As ListBox
    Friend WithEvents SelectedDayButton As Button
End Class
