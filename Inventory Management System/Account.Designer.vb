<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account
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
        HeaderPanel = New Panel()
        Header = New Label()
        CreateProductContainer = New Panel()
        Panel11 = New Panel()
        UpdateProfileButton = New Button()
        Panel8 = New Panel()
        Panel9 = New Panel()
        PasswordLabel = New Label()
        Password = New TextBox()
        Panel10 = New Panel()
        DateOfBirthLabel = New Label()
        DateOfBirth = New TextBox()
        Panel4 = New Panel()
        Panel5 = New Panel()
        ShopNameLabel = New Label()
        ShopName = New TextBox()
        Panel6 = New Panel()
        AddressLabel = New Label()
        Address = New TextBox()
        Panel1 = New Panel()
        Panel3 = New Panel()
        PhoneNumberLabel = New Label()
        Phone = New TextBox()
        Panel2 = New Panel()
        UserNameLabel = New Label()
        UserName = New TextBox()
        HeaderPanel.SuspendLayout()
        CreateProductContainer.SuspendLayout()
        Panel11.SuspendLayout()
        Panel8.SuspendLayout()
        Panel9.SuspendLayout()
        Panel10.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' HeaderPanel
        ' 
        HeaderPanel.BackColor = Color.White
        HeaderPanel.Controls.Add(Header)
        HeaderPanel.Dock = DockStyle.Top
        HeaderPanel.Location = New Point(0, 0)
        HeaderPanel.Name = "HeaderPanel"
        HeaderPanel.Padding = New Padding(9)
        HeaderPanel.Size = New Size(917, 47)
        HeaderPanel.TabIndex = 6
        ' 
        ' Header
        ' 
        Header.AutoSize = True
        Header.Dock = DockStyle.Top
        Header.Font = New Font("CaskaydiaCove NF", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Header.Location = New Point(9, 9)
        Header.Name = "Header"
        Header.Size = New Size(238, 31)
        Header.TabIndex = 0
        Header.Text = "Update Profile"
        ' 
        ' CreateProductContainer
        ' 
        CreateProductContainer.BackColor = Color.White
        CreateProductContainer.Controls.Add(Panel11)
        CreateProductContainer.Controls.Add(Panel8)
        CreateProductContainer.Controls.Add(Panel4)
        CreateProductContainer.Controls.Add(Panel1)
        CreateProductContainer.Dock = DockStyle.Bottom
        CreateProductContainer.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        CreateProductContainer.Location = New Point(0, 68)
        CreateProductContainer.Name = "CreateProductContainer"
        CreateProductContainer.Padding = New Padding(10)
        CreateProductContainer.Size = New Size(917, 496)
        CreateProductContainer.TabIndex = 8
        ' 
        ' Panel11
        ' 
        Panel11.Controls.Add(UpdateProfileButton)
        Panel11.Dock = DockStyle.Bottom
        Panel11.Location = New Point(10, 430)
        Panel11.Name = "Panel11"
        Panel11.Padding = New Padding(10)
        Panel11.Size = New Size(897, 56)
        Panel11.TabIndex = 5
        ' 
        ' UpdateProfileButton
        ' 
        UpdateProfileButton.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        UpdateProfileButton.Cursor = Cursors.Hand
        UpdateProfileButton.Dock = DockStyle.Left
        UpdateProfileButton.FlatStyle = FlatStyle.Flat
        UpdateProfileButton.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        UpdateProfileButton.ForeColor = Color.White
        UpdateProfileButton.Location = New Point(10, 10)
        UpdateProfileButton.Name = "UpdateProfileButton"
        UpdateProfileButton.Size = New Size(210, 36)
        UpdateProfileButton.TabIndex = 7
        UpdateProfileButton.Text = "Update Profile"
        UpdateProfileButton.UseVisualStyleBackColor = False
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(Panel9)
        Panel8.Controls.Add(Panel10)
        Panel8.Dock = DockStyle.Top
        Panel8.Location = New Point(10, 160)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(897, 75)
        Panel8.TabIndex = 3
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(PasswordLabel)
        Panel9.Controls.Add(Password)
        Panel9.Dock = DockStyle.Right
        Panel9.Location = New Point(452, 0)
        Panel9.Name = "Panel9"
        Panel9.Padding = New Padding(10)
        Panel9.Size = New Size(445, 75)
        Panel9.TabIndex = 1
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.AutoSize = True
        PasswordLabel.Dock = DockStyle.Top
        PasswordLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        PasswordLabel.Location = New Point(10, 10)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(168, 14)
        PasswordLabel.TabIndex = 1
        PasswordLabel.Text = "New Password (Optional)"
        ' 
        ' Password
        ' 
        Password.Cursor = Cursors.IBeam
        Password.Dock = DockStyle.Bottom
        Password.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Password.Location = New Point(10, 35)
        Password.Multiline = True
        Password.Name = "Password"
        Password.PlaceholderText = "Enter Password"
        Password.Size = New Size(425, 30)
        Password.TabIndex = 0
        ' 
        ' Panel10
        ' 
        Panel10.Controls.Add(DateOfBirthLabel)
        Panel10.Controls.Add(DateOfBirth)
        Panel10.Dock = DockStyle.Left
        Panel10.Location = New Point(0, 0)
        Panel10.Name = "Panel10"
        Panel10.Padding = New Padding(10)
        Panel10.Size = New Size(445, 75)
        Panel10.TabIndex = 0
        ' 
        ' DateOfBirthLabel
        ' 
        DateOfBirthLabel.AutoSize = True
        DateOfBirthLabel.Dock = DockStyle.Top
        DateOfBirthLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DateOfBirthLabel.Location = New Point(10, 10)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New Size(98, 14)
        DateOfBirthLabel.TabIndex = 1
        DateOfBirthLabel.Text = "Date of Birth"
        ' 
        ' DateOfBirth
        ' 
        DateOfBirth.Cursor = Cursors.IBeam
        DateOfBirth.Dock = DockStyle.Bottom
        DateOfBirth.Enabled = False
        DateOfBirth.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DateOfBirth.Location = New Point(10, 35)
        DateOfBirth.Multiline = True
        DateOfBirth.Name = "DateOfBirth"
        DateOfBirth.Size = New Size(425, 30)
        DateOfBirth.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Panel5)
        Panel4.Controls.Add(Panel6)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(10, 85)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(897, 75)
        Panel4.TabIndex = 1
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(ShopNameLabel)
        Panel5.Controls.Add(ShopName)
        Panel5.Dock = DockStyle.Right
        Panel5.Location = New Point(452, 0)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(10)
        Panel5.Size = New Size(445, 75)
        Panel5.TabIndex = 1
        ' 
        ' ShopNameLabel
        ' 
        ShopNameLabel.AutoSize = True
        ShopNameLabel.Dock = DockStyle.Top
        ShopNameLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ShopNameLabel.Location = New Point(10, 10)
        ShopNameLabel.Name = "ShopNameLabel"
        ShopNameLabel.Size = New Size(70, 14)
        ShopNameLabel.TabIndex = 1
        ShopNameLabel.Text = "Shop Name"
        ' 
        ' ShopName
        ' 
        ShopName.Cursor = Cursors.IBeam
        ShopName.Dock = DockStyle.Bottom
        ShopName.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ShopName.Location = New Point(10, 35)
        ShopName.Multiline = True
        ShopName.Name = "ShopName"
        ShopName.PlaceholderText = "Enter Shop Name"
        ShopName.Size = New Size(425, 30)
        ShopName.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(AddressLabel)
        Panel6.Controls.Add(Address)
        Panel6.Dock = DockStyle.Left
        Panel6.Location = New Point(0, 0)
        Panel6.Name = "Panel6"
        Panel6.Padding = New Padding(10)
        Panel6.Size = New Size(445, 75)
        Panel6.TabIndex = 0
        ' 
        ' AddressLabel
        ' 
        AddressLabel.AutoSize = True
        AddressLabel.Dock = DockStyle.Top
        AddressLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        AddressLabel.Location = New Point(10, 10)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New Size(56, 14)
        AddressLabel.TabIndex = 1
        AddressLabel.Text = "Address"
        ' 
        ' Address
        ' 
        Address.Cursor = Cursors.IBeam
        Address.Dock = DockStyle.Bottom
        Address.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Address.Location = New Point(10, 35)
        Address.Multiline = True
        Address.Name = "Address"
        Address.PlaceholderText = "Enter Address"
        Address.Size = New Size(425, 30)
        Address.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(10, 10)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(897, 75)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(PhoneNumberLabel)
        Panel3.Controls.Add(Phone)
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(452, 0)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(10)
        Panel3.Size = New Size(445, 75)
        Panel3.TabIndex = 1
        ' 
        ' PhoneNumberLabel
        ' 
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Dock = DockStyle.Top
        PhoneNumberLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        PhoneNumberLabel.Location = New Point(10, 10)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New Size(91, 14)
        PhoneNumberLabel.TabIndex = 1
        PhoneNumberLabel.Text = "Phone Number"
        ' 
        ' Phone
        ' 
        Phone.Cursor = Cursors.IBeam
        Phone.Dock = DockStyle.Bottom
        Phone.Enabled = False
        Phone.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Phone.Location = New Point(10, 35)
        Phone.Multiline = True
        Phone.Name = "Phone"
        Phone.Size = New Size(425, 30)
        Phone.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(UserNameLabel)
        Panel2.Controls.Add(UserName)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(10)
        Panel2.Size = New Size(445, 75)
        Panel2.TabIndex = 0
        ' 
        ' UserNameLabel
        ' 
        UserNameLabel.AutoSize = True
        UserNameLabel.Dock = DockStyle.Top
        UserNameLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        UserNameLabel.Location = New Point(10, 10)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New Size(70, 14)
        UserNameLabel.TabIndex = 1
        UserNameLabel.Text = "User Name"
        ' 
        ' UserName
        ' 
        UserName.Cursor = Cursors.IBeam
        UserName.Dock = DockStyle.Bottom
        UserName.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        UserName.Location = New Point(10, 35)
        UserName.Multiline = True
        UserName.Name = "UserName"
        UserName.PlaceholderText = "Enter User Name"
        UserName.Size = New Size(425, 30)
        UserName.TabIndex = 0
        ' 
        ' Account
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        ClientSize = New Size(917, 564)
        Controls.Add(CreateProductContainer)
        Controls.Add(HeaderPanel)
        Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "Account"
        Text = "Account"
        HeaderPanel.ResumeLayout(False)
        HeaderPanel.PerformLayout()
        CreateProductContainer.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents Header As Label
    Friend WithEvents CreateProductContainer As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents UpdateProfileButton As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents DateOfBirthLabel As Label
    Friend WithEvents DateOfBirth As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ShopNameLabel As Label
    Friend WithEvents ShopName As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents AddressLabel As Label
    Friend WithEvents Address As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PhoneNumberLabel As Label
    Friend WithEvents Phone As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UserNameLabel As Label
    Friend WithEvents UserName As TextBox
End Class
