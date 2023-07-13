Public Class ucTRANSACTIONREPORT
    Private Sub ucTRANSACTIONREPORT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.rptTRANSACTION.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_transactionTableAdapter.Fill(Me.sales_inventory_system_for_groceryDataSet.tbl_transaction)


        Me.rptTRANSACTION.RefreshReport()
    End Sub

    Private Sub btnDATEFILTER_Click(sender As Object, e As EventArgs) Handles btnDATEFILTER.Click
        Me.tbl_transactionTableAdapter.FillByDate(Me.sales_inventory_system_for_groceryDataSet.tbl_transaction, dtSTART.Value.ToString("MM/dd/yyyy"), dtEND.Value.ToString("MM/dd/yyyy"))
        Me.rptTRANSACTION.RefreshReport()

    End Sub

    Private Sub btnFNAMEFILTER_Click(sender As Object, e As EventArgs) Handles btnFNAMEFILTER.Click
        Me.tbl_transactionTableAdapter.FillByFname(Me.sales_inventory_system_for_groceryDataSet.tbl_transaction, txtFullname.Text)
        Me.rptTRANSACTION.RefreshReport()
    End Sub

    Private Sub Clear_Filter()
        Me.tbl_transactionTableAdapter.Fill(Me.sales_inventory_system_for_groceryDataSet.tbl_transaction)
        txtFullname.Text = ""
        Me.rptTRANSACTION.RefreshReport()
    End Sub

    Private Sub btnCLEAR_Click(sender As Object, e As EventArgs) Handles btnCLEAR.Click
        Clear_Filter()
    End Sub
End Class
