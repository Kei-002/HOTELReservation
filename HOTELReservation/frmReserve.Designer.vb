<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReserve
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bttnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.bttnCheckIn = New Guna.UI2.WinForms.Guna2Button()
        Me.bttnAddAdult = New System.Windows.Forms.Button()
        Me.bttnSubAdult = New System.Windows.Forms.Button()
        Me.txtAdults = New System.Windows.Forms.TextBox()
        Me.bttnSearchRoom = New System.Windows.Forms.Button()
        Me.bttnSearchGuest = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDaysNumber = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtCheckInDate = New System.Windows.Forms.DateTimePicker()
        Me.dtCheckOutDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRoomRate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRoomType = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRoomNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGuestName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTransID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDiscountRate = New System.Windows.Forms.Label()
        Me.lblDiscountID = New System.Windows.Forms.Label()
        Me.lblGuestID = New System.Windows.Forms.Label()
        Me.lblNoOfOccupancy = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bttnCancel
        '
        Me.bttnCancel.Animated = True
        Me.bttnCancel.AutoRoundedCorners = True
        Me.bttnCancel.BorderRadius = 15
        Me.bttnCancel.CheckedState.Parent = Me.bttnCancel
        Me.bttnCancel.CustomImages.Parent = Me.bttnCancel
        Me.bttnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.bttnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bttnCancel.ForeColor = System.Drawing.Color.White
        Me.bttnCancel.HoverState.Parent = Me.bttnCancel
        Me.bttnCancel.Location = New System.Drawing.Point(626, 310)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.ShadowDecoration.Parent = Me.bttnCancel
        Me.bttnCancel.Size = New System.Drawing.Size(98, 33)
        Me.bttnCancel.TabIndex = 140
        Me.bttnCancel.Text = "Cancel"
        '
        'bttnCheckIn
        '
        Me.bttnCheckIn.Animated = True
        Me.bttnCheckIn.AutoRoundedCorners = True
        Me.bttnCheckIn.BorderRadius = 15
        Me.bttnCheckIn.CheckedState.Parent = Me.bttnCheckIn
        Me.bttnCheckIn.CustomImages.Parent = Me.bttnCheckIn
        Me.bttnCheckIn.FillColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.bttnCheckIn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bttnCheckIn.ForeColor = System.Drawing.Color.White
        Me.bttnCheckIn.HoverState.Parent = Me.bttnCheckIn
        Me.bttnCheckIn.Location = New System.Drawing.Point(507, 310)
        Me.bttnCheckIn.Name = "bttnCheckIn"
        Me.bttnCheckIn.ShadowDecoration.Parent = Me.bttnCheckIn
        Me.bttnCheckIn.Size = New System.Drawing.Size(113, 33)
        Me.bttnCheckIn.TabIndex = 139
        Me.bttnCheckIn.Text = "Check In"
        '
        'bttnAddAdult
        '
        Me.bttnAddAdult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAddAdult.Location = New System.Drawing.Point(677, 109)
        Me.bttnAddAdult.Name = "bttnAddAdult"
        Me.bttnAddAdult.Size = New System.Drawing.Size(23, 25)
        Me.bttnAddAdult.TabIndex = 138
        Me.bttnAddAdult.Text = ">"
        Me.bttnAddAdult.UseVisualStyleBackColor = True
        '
        'bttnSubAdult
        '
        Me.bttnSubAdult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSubAdult.Location = New System.Drawing.Point(654, 109)
        Me.bttnSubAdult.Name = "bttnSubAdult"
        Me.bttnSubAdult.Size = New System.Drawing.Size(23, 25)
        Me.bttnSubAdult.TabIndex = 137
        Me.bttnSubAdult.Text = "<"
        Me.bttnSubAdult.UseVisualStyleBackColor = True
        '
        'txtAdults
        '
        Me.txtAdults.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtAdults.Font = New System.Drawing.Font("Comfortaa", 9.75!)
        Me.txtAdults.Location = New System.Drawing.Point(594, 110)
        Me.txtAdults.Multiline = True
        Me.txtAdults.Name = "txtAdults"
        Me.txtAdults.ReadOnly = True
        Me.txtAdults.Size = New System.Drawing.Size(51, 25)
        Me.txtAdults.TabIndex = 136
        Me.txtAdults.Text = "0"
        Me.txtAdults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bttnSearchRoom
        '
        Me.bttnSearchRoom.Location = New System.Drawing.Point(293, 145)
        Me.bttnSearchRoom.Name = "bttnSearchRoom"
        Me.bttnSearchRoom.Size = New System.Drawing.Size(30, 26)
        Me.bttnSearchRoom.TabIndex = 135
        Me.bttnSearchRoom.Text = "..."
        Me.bttnSearchRoom.UseVisualStyleBackColor = True
        '
        'bttnSearchGuest
        '
        Me.bttnSearchGuest.Location = New System.Drawing.Point(388, 113)
        Me.bttnSearchGuest.Name = "bttnSearchGuest"
        Me.bttnSearchGuest.Size = New System.Drawing.Size(30, 26)
        Me.bttnSearchGuest.TabIndex = 134
        Me.bttnSearchGuest.Text = "..."
        Me.bttnSearchGuest.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(595, 255)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(120, 25)
        Me.txtTotal.TabIndex = 126
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Comfortaa", 9.75!)
        Me.Label15.Location = New System.Drawing.Point(462, 258)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 21)
        Me.Label15.TabIndex = 133
        Me.Label15.Text = "Total Balance"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(595, 207)
        Me.txtSubTotal.Multiline = True
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(120, 25)
        Me.txtSubTotal.TabIndex = 123
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comfortaa", 9.75!)
        Me.Label11.Location = New System.Drawing.Point(462, 210)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 21)
        Me.Label11.TabIndex = 131
        Me.Label11.Text = "Sub Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comfortaa", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(462, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 21)
        Me.Label10.TabIndex = 130
        Me.Label10.Text = "No. Of Guests"
        '
        'txtDaysNumber
        '
        Me.txtDaysNumber.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtDaysNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDaysNumber.Location = New System.Drawing.Point(172, 296)
        Me.txtDaysNumber.Multiline = True
        Me.txtDaysNumber.Name = "txtDaysNumber"
        Me.txtDaysNumber.ReadOnly = True
        Me.txtDaysNumber.Size = New System.Drawing.Size(115, 25)
        Me.txtDaysNumber.TabIndex = 120
        Me.txtDaysNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(51, 300)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 21)
        Me.Label9.TabIndex = 129
        Me.Label9.Text = "No. Of Days"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(51, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 21)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "Check In Date"
        '
        'dtCheckInDate
        '
        Me.dtCheckInDate.CalendarFont = New System.Drawing.Font("Moon", 9.75!)
        Me.dtCheckInDate.Checked = False
        Me.dtCheckInDate.CustomFormat = "DD/mm/yyyy"
        Me.dtCheckInDate.Font = New System.Drawing.Font("Moon", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtCheckInDate.Location = New System.Drawing.Point(175, 241)
        Me.dtCheckInDate.Name = "dtCheckInDate"
        Me.dtCheckInDate.Size = New System.Drawing.Size(99, 22)
        Me.dtCheckInDate.TabIndex = 118
        '
        'dtCheckOutDate
        '
        Me.dtCheckOutDate.CalendarFont = New System.Drawing.Font("Moon", 9.75!)
        Me.dtCheckOutDate.Font = New System.Drawing.Font("Moon", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtCheckOutDate.Location = New System.Drawing.Point(175, 270)
        Me.dtCheckOutDate.Name = "dtCheckOutDate"
        Me.dtCheckOutDate.Size = New System.Drawing.Size(99, 22)
        Me.dtCheckOutDate.TabIndex = 119
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(51, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 21)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "Check Out Date"
        '
        'txtRoomRate
        '
        Me.txtRoomRate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRoomRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomRate.Location = New System.Drawing.Point(172, 207)
        Me.txtRoomRate.Multiline = True
        Me.txtRoomRate.Name = "txtRoomRate"
        Me.txtRoomRate.ReadOnly = True
        Me.txtRoomRate.Size = New System.Drawing.Size(115, 25)
        Me.txtRoomRate.TabIndex = 117
        Me.txtRoomRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 21)
        Me.Label6.TabIndex = 124
        Me.Label6.Text = "Room Rate"
        '
        'txtRoomType
        '
        Me.txtRoomType.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRoomType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomType.Location = New System.Drawing.Point(172, 176)
        Me.txtRoomType.Multiline = True
        Me.txtRoomType.Name = "txtRoomType"
        Me.txtRoomType.ReadOnly = True
        Me.txtRoomType.Size = New System.Drawing.Size(210, 25)
        Me.txtRoomType.TabIndex = 115
        Me.txtRoomType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 21)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "Room Type"
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRoomNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomNumber.Location = New System.Drawing.Point(172, 145)
        Me.txtRoomNumber.Multiline = True
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.ReadOnly = True
        Me.txtRoomNumber.Size = New System.Drawing.Size(115, 25)
        Me.txtRoomNumber.TabIndex = 113
        Me.txtRoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 21)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "Room Number"
        '
        'txtGuestName
        '
        Me.txtGuestName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtGuestName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestName.Location = New System.Drawing.Point(172, 114)
        Me.txtGuestName.Multiline = True
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.ReadOnly = True
        Me.txtGuestName.Size = New System.Drawing.Size(210, 25)
        Me.txtGuestName.TabIndex = 110
        Me.txtGuestName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 21)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "Guest Name"
        '
        'txtTransID
        '
        Me.txtTransID.BackColor = System.Drawing.Color.White
        Me.txtTransID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTransID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransID.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTransID.Location = New System.Drawing.Point(172, 83)
        Me.txtTransID.Multiline = True
        Me.txtTransID.Name = "txtTransID"
        Me.txtTransID.ReadOnly = True
        Me.txtTransID.Size = New System.Drawing.Size(115, 25)
        Me.txtTransID.TabIndex = 114
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 21)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Transaction ID"
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Moon", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 25)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Reserve Form"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(198, 434)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 145
        Me.lblTotal.Text = "Total"
        Me.lblTotal.Visible = False
        '
        'lblDiscountRate
        '
        Me.lblDiscountRate.AutoSize = True
        Me.lblDiscountRate.Location = New System.Drawing.Point(191, 411)
        Me.lblDiscountRate.Name = "lblDiscountRate"
        Me.lblDiscountRate.Size = New System.Drawing.Size(72, 13)
        Me.lblDiscountRate.TabIndex = 144
        Me.lblDiscountRate.Text = "DiscountRate"
        Me.lblDiscountRate.Visible = False
        '
        'lblDiscountID
        '
        Me.lblDiscountID.AutoSize = True
        Me.lblDiscountID.Location = New System.Drawing.Point(52, 457)
        Me.lblDiscountID.Name = "lblDiscountID"
        Me.lblDiscountID.Size = New System.Drawing.Size(60, 13)
        Me.lblDiscountID.TabIndex = 143
        Me.lblDiscountID.Text = "DiscountID"
        Me.lblDiscountID.Visible = False
        '
        'lblGuestID
        '
        Me.lblGuestID.AutoSize = True
        Me.lblGuestID.Location = New System.Drawing.Point(52, 411)
        Me.lblGuestID.Name = "lblGuestID"
        Me.lblGuestID.Size = New System.Drawing.Size(46, 13)
        Me.lblGuestID.TabIndex = 142
        Me.lblGuestID.Text = "GuestID"
        Me.lblGuestID.Visible = False
        '
        'lblNoOfOccupancy
        '
        Me.lblNoOfOccupancy.AutoSize = True
        Me.lblNoOfOccupancy.Location = New System.Drawing.Point(52, 433)
        Me.lblNoOfOccupancy.Name = "lblNoOfOccupancy"
        Me.lblNoOfOccupancy.Size = New System.Drawing.Size(87, 13)
        Me.lblNoOfOccupancy.TabIndex = 141
        Me.lblNoOfOccupancy.Text = "NoOfOccupancy"
        Me.lblNoOfOccupancy.Visible = False
        '
        'frmReserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 368)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblDiscountRate)
        Me.Controls.Add(Me.lblDiscountID)
        Me.Controls.Add(Me.lblGuestID)
        Me.Controls.Add(Me.lblNoOfOccupancy)
        Me.Controls.Add(Me.bttnCancel)
        Me.Controls.Add(Me.bttnCheckIn)
        Me.Controls.Add(Me.bttnAddAdult)
        Me.Controls.Add(Me.bttnSubAdult)
        Me.Controls.Add(Me.txtAdults)
        Me.Controls.Add(Me.bttnSearchRoom)
        Me.Controls.Add(Me.bttnSearchGuest)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDaysNumber)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtCheckInDate)
        Me.Controls.Add(Me.dtCheckOutDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtRoomRate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRoomType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRoomNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtGuestName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTransID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmReserve"
        Me.Text = "frmReserve"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bttnCheckIn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bttnAddAdult As Button
    Friend WithEvents bttnSubAdult As Button
    Friend WithEvents txtAdults As TextBox
    Friend WithEvents bttnSearchRoom As Button
    Friend WithEvents bttnSearchGuest As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDaysNumber As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dtCheckInDate As DateTimePicker
    Friend WithEvents dtCheckOutDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRoomRate As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRoomType As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRoomNumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGuestName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTransID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDiscountRate As Label
    Friend WithEvents lblDiscountID As Label
    Friend WithEvents lblGuestID As Label
    Friend WithEvents lblNoOfOccupancy As Label
End Class
