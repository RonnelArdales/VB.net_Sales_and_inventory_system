Public Class ucPRODUCTSTOCK

    Private Sub Actlog()
        con.Close()
        OpenCon()
        cmd.CommandText = "insert into tbl_actlog values(@un, @act, @dt )"
        With cmd.Parameters
            .Clear()
            .AddWithValue("un", FRMMAINMENU.lblUN.Text)
            .AddWithValue("act", activity)
            .AddWithValue("dt", Date.Now.ToString("MM/dd/yyyy hh:mm:ss tt"))
        End With
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub ucPRODUCTSTOCK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_Refresh()
    End Sub

    Private Sub DGV_Refresh()
        Me.Tbl_productTableAdapter.Fill(Me.Sales_inventory_system_for_groceryDataSet.tbl_product)
    End Sub

    Private Sub Getmax()
        OpenCon()
        cmd.CommandText = "Select * from tbl_productstock"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim getno As Integer
            con.Close()
            OpenCon()
            cmd.CommandText = "Select Max(stockId) from tbl_productstock"
            getno = Convert.ToInt64(cmd.ExecuteScalar())
            con.Close()
            txtSTOCKID.Text = getno + 1
        Else
            txtSTOCKID.Text = 1
            con.Close()
        End If
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DataGridView1.Rows(e.RowIndex)
            txtPC.Text = row.Cells(0).Value
            txtPN.Text = row.Cells(1).Value
            txtavailstock.Text = row.Cells(5).Value
        End If
        Getmax()
        txtSTOCKADDED.Enabled = True
    End Sub



    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        txtSTOCKID.Text = ""
        txtPC.Text = ""
        txtPN.Text = ""
        txtavailstock.Text = ""
        txtSTOCKADDED.Text = ""
        DGV_Refresh()
        txtSTOCKADDED.Enabled = False
    End Sub

    Private Sub txtSEARCH_TextChanged(sender As Object, e As EventArgs) Handles txtSEARCH.TextChanged
        If txtSEARCH.Text = "" Then
            TblproductBindingSource.Filter = Nothing
        Else
            TblproductBindingSource.Filter = "Productname like '%" & txtSEARCH.Text & "%' "
        End If
    End Sub

    Private Sub txtSTOCKADDED_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSTOCKADDED.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        If txtSTOCKID.Text = "" Or txtPN.Text = "" Or txtPC.Text = "" Or txtavailstock.Text = "" Or txtSTOCKADDED.Text = "" Then
            MsgBox("Please select a record!", vbOKOnly + vbCritical, "Error Saving")
            txtSTOCKADDED.Focus()
            Exit Sub
        End If
        'update qty - tbl_book
        Dim QtyUpdate As Integer
        QtyUpdate = Val(txtSTOCKADDED.Text) + Val(txtavailstock.Text)

        OpenCon()
        cmd.CommandText = "update tbl_product set Quantity = @qty where ProductCode  = @bno"
        With cmd.Parameters
            .Clear()
            .AddWithValue("qty", QtyUpdate)
            .AddWithValue("bno", txtPC.Text)
        End With
        cmd.ExecuteNonQuery()
        con.Close()

        'save code - tbl_bookstock (insert into)
        con.Open()
        cmd.CommandText = "insert into tbl_productstock (stockId, productcode, productname, addedstock, dateadded ) values (@sid, @pcode, @pn, @pa, @da)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("sid", txtSTOCKID.Text)
            .AddWithValue("pcode", txtPC.Text)
            .AddWithValue("pn", txtPN.Text)
            .AddWithValue("pa", txtSTOCKADDED.Text)
            .AddWithValue("da", Date.Now.ToString("MM/dd/yyyy hh:mm:ss tt"))
        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("New Stock has been added", vbOKOnly + vbInformation, "Added Stock")

        activity = " Added new stock. Product: " + txtPN.Text
        Actlog()

        txtSTOCKID.Text = ""
        txtPC.Text = ""
        txtPN.Text = ""
        txtavailstock.Text = ""
        txtSTOCKADDED.Text = ""
        txtSEARCH.Text = ""

        txtSTOCKADDED.Enabled = False
        DGV_Refresh()
    End Sub
End Class
