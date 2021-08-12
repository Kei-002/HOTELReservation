Public Class frmReserve
    Private Sub bttnCancel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bttnAddAdult_Click(sender As Object, e As EventArgs)
        totAdults = txtAdults.Text
        maxOccupancy = lblNoOfOccupancy.Text

        If totAdults < maxOccupancy Then
            txtAdults.Text = txtAdults.Text + 1
        End If
    End Sub

    Private Sub bttnSubAdult_Click(sender As Object, e As EventArgs)
        totAdults = txtAdults.Text
        maxOccupancy = lblNoOfOccupancy.Text

        If totAdults > 0 Then
            txtAdults.Text = txtAdults.Text - 1
        End If
    End Sub

    Private Sub bttnSearchRoom_Click(sender As Object, e As EventArgs)
        frmSelectRoom.Show()
    End Sub

    Private Sub bttnSearchGuest_Click(sender As Object, e As EventArgs)
        frmSelectGuest.Show()
    End Sub

    Private Sub dtCheckOutDate_ValueChanged(sender As Object, e As EventArgs)
        Dim T As TimeSpan = dtCheckOutDate.Value - Now
        If T.Days < 1 Then
            dtCheckOutDate.Text = Now.AddDays(1D)
            txtDaysNumber.Text = "1"
        Else
            txtDaysNumber.Text = T.Days + 1
        End If

        lblTotal.Text = Val(txtRoomRate.Text) * Val(txtDaysNumber.Text)
        txtSubTotal.Text = Val(txtRoomRate.Text) * Val(txtDaysNumber.Text)

    End Sub

    Private Sub frmReserve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmCheckIn.clear_text()
        Dim time As DateTime = DateTime.Now
        Dim format As String = "MM/d/yyyy"
        dtCheckInDate.Text = time
        dtCheckOutDate.Text = Now.AddDays(1D)
    End Sub
End Class