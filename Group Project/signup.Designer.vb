<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class signup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(signup))
        Me.pnlSignupSidePanel = New System.Windows.Forms.Panel()
        Me.lblSignup = New System.Windows.Forms.Label()
        Me.txtSignupName = New System.Windows.Forms.TextBox()
        Me.lblSignupName = New System.Windows.Forms.Label()
        Me.btnSignupSubmit = New System.Windows.Forms.Button()
        Me.lblSignupEmail = New System.Windows.Forms.Label()
        Me.lblSignupPhoneNumber = New System.Windows.Forms.Label()
        Me.lblSignupLicenseNumber = New System.Windows.Forms.Label()
        Me.lblSignupPassword = New System.Windows.Forms.Label()
        Me.lblSignupConfirmPassword = New System.Windows.Forms.Label()
        Me.txtSignupEmail = New System.Windows.Forms.TextBox()
        Me.txtSignupPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtSignupLicenseNumber = New System.Windows.Forms.TextBox()
        Me.txtSignupNationalID = New System.Windows.Forms.TextBox()
        Me.txtSignupPassword = New System.Windows.Forms.TextBox()
        Me.txtSignupConfirmPassword = New System.Windows.Forms.TextBox()
        Me.lblSignupNationalID = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picSignupLogo = New System.Windows.Forms.PictureBox()
        Me.lblSignupTitle = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdoSignupTerms = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSignupLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSignupSidePanel
        '
        Me.pnlSignupSidePanel.BackgroundImage = CType(resources.GetObject("pnlSignupSidePanel.BackgroundImage"), System.Drawing.Image)
        Me.pnlSignupSidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlSignupSidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSignupSidePanel.Location = New System.Drawing.Point(0, 0)
        Me.pnlSignupSidePanel.Name = "pnlSignupSidePanel"
        Me.pnlSignupSidePanel.Size = New System.Drawing.Size(341, 557)
        Me.pnlSignupSidePanel.TabIndex = 0
        '
        'lblSignup
        '
        Me.lblSignup.AutoSize = True
        Me.lblSignup.Font = New System.Drawing.Font("Argentum Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSignup.Location = New System.Drawing.Point(503, 68)
        Me.lblSignup.Name = "lblSignup"
        Me.lblSignup.Size = New System.Drawing.Size(72, 18)
        Me.lblSignup.TabIndex = 1
        Me.lblSignup.Text = "Sign Up"
        '
        'txtSignupName
        '
        Me.txtSignupName.Font = New System.Drawing.Font("Argentum Sans Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignupName.Location = New System.Drawing.Point(493, 119)
        Me.txtSignupName.Multiline = True
        Me.txtSignupName.Name = "txtSignupName"
        Me.txtSignupName.Size = New System.Drawing.Size(204, 32)
        Me.txtSignupName.TabIndex = 2
        '
        'lblSignupName
        '
        Me.lblSignupName.AutoSize = True
        Me.lblSignupName.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignupName.Location = New System.Drawing.Point(361, 128)
        Me.lblSignupName.Name = "lblSignupName"
        Me.lblSignupName.Size = New System.Drawing.Size(47, 15)
        Me.lblSignupName.TabIndex = 3
        Me.lblSignupName.Text = "Name"
        '
        'btnSignupSubmit
        '
        Me.btnSignupSubmit.BackColor = System.Drawing.Color.Black
        Me.btnSignupSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignupSubmit.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignupSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSignupSubmit.Location = New System.Drawing.Point(473, 466)
        Me.btnSignupSubmit.Name = "btnSignupSubmit"
        Me.btnSignupSubmit.Size = New System.Drawing.Size(121, 39)
        Me.btnSignupSubmit.TabIndex = 4
        Me.btnSignupSubmit.Text = "SIGN UP"
        Me.btnSignupSubmit.UseVisualStyleBackColor = False
        '
        'lblSignupEmail
        '
        Me.lblSignupEmail.AutoSize = True
        Me.lblSignupEmail.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignupEmail.Location = New System.Drawing.Point(361, 174)
        Me.lblSignupEmail.Name = "lblSignupEmail"
        Me.lblSignupEmail.Size = New System.Drawing.Size(46, 15)
        Me.lblSignupEmail.TabIndex = 3
        Me.lblSignupEmail.Text = "Email"
        '
        'lblSignupPhoneNumber
        '
        Me.lblSignupPhoneNumber.AutoSize = True
        Me.lblSignupPhoneNumber.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignupPhoneNumber.Location = New System.Drawing.Point(361, 221)
        Me.lblSignupPhoneNumber.Name = "lblSignupPhoneNumber"
        Me.lblSignupPhoneNumber.Size = New System.Drawing.Size(107, 15)
        Me.lblSignupPhoneNumber.TabIndex = 3
        Me.lblSignupPhoneNumber.Text = "Phone number"
        '
        'lblSignupLicenseNumber
        '
        Me.lblSignupLicenseNumber.AutoSize = True
        Me.lblSignupLicenseNumber.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignupLicenseNumber.Location = New System.Drawing.Point(361, 266)
        Me.lblSignupLicenseNumber.Name = "lblSignupLicenseNumber"
        Me.lblSignupLicenseNumber.Size = New System.Drawing.Size(114, 15)
        Me.lblSignupLicenseNumber.TabIndex = 3
        Me.lblSignupLicenseNumber.Text = "License Number"
        '
        'lblSignupPassword
        '
        Me.lblSignupPassword.AutoSize = True
        Me.lblSignupPassword.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignupPassword.Location = New System.Drawing.Point(361, 360)
        Me.lblSignupPassword.Name = "lblSignupPassword"
        Me.lblSignupPassword.Size = New System.Drawing.Size(70, 15)
        Me.lblSignupPassword.TabIndex = 3
        Me.lblSignupPassword.Text = "Password"
        '
        'lblSignupConfirmPassword
        '
        Me.lblSignupConfirmPassword.AutoSize = True
        Me.lblSignupConfirmPassword.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignupConfirmPassword.Location = New System.Drawing.Point(361, 406)
        Me.lblSignupConfirmPassword.Name = "lblSignupConfirmPassword"
        Me.lblSignupConfirmPassword.Size = New System.Drawing.Size(127, 15)
        Me.lblSignupConfirmPassword.TabIndex = 3
        Me.lblSignupConfirmPassword.Text = "Confirm Password"
        '
        'txtSignupEmail
        '
        Me.txtSignupEmail.Font = New System.Drawing.Font("Argentum Sans Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignupEmail.Location = New System.Drawing.Point(493, 167)
        Me.txtSignupEmail.Multiline = True
        Me.txtSignupEmail.Name = "txtSignupEmail"
        Me.txtSignupEmail.Size = New System.Drawing.Size(204, 32)
        Me.txtSignupEmail.TabIndex = 2
        '
        'txtSignupPhoneNumber
        '
        Me.txtSignupPhoneNumber.Font = New System.Drawing.Font("Argentum Sans Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignupPhoneNumber.Location = New System.Drawing.Point(493, 212)
        Me.txtSignupPhoneNumber.Multiline = True
        Me.txtSignupPhoneNumber.Name = "txtSignupPhoneNumber"
        Me.txtSignupPhoneNumber.Size = New System.Drawing.Size(204, 32)
        Me.txtSignupPhoneNumber.TabIndex = 2
        '
        'txtSignupLicenseNumber
        '
        Me.txtSignupLicenseNumber.Font = New System.Drawing.Font("Argentum Sans Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignupLicenseNumber.Location = New System.Drawing.Point(493, 257)
        Me.txtSignupLicenseNumber.Multiline = True
        Me.txtSignupLicenseNumber.Name = "txtSignupLicenseNumber"
        Me.txtSignupLicenseNumber.Size = New System.Drawing.Size(204, 32)
        Me.txtSignupLicenseNumber.TabIndex = 2
        '
        'txtSignupNationalID
        '
        Me.txtSignupNationalID.Font = New System.Drawing.Font("Argentum Sans Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignupNationalID.Location = New System.Drawing.Point(493, 304)
        Me.txtSignupNationalID.Multiline = True
        Me.txtSignupNationalID.Name = "txtSignupNationalID"
        Me.txtSignupNationalID.Size = New System.Drawing.Size(204, 32)
        Me.txtSignupNationalID.TabIndex = 2
        '
        'txtSignupPassword
        '
        Me.txtSignupPassword.Font = New System.Drawing.Font("Argentum Sans Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignupPassword.Location = New System.Drawing.Point(493, 352)
        Me.txtSignupPassword.Multiline = True
        Me.txtSignupPassword.Name = "txtSignupPassword"
        Me.txtSignupPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSignupPassword.Size = New System.Drawing.Size(204, 32)
        Me.txtSignupPassword.TabIndex = 2
        '
        'txtSignupConfirmPassword
        '
        Me.txtSignupConfirmPassword.Font = New System.Drawing.Font("Argentum Sans Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignupConfirmPassword.Location = New System.Drawing.Point(493, 397)
        Me.txtSignupConfirmPassword.Multiline = True
        Me.txtSignupConfirmPassword.Name = "txtSignupConfirmPassword"
        Me.txtSignupConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSignupConfirmPassword.Size = New System.Drawing.Size(204, 32)
        Me.txtSignupConfirmPassword.TabIndex = 2
        '
        'lblSignupNationalID
        '
        Me.lblSignupNationalID.AutoSize = True
        Me.lblSignupNationalID.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignupNationalID.Location = New System.Drawing.Point(361, 313)
        Me.lblSignupNationalID.Name = "lblSignupNationalID"
        Me.lblSignupNationalID.Size = New System.Drawing.Size(81, 15)
        Me.lblSignupNationalID.TabIndex = 3
        Me.lblSignupNationalID.Text = "National ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(493, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 43)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'picSignupLogo
        '
        Me.picSignupLogo.BackColor = System.Drawing.Color.Transparent
        Me.picSignupLogo.BackgroundImage = CType(resources.GetObject("picSignupLogo.BackgroundImage"), System.Drawing.Image)
        Me.picSignupLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picSignupLogo.Location = New System.Drawing.Point(475, 9)
        Me.picSignupLogo.Name = "picSignupLogo"
        Me.picSignupLogo.Size = New System.Drawing.Size(108, 77)
        Me.picSignupLogo.TabIndex = 5
        Me.picSignupLogo.TabStop = False
        '
        'lblSignupTitle
        '
        Me.lblSignupTitle.AutoSize = True
        Me.lblSignupTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSignupTitle.Font = New System.Drawing.Font("Argentum Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignupTitle.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblSignupTitle.Location = New System.Drawing.Point(472, 89)
        Me.lblSignupTitle.Name = "lblSignupTitle"
        Me.lblSignupTitle.Size = New System.Drawing.Size(121, 18)
        Me.lblSignupTitle.TabIndex = 6
        Me.lblSignupTitle.Text = "HOT WHEELS"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Argentum Sans Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(617, 515)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(33, 14)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "here"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Argentum Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(442, 517)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 12)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Already have an account? Sign in"
        '
        'rdoSignupTerms
        '
        Me.rdoSignupTerms.AutoSize = True
        Me.rdoSignupTerms.Font = New System.Drawing.Font("Argentum Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSignupTerms.Location = New System.Drawing.Point(475, 440)
        Me.rdoSignupTerms.Name = "rdoSignupTerms"
        Me.rdoSignupTerms.Size = New System.Drawing.Size(207, 16)
        Me.rdoSignupTerms.TabIndex = 9
        Me.rdoSignupTerms.TabStop = True
        Me.rdoSignupTerms.Text = "I agree to the terms and conditions"
        Me.rdoSignupTerms.UseVisualStyleBackColor = True
        '
        'signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(722, 557)
        Me.Controls.Add(Me.rdoSignupTerms)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSignupTitle)
        Me.Controls.Add(Me.picSignupLogo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSignupSubmit)
        Me.Controls.Add(Me.lblSignupConfirmPassword)
        Me.Controls.Add(Me.lblSignupPassword)
        Me.Controls.Add(Me.lblSignupNationalID)
        Me.Controls.Add(Me.lblSignupLicenseNumber)
        Me.Controls.Add(Me.lblSignupPhoneNumber)
        Me.Controls.Add(Me.lblSignupEmail)
        Me.Controls.Add(Me.lblSignupName)
        Me.Controls.Add(Me.txtSignupConfirmPassword)
        Me.Controls.Add(Me.txtSignupPassword)
        Me.Controls.Add(Me.txtSignupNationalID)
        Me.Controls.Add(Me.txtSignupLicenseNumber)
        Me.Controls.Add(Me.txtSignupPhoneNumber)
        Me.Controls.Add(Me.txtSignupEmail)
        Me.Controls.Add(Me.txtSignupName)
        Me.Controls.Add(Me.lblSignup)
        Me.Controls.Add(Me.pnlSignupSidePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "signup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "signup"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSignupLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlSignupSidePanel As Panel
    Friend WithEvents lblSignup As Label
    Friend WithEvents txtSignupName As TextBox
    Friend WithEvents lblSignupName As Label
    Friend WithEvents btnSignupSubmit As Button
    Friend WithEvents lblSignupEmail As Label
    Friend WithEvents lblSignupPhoneNumber As Label
    Friend WithEvents lblSignupLicenseNumber As Label
    Friend WithEvents lblSignupPassword As Label
    Friend WithEvents lblSignupConfirmPassword As Label
    Friend WithEvents txtSignupEmail As TextBox
    Friend WithEvents txtSignupPhoneNumber As TextBox
    Friend WithEvents txtSignupLicenseNumber As TextBox
    Friend WithEvents txtSignupNationalID As TextBox
    Friend WithEvents txtSignupPassword As TextBox
    Friend WithEvents txtSignupConfirmPassword As TextBox
    Friend WithEvents lblSignupNationalID As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picSignupLogo As PictureBox
    Friend WithEvents lblSignupTitle As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents rdoSignupTerms As RadioButton
End Class
