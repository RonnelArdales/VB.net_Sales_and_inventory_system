<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucACTIVITYLOGREPORT
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tbl_actlogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sales_inventory_system_for_groceryDataSet = New Sales_and_Inventory_System_for_Grocery.sales_inventory_system_for_groceryDataSet()
        Me.rptACTIVITY = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DtStart = New System.Windows.Forms.DateTimePicker()
        Me.DtEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNDATE = New System.Windows.Forms.Button()
        Me.tbl_actlogTableAdapter = New Sales_and_Inventory_System_for_Grocery.sales_inventory_system_for_groceryDataSetTableAdapters.tbl_actlogTableAdapter()
        Me.btnclear = New System.Windows.Forms.Button()
        CType(Me.tbl_actlogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sales_inventory_system_for_groceryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbl_actlogBindingSource
        '
        Me.tbl_actlogBindingSource.DataMember = "tbl_actlog"
        Me.tbl_actlogBindingSource.DataSource = Me.sales_inventory_system_for_groceryDataSet
        '
        'sales_inventory_system_for_groceryDataSet
        '
        Me.sales_inventory_system_for_groceryDataSet.DataSetName = "sales_inventory_system_for_groceryDataSet"
        Me.sales_inventory_system_for_groceryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rptACTIVITY
        '
        ReportDataSource2.Name = "DataSet1_ACTIVITYLOG"
        ReportDataSource2.Value = Me.tbl_actlogBindingSource
        Me.rptACTIVITY.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rptACTIVITY.LocalReport.ReportEmbeddedResource = "Sales_and_Inventory_System_for_Grocery.rptACTIVITYLOG.rdlc"
        Me.rptACTIVITY.Location = New System.Drawing.Point(20, 85)
        Me.rptACTIVITY.Name = "rptACTIVITY"
        Me.rptACTIVITY.ServerReport.BearerToken = Nothing
        Me.rptACTIVITY.Size = New System.Drawing.Size(900, 610)
        Me.rptACTIVITY.TabIndex = 1
        '
        'DtStart
        '
        Me.DtStart.CustomFormat = "MM/dd/yyyy"
        Me.DtStart.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold)
        Me.DtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtStart.Location = New System.Drawing.Point(135, 29)
        Me.DtStart.Name = "DtStart"
        Me.DtStart.Size = New System.Drawing.Size(200, 28)
        Me.DtStart.TabIndex = 2
        '
        'DtEnd
        '
        Me.DtEnd.CustomFormat = "MM/dd/yyyy"
        Me.DtEnd.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold)
        Me.DtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtEnd.Location = New System.Drawing.Point(464, 30)
        Me.DtEnd.Name = "DtEnd"
        Me.DtEnd.Size = New System.Drawing.Size(200, 28)
        Me.DtEnd.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(36, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Start Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(371, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "End Date"
        '
        'BTNDATE
        '
        Me.BTNDATE.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BTNDATE.Font = New System.Drawing.Font("Century Gothic", 10.2!)
        Me.BTNDATE.ForeColor = System.Drawing.Color.White
        Me.BTNDATE.Location = New System.Drawing.Point(693, 25)
        Me.BTNDATE.Name = "BTNDATE"
        Me.BTNDATE.Size = New System.Drawing.Size(87, 38)
        Me.BTNDATE.TabIndex = 6
        Me.BTNDATE.Text = "Filter"
        Me.BTNDATE.UseVisualStyleBackColor = False
        '
        'tbl_actlogTableAdapter
        '
        Me.tbl_actlogTableAdapter.ClearBeforeFill = True
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnclear.Font = New System.Drawing.Font("Century Gothic", 10.2!)
        Me.btnclear.ForeColor = System.Drawing.Color.White
        Me.btnclear.Location = New System.Drawing.Point(805, 25)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(87, 38)
        Me.btnclear.TabIndex = 13
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'ucACTIVITYLOGREPORT
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
        Me.Controls.Add(Me.rptACTIVITY)
        Me.Name = "ucACTIVITYLOGREPORT"
        Me.Size = New System.Drawing.Size(940, 716)
        CType(Me.tbl_actlogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sales_inventory_system_for_groceryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rptACTIVITY As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_actlogBindingSource As BindingSource
    Friend WithEvents sales_inventory_system_for_groceryDataSet As sales_inventory_system_for_groceryDataSet
    Friend WithEvents tbl_actlogTableAdapter As sales_inventory_system_for_groceryDataSetTableAdapters.tbl_actlogTableAdapter
    Friend WithEvents DtStart As DateTimePicker
    Friend WithEvents DtEnd As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BTNDATE As Button
    Friend WithEvents btnclear As Button
End Class
