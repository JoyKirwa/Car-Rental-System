<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminDashboardViewRentals
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminDashboardViewRentals))
        Me.btnLoadTransactionHistory = New System.Windows.Forms.Button()
        Me.dgvUserList = New System.Windows.Forms.DataGridView()
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
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.picSignupLogo = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvUserList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.picManageUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRentals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picManageCatalog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picSignupLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoadTransactionHistory
        '
        Me.btnLoadTransactionHistory.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnLoadTransactionHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadTransactionHistory.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadTransactionHistory.ForeColor = System.Drawing.Color.White
        Me.btnLoadTransactionHistory.Location = New System.Drawing.Point(323, 605)
        Me.btnLoadTransactionHistory.Name = "btnLoadTransactionHistory"
        Me.btnLoadTransactionHistory.Size = New System.Drawing.Size(121, 39)
        Me.btnLoadTransactionHistory.TabIndex = 83
        Me.btnLoadTransactionHistory.Text = "View history"
        Me.btnLoadTransactionHistory.UseVisualStyleBackColor = False
        '
        'dgvUserList
        '
        Me.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserList.Location = New System.Drawing.Point(136, 138)
        Me.dgvUserList.Name = "dgvUserList"
        Me.dgvUserList.Size = New System.Drawing.Size(487, 446)
        Me.dgvUserList.TabIndex = 82
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
        Me.Panel2.TabIndex = 50
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
        Me.picManageUsers.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.Panel1.Controls.Add(Me.btnSignOut)
        Me.Panel1.Controls.Add(Me.picSignupLogo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Argentum Sans Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(682, 60)
        Me.Panel1.TabIndex = 49
        '
        'btnSignOut
        '
        Me.btnSignOut.BackColor = System.Drawing.Color.Gray
        Me.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignOut.ForeColor = System.Drawing.Color.White
        Me.btnSignOut.Location = New System.Drawing.Point(548, 12)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(75, 35)
        Me.btnSignOut.TabIndex = 3
        Me.btnSignOut.Text = "Sign Out"
        Me.btnSignOut.UseVisualStyleBackColor = False
        '
        'picSignupLogo
        '
        Me.picSignupLogo.BackColor = System.Drawing.Color.Transparent
        Me.picSignupLogo.BackgroundImage = CType(resources.GetObject("picSignupLogo.BackgroundImage"), System.Drawing.Image)
        Me.picSignupLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picSignupLogo.Location = New System.Drawing.Point(306, 0)
        Me.picSignupLogo.Name = "picSignupLogo"
        Me.picSignupLogo.Size = New System.Drawing.Size(83, 60)
        Me.picSignupLogo.TabIndex = 7
        Me.picSignupLogo.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Argentum Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(294, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 18)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Rent History"
        '
        'adminDashboardViewRentals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(682, 665)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnLoadTransactionHistory)
        Me.Controls.Add(Me.dgvUserList)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Argentum Sans Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "adminDashboardViewRentals"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminDashboardViewRentals"
        CType(Me.dgvUserList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picManageUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRentals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picManageCatalog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.picSignupLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLoadTransactionHistory As Button
    Friend WithEvents dgvUserList As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents picManageUsers As PictureBox
    Friend WithEvents picRent As PictureBox
    Friend WithEvents picRentals As PictureBox
    Friend WithEvents picManageCatalog As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSignOut As Button
    Friend WithEvents picSignupLogo As PictureBox
    Friend WithEvents Label6 As Label
End Class
