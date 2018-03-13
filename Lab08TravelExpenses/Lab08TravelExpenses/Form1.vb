Public Class Form1

    Dim intDays As Integer
    Dim decMealReimburse As Decimal
    Dim decMileReimburse As Decimal
    Dim decParkReimburse As Decimal
    Dim decTaxiFees As Decimal
    Dim decLodgeReimburse As Decimal
    Dim decTotalReimburse As Decimal
    Dim decNotReimburse As Decimal
    Dim decSaved As Decimal
    Dim decTotalExpesses As Decimal

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not Integer.TryParse(txtDays.Text, intDays) Then
            MessageBox.Show("Number of days not a valid whole number")
            Exit Sub
        ElseIf intDays < 1 Then
            MessageBox.Show("Number of days must be more than one")
            Exit Sub
        End If
        If Not CheckPosNum(txtAirfare.Text) Then
            MessageBox.Show("Airfare must be a valid posotive number")
            Exit Sub
        End If
        If Not CheckPosNum(txtMeals.Text) Then
            MessageBox.Show("Meals must be a valid posotive number")
            Exit Sub
        End If
        If Not CheckPosNum(txtParking.Text) Then
            MessageBox.Show("Parking fees must be a valid posotive number")
            Exit Sub
        End If
        If Not CheckPosNum(txtRental.Text) Then
            MessageBox.Show("Rental fees must be a valid posotive number")
            Exit Sub
        End If
        If Not CheckPosNum(txtMiles.Text) Then
            MessageBox.Show("Miles must be a valid posotive number")
            Exit Sub
        End If
        If Not CheckPosNum(txtTaxi.Text) Then
            MessageBox.Show("Taxi charges must be a valid posotive number")
            Exit Sub
        End If
        If Not CheckPosNum(txtRegistration.Text) Then
            MessageBox.Show("Registration fees must be a valid posotive number")
            Exit Sub
        End If
        If Not CheckPosNum(txtLodging.Text) Then
            MessageBox.Show("Lodging must be a valid posotive number")
            Exit Sub
        End If

        CalcTotalReimbersement()
        lblTotalExpenses.Text = CalcTotalExpenses.ToString("C2")
        lblTotalAllowed.Text = (intDays * 37 + intDays * 10 + intDays * 20 + intDays * 95).ToString("C2")
        lblTotalSaved.Text = CalcSaved.ToString("C2")
        lblTotalUnpaid.Text = Unallowed.ToString("C2")

    End Sub

    Private Function CheckPosNum(strcheck As String) As Boolean
        Dim dblx As Double
        If Not Double.TryParse(strcheck, dblx) Then
            Return False
        ElseIf dblx < 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function CalcMeals() As Decimal
        Decimal.TryParse(txtMeals.Text, decMealReimburse)
        If decMealReimburse > (intDays * 37) Then
            decMealReimburse = intDays * 37
        End If
        Return decMealReimburse
    End Function

    Private Function CalcMileage() As Decimal
        Decimal.TryParse(txtMiles.Text, decMileReimburse)
        decMileReimburse = decMileReimburse * CDec(0.27)
        Return decMileReimburse
    End Function

    Private Function CalcParkingFees() As Decimal
        Decimal.TryParse(txtParking.Text, decParkReimburse)
        If decParkReimburse > (intDays * 10) Then
            decParkReimburse = intDays * 10
        End If
        Return decParkReimburse
    End Function

    Private Function CalcTaxiFees() As Decimal
        Decimal.TryParse(txtTaxi.Text, decTaxiFees)
        If decTaxiFees > (intDays * 20) Then
            decTaxiFees = intDays * 20
        End If
        Return decTaxiFees
    End Function

    Private Function CalcLodging() As Decimal
        Decimal.TryParse(txtLodging.Text, decLodgeReimburse)
        If decLodgeReimburse > (intDays * 95) Then
            decLodgeReimburse = intDays * 95
        End If
        Return decLodgeReimburse
    End Function

    Private Function CalcTotalReimbersement() As Decimal
        decTotalReimburse = CalcMeals() + CalcMileage() + CalcParkingFees() + CalcTaxiFees() + CalcLodging()
        Return decTotalReimburse
    End Function

    Private Function Unallowed() As Decimal
        decNotReimburse = (intDays * 37 - decMealReimburse) + (intDays * 10 - decParkReimburse) + (intDays * 20 - decMileReimburse) + (intDays * 95 - decLodgeReimburse)
        Return decNotReimburse
    End Function

    Private Function CalcSaved() As Decimal
        decSaved = (decMealReimburse - intDays * 37) + (decParkReimburse - intDays * 10) + (decMileReimburse - intDays * 20) + (decLodgeReimburse - intDays * 95)
        Return decSaved
    End Function

    Private Function CalcTotalExpenses() As Decimal
        decTotalExpesses = CDec(txtAirfare.Text) + CDec(txtLodging.Text) + CDec(txtMeals.Text) + CDec(txtMiles.Text) + CDec(txtParking.Text) + CDec(txtRegistration.Text) + CDec(txtRental.Text) + CDec(txtTaxi.Text)
        Return decTotalExpesses
    End Function
End Class

