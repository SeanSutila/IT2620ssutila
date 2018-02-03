Public Class Form1
    Private Sub Setup_Click(sender As Object, e As EventArgs) Handles Setup.Click
        Joke.Text = "How many programmers does it take to change a light bulb?"
    End Sub

    Private Sub Punchline_Click(sender As Object, e As EventArgs) Handles Punchline.Click
        Joke.Text = "None. That’s a hardware problem."
    End Sub
End Class
