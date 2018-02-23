Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intNumber As Integer
        Dim intSum As Integer
        Dim intCounter As Integer
        If Integer.TryParse(InputBox("Enter a positive interger value"), intNumber) Then
            If intNumber >= 0 Then
                intCounter = intNumber
                While (0 <> intCounter)
                    intSum = intSum + intCounter
                    intCounter = intCounter - 1
                End While
                MessageBox.Show("The Sum of number 1 through " & intNumber & " is " & intSum)
            Else
                MessageBox.Show("integer must be positive")
            End If
        Else
            MessageBox.Show("You did not enter an integer")
        End If
    End Sub
End Class
