<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductForm
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
        ProductContainerPanel = New Panel()
        Panel1 = New Panel()
        SearchInputPanel = New Panel()
        SearchInput = New TextBox()
        CreateProductButton = New Button()
        ProductsTable = New DataGridView()
        HeaderPanel.SuspendLayout()
        ProductContainerPanel.SuspendLayout()
        Panel1.SuspendLayout()
        SearchInputPanel.SuspendLayout()
        CType(ProductsTable, ComponentModel.ISupportInitialize).BeginInit()
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
        HeaderPanel.TabIndex = 2
        ' 
        ' Header
        ' 
        Header.AutoSize = True
        Header.Dock = DockStyle.Top
        Header.Font = New Font("CaskaydiaCove NF", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Header.Location = New Point(9, 9)
        Header.Name = "Header"
        Header.Size = New Size(126, 31)
        Header.TabIndex = 0
        Header.Text = "Product"
        ' 
        ' ProductContainerPanel
        ' 
        ProductContainerPanel.BackColor = Color.White
        ProductContainerPanel.Controls.Add(Panel1)
        ProductContainerPanel.Controls.Add(ProductsTable)
        ProductContainerPanel.Dock = DockStyle.Bottom
        ProductContainerPanel.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        ProductContainerPanel.Location = New Point(0, 68)
        ProductContainerPanel.Name = "ProductContainerPanel"
        ProductContainerPanel.Padding = New Padding(12)
        ProductContainerPanel.Size = New Size(917, 496)
        ProductContainerPanel.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(SearchInputPanel)
        Panel1.Controls.Add(CreateProductButton)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(893, 36)
        Panel1.TabIndex = 2
        ' 
        ' SearchInputPanel
        ' 
        SearchInputPanel.BackColor = Color.FromArgb(CByte(246), CByte(250), CByte(255))
        SearchInputPanel.Controls.Add(SearchInput)
        SearchInputPanel.Dock = DockStyle.Left
        SearchInputPanel.Location = New Point(0, 0)
        SearchInputPanel.Name = "SearchInputPanel"
        SearchInputPanel.Size = New Size(735, 36)
        SearchInputPanel.TabIndex = 1
        ' 
        ' SearchInput
        ' 
        SearchInput.BackColor = Color.FromArgb(CByte(246), CByte(250), CByte(255))
        SearchInput.BorderStyle = BorderStyle.None
        SearchInput.Cursor = Cursors.IBeam
        SearchInput.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        SearchInput.ForeColor = Color.Black
        SearchInput.Location = New Point(3, 9)
        SearchInput.Name = "SearchInput"
        SearchInput.PlaceholderText = "Search Product"
        SearchInput.Size = New Size(729, 16)
        SearchInput.TabIndex = 1
        ' 
        ' CreateProductButton
        ' 
        CreateProductButton.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        CreateProductButton.Cursor = Cursors.Hand
        CreateProductButton.Dock = DockStyle.Right
        CreateProductButton.FlatStyle = FlatStyle.Flat
        CreateProductButton.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        CreateProductButton.ForeColor = Color.White
        CreateProductButton.Location = New Point(743, 0)
        CreateProductButton.Name = "CreateProductButton"
        CreateProductButton.Size = New Size(150, 36)
        CreateProductButton.TabIndex = 0
        CreateProductButton.Text = "+ Create Product"
        CreateProductButton.UseVisualStyleBackColor = False
        ' 
        ' ProductsTable
        ' 
        ProductsTable.AllowUserToAddRows = False
        ProductsTable.AllowUserToDeleteRows = False
        ProductsTable.AllowUserToResizeColumns = False
        ProductsTable.AllowUserToResizeRows = False
        ProductsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ProductsTable.BackgroundColor = Color.FromArgb(CByte(246), CByte(250), CByte(255))
        ProductsTable.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(246), CByte(250), CByte(255))
        DataGridViewCellStyle1.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(246), CByte(250), CByte(255))
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        ProductsTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        ProductsTable.ColumnHeadersHeight = 40
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        ProductsTable.DefaultCellStyle = DataGridViewCellStyle2
        ProductsTable.Dock = DockStyle.Bottom
        ProductsTable.GridColor = Color.FromArgb(CByte(246), CByte(250), CByte(255))
        ProductsTable.Location = New Point(12, 59)
        ProductsTable.Name = "ProductsTable"
        ProductsTable.RowHeadersVisible = False
        ProductsTable.RowTemplate.Height = 35
        ProductsTable.RowTemplate.Resizable = DataGridViewTriState.False
        ProductsTable.ScrollBars = ScrollBars.Vertical
        ProductsTable.Size = New Size(893, 425)
        ProductsTable.TabIndex = 1
        ' 
        ' ProductForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        ClientSize = New Size(917, 564)
        Controls.Add(ProductContainerPanel)
        Controls.Add(HeaderPanel)
        Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "ProductForm"
        Text = "ProductForm"
        HeaderPanel.ResumeLayout(False)
        HeaderPanel.PerformLayout()
        ProductContainerPanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        SearchInputPanel.ResumeLayout(False)
        SearchInputPanel.PerformLayout()
        CType(ProductsTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents Header As Label
    Friend WithEvents ProductContainerPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SearchInputPanel As Panel
    Friend WithEvents SearchInput As TextBox
    Friend WithEvents CreateProductButton As Button
    Friend WithEvents ProductsTable As DataGridView
End Class
