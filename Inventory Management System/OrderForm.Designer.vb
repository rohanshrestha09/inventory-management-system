<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderForm
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
        OrderContainerPanel = New Panel()
        Panel1 = New Panel()
        SearchInputPanel = New Panel()
        SearchInput = New TextBox()
        CreateOrderButton = New Button()
        OrdersTable = New DataGridView()
        HeaderPanel.SuspendLayout()
        OrderContainerPanel.SuspendLayout()
        Panel1.SuspendLayout()
        SearchInputPanel.SuspendLayout()
        CType(OrdersTable, ComponentModel.ISupportInitialize).BeginInit()
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
        HeaderPanel.TabIndex = 1
        ' 
        ' Header
        ' 
        Header.AutoSize = True
        Header.Dock = DockStyle.Top
        Header.Font = New Font("CaskaydiaCove NF", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Header.Location = New Point(9, 9)
        Header.Name = "Header"
        Header.Size = New Size(94, 31)
        Header.TabIndex = 0
        Header.Text = "Order"
        ' 
        ' OrderContainerPanel
        ' 
        OrderContainerPanel.BackColor = Color.White
        OrderContainerPanel.Controls.Add(Panel1)
        OrderContainerPanel.Controls.Add(OrdersTable)
        OrderContainerPanel.Dock = DockStyle.Bottom
        OrderContainerPanel.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        OrderContainerPanel.Location = New Point(0, 68)
        OrderContainerPanel.Name = "OrderContainerPanel"
        OrderContainerPanel.Padding = New Padding(12)
        OrderContainerPanel.Size = New Size(917, 496)
        OrderContainerPanel.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(SearchInputPanel)
        Panel1.Controls.Add(CreateOrderButton)
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
        SearchInput.PlaceholderText = "Search Customer"
        SearchInput.Size = New Size(729, 16)
        SearchInput.TabIndex = 1
        ' 
        ' CreateOrderButton
        ' 
        CreateOrderButton.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        CreateOrderButton.Cursor = Cursors.Hand
        CreateOrderButton.Dock = DockStyle.Right
        CreateOrderButton.FlatStyle = FlatStyle.Flat
        CreateOrderButton.Font = New Font("CaskaydiaCove NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        CreateOrderButton.ForeColor = Color.White
        CreateOrderButton.Location = New Point(743, 0)
        CreateOrderButton.Name = "CreateOrderButton"
        CreateOrderButton.Size = New Size(150, 36)
        CreateOrderButton.TabIndex = 0
        CreateOrderButton.Text = "+ Create Order"
        CreateOrderButton.UseVisualStyleBackColor = False
        ' 
        ' OrdersTable
        ' 
        OrdersTable.AllowUserToAddRows = False
        OrdersTable.AllowUserToDeleteRows = False
        OrdersTable.AllowUserToResizeColumns = False
        OrdersTable.AllowUserToResizeRows = False
        OrdersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        OrdersTable.BackgroundColor = Color.FromArgb(CByte(246), CByte(250), CByte(255))
        OrdersTable.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(246), CByte(250), CByte(255))
        DataGridViewCellStyle1.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(246), CByte(250), CByte(255))
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        OrdersTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        OrdersTable.ColumnHeadersHeight = 40
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        OrdersTable.DefaultCellStyle = DataGridViewCellStyle2
        OrdersTable.Dock = DockStyle.Bottom
        OrdersTable.GridColor = Color.FromArgb(CByte(246), CByte(250), CByte(255))
        OrdersTable.Location = New Point(12, 59)
        OrdersTable.Name = "OrdersTable"
        OrdersTable.RowHeadersVisible = False
        OrdersTable.RowTemplate.Height = 35
        OrdersTable.RowTemplate.Resizable = DataGridViewTriState.False
        OrdersTable.ScrollBars = ScrollBars.Vertical
        OrdersTable.Size = New Size(893, 425)
        OrdersTable.TabIndex = 1
        ' 
        ' OrderForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        ClientSize = New Size(917, 564)
        Controls.Add(OrderContainerPanel)
        Controls.Add(HeaderPanel)
        Font = New Font("CaskaydiaCove NF", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "OrderForm"
        StartPosition = FormStartPosition.Manual
        Text = "OrderForm"
        HeaderPanel.ResumeLayout(False)
        HeaderPanel.PerformLayout()
        OrderContainerPanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        SearchInputPanel.ResumeLayout(False)
        SearchInputPanel.PerformLayout()
        CType(OrdersTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents Header As Label
    Friend WithEvents OrderContainerPanel As Panel
    Friend WithEvents OrdersTable As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CreateOrderButton As Button
    Friend WithEvents SearchInput As TextBox
    Friend WithEvents SearchInputPanel As Panel
End Class
