﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Panel1 = New Panel()
        DashboardContainer = New Panel()
        Menu = New Panel()
        AccountPanel = New Panel()
        AccountButton = New Button()
        PictureBox4 = New PictureBox()
        OrderPanel = New Panel()
        OrderButton = New Button()
        PictureBox3 = New PictureBox()
        ProductPanel = New Panel()
        ProductButton = New Button()
        PictureBox2 = New PictureBox()
        DashboardPanel = New Panel()
        DashboardButton = New Button()
        PictureBox1 = New PictureBox()
        Header = New Panel()
        Logo = New PictureBox()
        Panel1.SuspendLayout()
        Menu.SuspendLayout()
        AccountPanel.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        OrderPanel.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        ProductPanel.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        DashboardPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Header.SuspendLayout()
        CType(Logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        Panel1.Controls.Add(DashboardContainer)
        Panel1.Controls.Add(Menu)
        Panel1.Controls.Add(Header)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1127, 637)
        Panel1.TabIndex = 0
        ' 
        ' DashboardContainer
        ' 
        DashboardContainer.BackColor = Color.White
        DashboardContainer.Dock = DockStyle.Right
        DashboardContainer.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DashboardContainer.Location = New Point(210, 73)
        DashboardContainer.Name = "DashboardContainer"
        DashboardContainer.Size = New Size(917, 564)
        DashboardContainer.TabIndex = 2
        ' 
        ' Menu
        ' 
        Menu.BackColor = Color.White
        Menu.Controls.Add(AccountPanel)
        Menu.Controls.Add(OrderPanel)
        Menu.Controls.Add(ProductPanel)
        Menu.Controls.Add(DashboardPanel)
        Menu.Dock = DockStyle.Left
        Menu.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Menu.Location = New Point(0, 73)
        Menu.Name = "Menu"
        Menu.Size = New Size(190, 564)
        Menu.TabIndex = 1
        ' 
        ' AccountPanel
        ' 
        AccountPanel.Controls.Add(AccountButton)
        AccountPanel.Controls.Add(PictureBox4)
        AccountPanel.Cursor = Cursors.Hand
        AccountPanel.Dock = DockStyle.Top
        AccountPanel.Location = New Point(0, 150)
        AccountPanel.Name = "AccountPanel"
        AccountPanel.Size = New Size(190, 50)
        AccountPanel.TabIndex = 3
        ' 
        ' AccountButton
        ' 
        AccountButton.BackColor = Color.Transparent
        AccountButton.Cursor = Cursors.Hand
        AccountButton.FlatAppearance.BorderSize = 0
        AccountButton.FlatStyle = FlatStyle.Flat
        AccountButton.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        AccountButton.ForeColor = Color.Black
        AccountButton.Location = New Point(40, 3)
        AccountButton.Name = "AccountButton"
        AccountButton.Size = New Size(147, 44)
        AccountButton.TabIndex = 1
        AccountButton.Text = "Account"
        AccountButton.TextAlign = ContentAlignment.MiddleLeft
        AccountButton.UseVisualStyleBackColor = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(14, 15)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(20, 20)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' OrderPanel
        ' 
        OrderPanel.Controls.Add(OrderButton)
        OrderPanel.Controls.Add(PictureBox3)
        OrderPanel.Cursor = Cursors.Hand
        OrderPanel.Dock = DockStyle.Top
        OrderPanel.Location = New Point(0, 100)
        OrderPanel.Name = "OrderPanel"
        OrderPanel.Size = New Size(190, 50)
        OrderPanel.TabIndex = 2
        ' 
        ' OrderButton
        ' 
        OrderButton.BackColor = Color.Transparent
        OrderButton.Cursor = Cursors.Hand
        OrderButton.FlatAppearance.BorderSize = 0
        OrderButton.FlatStyle = FlatStyle.Flat
        OrderButton.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        OrderButton.ForeColor = Color.Black
        OrderButton.Location = New Point(40, 3)
        OrderButton.Name = "OrderButton"
        OrderButton.Size = New Size(147, 44)
        OrderButton.TabIndex = 1
        OrderButton.Text = "Order"
        OrderButton.TextAlign = ContentAlignment.MiddleLeft
        OrderButton.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(14, 15)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(20, 20)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' ProductPanel
        ' 
        ProductPanel.Controls.Add(ProductButton)
        ProductPanel.Controls.Add(PictureBox2)
        ProductPanel.Cursor = Cursors.Hand
        ProductPanel.Dock = DockStyle.Top
        ProductPanel.Location = New Point(0, 50)
        ProductPanel.Name = "ProductPanel"
        ProductPanel.Size = New Size(190, 50)
        ProductPanel.TabIndex = 1
        ' 
        ' ProductButton
        ' 
        ProductButton.BackColor = Color.Transparent
        ProductButton.Cursor = Cursors.Hand
        ProductButton.FlatAppearance.BorderSize = 0
        ProductButton.FlatStyle = FlatStyle.Flat
        ProductButton.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ProductButton.ForeColor = Color.Black
        ProductButton.Location = New Point(40, 3)
        ProductButton.Name = "ProductButton"
        ProductButton.Size = New Size(147, 44)
        ProductButton.TabIndex = 1
        ProductButton.Text = "Product"
        ProductButton.TextAlign = ContentAlignment.MiddleLeft
        ProductButton.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(14, 15)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(20, 20)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' DashboardPanel
        ' 
        DashboardPanel.BackColor = Color.Transparent
        DashboardPanel.Controls.Add(DashboardButton)
        DashboardPanel.Controls.Add(PictureBox1)
        DashboardPanel.Cursor = Cursors.Hand
        DashboardPanel.Dock = DockStyle.Top
        DashboardPanel.Location = New Point(0, 0)
        DashboardPanel.Name = "DashboardPanel"
        DashboardPanel.Size = New Size(190, 50)
        DashboardPanel.TabIndex = 0
        ' 
        ' DashboardButton
        ' 
        DashboardButton.BackColor = Color.Transparent
        DashboardButton.Cursor = Cursors.Hand
        DashboardButton.FlatAppearance.BorderSize = 0
        DashboardButton.FlatAppearance.MouseDownBackColor = Color.Transparent
        DashboardButton.FlatAppearance.MouseOverBackColor = Color.Transparent
        DashboardButton.FlatStyle = FlatStyle.Flat
        DashboardButton.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DashboardButton.ForeColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        DashboardButton.Location = New Point(40, 3)
        DashboardButton.Name = "DashboardButton"
        DashboardButton.Size = New Size(147, 44)
        DashboardButton.TabIndex = 1
        DashboardButton.Text = "Dashboard"
        DashboardButton.TextAlign = ContentAlignment.MiddleLeft
        DashboardButton.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(14, 15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(20, 20)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Header
        ' 
        Header.BackColor = Color.White
        Header.Controls.Add(Logo)
        Header.Dock = DockStyle.Top
        Header.Location = New Point(0, 0)
        Header.Name = "Header"
        Header.Size = New Size(1127, 73)
        Header.TabIndex = 0
        ' 
        ' Logo
        ' 
        Logo.Dock = DockStyle.Left
        Logo.Image = CType(resources.GetObject("Logo.Image"), Image)
        Logo.Location = New Point(0, 0)
        Logo.Name = "Logo"
        Logo.Size = New Size(414, 73)
        Logo.SizeMode = PictureBoxSizeMode.StretchImage
        Logo.TabIndex = 0
        Logo.TabStop = False
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1127, 637)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Dashboard"
        Text = "Dashboard"
        Panel1.ResumeLayout(False)
        Menu.ResumeLayout(False)
        AccountPanel.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        OrderPanel.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ProductPanel.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        DashboardPanel.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Header.ResumeLayout(False)
        CType(Logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Header As Panel
    Friend WithEvents Menu As Panel
    Friend WithEvents DashboardPanel As Panel
    Friend WithEvents DashboardButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Logo As PictureBox
    Friend WithEvents DashboardContainer As Panel
    Friend WithEvents AccountPanel As Panel
    Friend WithEvents AccountButton As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents OrderPanel As Panel
    Friend WithEvents OrderButton As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ProductPanel As Panel
    Friend WithEvents ProductButton As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
