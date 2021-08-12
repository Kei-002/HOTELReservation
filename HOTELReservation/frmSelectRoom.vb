Imports System.Data.OleDb

Public Class frmSelectRoom
    Private Sub frmSelectRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dt = New DataTable("tblRoom")

        con.ConnectionString = dbcon
        con.Open()

        sql = "Select RoomID, RoomDesc as RoomType,Capacity, roomStatus as Status, Rate from Rooms,RoomType WHERE Rooms.RoomType = RoomType.RoomTypeID AND roomStatus = 'Available'"

        dbread = cmdSelectR(sql, con)


        dt.Load(dbread)
        'DataGridView1.DataSource = dt
        Guna2DataGridView1.DataSource = dt

        dbread.Dispose()
        con.Close()

    End Sub

    Private Sub Guna2DataGridView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Guna2DataGridView1.MouseDoubleClick
        frmCheckIn.txtRoomNumber.Text = Me.Guna2DataGridView1.CurrentRow.Cells("RoomID").Value
        frmCheckIn.txtRoomType.Text = Me.Guna2DataGridView1.CurrentRow.Cells("roomType").Value
        frmCheckIn.txtRoomRate.Text = Me.Guna2DataGridView1.CurrentRow.Cells("Rate").Value
        frmCheckIn.lblNoOfOccupancy.Text = Me.Guna2DataGridView1.CurrentRow.Cells("Capacity").Value

        frmReserve.txtRoomNumber.Text = Me.Guna2DataGridView1.CurrentRow.Cells("RoomID").Value
        frmReserve.txtRoomType.Text = Me.Guna2DataGridView1.CurrentRow.Cells("roomType").Value
        frmReserve.txtRoomRate.Text = Me.Guna2DataGridView1.CurrentRow.Cells("Rate").Value
        frmReserve.lblNoOfOccupancy.Text = Me.Guna2DataGridView1.CurrentRow.Cells("Capacity").Value
        dt.Clear()
        Me.Close()
    End Sub
End Class