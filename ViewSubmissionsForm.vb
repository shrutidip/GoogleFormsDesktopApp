Imports System.Windows.Forms

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0 ' To track current submission index, assuming 0-based index

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowSubmission(currentIndex)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            ShowSubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Assuming submissions are stored somewhere and fetched accordingly
        If currentIndex < TotalSubmissions() - 1 Then
            currentIndex += 1
            ShowSubmission(currentIndex)
        End If
    End Sub

    Private Sub ShowSubmission(index As Integer)
        ' Logic to fetch and display submission at index
        ' Example: Display submission details in text boxes
        txtName.Text = "Submission " & (index + 1)
        txtEmail.Text = "email@example.com"
        ' Display other submission details similarly
    End Sub
End Class
