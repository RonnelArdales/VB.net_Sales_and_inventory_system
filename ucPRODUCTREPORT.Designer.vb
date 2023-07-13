<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPRODUCTREPORT
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
        Me.tbl_productBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sales_inventory_system_for_groceryDataSet = New Sales_and_Inventory_System_for_Grocery.sales_inventory_system_for_groceryDataSet()
        Me.rptPRODUCT = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbl_productTableAdapter = New Sales_and_Inventory_System_for_Grocery.sales_inventory_system_for_groceryDataSetTableAdapters.tbl_productTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboCATEGORY = New System.Windows.Forms.ComboBox()
        Me.btnCATEGORY = New System.Windows.Forms.Button()
        Me.btnCLEAR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboBRAND = New System.Windows.Forms.ComboBox()
        Me.btnBRAND = New System.Windows.Forms.Button()
        CType(Me.tbl_productBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sales_inventory_system_for_groceryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbl_productBindingSource
        '
        Me.tbl_productBindingSource.DataMember = "tbl_product"
        Me.tbl_productBindingSource.DataSource = Me.sales_inventory_system_for_groceryDataSet
        '
        'sales_inventory_system_for_groceryDataSet
        '
        Me.sales_inventory_system_for_groceryDataSet.DataSetName = "sales_inventory_system_for_groceryDataSet"
        Me.sales_inventory_system_for_groceryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rptPRODUCT
        '
        ReportDataSource1.Name = "DataSet1_PRODUCT"
        ReportDataSource1.Value = Me.tbl_productBindingSource
        Me.rptPRODUCT.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptPRODUCT.LocalReport.ReportEmbeddedResource = "Sales_and_Inventory_System_for_Grocery.rptPRODUCT.rdlc"
        Me.rptPRODUCT.Location = New System.Drawing.Point(20, 86)
        Me.rptPRODUCT.Name = "rptPRODUCT"
        Me.rptPRODUCT.ServerReport.BearerToken = Nothing
        Me.rptPRODUCT.Size = New System.Drawing.Size(900, 610)
        Me.rptPRODUCT.TabIndex = 1
        '
        'tbl_productTableAdapter
        '
        Me.tbl_productTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(439, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Category"
        '
        'cboCATEGORY
        '
        Me.cboCATEGORY.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.cboCATEGORY.FormattingEnabled = True
        Me.cboCATEGORY.Location = New System.Drawing.Point(533, 32)
        Me.cboCATEGORY.Name = "cboCATEGORY"
        Me.cboCATEGORY.Size = New System.Drawing.Size(146, 29)
        Me.cboCATEGORY.TabIndex = 13
        '
        'btnCATEGORY
        '
        Me.btnCATEGORY.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnCATEGORY.Font = New System.Drawing.Font("Century Gothic", 10.2!)
        Me.btnCATEGORY.ForeColor = System.Drawing.Color.White
        Me.btnCATEGORY.Location = New System.Drawing.Point(685, 28)
        Me.btnCATEGORY.Name = "btnCATEGORY"
        Me.btnCATEGORY.Size = New System.Drawing.Size(87, 38)
        Me.btnCATEGORY.TabIndex = 12
        Me.btnCATEGORY.Text = "Filter"
        Me.btnCATEGORY.UseVisualStyleBackColor = False
        '
        'btnCLEAR
        '
        Me.btnCLEAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnCLEAR.Font = New System.Drawing.Font("Century Gothic", 10.2!)
        Me.btnCLEAR.ForeColor = System.Drawing.Color.White
        Me.btnCLEAR.Location = New System.Drawing.Point(791, 28)
        Me.btnCLEAR.Name = "btnCLEAR"
        Me.btnCLEAR.Size = New System.Drawing.Size(87, 38)
        Me.btnCLEAR.TabIndex = 11
        Me.btnCLEAR.Text = "Clear"
        Me.btnCLEAR.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(62, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Brand"
        '
        'cboBRAND
        '
        Me.cboBRAND.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.cboBRAND.FormattingEnabled = True
        Me.cboBRAND.Location = New System.Drawing.Point(127, 32)
        Me.cboBRAND.Name = "cboBRAND"
        Me.cboBRAND.Size = New System.Drawing.Size(146, 29)
        Me.cboBRAND.TabIndex = 9
        '
        'btnBRAND
        '
        Me.btnBRAND.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnBRAND.Font = New System.Drawing.Font("Century Gothic", 10.2!)
        Me.btnBRAND.ForeColor = System.Drawing.Color.White
        Me.btnBRAND.Location = New System.Drawing.Point(280, 28)
        Me.btnBRAND.Name = "btnBRAND"
        Me.btnBRAND.Size = New System.Drawing.Size(87, 38)
        Me.btnBRAND.TabIndex = 8
        Me.btnBRAND.Text = "Filter"
        Me.btnBRAND.UseVisualStyleBackColor = False
        '
        'ucPRODUCTREPORT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboCATEGORY)
        Me.Controls.Add(Me.btnCATEGORY)
        Me.Controls.Add(Me.btnCLEAR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboBRAND)
        Me.Controls.Add(Me.btnBRAND)
        Me.Controls.Add(Me.rptPRODUCT)
        Me.Name = "ucPRODUCTREPORT"
        Me.Size = New System.Drawing.Size(940, 716)
        CType(Me.tbl_productBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sales_inventory_system_for_groceryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rptPRODUCT As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_productBindingSource As BindingSource
    Friend WithEvents sales_inventory_system_for_groceryDataSet As sales_inventory_system_for_groceryDataSet
    Friend WithEvents tbl_productTableAdapter As sales_inventory_system_for_groceryDataSetTableAdapters.tbl_productTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents cboCATEGORY As ComboBox
    Friend WithEvents btnCATEGORY As Button
    Friend WithEvents btnCLEAR As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboBRAND As ComboBox
    Friend WithEvents btnBRAND As Button
End Class
