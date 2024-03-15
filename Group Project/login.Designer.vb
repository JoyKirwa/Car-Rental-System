<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.pnlLoginSidePanel = New System.Windows.Forms.Panel()
        Me.picSigninLogo = New System.Windows.Forms.PictureBox()
        Me.lblSigninTitle = New System.Windows.Forms.Label()
        Me.btnSigninSubmit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lblSigninEmail = New System.Windows.Forms.Label()
        Me.lblSigninPassword = New System.Windows.Forms.Label()
        Me.txtSigninEmail = New System.Windows.Forms.TextBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtSigninPassword = New System.Windows.Forms.TextBox()
        CType(Me.picSigninLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLoginSidePanel
        '
        Me.pnlLoginSidePanel.BackgroundImage = CType(resources.GetObject("pnlLoginSidePanel.BackgroundImage"), System.Drawing.Image)
        Me.pnlLoginSidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlLoginSidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLoginSidePanel.Location = New System.Drawing.Point(0, 0)
        Me.pnlLoginSidePanel.Name = "pnlLoginSidePanel"
        Me.pnlLoginSidePanel.Size = New System.Drawing.Size(292, 362)
        Me.pnlLoginSidePanel.TabIndex = 0
        '
        'picSigninLogo
        '
        Me.picSigninLogo.BackColor = System.Drawing.Color.Transparent
        Me.picSigninLogo.BackgroundImage = CType(resources.GetObject("picSigninLogo.BackgroundImage"), System.Drawing.Image)
        Me.picSigninLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picSigninLogo.Location = New System.Drawing.Point(406, 23)
        Me.picSigninLogo.Name = "picSigninLogo"
        Me.picSigninLogo.Size = New System.Drawing.Size(108, 77)
        Me.picSigninLogo.TabIndex = 1
        Me.picSigninLogo.TabStop = False
        '
        'lblSigninTitle
        '
        Me.lblSigninTitle.AutoSize = True
        Me.lblSigninTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSigninTitle.Font = New System.Drawing.Font("Argentum Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSigninTitle.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblSigninTitle.Location = New System.Drawing.Point(403, 112)
        Me.lblSigninTitle.Name = "lblSigninTitle"
        Me.lblSigninTitle.Size = New System.Drawing.Size(121, 18)
        Me.lblSigninTitle.TabIndex = 2
        Me.lblSigninTitle.Text = "HOT WHEELS"
        '
        'btnSigninSubmit
        '
        Me.btnSigninSubmit.BackColor = System.Drawing.Color.Black
        Me.btnSigninSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSigninSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSigninSubmit.Location = New System.Drawing.Point(418, 271)
        Me.btnSigninSubmit.Name = "btnSigninSubmit"
        Me.btnSigninSubmit.Size = New System.Drawing.Size(87, 37)
        Me.btnSigninSubmit.TabIndex = 3
        Me.btnSigninSubmit.Text = "LOG IN"
        Me.btnSigninSubmit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Argentum Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(372, 319)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Don't have an account? Sign up"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Argentum Sans Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(541, 318)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(33, 14)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "here"
        '
        'lblSigninEmail
        '
        Me.lblSigninEmail.AutoSize = True
        Me.lblSigninEmail.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSigninEmail.Location = New System.Drawing.Point(315, 167)
        Me.lblSigninEmail.Name = "lblSigninEmail"
        Me.lblSigninEmail.Size = New System.Drawing.Size(46, 15)
        Me.lblSigninEmail.TabIndex = 6
        Me.lblSigninEmail.Text = "Email"
        '
        'lblSigninPassword
        '
        Me.lblSigninPassword.AutoSize = True
        Me.lblSigninPassword.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSigninPassword.Location = New System.Drawing.Point(315, 216)
        Me.lblSigninPassword.Name = "lblSigninPassword"
        Me.lblSigninPassword.Size = New System.Drawing.Size(70, 15)
        Me.lblSigninPassword.TabIndex = 6
        Me.lblSigninPassword.Text = "Password"
        '
        'txtSigninEmail
        '
        Me.txtSigninEmail.Font = New System.Drawing.Font("Argentum Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSigninEmail.Location = New System.Drawing.Point(406, 159)
        Me.txtSigninEmail.Multiline = True
        Me.txtSigninEmail.Name = "txtSigninEmail"
        Me.txtSigninEmail.Size = New System.Drawing.Size(188, 30)
        Me.txtSigninEmail.TabIndex = 7
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Argentum Sans Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(491, 248)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(103, 14)
        Me.LinkLabel2.TabIndex = 8
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Forgot Password"
        Me.LinkLabel2.Visible = False
        '
        'BindingSource1
        '
        '
        'txtSigninPassword
        '
        Me.txtSigninPassword.Font = New System.Drawing.Font("Argentum Sans", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSigninPassword.Location = New System.Drawing.Point(406, 210)
        Me.txtSigninPassword.Multiline = True
        Me.txtSigninPassword.Name = "txtSigninPassword"
        Me.txtSigninPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSigninPassword.Size = New System.Drawing.Size(188, 30)
        Me.txtSigninPassword.TabIndex = 7
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(620, 362)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.txtSigninPassword)
        Me.Controls.Add(Me.txtSigninEmail)
        Me.Controls.Add(Me.lblSigninPassword)
        Me.Controls.Add(Me.lblSigninEmail)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSigninSubmit)
        Me.Controls.Add(Me.lblSigninTitle)
        Me.Controls.Add(Me.picSigninLogo)
        Me.Controls.Add(Me.pnlLoginSidePanel)
        Me.Font = New System.Drawing.Font("Argentum Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        CType(Me.picSigninLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlLoginSidePanel As Panel
    Friend WithEvents picSigninLogo As PictureBox
    Friend WithEvents lblSigninTitle As Label
    Friend WithEvents btnSigninSubmit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lblSigninEmail As Label
    Friend WithEvents lblSigninPassword As Label
    Friend WithEvents txtSigninEmail As TextBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents txtSigninPassword As TextBox
End Class
