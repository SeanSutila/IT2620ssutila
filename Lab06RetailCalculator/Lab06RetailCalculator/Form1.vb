Public Class Form1

    Dim dblCost As Double
    Dim dblMarkup As Double
    Dim dblPrice As Double

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        If CheckPosNum(txtCost.Text) And CheckPosNum(txtMarkup.Text) Then
            dblCost = CDbl(txtCost.Text)
            dblMarkup = CDbl(txtMarkup.Text)
            dblPrice = CalculateRetail()
            lblRetailPrice.Text = dblPrice.ToString("C2")
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Public Function CheckPosNum(strcheck As String) As Boolean
        Dim dblx As Double
        If Not Double.TryParse(strcheck, dblx) Then
            MessageBox.Show("You must enter an valid number")
            Return False
        ElseIf Not dblx > 0 Then
            MessageBox.Show("Number entered must be posotive")
            Return False
        Else
            Return True
        End If
    End Function

    Public Function CalculateRetail() As Double
        Return dblCost + (dblCost * (dblMarkup / 100))
    End Function

End Class
