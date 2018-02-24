Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim intSpeed As Integer
        Dim intTime As Integer
        Dim intDistance As Integer
        Dim intCounter As Integer
        If Integer.TryParse(InputBox("Enter Vehicle Speed"), intSpeed) Then
            If Integer.TryParse(InputBox("Enter Time Traveled"), intTime) Then
                If intTime < 0 Then
                    ListBox1.Items.Clear()
                    ListBox1.Items.Add("Vehicle speed: " & intSpeed & " MPH")
                    ListBox1.Items.Add("Time Traveled: " & intTime & " hours")
                    ListBox1.Items.Add("Hours       Distance")
                    ListBox1.Items.Add("-----------------------------")
                    While (intCounter < intTime)
                        intDistance = intDistance + intSpeed
                        intCounter += 1
                        ListBox1.Items.Add(intCounter & "               " & intDistance)
                    End While
                    ListBox1.Items.Add("Total Distance: " & intDistance & "Miles")
                Else
                    MessageBox.Show("Time can not be negative")
                End If
            Else
                MessageBox.Show("Time entered is not a valid integer")
            End If
        Else
            MessageBox.Show("Speed entered is not a valid integer")
        End If
    End Sub
End Class
