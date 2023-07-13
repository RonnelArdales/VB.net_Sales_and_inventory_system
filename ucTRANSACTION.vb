Public Class ucTRANSACTION
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

    Private Sub btnbrowsecustomer_Click(sender As Object, e As EventArgs) Handles btnbrowsecustomer.Click
        pnlprofile.Visible = True
    End Sub

    Private Sub btnbrowseproduct_Click(sender As Object, e As EventArgs) Handles btnbrowseproduct.Click
        pnlproduct.Visible = True
    End Sub

    Private Sub Refresh_Product()
        Me.Tbl_productTableAdapter.Fill(Me.Sales_inventory_system_for_groceryDataSet.tbl_product)
    End Sub

    Private Sub BOOKCART_REFRESH()
        Me.Tbl_addcartTableAdapter.Fill(Me.Sales_inventory_system_for_groceryDataSet.tbl_addcart)
        DGVADDCART.Columns(9).Visible = False
        DGVADDCART.Columns(10).Visible = False
        DGVADDCART.Columns(11).Visible = False
    End Sub

    Private Sub dgvproduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvproduct.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgvproduct.Rows(e.RowIndex)
            txtPRODUCTCODE.Text = row.Cells(0).Value
            txtPRODUCTNAME.Text = row.Cells(1).Value
            txtQTYPRICE.Text = row.Cells(4).Value
            lblstock.Text = row.Cells(5).Value
        End If
        pnlproduct.Visible = False
        txtQUANTITY.Enabled = True
        txtQUANTITY.Focus()
    End Sub

    Private Sub dgvcustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcustomer.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgvcustomer.Rows(e.RowIndex)
            txtCUSTOMERNO.Text = row.Cells(0).Value
            txtFULLNAME.Text = row.Cells(1).Value + " " + row.Cells(3).Value
        End If
        pnlprofile.Visible = False
        txtQUANTITY.Enabled = True
        txtQUANTITY.Focus()
    End Sub

    Private Sub ucTRANSACTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refresh_Product()
        Me.Tbl_profileTableAdapter.Fill(Me.Sales_inventory_system_for_groceryDataSet.tbl_profile)
        Total_Amount()
        BOOKCART_REFRESH()

    End Sub

    Private Sub btnNEWTRANS_Click(sender As Object, e As EventArgs) Handles btnNEWTRANS.Click
        Getmax()
        btnNEWTRANS.Enabled = False

        btnbrowsecustomer.Enabled = True
        btnbrowseproduct.Enabled = True
        btnADD.Enabled = True
    End Sub

    Private Sub Getmax()

        OpenCon()
        cmd.CommandText = "Select * from tbl_transaction"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim getno As Integer
            con.Close()
            OpenCon()
            cmd.CommandText = "Select Max(TransNo) from tbl_transaction"
            getno = Convert.ToInt64(cmd.ExecuteScalar())
            con.Close()
            txtTransno.Text = getno + 1
        Else
            txtTransno.Text = 1
            con.Close()
        End If
    End Sub

    Private Sub Getmax_trans()
        con.Close()
        OpenCon()
        cmd.CommandText = "Select * from tbl_transaction"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim getno As Integer
            con.Close()
            OpenCon()
            cmd.CommandText = "Select Max(TransNo) from tbl_transaction"
            getno = Convert.ToInt64(cmd.ExecuteScalar())
            con.Close()
            txttransactionnum.Text = getno + 1
        Else
            txttransactionnum.Text = 1
            con.Close()
        End If
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click

        'error trapping if quanity is greater than stock
        If Val(txtQUANTITY.Text) > Val(lblstock.Text) Then
            MsgBox("Not enough stock!", vbOKOnly + vbCritical, "Error Saving")
            Exit Sub
        End If

        'Error trapping If textbox Is null
        If txtTransno.Text = "" Or txtCUSTOMERNO.Text = "" Or txtFULLNAME.Text = "" Or txtPRODUCTCODE.Text = "" Or txtPRODUCTNAME.Text = "" Or txtQUANTITY.Text = "" Or txtQTYPRICE.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
            Exit Sub
        End If

        'error trapping if product is existing in the cart
        OpenCon()
        cmd.CommandText = "select * from tbl_addcart where productcode = '" & txtPRODUCTCODE.Text & "' "
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            MsgBox("This product is already in the cart", vbOKOnly + vbCritical, "Error Saving")
            btnbrowseproduct.Focus()
            con.Close()
            Exit Sub
        End If
        con.Close()

        'add to product cart mode
        con.Open()
        cmd.CommandText = " insert into tbl_addcart( TransNo, TransDate, TransTime, CustomerNo, Fullname, ProductCode, ProductName, Quantity, Price ) values(@tn, @td, @tt, @cn, @fname, @pc, @pn, @qty, @price )"
        With cmd.Parameters
            .Clear()
            .AddWithValue("tn", txtTransno.Text)
            .AddWithValue("td", Date.Now.ToString("MM/dd/yyyy"))
            .AddWithValue("tt", Date.Now.ToString("hh:mm:ss tt"))
            .AddWithValue("cn", txtCUSTOMERNO.Text)
            .AddWithValue("fname", txtFULLNAME.Text)
            .AddWithValue("pc", txtPRODUCTCODE.Text)
            .AddWithValue("pn", txtPRODUCTNAME.Text)
            .AddWithValue("qty", txtQUANTITY.Text)
            .AddWithValue("price", txtPRODUCTPRICE.Text)

        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("New cart has been added", vbOKOnly + vbInformation, "Added Stock")
        txtQUANTITY.Enabled = False
        txtPRODUCTCODE.Text = ""
        txtPRODUCTNAME.Text = ""
        txtQUANTITY.Text = ""
        txtPRODUCTPRICE.Text = ""
        lblstock.Text = ""
        txtQTYPRICE.Text = ""
        BOOKCART_REFRESH()
        Total_Amount()

    End Sub

    Private Sub txtQUANTITY_TextChanged(sender As Object, e As EventArgs) Handles txtQUANTITY.TextChanged

        txtPRODUCTPRICE.Text = Val(txtQUANTITY.Text) * Val(txtQTYPRICE.Text)

    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        If txtremovecart.Text = "" Then
            MsgBox("Select a record to delete", vbOKOnly + vbCritical, "Error deleting")
            Exit Sub
        End If
        con.Close()
        OpenCon()
        cmd.CommandText = "delete from tbl_addcart where ProductCode= '" & txtremovecart.Text & "'"
        cmd.ExecuteNonQuery()
        con.Close()
        txtremovecart.Text = ""
        BOOKCART_REFRESH()
        MsgBox("Record has been deleted", vbOKOnly + vbInformation, "erf")
        Total_Amount()
    End Sub

    Private Sub Total_Amount()
        OpenCon()
        cmd.CommandText = "select TotalAmount from tbl_addcart "
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            con.Close()
            OpenCon()
            cmd.CommandText = "Select sum(Price)from tbl_addcart"
            Dim sqlresult As Object
            sqlresult = cmd.ExecuteScalar
            Dim str As String
            str = sqlresult

            txtTLPRICE.Text = Format(Val(str), "#,###,##0.00")
            con.Close()
        Else
            txtTLPRICE.Text = 0

            con.Close()
        End If
    End Sub

    Private Sub Total_Amount_transaction()
        con.Close()
        OpenCon()
        cmd.CommandText = "select TotalAmount from tbl_addcart "
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            con.Close()
            OpenCon()
            cmd.CommandText = "Select sum(Price)from tbl_addcart"
            Dim sqlresult As Object
            sqlresult = cmd.ExecuteScalar
            Dim str As String
            str = sqlresult
            txttotal.Text = Format(Val(str), "#,###,##0.00")
            con.Close()
        Else
            txttotal.Text = 0
            con.Close()
        End If
    End Sub

    Private Sub btnBUY_Click(sender As Object, e As EventArgs) Handles btnBUY.Click
        con.Close()
        OpenCon()
        cmd.CommandText = "select * from tbl_addcart"
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            btnbrowseproduct.Enabled = False
            btnbrowsecustomer.Enabled = False
            btnADD.Enabled = False
            btnremove.Enabled = False
            btnNEWTRANS.Enabled = False
            btnREMOVEALL.Enabled = False
            btnBUY.Enabled = False
            Getmax_trans()
            Total_Amount_transaction()
            pnlTRANSACTION.Visible = True
            cmd.Parameters.Clear()
            OpenCon()
            cmd.CommandText = "select * from tbl_addcart where TransNo = @tn "
            cmd.Parameters.AddWithValue("tn", txttransactionnum.Text)
            dr = cmd.ExecuteReader
            If dr.Read Then
                txtname.Text = dr("fullname")
                con.Close()
            End If
        Else
            MsgBox("Add record in Product Cart!", vbOKOnly + vbCritical, "Error Adding")
        End If
        con.Close()
    End Sub

    Private Sub btnBUYPRODUCT_Click(sender As Object, e As EventArgs) Handles btnBUYPRODUCT.Click
        'error trapping
        If txttransactionnum.Text = "" Or txtname.Text = "" Or txttotal.Text = "" Or txtPAYMENT.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
            txtPAYMENT.Focus()
            Exit Sub
        End If
        OpenCon()
        cmd.CommandText = "Update tbl_addcart set TransNo =@cm, Fullname=@fname, TotalAmount=@tamount, Cash=@cash, changed=@chh where TransNo= @cm"
        With cmd.Parameters
            .Clear()
            .AddWithValue("cm", txttransactionnum.Text)
            .AddWithValue("fname", txtname.Text)
            .AddWithValue("tamount", txtTLPRICE.Text)
            .AddWithValue("cash", txtPAYMENT.Text)
            .AddWithValue("chh", Val(txtchanged.Text))
        End With
        cmd.ExecuteNonQuery()
        con.Close()
        BOOKCART_REFRESH()


        Dim i As Integer
        For i = 0 To DGVADDCART.Rows.Count - 1
            OpenCon()
            cmd.CommandText = "insert into tbl_transaction(TransNo, TransDate, TransTime, CustomerNo, Fullname, ProductCode, ProductName, Quantity, Price, TotalAmount, Cash, `Change`) values(@tn, @transdate, @transtime, @cn, @fname, @pc, @pn, @qty, @price, @ta, @cash, @changed)"
            With cmd.Parameters
                .Clear()
                .AddWithValue("tn", DGVADDCART.Rows(i).Cells(0).Value.ToString)
                .AddWithValue("transdate", DGVADDCART.Rows(i).Cells(1).Value.ToString)
                .AddWithValue("transtime", DGVADDCART.Rows(i).Cells(2).Value.ToString)
                .AddWithValue("cn", DGVADDCART.Rows(i).Cells(3).Value.ToString)
                .AddWithValue("fname", DGVADDCART.Rows(i).Cells(4).Value.ToString)
                .AddWithValue("pc", DGVADDCART.Rows(i).Cells(5).Value.ToString)
                .AddWithValue("pn", DGVADDCART.Rows(i).Cells(6).Value.ToString)
                .AddWithValue("qty", DGVADDCART.Rows(i).Cells(7).Value.ToString)
                .AddWithValue("price", DGVADDCART.Rows(i).Cells(8).Value.ToString)
                .AddWithValue("ta", DGVADDCART.Rows(i).Cells(9).Value.ToString)
                .AddWithValue("cash", DGVADDCART.Rows(i).Cells(10).Value.ToString)
                .AddWithValue("changed", DGVADDCART.Rows(i).Cells(11).Value.ToString)
            End With
            cmd.ExecuteNonQuery()
            con.Close()
        Next
        MsgBox("Transaction have been recorded!", vbOKOnly + vbInformation, "Transaction saved")

        activity = "Added new transaction. Customer name: " + txtname.Text
        Actlog()


        'Update stock in tbl_product
        Dim updateQTY As Integer
        For i = 0 To DGVADDCART.Rows.Count - 1
            OpenCon()
            cmd.CommandText = "Select * from tbl_product where ProductCode ='" & DGVADDCART.Rows(i).Cells(5).Value.ToString & "' "
            dr = cmd.ExecuteReader
            While dr.Read
                updateQTY = dr.Item("Quantity") - DGVADDCART.Rows(i).Cells(7).Value.ToString
            End While
            con.Close()
            OpenCon()
            cmd.CommandText = "update tbl_product set Quantity = @uqty where ProductCode = @pc "
            With cmd.Parameters
                .Clear()
                .AddWithValue("uqty", updateQTY)
                .AddWithValue("pc", DGVADDCART.Rows(i).Cells(5).Value.ToString)
            End With
            cmd.ExecuteNonQuery()
            con.Close()
        Next

        'delete all record in add cart
        OpenCon()
        cmd.CommandText = "delete from tbl_addcart"
        cmd.ExecuteNonQuery()
        con.Close()
        Refresh_Product()
        BOOKCART_REFRESH()
        pnlTRANSACTION.Visible = False
        'clear textbox

        removefields()
        btnremove.Enabled = True
        btnREMOVEALL.Enabled = True

    End Sub

    Private Sub btnTRANSBACK_Click(sender As Object, e As EventArgs) Handles btnTRANSBACK.Click
        pnlTRANSACTION.Visible = False
        txttransactionnum.Text = ""
        txttotal.Text = ""
        txtname.Text = ""
        txtPAYMENT.Text = ""
        btnremove.Enabled = True
        btnREMOVEALL.Enabled = True
        btnADD.Enabled = True
        btnbrowsecustomer.Enabled = True
        btnbrowseproduct.Enabled = True
        btnBUY.Enabled = True
    End Sub

    Private Sub txtPAYMENT_TextChanged(sender As Object, e As EventArgs) Handles txtPAYMENT.TextChanged
        Dim change
        If txttotal.Text < txtPAYMENT.Text Then
            change = Val(txtPAYMENT.Text) - Val(txttotal.Text)
            txtchanged.Text = Format(change, "#,###,##0.00")
        Else
            txtchanged.Text = 0
        End If

    End Sub

    Private Sub DGVADDCART_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVADDCART.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DGVADDCART.Rows(e.RowIndex)
            txtremovecart.Text = row.Cells(5).Value

        End If
    End Sub

    Private Sub BTNEXIT_Click(sender As Object, e As EventArgs) Handles BTNEXIT.Click
        pnlproduct.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        pnlprofile.Visible = False
    End Sub

    Private Sub txtSEARCHCART_TextChanged(sender As Object, e As EventArgs) Handles txtSEARCHCART.TextChanged
        If txtSEARCHCART.Text = "" Then
            TbladdcartBindingSource.Filter = Nothing
        Else
            TbladdcartBindingSource.Filter = "Productname like '%" & txtSEARCHCART.Text & "%' "
        End If
    End Sub

    Private Sub txtSEARCHPROFILE_TextChanged(sender As Object, e As EventArgs) Handles txtSEARCHPROFILE.TextChanged
        If txtSEARCHPROFILE.Text = "" Then
            TblprofileBindingSource.Filter = Nothing
        Else
            TblprofileBindingSource.Filter = "Firstname + Middlename + Lastname like '%" & txtSEARCHPROFILE.Text & "%' "
        End If
    End Sub

    Private Sub TxtSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchProduct.TextChanged
        If TxtSearchProduct.Text = "" Then
            TblproductBindingSource.Filter = Nothing
        Else
            TblproductBindingSource.Filter = " Productname like '%" & TxtSearchProduct.Text & "%' "
        End If
    End Sub

    Private Sub txtPAYMENT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPAYMENT.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtQUANTITY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQUANTITY.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnREMOVEALL_Click(sender As Object, e As EventArgs) Handles btnREMOVEALL.Click
        Dim ans
        con.Close()
        OpenCon()
        cmd.CommandText = "select * from tbl_addcart"
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            ans = MsgBox("Do you want to delete all the record in add to cart?", vbYesNo + vbCritical, "Warning")
            If ans = vbYes Then
                con.Close()
                OpenCon()
                cmd.CommandText = "delete from tbl_addcart"
                cmd.ExecuteNonQuery()
                con.Close()
                BOOKCART_REFRESH()
                txtQUANTITY.Enabled = False
                removefields()
            ElseIf ans = vbNo Then

            End If
        Else
            MsgBox("Add record in Product Cart!", vbOKOnly + vbCritical, "Error Adding")
        End If
        con.Close()
    End Sub

    Private Sub removefields()
        txtTransno.Text = ""
        txtCUSTOMERNO.Text = ""
        txtFULLNAME.Text = ""
        txtPRODUCTCODE.Text = ""
        txtPRODUCTNAME.Text = ""
        txtQUANTITY.Text = ""
        txtPRODUCTPRICE.Text = ""
        lblstock.Text = ""
        txtremovecart.Text = ""
        txtQTYPRICE.Text = ""
        txttransactionnum.Text = ""
        txtname.Text = ""
        txttotal.Text = ""
        txtPAYMENT.Text = ""
        txtchanged.Text = ""
        txtPRODUCTPRICE.Text = ""
        txtTLPRICE.Text = ""

        btnbrowsecustomer.Enabled = False
        btnbrowseproduct.Enabled = False
        btnNEWTRANS.Enabled = True
        btnBUY.Enabled = True
        btnADD.Enabled = False
    End Sub
End Class
