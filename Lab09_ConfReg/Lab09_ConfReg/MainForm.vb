Public Class MainForm
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSelectConference.Click
        Dim frmConference As New ConferenceOptions
        frmConference.ShowDialog()
        lblTotal.Text = decTotal.ToString("C2")
    End Sub
End Class
