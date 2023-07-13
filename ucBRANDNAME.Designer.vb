<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBRANDNAME
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BrandcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblbrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sales_inventory_system_for_groceryDataSet = New Sales_and_Inventory_System_for_Grocery.sales_inventory_system_for_groceryDataSet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSEARCH = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtBRANDCODE = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBRANDNAME = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCANCEL = New System.Windows.Forms.Button()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.Tbl_brandTableAdapter = New Sales_and_Inventory_System_for_Grocery.sales_inventory_system_for_groceryDataSetTableAdapters.tbl_brandTableAdapter()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblbrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sales_inventory_system_for_groceryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtSEARCH)
        Me.Panel3.Location = New System.Drawing.Point(422, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(447, 677)
        Me.Panel3.TabIndex = 138
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BrandcodeDataGridViewTextBoxColumn, Me.BrandnameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblbrandBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(17, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(408, 591)
        Me.DataGridView1.TabIndex = 95
        '
        'BrandcodeDataGridViewTextBoxColumn
        '
        Me.BrandcodeDataGridViewTextBoxColumn.DataPropertyName = "brandcode"
        Me.BrandcodeDataGridViewTextBoxColumn.HeaderText = "brandcode"
        Me.BrandcodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BrandcodeDataGridViewTextBoxColumn.Name = "BrandcodeDataGridViewTextBoxColumn"
        Me.BrandcodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.BrandcodeDataGridViewTextBoxColumn.Width = 125
        '
        'BrandnameDataGridViewTextBoxColumn
        '
        Me.BrandnameDataGridViewTextBoxColumn.DataPropertyName = "brandname"
        Me.BrandnameDataGridViewTextBoxColumn.HeaderText = "brandname"
        Me.BrandnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BrandnameDataGridViewTextBoxColumn.Name = "BrandnameDataGridViewTextBoxColumn"
        Me.BrandnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.BrandnameDataGridViewTextBoxColumn.Width = 125
        '
        'TblbrandBindingSource
        '
        Me.TblbrandBindingSource.DataMember = "tbl_brand"
        Me.TblbrandBindingSource.DataSource = Me.Sales_inventory_system_for_groceryDataSet
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
        Me.Label8.Location = New System.Drawing.Point(101, 28)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 23)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Search Brand"
        '
        'txtSEARCH
        '
        Me.txtSEARCH.BackColor = System.Drawing.Color.White
        Me.txtSEARCH.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSEARCH.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSEARCH.Location = New System.Drawing.Point(245, 21)
        Me.txtSEARCH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSEARCH.Multiline = True
        Me.txtSEARCH.Name = "txtSEARCH"
        Me.txtSEARCH.Size = New System.Drawing.Size(180, 35)
        Me.txtSEARCH.TabIndex = 93
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtBRANDCODE)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtBRANDNAME)
        Me.Panel2.Location = New System.Drawing.Point(23, 364)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(387, 329)
        Me.Panel2.TabIndex = 137
        '
        'txtBRANDCODE
        '
        Me.txtBRANDCODE.BackColor = System.Drawing.Color.White
        Me.txtBRANDCODE.Enabled = False
        Me.txtBRANDCODE.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBRANDCODE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBRANDCODE.Location = New System.Drawing.Point(81, 105)
        Me.txtBRANDCODE.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBRANDCODE.Multiline = True
        Me.txtBRANDCODE.Name = "txtBRANDCODE"
        Me.txtBRANDCODE.Size = New System.Drawing.Size(233, 35)
        Me.txtBRANDCODE.TabIndex = 100
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(78, 81)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 23)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "Brand code"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(81, 158)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 23)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Brand name"
        '
        'txtBRANDNAME
        '
        Me.txtBRANDNAME.BackColor = System.Drawing.Color.White
        Me.txtBRANDNAME.Enabled = False
        Me.txtBRANDNAME.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBRANDNAME.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBRANDNAME.Location = New System.Drawing.Point(80, 181)
        Me.txtBRANDNAME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBRANDNAME.Multiline = True
        Me.txtBRANDNAME.Name = "txtBRANDNAME"
        Me.txtBRANDNAME.Size = New System.Drawing.Size(233, 35)
        Me.txtBRANDNAME.TabIndex = 98
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnSAVE)
        Me.Panel1.Controls.Add(Me.btnADD)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnCANCEL)
        Me.Panel1.Controls.Add(Me.btnEDIT)
        Me.Panel1.Location = New System.Drawing.Point(23, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(387, 337)
        Me.Panel1.TabIndex = 136
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(59, 48)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(268, 44)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "BRAND NAME"
        '
        'btnCANCEL
        '
        Me.btnCANCEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnCANCEL.Enabled = False
        Me.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCANCEL.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.btnCANCEL.ForeColor = System.Drawing.Color.White
        Me.btnCANCEL.Location = New System.Drawing.Point(201, 216)
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
        Me.btnEDIT.Location = New System.Drawing.Point(68, 216)
        Me.btnEDIT.Name = "btnEDIT"
        Me.btnEDIT.Size = New System.Drawing.Size(117, 45)
        Me.btnEDIT.TabIndex = 2
        Me.btnEDIT.Text = "EDIT"
        Me.btnEDIT.UseVisualStyleBackColor = False
        '
        'Tbl_brandTableAdapter
        '
        Me.Tbl_brandTableAdapter.ClearBeforeFill = True
        '
        'btnSAVE
        '
        Me.btnSAVE.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnSAVE.Enabled = False
        Me.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSAVE.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.btnSAVE.ForeColor = System.Drawing.Color.White
        Me.btnSAVE.Location = New System.Drawing.Point(201, 146)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(117, 45)
        Me.btnSAVE.TabIndex = 135
        Me.btnSAVE.Text = "SAVE"
        Me.btnSAVE.UseVisualStyleBackColor = False
        '
        'btnADD
        '
        Me.btnADD.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnADD.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.btnADD.ForeColor = System.Drawing.Color.White
        Me.btnADD.Location = New System.Drawing.Point(68, 146)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(117, 45)
        Me.btnADD.TabIndex = 134
        Me.btnADD.Text = "ADD"
        Me.btnADD.UseVisualStyleBackColor = False
        '
        'ucBRANDNAME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ucBRANDNAME"
        Me.Size = New System.Drawing.Size(892, 716)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblbrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sales_inventory_system_for_groceryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSEARCH As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtBRANDCODE As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBRANDNAME As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCANCEL As Button
    Friend WithEvents btnEDIT As Button
    Friend WithEvents BrandcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrandnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblbrandBindingSource As BindingSource
    Friend WithEvents Sales_inventory_system_for_groceryDataSet As sales_inventory_system_for_groceryDataSet
    Friend WithEvents Tbl_brandTableAdapter As sales_inventory_system_for_groceryDataSetTableAdapters.tbl_brandTableAdapter
    Friend WithEvents btnSAVE As Button
    Friend WithEvents btnADD As Button
End Class
