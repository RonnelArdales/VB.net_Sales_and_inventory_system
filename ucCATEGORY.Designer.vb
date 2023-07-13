<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCATEGORY
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSEARCH = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CategorycodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategorynameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblcategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sales_inventory_system_for_groceryDataSet = New Sales_and_Inventory_System_for_Grocery.sales_inventory_system_for_groceryDataSet()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtCATEGORYCODE = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCATEGORYNAME = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCANCEL = New System.Windows.Forms.Button()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.Tbl_categoryTableAdapter = New Sales_and_Inventory_System_for_Grocery.sales_inventory_system_for_groceryDataSetTableAdapters.tbl_categoryTableAdapter()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sales_inventory_system_for_groceryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtSEARCH)
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Location = New System.Drawing.Point(422, 20)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(445, 671)
        Me.Panel3.TabIndex = 141
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(51, 27)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 23)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "Search category"
        '
        'txtSEARCH
        '
        Me.txtSEARCH.BackColor = System.Drawing.Color.White
        Me.txtSEARCH.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSEARCH.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSEARCH.Location = New System.Drawing.Point(230, 21)
        Me.txtSEARCH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSEARCH.Multiline = True
        Me.txtSEARCH.Name = "txtSEARCH"
        Me.txtSEARCH.Size = New System.Drawing.Size(193, 35)
        Me.txtSEARCH.TabIndex = 93
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CategorycodeDataGridViewTextBoxColumn, Me.CategorynameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblcategoryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(17, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(406, 575)
        Me.DataGridView1.TabIndex = 0
        '
        'CategorycodeDataGridViewTextBoxColumn
        '
        Me.CategorycodeDataGridViewTextBoxColumn.DataPropertyName = "categorycode"
        Me.CategorycodeDataGridViewTextBoxColumn.HeaderText = "categorycode"
        Me.CategorycodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CategorycodeDataGridViewTextBoxColumn.Name = "CategorycodeDataGridViewTextBoxColumn"
        Me.CategorycodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategorycodeDataGridViewTextBoxColumn.Width = 125
        '
        'CategorynameDataGridViewTextBoxColumn
        '
        Me.CategorynameDataGridViewTextBoxColumn.DataPropertyName = "categoryname"
        Me.CategorynameDataGridViewTextBoxColumn.HeaderText = "categoryname"
        Me.CategorynameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CategorynameDataGridViewTextBoxColumn.Name = "CategorynameDataGridViewTextBoxColumn"
        Me.CategorynameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategorynameDataGridViewTextBoxColumn.Width = 125
        '
        'TblcategoryBindingSource
        '
        Me.TblcategoryBindingSource.DataMember = "tbl_category"
        Me.TblcategoryBindingSource.DataSource = Me.Sales_inventory_system_for_groceryDataSet
        '
        'Sales_inventory_system_for_groceryDataSet
        '
        Me.Sales_inventory_system_for_groceryDataSet.DataSetName = "sales_inventory_system_for_groceryDataSet"
        Me.Sales_inventory_system_for_groceryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtCATEGORYCODE)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtCATEGORYNAME)
        Me.Panel2.Location = New System.Drawing.Point(22, 364)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(388, 327)
        Me.Panel2.TabIndex = 140
        '
        'txtCATEGORYCODE
        '
        Me.txtCATEGORYCODE.BackColor = System.Drawing.Color.White
        Me.txtCATEGORYCODE.Enabled = False
        Me.txtCATEGORYCODE.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCATEGORYCODE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCATEGORYCODE.Location = New System.Drawing.Point(75, 97)
        Me.txtCATEGORYCODE.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCATEGORYCODE.Multiline = True
        Me.txtCATEGORYCODE.Name = "txtCATEGORYCODE"
        Me.txtCATEGORYCODE.Size = New System.Drawing.Size(233, 35)
        Me.txtCATEGORYCODE.TabIndex = 100
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(72, 73)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 23)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "Category code"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(75, 149)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 23)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Category name"
        '
        'txtCATEGORYNAME
        '
        Me.txtCATEGORYNAME.BackColor = System.Drawing.Color.White
        Me.txtCATEGORYNAME.Enabled = False
        Me.txtCATEGORYNAME.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCATEGORYNAME.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCATEGORYNAME.Location = New System.Drawing.Point(75, 177)
        Me.txtCATEGORYNAME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCATEGORYNAME.Multiline = True
        Me.txtCATEGORYNAME.Name = "txtCATEGORYNAME"
        Me.txtCATEGORYNAME.Size = New System.Drawing.Size(233, 35)
        Me.txtCATEGORYNAME.TabIndex = 98
        Me.txtCATEGORYNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnCANCEL)
        Me.Panel1.Controls.Add(Me.btnEDIT)
        Me.Panel1.Controls.Add(Me.btnSAVE)
        Me.Panel1.Controls.Add(Me.btnADD)
        Me.Panel1.Location = New System.Drawing.Point(22, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(388, 333)
        Me.Panel1.TabIndex = 139
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 39)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "PRODUCT CATEGORY"
        '
        'btnCANCEL
        '
        Me.btnCANCEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnCANCEL.Enabled = False
        Me.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCANCEL.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.btnCANCEL.ForeColor = System.Drawing.Color.White
        Me.btnCANCEL.Location = New System.Drawing.Point(202, 228)
        Me.btnCANCEL.Name = "btnCANCEL"
        Me.btnCANCEL.Size = New System.Drawing.Size(117, 45)
        Me.btnCANCEL.TabIndex = 3
        Me.btnCANCEL.Text = "CANCEL"
        Me.btnCANCEL.UseVisualStyleBackColor = False
        '
        'btnEDIT
        '
        Me.btnEDIT.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEDIT.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.btnEDIT.ForeColor = System.Drawing.Color.White
        Me.btnEDIT.Location = New System.Drawing.Point(69, 228)
        Me.btnEDIT.Name = "btnEDIT"
        Me.btnEDIT.Size = New System.Drawing.Size(117, 45)
        Me.btnEDIT.TabIndex = 2
        Me.btnEDIT.Text = "EDIT"
        Me.btnEDIT.UseVisualStyleBackColor = False
        '
        'btnSAVE
        '
        Me.btnSAVE.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnSAVE.Enabled = False
        Me.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSAVE.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.btnSAVE.ForeColor = System.Drawing.Color.White
        Me.btnSAVE.Location = New System.Drawing.Point(202, 162)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(117, 45)
        Me.btnSAVE.TabIndex = 1
        Me.btnSAVE.Text = "SAVE"
        Me.btnSAVE.UseVisualStyleBackColor = False
        '
        'btnADD
        '
        Me.btnADD.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnADD.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.btnADD.ForeColor = System.Drawing.Color.White
        Me.btnADD.Location = New System.Drawing.Point(69, 162)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(117, 45)
        Me.btnADD.TabIndex = 0
        Me.btnADD.Text = "ADD"
        Me.btnADD.UseVisualStyleBackColor = False
        '
        'Tbl_categoryTableAdapter
        '
        Me.Tbl_categoryTableAdapter.ClearBeforeFill = True
        '
        'ucCATEGORY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ucCATEGORY"
        Me.Size = New System.Drawing.Size(892, 716)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sales_inventory_system_for_groceryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSEARCH As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtCATEGORYCODE As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCATEGORYNAME As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCANCEL As Button
    Friend WithEvents btnEDIT As Button
    Friend WithEvents btnSAVE As Button
    Friend WithEvents btnADD As Button
    Friend WithEvents CategorycodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategorynameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblcategoryBindingSource As BindingSource
    Friend WithEvents Sales_inventory_system_for_groceryDataSet As sales_inventory_system_for_groceryDataSet
    Friend WithEvents Tbl_categoryTableAdapter As sales_inventory_system_for_groceryDataSetTableAdapters.tbl_categoryTableAdapter
End Class
