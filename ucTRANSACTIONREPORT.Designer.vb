<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTRANSACTIONREPORT
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
        Me.tbl_transactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sales_inventory_system_for_groceryDataSet = New Sales_and_Inventory_System_for_Grocery.sales_inventory_system_for_groceryDataSet()
        Me.rptTRANSACTION = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dtSTART = New System.Windows.Forms.DateTimePicker()
        Me.dtEND = New System.Windows.Forms.DateTimePicker()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.btnDATEFILTER = New System.Windows.Forms.Button()
        Me.btnFNAMEFILTER = New System.Windows.Forms.Button()
        Me.btnCLEAR = New System.Windows.Forms.Button()
        Me.tbl_transactionTableAdapter = New Sales_and_Inventory_System_for_Grocery.sales_inventory_system_for_groceryDataSetTableAdapters.tbl_transactionTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.tbl_transactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sales_inventory_system_for_groceryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbl_transactionBindingSource
        '
        Me.tbl_transactionBindingSource.DataMember = "tbl_transaction"
        Me.tbl_transactionBindingSource.DataSource = Me.sales_inventory_system_for_groceryDataSet
        '
        'sales_inventory_system_for_groceryDataSet
        '
        Me.sales_inventory_system_for_groceryDataSet.DataSetName = "sales_inventory_system_for_groceryDataSet"
        Me.sales_inventory_system_for_groceryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rptTRANSACTION
        '
        Me.rptTRANSACTION.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1_TRANSACTION"
        ReportDataSource1.Value = Me.tbl_transactionBindingSource
        Me.rptTRANSACTION.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptTRANSACTION.LocalReport.ReportEmbeddedResource = "Sales_and_Inventory_System_for_Grocery.rptTRANSACTION.rdlc"
        Me.rptTRANSACTION.Location = New System.Drawing.Point(20, 91)
        Me.rptTRANSACTION.Name = "rptTRANSACTION"
        Me.rptTRANSACTION.ServerReport.BearerToken = Nothing
        Me.rptTRANSACTION.Size = New System.Drawing.Size(900, 610)
        Me.rptTRANSACTION.TabIndex = 1
        '
        'dtSTART
        '
        Me.dtSTART.CustomFormat = "MM/dd/yyyy"
        Me.dtSTART.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.dtSTART.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtSTART.Location = New System.Drawing.Point(27, 40)
        Me.dtSTART.Name = "dtSTART"
        Me.dtSTART.Size = New System.Drawing.Size(200, 30)
        Me.dtSTART.TabIndex = 2
        '
        'dtEND
        '
        Me.dtEND.CustomFormat = "MM/dd/yyyy"
        Me.dtEND.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.dtEND.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtEND.Location = New System.Drawing.Point(257, 40)
        Me.dtEND.Name = "dtEND"
        Me.dtEND.Size = New System.Drawing.Size(200, 30)
        Me.dtEND.TabIndex = 3
        '
        'txtFullname
        '
        Me.txtFullname.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.txtFullname.Location = New System.Drawing.Point(597, 40)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(130, 30)
        Me.txtFullname.TabIndex = 4
        '
        'btnDATEFILTER
        '
        Me.btnDATEFILTER.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnDATEFILTER.Font = New System.Drawing.Font("Century Gothic", 10.2!)
        Me.btnDATEFILTER.ForeColor = System.Drawing.Color.White
        Me.btnDATEFILTER.Location = New System.Drawing.Point(471, 37)
        Me.btnDATEFILTER.Name = "btnDATEFILTER"
        Me.btnDATEFILTER.Size = New System.Drawing.Size(87, 38)
        Me.btnDATEFILTER.TabIndex = 5
        Me.btnDATEFILTER.Text = "Filter"
        Me.btnDATEFILTER.UseVisualStyleBackColor = False
        '
        'btnFNAMEFILTER
        '
        Me.btnFNAMEFILTER.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnFNAMEFILTER.Font = New System.Drawing.Font("Century Gothic", 10.2!)
        Me.btnFNAMEFILTER.ForeColor = System.Drawing.Color.White
        Me.btnFNAMEFILTER.Location = New System.Drawing.Point(739, 35)
        Me.btnFNAMEFILTER.Name = "btnFNAMEFILTER"
        Me.btnFNAMEFILTER.Size = New System.Drawing.Size(87, 38)
        Me.btnFNAMEFILTER.TabIndex = 6
        Me.btnFNAMEFILTER.Text = "Filter"
        Me.btnFNAMEFILTER.UseVisualStyleBackColor = False
        '
        'btnCLEAR
        '
        Me.btnCLEAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnCLEAR.Font = New System.Drawing.Font("Century Gothic", 10.2!)
        Me.btnCLEAR.ForeColor = System.Drawing.Color.White
        Me.btnCLEAR.Location = New System.Drawing.Point(834, 34)
        Me.btnCLEAR.Name = "btnCLEAR"
        Me.btnCLEAR.Size = New System.Drawing.Size(87, 38)
        Me.btnCLEAR.TabIndex = 7
        Me.btnCLEAR.Text = "Clear"
        Me.btnCLEAR.UseVisualStyleBackColor = False
        '
        'tbl_transactionTableAdapter
        '
        Me.tbl_transactionTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(76, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Start date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(317, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "End date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(621, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Fullname"
        '
        'ucTRANSACTIONREPORT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCLEAR)
        Me.Controls.Add(Me.btnFNAMEFILTER)
        Me.Controls.Add(Me.btnDATEFILTER)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.dtEND)
        Me.Controls.Add(Me.dtSTART)
        Me.Controls.Add(Me.rptTRANSACTION)
        Me.Name = "ucTRANSACTIONREPORT"
        Me.Size = New System.Drawing.Size(940, 716)
        CType(Me.tbl_transactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sales_inventory_system_for_groceryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rptTRANSACTION As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_transactionBindingSource As BindingSource
    Friend WithEvents sales_inventory_system_for_groceryDataSet As sales_inventory_system_for_groceryDataSet
    Friend WithEvents tbl_transactionTableAdapter As sales_inventory_system_for_groceryDataSetTableAdapters.tbl_transactionTableAdapter
    Friend WithEvents dtSTART As DateTimePicker
    Friend WithEvents dtEND As DateTimePicker
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents btnDATEFILTER As Button
    Friend WithEvents btnFNAMEFILTER As Button
    Friend WithEvents btnCLEAR As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
