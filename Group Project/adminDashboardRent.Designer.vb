<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminDashboardRent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminDashboardRent))
        Me.dgvUserList = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picManageUsers = New System.Windows.Forms.PictureBox()
        Me.picRent = New System.Windows.Forms.PictureBox()
        Me.picRentals = New System.Windows.Forms.PictureBox()
        Me.picManageCatalog = New System.Windows.Forms.PictureBox()
        Me.btnRent = New System.Windows.Forms.Button()
        Me.btnRentSignOut = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picSignupLogo = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRentEmailAdress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbSelectCar = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtRentFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtReturnOn = New System.Windows.Forms.DateTimePicker()
        Me.btnLoadCars = New System.Windows.Forms.Button()
        Me.txtRentDuration = New System.Windows.Forms.NumericUpDown()
        Me.txtRentalRate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRentTotalCost = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvUserList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.picManageUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRentals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picManageCatalog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picSignupLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRentDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUserList
        '
        Me.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserList.Location = New System.Drawing.Point(558, 72)
        Me.dgvUserList.Name = "dgvUserList"
        Me.dgvUserList.Size = New System.Drawing.Size(487, 438)
        Me.dgvUserList.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(84, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 15)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Rent:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.picManageUsers)
        Me.Panel2.Controls.Add(Me.picRent)
        Me.Panel2.Controls.Add(Me.picRentals)
        Me.Panel2.Controls.Add(Me.picManageCatalog)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 60)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(69, 605)
        Me.Panel2.TabIndex = 47
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Argentum Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 253)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 24)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Manage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Users"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Argentum Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 24)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Manage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Catalog"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Argentum Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(17, 89)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 12)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Rent"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Argentum Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 12)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Rentals"
        '
        'picManageUsers
        '
        Me.picManageUsers.BackColor = System.Drawing.Color.Transparent
        Me.picManageUsers.BackgroundImage = CType(resources.GetObject("picManageUsers.BackgroundImage"), System.Drawing.Image)
        Me.picManageUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picManageUsers.Location = New System.Drawing.Point(14, 281)
        Me.picManageUsers.Name = "picManageUsers"
        Me.picManageUsers.Size = New System.Drawing.Size(41, 41)
        Me.picManageUsers.TabIndex = 5
        Me.picManageUsers.TabStop = False
        '
        'picRent
        '
        Me.picRent.BackColor = System.Drawing.Color.Transparent
        Me.picRent.BackgroundImage = CType(resources.GetObject("picRent.BackgroundImage"), System.Drawing.Image)
        Me.picRent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picRent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picRent.Location = New System.Drawing.Point(14, 108)
        Me.picRent.Name = "picRent"
        Me.picRent.Size = New System.Drawing.Size(41, 41)
        Me.picRent.TabIndex = 6
        Me.picRent.TabStop = False
        '
        'picRentals
        '
        Me.picRentals.BackColor = System.Drawing.Color.Transparent
        Me.picRentals.BackgroundImage = CType(resources.GetObject("picRentals.BackgroundImage"), System.Drawing.Image)
        Me.picRentals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picRentals.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picRentals.Location = New System.Drawing.Point(13, 32)
        Me.picRentals.Name = "picRentals"
        Me.picRentals.Size = New System.Drawing.Size(41, 41)
        Me.picRentals.TabIndex = 6
        Me.picRentals.TabStop = False
        '
        'picManageCatalog
        '
        Me.picManageCatalog.BackColor = System.Drawing.Color.Transparent
        Me.picManageCatalog.BackgroundImage = CType(resources.GetObject("picManageCatalog.BackgroundImage"), System.Drawing.Image)
        Me.picManageCatalog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picManageCatalog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picManageCatalog.Location = New System.Drawing.Point(14, 194)
        Me.picManageCatalog.Name = "picManageCatalog"
        Me.picManageCatalog.Size = New System.Drawing.Size(41, 41)
        Me.picManageCatalog.TabIndex = 5
        Me.picManageCatalog.TabStop = False
        '
        'btnRent
        '
        Me.btnRent.BackColor = System.Drawing.Color.Black
        Me.btnRent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRent.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRent.ForeColor = System.Drawing.Color.White
        Me.btnRent.Location = New System.Drawing.Point(350, 536)
        Me.btnRent.Name = "btnRent"
        Me.btnRent.Size = New System.Drawing.Size(121, 39)
        Me.btnRent.TabIndex = 45
        Me.btnRent.Text = "RENT"
        Me.btnRent.UseVisualStyleBackColor = False
        '
        'btnRentSignOut
        '
        Me.btnRentSignOut.BackColor = System.Drawing.Color.Gray
        Me.btnRentSignOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRentSignOut.ForeColor = System.Drawing.Color.White
        Me.btnRentSignOut.Location = New System.Drawing.Point(970, 12)
        Me.btnRentSignOut.Name = "btnRentSignOut"
        Me.btnRentSignOut.Size = New System.Drawing.Size(75, 35)
        Me.btnRentSignOut.TabIndex = 3
        Me.btnRentSignOut.Text = "Sign Out"
        Me.btnRentSignOut.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.btnRentSignOut)
        Me.Panel1.Controls.Add(Me.picSignupLogo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Argentum Sans Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1067, 60)
        Me.Panel1.TabIndex = 46
        '
        'picSignupLogo
        '
        Me.picSignupLogo.BackColor = System.Drawing.Color.Transparent
        Me.picSignupLogo.BackgroundImage = CType(resources.GetObject("picSignupLogo.BackgroundImage"), System.Drawing.Image)
        Me.picSignupLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picSignupLogo.Location = New System.Drawing.Point(540, 0)
        Me.picSignupLogo.Name = "picSignupLogo"
        Me.picSignupLogo.Size = New System.Drawing.Size(83, 60)
        Me.picSignupLogo.TabIndex = 7
        Me.picSignupLogo.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(162, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Select car"
        '
        'txtRentEmailAdress
        '
        Me.txtRentEmailAdress.Font = New System.Drawing.Font("Argentum Sans Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRentEmailAdress.Location = New System.Drawing.Point(295, 165)
        Me.txtRentEmailAdress.Multiline = True
        Me.txtRentEmailAdress.Name = "txtRentEmailAdress"
        Me.txtRentEmailAdress.Size = New System.Drawing.Size(245, 32)
        Me.txtRentEmailAdress.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(162, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 15)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Email address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(162, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 15)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Rent from"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(162, 301)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 15)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Return on"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(162, 367)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 15)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Rent duration"
        '
        'cmbSelectCar
        '
        Me.cmbSelectCar.BackColor = System.Drawing.SystemColors.Info
        Me.cmbSelectCar.FormattingEnabled = True
        Me.cmbSelectCar.Location = New System.Drawing.Point(295, 115)
        Me.cmbSelectCar.Name = "cmbSelectCar"
        Me.cmbSelectCar.Size = New System.Drawing.Size(245, 23)
        Me.cmbSelectCar.TabIndex = 51
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(691, -142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 39)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Load Users"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dtRentFrom
        '
        Me.dtRentFrom.CustomFormat = "yyyy-MM-dd hh:mm"
        Me.dtRentFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtRentFrom.Location = New System.Drawing.Point(295, 237)
        Me.dtRentFrom.Name = "dtRentFrom"
        Me.dtRentFrom.ShowUpDown = True
        Me.dtRentFrom.Size = New System.Drawing.Size(245, 22)
        Me.dtRentFrom.TabIndex = 55
        '
        'dtReturnOn
        '
        Me.dtReturnOn.CustomFormat = "yyyy-MM-dd hh:mm"
        Me.dtReturnOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtReturnOn.Location = New System.Drawing.Point(295, 295)
        Me.dtReturnOn.Name = "dtReturnOn"
        Me.dtReturnOn.ShowUpDown = True
        Me.dtReturnOn.Size = New System.Drawing.Size(245, 22)
        Me.dtReturnOn.TabIndex = 55
        '
        'btnLoadCars
        '
        Me.btnLoadCars.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnLoadCars.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadCars.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadCars.ForeColor = System.Drawing.Color.White
        Me.btnLoadCars.Location = New System.Drawing.Point(729, 536)
        Me.btnLoadCars.Name = "btnLoadCars"
        Me.btnLoadCars.Size = New System.Drawing.Size(121, 39)
        Me.btnLoadCars.TabIndex = 54
        Me.btnLoadCars.Text = "Load Cars"
        Me.btnLoadCars.UseVisualStyleBackColor = False
        '
        'txtRentDuration
        '
        Me.txtRentDuration.Font = New System.Drawing.Font("Argentum Sans Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRentDuration.Location = New System.Drawing.Point(295, 360)
        Me.txtRentDuration.Name = "txtRentDuration"
        Me.txtRentDuration.Size = New System.Drawing.Size(245, 25)
        Me.txtRentDuration.TabIndex = 0
        '
        'txtRentalRate
        '
        Me.txtRentalRate.Font = New System.Drawing.Font("Argentum Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRentalRate.Location = New System.Drawing.Point(295, 414)
        Me.txtRentalRate.Multiline = True
        Me.txtRentalRate.Name = "txtRentalRate"
        Me.txtRentalRate.ReadOnly = True
        Me.txtRentalRate.Size = New System.Drawing.Size(245, 32)
        Me.txtRentalRate.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(162, 489)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Total Cost"
        '
        'txtRentTotalCost
        '
        Me.txtRentTotalCost.Font = New System.Drawing.Font("Argentum Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRentTotalCost.Location = New System.Drawing.Point(295, 478)
        Me.txtRentTotalCost.Multiline = True
        Me.txtRentTotalCost.Name = "txtRentTotalCost"
        Me.txtRentTotalCost.ReadOnly = True
        Me.txtRentTotalCost.Size = New System.Drawing.Size(245, 32)
        Me.txtRentTotalCost.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(162, 424)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 15)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Rental Rate"
        '
        'adminDashboardRent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1067, 665)
        Me.Controls.Add(Me.txtRentDuration)
        Me.Controls.Add(Me.dtReturnOn)
        Me.Controls.Add(Me.dtRentFrom)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLoadCars)
        Me.Controls.Add(Me.dgvUserList)
        Me.Controls.Add(Me.cmbSelectCar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRentTotalCost)
        Me.Controls.Add(Me.txtRentalRate)
        Me.Controls.Add(Me.txtRentEmailAdress)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnRent)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "adminDashboardRent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminDashboardRent"
        CType(Me.dgvUserList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picManageUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRentals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picManageCatalog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.picSignupLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRentDuration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvUserList As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents picManageUsers As PictureBox
    Friend WithEvents picRent As PictureBox
    Friend WithEvents picRentals As PictureBox
    Friend WithEvents picManageCatalog As PictureBox
    Friend WithEvents btnRent As Button
    Friend WithEvents btnRentSignOut As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picSignupLogo As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRentEmailAdress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbSelectCar As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents dtRentFrom As DateTimePicker
    Friend WithEvents dtReturnOn As DateTimePicker
    Friend WithEvents btnLoadCars As Button
    Friend WithEvents txtRentDuration As NumericUpDown
    Friend WithEvents txtRentalRate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRentTotalCost As TextBox
    Friend WithEvents Label7 As Label
End Class
