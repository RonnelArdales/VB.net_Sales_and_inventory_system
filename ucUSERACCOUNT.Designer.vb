<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucUSERACCOUNT
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
        Me.txtDUN = New System.Windows.Forms.TextBox()
        Me.cboSTATUS = New System.Windows.Forms.ComboBox()
        Me.cboUSERTYPE = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtACCNAME = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCONPASS = New System.Windows.Forms.TextBox()
        Me.txtUn = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsertypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbluserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sales_inventory_system_for_groceryDataSet = New Sales_and_Inventory_System_for_Grocery.sales_inventory_system_for_groceryDataSet()
        Me.btnCANCEL = New System.Windows.Forms.Button()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.txtSEARCH = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tbl_userTableAdapter = New Sales_and_Inventory_System_for_Grocery.sales_inventory_system_for_groceryDataSetTableAdapters.tbl_userTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbluserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sales_inventory_system_for_groceryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDUN
        '
        Me.txtDUN.BackColor = System.Drawing.Color.White
        Me.txtDUN.Enabled = False
        Me.txtDUN.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDUN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDUN.Location = New System.Drawing.Point(1082, 28)
        Me.txtDUN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDUN.Multiline = True
        Me.txtDUN.Name = "txtDUN"
        Me.txtDUN.Size = New System.Drawing.Size(10, 13)
        Me.txtDUN.TabIndex = 165
        Me.txtDUN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDUN.Visible = False
        '
        'cboSTATUS
        '
        Me.cboSTATUS.Enabled = False
        Me.cboSTATUS.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.cboSTATUS.FormattingEnabled = True
        Me.cboSTATUS.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cboSTATUS.Location = New System.Drawing.Point(807, 302)
        Me.cboSTATUS.Name = "cboSTATUS"
        Me.cboSTATUS.Size = New System.Drawing.Size(284, 29)
        Me.cboSTATUS.TabIndex = 164
        '
        'cboUSERTYPE
        '
        Me.cboUSERTYPE.Enabled = False
        Me.cboUSERTYPE.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.cboUSERTYPE.FormattingEnabled = True
        Me.cboUSERTYPE.Items.AddRange(New Object() {"Administrator", "Cashier", "Inventory Clerk"})
        Me.cboUSERTYPE.Location = New System.Drawing.Point(806, 230)
        Me.cboUSERTYPE.Name = "cboUSERTYPE"
        Me.cboUSERTYPE.Size = New System.Drawing.Size(284, 29)
        Me.cboUSERTYPE.TabIndex = 163
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(812, 273)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 23)
        Me.Label9.TabIndex = 161
        Me.Label9.Text = "Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(810, 129)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 23)
        Me.Label6.TabIndex = 159
        Me.Label6.Text = "Login Name"
        '
        'txtACCNAME
        '
        Me.txtACCNAME.BackColor = System.Drawing.Color.White
        Me.txtACCNAME.Enabled = False
        Me.txtACCNAME.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACCNAME.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtACCNAME.Location = New System.Drawing.Point(808, 157)
        Me.txtACCNAME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtACCNAME.Multiline = True
        Me.txtACCNAME.Name = "txtACCNAME"
        Me.txtACCNAME.Size = New System.Drawing.Size(284, 35)
        Me.txtACCNAME.TabIndex = 160
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(122, 303)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 28)
        Me.Label2.TabIndex = 158
        Me.Label2.Text = "User Account"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(810, 201)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 23)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "User-type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(497, 273)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 23)
        Me.Label4.TabIndex = 154
        Me.Label4.Text = "Confirm-Password"
        '
        'txtCONPASS
        '
        Me.txtCONPASS.BackColor = System.Drawing.Color.White
        Me.txtCONPASS.Enabled = False
        Me.txtCONPASS.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCONPASS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCONPASS.Location = New System.Drawing.Point(495, 301)
        Me.txtCONPASS.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCONPASS.Multiline = True
        Me.txtCONPASS.Name = "txtCONPASS"
        Me.txtCONPASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCONPASS.Size = New System.Drawing.Size(280, 35)
        Me.txtCONPASS.TabIndex = 155
        '
        'txtUn
        '
        Me.txtUn.BackColor = System.Drawing.Color.White
        Me.txtUn.Enabled = False
        Me.txtUn.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUn.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUn.Location = New System.Drawing.Point(494, 157)
        Me.txtUn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUn.Multiline = True
        Me.txtUn.Name = "txtUn"
        Me.txtUn.Size = New System.Drawing.Size(280, 35)
        Me.txtUn.TabIndex = 153
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(496, 129)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 23)
        Me.Label7.TabIndex = 152
        Me.Label7.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(497, 201)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 23)
        Me.Label5.TabIndex = 150
        Me.Label5.Text = "Password"
        '
        'txtPW
        '
        Me.txtPW.BackColor = System.Drawing.Color.White
        Me.txtPW.Enabled = False
        Me.txtPW.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPW.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPW.Location = New System.Drawing.Point(495, 229)
        Me.txtPW.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPW.Multiline = True
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.Size = New System.Drawing.Size(280, 35)
        Me.txtPW.TabIndex = 151
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(55, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(385, 44)
        Me.Label3.TabIndex = 149
        Me.Label3.Text = "USER MANAGEMENT"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Panel1.Controls.Add(Me.dgvUser)
        Me.Panel1.Controls.Add(Me.btnCANCEL)
        Me.Panel1.Controls.Add(Me.btnSAVE)
        Me.Panel1.Controls.Add(Me.btnEDIT)
        Me.Panel1.Controls.Add(Me.btnADD)
        Me.Panel1.Controls.Add(Me.txtSEARCH)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(18, 373)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1130, 366)
        Me.Panel1.TabIndex = 162
        '
        'dgvUser
        '
        Me.dgvUser.AllowUserToAddRows = False
        Me.dgvUser.AllowUserToDeleteRows = False
        Me.dgvUser.AutoGenerateColumns = False
        Me.dgvUser.BackgroundColor = System.Drawing.Color.White
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.LoginnameDataGridViewTextBoxColumn, Me.UsertypeDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.dgvUser.DataSource = Me.TbluserBindingSource
        Me.dgvUser.Location = New System.Drawing.Point(161, 67)
        Me.dgvUser.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.ReadOnly = True
        Me.dgvUser.RowHeadersWidth = 51
        Me.dgvUser.Size = New System.Drawing.Size(942, 267)
        Me.dgvUser.TabIndex = 98
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsernameDataGridViewTextBoxColumn.Width = 125
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        Me.PasswordDataGridViewTextBoxColumn.Width = 125
        '
        'LoginnameDataGridViewTextBoxColumn
        '
        Me.LoginnameDataGridViewTextBoxColumn.DataPropertyName = "loginname"
        Me.LoginnameDataGridViewTextBoxColumn.HeaderText = "loginname"
        Me.LoginnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LoginnameDataGridViewTextBoxColumn.Name = "LoginnameDataGridViewTextBoxColumn"
        Me.LoginnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LoginnameDataGridViewTextBoxColumn.Width = 125
        '
        'UsertypeDataGridViewTextBoxColumn
        '
        Me.UsertypeDataGridViewTextBoxColumn.DataPropertyName = "usertype"
        Me.UsertypeDataGridViewTextBoxColumn.HeaderText = "usertype"
        Me.UsertypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsertypeDataGridViewTextBoxColumn.Name = "UsertypeDataGridViewTextBoxColumn"
        Me.UsertypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsertypeDataGridViewTextBoxColumn.Width = 125
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusDataGridViewTextBoxColumn.Width = 125
        '
        'TbluserBindingSource
        '
        Me.TbluserBindingSource.DataMember = "tbl_user"
        Me.TbluserBindingSource.DataSource = Me.Sales_inventory_system_for_groceryDataSet
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
        Me.btnCANCEL.Location = New System.Drawing.Point(19, 287)
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
        Me.btnSAVE.Location = New System.Drawing.Point(18, 215)
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
        Me.btnEDIT.Location = New System.Drawing.Point(19, 141)
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
        Me.btnADD.Location = New System.Drawing.Point(20, 67)
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
        Me.Label8.Location = New System.Drawing.Point(663, 27)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 23)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "Search Record"
        '
        'Tbl_userTableAdapter
        '
        Me.Tbl_userTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sales_and_Inventory_System_for_Grocery.My.Resources.Resources._8ce8grcfqj4gaqq4sg28jgp5b6_1f286afea8ee1f62529d168e0cbd00c92
        Me.PictureBox1.Location = New System.Drawing.Point(129, 156)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 157
        Me.PictureBox1.TabStop = False
        '
        'ucUSERACCOUNT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Controls.Add(Me.txtDUN)
        Me.Controls.Add(Me.cboSTATUS)
        Me.Controls.Add(Me.cboUSERTYPE)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtACCNAME)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCONPASS)
        Me.Controls.Add(Me.txtUn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ucUSERACCOUNT"
        Me.Size = New System.Drawing.Size(1167, 766)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbluserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sales_inventory_system_for_groceryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDUN As TextBox
    Friend WithEvents cboSTATUS As ComboBox
    Friend WithEvents cboUSERTYPE As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtACCNAME As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCONPASS As TextBox
    Friend WithEvents txtUn As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPW As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvUser As DataGridView
    Friend WithEvents btnCANCEL As Button
    Friend WithEvents btnSAVE As Button
    Friend WithEvents btnEDIT As Button
    Friend WithEvents btnADD As Button
    Friend WithEvents txtSEARCH As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoginnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsertypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TbluserBindingSource As BindingSource
    Friend WithEvents Sales_inventory_system_for_groceryDataSet As sales_inventory_system_for_groceryDataSet
    Friend WithEvents Tbl_userTableAdapter As sales_inventory_system_for_groceryDataSetTableAdapters.tbl_userTableAdapter
End Class
