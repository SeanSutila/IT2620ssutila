Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As Integer
        Dim B As Integer

        If Integer.TryParse(txtA.Text, A) Then
            If Integer.TryParse(txtB.Text, B) Then
                If A > B Then
                    lblOutput.Text = "A is Larger."
                ElseIf B > A Then
                    lblOutput.Text = "B is Larger."
                ElseIf A = B Then
                    lblOutput.Text = "A and B equal."
                End If
            Else
                lblOutput.Text = "B is not an integer."
            End If
        Else
            lblOutput.Text = "A is not an integer."
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
