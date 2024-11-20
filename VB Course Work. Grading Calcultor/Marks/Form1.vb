Public Class Form1
    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click


        Dim marks As Integer = txtMarks.Text
        Dim grade As String = txtGrade.Text


        If marks < 101 And marks > -1 Then

            Select Case marks
                Case 90 To 100
                    txtGrade.Text = "Excellent"
                Case 80 To 89
                    txtGrade.Text = "Very good"
                Case 70 To 79
                    txtGrade.Text = "Good"
                Case 60 To 69
                    txtGrade.Text = "Medium"
                Case 50 To 59
                    txtGrade.Text = "Pass"
                Case Else
                    txtGrade.Text = "Fail"
            End Select

        Else
            MessageBox.Show("Wrong entry, please re-enter the marks")
            txtMarks.Clear()
        End If


    End Sub
End Class
