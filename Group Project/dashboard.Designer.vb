<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Me.txtRentDuration = New System.Windows.Forms.NumericUpDown()
        Me.btnRentSignOut = New System.Windows.Forms.Button()
        Me.dtReturnOn = New System.Windows.Forms.DateTimePicker()
        Me.dtRentFrom = New System.Windows.Forms.DateTimePicker()
        Me.dgvUserList = New System.Windows.Forms.DataGridView()
        Me.cmbSelectCar = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.picSignupLogo = New System.Windows.Forms.PictureBox()
        Me.txtRentTotalCost = New System.Windows.Forms.TextBox()
        Me.txtRentalRate = New System.Windows.Forms.TextBox()
        Me.txtRentEmailAdress = New System.Windows.Forms.TextBox()
        Me.btnRent = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.txtRentDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUserList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSignupLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRentDuration
        '
        Me.txtRentDuration.Font = New System.Drawing.Font("Argentum Sans Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRentDuration.Location = New System.Drawing.Point(295, 405)
        Me.txtRentDuration.Name = "txtRentDuration"
        Me.txtRentDuration.Size = New System.Drawing.Size(245, 25)
        Me.txtRentDuration.TabIndex = 56
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
        'dtReturnOn
        '
        Me.dtReturnOn.CustomFormat = "yyyy-MM-dd hh:mm"
        Me.dtReturnOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtReturnOn.Location = New System.Drawing.Point(295, 340)
        Me.dtReturnOn.Name = "dtReturnOn"
        Me.dtReturnOn.ShowUpDown = True
        Me.dtReturnOn.Size = New System.Drawing.Size(245, 22)
        Me.dtReturnOn.TabIndex = 73
        '
        'dtRentFrom
        '
        Me.dtRentFrom.CustomFormat = "yyyy-MM-dd hh:mm"
        Me.dtRentFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtRentFrom.Location = New System.Drawing.Point(295, 282)
        Me.dtRentFrom.Name = "dtRentFrom"
        Me.dtRentFrom.ShowUpDown = True
        Me.dtRentFrom.Size = New System.Drawing.Size(245, 22)
        Me.dtRentFrom.TabIndex = 74
        '
        'dgvUserList
        '
        Me.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserList.Location = New System.Drawing.Point(558, 117)
        Me.dgvUserList.Name = "dgvUserList"
        Me.dgvUserList.Size = New System.Drawing.Size(487, 438)
        Me.dgvUserList.TabIndex = 71
        '
        'cmbSelectCar
        '
        Me.cmbSelectCar.BackColor = System.Drawing.SystemColors.Info
        Me.cmbSelectCar.FormattingEnabled = True
        Me.cmbSelectCar.Location = New System.Drawing.Point(295, 160)
        Me.cmbSelectCar.Name = "cmbSelectCar"
        Me.cmbSelectCar.Size = New System.Drawing.Size(245, 23)
        Me.cmbSelectCar.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(84, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 15)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Rent:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(162, 412)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 15)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Rent duration"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(162, 346)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 15)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Return on"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(162, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 15)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Rent from"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(162, 469)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 15)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Rental Rate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(162, 534)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Total Cost"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(162, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 15)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Email address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(162, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Select car"
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
        'txtRentTotalCost
        '
        Me.txtRentTotalCost.Font = New System.Drawing.Font("Argentum Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRentTotalCost.Location = New System.Drawing.Point(295, 523)
        Me.txtRentTotalCost.Multiline = True
        Me.txtRentTotalCost.Name = "txtRentTotalCost"
        Me.txtRentTotalCost.ReadOnly = True
        Me.txtRentTotalCost.Size = New System.Drawing.Size(245, 32)
        Me.txtRentTotalCost.TabIndex = 59
        '
        'txtRentalRate
        '
        Me.txtRentalRate.Font = New System.Drawing.Font("Argentum Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRentalRate.Location = New System.Drawing.Point(295, 459)
        Me.txtRentalRate.Multiline = True
        Me.txtRentalRate.Name = "txtRentalRate"
        Me.txtRentalRate.ReadOnly = True
        Me.txtRentalRate.Size = New System.Drawing.Size(245, 32)
        Me.txtRentalRate.TabIndex = 60
        '
        'txtRentEmailAdress
        '
        Me.txtRentEmailAdress.Font = New System.Drawing.Font("Argentum Sans Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRentEmailAdress.Location = New System.Drawing.Point(295, 210)
        Me.txtRentEmailAdress.Multiline = True
        Me.txtRentEmailAdress.Name = "txtRentEmailAdress"
        Me.txtRentEmailAdress.Size = New System.Drawing.Size(245, 32)
        Me.txtRentEmailAdress.TabIndex = 61
        '
        'btnRent
        '
        Me.btnRent.BackColor = System.Drawing.Color.Black
        Me.btnRent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRent.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRent.ForeColor = System.Drawing.Color.White
        Me.btnRent.Location = New System.Drawing.Point(350, 581)
        Me.btnRent.Name = "btnRent"
        Me.btnRent.Size = New System.Drawing.Size(121, 39)
        Me.btnRent.TabIndex = 57
        Me.btnRent.Text = "RENT"
        Me.btnRent.UseVisualStyleBackColor = False
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
        Me.Panel1.TabIndex = 58
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Argentum Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(732, 581)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 39)
        Me.Button1.TabIndex = 72
        Me.Button1.Text = "Load Cars"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1067, 665)
        Me.Controls.Add(Me.txtRentDuration)
        Me.Controls.Add(Me.dtReturnOn)
        Me.Controls.Add(Me.dtRentFrom)
        Me.Controls.Add(Me.Button1)
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
        Me.Controls.Add(Me.btnRent)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Argentum Sans Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dashboard"
        CType(Me.txtRentDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUserList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSignupLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRentDuration As NumericUpDown
    Friend WithEvents btnRentSignOut As Button
    Friend WithEvents dtReturnOn As DateTimePicker
    Friend WithEvents dtRentFrom As DateTimePicker
    Friend WithEvents dgvUserList As DataGridView
    Friend WithEvents cmbSelectCar As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents picSignupLogo As PictureBox
    Friend WithEvents txtRentTotalCost As TextBox
    Friend WithEvents txtRentalRate As TextBox
    Friend WithEvents txtRentEmailAdress As TextBox
    Friend WithEvents btnRent As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
End Class
