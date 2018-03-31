Public Class frmPrintBooks
    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        Form1.Cart.Items.Add(ListBox1.SelectedItem.ToString)
        decSubTotal = decSubTotal + Cost(CType(ListBox1.SelectedItem, String))
        updateTotal()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class