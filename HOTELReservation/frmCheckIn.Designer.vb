<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCheckIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.bttnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.bttnCheckIn = New Guna.UI2.WinForms.Guna2Button()
        Me.bttnAddAdult = New System.Windows.Forms.Button()
        Me.bttnSubAdult = New System.Windows.Forms.Button()
        Me.txtAdults = New System.Windows.Forms.TextBox()
        Me.bttnSearchRoom = New System.Windows.Forms.Button()
        Me.bttnSearchGuest = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboDiscount = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.label12 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDiscountRate = New System.Windows.Forms.Label()
        Me.lblDiscountID = New System.Windows.Forms.Label()
        Me.lblGuestID = New System.Windows.Forms.Label()
        Me.lblNoOfOccupancy = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(774, 376)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.bttnCancel)
        Me.TabPage1.Controls.Add(Me.bttnCheckIn)
        Me.TabPage1.Controls.Add(Me.bttnAddAdult)
        Me.TabPage1.Controls.Add(Me.bttnSubAdult)
        Me.TabPage1.Controls.Add(Me.txtAdults)
        Me.TabPage1.Controls.Add(Me.bttnSearchRoom)
        Me.TabPage1.Controls.Add(Me.bttnSearchGuest)
        Me.TabPage1.Controls.Add(Me.txtTotal)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.cboDiscount)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.txtSubTotal)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtDaysNumber)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.dtCheckInDate)
        Me.TabPage1.Controls.Add(Me.dtCheckOutDate)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtRoomRate)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtRoomType)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtRoomNumber)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtGuestName)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtTransID)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Font = New System.Drawing.Font("Comfortaa", 8.25!)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(766, 350)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        Me.bttnCancel.Location = New System.Drawing.Point(609, 299)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.ShadowDecoration.Parent = Me.bttnCancel
        Me.bttnCancel.Size = New System.Drawing.Size(98, 33)
        Me.bttnCancel.TabIndex = 109
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
        Me.bttnCheckIn.Location = New System.Drawing.Point(490, 299)
        Me.bttnCheckIn.Name = "bttnCheckIn"
        Me.bttnCheckIn.ShadowDecoration.Parent = Me.bttnCheckIn
        Me.bttnCheckIn.Size = New System.Drawing.Size(113, 33)
        Me.bttnCheckIn.TabIndex = 109
        Me.bttnCheckIn.Text = "Check In"
        '
        'bttnAddAdult
        '
        Me.bttnAddAdult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAddAdult.Location = New System.Drawing.Point(660, 98)
        Me.bttnAddAdult.Name = "bttnAddAdult"
        Me.bttnAddAdult.Size = New System.Drawing.Size(23, 25)
        Me.bttnAddAdult.TabIndex = 108
        Me.bttnAddAdult.Text = ">"
        Me.bttnAddAdult.UseVisualStyleBackColor = True
        '
        'bttnSubAdult
        '
        Me.bttnSubAdult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSubAdult.Location = New System.Drawing.Point(637, 98)
        Me.bttnSubAdult.Name = "bttnSubAdult"
        Me.bttnSubAdult.Size = New System.Drawing.Size(23, 25)
        Me.bttnSubAdult.TabIndex = 106
        Me.bttnSubAdult.Text = "<"
        Me.bttnSubAdult.UseVisualStyleBackColor = True
        '
        'txtAdults
        '
        Me.txtAdults.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtAdults.Font = New System.Drawing.Font("Comfortaa", 9.75!)
        Me.txtAdults.Location = New System.Drawing.Point(577, 99)
        Me.txtAdults.Multiline = True
        Me.txtAdults.Name = "txtAdults"
        Me.txtAdults.ReadOnly = True
        Me.txtAdults.Size = New System.Drawing.Size(51, 25)
        Me.txtAdults.TabIndex = 105
        Me.txtAdults.Text = "0"
        Me.txtAdults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bttnSearchRoom
        '
        Me.bttnSearchRoom.Location = New System.Drawing.Point(276, 134)
        Me.bttnSearchRoom.Name = "bttnSearchRoom"
        Me.bttnSearchRoom.Size = New System.Drawing.Size(30, 26)
        Me.bttnSearchRoom.TabIndex = 103
        Me.bttnSearchRoom.Text = "..."
        Me.bttnSearchRoom.UseVisualStyleBackColor = True
        '
        'bttnSearchGuest
        '
        Me.bttnSearchGuest.Location = New System.Drawing.Point(371, 102)
        Me.bttnSearchGuest.Name = "bttnSearchGuest"
        Me.bttnSearchGuest.Size = New System.Drawing.Size(30, 26)
        Me.bttnSearchGuest.TabIndex = 102
        Me.bttnSearchGuest.Text = "..."
        Me.bttnSearchGuest.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(578, 244)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(120, 25)
        Me.txtTotal.TabIndex = 90
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Comfortaa", 9.75!)
        Me.Label15.Location = New System.Drawing.Point(445, 247)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 21)
        Me.Label15.TabIndex = 99
        Me.Label15.Text = "Total Balance"
        '
        'cboDiscount
        '
        Me.cboDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiscount.FormattingEnabled = True
        Me.cboDiscount.Location = New System.Drawing.Point(579, 135)
        Me.cboDiscount.Name = "cboDiscount"
        Me.cboDiscount.Size = New System.Drawing.Size(119, 26)
        Me.cboDiscount.TabIndex = 88
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Comfortaa", 9.75!)
        Me.Label13.Location = New System.Drawing.Point(444, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 21)
        Me.Label13.TabIndex = 97
        Me.Label13.Text = "Discount Type"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(578, 196)
        Me.txtSubTotal.Multiline = True
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(120, 25)
        Me.txtSubTotal.TabIndex = 86
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comfortaa", 9.75!)
        Me.Label11.Location = New System.Drawing.Point(445, 199)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 21)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = "Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comfortaa", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(445, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 21)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "No. Of Guests"
        '
        'txtDaysNumber
        '
        Me.txtDaysNumber.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtDaysNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDaysNumber.Location = New System.Drawing.Point(155, 285)
        Me.txtDaysNumber.Multiline = True
        Me.txtDaysNumber.Name = "txtDaysNumber"
        Me.txtDaysNumber.ReadOnly = True
        Me.txtDaysNumber.Size = New System.Drawing.Size(115, 25)
        Me.txtDaysNumber.TabIndex = 83
        Me.txtDaysNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 289)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 21)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "No. Of Days"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 21)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Check In Date"
        '
        'dtCheckInDate
        '
        Me.dtCheckInDate.CalendarFont = New System.Drawing.Font("Moon", 9.75!)
        Me.dtCheckInDate.Checked = False
        Me.dtCheckInDate.CustomFormat = "DD/mm/yyyy"
        Me.dtCheckInDate.Font = New System.Drawing.Font("Moon", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtCheckInDate.Location = New System.Drawing.Point(158, 230)
        Me.dtCheckInDate.Name = "dtCheckInDate"
        Me.dtCheckInDate.Size = New System.Drawing.Size(99, 22)
        Me.dtCheckInDate.TabIndex = 82
        '
        'dtCheckOutDate
        '
        Me.dtCheckOutDate.CalendarFont = New System.Drawing.Font("Moon", 9.75!)
        Me.dtCheckOutDate.Font = New System.Drawing.Font("Moon", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtCheckOutDate.Location = New System.Drawing.Point(158, 259)
        Me.dtCheckOutDate.Name = "dtCheckOutDate"
        Me.dtCheckOutDate.Size = New System.Drawing.Size(99, 22)
        Me.dtCheckOutDate.TabIndex = 82
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 21)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Check Out Date"
        '
        'txtRoomRate
        '
        Me.txtRoomRate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRoomRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomRate.Location = New System.Drawing.Point(155, 196)
        Me.txtRoomRate.Multiline = True
        Me.txtRoomRate.Name = "txtRoomRate"
        Me.txtRoomRate.ReadOnly = True
        Me.txtRoomRate.Size = New System.Drawing.Size(115, 25)
        Me.txtRoomRate.TabIndex = 81
        Me.txtRoomRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 21)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Room Rate"
        '
        'txtRoomType
        '
        Me.txtRoomType.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRoomType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomType.Location = New System.Drawing.Point(155, 165)
        Me.txtRoomType.Multiline = True
        Me.txtRoomType.Name = "txtRoomType"
        Me.txtRoomType.ReadOnly = True
        Me.txtRoomType.Size = New System.Drawing.Size(210, 25)
        Me.txtRoomType.TabIndex = 79
        Me.txtRoomType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 21)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Room Type"
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRoomNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomNumber.Location = New System.Drawing.Point(155, 134)
        Me.txtRoomNumber.Multiline = True
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.ReadOnly = True
        Me.txtRoomNumber.Size = New System.Drawing.Size(115, 25)
        Me.txtRoomNumber.TabIndex = 77
        Me.txtRoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 21)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Room Number"
        '
        'txtGuestName
        '
        Me.txtGuestName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtGuestName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestName.Location = New System.Drawing.Point(155, 103)
        Me.txtGuestName.Multiline = True
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.ReadOnly = True
        Me.txtGuestName.Size = New System.Drawing.Size(210, 25)
        Me.txtGuestName.TabIndex = 74
        Me.txtGuestName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 21)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Guest Name"
        '
        'txtTransID
        '
        Me.txtTransID.BackColor = System.Drawing.Color.White
        Me.txtTransID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTransID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransID.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTransID.Location = New System.Drawing.Point(155, 72)
        Me.txtTransID.Multiline = True
        Me.txtTransID.Name = "txtTransID"
        Me.txtTransID.ReadOnly = True
        Me.txtTransID.Size = New System.Drawing.Size(115, 25)
        Me.txtTransID.TabIndex = 78
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 21)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Transaction ID"
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Moon", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 25)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Reserve Form"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Guna2DataGridView1)
        Me.TabPage2.Controls.Add(Me.label12)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(766, 350)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Guna2DataGridView1
        '
        Me.Guna2DataGridView1.AllowUserToAddRows = False
        Me.Guna2DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.Guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Guna2DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.Guna2DataGridView1.ColumnHeadersHeight = 4
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle12
        Me.Guna2DataGridView1.EnableHeadersVisualStyles = False
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(56, 67)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.ReadOnly = True
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(654, 251)
        Me.Guna2DataGridView1.TabIndex = 2
        Me.Guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = True
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Moon", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(283, 32)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(158, 22)
        Me.label12.TabIndex = 1
        Me.label12.Text = "Check in List"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(169, 493)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "Total"
        Me.lblTotal.Visible = False
        '
        'lblDiscountRate
        '
        Me.lblDiscountRate.AutoSize = True
        Me.lblDiscountRate.Location = New System.Drawing.Point(162, 470)
        Me.lblDiscountRate.Name = "lblDiscountRate"
        Me.lblDiscountRate.Size = New System.Drawing.Size(72, 13)
        Me.lblDiscountRate.TabIndex = 9
        Me.lblDiscountRate.Text = "DiscountRate"
        Me.lblDiscountRate.Visible = False
        '
        'lblDiscountID
        '
        Me.lblDiscountID.AutoSize = True
        Me.lblDiscountID.Location = New System.Drawing.Point(23, 516)
        Me.lblDiscountID.Name = "lblDiscountID"
        Me.lblDiscountID.Size = New System.Drawing.Size(60, 13)
        Me.lblDiscountID.TabIndex = 8
        Me.lblDiscountID.Text = "DiscountID"
        Me.lblDiscountID.Visible = False
        '
        'lblGuestID
        '
        Me.lblGuestID.AutoSize = True
        Me.lblGuestID.Location = New System.Drawing.Point(23, 470)
        Me.lblGuestID.Name = "lblGuestID"
        Me.lblGuestID.Size = New System.Drawing.Size(46, 13)
        Me.lblGuestID.TabIndex = 7
        Me.lblGuestID.Text = "GuestID"
        Me.lblGuestID.Visible = False
        '
        'lblNoOfOccupancy
        '
        Me.lblNoOfOccupancy.AutoSize = True
        Me.lblNoOfOccupancy.Location = New System.Drawing.Point(23, 492)
        Me.lblNoOfOccupancy.Name = "lblNoOfOccupancy"
        Me.lblNoOfOccupancy.Size = New System.Drawing.Size(87, 13)
        Me.lblNoOfOccupancy.TabIndex = 6
        Me.lblNoOfOccupancy.Text = "NoOfOccupancy"
        Me.lblNoOfOccupancy.Visible = False
        '
        'frmCheckIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(795, 402)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblDiscountRate)
        Me.Controls.Add(Me.lblDiscountID)
        Me.Controls.Add(Me.lblGuestID)
        Me.Controls.Add(Me.lblNoOfOccupancy)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCheckIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCheckIn"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents bttnAddAdult As Button
    Friend WithEvents bttnSubAdult As Button
    Friend WithEvents txtAdults As TextBox
    Friend WithEvents bttnSearchRoom As Button
    Friend WithEvents bttnSearchGuest As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cboDiscount As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDaysNumber As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
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
    Friend WithEvents dtCheckInDate As DateTimePicker
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDiscountRate As Label
    Friend WithEvents lblDiscountID As Label
    Friend WithEvents lblGuestID As Label
    Friend WithEvents lblNoOfOccupancy As Label
    Friend WithEvents label12 As Label
    Friend WithEvents bttnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bttnCheckIn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
End Class
