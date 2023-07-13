Public Class ucPRODUCT

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

    Private Sub Addcombobox_value()
        DGV_Refresh()
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

    Private Sub Getmax()
        OpenCon()
        cmd.CommandText = "Select * from tbl_product"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim getno As Integer
            con.Close()
            OpenCon()
            cmd.CommandText = "Select Max(ProductCode) from tbl_product"
            getno = Convert.ToInt64(cmd.ExecuteScalar())
            con.Close()
            txtPC.Text = getno + 1
        Else
            txtPC.Text = 1
            con.Close()
        End If
    End Sub

    Private Sub ucPRODUCT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_Refresh()

    End Sub

    Private Sub DGV_Refresh()
        Me.Tbl_productTableAdapter.Fill(Me.Sales_inventory_system_for_groceryDataSet.tbl_product)
    End Sub

    Private Sub BTNADD_Click(sender As Object, e As EventArgs) Handles BTNADD.Click
        Getmax()
        Addcombobox_value()
        BTNADD.Enabled = False
        BTNSAVE.Enabled = True
        BTNCANCEL.Enabled = True
        txtPN.Enabled = True
        cboCATEGORY.Enabled = True
        cboBRAND.Enabled = True
        txtPRICE.Enabled = True
        txtCS.Enabled = True
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        If txtPN.Text = "" Or cboCATEGORY.Text = "" Or cboBRAND.Text = "" Or txtPRICE.Text = "" Or txtCS.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
            txtPN.Focus()
            Exit Sub
        End If

        'saving products
        OpenCon()
        cmd.CommandText = "insert into tbl_product values(@pc, @pn, @pcat, @pb, @pprice,@pcs)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("pc", txtPC.Text)
            .AddWithValue("pn", txtPN.Text)
            .AddWithValue("pcat", cboCATEGORY.Text)
            .AddWithValue("pb", cboBRAND.Text)
            .AddWithValue("pprice", txtPRICE.Text)
            .AddWithValue("pcs", txtCS.Text)
        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("New record ha been saved!", vbOKOnly + vbInformation, "Saving Successful")

        activity = " Added new product. Product: " + txtPN.Text
        Actlog()

        BTNSAVE.Enabled = False
        BTNCANCEL.Enabled = False
        BTNADD.Enabled = True
        functionremove_disabled()
        DGV_Refresh()
    End Sub

    Private Sub functionremove_disabled()
        txtPC.Text = ""
        txtPN.Text = ""
        cboCATEGORY.Text = " "
        cboBRAND.Text = " "
        txtPRICE.Text = ""
        txtCS.Text = ""
        cboCATEGORY.Items.Clear()
        cboBRAND.Items.Clear()
        txtPC.Enabled = False
        txtPN.Enabled = False
        cboCATEGORY.Enabled = False
        cboBRAND.Enabled = False
        txtPRICE.Enabled = False
        txtCS.Enabled = False
    End Sub

    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        functionremove_disabled()
        BTNSAVE.Enabled = False
        BTNCANCEL.Enabled = False
        BTNADD.Enabled = True
    End Sub

    Private Sub txtSEARCH_TextChanged(sender As Object, e As EventArgs) Handles txtSEARCH.TextChanged
        If txtSEARCH.Text = "" Then
            TblproductBindingSource.Filter = Nothing
        Else
            TblproductBindingSource.Filter = "Productname like '%" & txtSEARCH.Text & "%' "
        End If
    End Sub

    Private Sub txtPRICE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPRICE.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCS.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
