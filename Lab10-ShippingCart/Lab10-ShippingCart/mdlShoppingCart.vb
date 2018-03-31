Module mdlShoppingCart
    Public decSubTotal As Decimal

    Public Function Cost(Item As String) As Decimal
        If Item = "Learn Calculus in One Day (Audio)" Then
            Return CDec(29.95)
        ElseIf Item = "Relaxation Techniques (Audio)" Then
            Return CDec(11.5)
        ElseIf Item = "The History of Scotland (Audio)" Then
            Return CDec(14.5)
        ElseIf Item = "The Science of Body Language (Audio)" Then
            Return CDec(12.95)
        ElseIf Item = "I Did It Your Way (Print)" Then
            Return CDec(11.95)
        ElseIf Item = "The History of Scotland (Print)" Then
            Return CDec(14.5)
        ElseIf Item = "Learn Calculus in One Day (Print)" Then
            Return CDec(29.95)
        ElseIf Item = "Feel the Stress (Print)" Then
            Return CDec(18.5)
        End If
        Return 0
    End Function

    Public Sub updateTotal()
        Form1.lblSubTotal.Text = decSubTotal.ToString("C2")
        Dim decTax As Decimal
        decTax = decSubTotal * CDec(0.06)
        Form1.lblTax.Text = decTax.ToString("C2")
        Dim decShipping As Decimal
        decShipping = Form1.Cart.Items.Count * 2
        Form1.lblShipping = decShipping.ToString("C2")
        Dim decTotal As Decimal
        decTotal = decSubTotal + decTax + decShipping
        Form1.lblTotal = decTotal.ToString("C2")
    End Sub
End Module
