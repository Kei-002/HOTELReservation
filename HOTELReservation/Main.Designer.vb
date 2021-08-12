<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRooms = New System.Windows.Forms.Button()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.btnGuests = New System.Windows.Forms.Button()
        Me.btnReserve = New System.Windows.Forms.Button()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.btnCheckIn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapedPanel2 = New HOTELReservation.ShapedPanel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblSuite = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblDD = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblQueen = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblKing = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblQuad = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblTriple = New System.Windows.Forms.Label()
        Me.lblDouble = New System.Windows.Forms.Label()
        Me.lblSingle = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ShapedPanel4 = New HOTELReservation.ShapedPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ShapedPanel1 = New HOTELReservation.ShapedPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAvailRoom = New System.Windows.Forms.Label()
        Me.lblTotalOccupant = New System.Windows.Forms.Label()
        Me.lblCheckIns = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ResizeForm1 = New Guna.UI2.WinForms.Guna2ResizeForm(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ShapedPanel2.SuspendLayout()
        Me.ShapedPanel4.SuspendLayout()
        Me.ShapedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnRooms)
        Me.Panel2.Controls.Add(Me.logo)
        Me.Panel2.Controls.Add(Me.btnGuests)
        Me.Panel2.Controls.Add(Me.btnReserve)
        Me.Panel2.Controls.Add(Me.btnCheckOut)
        Me.Panel2.Controls.Add(Me.btnCheckIn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(153, 565)
        Me.Panel2.TabIndex = 1
        '
        'btnRooms
        '
        Me.btnRooms.FlatAppearance.BorderSize = 0
        Me.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRooms.Font = New System.Drawing.Font("Moon", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRooms.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRooms.Location = New System.Drawing.Point(0, 347)
        Me.btnRooms.Name = "btnRooms"
        Me.btnRooms.Size = New System.Drawing.Size(153, 45)
        Me.btnRooms.TabIndex = 2
        Me.btnRooms.Text = "Rooms"
        Me.btnRooms.UseVisualStyleBackColor = True
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(3, -16)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(145, 124)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 2
        Me.logo.TabStop = False
        '
        'btnGuests
        '
        Me.btnGuests.FlatAppearance.BorderSize = 0
        Me.btnGuests.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuests.Font = New System.Drawing.Font("Moon", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuests.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGuests.Location = New System.Drawing.Point(0, 296)
        Me.btnGuests.Name = "btnGuests"
        Me.btnGuests.Size = New System.Drawing.Size(153, 45)
        Me.btnGuests.TabIndex = 2
        Me.btnGuests.Text = "Guests"
        Me.btnGuests.UseVisualStyleBackColor = True
        '
        'btnReserve
        '
        Me.btnReserve.FlatAppearance.BorderSize = 0
        Me.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReserve.Font = New System.Drawing.Font("Moon", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReserve.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReserve.Location = New System.Drawing.Point(0, 245)
        Me.btnReserve.Name = "btnReserve"
        Me.btnReserve.Size = New System.Drawing.Size(153, 45)
        Me.btnReserve.TabIndex = 2
        Me.btnReserve.Text = "Reserve"
        Me.btnReserve.UseVisualStyleBackColor = True
        '
        'btnCheckOut
        '
        Me.btnCheckOut.FlatAppearance.BorderSize = 0
        Me.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckOut.Font = New System.Drawing.Font("Moon", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckOut.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCheckOut.Location = New System.Drawing.Point(0, 194)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(153, 45)
        Me.btnCheckOut.TabIndex = 2
        Me.btnCheckOut.Text = "Check Out"
        Me.btnCheckOut.UseVisualStyleBackColor = True
        '
        'btnCheckIn
        '
        Me.btnCheckIn.FlatAppearance.BorderSize = 0
        Me.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckIn.Font = New System.Drawing.Font("Moon", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckIn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCheckIn.Location = New System.Drawing.Point(0, 143)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.Size = New System.Drawing.Size(153, 45)
        Me.btnCheckIn.TabIndex = 2
        Me.btnCheckIn.Text = "Check in"
        Me.btnCheckIn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Moon", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(183, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dashboard"
        '
        'ShapedPanel2
        '
        Me.ShapedPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ShapedPanel2.BorderColor = System.Drawing.Color.White
        Me.ShapedPanel2.Controls.Add(Me.Guna2Button1)
        Me.ShapedPanel2.Controls.Add(Me.Label27)
        Me.ShapedPanel2.Controls.Add(Me.Label25)
        Me.ShapedPanel2.Controls.Add(Me.Label23)
        Me.ShapedPanel2.Controls.Add(Me.lblSuite)
        Me.ShapedPanel2.Controls.Add(Me.Label20)
        Me.ShapedPanel2.Controls.Add(Me.lblDD)
        Me.ShapedPanel2.Controls.Add(Me.Label18)
        Me.ShapedPanel2.Controls.Add(Me.lblQueen)
        Me.ShapedPanel2.Controls.Add(Me.Label10)
        Me.ShapedPanel2.Controls.Add(Me.lblKing)
        Me.ShapedPanel2.Controls.Add(Me.Label9)
        Me.ShapedPanel2.Controls.Add(Me.lblQuad)
        Me.ShapedPanel2.Controls.Add(Me.Label14)
        Me.ShapedPanel2.Controls.Add(Me.lblTriple)
        Me.ShapedPanel2.Controls.Add(Me.lblDouble)
        Me.ShapedPanel2.Controls.Add(Me.lblSingle)
        Me.ShapedPanel2.Controls.Add(Me.Label21)
        Me.ShapedPanel2.Edge = 50
        Me.ShapedPanel2.Location = New System.Drawing.Point(577, 103)
        Me.ShapedPanel2.Name = "ShapedPanel2"
        Me.ShapedPanel2.Size = New System.Drawing.Size(350, 443)
        Me.ShapedPanel2.TabIndex = 3
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BorderRadius = 16
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Font = New System.Drawing.Font("Moon", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(205, 19)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(129, 35)
        Me.Guna2Button1.TabIndex = 1
        Me.Guna2Button1.Text = "Modify v"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(42, 390)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(87, 21)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Suite Room"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(42, 340)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(112, 21)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Double Double"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(42, 294)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(98, 21)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Queen Room"
        '
        'lblSuite
        '
        Me.lblSuite.AutoSize = True
        Me.lblSuite.Font = New System.Drawing.Font("Comfortaa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuite.Location = New System.Drawing.Point(261, 386)
        Me.lblSuite.Name = "lblSuite"
        Me.lblSuite.Size = New System.Drawing.Size(21, 26)
        Me.lblSuite.TabIndex = 0
        Me.lblSuite.Text = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(42, 252)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 21)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "King Room"
        '
        'lblDD
        '
        Me.lblDD.AutoSize = True
        Me.lblDD.Font = New System.Drawing.Font("Comfortaa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDD.Location = New System.Drawing.Point(261, 336)
        Me.lblDD.Name = "lblDD"
        Me.lblDD.Size = New System.Drawing.Size(21, 26)
        Me.lblDD.TabIndex = 0
        Me.lblDD.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(42, 203)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(132, 21)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Quad Occupancy"
        '
        'lblQueen
        '
        Me.lblQueen.AutoSize = True
        Me.lblQueen.Font = New System.Drawing.Font("Comfortaa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQueen.Location = New System.Drawing.Point(261, 289)
        Me.lblQueen.Name = "lblQueen"
        Me.lblQueen.Size = New System.Drawing.Size(21, 26)
        Me.lblQueen.TabIndex = 0
        Me.lblQueen.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(42, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 21)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Triple Occupancy:"
        '
        'lblKing
        '
        Me.lblKing.AutoSize = True
        Me.lblKing.Font = New System.Drawing.Font("Comfortaa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKing.Location = New System.Drawing.Point(261, 248)
        Me.lblKing.Name = "lblKing"
        Me.lblKing.Size = New System.Drawing.Size(21, 26)
        Me.lblKing.TabIndex = 0
        Me.lblKing.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(42, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 21)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Double Occupancy:"
        '
        'lblQuad
        '
        Me.lblQuad.AutoSize = True
        Me.lblQuad.Font = New System.Drawing.Font("Comfortaa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuad.Location = New System.Drawing.Point(261, 199)
        Me.lblQuad.Name = "lblQuad"
        Me.lblQuad.Size = New System.Drawing.Size(21, 26)
        Me.lblQuad.TabIndex = 0
        Me.lblQuad.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(42, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(139, 21)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Single Occupancy:"
        '
        'lblTriple
        '
        Me.lblTriple.AutoSize = True
        Me.lblTriple.Font = New System.Drawing.Font("Comfortaa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTriple.Location = New System.Drawing.Point(261, 154)
        Me.lblTriple.Name = "lblTriple"
        Me.lblTriple.Size = New System.Drawing.Size(21, 26)
        Me.lblTriple.TabIndex = 0
        Me.lblTriple.Text = "0"
        '
        'lblDouble
        '
        Me.lblDouble.AutoSize = True
        Me.lblDouble.Font = New System.Drawing.Font("Comfortaa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDouble.Location = New System.Drawing.Point(261, 113)
        Me.lblDouble.Name = "lblDouble"
        Me.lblDouble.Size = New System.Drawing.Size(21, 26)
        Me.lblDouble.TabIndex = 0
        Me.lblDouble.Text = "0"
        '
        'lblSingle
        '
        Me.lblSingle.AutoSize = True
        Me.lblSingle.Font = New System.Drawing.Font("Comfortaa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSingle.Location = New System.Drawing.Point(261, 68)
        Me.lblSingle.Name = "lblSingle"
        Me.lblSingle.Size = New System.Drawing.Size(21, 26)
        Me.lblSingle.TabIndex = 0
        Me.lblSingle.Text = "0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Comfortaa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(41, 19)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(110, 26)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Room Rates"
        '
        'ShapedPanel4
        '
        Me.ShapedPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ShapedPanel4.BorderColor = System.Drawing.Color.White
        Me.ShapedPanel4.Controls.Add(Me.Label7)
        Me.ShapedPanel4.Controls.Add(Me.Label8)
        Me.ShapedPanel4.Controls.Add(Me.Label12)
        Me.ShapedPanel4.Controls.Add(Me.Label13)
        Me.ShapedPanel4.Controls.Add(Me.Label16)
        Me.ShapedPanel4.Edge = 50
        Me.ShapedPanel4.Location = New System.Drawing.Point(187, 332)
        Me.ShapedPanel4.Name = "ShapedPanel4"
        Me.ShapedPanel4.Size = New System.Drawing.Size(350, 214)
        Me.ShapedPanel4.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "On Service:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(42, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Available:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comfortaa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(293, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 26)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Comfortaa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(293, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 26)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Comfortaa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(41, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 26)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Employees"
        '
        'ShapedPanel1
        '
        Me.ShapedPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ShapedPanel1.BorderColor = System.Drawing.Color.White
        Me.ShapedPanel1.Controls.Add(Me.Label5)
        Me.ShapedPanel1.Controls.Add(Me.Label4)
        Me.ShapedPanel1.Controls.Add(Me.Label3)
        Me.ShapedPanel1.Controls.Add(Me.lblAvailRoom)
        Me.ShapedPanel1.Controls.Add(Me.lblTotalOccupant)
        Me.ShapedPanel1.Controls.Add(Me.lblCheckIns)
        Me.ShapedPanel1.Controls.Add(Me.Label2)
        Me.ShapedPanel1.Edge = 50
        Me.ShapedPanel1.Location = New System.Drawing.Point(187, 103)
        Me.ShapedPanel1.Name = "ShapedPanel1"
        Me.ShapedPanel1.Size = New System.Drawing.Size(350, 188)
        Me.ShapedPanel1.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Available Rooms:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total Occupants:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Checked In:"
        '
        'lblAvailRoom
        '
        Me.lblAvailRoom.AutoSize = True
        Me.lblAvailRoom.Font = New System.Drawing.Font("Comfortaa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailRoom.Location = New System.Drawing.Point(293, 129)
        Me.lblAvailRoom.Name = "lblAvailRoom"
        Me.lblAvailRoom.Size = New System.Drawing.Size(21, 26)
        Me.lblAvailRoom.TabIndex = 0
        Me.lblAvailRoom.Text = "0"
        '
        'lblTotalOccupant
        '
        Me.lblTotalOccupant.AutoSize = True
        Me.lblTotalOccupant.Font = New System.Drawing.Font("Comfortaa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalOccupant.Location = New System.Drawing.Point(293, 94)
        Me.lblTotalOccupant.Name = "lblTotalOccupant"
        Me.lblTotalOccupant.Size = New System.Drawing.Size(21, 26)
        Me.lblTotalOccupant.TabIndex = 0
        Me.lblTotalOccupant.Text = "0"
        '
        'lblCheckIns
        '
        Me.lblCheckIns.AutoSize = True
        Me.lblCheckIns.Font = New System.Drawing.Font("Comfortaa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckIns.Location = New System.Drawing.Point(293, 59)
        Me.lblCheckIns.Name = "lblCheckIns"
        Me.lblCheckIns.Size = New System.Drawing.Size(21, 26)
        Me.lblCheckIns.TabIndex = 0
        Me.lblCheckIns.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comfortaa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Status"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(948, 565)
        Me.Controls.Add(Me.ShapedPanel2)
        Me.Controls.Add(Me.ShapedPanel4)
        Me.Controls.Add(Me.ShapedPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.Panel2.ResumeLayout(False)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ShapedPanel2.ResumeLayout(False)
        Me.ShapedPanel2.PerformLayout()
        Me.ShapedPanel4.ResumeLayout(False)
        Me.ShapedPanel4.PerformLayout()
        Me.ShapedPanel1.ResumeLayout(False)
        Me.ShapedPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCheckIn As Button
    Friend WithEvents btnRooms As Button
    Friend WithEvents btnGuests As Button
    Friend WithEvents btnReserve As Button
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ShapedPanel1 As ShapedPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblAvailRoom As Label
    Friend WithEvents lblTotalOccupant As Label
    Friend WithEvents lblCheckIns As Label
    Friend WithEvents ShapedPanel2 As ShapedPanel
    Friend WithEvents Label14 As Label
    Friend WithEvents lblTriple As Label
    Friend WithEvents lblDouble As Label
    Friend WithEvents lblSingle As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ShapedPanel4 As ShapedPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblQuad As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lblSuite As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lblDD As Label
    Friend WithEvents lblQueen As Label
    Friend WithEvents lblKing As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents logo As PictureBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ResizeForm1 As Guna.UI2.WinForms.Guna2ResizeForm
End Class
