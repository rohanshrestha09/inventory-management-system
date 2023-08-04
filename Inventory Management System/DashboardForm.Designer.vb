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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        HeaderPanel = New Panel()
        Header = New Label()
        DashboardContainerPanel = New Panel()
        KPIPanelContainer = New Panel()
        Panel12 = New Panel()
        RecentOrdersTable = New DataGridView()
        RecentOrdersLabel = New Label()
        KPIPanel = New Panel()
        ProductKPI = New Panel()
        ProductKPITimeSelector = New ComboBox()
        Panel13 = New Panel()
        Panel14 = New Panel()
        Panel15 = New Panel()
        MostBoughtProductTotalAmount = New Label()
        MostBoughtProductTotalAmountLabel = New Label()
        Panel16 = New Panel()
        Panel17 = New Panel()
        MostBoughtProductTotalUnits = New Label()
        MostBoughtProductTotalUnitsLabel = New Label()
        Panel18 = New Panel()
        Panel19 = New Panel()
        MostBoughtProductName = New Label()
        MostBoughtProductNameLabel = New Label()
        MostBoughtProductKPILabel = New Label()
        OrderKPI = New Panel()
        OrderKPITimeSelector = New ComboBox()
        Panel6 = New Panel()
        Panel9 = New Panel()
        Panel10 = New Panel()
        TotalOrdersDelivered = New Label()
        TotalOrdersDeliveredLabel = New Label()
        Panel5 = New Panel()
        Panel7 = New Panel()
        TotalOrdersAmount = New Label()
        TotalOrdersAmountLabel = New Label()
        Panel8 = New Panel()
        Panel11 = New Panel()
        TotalOrders = New Label()
        TotalOrdersLabel = New Label()
        OrderKPILabel = New Label()
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
        HeaderPanel.SuspendLayout()
        DashboardContainerPanel.SuspendLayout()
        KPIPanelContainer.SuspendLayout()
        Panel12.SuspendLayout()
        CType(RecentOrdersTable, ComponentModel.ISupportInitialize).BeginInit()
        KPIPanel.SuspendLayout()
        ProductKPI.SuspendLayout()
        Panel13.SuspendLayout()
        Panel14.SuspendLayout()
        Panel15.SuspendLayout()
        Panel16.SuspendLayout()
        Panel17.SuspendLayout()
        Panel18.SuspendLayout()
        Panel19.SuspendLayout()
        OrderKPI.SuspendLayout()
        Panel6.SuspendLayout()
        Panel9.SuspendLayout()
        Panel10.SuspendLayout()
        Panel5.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        Panel11.SuspendLayout()
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
        ' HeaderPanel
        ' 
        HeaderPanel.BackColor = Color.White
        HeaderPanel.Controls.Add(Header)
        HeaderPanel.Dock = DockStyle.Top
        HeaderPanel.Location = New Point(0, 0)
        HeaderPanel.Name = "HeaderPanel"
        HeaderPanel.Padding = New Padding(9)
        HeaderPanel.Size = New Size(917, 50)
        HeaderPanel.TabIndex = 0
        ' 
        ' Header
        ' 
        Header.AutoSize = True
        Header.Dock = DockStyle.Top
        Header.Font = New Font("CaskaydiaCove NF", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Header.Location = New Point(9, 9)
        Header.Name = "Header"
        Header.Size = New Size(158, 31)
        Header.TabIndex = 0
        Header.Text = "Dashboard"
        ' 
        ' DashboardContainerPanel
        ' 
        DashboardContainerPanel.BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        DashboardContainerPanel.Controls.Add(KPIPanelContainer)
        DashboardContainerPanel.Controls.Add(ProfilePanel)
        DashboardContainerPanel.Dock = DockStyle.Bottom
        DashboardContainerPanel.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DashboardContainerPanel.Location = New Point(0, 69)
        DashboardContainerPanel.Name = "DashboardContainerPanel"
        DashboardContainerPanel.Size = New Size(917, 495)
        DashboardContainerPanel.TabIndex = 1
        ' 
        ' KPIPanelContainer
        ' 
        KPIPanelContainer.BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        KPIPanelContainer.Controls.Add(Panel12)
        KPIPanelContainer.Controls.Add(KPIPanel)
        KPIPanelContainer.Dock = DockStyle.Right
        KPIPanelContainer.Location = New Point(252, 0)
        KPIPanelContainer.Name = "KPIPanelContainer"
        KPIPanelContainer.Size = New Size(665, 495)
        KPIPanelContainer.TabIndex = 1
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.White
        Panel12.Controls.Add(RecentOrdersTable)
        Panel12.Controls.Add(RecentOrdersLabel)
        Panel12.Dock = DockStyle.Bottom
        Panel12.Location = New Point(0, 263)
        Panel12.Name = "Panel12"
        Panel12.Padding = New Padding(9)
        Panel12.Size = New Size(665, 232)
        Panel12.TabIndex = 3
        ' 
        ' RecentOrdersTable
        ' 
        RecentOrdersTable.AllowUserToAddRows = False
        RecentOrdersTable.AllowUserToDeleteRows = False
        RecentOrdersTable.AllowUserToResizeColumns = False
        RecentOrdersTable.AllowUserToResizeRows = False
        RecentOrdersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        RecentOrdersTable.BackgroundColor = Color.FromArgb(CByte(246), CByte(250), CByte(255))
        RecentOrdersTable.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(246), CByte(250), CByte(255))
        DataGridViewCellStyle1.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(246), CByte(250), CByte(255))
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        RecentOrdersTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        RecentOrdersTable.ColumnHeadersHeight = 35
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        RecentOrdersTable.DefaultCellStyle = DataGridViewCellStyle2
        RecentOrdersTable.Dock = DockStyle.Bottom
        RecentOrdersTable.GridColor = Color.FromArgb(CByte(246), CByte(250), CByte(255))
        RecentOrdersTable.Location = New Point(9, 41)
        RecentOrdersTable.Name = "RecentOrdersTable"
        RecentOrdersTable.RowHeadersVisible = False
        RecentOrdersTable.RowTemplate.Height = 35
        RecentOrdersTable.RowTemplate.Resizable = DataGridViewTriState.False
        RecentOrdersTable.ScrollBars = ScrollBars.Vertical
        RecentOrdersTable.Size = New Size(647, 182)
        RecentOrdersTable.TabIndex = 1
        ' 
        ' RecentOrdersLabel
        ' 
        RecentOrdersLabel.AutoSize = True
        RecentOrdersLabel.Dock = DockStyle.Top
        RecentOrdersLabel.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        RecentOrdersLabel.Location = New Point(9, 9)
        RecentOrdersLabel.Name = "RecentOrdersLabel"
        RecentOrdersLabel.Size = New Size(111, 15)
        RecentOrdersLabel.TabIndex = 0
        RecentOrdersLabel.Text = "Recent Orders"
        ' 
        ' KPIPanel
        ' 
        KPIPanel.Controls.Add(ProductKPI)
        KPIPanel.Controls.Add(OrderKPI)
        KPIPanel.Dock = DockStyle.Top
        KPIPanel.Location = New Point(0, 0)
        KPIPanel.Name = "KPIPanel"
        KPIPanel.Size = New Size(665, 244)
        KPIPanel.TabIndex = 2
        ' 
        ' ProductKPI
        ' 
        ProductKPI.BackColor = Color.White
        ProductKPI.Controls.Add(ProductKPITimeSelector)
        ProductKPI.Controls.Add(Panel13)
        ProductKPI.Controls.Add(MostBoughtProductKPILabel)
        ProductKPI.Dock = DockStyle.Bottom
        ProductKPI.Location = New Point(0, 132)
        ProductKPI.Name = "ProductKPI"
        ProductKPI.Padding = New Padding(9)
        ProductKPI.Size = New Size(665, 112)
        ProductKPI.TabIndex = 2
        ' 
        ' ProductKPITimeSelector
        ' 
        ProductKPITimeSelector.Font = New Font("CaskaydiaCove NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        ProductKPITimeSelector.FormattingEnabled = True
        ProductKPITimeSelector.Items.AddRange(New Object() {"This Month", "This Year"})
        ProductKPITimeSelector.Location = New Point(535, 8)
        ProductKPITimeSelector.Name = "ProductKPITimeSelector"
        ProductKPITimeSelector.Size = New Size(121, 21)
        ProductKPITimeSelector.TabIndex = 3
        ProductKPITimeSelector.Text = "Select time"
        ' 
        ' Panel13
        ' 
        Panel13.Controls.Add(Panel14)
        Panel13.Controls.Add(Panel16)
        Panel13.Controls.Add(Panel18)
        Panel13.Dock = DockStyle.Bottom
        Panel13.Location = New Point(9, 34)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(647, 69)
        Panel13.TabIndex = 1
        ' 
        ' Panel14
        ' 
        Panel14.Controls.Add(Panel15)
        Panel14.Dock = DockStyle.Left
        Panel14.Location = New Point(430, 0)
        Panel14.Name = "Panel14"
        Panel14.Padding = New Padding(5)
        Panel14.Size = New Size(215, 69)
        Panel14.TabIndex = 3
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.FromArgb(CByte(246), CByte(250), CByte(255))
        Panel15.Controls.Add(MostBoughtProductTotalAmount)
        Panel15.Controls.Add(MostBoughtProductTotalAmountLabel)
        Panel15.Location = New Point(5, 5)
        Panel15.Name = "Panel15"
        Panel15.Padding = New Padding(12)
        Panel15.Size = New Size(206, 60)
        Panel15.TabIndex = 3
        ' 
        ' MostBoughtProductTotalAmount
        ' 
        MostBoughtProductTotalAmount.AutoSize = True
        MostBoughtProductTotalAmount.Dock = DockStyle.Top
        MostBoughtProductTotalAmount.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        MostBoughtProductTotalAmount.Location = New Point(12, 26)
        MostBoughtProductTotalAmount.Name = "MostBoughtProductTotalAmount"
        MostBoughtProductTotalAmount.Padding = New Padding(0, 5, 0, 0)
        MostBoughtProductTotalAmount.Size = New Size(47, 20)
        MostBoughtProductTotalAmount.TabIndex = 1
        MostBoughtProductTotalAmount.Text = "Rs. 0"
        ' 
        ' MostBoughtProductTotalAmountLabel
        ' 
        MostBoughtProductTotalAmountLabel.AutoSize = True
        MostBoughtProductTotalAmountLabel.Dock = DockStyle.Top
        MostBoughtProductTotalAmountLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        MostBoughtProductTotalAmountLabel.ForeColor = SystemColors.ControlDarkDark
        MostBoughtProductTotalAmountLabel.Location = New Point(12, 12)
        MostBoughtProductTotalAmountLabel.Name = "MostBoughtProductTotalAmountLabel"
        MostBoughtProductTotalAmountLabel.Size = New Size(91, 14)
        MostBoughtProductTotalAmountLabel.TabIndex = 0
        MostBoughtProductTotalAmountLabel.Text = "Total Amount"
        ' 
        ' Panel16
        ' 
        Panel16.Controls.Add(Panel17)
        Panel16.Dock = DockStyle.Left
        Panel16.Location = New Point(215, 0)
        Panel16.Name = "Panel16"
        Panel16.Padding = New Padding(5)
        Panel16.Size = New Size(215, 69)
        Panel16.TabIndex = 2
        ' 
        ' Panel17
        ' 
        Panel17.BackColor = Color.FromArgb(CByte(246), CByte(250), CByte(255))
        Panel17.Controls.Add(MostBoughtProductTotalUnits)
        Panel17.Controls.Add(MostBoughtProductTotalUnitsLabel)
        Panel17.Location = New Point(5, 5)
        Panel17.Name = "Panel17"
        Panel17.Padding = New Padding(12)
        Panel17.Size = New Size(205, 60)
        Panel17.TabIndex = 3
        ' 
        ' MostBoughtProductTotalUnits
        ' 
        MostBoughtProductTotalUnits.AutoSize = True
        MostBoughtProductTotalUnits.Dock = DockStyle.Top
        MostBoughtProductTotalUnits.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        MostBoughtProductTotalUnits.Location = New Point(12, 26)
        MostBoughtProductTotalUnits.Name = "MostBoughtProductTotalUnits"
        MostBoughtProductTotalUnits.Padding = New Padding(0, 5, 0, 0)
        MostBoughtProductTotalUnits.Size = New Size(15, 20)
        MostBoughtProductTotalUnits.TabIndex = 1
        MostBoughtProductTotalUnits.Text = "0"
        ' 
        ' MostBoughtProductTotalUnitsLabel
        ' 
        MostBoughtProductTotalUnitsLabel.AutoSize = True
        MostBoughtProductTotalUnitsLabel.Dock = DockStyle.Top
        MostBoughtProductTotalUnitsLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        MostBoughtProductTotalUnitsLabel.ForeColor = SystemColors.ControlDarkDark
        MostBoughtProductTotalUnitsLabel.Location = New Point(12, 12)
        MostBoughtProductTotalUnitsLabel.Name = "MostBoughtProductTotalUnitsLabel"
        MostBoughtProductTotalUnitsLabel.Size = New Size(84, 14)
        MostBoughtProductTotalUnitsLabel.TabIndex = 0
        MostBoughtProductTotalUnitsLabel.Text = "Total Units"
        ' 
        ' Panel18
        ' 
        Panel18.Controls.Add(Panel19)
        Panel18.Dock = DockStyle.Left
        Panel18.Location = New Point(0, 0)
        Panel18.Name = "Panel18"
        Panel18.Padding = New Padding(5)
        Panel18.Size = New Size(215, 69)
        Panel18.TabIndex = 1
        ' 
        ' Panel19
        ' 
        Panel19.BackColor = Color.FromArgb(CByte(246), CByte(250), CByte(255))
        Panel19.Controls.Add(MostBoughtProductName)
        Panel19.Controls.Add(MostBoughtProductNameLabel)
        Panel19.Location = New Point(5, 5)
        Panel19.Name = "Panel19"
        Panel19.Padding = New Padding(12)
        Panel19.Size = New Size(204, 60)
        Panel19.TabIndex = 3
        ' 
        ' MostBoughtProductName
        ' 
        MostBoughtProductName.AutoSize = True
        MostBoughtProductName.Dock = DockStyle.Top
        MostBoughtProductName.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        MostBoughtProductName.Location = New Point(12, 26)
        MostBoughtProductName.Name = "MostBoughtProductName"
        MostBoughtProductName.Padding = New Padding(0, 5, 0, 0)
        MostBoughtProductName.Size = New Size(15, 20)
        MostBoughtProductName.TabIndex = 1
        MostBoughtProductName.Text = "-"
        ' 
        ' MostBoughtProductNameLabel
        ' 
        MostBoughtProductNameLabel.AutoSize = True
        MostBoughtProductNameLabel.Dock = DockStyle.Top
        MostBoughtProductNameLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        MostBoughtProductNameLabel.ForeColor = SystemColors.ControlDarkDark
        MostBoughtProductNameLabel.Location = New Point(12, 12)
        MostBoughtProductNameLabel.Name = "MostBoughtProductNameLabel"
        MostBoughtProductNameLabel.Size = New Size(91, 14)
        MostBoughtProductNameLabel.TabIndex = 0
        MostBoughtProductNameLabel.Text = "Product Name"
        ' 
        ' MostBoughtProductKPILabel
        ' 
        MostBoughtProductKPILabel.AutoSize = True
        MostBoughtProductKPILabel.Dock = DockStyle.Top
        MostBoughtProductKPILabel.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        MostBoughtProductKPILabel.Location = New Point(9, 9)
        MostBoughtProductKPILabel.Name = "MostBoughtProductKPILabel"
        MostBoughtProductKPILabel.Size = New Size(159, 15)
        MostBoughtProductKPILabel.TabIndex = 0
        MostBoughtProductKPILabel.Text = "Most Bought Product"
        ' 
        ' OrderKPI
        ' 
        OrderKPI.BackColor = Color.White
        OrderKPI.Controls.Add(OrderKPITimeSelector)
        OrderKPI.Controls.Add(Panel6)
        OrderKPI.Controls.Add(OrderKPILabel)
        OrderKPI.Dock = DockStyle.Top
        OrderKPI.Location = New Point(0, 0)
        OrderKPI.Name = "OrderKPI"
        OrderKPI.Padding = New Padding(9)
        OrderKPI.Size = New Size(665, 112)
        OrderKPI.TabIndex = 1
        ' 
        ' OrderKPITimeSelector
        ' 
        OrderKPITimeSelector.Font = New Font("CaskaydiaCove NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        OrderKPITimeSelector.FormattingEnabled = True
        OrderKPITimeSelector.Items.AddRange(New Object() {"This Month", "This Year"})
        OrderKPITimeSelector.Location = New Point(535, 8)
        OrderKPITimeSelector.Name = "OrderKPITimeSelector"
        OrderKPITimeSelector.Size = New Size(121, 21)
        OrderKPITimeSelector.TabIndex = 2
        OrderKPITimeSelector.Text = "Select time"
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(Panel9)
        Panel6.Controls.Add(Panel5)
        Panel6.Controls.Add(Panel8)
        Panel6.Dock = DockStyle.Bottom
        Panel6.Location = New Point(9, 34)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(647, 69)
        Panel6.TabIndex = 1
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(Panel10)
        Panel9.Dock = DockStyle.Left
        Panel9.Location = New Point(430, 0)
        Panel9.Name = "Panel9"
        Panel9.Padding = New Padding(5)
        Panel9.Size = New Size(215, 69)
        Panel9.TabIndex = 3
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.FromArgb(CByte(246), CByte(250), CByte(255))
        Panel10.Controls.Add(TotalOrdersDelivered)
        Panel10.Controls.Add(TotalOrdersDeliveredLabel)
        Panel10.Location = New Point(5, 5)
        Panel10.Name = "Panel10"
        Panel10.Padding = New Padding(12)
        Panel10.Size = New Size(206, 60)
        Panel10.TabIndex = 3
        ' 
        ' TotalOrdersDelivered
        ' 
        TotalOrdersDelivered.AutoSize = True
        TotalOrdersDelivered.Dock = DockStyle.Top
        TotalOrdersDelivered.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TotalOrdersDelivered.Location = New Point(12, 26)
        TotalOrdersDelivered.Name = "TotalOrdersDelivered"
        TotalOrdersDelivered.Padding = New Padding(0, 5, 0, 0)
        TotalOrdersDelivered.Size = New Size(15, 20)
        TotalOrdersDelivered.TabIndex = 1
        TotalOrdersDelivered.Text = "0"
        ' 
        ' TotalOrdersDeliveredLabel
        ' 
        TotalOrdersDeliveredLabel.AutoSize = True
        TotalOrdersDeliveredLabel.Dock = DockStyle.Top
        TotalOrdersDeliveredLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TotalOrdersDeliveredLabel.ForeColor = SystemColors.ControlDarkDark
        TotalOrdersDeliveredLabel.Location = New Point(12, 12)
        TotalOrdersDeliveredLabel.Name = "TotalOrdersDeliveredLabel"
        TotalOrdersDeliveredLabel.Size = New Size(161, 14)
        TotalOrdersDeliveredLabel.TabIndex = 0
        TotalOrdersDeliveredLabel.Text = "Total Orders Delivered"
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Panel7)
        Panel5.Dock = DockStyle.Left
        Panel5.Location = New Point(215, 0)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(5)
        Panel5.Size = New Size(215, 69)
        Panel5.TabIndex = 2
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(246), CByte(250), CByte(255))
        Panel7.Controls.Add(TotalOrdersAmount)
        Panel7.Controls.Add(TotalOrdersAmountLabel)
        Panel7.Location = New Point(5, 5)
        Panel7.Name = "Panel7"
        Panel7.Padding = New Padding(12)
        Panel7.Size = New Size(205, 60)
        Panel7.TabIndex = 3
        ' 
        ' TotalOrdersAmount
        ' 
        TotalOrdersAmount.AutoSize = True
        TotalOrdersAmount.Dock = DockStyle.Top
        TotalOrdersAmount.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TotalOrdersAmount.Location = New Point(12, 26)
        TotalOrdersAmount.Name = "TotalOrdersAmount"
        TotalOrdersAmount.Padding = New Padding(0, 5, 0, 0)
        TotalOrdersAmount.Size = New Size(47, 20)
        TotalOrdersAmount.TabIndex = 1
        TotalOrdersAmount.Text = "Rs. 0"
        ' 
        ' TotalOrdersAmountLabel
        ' 
        TotalOrdersAmountLabel.AutoSize = True
        TotalOrdersAmountLabel.Dock = DockStyle.Top
        TotalOrdersAmountLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TotalOrdersAmountLabel.ForeColor = SystemColors.ControlDarkDark
        TotalOrdersAmountLabel.Location = New Point(12, 12)
        TotalOrdersAmountLabel.Name = "TotalOrdersAmountLabel"
        TotalOrdersAmountLabel.Size = New Size(140, 14)
        TotalOrdersAmountLabel.TabIndex = 0
        TotalOrdersAmountLabel.Text = "Total Orders Amount"
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(Panel11)
        Panel8.Dock = DockStyle.Left
        Panel8.Location = New Point(0, 0)
        Panel8.Name = "Panel8"
        Panel8.Padding = New Padding(5)
        Panel8.Size = New Size(215, 69)
        Panel8.TabIndex = 1
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(246), CByte(250), CByte(255))
        Panel11.Controls.Add(TotalOrders)
        Panel11.Controls.Add(TotalOrdersLabel)
        Panel11.Location = New Point(5, 5)
        Panel11.Name = "Panel11"
        Panel11.Padding = New Padding(12)
        Panel11.Size = New Size(204, 60)
        Panel11.TabIndex = 3
        ' 
        ' TotalOrders
        ' 
        TotalOrders.AutoSize = True
        TotalOrders.Dock = DockStyle.Top
        TotalOrders.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TotalOrders.Location = New Point(12, 26)
        TotalOrders.Name = "TotalOrders"
        TotalOrders.Padding = New Padding(0, 5, 0, 0)
        TotalOrders.Size = New Size(15, 20)
        TotalOrders.TabIndex = 1
        TotalOrders.Text = "0"
        ' 
        ' TotalOrdersLabel
        ' 
        TotalOrdersLabel.AutoSize = True
        TotalOrdersLabel.Dock = DockStyle.Top
        TotalOrdersLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TotalOrdersLabel.ForeColor = SystemColors.ControlDarkDark
        TotalOrdersLabel.Location = New Point(12, 12)
        TotalOrdersLabel.Name = "TotalOrdersLabel"
        TotalOrdersLabel.Size = New Size(91, 14)
        TotalOrdersLabel.TabIndex = 0
        TotalOrdersLabel.Text = "Total Orders"
        ' 
        ' OrderKPILabel
        ' 
        OrderKPILabel.AutoSize = True
        OrderKPILabel.Dock = DockStyle.Top
        OrderKPILabel.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        OrderKPILabel.Location = New Point(9, 9)
        OrderKPILabel.Name = "OrderKPILabel"
        OrderKPILabel.Size = New Size(55, 15)
        OrderKPILabel.TabIndex = 0
        OrderKPILabel.Text = "Orders"
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
        RegisteredAtContainer.Padding = New Padding(12)
        RegisteredAtContainer.Size = New Size(203, 60)
        RegisteredAtContainer.TabIndex = 1
        ' 
        ' RegisteredAt
        ' 
        RegisteredAt.AutoSize = True
        RegisteredAt.Dock = DockStyle.Top
        RegisteredAt.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        RegisteredAt.Location = New Point(12, 26)
        RegisteredAt.Name = "RegisteredAt"
        RegisteredAt.Padding = New Padding(0, 5, 0, 0)
        RegisteredAt.Size = New Size(103, 20)
        RegisteredAt.TabIndex = 1
        RegisteredAt.Text = "Jun 12, 2023"
        ' 
        ' RegisteredAtLabel
        ' 
        RegisteredAtLabel.AutoSize = True
        RegisteredAtLabel.Dock = DockStyle.Top
        RegisteredAtLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        RegisteredAtLabel.ForeColor = SystemColors.ControlDarkDark
        RegisteredAtLabel.Location = New Point(12, 12)
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
        DateOfBirthContainer.Padding = New Padding(12)
        DateOfBirthContainer.Size = New Size(203, 60)
        DateOfBirthContainer.TabIndex = 0
        ' 
        ' DateOfBirth
        ' 
        DateOfBirth.AutoSize = True
        DateOfBirth.Dock = DockStyle.Top
        DateOfBirth.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DateOfBirth.Location = New Point(12, 26)
        DateOfBirth.Name = "DateOfBirth"
        DateOfBirth.Padding = New Padding(0, 5, 0, 0)
        DateOfBirth.Size = New Size(95, 20)
        DateOfBirth.TabIndex = 1
        DateOfBirth.Text = "Jun 3, 2023"
        ' 
        ' DateOfBirthLabel
        ' 
        DateOfBirthLabel.AutoSize = True
        DateOfBirthLabel.Dock = DockStyle.Top
        DateOfBirthLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DateOfBirthLabel.ForeColor = SystemColors.ControlDarkDark
        DateOfBirthLabel.Location = New Point(12, 12)
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
        AddressContainer.Padding = New Padding(12)
        AddressContainer.Size = New Size(203, 60)
        AddressContainer.TabIndex = 2
        ' 
        ' Address
        ' 
        Address.AutoSize = True
        Address.Dock = DockStyle.Top
        Address.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Address.Location = New Point(12, 26)
        Address.Name = "Address"
        Address.Padding = New Padding(0, 5, 0, 0)
        Address.Size = New Size(159, 20)
        Address.TabIndex = 1
        Address.Text = "Siddhipur, Lalitpur"
        ' 
        ' AddressLabel
        ' 
        AddressLabel.AutoSize = True
        AddressLabel.Dock = DockStyle.Top
        AddressLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        AddressLabel.ForeColor = SystemColors.ControlDarkDark
        AddressLabel.Location = New Point(12, 12)
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
        ShopNameContainer.Padding = New Padding(12)
        ShopNameContainer.Size = New Size(203, 60)
        ShopNameContainer.TabIndex = 1
        ' 
        ' ShopName
        ' 
        ShopName.AutoSize = True
        ShopName.Dock = DockStyle.Top
        ShopName.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ShopName.Location = New Point(12, 26)
        ShopName.Name = "ShopName"
        ShopName.Padding = New Padding(0, 5, 0, 0)
        ShopName.Size = New Size(87, 20)
        ShopName.TabIndex = 1
        ShopName.Text = "Naya Pasal"
        ' 
        ' ShopNameLabel
        ' 
        ShopNameLabel.AutoSize = True
        ShopNameLabel.Dock = DockStyle.Top
        ShopNameLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ShopNameLabel.ForeColor = SystemColors.ControlDarkDark
        ShopNameLabel.Location = New Point(12, 12)
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
        PhoneNumberContainer.Padding = New Padding(12)
        PhoneNumberContainer.Size = New Size(203, 60)
        PhoneNumberContainer.TabIndex = 0
        ' 
        ' PhoneNumber
        ' 
        PhoneNumber.AutoSize = True
        PhoneNumber.Dock = DockStyle.Top
        PhoneNumber.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        PhoneNumber.Location = New Point(12, 26)
        PhoneNumber.Name = "PhoneNumber"
        PhoneNumber.Padding = New Padding(0, 5, 0, 0)
        PhoneNumber.Size = New Size(87, 20)
        PhoneNumber.TabIndex = 1
        PhoneNumber.Text = "9800000000"
        ' 
        ' PhoneNumberLabel
        ' 
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Dock = DockStyle.Top
        PhoneNumberLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        PhoneNumberLabel.ForeColor = SystemColors.ControlDarkDark
        PhoneNumberLabel.Location = New Point(12, 12)
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
        Panel2.Padding = New Padding(17, 17, 0, 17)
        Panel2.Size = New Size(233, 48)
        Panel2.TabIndex = 0
        ' 
        ' UserName
        ' 
        UserName.AutoSize = True
        UserName.Dock = DockStyle.Top
        UserName.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        UserName.ForeColor = Color.White
        UserName.Location = New Point(17, 17)
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
        Controls.Add(HeaderPanel)
        Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "DashboardForm"
        Text = "DashboardForm"
        HeaderPanel.ResumeLayout(False)
        HeaderPanel.PerformLayout()
        DashboardContainerPanel.ResumeLayout(False)
        KPIPanelContainer.ResumeLayout(False)
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        CType(RecentOrdersTable, ComponentModel.ISupportInitialize).EndInit()
        KPIPanel.ResumeLayout(False)
        ProductKPI.ResumeLayout(False)
        ProductKPI.PerformLayout()
        Panel13.ResumeLayout(False)
        Panel14.ResumeLayout(False)
        Panel15.ResumeLayout(False)
        Panel15.PerformLayout()
        Panel16.ResumeLayout(False)
        Panel17.ResumeLayout(False)
        Panel17.PerformLayout()
        Panel18.ResumeLayout(False)
        Panel19.ResumeLayout(False)
        Panel19.PerformLayout()
        OrderKPI.ResumeLayout(False)
        OrderKPI.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
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

    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents Header As Label
    Friend WithEvents DashboardContainerPanel As Panel
    Friend WithEvents KPIPanelContainer As Panel
    Friend WithEvents ProfilePanel As Panel
    Friend WithEvents Profile As Panel
    Friend WithEvents UserName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
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
    Friend WithEvents RegisteredAtContainer As Panel
    Friend WithEvents RegisteredAt As Label
    Friend WithEvents RegisteredAtLabel As Label
    Friend WithEvents DateOfBirthContainer As Panel
    Friend WithEvents DateOfBirth As Label
    Friend WithEvents DateOfBirthLabel As Label
    Friend WithEvents EditProfileButton As Button
    Friend WithEvents KPIPanel As Panel
    Friend WithEvents OrderKPI As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents TotalOrdersDelivered As Label
    Friend WithEvents TotalOrdersDeliveredLabel As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TotalOrdersAmount As Label
    Friend WithEvents TotalOrdersAmountLabel As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents TotalOrders As Label
    Friend WithEvents TotalOrdersLabel As Label
    Friend WithEvents OrderKPILabel As Label
    Friend WithEvents ProductKPI As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents MostBoughtProductTotalAmount As Label
    Friend WithEvents MostBoughtProductTotalAmountLabel As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents MostBoughtProductTotalUnits As Label
    Friend WithEvents MostBoughtProductTotalUnitsLabel As Label
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents MostBoughtProductName As Label
    Friend WithEvents MostBoughtProductNameLabel As Label
    Friend WithEvents MostBoughtProductKPILabel As Label
    Friend WithEvents OrderKPITimeSelector As ComboBox
    Friend WithEvents ProductKPITimeSelector As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Panel26 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents RecentOrdersLabel As Label
    Friend WithEvents RecentOrdersTable As DataGridView
End Class
