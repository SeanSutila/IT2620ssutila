Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intA As Integer
        Dim intB As Integer
        Dim intC As Integer
        Try
            intA = CInt(txtClassA.Text)
            intB = CInt(txtClassB.Text)
            intC = CInt(txtClassC.Text)
        Catch ex As Exception
            MessageBox.Show("All input must be valid numeric values.")
        End Try
        lblClassA.Text = CType(intA * 15, String)
        lblClassB.Text = CType(intB * 12, String)
        lblClassC.Text = CType(intC * 9, String)
        lblRevenue.Text = CType(CInt(lblClassA.Text) + CInt(lblClassB.Text) + CInt(lblClassC.Text), String)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtClassA.Clear()
        txtClassB.Clear()
        txtClassC.Clear()
        lblClassA.Text = String.Empty
        lblClassB.Text = String.Empty
        lblClassC.Text = String.Empty
        lblRevenue.Text = String.Empty
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
