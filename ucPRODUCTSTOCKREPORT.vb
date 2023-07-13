Public Class ucPRODUCTSTOCKREPORT
    Private Sub ucPRODUCTSTOCKREPORT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.rptPRODUCTSTOCK.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_productstockTableAdapter.Fill(Me.sales_inventory_system_for_groceryDataSet.tbl_productstock)


        Me.rptPRODUCTSTOCK.RefreshReport()
    End Sub

    Private Sub BTNDATE_Click(sender As Object, e As EventArgs) Handles BTNDATE.Click
        Me.tbl_productstockTableAdapter.FillByDate(Me.sales_inventory_system_for_groceryDataSet.tbl_productstock, DtStart.Value.ToString("MM/dd/yyyy 00:00:00"), DtEnd.Value.ToString("MM/dd/yyyy 23:59:59"))
        Me.rptPRODUCTSTOCK.RefreshReport()

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Me.tbl_productstockTableAdapter.Fill(Me.sales_inventory_system_for_groceryDataSet.tbl_productstock)


        Me.rptPRODUCTSTOCK.RefreshReport()
    End Sub
End Class
