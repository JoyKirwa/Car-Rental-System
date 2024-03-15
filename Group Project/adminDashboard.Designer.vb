<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminDashboard))
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnUpdateUser = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picManageUsers = New System.Windows.Forms.PictureBox()
        Me.picRent = New System.Windows.Forms.PictureBox()
        Me.picRentals = New System.Windows.Forms.PictureBox()
        Me.picManageCatalog = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.picSignupLogo = New System.Windows.Forms.PictureBox()
        Me.lblSignupConfirmPassword = New System.Windows.Forms.Label()
        Me.lblSignupPassword = New System.Windows.Forms.Label()
        Me.lblSignupNationalID = New System.Windows.Forms.Label()
        Me.lblSignupLicenseNumber = New System.Windows.Forms.Label()
        Me.lblSignupPhoneNumber = New System.Windows.Forms.Label()
        Me.lblSignupEmail = New System.Windows.Forms.Label()
        Me.lblAddName = New System.Windows.Forms.Label()
        Me.txtAddConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtAddPassword = New System.Windows.Forms.TextBox()
        Me.txtAddNationalID = New System.Windows.Forms.TextBox()
        Me.txtAddLicenseNumber = New System.Windows.Forms.TextBox()
        Me.txtAddPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtAddEmail = New System.Windows.Forms.TextBox()
        Me.txtAddName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbSelectUserDelete = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbSelectUserUpdate = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUpdateEmail = New System.Windows.Forms.TextBox()
        Me.txtUpdatePhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtUpdateName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtUpdatePassword = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.dgvUserList = New System.Windows.Forms.DataGridView()
        Me.btnLoadUsers = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.picManageUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRentals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picManageCatalog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSignupLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUserList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.BackColor = System.Drawing.Color.IndianRed
        Me.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteUser.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteUser.ForeColor = System.Drawing.Color.White
        Me.btnDeleteUser.Location = New System.Drawing.Point(375, 611)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(121, 39)
        Me.btnDeleteUser.TabIndex = 5
        Me.btnDeleteUser.Text = "DELETE"
        Me.btnDeleteUser.UseVisualStyleBackColor = False
        '
        'btnUpdateUser
        '
        Me.btnUpdateUser.BackColor = System.Drawing.Color.Teal
        Me.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateUser.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateUser.ForeColor = System.Drawing.Color.White
        Me.btnUpdateUser.Location = New System.Drawing.Point(747, 611)
        Me.btnUpdateUser.Name = "btnUpdateUser"
        Me.btnUpdateUser.Size = New System.Drawing.Size(121, 39)
        Me.btnUpdateUser.TabIndex = 6
        Me.btnUpdateUser.Text = "UPDATE"
        Me.btnUpdateUser.UseVisualStyleBackColor = False
        '
        'btnAddUser
        '
        Me.btnAddUser.BackColor = System.Drawing.Color.Black
        Me.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddUser.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.ForeColor = System.Drawing.Color.White
        Me.btnAddUser.Location = New System.Drawing.Point(375, 468)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(121, 39)
        Me.btnAddUser.TabIndex = 7
        Me.btnAddUser.Text = "ADD"
        Me.btnAddUser.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Add New Users:"
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
        Me.Panel2.TabIndex = 10
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.picSignupLogo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Argentum Sans Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1067, 60)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(1010, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gray
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(920, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 35)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Sign Out"
        Me.Button3.UseVisualStyleBackColor = False
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
        'lblSignupConfirmPassword
        '
        Me.lblSignupConfirmPassword.AutoSize = True
        Me.lblSignupConfirmPassword.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignupConfirmPassword.Location = New System.Drawing.Point(204, 400)
        Me.lblSignupConfirmPassword.Name = "lblSignupConfirmPassword"
        Me.lblSignupConfirmPassword.Size = New System.Drawing.Size(127, 15)
        Me.lblSignupConfirmPassword.TabIndex = 18
        Me.lblSignupConfirmPassword.Text = "Confirm Password"
        '
        'lblSignupPassword
        '
        Me.lblSignupPassword.AutoSize = True
        Me.lblSignupPassword.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignupPassword.Location = New System.Drawing.Point(204, 354)
        Me.lblSignupPassword.Name = "lblSignupPassword"
        Me.lblSignupPassword.Size = New System.Drawing.Size(70, 15)
        Me.lblSignupPassword.TabIndex = 19
        Me.lblSignupPassword.Text = "Password"
        '
        'lblSignupNationalID
        '
        Me.lblSignupNationalID.AutoSize = True
        Me.lblSignupNationalID.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignupNationalID.Location = New System.Drawing.Point(204, 307)
        Me.lblSignupNationalID.Name = "lblSignupNationalID"
        Me.lblSignupNationalID.Size = New System.Drawing.Size(81, 15)
        Me.lblSignupNationalID.TabIndex = 20
        Me.lblSignupNationalID.Text = "National ID"
        '
        'lblSignupLicenseNumber
        '
        Me.lblSignupLicenseNumber.AutoSize = True
        Me.lblSignupLicenseNumber.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignupLicenseNumber.Location = New System.Drawing.Point(204, 260)
        Me.lblSignupLicenseNumber.Name = "lblSignupLicenseNumber"
        Me.lblSignupLicenseNumber.Size = New System.Drawing.Size(114, 15)
        Me.lblSignupLicenseNumber.TabIndex = 21
        Me.lblSignupLicenseNumber.Text = "License Number"
        '
        'lblSignupPhoneNumber
        '
        Me.lblSignupPhoneNumber.AutoSize = True
        Me.lblSignupPhoneNumber.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignupPhoneNumber.Location = New System.Drawing.Point(204, 215)
        Me.lblSignupPhoneNumber.Name = "lblSignupPhoneNumber"
        Me.lblSignupPhoneNumber.Size = New System.Drawing.Size(107, 15)
        Me.lblSignupPhoneNumber.TabIndex = 22
        Me.lblSignupPhoneNumber.Text = "Phone number"
        '
        'lblSignupEmail
        '
        Me.lblSignupEmail.AutoSize = True
        Me.lblSignupEmail.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignupEmail.Location = New System.Drawing.Point(204, 168)
        Me.lblSignupEmail.Name = "lblSignupEmail"
        Me.lblSignupEmail.Size = New System.Drawing.Size(46, 15)
        Me.lblSignupEmail.TabIndex = 23
        Me.lblSignupEmail.Text = "Email"
        '
        'lblAddName
        '
        Me.lblAddName.AutoSize = True
        Me.lblAddName.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddName.Location = New System.Drawing.Point(204, 122)
        Me.lblAddName.Name = "lblAddName"
        Me.lblAddName.Size = New System.Drawing.Size(47, 15)
        Me.lblAddName.TabIndex = 24
        Me.lblAddName.Text = "Name"
        '
        'txtAddConfirmPassword
        '
        Me.txtAddConfirmPassword.Font = New System.Drawing.Font("Argentum Sans Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddConfirmPassword.Location = New System.Drawing.Point(336, 391)
        Me.txtAddConfirmPassword.Multiline = True
        Me.txtAddConfirmPassword.Name = "txtAddConfirmPassword"
        Me.txtAddConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAddConfirmPassword.Size = New System.Drawing.Size(204, 32)
        Me.txtAddConfirmPassword.TabIndex = 11
        '
        'txtAddPassword
        '
        Me.txtAddPassword.Font = New System.Drawing.Font("Argentum Sans Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddPassword.Location = New System.Drawing.Point(336, 346)
        Me.txtAddPassword.Multiline = True
        Me.txtAddPassword.Name = "txtAddPassword"
        Me.txtAddPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAddPassword.Size = New System.Drawing.Size(204, 32)
        Me.txtAddPassword.TabIndex = 12
        '
        'txtAddNationalID
        '
        Me.txtAddNationalID.Font = New System.Drawing.Font("Argentum Sans Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddNationalID.Location = New System.Drawing.Point(336, 298)
        Me.txtAddNationalID.Multiline = True
        Me.txtAddNationalID.Name = "txtAddNationalID"
        Me.txtAddNationalID.Size = New System.Drawing.Size(204, 32)
        Me.txtAddNationalID.TabIndex = 13
        '
        'txtAddLicenseNumber
        '
        Me.txtAddLicenseNumber.Font = New System.Drawing.Font("Argentum Sans Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddLicenseNumber.Location = New System.Drawing.Point(336, 251)
        Me.txtAddLicenseNumber.Multiline = True
        Me.txtAddLicenseNumber.Name = "txtAddLicenseNumber"
        Me.txtAddLicenseNumber.Size = New System.Drawing.Size(204, 32)
        Me.txtAddLicenseNumber.TabIndex = 14
        '
        'txtAddPhoneNumber
        '
        Me.txtAddPhoneNumber.Font = New System.Drawing.Font("Argentum Sans Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddPhoneNumber.Location = New System.Drawing.Point(336, 206)
        Me.txtAddPhoneNumber.Multiline = True
        Me.txtAddPhoneNumber.Name = "txtAddPhoneNumber"
        Me.txtAddPhoneNumber.Size = New System.Drawing.Size(204, 32)
        Me.txtAddPhoneNumber.TabIndex = 15
        '
        'txtAddEmail
        '
        Me.txtAddEmail.Font = New System.Drawing.Font("Argentum Sans Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddEmail.Location = New System.Drawing.Point(336, 161)
        Me.txtAddEmail.Multiline = True
        Me.txtAddEmail.Name = "txtAddEmail"
        Me.txtAddEmail.Size = New System.Drawing.Size(204, 32)
        Me.txtAddEmail.TabIndex = 16
        '
        'txtAddName
        '
        Me.txtAddName.Font = New System.Drawing.Font("Argentum Sans Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddName.Location = New System.Drawing.Point(336, 113)
        Me.txtAddName.Multiline = True
        Me.txtAddName.Name = "txtAddName"
        Me.txtAddName.Size = New System.Drawing.Size(204, 32)
        Me.txtAddName.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(574, 355)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 15)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Update User Info"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(817, 547)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 15)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Role"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(84, 519)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 15)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Delete User"
        '
        'cmbSelectUserDelete
        '
        Me.cmbSelectUserDelete.BackColor = System.Drawing.SystemColors.Info
        Me.cmbSelectUserDelete.FormattingEnabled = True
        Me.cmbSelectUserDelete.Location = New System.Drawing.Point(336, 558)
        Me.cmbSelectUserDelete.Name = "cmbSelectUserDelete"
        Me.cmbSelectUserDelete.Size = New System.Drawing.Size(204, 23)
        Me.cmbSelectUserDelete.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(204, 561)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 15)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Select user:"
        '
        'cmbSelectUserUpdate
        '
        Me.cmbSelectUserUpdate.BackColor = System.Drawing.SystemColors.Info
        Me.cmbSelectUserUpdate.FormattingEnabled = True
        Me.cmbSelectUserUpdate.Location = New System.Drawing.Point(577, 432)
        Me.cmbSelectUserUpdate.Name = "cmbSelectUserUpdate"
        Me.cmbSelectUserUpdate.Size = New System.Drawing.Size(204, 23)
        Me.cmbSelectUserUpdate.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(574, 403)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Select user:"
        '
        'txtUpdateEmail
        '
        Me.txtUpdateEmail.Font = New System.Drawing.Font("Argentum Sans Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateEmail.Location = New System.Drawing.Point(577, 495)
        Me.txtUpdateEmail.Multiline = True
        Me.txtUpdateEmail.Name = "txtUpdateEmail"
        Me.txtUpdateEmail.Size = New System.Drawing.Size(204, 32)
        Me.txtUpdateEmail.TabIndex = 33
        '
        'txtUpdatePhoneNumber
        '
        Me.txtUpdatePhoneNumber.Font = New System.Drawing.Font("Argentum Sans Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdatePhoneNumber.Location = New System.Drawing.Point(820, 495)
        Me.txtUpdatePhoneNumber.Multiline = True
        Me.txtUpdatePhoneNumber.Name = "txtUpdatePhoneNumber"
        Me.txtUpdatePhoneNumber.Size = New System.Drawing.Size(204, 32)
        Me.txtUpdatePhoneNumber.TabIndex = 34
        '
        'txtUpdateName
        '
        Me.txtUpdateName.Font = New System.Drawing.Font("Argentum Sans Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateName.Location = New System.Drawing.Point(820, 423)
        Me.txtUpdateName.Multiline = True
        Me.txtUpdateName.Name = "txtUpdateName"
        Me.txtUpdateName.Size = New System.Drawing.Size(204, 32)
        Me.txtUpdateName.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(817, 403)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 15)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(817, 476)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 15)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Phone number"
        '
        'txtUpdatePassword
        '
        Me.txtUpdatePassword.Font = New System.Drawing.Font("Argentum Sans Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdatePassword.Location = New System.Drawing.Point(577, 561)
        Me.txtUpdatePassword.Multiline = True
        Me.txtUpdatePassword.Name = "txtUpdatePassword"
        Me.txtUpdatePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUpdatePassword.Size = New System.Drawing.Size(204, 32)
        Me.txtUpdatePassword.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(574, 476)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 15)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Email"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(574, 544)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 15)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Password"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Argentum Sans Light", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(575, 379)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(440, 12)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "* Not all fields must be filled in order to update. You can choose to omit others" &
    "."
        '
        'cmbRole
        '
        Me.cmbRole.BackColor = System.Drawing.SystemColors.Window
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Items.AddRange(New Object() {"", "True", "False"})
        Me.cmbRole.Location = New System.Drawing.Point(820, 571)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(204, 23)
        Me.cmbRole.TabIndex = 42
        '
        'dgvUserList
        '
        Me.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserList.Location = New System.Drawing.Point(558, 72)
        Me.dgvUserList.Name = "dgvUserList"
        Me.dgvUserList.Size = New System.Drawing.Size(487, 223)
        Me.dgvUserList.TabIndex = 43
        '
        'btnLoadUsers
        '
        Me.btnLoadUsers.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnLoadUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadUsers.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadUsers.ForeColor = System.Drawing.Color.White
        Me.btnLoadUsers.Location = New System.Drawing.Point(732, 301)
        Me.btnLoadUsers.Name = "btnLoadUsers"
        Me.btnLoadUsers.Size = New System.Drawing.Size(121, 39)
        Me.btnLoadUsers.TabIndex = 44
        Me.btnLoadUsers.Text = "Load Users"
        Me.btnLoadUsers.UseVisualStyleBackColor = False
        '
        'adminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1067, 665)
        Me.Controls.Add(Me.btnLoadUsers)
        Me.Controls.Add(Me.dgvUserList)
        Me.Controls.Add(Me.cmbRole)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtUpdatePassword)
        Me.Controls.Add(Me.txtUpdateEmail)
        Me.Controls.Add(Me.txtUpdatePhoneNumber)
        Me.Controls.Add(Me.txtUpdateName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbSelectUserUpdate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbSelectUserDelete)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblSignupConfirmPassword)
        Me.Controls.Add(Me.lblSignupPassword)
        Me.Controls.Add(Me.lblSignupNationalID)
        Me.Controls.Add(Me.lblSignupLicenseNumber)
        Me.Controls.Add(Me.lblSignupPhoneNumber)
        Me.Controls.Add(Me.lblSignupEmail)
        Me.Controls.Add(Me.lblAddName)
        Me.Controls.Add(Me.txtAddConfirmPassword)
        Me.Controls.Add(Me.txtAddPassword)
        Me.Controls.Add(Me.txtAddNationalID)
        Me.Controls.Add(Me.txtAddLicenseNumber)
        Me.Controls.Add(Me.txtAddPhoneNumber)
        Me.Controls.Add(Me.txtAddEmail)
        Me.Controls.Add(Me.txtAddName)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.btnUpdateUser)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Font = New System.Drawing.Font("Argentum Sans Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "adminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminDashboard"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picManageUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRentals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picManageCatalog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSignupLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUserList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnUpdateUser As Button
    Friend WithEvents btnAddUser As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents picManageCatalog As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents picSignupLogo As PictureBox
    Friend WithEvents picRentals As PictureBox
    Friend WithEvents lblSignupConfirmPassword As Label
    Friend WithEvents lblSignupPassword As Label
    Friend WithEvents lblSignupNationalID As Label
    Friend WithEvents lblSignupLicenseNumber As Label
    Friend WithEvents lblSignupPhoneNumber As Label
    Friend WithEvents lblSignupEmail As Label
    Friend WithEvents lblAddName As Label
    Friend WithEvents txtAddConfirmPassword As TextBox
    Friend WithEvents txtAddPassword As TextBox
    Friend WithEvents txtAddNationalID As TextBox
    Friend WithEvents txtAddLicenseNumber As TextBox
    Friend WithEvents txtAddPhoneNumber As TextBox
    Friend WithEvents txtAddEmail As TextBox
    Friend WithEvents txtAddName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbSelectUserDelete As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbSelectUserUpdate As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUpdateEmail As TextBox
    Friend WithEvents txtUpdatePhoneNumber As TextBox
    Friend WithEvents txtUpdateName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents picManageUsers As PictureBox
    Friend WithEvents picRent As PictureBox
    Friend WithEvents txtUpdatePassword As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents dgvUserList As DataGridView
    Friend WithEvents btnLoadUsers As Button
End Class
