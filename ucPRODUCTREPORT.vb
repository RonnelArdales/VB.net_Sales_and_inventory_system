Public Class ucPRODUCTREPORT

    Private Sub Addcombobox_value()
        OpenCon()
        cmd.CommandText = "Select * from tbl_category"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                cboCATEGORY.Items.Add(dr.Item("categoryname"))
            End While
        Else
            cboCATEGORY.Text = " "
        End If
        con.Close()


        OpenCon()
        cmd.CommandText = "Select * from tbl_brand"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                cboBRAND.Items.Add(dr.Item("brandname"))
            End While
        End If
        con.Close()
    End Sub
    Private Sub ucPRODUCTREPORT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.rptPRODUCT.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_productTableAdapter.Fill(Me.sales_inventory_system_for_groceryDataSet.tbl_product)
        Addcombobox_value()

        Me.rptPRODUCT.RefreshReport()
    End Sub

    Private Sub Clear_Filter()
        Me.tbl_productTableAdapter.Fill(Me.sales_inventory_system_for_groceryDataSet.tbl_product)
        cboBRAND.Text = ""
        cboCATEGORY.Text = ""
        Me.rptPRODUCT.RefreshReport()
    End Sub

    Private Sub btnBRAND_Click(sender As Object, e As EventArgs) Handles btnBRAND.Click
        Me.tbl_productTableAdapter.FillByBrand(Me.sales_inventory_system_for_groceryDataSet.tbl_product, cboBRAND.Text)

        Me.rptPRODUCT.RefreshReport()
    End Sub

    Private Sub btnCATEGORY_Click(sender As Object, e As EventArgs) Handles btnCATEGORY.Click
        Me.tbl_productTableAdapter.FillByCategory(Me.sales_inventory_system_for_groceryDataSet.tbl_product, cboCATEGORY.Text)
        Me.rptPRODUCT.RefreshReport()
    End Sub

    Private Sub btnCLEAR_Click(sender As Object, e As EventArgs) Handles btnCLEAR.Click
        Clear_Filter()
    End Sub
End Class
