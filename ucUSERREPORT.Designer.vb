<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucUSERREPORT
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tbl_userBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sales_inventory_system_for_groceryDataSet = New Sales_and_Inventory_System_for_Grocery.sales_inventory_system_for_groceryDataSet()
        Me.rptUSER = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnFILTERUSERTYPE = New System.Windows.Forms.Button()
        Me.cboUSERTYPE = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCLEAR = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboSTATUS = New System.Windows.Forms.ComboBox()
        Me.btnFILTERSTATUS = New System.Windows.Forms.Button()
        Me.tbl_userTableAdapter = New Sales_and_Inventory_System_for_Grocery.sales_inventory_system_for_groceryDataSetTableAdapters.tbl_userTableAdapter()
        CType(Me.tbl_userBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sales_inventory_system_for_groceryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbl_userBindingSource
        '
        Me.tbl_userBindingSource.DataMember = "tbl_user"
        Me.tbl_userBindingSource.DataSource = Me.sales_inventory_system_for_groceryDataSet
        '
        'sales_inventory_system_for_groceryDataSet
        '
        Me.sales_inventory_system_for_groceryDataSet.DataSetName = "sales_inventory_system_for_groceryDataSet"
        Me.sales_inventory_system_for_groceryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rptUSER
        '
        ReportDataSource3.Name = "DataSet1_USERACCOUNT"
        ReportDataSource3.Value = Me.tbl_userBindingSource
        Me.rptUSER.LocalReport.DataSources.Add(ReportDataSource3)
        Me.rptUSER.LocalReport.ReportEmbeddedResource = "Sales_and_Inventory_System_for_Grocery.rptUSERACC.rdlc"
        Me.rptUSER.Location = New System.Drawing.Point(18, 86)
        Me.rptUSER.Name = "rptUSER"
        Me.rptUSER.ServerReport.BearerToken = Nothing
        Me.rptUSER.Size = New System.Drawing.Size(900, 610)
        Me.rptUSER.TabIndex = 0
        '
        'btnFILTERUSERTYPE
        '
        Me.btnFILTERUSERTYPE.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnFILTERUSERTYPE.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFILTERUSERTYPE.ForeColor = System.Drawing.Color.White
        Me.btnFILTERUSERTYPE.Location = New System.Drawing.Point(299, 32)
        Me.btnFILTERUSERTYPE.Name = "btnFILTERUSERTYPE"
        Me.btnFILTERUSERTYPE.Size = New System.Drawing.Size(87, 38)
        Me.btnFILTERUSERTYPE.TabIndex = 1
        Me.btnFILTERUSERTYPE.Text = "Filter"
        Me.btnFILTERUSERTYPE.UseVisualStyleBackColor = False
        '
        'cboUSERTYPE
        '
        Me.cboUSERTYPE.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUSERTYPE.FormattingEnabled = True
        Me.cboUSERTYPE.Items.AddRange(New Object() {"Administrator", "Inventory Clerk", "Cashier"})
        Me.cboUSERTYPE.Location = New System.Drawing.Point(146, 34)
        Me.cboUSERTYPE.Name = "cboUSERTYPE"
        Me.cboUSERTYPE.Size = New System.Drawing.Size(146, 29)
        Me.cboUSERTYPE.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(59, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usertype"
        '
        'btnCLEAR
        '
        Me.btnCLEAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnCLEAR.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCLEAR.ForeColor = System.Drawing.Color.White
        Me.btnCLEAR.Location = New System.Drawing.Point(788, 32)
        Me.btnCLEAR.Name = "btnCLEAR"
        Me.btnCLEAR.Size = New System.Drawing.Size(87, 38)
        Me.btnCLEAR.TabIndex = 4
        Me.btnCLEAR.Text = "Clear"
        Me.btnCLEAR.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(431, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Status"
        '
        'cboSTATUS
        '
        Me.cboSTATUS.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSTATUS.FormattingEnabled = True
        Me.cboSTATUS.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cboSTATUS.Location = New System.Drawing.Point(495, 35)
        Me.cboSTATUS.Name = "cboSTATUS"
        Me.cboSTATUS.Size = New System.Drawing.Size(146, 29)
        Me.cboSTATUS.TabIndex = 6
        '
        'btnFILTERSTATUS
        '
        Me.btnFILTERSTATUS.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnFILTERSTATUS.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFILTERSTATUS.ForeColor = System.Drawing.Color.White
        Me.btnFILTERSTATUS.Location = New System.Drawing.Point(648, 32)
        Me.btnFILTERSTATUS.Name = "btnFILTERSTATUS"
        Me.btnFILTERSTATUS.Size = New System.Drawing.Size(87, 38)
        Me.btnFILTERSTATUS.TabIndex = 5
        Me.btnFILTERSTATUS.Text = "Filter"
        Me.btnFILTERSTATUS.UseVisualStyleBackColor = False
        '
        'tbl_userTableAdapter
        '
        Me.tbl_userTableAdapter.ClearBeforeFill = True
        '
        'ucUSERREPORT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboSTATUS)
        Me.Controls.Add(Me.btnFILTERSTATUS)
        Me.Controls.Add(Me.btnCLEAR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboUSERTYPE)
        Me.Controls.Add(Me.btnFILTERUSERTYPE)
        Me.Controls.Add(Me.rptUSER)
        Me.Name = "ucUSERREPORT"
        Me.Size = New System.Drawing.Size(940, 716)
        CType(Me.tbl_userBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sales_inventory_system_for_groceryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rptUSER As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_userBindingSource As BindingSource
    Friend WithEvents sales_inventory_system_for_groceryDataSet As sales_inventory_system_for_groceryDataSet
    Friend WithEvents tbl_userTableAdapter As sales_inventory_system_for_groceryDataSetTableAdapters.tbl_userTableAdapter
    Friend WithEvents btnFILTERUSERTYPE As Button
    Friend WithEvents cboUSERTYPE As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCLEAR As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cboSTATUS As ComboBox
    Friend WithEvents btnFILTERSTATUS As Button
End Class
