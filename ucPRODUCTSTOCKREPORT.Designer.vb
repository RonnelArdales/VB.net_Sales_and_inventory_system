<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPRODUCTSTOCKREPORT
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
        Me.tbl_productstockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sales_inventory_system_for_groceryDataSet = New Sales_and_Inventory_System_for_Grocery.sales_inventory_system_for_groceryDataSet()
        Me.rptPRODUCTSTOCK = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BTNDATE = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtEnd = New System.Windows.Forms.DateTimePicker()
        Me.DtStart = New System.Windows.Forms.DateTimePicker()
        Me.tbl_productstockTableAdapter = New Sales_and_Inventory_System_for_Grocery.sales_inventory_system_for_groceryDataSetTableAdapters.tbl_productstockTableAdapter()
        Me.btnclear = New System.Windows.Forms.Button()
        CType(Me.tbl_productstockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sales_inventory_system_for_groceryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbl_productstockBindingSource
        '
        Me.tbl_productstockBindingSource.DataMember = "tbl_productstock"
        Me.tbl_productstockBindingSource.DataSource = Me.sales_inventory_system_for_groceryDataSet
        '
        'sales_inventory_system_for_groceryDataSet
        '
        Me.sales_inventory_system_for_groceryDataSet.DataSetName = "sales_inventory_system_for_groceryDataSet"
        Me.sales_inventory_system_for_groceryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rptPRODUCTSTOCK
        '
        Me.rptPRODUCTSTOCK.DocumentMapWidth = 85
        ReportDataSource1.Name = "DataSet1_PRODUCTSTOCK"
        ReportDataSource1.Value = Me.tbl_productstockBindingSource
        Me.rptPRODUCTSTOCK.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptPRODUCTSTOCK.LocalReport.ReportEmbeddedResource = "Sales_and_Inventory_System_for_Grocery.rptPRODUCTSTOCK.rdlc"
        Me.rptPRODUCTSTOCK.Location = New System.Drawing.Point(20, 85)
        Me.rptPRODUCTSTOCK.Name = "rptPRODUCTSTOCK"
        Me.rptPRODUCTSTOCK.ServerReport.BearerToken = Nothing
        Me.rptPRODUCTSTOCK.Size = New System.Drawing.Size(900, 610)
        Me.rptPRODUCTSTOCK.TabIndex = 2
        '
        'BTNDATE
        '
        Me.BTNDATE.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BTNDATE.Font = New System.Drawing.Font("Century Gothic", 10.2!)
        Me.BTNDATE.ForeColor = System.Drawing.Color.White
        Me.BTNDATE.Location = New System.Drawing.Point(705, 24)
        Me.BTNDATE.Name = "BTNDATE"
        Me.BTNDATE.Size = New System.Drawing.Size(87, 38)
        Me.BTNDATE.TabIndex = 11
        Me.BTNDATE.Text = "Filter"
        Me.BTNDATE.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(388, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "End Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(41, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Start Date"
        '
        'DtEnd
        '
        Me.DtEnd.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtEnd.CustomFormat = "MM/dd/yyyy"
        Me.DtEnd.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold)
        Me.DtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtEnd.Location = New System.Drawing.Point(484, 31)
        Me.DtEnd.Name = "DtEnd"
        Me.DtEnd.Size = New System.Drawing.Size(200, 28)
        Me.DtEnd.TabIndex = 8
        '
        'DtStart
        '
        Me.DtStart.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtStart.CustomFormat = "MM/dd/yyyy"
        Me.DtStart.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold)
        Me.DtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtStart.Location = New System.Drawing.Point(138, 31)
        Me.DtStart.Name = "DtStart"
        Me.DtStart.Size = New System.Drawing.Size(200, 28)
        Me.DtStart.TabIndex = 7
        '
        'tbl_productstockTableAdapter
        '
        Me.tbl_productstockTableAdapter.ClearBeforeFill = True
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnclear.Font = New System.Drawing.Font("Century Gothic", 10.2!)
        Me.btnclear.ForeColor = System.Drawing.Color.White
        Me.btnclear.Location = New System.Drawing.Point(811, 24)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(87, 38)
        Me.btnclear.TabIndex = 12
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'ucPRODUCTSTOCKREPORT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.BTNDATE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DtEnd)
        Me.Controls.Add(Me.DtStart)
        Me.Controls.Add(Me.rptPRODUCTSTOCK)
        Me.Name = "ucPRODUCTSTOCKREPORT"
        Me.Size = New System.Drawing.Size(940, 716)
        CType(Me.tbl_productstockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sales_inventory_system_for_groceryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rptPRODUCTSTOCK As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_productstockBindingSource As BindingSource
    Friend WithEvents sales_inventory_system_for_groceryDataSet As sales_inventory_system_for_groceryDataSet
    Friend WithEvents tbl_productstockTableAdapter As sales_inventory_system_for_groceryDataSetTableAdapters.tbl_productstockTableAdapter
    Friend WithEvents BTNDATE As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DtEnd As DateTimePicker
    Friend WithEvents DtStart As DateTimePicker
    Friend WithEvents btnclear As Button
End Class
