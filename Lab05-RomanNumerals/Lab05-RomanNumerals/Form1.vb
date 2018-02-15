Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Select Case CInt(txtInt.Text)
            Case 1
                lblRomanNum.Text = "I"
            Case 2
                lblRomanNum.Text = "II"
            Case 3
                lblRomanNum.Text = "III"
            Case 4
                lblRomanNum.Text = "IV"
            Case 5
                lblRomanNum.Text = "V"
            Case 6
                lblRomanNum.Text = "VI"
            Case 7
                lblRomanNum.Text = "VI"
            Case 8
                lblRomanNum.Text = "VII"
            Case 9
                lblRomanNum.Text = "IX"
            Case 10
                lblRomanNum.Text = "X"
            Case Else
                lblRomanNum.Text = "Invalid Integer"
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
