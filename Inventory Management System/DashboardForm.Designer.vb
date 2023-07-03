<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        LogoPanel = New Panel()
        Header = New Label()
        DashboardContainerPanel = New Panel()
        OrderKPIPanel = New Panel()
        ProfilePanel = New Panel()
        Panel1 = New Panel()
        EditProfileButton = New Button()
        Panel4 = New Panel()
        RegisteredAtContainer = New Panel()
        RegisteredAt = New Label()
        RegisteredAtLabel = New Label()
        DateOfBirthContainer = New Panel()
        DateOfBirth = New Label()
        DateOfBirthLabel = New Label()
        Profile = New Panel()
        Panel3 = New Panel()
        AddressContainer = New Panel()
        Address = New Label()
        AddressLabel = New Label()
        ShopNameContainer = New Panel()
        ShopName = New Label()
        ShopNameLabel = New Label()
        PhoneNumberContainer = New Panel()
        PhoneNumber = New Label()
        PhoneNumberLabel = New Label()
        Panel2 = New Panel()
        UserName = New Label()
        LogoPanel.SuspendLayout()
        DashboardContainerPanel.SuspendLayout()
        ProfilePanel.SuspendLayout()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        RegisteredAtContainer.SuspendLayout()
        DateOfBirthContainer.SuspendLayout()
        Profile.SuspendLayout()
        Panel3.SuspendLayout()
        AddressContainer.SuspendLayout()
        ShopNameContainer.SuspendLayout()
        PhoneNumberContainer.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' LogoPanel
        ' 
        LogoPanel.BackColor = Color.White
        LogoPanel.Controls.Add(Header)
        LogoPanel.Dock = DockStyle.Top
        LogoPanel.Location = New Point(0, 0)
        LogoPanel.Name = "LogoPanel"
        LogoPanel.Size = New Size(917, 50)
        LogoPanel.TabIndex = 0
        ' 
        ' Header
        ' 
        Header.AutoSize = True
        Header.Font = New Font("CaskaydiaCove NF", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Header.Location = New Point(12, 8)
        Header.Name = "Header"
        Header.Size = New Size(158, 31)
        Header.TabIndex = 0
        Header.Text = "Dashboard"
        ' 
        ' DashboardContainerPanel
        ' 
        DashboardContainerPanel.BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        DashboardContainerPanel.Controls.Add(OrderKPIPanel)
        DashboardContainerPanel.Controls.Add(ProfilePanel)
        DashboardContainerPanel.Dock = DockStyle.Bottom
        DashboardContainerPanel.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DashboardContainerPanel.Location = New Point(0, 69)
        DashboardContainerPanel.Name = "DashboardContainerPanel"
        DashboardContainerPanel.Size = New Size(917, 495)
        DashboardContainerPanel.TabIndex = 1
        ' 
        ' OrderKPIPanel
        ' 
        OrderKPIPanel.BackColor = Color.White
        OrderKPIPanel.Dock = DockStyle.Right
        OrderKPIPanel.Location = New Point(252, 0)
        OrderKPIPanel.Name = "OrderKPIPanel"
        OrderKPIPanel.Size = New Size(665, 495)
        OrderKPIPanel.TabIndex = 1
        ' 
        ' ProfilePanel
        ' 
        ProfilePanel.BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        ProfilePanel.Controls.Add(Panel1)
        ProfilePanel.Controls.Add(Profile)
        ProfilePanel.Dock = DockStyle.Left
        ProfilePanel.Location = New Point(0, 0)
        ProfilePanel.Name = "ProfilePanel"
        ProfilePanel.Size = New Size(233, 495)
        ProfilePanel.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(EditProfileButton)
        Panel1.Controls.Add(Panel4)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 286)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(233, 209)
        Panel1.TabIndex = 1
        ' 
        ' EditProfileButton
        ' 
        EditProfileButton.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        EditProfileButton.Cursor = Cursors.Hand
        EditProfileButton.FlatStyle = FlatStyle.Flat
        EditProfileButton.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        EditProfileButton.ForeColor = Color.White
        EditProfileButton.Location = New Point(15, 155)
        EditProfileButton.Name = "EditProfileButton"
        EditProfileButton.Size = New Size(203, 40)
        EditProfileButton.TabIndex = 3
        EditProfileButton.Text = "Edit Profile >>"
        EditProfileButton.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(246), CByte(250), CByte(255))
        Panel4.Controls.Add(RegisteredAtContainer)
        Panel4.Controls.Add(DateOfBirthContainer)
        Panel4.Location = New Point(15, 18)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(203, 122)
        Panel4.TabIndex = 2
        ' 
        ' RegisteredAtContainer
        ' 
        RegisteredAtContainer.Controls.Add(RegisteredAt)
        RegisteredAtContainer.Controls.Add(RegisteredAtLabel)
        RegisteredAtContainer.Dock = DockStyle.Top
        RegisteredAtContainer.Location = New Point(0, 60)
        RegisteredAtContainer.Name = "RegisteredAtContainer"
        RegisteredAtContainer.Size = New Size(203, 60)
        RegisteredAtContainer.TabIndex = 1
        ' 
        ' RegisteredAt
        ' 
        RegisteredAt.AutoSize = True
        RegisteredAt.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        RegisteredAt.Location = New Point(13, 32)
        RegisteredAt.Name = "RegisteredAt"
        RegisteredAt.Size = New Size(103, 15)
        RegisteredAt.TabIndex = 1
        RegisteredAt.Text = "Jun 12, 2023"
        ' 
        ' RegisteredAtLabel
        ' 
        RegisteredAtLabel.AutoSize = True
        RegisteredAtLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        RegisteredAtLabel.ForeColor = SystemColors.ControlDarkDark
        RegisteredAtLabel.Location = New Point(13, 11)
        RegisteredAtLabel.Name = "RegisteredAtLabel"
        RegisteredAtLabel.Size = New Size(98, 14)
        RegisteredAtLabel.TabIndex = 0
        RegisteredAtLabel.Text = "Registered At"
        ' 
        ' DateOfBirthContainer
        ' 
        DateOfBirthContainer.Controls.Add(DateOfBirth)
        DateOfBirthContainer.Controls.Add(DateOfBirthLabel)
        DateOfBirthContainer.Dock = DockStyle.Top
        DateOfBirthContainer.Location = New Point(0, 0)
        DateOfBirthContainer.Name = "DateOfBirthContainer"
        DateOfBirthContainer.Size = New Size(203, 60)
        DateOfBirthContainer.TabIndex = 0
        ' 
        ' DateOfBirth
        ' 
        DateOfBirth.AutoSize = True
        DateOfBirth.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DateOfBirth.Location = New Point(13, 32)
        DateOfBirth.Name = "DateOfBirth"
        DateOfBirth.Size = New Size(95, 15)
        DateOfBirth.TabIndex = 1
        DateOfBirth.Text = "Jun 3, 2023"
        ' 
        ' DateOfBirthLabel
        ' 
        DateOfBirthLabel.AutoSize = True
        DateOfBirthLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DateOfBirthLabel.ForeColor = SystemColors.ControlDarkDark
        DateOfBirthLabel.Location = New Point(13, 11)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New Size(98, 14)
        DateOfBirthLabel.TabIndex = 0
        DateOfBirthLabel.Text = "Date of Birth"
        ' 
        ' Profile
        ' 
        Profile.BackColor = Color.White
        Profile.Controls.Add(Panel3)
        Profile.Controls.Add(Panel2)
        Profile.Dock = DockStyle.Top
        Profile.Location = New Point(0, 0)
        Profile.Name = "Profile"
        Profile.Size = New Size(233, 266)
        Profile.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(246), CByte(250), CByte(255))
        Panel3.Controls.Add(AddressContainer)
        Panel3.Controls.Add(ShopNameContainer)
        Panel3.Controls.Add(PhoneNumberContainer)
        Panel3.Location = New Point(14, 66)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(203, 182)
        Panel3.TabIndex = 1
        ' 
        ' AddressContainer
        ' 
        AddressContainer.Controls.Add(Address)
        AddressContainer.Controls.Add(AddressLabel)
        AddressContainer.Dock = DockStyle.Top
        AddressContainer.Location = New Point(0, 120)
        AddressContainer.Name = "AddressContainer"
        AddressContainer.Size = New Size(203, 60)
        AddressContainer.TabIndex = 2
        ' 
        ' Address
        ' 
        Address.AutoSize = True
        Address.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Address.Location = New Point(13, 32)
        Address.Name = "Address"
        Address.Size = New Size(159, 15)
        Address.TabIndex = 1
        Address.Text = "Siddhipur, Lalitpur"
        ' 
        ' AddressLabel
        ' 
        AddressLabel.AutoSize = True
        AddressLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        AddressLabel.ForeColor = SystemColors.ControlDarkDark
        AddressLabel.Location = New Point(13, 11)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New Size(56, 14)
        AddressLabel.TabIndex = 0
        AddressLabel.Text = "Address"
        ' 
        ' ShopNameContainer
        ' 
        ShopNameContainer.Controls.Add(ShopName)
        ShopNameContainer.Controls.Add(ShopNameLabel)
        ShopNameContainer.Dock = DockStyle.Top
        ShopNameContainer.Location = New Point(0, 60)
        ShopNameContainer.Name = "ShopNameContainer"
        ShopNameContainer.Size = New Size(203, 60)
        ShopNameContainer.TabIndex = 1
        ' 
        ' ShopName
        ' 
        ShopName.AutoSize = True
        ShopName.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ShopName.Location = New Point(13, 32)
        ShopName.Name = "ShopName"
        ShopName.Size = New Size(87, 15)
        ShopName.TabIndex = 1
        ShopName.Text = "Naya Pasal"
        ' 
        ' ShopNameLabel
        ' 
        ShopNameLabel.AutoSize = True
        ShopNameLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ShopNameLabel.ForeColor = SystemColors.ControlDarkDark
        ShopNameLabel.Location = New Point(13, 11)
        ShopNameLabel.Name = "ShopNameLabel"
        ShopNameLabel.Size = New Size(70, 14)
        ShopNameLabel.TabIndex = 0
        ShopNameLabel.Text = "Shop Name"
        ' 
        ' PhoneNumberContainer
        ' 
        PhoneNumberContainer.Controls.Add(PhoneNumber)
        PhoneNumberContainer.Controls.Add(PhoneNumberLabel)
        PhoneNumberContainer.Dock = DockStyle.Top
        PhoneNumberContainer.Location = New Point(0, 0)
        PhoneNumberContainer.Name = "PhoneNumberContainer"
        PhoneNumberContainer.Size = New Size(203, 60)
        PhoneNumberContainer.TabIndex = 0
        ' 
        ' PhoneNumber
        ' 
        PhoneNumber.AutoSize = True
        PhoneNumber.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        PhoneNumber.Location = New Point(13, 32)
        PhoneNumber.Name = "PhoneNumber"
        PhoneNumber.Size = New Size(87, 15)
        PhoneNumber.TabIndex = 1
        PhoneNumber.Text = "9800000000"
        ' 
        ' PhoneNumberLabel
        ' 
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        PhoneNumberLabel.ForeColor = SystemColors.ControlDarkDark
        PhoneNumberLabel.Location = New Point(13, 11)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New Size(91, 14)
        PhoneNumberLabel.TabIndex = 0
        PhoneNumberLabel.Text = "Phone Number"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(184), CByte(135), CByte(70))
        Panel2.Controls.Add(UserName)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(233, 48)
        Panel2.TabIndex = 0
        ' 
        ' UserName
        ' 
        UserName.AutoSize = True
        UserName.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        UserName.ForeColor = Color.White
        UserName.Location = New Point(14, 16)
        UserName.Name = "UserName"
        UserName.Size = New Size(183, 15)
        UserName.TabIndex = 0
        UserName.Text = "Welcome Rohan Shrestha"
        ' 
        ' DashboardForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        ClientSize = New Size(917, 564)
        Controls.Add(DashboardContainerPanel)
        Controls.Add(LogoPanel)
        Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "DashboardForm"
        Text = "DashboardForm"
        LogoPanel.ResumeLayout(False)
        LogoPanel.PerformLayout()
        DashboardContainerPanel.ResumeLayout(False)
        ProfilePanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        RegisteredAtContainer.ResumeLayout(False)
        RegisteredAtContainer.PerformLayout()
        DateOfBirthContainer.ResumeLayout(False)
        DateOfBirthContainer.PerformLayout()
        Profile.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        AddressContainer.ResumeLayout(False)
        AddressContainer.PerformLayout()
        ShopNameContainer.ResumeLayout(False)
        ShopNameContainer.PerformLayout()
        PhoneNumberContainer.ResumeLayout(False)
        PhoneNumberContainer.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LogoPanel As Panel
    Friend WithEvents Header As Label
    Friend WithEvents DashboardContainerPanel As Panel
    Friend WithEvents OrderKPIPanel As Panel
    Friend WithEvents ProfilePanel As Panel
    Friend WithEvents Profile As Panel
    Friend WithEvents UserName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PhoneNumberContainer As Panel
    Friend WithEvents PhoneNumber As Label
    Friend WithEvents PhoneNumberLabel As Label
    Friend WithEvents ShopNameContainer As Panel
    Friend WithEvents ShopName As Label
    Friend WithEvents ShopNameLabel As Label
    Friend WithEvents AddressContainer As Panel
    Friend WithEvents Address As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RegisteredAtContainer As Panel
    Friend WithEvents RegisteredAt As Label
    Friend WithEvents RegisteredAtLabel As Label
    Friend WithEvents DateOfBirthContainer As Panel
    Friend WithEvents DateOfBirth As Label
    Friend WithEvents DateOfBirthLabel As Label
    Friend WithEvents EditProfileButton As Button
End Class
