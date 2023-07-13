Public Class ucACTIVITYLOGREPORT
    Private Sub ucACTIVITYLOGREPORT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.rptACTIVITY.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_actlogTableAdapter.Fill(Me.sales_inventory_system_for_groceryDataSet.tbl_actlog)


        Me.rptACTIVITY.RefreshReport()
    End Sub

    Private Sub BTNDATE_Click(sender As Object, e As EventArgs) Handles BTNDATE.Click
        Me.tbl_actlogTableAdapter.FillByDate(Me.sales_inventory_system_for_groceryDataSet.tbl_actlog, DtStart.Value.ToString("MM/dd/yyyy 00:00:00"), DtEnd.Value.ToString("MM/dd/yyyy 23:59:59"))
        Me.rptACTIVITY.RefreshReport()


    End Sub

    Private Sub DtStart_ValueChanged(sender As Object, e As EventArgs) Handles DtStart.ValueChanged

    End Sub
End Class
