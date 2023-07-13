Public Class ucPROFILEREPORT
    Private Sub ucPROFILEREPORT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.rptPROFILE.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_profileTableAdapter.Fill(Me.sales_inventory_system_for_groceryDataSet.tbl_profile)


        Me.rptPROFILE.RefreshReport()
    End Sub

    Private Sub BTNFILTERFNAME_Click(sender As Object, e As EventArgs) Handles BTNFILTERFNAME.Click
        Me.tbl_profileTableAdapter.FillByFname(Me.sales_inventory_system_for_groceryDataSet.tbl_profile, txtFNAME.Text)


        Me.rptPROFILE.RefreshReport()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear_Filter()
    End Sub

    Private Sub Clear_Filter()
        Me.tbl_profileTableAdapter.Fill(Me.sales_inventory_system_for_groceryDataSet.tbl_profile)
        txtFNAME.Text = ""
        txtLNAME.Text = ""
        Me.rptPROFILE.RefreshReport()
    End Sub

    Private Sub btnFILTERLNAME_Click(sender As Object, e As EventArgs) Handles btnFILTERLNAME.Click
        Me.tbl_profileTableAdapter.FillByLNAME(Me.sales_inventory_system_for_groceryDataSet.tbl_profile, txtLNAME.Text)


        Me.rptPROFILE.RefreshReport()
    End Sub
End Class
