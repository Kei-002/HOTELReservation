Public Class frmSelectGuest
    Private Sub frmSelectGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt = New DataTable("tblGuest")

        con.ConnectionString = dbcon
        con.Open()

        sql = "Select customerID as GuestID, cusName as Guest, cusPhoneNum as PhoneNum from Guest"

        dbread = cmdSelectR(sql, con)


        dt.Load(dbread)
        DataGridView1.DataSource = dt

        dbread.Dispose()
        con.Close()
    End Sub

    Private Sub DataGridView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDoubleClick
        frmCheckIn.lblGuestID.Text = Me.DataGridView1.CurrentRow.Cells("GuestID").Value
        frmCheckIn.txtGuestName.Text = Me.DataGridView1.CurrentRow.Cells("Guest").Value

        frmReserve.lblGuestID.Text = Me.DataGridView1.CurrentRow.Cells("GuestID").Value
        frmReserve.txtGuestName.Text = Me.DataGridView1.CurrentRow.Cells("Guest").Value
        Me.Close()
    End Sub


End Class