Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            TextBox1.Text = "The Chosen Language is Java"
        ElseIf RadioButton2.Checked = True Then
            TextBox1.Text = "The Chosen Language is C++"
        ElseIf RadioButton3.Checked = True Then
            TextBox1.Text = "The Chosen Language is C"
        ElseIf RadioButton4.Checked = True Then
            TextBox1.Text = "The Chosen Language is Visual Basic"
        ElseIf RadioButton5.Checked = True Then
            TextBox1.Text = "The Chosen Language is Javascript"
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub
End Class
