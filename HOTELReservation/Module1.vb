Imports System.Data.OleDb
Module Module1

    Public da As OleDbDataAdapter
    Public ds As New DataSet 'Temporarily Stores Data'

    Public sql, sql1 As String
    Public cmd, cmd1 As OleDbCommand
    Public dt As New DataTable

    Public dr As OleDbDataReader
    Public dbread As OleDbDataReader

    Public dbcon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Shimi\Documents\hoteloooo\HotelDB.accdb"
    Public con As New OleDbConnection


    Public totAdults As Integer
    Public maxOccupancy As Integer



    Public Function cmdSelectR(ByVal sql As String, ByVal con As OleDbConnection)
        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        Return dr
    End Function
End Module
