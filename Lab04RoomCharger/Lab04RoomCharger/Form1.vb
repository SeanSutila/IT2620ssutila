Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDateToday.Text = Now.ToString("D")
        lblTimeToday.Text = Now.ToString("T")
    End Sub


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            lblRoomCharges.Text = CType(CDec(txtNights.Text) * CDec(txtNightlyCharge.Text), String)
            lblAddCharges.Text = CType(CDec(txtRoomService.Text) + CDec(txtTelephone.Text) + CDec(txtMisc.Text), String)
            lblSubtotal.Text = CType(CDec(lblRoomCharges.Text) + CDec(lblAddCharges.Text), String)
            lblTax.Text = CType(CDec(lblSubtotal.Text) * 0.08, String)
            lblTotal.Text = CType(CDec(lblSubtotal.Text) + CDec(lblTax.Text), String)
        Catch
            MessageBox.Show(“All input must be valid numeric values.”)
        End Try
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNights.Clear()
        txtNightlyCharge.Clear()
        txtRoomService.Clear()
        txtTelephone.Clear()
        txtMisc.Clear()
        lblRoomCharges.Text = String.Empty
        lblAddCharges.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty
        lblDateToday.Text = Now.ToString("D")
        lblTimeToday.Text = Now.ToString("T")
        txtNights.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
