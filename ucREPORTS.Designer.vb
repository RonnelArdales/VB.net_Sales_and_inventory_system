<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucREPORTS
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalesTransaction = New System.Windows.Forms.Button()
        Me.btnCustomerProfile = New System.Windows.Forms.Button()
        Me.btnProductStock = New System.Windows.Forms.Button()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.btnActivityLog = New System.Windows.Forms.Button()
        Me.btnUserAccount = New System.Windows.Forms.Button()
        Me.pnlMAINREPORT = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnSalesTransaction)
        Me.Panel1.Controls.Add(Me.btnCustomerProfile)
        Me.Panel1.Controls.Add(Me.btnProductStock)
        Me.Panel1.Controls.Add(Me.btnProduct)
        Me.Panel1.Controls.Add(Me.btnActivityLog)
        Me.Panel1.Controls.Add(Me.btnUserAccount)
        Me.Panel1.Location = New System.Drawing.Point(20, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(168, 716)
        Me.Panel1.TabIndex = 0
        '
        'btnSalesTransaction
        '
        Me.btnSalesTransaction.Enabled = False
        Me.btnSalesTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalesTransaction.Location = New System.Drawing.Point(18, 490)
        Me.btnSalesTransaction.Name = "btnSalesTransaction"
        Me.btnSalesTransaction.Size = New System.Drawing.Size(130, 61)
        Me.btnSalesTransaction.TabIndex = 6
        Me.btnSalesTransaction.Text = "Sales Transaction"
        Me.btnSalesTransaction.UseVisualStyleBackColor = True
        '
        'btnCustomerProfile
        '
        Me.btnCustomerProfile.Enabled = False
        Me.btnCustomerProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerProfile.Location = New System.Drawing.Point(18, 400)
        Me.btnCustomerProfile.Name = "btnCustomerProfile"
        Me.btnCustomerProfile.Size = New System.Drawing.Size(130, 61)
        Me.btnCustomerProfile.TabIndex = 5
        Me.btnCustomerProfile.Text = "Customer Profile"
        Me.btnCustomerProfile.UseVisualStyleBackColor = True
        '
        'btnProductStock
        '
        Me.btnProductStock.Enabled = False
        Me.btnProductStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductStock.Location = New System.Drawing.Point(18, 315)
        Me.btnProductStock.Name = "btnProductStock"
        Me.btnProductStock.Size = New System.Drawing.Size(130, 61)
        Me.btnProductStock.TabIndex = 4
        Me.btnProductStock.Text = "Product Stock"
        Me.btnProductStock.UseVisualStyleBackColor = True
        '
        'btnProduct
        '
        Me.btnProduct.Enabled = False
        Me.btnProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct.Location = New System.Drawing.Point(18, 231)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(130, 61)
        Me.btnProduct.TabIndex = 3
        Me.btnProduct.Text = "Product"
        Me.btnProduct.UseVisualStyleBackColor = True
        '
        'btnActivityLog
        '
        Me.btnActivityLog.Enabled = False
        Me.btnActivityLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActivityLog.Location = New System.Drawing.Point(18, 150)
        Me.btnActivityLog.Name = "btnActivityLog"
        Me.btnActivityLog.Size = New System.Drawing.Size(130, 61)
        Me.btnActivityLog.TabIndex = 2
        Me.btnActivityLog.Text = "Activity Log"
        Me.btnActivityLog.UseVisualStyleBackColor = True
        '
        'btnUserAccount
        '
        Me.btnUserAccount.Enabled = False
        Me.btnUserAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserAccount.Location = New System.Drawing.Point(18, 68)
        Me.btnUserAccount.Name = "btnUserAccount"
        Me.btnUserAccount.Size = New System.Drawing.Size(130, 61)
        Me.btnUserAccount.TabIndex = 1
        Me.btnUserAccount.Text = "User Account"
        Me.btnUserAccount.UseVisualStyleBackColor = True
        '
        'pnlMAINREPORT
        '
        Me.pnlMAINREPORT.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.pnlMAINREPORT.Location = New System.Drawing.Point(205, 25)
        Me.pnlMAINREPORT.Name = "pnlMAINREPORT"
        Me.pnlMAINREPORT.Size = New System.Drawing.Size(940, 716)
        Me.pnlMAINREPORT.TabIndex = 1
        '
        'ucREPORTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Controls.Add(Me.pnlMAINREPORT)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ucREPORTS"
        Me.Size = New System.Drawing.Size(1167, 766)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnUserAccount As Button
    Friend WithEvents pnlMAINREPORT As Panel
    Friend WithEvents btnSalesTransaction As Button
    Friend WithEvents btnCustomerProfile As Button
    Friend WithEvents btnProductStock As Button
    Friend WithEvents btnProduct As Button
    Friend WithEvents btnActivityLog As Button
End Class
