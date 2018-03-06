Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        If IsValid(txtPassword.Text) Then
            MessageBox.Show("Great Job")
        End If
    End Sub

    Private Function IsValid(strPassword As String) As Boolean
        If strPassword = String.Empty Then
            MessageBox.Show("Enter a password")
            Return False
        End If

        If strPassword.Length < 6 Then
            MessageBox.Show("Password must be 6 characters long")
            Return False
        End If
        Dim dblx As Double
        If Double.TryParse(strPassword, dblx) Then
            MessageBox.Show("Password must have at least one alphabetic letter")
            Return False
        End If
        Dim count As Integer = 0
        While (count < (strPassword.Length))
            If IsNumeric(strPassword.Substring(count, 1)) Then
                Return True
            End If
            count += 1
        End While
        If count >= strPassword.Length Then
            MessageBox.Show("Password must have at least on number in it")
            Return False
        End If
        Return True
    End Function

End Class
