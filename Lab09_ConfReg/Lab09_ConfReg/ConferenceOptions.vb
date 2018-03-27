Public Class ConferenceOptions
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckBox1.Checked = True Then
            decTotal = decTotal + 895
            If CheckBox2.Checked = True Then
                decTotal = decTotal + 30
            End If
            If ListBox1.SelectedIndex <> -1 Then
                If ListBox1.SelectedIndex = 0 Then
                    decTotal = decTotal + 295
                ElseIf ListBox1.SelectedIndex = 1 Then
                    decTotal = decTotal + 295
                ElseIf ListBox1.SelectedIndex = 2 Then
                    decTotal = decTotal + 395
                ElseIf ListBox1.SelectedIndex = 3 Then
                    decTotal = decTotal + 395
                End If
            End If
        End If
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        ListBox1.SelectedIndex = -1
        decTotal = 0
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            ListBox1.Enabled = True
            CheckBox2.Enabled = True
        Else
            ListBox1.Enabled = False
            CheckBox2.Enabled = False
        End If
    End Sub
End Class