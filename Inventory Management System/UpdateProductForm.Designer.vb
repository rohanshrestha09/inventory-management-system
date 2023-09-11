<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateProductForm
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
        DeleteProductButton = New Button()
        CancelButton = New Button()
        UpdateProductButton = New Button()
        Panel8 = New Panel()
        Panel9 = New Panel()
        CategoryLabel = New Label()
        Category = New TextBox()
        Panel10 = New Panel()
        BrandLabel = New Label()
        Brand = New TextBox()
        Panel7 = New Panel()
        Description = New TextBox()
        DescriptionLabel = New Label()
        Panel4 = New Panel()
        Panel5 = New Panel()
        QuantityLabel = New Label()
        Quantity = New TextBox()
        Panel6 = New Panel()
        PriceLabel = New Label()
        Price = New TextBox()
        Panel1 = New Panel()
        Panel3 = New Panel()
        ProductSkuNameLabel = New Label()
        ProductSkuName = New TextBox()
        Panel2 = New Panel()
        ProductNameLabel = New Label()
        ProductName = New TextBox()
        HeaderPanel.SuspendLayout()
        CreateProductContainer.SuspendLayout()
        Panel11.SuspendLayout()
        Panel8.SuspendLayout()
        Panel9.SuspendLayout()
        Panel10.SuspendLayout()
        Panel7.SuspendLayout()
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
        HeaderPanel.TabIndex = 5
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
        Header.Text = "Update Product"
        ' 
        ' CreateProductContainer
        ' 
        CreateProductContainer.BackColor = Color.White
        CreateProductContainer.Controls.Add(Panel11)
        CreateProductContainer.Controls.Add(Panel8)
        CreateProductContainer.Controls.Add(Panel7)
        CreateProductContainer.Controls.Add(Panel4)
        CreateProductContainer.Controls.Add(Panel1)
        CreateProductContainer.Dock = DockStyle.Bottom
        CreateProductContainer.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        CreateProductContainer.Location = New Point(0, 68)
        CreateProductContainer.Name = "CreateProductContainer"
        CreateProductContainer.Padding = New Padding(10)
        CreateProductContainer.Size = New Size(917, 496)
        CreateProductContainer.TabIndex = 7
        ' 
        ' Panel11
        ' 
        Panel11.Controls.Add(DeleteProductButton)
        Panel11.Controls.Add(CancelButton)
        Panel11.Controls.Add(UpdateProductButton)
        Panel11.Dock = DockStyle.Bottom
        Panel11.Location = New Point(10, 430)
        Panel11.Name = "Panel11"
        Panel11.Padding = New Padding(10)
        Panel11.Size = New Size(897, 56)
        Panel11.TabIndex = 5
        ' 
        ' DeleteProductButton
        ' 
        DeleteProductButton.BackColor = Color.FromArgb(225, 77, 79)
        DeleteProductButton.Cursor = Cursors.Hand
        DeleteProductButton.Dock = DockStyle.Left
        DeleteProductButton.FlatStyle = FlatStyle.Flat
        DeleteProductButton.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DeleteProductButton.ForeColor = Color.White
        DeleteProductButton.Location = New Point(220, 10)
        DeleteProductButton.Name = "DeleteProductButton"
        DeleteProductButton.Size = New Size(210, 36)
        DeleteProductButton.TabIndex = 9
        DeleteProductButton.Text = "Delete"
        DeleteProductButton.UseVisualStyleBackColor = False
        ' 
        ' CancelButton
        ' 
        CancelButton.BackColor = Color.FromArgb(240, 244, 247)
        CancelButton.Cursor = Cursors.Hand
        CancelButton.Dock = DockStyle.Right
        CancelButton.FlatAppearance.BorderColor = Color.FromArgb(240, 244, 247)
        CancelButton.FlatAppearance.BorderSize = 0
        CancelButton.FlatStyle = FlatStyle.System
        CancelButton.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        CancelButton.ForeColor = Color.Black
        CancelButton.Location = New Point(677, 10)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(210, 36)
        CancelButton.TabIndex = 8
        CancelButton.Text = "Cancel"
        CancelButton.UseVisualStyleBackColor = False
        ' 
        ' UpdateProductButton
        ' 
        UpdateProductButton.BackColor = Color.FromArgb(0, 120, 212)
        UpdateProductButton.Cursor = Cursors.Hand
        UpdateProductButton.Dock = DockStyle.Left
        UpdateProductButton.FlatStyle = FlatStyle.Flat
        UpdateProductButton.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        UpdateProductButton.ForeColor = Color.White
        UpdateProductButton.Location = New Point(10, 10)
        UpdateProductButton.Name = "UpdateProductButton"
        UpdateProductButton.Size = New Size(210, 36)
        UpdateProductButton.TabIndex = 7
        UpdateProductButton.Text = "Update Product"
        UpdateProductButton.UseVisualStyleBackColor = False
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(Panel9)
        Panel8.Controls.Add(Panel10)
        Panel8.Dock = DockStyle.Top
        Panel8.Location = New Point(10, 300)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(897, 75)
        Panel8.TabIndex = 3
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(CategoryLabel)
        Panel9.Controls.Add(Category)
        Panel9.Dock = DockStyle.Right
        Panel9.Location = New Point(452, 0)
        Panel9.Name = "Panel9"
        Panel9.Padding = New Padding(10)
        Panel9.Size = New Size(445, 75)
        Panel9.TabIndex = 1
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
        Category.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Category.Location = New Point(10, 35)
        Category.Multiline = True
        Category.Name = "Category"
        Category.PlaceholderText = "Enter Category"
        Category.Size = New Size(425, 30)
        Category.TabIndex = 0
        ' 
        ' Panel10
        ' 
        Panel10.Controls.Add(BrandLabel)
        Panel10.Controls.Add(Brand)
        Panel10.Dock = DockStyle.Left
        Panel10.Location = New Point(0, 0)
        Panel10.Name = "Panel10"
        Panel10.Padding = New Padding(10)
        Panel10.Size = New Size(445, 75)
        Panel10.TabIndex = 0
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
        Brand.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Brand.Location = New Point(10, 35)
        Brand.Multiline = True
        Brand.Name = "Brand"
        Brand.PlaceholderText = "Enter Brand"
        Brand.Size = New Size(425, 30)
        Brand.TabIndex = 0
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(Description)
        Panel7.Controls.Add(DescriptionLabel)
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(10, 160)
        Panel7.Name = "Panel7"
        Panel7.Padding = New Padding(10)
        Panel7.Size = New Size(897, 140)
        Panel7.TabIndex = 2
        ' 
        ' Description
        ' 
        Description.Cursor = Cursors.IBeam
        Description.Dock = DockStyle.Bottom
        Description.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Description.Location = New Point(10, 37)
        Description.Multiline = True
        Description.Name = "Description"
        Description.PlaceholderText = "Enter Description"
        Description.Size = New Size(877, 93)
        Description.TabIndex = 3
        ' 
        ' DescriptionLabel
        ' 
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Dock = DockStyle.Top
        DescriptionLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DescriptionLabel.Location = New Point(10, 10)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New Size(84, 14)
        DescriptionLabel.TabIndex = 2
        DescriptionLabel.Text = "Description"
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
        Panel5.Controls.Add(QuantityLabel)
        Panel5.Controls.Add(Quantity)
        Panel5.Dock = DockStyle.Right
        Panel5.Location = New Point(452, 0)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(10)
        Panel5.Size = New Size(445, 75)
        Panel5.TabIndex = 1
        ' 
        ' QuantityLabel
        ' 
        QuantityLabel.AutoSize = True
        QuantityLabel.Dock = DockStyle.Top
        QuantityLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        QuantityLabel.Location = New Point(10, 10)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New Size(63, 14)
        QuantityLabel.TabIndex = 1
        QuantityLabel.Text = "Quantity"
        ' 
        ' Quantity
        ' 
        Quantity.Cursor = Cursors.IBeam
        Quantity.Dock = DockStyle.Bottom
        Quantity.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Quantity.Location = New Point(10, 35)
        Quantity.Multiline = True
        Quantity.Name = "Quantity"
        Quantity.PlaceholderText = "Enter Quantity"
        Quantity.Size = New Size(425, 30)
        Quantity.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(PriceLabel)
        Panel6.Controls.Add(Price)
        Panel6.Dock = DockStyle.Left
        Panel6.Location = New Point(0, 0)
        Panel6.Name = "Panel6"
        Panel6.Padding = New Padding(10)
        Panel6.Size = New Size(445, 75)
        Panel6.TabIndex = 0
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
        Price.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Price.Location = New Point(10, 35)
        Price.Multiline = True
        Price.Name = "Price"
        Price.PlaceholderText = "Enter Price"
        Price.Size = New Size(425, 30)
        Price.TabIndex = 0
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
        Panel3.Controls.Add(ProductSkuNameLabel)
        Panel3.Controls.Add(ProductSkuName)
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(452, 0)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(10)
        Panel3.Size = New Size(445, 75)
        Panel3.TabIndex = 1
        ' 
        ' ProductSkuNameLabel
        ' 
        ProductSkuNameLabel.AutoSize = True
        ProductSkuNameLabel.Dock = DockStyle.Top
        ProductSkuNameLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ProductSkuNameLabel.Location = New Point(10, 10)
        ProductSkuNameLabel.Name = "ProductSkuNameLabel"
        ProductSkuNameLabel.Size = New Size(119, 14)
        ProductSkuNameLabel.TabIndex = 1
        ProductSkuNameLabel.Text = "Product SKU Name"
        ' 
        ' ProductSkuName
        ' 
        ProductSkuName.Cursor = Cursors.IBeam
        ProductSkuName.Dock = DockStyle.Bottom
        ProductSkuName.Enabled = False
        ProductSkuName.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ProductSkuName.Location = New Point(10, 35)
        ProductSkuName.Multiline = True
        ProductSkuName.Name = "ProductSkuName"
        ProductSkuName.PlaceholderText = "Enter Product SKU Name"
        ProductSkuName.Size = New Size(425, 30)
        ProductSkuName.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(ProductNameLabel)
        Panel2.Controls.Add(ProductName)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(10)
        Panel2.Size = New Size(445, 75)
        Panel2.TabIndex = 0
        ' 
        ' ProductNameLabel
        ' 
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Dock = DockStyle.Top
        ProductNameLabel.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ProductNameLabel.Location = New Point(10, 10)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New Size(91, 14)
        ProductNameLabel.TabIndex = 1
        ProductNameLabel.Text = "Product Name"
        ' 
        ' ProductName
        ' 
        ProductName.Cursor = Cursors.IBeam
        ProductName.Dock = DockStyle.Bottom
        ProductName.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ProductName.Location = New Point(10, 35)
        ProductName.Multiline = True
        ProductName.Name = "ProductName"
        ProductName.PlaceholderText = "Enter Product Name"
        ProductName.Size = New Size(425, 30)
        ProductName.TabIndex = 0
        ' 
        ' UpdateProductForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(240, 244, 247)
        ClientSize = New Size(917, 564)
        Controls.Add(CreateProductContainer)
        Controls.Add(HeaderPanel)
        Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "UpdateProductForm"
        Text = "UpdateProductForm"
        HeaderPanel.ResumeLayout(False)
        HeaderPanel.PerformLayout()
        CreateProductContainer.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
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
    Friend WithEvents CancelButton As Button
    Friend WithEvents UpdateProductButton As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents CategoryLabel As Label
    Friend WithEvents Category As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents BrandLabel As Label
    Friend WithEvents Brand As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Description As TextBox
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents QuantityLabel As Label
    Friend WithEvents Quantity As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PriceLabel As Label
    Friend WithEvents Price As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ProductSkuNameLabel As Label
    Friend WithEvents ProductSkuName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ProductNameLabel As Label
    Friend WithEvents ProductName As TextBox
    Friend WithEvents DeleteProductButton As Button
End Class
