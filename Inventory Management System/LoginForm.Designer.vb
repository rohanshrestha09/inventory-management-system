<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LoginForm))
        UserIcon = New PictureBox()
        Panel1 = New Panel()
        PhoneNumberInput = New TextBox()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        ShowPasswordCheckbox = New CheckBox()
        PasswordInput = New TextBox()
        PictureBox3 = New PictureBox()
        LoginButton = New Button()
        CancelLoginButton = New Button()
        Logo = New PictureBox()
        CType(UserIcon, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' UserIcon
        ' 
        UserIcon.Image = CType(resources.GetObject("UserIcon.Image"), Image)
        UserIcon.Location = New Point(171, 59)
        UserIcon.Name = "UserIcon"
        UserIcon.Size = New Size(156, 156)
        UserIcon.SizeMode = PictureBoxSizeMode.StretchImage
        UserIcon.TabIndex = 5
        UserIcon.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(PhoneNumberInput)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(85, 285)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(323, 50)
        Panel1.TabIndex = 7
        ' 
        ' PhoneNumberInput
        ' 
        PhoneNumberInput.BorderStyle = BorderStyle.None
        PhoneNumberInput.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        PhoneNumberInput.ForeColor = Color.Black
        PhoneNumberInput.Location = New Point(51, 18)
        PhoneNumberInput.Name = "PhoneNumberInput"
        PhoneNumberInput.PlaceholderText = "Phone Number"
        PhoneNumberInput.Size = New Size(258, 16)
        PhoneNumberInput.TabIndex = 9
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(10, 10)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(30, 30)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(ShowPasswordCheckbox)
        Panel2.Controls.Add(PasswordInput)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(85, 341)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(323, 50)
        Panel2.TabIndex = 10
        ' 
        ' ShowPasswordCheckbox
        ' 
        ShowPasswordCheckbox.AutoSize = True
        ShowPasswordCheckbox.BackgroundImageLayout = ImageLayout.None
        ShowPasswordCheckbox.Location = New Point(295, 19)
        ShowPasswordCheckbox.Name = "ShowPasswordCheckbox"
        ShowPasswordCheckbox.Size = New Size(15, 14)
        ShowPasswordCheckbox.TabIndex = 13
        ShowPasswordCheckbox.UseVisualStyleBackColor = True
        ' 
        ' PasswordInput
        ' 
        PasswordInput.BorderStyle = BorderStyle.None
        PasswordInput.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        PasswordInput.ForeColor = Color.Black
        PasswordInput.Location = New Point(51, 18)
        PasswordInput.Name = "PasswordInput"
        PasswordInput.PasswordChar = "•"c
        PasswordInput.PlaceholderText = "Password"
        PasswordInput.Size = New Size(258, 16)
        PasswordInput.TabIndex = 9
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(10, 10)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(30, 30)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        ' 
        ' LoginButton
        ' 
        LoginButton.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        LoginButton.Cursor = Cursors.Hand
        LoginButton.FlatStyle = FlatStyle.Flat
        LoginButton.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        LoginButton.ForeColor = Color.White
        LoginButton.Location = New Point(85, 397)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(323, 45)
        LoginButton.TabIndex = 11
        LoginButton.Text = "Login"
        LoginButton.UseVisualStyleBackColor = False
        ' 
        ' CancelLoginButton
        ' 
        CancelLoginButton.Cursor = Cursors.Hand
        CancelLoginButton.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        CancelLoginButton.Location = New Point(85, 448)
        CancelLoginButton.Name = "CancelLoginButton"
        CancelLoginButton.Size = New Size(323, 45)
        CancelLoginButton.TabIndex = 12
        CancelLoginButton.Text = "Cancel"
        CancelLoginButton.UseVisualStyleBackColor = True
        ' 
        ' Logo
        ' 
        Logo.Image = CType(resources.GetObject("Logo.Image"), Image)
        Logo.Location = New Point(92, 221)
        Logo.Name = "Logo"
        Logo.Size = New Size(310, 50)
        Logo.SizeMode = PictureBoxSizeMode.StretchImage
        Logo.TabIndex = 13
        Logo.TabStop = False
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        ClientSize = New Size(491, 656)
        Controls.Add(Logo)
        Controls.Add(CancelLoginButton)
        Controls.Add(LoginButton)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(UserIcon)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
        CType(UserIcon, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(Logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents UserIcon As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PasswordInput As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PhoneNumberInput As TextBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents CancelLoginButton As Button
    Friend WithEvents ShowPasswordCheckbox As CheckBox
    Friend WithEvents Logo As PictureBox
End Class
