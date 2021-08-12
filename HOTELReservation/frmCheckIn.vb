Imports System.Data.OleDb
Public Class frmCheckIn

    Dim i, j As Integer

    Private Sub frmCheckIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear_text()
        Dim time As DateTime = DateTime.Now
        Dim format As String = "MM/d/yyyy"
        dtCheckInDate.Text = time
        dtCheckOutDate.Text = Now.AddDays(1D)
    End Sub


    Public Sub clear_text()
        txtGuestName.Clear()
        txtRoomNumber.Clear()
        txtRoomType.Clear()
        txtRoomRate.Clear()
        'txtChildren.Text = "0"
        txtAdults.Text = "0"
        cboDiscount.Refresh()
        'txtAdvance.Clear()
        txtSubTotal.Clear()
        txtTotal.Clear()
        lblDiscountID.Text = ""
        lblDiscountRate.Text = ""
        lblGuestID.Text = ""
        'lblAdvancePayment.Text = ""
        lblNoOfOccupancy.Text = "0"

        Dim time As DateTime = DateTime.Now
        Dim format As String = "MM/d/yyyy"


        dtCheckOutDate.Text = Now.AddDays(1D)
    End Sub

    Public Sub bttnAddAdult_Click(sender As Object, e As EventArgs) Handles bttnAddAdult.Click
        totAdults = txtAdults.Text
        maxOccupancy = lblNoOfOccupancy.Text

        If totAdults < maxOccupancy Then
            txtAdults.Text = txtAdults.Text + 1
        End If

    End Sub

    Public Sub bttnSubAdult_Click(sender As Object, e As EventArgs) Handles bttnSubAdult.Click
        totAdults = txtAdults.Text
        maxOccupancy = lblNoOfOccupancy.Text

        If totAdults > 0 Then
            txtAdults.Text = txtAdults.Text - 1
        End If
    End Sub


    Public Sub bttnSearchRoom_Click(sender As Object, e As EventArgs) Handles bttnSearchRoom.Click
        frmSelectRoom.Show()
    End Sub

    Private Sub dtCheckOutDate_ValueChanged(sender As Object, e As EventArgs) Handles dtCheckOutDate.ValueChanged
        Dim T As TimeSpan = dtCheckOutDate.Value - dtCheckInDate.Value
        If T.Days < 1 Then
            dtCheckOutDate.Text = dtCheckInDate.Value.AddDays(1D)
            txtDaysNumber.Text = "1"
        Else
            txtDaysNumber.Text = T.Days
        End If

        lblTotal.Text = Val(txtRoomRate.Text) * Val(txtDaysNumber.Text)
        txtSubTotal.Text = Val(txtRoomRate.Text) * Val(txtDaysNumber.Text)


    End Sub



    Private Sub bttnSearchGuest_Click(sender As Object, e As EventArgs) Handles bttnSearchGuest.Click
        frmSelectGuest.Show()
    End Sub

    Private Sub bttnCancel_Click(sender As Object, e As EventArgs) Handles bttnCancel.Click
        Me.Close()
    End Sub

    Private Sub bttnCheckIn_Click(sender As Object, e As EventArgs) Handles bttnCheckIn.Click
        con.ConnectionString = dbcon


        Try
            con.Open()

            sql = "INSERT INTO Reservation(customerID, roomID, ReservationDate, InDate, OutDate, DayRange) 
                   VALUES (@cusID, @roomNum, @reserveDate, @inDate, @outDate, @Ranged)"


            cmd = New OleDbCommand(sql, con)
            cmd.Parameters.AddWithValue("@cusID", OleDbType.Integer).Value = lblGuestID.Text
            cmd.Parameters.AddWithValue("@roomNum", OleDbType.Integer).Value = txtRoomNumber.Text
            cmd.Parameters.AddWithValue("@reserveDate", OleDbType.Date).Value = Now.ToShortDateString
            cmd.Parameters.AddWithValue("@inDate", OleDbType.Date).Value = dtCheckInDate.Value.ToShortDateString
            cmd.Parameters.AddWithValue("@outDate", OleDbType.Date).Value = dtCheckOutDate.Value.ToShortDateString
            cmd.Parameters.AddWithValue("@Ranged", OleDbType.Integer).Value = txtDaysNumber.Text

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Data Saved")
            Else
                MsgBox("Data Save failed")
            End If


        Catch ex As Exception

            Throw ex
        End Try

        con.Close()

        clear_text()
    End Sub


End Class