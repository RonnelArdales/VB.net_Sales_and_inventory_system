<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSETTINGS
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnBRAND = New System.Windows.Forms.Button()
        Me.btnPRODUCT = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlSETTINGS = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnBRAND)
        Me.Panel2.Controls.Add(Me.btnPRODUCT)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(26, 21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(203, 716)
        Me.Panel2.TabIndex = 147
        '
        'btnBRAND
        '
        Me.btnBRAND.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnBRAND.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBRAND.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBRAND.ForeColor = System.Drawing.Color.White
        Me.btnBRAND.Location = New System.Drawing.Point(26, 207)
        Me.btnBRAND.Name = "btnBRAND"
        Me.btnBRAND.Size = New System.Drawing.Size(140, 61)
        Me.btnBRAND.TabIndex = 148
        Me.btnBRAND.Text = "BRAND NAME "
        Me.btnBRAND.UseVisualStyleBackColor = False
        '
        'btnPRODUCT
        '
        Me.btnPRODUCT.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnPRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPRODUCT.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPRODUCT.ForeColor = System.Drawing.Color.White
        Me.btnPRODUCT.Location = New System.Drawing.Point(27, 134)
        Me.btnPRODUCT.Name = "btnPRODUCT"
        Me.btnPRODUCT.Size = New System.Drawing.Size(140, 60)
        Me.btnPRODUCT.TabIndex = 147
        Me.btnPRODUCT.Text = "PRODUCT CATEGORY "
        Me.btnPRODUCT.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 40)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 37)
        Me.Label3.TabIndex = 132
        Me.Label3.Text = "SETTINGS"
        '
        'pnlSETTINGS
        '
        Me.pnlSETTINGS.Location = New System.Drawing.Point(244, 21)
        Me.pnlSETTINGS.Name = "pnlSETTINGS"
        Me.pnlSETTINGS.Size = New System.Drawing.Size(892, 716)
        Me.pnlSETTINGS.TabIndex = 148
        '
        'ucSETTINGS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Controls.Add(Me.pnlSETTINGS)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "ucSETTINGS"
        Me.Size = New System.Drawing.Size(1167, 766)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnBRAND As Button
    Friend WithEvents btnPRODUCT As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlSETTINGS As Panel
End Class
