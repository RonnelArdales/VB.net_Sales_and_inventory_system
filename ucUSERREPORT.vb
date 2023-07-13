Public Class ucUSERREPORT
    Private Sub ucUSERREPORT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.rptUSER.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_userTableAdapter.Fill(Me.sales_inventory_system_for_groceryDataSet.tbl_user)


        Me.rptUSER.RefreshReport()
    End Sub

    Private Sub btnFILTERUSERTYPE_Click(sender As Object, e As EventArgs) Handles btnFILTERUSERTYPE.Click
        Me.tbl_userTableAdapter.FillByUsertype(Me.sales_inventory_system_for_groceryDataSet.tbl_user, cboUSERTYPE.Text)
        Me.rptUSER.RefreshReport()
    End Sub

    Private Sub btnFILTERSTATUS_Click(sender As Object, e As EventArgs) Handles btnFILTERSTATUS.Click
        Me.tbl_userTableAdapter.FillByStatus(Me.sales_inventory_system_for_groceryDataSet.tbl_user, cboSTATUS.Text)
        Me.rptUSER.RefreshReport()
    End Sub


    Private Sub Clear_Filter()
        Me.tbl_userTableAdapter.Fill(Me.sales_inventory_system_for_groceryDataSet.tbl_user)
        cboUSERTYPE.Text = ""
        cboSTATUS.Text = ""
        Me.rptUSER.RefreshReport()
    End Sub

    Private Sub btnCLEAR_Click(sender As Object, e As EventArgs) Handles btnCLEAR.Click
        Clear_Filter()
    End Sub


End Class
