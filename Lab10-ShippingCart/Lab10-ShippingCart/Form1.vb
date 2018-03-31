Public Class Form1
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Cart.Items.RemoveAt(Cart.SelectedIndex)
        decSubTotal = decSubTotal - Cost(CType(Cart.SelectedItem, String))
        updateTotal()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        Cart.Items.Clear()
        decSubTotal = 0
        lblShipping.Text = ""
        lblSubTotal.Text = ""
        lblTax.Text = ""
        lblTotal.Text = ""
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PrintBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintBooksToolStripMenuItem.Click
        Dim frmPrint As New frmPrintBooks
        frmPrint.ShowDialog()
    End Sub

    Private Sub AudioBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AudioBooksToolStripMenuItem.Click
        Dim frmAudio As New frmAudioBook
        frmAudio.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

    End Sub
End Class
