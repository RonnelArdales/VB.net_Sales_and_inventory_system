<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPROFILEREPORT
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tbl_profileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sales_inventory_system_for_groceryDataSet = New Sales_and_Inventory_System_for_Grocery.sales_inventory_system_for_groceryDataSet()
        Me.rptPROFILE = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtFNAME = New System.Windows.Forms.TextBox()
        Me.BTNFILTERFNAME = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLNAME = New System.Windows.Forms.TextBox()
        Me.btnFILTERLNAME = New System.Windows.Forms.Button()
        Me.tbl_profileTableAdapter = New Sales_and_Inventory_System_for_Grocery.sales_inventory_system_for_groceryDataSetTableAdapters.tbl_profileTableAdapter()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.tbl_profileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sales_inventory_system_for_groceryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbl_profileBindingSource
        '
        Me.tbl_profileBindingSource.DataMember = "tbl_profile"
        Me.tbl_profileBindingSource.DataSource = Me.sales_inventory_system_for_groceryDataSet
        '
        'sales_inventory_system_for_groceryDataSet
        '
        Me.sales_inventory_system_for_groceryDataSet.DataSetName = "sales_inventory_system_for_groceryDataSet"
        Me.sales_inventory_system_for_groceryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rptPROFILE
        '
        ReportDataSource1.Name = "DataSet1_PROFILE"
        ReportDataSource1.Value = Me.tbl_profileBindingSource
        Me.rptPROFILE.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptPROFILE.LocalReport.ReportEmbeddedResource = "Sales_and_Inventory_System_for_Grocery.rptPROFILE.rdlc"
        Me.rptPROFILE.Location = New System.Drawing.Point(20, 85)
        Me.rptPROFILE.Name = "rptPROFILE"
        Me.rptPROFILE.ServerReport.BearerToken = Nothing
        Me.rptPROFILE.Size = New System.Drawing.Size(900, 610)
        Me.rptPROFILE.TabIndex = 2
        '
        'txtFNAME
        '
        Me.txtFNAME.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.txtFNAME.Location = New System.Drawing.Point(151, 34)
        Me.txtFNAME.Name = "txtFNAME"
        Me.txtFNAME.Size = New System.Drawing.Size(151, 30)
        Me.txtFNAME.TabIndex = 3
        '
        'BTNFILTERFNAME
        '
        Me.BTNFILTERFNAME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BTNFILTERFNAME.Font = New System.Drawing.Font("Century Gothic", 10.2!)
        Me.BTNFILTERFNAME.ForeColor = System.Drawing.Color.White
        Me.BTNFILTERFNAME.Location = New System.Drawing.Point(309, 31)
        Me.BTNFILTERFNAME.Name = "BTNFILTERFNAME"
        Me.BTNFILTERFNAME.Size = New System.Drawing.Size(87, 38)
        Me.BTNFILTERFNAME.TabIndex = 4
        Me.BTNFILTERFNAME.Text = "Filter"
        Me.BTNFILTERFNAME.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(45, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(432, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Last Name"
        '
        'txtLNAME
        '
        Me.txtLNAME.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.txtLNAME.Location = New System.Drawing.Point(538, 35)
        Me.txtLNAME.Name = "txtLNAME"
        Me.txtLNAME.Size = New System.Drawing.Size(151, 30)
        Me.txtLNAME.TabIndex = 6
        '
        'btnFILTERLNAME
        '
        Me.btnFILTERLNAME.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnFILTERLNAME.Font = New System.Drawing.Font("Century Gothic", 10.2!)
        Me.btnFILTERLNAME.ForeColor = System.Drawing.Color.White
        Me.btnFILTERLNAME.Location = New System.Drawing.Point(695, 30)
        Me.btnFILTERLNAME.Name = "btnFILTERLNAME"
        Me.btnFILTERLNAME.Size = New System.Drawing.Size(87, 38)
        Me.btnFILTERLNAME.TabIndex = 8
        Me.btnFILTERLNAME.Text = "Filter"
        Me.btnFILTERLNAME.UseVisualStyleBackColor = False
        '
        'tbl_profileTableAdapter
        '
        Me.tbl_profileTableAdapter.ClearBeforeFill = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 10.2!)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(827, 30)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 38)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'ucPROFILEREPORT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnFILTERLNAME)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLNAME)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNFILTERFNAME)
        Me.Controls.Add(Me.txtFNAME)
        Me.Controls.Add(Me.rptPROFILE)
        Me.Name = "ucPROFILEREPORT"
        Me.Size = New System.Drawing.Size(940, 716)
        CType(Me.tbl_profileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sales_inventory_system_for_groceryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rptPROFILE As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txtFNAME As TextBox
    Friend WithEvents BTNFILTERFNAME As Button
    Friend WithEvents tbl_profileBindingSource As BindingSource
    Friend WithEvents sales_inventory_system_for_groceryDataSet As sales_inventory_system_for_groceryDataSet
    Friend WithEvents tbl_profileTableAdapter As sales_inventory_system_for_groceryDataSetTableAdapters.tbl_profileTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLNAME As TextBox
    Friend WithEvents btnFILTERLNAME As Button
    Friend WithEvents btnClear As Button
End Class
