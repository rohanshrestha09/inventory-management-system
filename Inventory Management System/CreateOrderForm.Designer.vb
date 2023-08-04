<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateOrderForm
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
        CreateOrderContainer = New Panel()
        Panel7 = New Panel()
        Panel8 = New Panel()
        PaymentMethod = New ComboBox()
        PaymentMethodLabel = New Label()
        Panel3 = New Panel()
        DeliveryStatus = New ComboBox()
        DeliveryStatusLabel = New Label()
        Panel4 = New Panel()
        Panel5 = New Panel()
        TotalPaidAmountLabel = New Label()
        TotalPaidAmount = New TextBox()
        Panel6 = New Panel()
        TotalAmountLabel = New Label()
        TotalAmount = New TextBox()
        Panel14 = New Panel()
        Panel15 = New Panel()
        CategoryLabel = New Label()
        Category = New TextBox()
        Panel16 = New Panel()
        BrandLabel = New Label()
        Brand = New TextBox()
        Panel10 = New Panel()
        Panel12 = New Panel()
        QuantityLabel = New Label()
        Quantity = New TextBox()
        Panel13 = New Panel()
        PriceLabel = New Label()
        Price = New TextBox()
        Panel1 = New Panel()
        Panel9 = New Panel()
        TotalUnitsLabel = New Label()
        TotalUnits = New TextBox()
        Panel2 = New Panel()
        Products = New ComboBox()
        ProductsLabel = New Label()
        Panel17 = New Panel()
        Panel18 = New Panel()
        ShopNameLabel = New Label()
        ShopName = New TextBox()
        Panel19 = New Panel()
        Customers = New ComboBox()
        CustomerLabel = New Label()
        Panel11 = New Panel()
        CancelButton = New Button()
        CreateOrderButton = New Button()
        HeaderPanel.SuspendLayout()
        CreateOrderContainer.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel14.SuspendLayout()
        Panel15.SuspendLayout()
        Panel16.SuspendLayout()
        Panel10.SuspendLayout()
        Panel12.SuspendLayout()
        Panel13.SuspendLayout()
        Panel1.SuspendLayout()
        Panel9.SuspendLayout()
        Panel2.SuspendLayout()
        Panel17.SuspendLayout()
        Panel18.SuspendLayout()
        Panel19.SuspendLayout()
        Panel11.SuspendLayout()
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
        HeaderPanel.TabIndex = 5
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
        Header.Text = "Add Order"
        ' 
        ' CreateOrderContainer
        ' 
        CreateOrderContainer.BackColor = Color.White
        CreateOrderContainer.Controls.Add(Panel7)
        CreateOrderContainer.Controls.Add(Panel4)
        CreateOrderContainer.Controls.Add(Panel14)
        CreateOrderContainer.Controls.Add(Panel10)
        CreateOrderContainer.Controls.Add(Panel1)
        CreateOrderContainer.Controls.Add(Panel17)
        CreateOrderContainer.Controls.Add(Panel11)
        CreateOrderContainer.Dock = DockStyle.Bottom
        CreateOrderContainer.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        CreateOrderContainer.Location = New Point(0, 68)
        CreateOrderContainer.Name = "CreateOrderContainer"
        CreateOrderContainer.Padding = New Padding(10)
        CreateOrderContainer.Size = New Size(917, 496)
        CreateOrderContainer.TabIndex = 7
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(Panel8)
        Panel7.Controls.Add(Panel3)
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(10, 361)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(897, 63)
        Panel7.TabIndex = 19
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(PaymentMethod)
        Panel8.Controls.Add(PaymentMethodLabel)
        Panel8.Dock = DockStyle.Left
        Panel8.Location = New Point(0, 0)
        Panel8.Name = "Panel8"
        Panel8.Padding = New Padding(10)
        Panel8.Size = New Size(445, 63)
        Panel8.TabIndex = 3
        ' 
        ' PaymentMethod
        ' 
        PaymentMethod.Dock = DockStyle.Bottom
        PaymentMethod.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        PaymentMethod.FormattingEnabled = True
        PaymentMethod.Location = New Point(10, 31)
        PaymentMethod.Name = "PaymentMethod"
        PaymentMethod.Size = New Size(425, 22)
        PaymentMethod.TabIndex = 2
        ' 
        ' PaymentMethodLabel
        ' 
        PaymentMethodLabel.AutoSize = True
        PaymentMethodLabel.Dock = DockStyle.Top
        PaymentMethodLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        PaymentMethodLabel.Location = New Point(10, 10)
        PaymentMethodLabel.Name = "PaymentMethodLabel"
        PaymentMethodLabel.Size = New Size(105, 14)
        PaymentMethodLabel.TabIndex = 1
        PaymentMethodLabel.Text = "Payment Method"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(DeliveryStatus)
        Panel3.Controls.Add(DeliveryStatusLabel)
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(452, 0)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(10)
        Panel3.Size = New Size(445, 63)
        Panel3.TabIndex = 2
        ' 
        ' DeliveryStatus
        ' 
        DeliveryStatus.Dock = DockStyle.Bottom
        DeliveryStatus.Enabled = False
        DeliveryStatus.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DeliveryStatus.FormattingEnabled = True
        DeliveryStatus.Location = New Point(10, 31)
        DeliveryStatus.Name = "DeliveryStatus"
        DeliveryStatus.Size = New Size(425, 22)
        DeliveryStatus.TabIndex = 2
        ' 
        ' DeliveryStatusLabel
        ' 
        DeliveryStatusLabel.AutoSize = True
        DeliveryStatusLabel.Dock = DockStyle.Top
        DeliveryStatusLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DeliveryStatusLabel.Location = New Point(10, 10)
        DeliveryStatusLabel.Name = "DeliveryStatusLabel"
        DeliveryStatusLabel.Size = New Size(112, 14)
        DeliveryStatusLabel.TabIndex = 1
        DeliveryStatusLabel.Text = "Delivery Status"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Panel5)
        Panel4.Controls.Add(Panel6)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(10, 286)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(897, 75)
        Panel4.TabIndex = 18
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(TotalPaidAmountLabel)
        Panel5.Controls.Add(TotalPaidAmount)
        Panel5.Dock = DockStyle.Right
        Panel5.Location = New Point(452, 0)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(10)
        Panel5.Size = New Size(445, 75)
        Panel5.TabIndex = 1
        ' 
        ' TotalPaidAmountLabel
        ' 
        TotalPaidAmountLabel.AutoSize = True
        TotalPaidAmountLabel.Dock = DockStyle.Top
        TotalPaidAmountLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TotalPaidAmountLabel.Location = New Point(10, 10)
        TotalPaidAmountLabel.Name = "TotalPaidAmountLabel"
        TotalPaidAmountLabel.Size = New Size(126, 14)
        TotalPaidAmountLabel.TabIndex = 1
        TotalPaidAmountLabel.Text = "Total Paid Amount"
        ' 
        ' TotalPaidAmount
        ' 
        TotalPaidAmount.Cursor = Cursors.IBeam
        TotalPaidAmount.Dock = DockStyle.Bottom
        TotalPaidAmount.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TotalPaidAmount.Location = New Point(10, 35)
        TotalPaidAmount.Multiline = True
        TotalPaidAmount.Name = "TotalPaidAmount"
        TotalPaidAmount.PlaceholderText = "Enter Paid Amount"
        TotalPaidAmount.Size = New Size(425, 30)
        TotalPaidAmount.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(TotalAmountLabel)
        Panel6.Controls.Add(TotalAmount)
        Panel6.Dock = DockStyle.Left
        Panel6.Location = New Point(0, 0)
        Panel6.Name = "Panel6"
        Panel6.Padding = New Padding(10)
        Panel6.Size = New Size(445, 75)
        Panel6.TabIndex = 0
        ' 
        ' TotalAmountLabel
        ' 
        TotalAmountLabel.AutoSize = True
        TotalAmountLabel.Dock = DockStyle.Top
        TotalAmountLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TotalAmountLabel.Location = New Point(10, 10)
        TotalAmountLabel.Name = "TotalAmountLabel"
        TotalAmountLabel.Size = New Size(91, 14)
        TotalAmountLabel.TabIndex = 1
        TotalAmountLabel.Text = "Total Amount"
        ' 
        ' TotalAmount
        ' 
        TotalAmount.Cursor = Cursors.IBeam
        TotalAmount.Dock = DockStyle.Bottom
        TotalAmount.Enabled = False
        TotalAmount.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TotalAmount.Location = New Point(10, 35)
        TotalAmount.Multiline = True
        TotalAmount.Name = "TotalAmount"
        TotalAmount.PlaceholderText = "Total Order Amount"
        TotalAmount.Size = New Size(425, 30)
        TotalAmount.TabIndex = 0
        ' 
        ' Panel14
        ' 
        Panel14.Controls.Add(Panel15)
        Panel14.Controls.Add(Panel16)
        Panel14.Dock = DockStyle.Top
        Panel14.Location = New Point(10, 211)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(897, 75)
        Panel14.TabIndex = 17
        ' 
        ' Panel15
        ' 
        Panel15.Controls.Add(CategoryLabel)
        Panel15.Controls.Add(Category)
        Panel15.Dock = DockStyle.Right
        Panel15.Location = New Point(452, 0)
        Panel15.Name = "Panel15"
        Panel15.Padding = New Padding(10)
        Panel15.Size = New Size(445, 75)
        Panel15.TabIndex = 1
        ' 
        ' CategoryLabel
        ' 
        CategoryLabel.AutoSize = True
        CategoryLabel.Dock = DockStyle.Top
        CategoryLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        CategoryLabel.Location = New Point(10, 10)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New Size(63, 14)
        CategoryLabel.TabIndex = 1
        CategoryLabel.Text = "Category"
        ' 
        ' Category
        ' 
        Category.Cursor = Cursors.IBeam
        Category.Dock = DockStyle.Bottom
        Category.Enabled = False
        Category.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Category.Location = New Point(10, 35)
        Category.Multiline = True
        Category.Name = "Category"
        Category.PlaceholderText = "Product Category"
        Category.Size = New Size(425, 30)
        Category.TabIndex = 0
        ' 
        ' Panel16
        ' 
        Panel16.Controls.Add(BrandLabel)
        Panel16.Controls.Add(Brand)
        Panel16.Dock = DockStyle.Left
        Panel16.Location = New Point(0, 0)
        Panel16.Name = "Panel16"
        Panel16.Padding = New Padding(10)
        Panel16.Size = New Size(445, 75)
        Panel16.TabIndex = 0
        ' 
        ' BrandLabel
        ' 
        BrandLabel.AutoSize = True
        BrandLabel.Dock = DockStyle.Top
        BrandLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        BrandLabel.Location = New Point(10, 10)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New Size(42, 14)
        BrandLabel.TabIndex = 1
        BrandLabel.Text = "Brand"
        ' 
        ' Brand
        ' 
        Brand.Cursor = Cursors.IBeam
        Brand.Dock = DockStyle.Bottom
        Brand.Enabled = False
        Brand.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Brand.Location = New Point(10, 35)
        Brand.Multiline = True
        Brand.Name = "Brand"
        Brand.PlaceholderText = "Product Brand"
        Brand.Size = New Size(425, 30)
        Brand.TabIndex = 0
        ' 
        ' Panel10
        ' 
        Panel10.Controls.Add(Panel12)
        Panel10.Controls.Add(Panel13)
        Panel10.Dock = DockStyle.Top
        Panel10.Location = New Point(10, 136)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(897, 75)
        Panel10.TabIndex = 16
        ' 
        ' Panel12
        ' 
        Panel12.Controls.Add(QuantityLabel)
        Panel12.Controls.Add(Quantity)
        Panel12.Dock = DockStyle.Right
        Panel12.Location = New Point(452, 0)
        Panel12.Name = "Panel12"
        Panel12.Padding = New Padding(10)
        Panel12.Size = New Size(445, 75)
        Panel12.TabIndex = 1
        ' 
        ' QuantityLabel
        ' 
        QuantityLabel.AutoSize = True
        QuantityLabel.Dock = DockStyle.Top
        QuantityLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        QuantityLabel.Location = New Point(10, 10)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New Size(112, 14)
        QuantityLabel.TabIndex = 1
        QuantityLabel.Text = "Quantity (Gram)"
        ' 
        ' Quantity
        ' 
        Quantity.Cursor = Cursors.IBeam
        Quantity.Dock = DockStyle.Bottom
        Quantity.Enabled = False
        Quantity.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Quantity.Location = New Point(10, 35)
        Quantity.Multiline = True
        Quantity.Name = "Quantity"
        Quantity.PlaceholderText = "Product Quantity"
        Quantity.Size = New Size(425, 30)
        Quantity.TabIndex = 0
        ' 
        ' Panel13
        ' 
        Panel13.Controls.Add(PriceLabel)
        Panel13.Controls.Add(Price)
        Panel13.Dock = DockStyle.Left
        Panel13.Location = New Point(0, 0)
        Panel13.Name = "Panel13"
        Panel13.Padding = New Padding(10)
        Panel13.Size = New Size(445, 75)
        Panel13.TabIndex = 0
        ' 
        ' PriceLabel
        ' 
        PriceLabel.AutoSize = True
        PriceLabel.Dock = DockStyle.Top
        PriceLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        PriceLabel.Location = New Point(10, 10)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New Size(42, 14)
        PriceLabel.TabIndex = 1
        PriceLabel.Text = "Price"
        ' 
        ' Price
        ' 
        Price.Cursor = Cursors.IBeam
        Price.Dock = DockStyle.Bottom
        Price.Enabled = False
        Price.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Price.Location = New Point(10, 35)
        Price.Multiline = True
        Price.Name = "Price"
        Price.PlaceholderText = "Product Price"
        Price.Size = New Size(425, 30)
        Price.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel9)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(10, 73)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(897, 63)
        Panel1.TabIndex = 15
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(TotalUnitsLabel)
        Panel9.Controls.Add(TotalUnits)
        Panel9.Dock = DockStyle.Right
        Panel9.Location = New Point(452, 0)
        Panel9.Name = "Panel9"
        Panel9.Padding = New Padding(10)
        Panel9.Size = New Size(445, 63)
        Panel9.TabIndex = 2
        ' 
        ' TotalUnitsLabel
        ' 
        TotalUnitsLabel.AutoSize = True
        TotalUnitsLabel.Dock = DockStyle.Top
        TotalUnitsLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TotalUnitsLabel.Location = New Point(10, 10)
        TotalUnitsLabel.Name = "TotalUnitsLabel"
        TotalUnitsLabel.Size = New Size(84, 14)
        TotalUnitsLabel.TabIndex = 1
        TotalUnitsLabel.Text = "Total Units"
        ' 
        ' TotalUnits
        ' 
        TotalUnits.Cursor = Cursors.IBeam
        TotalUnits.Dock = DockStyle.Bottom
        TotalUnits.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TotalUnits.Location = New Point(10, 32)
        TotalUnits.Name = "TotalUnits"
        TotalUnits.PlaceholderText = "Enter Total Units"
        TotalUnits.Size = New Size(425, 21)
        TotalUnits.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Products)
        Panel2.Controls.Add(ProductsLabel)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(10)
        Panel2.Size = New Size(445, 63)
        Panel2.TabIndex = 0
        ' 
        ' Products
        ' 
        Products.Dock = DockStyle.Bottom
        Products.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Products.FormattingEnabled = True
        Products.Location = New Point(10, 31)
        Products.Name = "Products"
        Products.Size = New Size(425, 22)
        Products.TabIndex = 2
        ' 
        ' ProductsLabel
        ' 
        ProductsLabel.AutoSize = True
        ProductsLabel.Dock = DockStyle.Top
        ProductsLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ProductsLabel.Location = New Point(10, 10)
        ProductsLabel.Name = "ProductsLabel"
        ProductsLabel.Size = New Size(63, 14)
        ProductsLabel.TabIndex = 1
        ProductsLabel.Text = "Products"
        ' 
        ' Panel17
        ' 
        Panel17.Controls.Add(Panel18)
        Panel17.Controls.Add(Panel19)
        Panel17.Dock = DockStyle.Top
        Panel17.Location = New Point(10, 10)
        Panel17.Name = "Panel17"
        Panel17.Size = New Size(897, 63)
        Panel17.TabIndex = 14
        ' 
        ' Panel18
        ' 
        Panel18.Controls.Add(ShopNameLabel)
        Panel18.Controls.Add(ShopName)
        Panel18.Dock = DockStyle.Right
        Panel18.Location = New Point(452, 0)
        Panel18.Name = "Panel18"
        Panel18.Padding = New Padding(10)
        Panel18.Size = New Size(445, 63)
        Panel18.TabIndex = 2
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
        ShopName.Location = New Point(10, 32)
        ShopName.Name = "ShopName"
        ShopName.PlaceholderText = "Shop Name"
        ShopName.Size = New Size(425, 21)
        ShopName.TabIndex = 0
        ' 
        ' Panel19
        ' 
        Panel19.Controls.Add(Customers)
        Panel19.Controls.Add(CustomerLabel)
        Panel19.Dock = DockStyle.Left
        Panel19.Location = New Point(0, 0)
        Panel19.Name = "Panel19"
        Panel19.Padding = New Padding(10)
        Panel19.Size = New Size(445, 63)
        Panel19.TabIndex = 0
        ' 
        ' Customers
        ' 
        Customers.Dock = DockStyle.Bottom
        Customers.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Customers.FormattingEnabled = True
        Customers.Location = New Point(10, 31)
        Customers.Name = "Customers"
        Customers.Size = New Size(425, 22)
        Customers.TabIndex = 2
        ' 
        ' CustomerLabel
        ' 
        CustomerLabel.AutoSize = True
        CustomerLabel.Dock = DockStyle.Top
        CustomerLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        CustomerLabel.Location = New Point(10, 10)
        CustomerLabel.Name = "CustomerLabel"
        CustomerLabel.Size = New Size(63, 14)
        CustomerLabel.TabIndex = 1
        CustomerLabel.Text = "Customer"
        ' 
        ' Panel11
        ' 
        Panel11.Controls.Add(CancelButton)
        Panel11.Controls.Add(CreateOrderButton)
        Panel11.Dock = DockStyle.Bottom
        Panel11.Location = New Point(10, 430)
        Panel11.Name = "Panel11"
        Panel11.Padding = New Padding(10)
        Panel11.Size = New Size(897, 56)
        Panel11.TabIndex = 5
        ' 
        ' CancelButton
        ' 
        CancelButton.BackColor = Color.FromArgb(240, 244, 247)
        CancelButton.Cursor = Cursors.Hand
        CancelButton.FlatAppearance.BorderColor = Color.FromArgb(240, 244, 247)
        CancelButton.FlatAppearance.BorderSize = 0
        CancelButton.FlatStyle = FlatStyle.System
        CancelButton.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        CancelButton.ForeColor = Color.Black
        CancelButton.Location = New Point(226, 10)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(210, 36)
        CancelButton.TabIndex = 8
        CancelButton.Text = "Cancel"
        CancelButton.UseVisualStyleBackColor = False
        ' 
        ' CreateOrderButton
        ' 
        CreateOrderButton.BackColor = Color.FromArgb(0, 120, 212)
        CreateOrderButton.Cursor = Cursors.Hand
        CreateOrderButton.Dock = DockStyle.Left
        CreateOrderButton.FlatStyle = FlatStyle.Flat
        CreateOrderButton.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        CreateOrderButton.ForeColor = Color.White
        CreateOrderButton.Location = New Point(10, 10)
        CreateOrderButton.Name = "CreateOrderButton"
        CreateOrderButton.Size = New Size(210, 36)
        CreateOrderButton.TabIndex = 7
        CreateOrderButton.Text = "+ Create Order"
        CreateOrderButton.UseVisualStyleBackColor = False
        ' 
        ' CreateOrderForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(240, 244, 247)
        ClientSize = New Size(917, 564)
        Controls.Add(CreateOrderContainer)
        Controls.Add(HeaderPanel)
        Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "CreateOrderForm"
        Text = "CreateOrderForm"
        HeaderPanel.ResumeLayout(False)
        HeaderPanel.PerformLayout()
        CreateOrderContainer.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel14.ResumeLayout(False)
        Panel15.ResumeLayout(False)
        Panel15.PerformLayout()
        Panel16.ResumeLayout(False)
        Panel16.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        Panel13.ResumeLayout(False)
        Panel13.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel17.ResumeLayout(False)
        Panel18.ResumeLayout(False)
        Panel18.PerformLayout()
        Panel19.ResumeLayout(False)
        Panel19.PerformLayout()
        Panel11.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents Header As Label
    Friend WithEvents CreateOrderContainer As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents CancelButton As Button
    Friend WithEvents CreateOrderButton As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PaymentMethod As ComboBox
    Friend WithEvents PaymentMethodLabel As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DeliveryStatus As ComboBox
    Friend WithEvents DeliveryStatusLabel As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TotalPaidAmountLabel As Label
    Friend WithEvents TotalPaidAmount As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TotalAmountLabel As Label
    Friend WithEvents TotalAmount As TextBox
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents CategoryLabel As Label
    Friend WithEvents Category As TextBox
    Friend WithEvents Panel16 As Panel
    Friend WithEvents BrandLabel As Label
    Friend WithEvents Brand As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents QuantityLabel As Label
    Friend WithEvents Quantity As TextBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents PriceLabel As Label
    Friend WithEvents Price As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents TotalUnitsLabel As Label
    Friend WithEvents TotalUnits As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Products As ComboBox
    Friend WithEvents ProductsLabel As Label
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents ShopNameLabel As Label
    Friend WithEvents ShopName As TextBox
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Customers As ComboBox
    Friend WithEvents CustomerLabel As Label
End Class
