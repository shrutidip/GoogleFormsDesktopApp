Imports System.Windows.Forms

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Private stopwatchRunning As Boolean = False

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize form or load data if needed
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatchRunning Then
            stopwatch.Stop()
            stopwatchRunning = False
            ' Display paused stopwatch time or handle logic
        Else
            stopwatch.Start()
            stopwatchRunning = True
            ' Start or resume stopwatch display or logic
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Example: Submit data to backend using API call
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhone.Text
        Dim githubLink As String = txtGitHub.Text
        Dim stopwatchTime As String = stopwatch.Elapsed.ToString()

        ' Call backend API to save submission
        ' Example: Submit(name, email, phone, githubLink, stopwatchTime)
        MessageBox.Show("Submission saved successfully!")

        ' Optionally, close form or reset fields
        Me.Close()
    End Sub
End Class
