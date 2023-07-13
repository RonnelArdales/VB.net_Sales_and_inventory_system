<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPRODUCTSTOCK
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtSTOCKADDED = New System.Windows.Forms.TextBox()
        Me.txtavailstock = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSTOCKID = New System.Windows.Forms.TextBox()
        Me.txtPC = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTNSAVE = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.BTNCANCEL = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSEARCH = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductcategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblproductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sales_inventory_system_for_groceryDataSet = New Sales_and_Inventory_System_for_Grocery.sales_inventory_system_for_groceryDataSet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tbl_productTableAdapter = New Sales_and_Inventory_System_for_Grocery.sales_inventory_system_for_groceryDataSetTableAdapters.tbl_productTableAdapter()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblproductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sales_inventory_system_for_groceryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Panel3.Controls.Add(Me.txtSTOCKADDED)
        Me.Panel3.Controls.Add(Me.txtavailstock)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtPN)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txtSTOCKID)
        Me.Panel3.Controls.Add(Me.txtPC)
        Me.Panel3.Location = New System.Drawing.Point(21, 371)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(509, 370)
        Me.Panel3.TabIndex = 146
        '
        'txtSTOCKADDED
        '
        Me.txtSTOCKADDED.BackColor = System.Drawing.Color.White
        Me.txtSTOCKADDED.Enabled = False
        Me.txtSTOCKADDED.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSTOCKADDED.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSTOCKADDED.Location = New System.Drawing.Point(110, 295)
        Me.txtSTOCKADDED.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSTOCKADDED.Multiline = True
        Me.txtSTOCKADDED.Name = "txtSTOCKADDED"
        Me.txtSTOCKADDED.Size = New System.Drawing.Size(280, 35)
        Me.txtSTOCKADDED.TabIndex = 127
        Me.txtSTOCKADDED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtavailstock
        '
        Me.txtavailstock.BackColor = System.Drawing.Color.White
        Me.txtavailstock.Enabled = False
        Me.txtavailstock.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtavailstock.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtavailstock.Location = New System.Drawing.Point(110, 215)
        Me.txtavailstock.Margin = New System.Windows.Forms.Padding(4)
        Me.txtavailstock.Multiline = True
        Me.txtavailstock.Name = "txtavailstock"
        Me.txtavailstock.Size = New System.Drawing.Size(280, 35)
        Me.txtavailstock.TabIndex = 119
        Me.txtavailstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(111, 117)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 23)
        Me.Label6.TabIndex = 139
        Me.Label6.Text = "Product Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(111, 191)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 23)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Available Stocks"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(112, 270)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 23)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "No of stock added"
        '
        'txtPN
        '
        Me.txtPN.BackColor = System.Drawing.Color.White
        Me.txtPN.Enabled = False
        Me.txtPN.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPN.Location = New System.Drawing.Point(110, 141)
        Me.txtPN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPN.Multiline = True
        Me.txtPN.Name = "txtPN"
        Me.txtPN.Size = New System.Drawing.Size(280, 35)
        Me.txtPN.TabIndex = 140
        Me.txtPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(111, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 23)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Product Code"
        '
        'txtSTOCKID
        '
        Me.txtSTOCKID.BackColor = System.Drawing.Color.White
        Me.txtSTOCKID.Enabled = False
        Me.txtSTOCKID.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSTOCKID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSTOCKID.Location = New System.Drawing.Point(55, 213)
        Me.txtSTOCKID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSTOCKID.Multiline = True
        Me.txtSTOCKID.Name = "txtSTOCKID"
        Me.txtSTOCKID.Size = New System.Drawing.Size(13, 35)
        Me.txtSTOCKID.TabIndex = 136
        Me.txtSTOCKID.Visible = False
        '
        'txtPC
        '
        Me.txtPC.BackColor = System.Drawing.Color.White
        Me.txtPC.Enabled = False
        Me.txtPC.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPC.Location = New System.Drawing.Point(110, 60)
        Me.txtPC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPC.Multiline = True
        Me.txtPC.Name = "txtPC"
        Me.txtPC.Size = New System.Drawing.Size(280, 35)
        Me.txtPC.TabIndex = 134
        Me.txtPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BTNSAVE)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.BTNCANCEL)
        Me.Panel2.Location = New System.Drawing.Point(21, 26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(509, 324)
        Me.Panel2.TabIndex = 145
        '
        'BTNSAVE
        '
        Me.BTNSAVE.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BTNSAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTNSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSAVE.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSAVE.ForeColor = System.Drawing.Color.White
        Me.BTNSAVE.Location = New System.Drawing.Point(124, 252)
        Me.BTNSAVE.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNSAVE.Name = "BTNSAVE"
        Me.BTNSAVE.Size = New System.Drawing.Size(117, 45)
        Me.BTNSAVE.TabIndex = 132
        Me.BTNSAVE.Text = "SAVE"
        Me.BTNSAVE.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(87, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(325, 44)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "PRODUCT STOCK"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Sales_and_Inventory_System_for_Grocery.My.Resources.Resources.hd_shopping_cart_white_logo_icon_transparent_png_11640441682ecem2ohejv_removebg_preview
        Me.PictureBox5.Location = New System.Drawing.Point(178, 86)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(138, 125)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 131
        Me.PictureBox5.TabStop = False
        '
        'BTNCANCEL
        '
        Me.BTNCANCEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BTNCANCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTNCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCANCEL.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCEL.ForeColor = System.Drawing.Color.White
        Me.BTNCANCEL.Location = New System.Drawing.Point(273, 251)
        Me.BTNCANCEL.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNCANCEL.Name = "BTNCANCEL"
        Me.BTNCANCEL.Size = New System.Drawing.Size(117, 45)
        Me.BTNCANCEL.TabIndex = 100
        Me.BTNCANCEL.Text = "CANCEL"
        Me.BTNCANCEL.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtSEARCH)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(545, 25)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(601, 716)
        Me.Panel1.TabIndex = 144
        '
        'txtSEARCH
        '
        Me.txtSEARCH.BackColor = System.Drawing.Color.White
        Me.txtSEARCH.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSEARCH.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSEARCH.Location = New System.Drawing.Point(349, 23)
        Me.txtSEARCH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSEARCH.Multiline = True
        Me.txtSEARCH.Name = "txtSEARCH"
        Me.txtSEARCH.Size = New System.Drawing.Size(207, 35)
        Me.txtSEARCH.TabIndex = 141
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductCodeDataGridViewTextBoxColumn, Me.ProductnameDataGridViewTextBoxColumn, Me.ProductcategoryDataGridViewTextBoxColumn, Me.BrandDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblproductBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 76)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(568, 616)
        Me.DataGridView1.TabIndex = 97
        '
        'ProductCodeDataGridViewTextBoxColumn
        '
        Me.ProductCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode"
        Me.ProductCodeDataGridViewTextBoxColumn.HeaderText = "ProductCode"
        Me.ProductCodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductCodeDataGridViewTextBoxColumn.Name = "ProductCodeDataGridViewTextBoxColumn"
        Me.ProductCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductCodeDataGridViewTextBoxColumn.Width = 125
        '
        'ProductnameDataGridViewTextBoxColumn
        '
        Me.ProductnameDataGridViewTextBoxColumn.DataPropertyName = "Productname"
        Me.ProductnameDataGridViewTextBoxColumn.HeaderText = "Productname"
        Me.ProductnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductnameDataGridViewTextBoxColumn.Name = "ProductnameDataGridViewTextBoxColumn"
        Me.ProductnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductnameDataGridViewTextBoxColumn.Width = 125
        '
        'ProductcategoryDataGridViewTextBoxColumn
        '
        Me.ProductcategoryDataGridViewTextBoxColumn.DataPropertyName = "Productcategory"
        Me.ProductcategoryDataGridViewTextBoxColumn.HeaderText = "Productcategory"
        Me.ProductcategoryDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductcategoryDataGridViewTextBoxColumn.Name = "ProductcategoryDataGridViewTextBoxColumn"
        Me.ProductcategoryDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductcategoryDataGridViewTextBoxColumn.Width = 125
        '
        'BrandDataGridViewTextBoxColumn
        '
        Me.BrandDataGridViewTextBoxColumn.DataPropertyName = "Brand"
        Me.BrandDataGridViewTextBoxColumn.HeaderText = "Brand"
        Me.BrandDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BrandDataGridViewTextBoxColumn.Name = "BrandDataGridViewTextBoxColumn"
        Me.BrandDataGridViewTextBoxColumn.ReadOnly = True
        Me.BrandDataGridViewTextBoxColumn.Width = 125
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.PriceDataGridViewTextBoxColumn.Width = 125
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuantityDataGridViewTextBoxColumn.Width = 125
        '
        'TblproductBindingSource
        '
        Me.TblproductBindingSource.DataMember = "tbl_product"
        Me.TblproductBindingSource.DataSource = Me.Sales_inventory_system_for_groceryDataSet
        '
        'Sales_inventory_system_for_groceryDataSet
        '
        Me.Sales_inventory_system_for_groceryDataSet.DataSetName = "sales_inventory_system_for_groceryDataSet"
        Me.Sales_inventory_system_for_groceryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(192, 29)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 23)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "Search Product"
        '
        'Tbl_productTableAdapter
        '
        Me.Tbl_productTableAdapter.ClearBeforeFill = True
        '
        'ucPRODUCTSTOCK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ucPRODUCTSTOCK"
        Me.Size = New System.Drawing.Size(1167, 766)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblproductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sales_inventory_system_for_groceryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtSTOCKADDED As TextBox
    Friend WithEvents txtavailstock As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSTOCKID As TextBox
    Friend WithEvents txtPC As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents BTNCANCEL As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSEARCH As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents ProductCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductcategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblproductBindingSource As BindingSource
    Friend WithEvents Sales_inventory_system_for_groceryDataSet As sales_inventory_system_for_groceryDataSet
    Friend WithEvents Tbl_productTableAdapter As sales_inventory_system_for_groceryDataSetTableAdapters.tbl_productTableAdapter
    Friend WithEvents BTNSAVE As Button
End Class
