<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPROFILE
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
        Me.txtConnum = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtDUN = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.txtCusno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TblprofileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sales_inventory_system_for_groceryDataSet = New Sales_and_Inventory_System_for_Grocery.sales_inventory_system_for_groceryDataSet()
        Me.btnCANCEL = New System.Windows.Forms.Button()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.txtSEARCH = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tbl_profileTableAdapter = New Sales_and_Inventory_System_for_Grocery.sales_inventory_system_for_groceryDataSetTableAdapters.tbl_profileTableAdapter()
        Me.ContactnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddlenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomernoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TblprofileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sales_inventory_system_for_groceryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtConnum
        '
        Me.txtConnum.BackColor = System.Drawing.Color.White
        Me.txtConnum.Enabled = False
        Me.txtConnum.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConnum.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnum.Location = New System.Drawing.Point(805, 302)
        Me.txtConnum.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConnum.Multiline = True
        Me.txtConnum.Name = "txtConnum"
        Me.txtConnum.Size = New System.Drawing.Size(284, 35)
        Me.txtConnum.TabIndex = 146
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.Enabled = False
        Me.txtAddress.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAddress.Location = New System.Drawing.Point(807, 230)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtAddress.Size = New System.Drawing.Size(284, 35)
        Me.txtAddress.TabIndex = 145
        '
        'txtDUN
        '
        Me.txtDUN.Location = New System.Drawing.Point(1021, 26)
        Me.txtDUN.Name = "txtDUN"
        Me.txtDUN.Size = New System.Drawing.Size(100, 22)
        Me.txtDUN.TabIndex = 144
        Me.txtDUN.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(808, 274)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 23)
        Me.Label9.TabIndex = 142
        Me.Label9.Text = "Contact no."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(810, 130)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 23)
        Me.Label6.TabIndex = 140
        Me.Label6.Text = "Last Name"
        '
        'txtLname
        '
        Me.txtLname.BackColor = System.Drawing.Color.White
        Me.txtLname.Enabled = False
        Me.txtLname.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLname.Location = New System.Drawing.Point(808, 158)
        Me.txtLname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLname.Multiline = True
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(284, 35)
        Me.txtLname.TabIndex = 141
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(109, 303)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 28)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Customer Account"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sales_and_Inventory_System_for_Grocery.My.Resources.Resources._8ce8grcfqj4gaqq4sg28jgp5b6_1f286afea8ee1f62529d168e0cbd00c92
        Me.PictureBox1.Location = New System.Drawing.Point(143, 156)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 138
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(810, 202)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 23)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(497, 274)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 23)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "Middle name"
        '
        'txtMname
        '
        Me.txtMname.BackColor = System.Drawing.Color.White
        Me.txtMname.Enabled = False
        Me.txtMname.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMname.Location = New System.Drawing.Point(495, 302)
        Me.txtMname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMname.Multiline = True
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(280, 35)
        Me.txtMname.TabIndex = 136
        '
        'txtCusno
        '
        Me.txtCusno.BackColor = System.Drawing.Color.White
        Me.txtCusno.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusno.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCusno.Location = New System.Drawing.Point(494, 158)
        Me.txtCusno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCusno.Multiline = True
        Me.txtCusno.Name = "txtCusno"
        Me.txtCusno.ReadOnly = True
        Me.txtCusno.Size = New System.Drawing.Size(280, 35)
        Me.txtCusno.TabIndex = 134
        Me.txtCusno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(496, 130)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 23)
        Me.Label7.TabIndex = 133
        Me.Label7.Text = "Customer number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(497, 202)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 23)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "First name"
        '
        'txtFname
        '
        Me.txtFname.BackColor = System.Drawing.Color.White
        Me.txtFname.Enabled = False
        Me.txtFname.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFname.Location = New System.Drawing.Point(495, 230)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFname.Multiline = True
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(280, 35)
        Me.txtFname.TabIndex = 132
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(55, 29)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(370, 44)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "CUSTOMER PROFILE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.btnCANCEL)
        Me.Panel1.Controls.Add(Me.btnSAVE)
        Me.Panel1.Controls.Add(Me.btnEDIT)
        Me.Panel1.Controls.Add(Me.btnADD)
        Me.Panel1.Controls.Add(Me.txtSEARCH)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(18, 374)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1130, 366)
        Me.Panel1.TabIndex = 143
        '
        'TblprofileBindingSource
        '
        Me.TblprofileBindingSource.DataMember = "tbl_profile"
        Me.TblprofileBindingSource.DataSource = Me.Sales_inventory_system_for_groceryDataSet
        '
        'Sales_inventory_system_for_groceryDataSet
        '
        Me.Sales_inventory_system_for_groceryDataSet.DataSetName = "sales_inventory_system_for_groceryDataSet"
        Me.Sales_inventory_system_for_groceryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnCANCEL
        '
        Me.btnCANCEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnCANCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCANCEL.Enabled = False
        Me.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCANCEL.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCANCEL.ForeColor = System.Drawing.Color.White
        Me.btnCANCEL.Location = New System.Drawing.Point(19, 289)
        Me.btnCANCEL.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCANCEL.Name = "btnCANCEL"
        Me.btnCANCEL.Size = New System.Drawing.Size(117, 45)
        Me.btnCANCEL.TabIndex = 94
        Me.btnCANCEL.Text = "CANCEL"
        Me.btnCANCEL.UseVisualStyleBackColor = False
        '
        'btnSAVE
        '
        Me.btnSAVE.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnSAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSAVE.Enabled = False
        Me.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSAVE.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSAVE.ForeColor = System.Drawing.Color.White
        Me.btnSAVE.Location = New System.Drawing.Point(18, 217)
        Me.btnSAVE.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(117, 45)
        Me.btnSAVE.TabIndex = 93
        Me.btnSAVE.Text = "SAVE"
        Me.btnSAVE.UseVisualStyleBackColor = False
        '
        'btnEDIT
        '
        Me.btnEDIT.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnEDIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEDIT.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEDIT.ForeColor = System.Drawing.Color.White
        Me.btnEDIT.Location = New System.Drawing.Point(19, 144)
        Me.btnEDIT.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEDIT.Name = "btnEDIT"
        Me.btnEDIT.Size = New System.Drawing.Size(117, 45)
        Me.btnEDIT.TabIndex = 92
        Me.btnEDIT.Text = "EDIT"
        Me.btnEDIT.UseVisualStyleBackColor = False
        '
        'btnADD
        '
        Me.btnADD.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnADD.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnADD.ForeColor = System.Drawing.Color.White
        Me.btnADD.Location = New System.Drawing.Point(20, 69)
        Me.btnADD.Margin = New System.Windows.Forms.Padding(4)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(117, 45)
        Me.btnADD.TabIndex = 90
        Me.btnADD.Text = "ADD"
        Me.btnADD.UseVisualStyleBackColor = False
        '
        'txtSEARCH
        '
        Me.txtSEARCH.BackColor = System.Drawing.Color.White
        Me.txtSEARCH.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSEARCH.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSEARCH.Location = New System.Drawing.Point(821, 20)
        Me.txtSEARCH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSEARCH.Multiline = True
        Me.txtSEARCH.Name = "txtSEARCH"
        Me.txtSEARCH.Size = New System.Drawing.Size(233, 35)
        Me.txtSEARCH.TabIndex = 110
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(662, 26)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 23)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "Search Record"
        '
        'Tbl_profileTableAdapter
        '
        Me.Tbl_profileTableAdapter.ClearBeforeFill = True
        '
        'ContactnoDataGridViewTextBoxColumn
        '
        Me.ContactnoDataGridViewTextBoxColumn.DataPropertyName = "Contactno"
        Me.ContactnoDataGridViewTextBoxColumn.HeaderText = "Contactno"
        Me.ContactnoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ContactnoDataGridViewTextBoxColumn.Name = "ContactnoDataGridViewTextBoxColumn"
        Me.ContactnoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ContactnoDataGridViewTextBoxColumn.Width = 125
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.AddressDataGridViewTextBoxColumn.Width = 125
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LastnameDataGridViewTextBoxColumn.Width = 125
        '
        'MiddlenameDataGridViewTextBoxColumn
        '
        Me.MiddlenameDataGridViewTextBoxColumn.DataPropertyName = "Middlename"
        Me.MiddlenameDataGridViewTextBoxColumn.HeaderText = "Middlename"
        Me.MiddlenameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MiddlenameDataGridViewTextBoxColumn.Name = "MiddlenameDataGridViewTextBoxColumn"
        Me.MiddlenameDataGridViewTextBoxColumn.ReadOnly = True
        Me.MiddlenameDataGridViewTextBoxColumn.Width = 125
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FirstnameDataGridViewTextBoxColumn.Width = 125
        '
        'CustomernoDataGridViewTextBoxColumn
        '
        Me.CustomernoDataGridViewTextBoxColumn.DataPropertyName = "Customerno"
        Me.CustomernoDataGridViewTextBoxColumn.HeaderText = "Customerno"
        Me.CustomernoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustomernoDataGridViewTextBoxColumn.Name = "CustomernoDataGridViewTextBoxColumn"
        Me.CustomernoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomernoDataGridViewTextBoxColumn.Width = 125
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomernoDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.MiddlenameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactnoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblprofileBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(161, 67)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(942, 267)
        Me.DataGridView1.TabIndex = 98
        '
        'ucPROFILE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Controls.Add(Me.txtConnum)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtDUN)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMname)
        Me.Controls.Add(Me.txtCusno)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ucPROFILE"
        Me.Size = New System.Drawing.Size(1167, 766)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblprofileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sales_inventory_system_for_groceryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtConnum As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtDUN As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtCusno As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCANCEL As Button
    Friend WithEvents btnSAVE As Button
    Friend WithEvents btnEDIT As Button
    Friend WithEvents btnADD As Button
    Friend WithEvents txtSEARCH As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TblprofileBindingSource As BindingSource
    Friend WithEvents Sales_inventory_system_for_groceryDataSet As sales_inventory_system_for_groceryDataSet
    Friend WithEvents Tbl_profileTableAdapter As sales_inventory_system_for_groceryDataSetTableAdapters.tbl_profileTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CustomernoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddlenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
