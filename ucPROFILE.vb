Public Class ucPROFILE

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

    Private Sub Function_Enabled()
        btnADD.Enabled = False
        btnSAVE.Enabled = True
        btnEDIT.Enabled = False
        btnCANCEL.Enabled = True
        btnCANCEL.Enabled = True
        txtFname.Enabled = True
        txtMname.Enabled = True
        txtLname.Enabled = True
        txtAddress.Enabled = True
        txtConnum.Enabled = True
    End Sub

    Private Sub Function_Disabled()
        btnADD.Enabled = True
        btnSAVE.Enabled = False
        btnEDIT.Enabled = True
        btnCANCEL.Enabled = False
        btnCANCEL.Enabled = False
        txtFname.Enabled = False
        txtMname.Enabled = False
        txtLname.Enabled = False
        txtAddress.Enabled = False
        txtConnum.Enabled = False
    End Sub


    Private Sub DGV_Refresh()
        Me.Tbl_profileTableAdapter.Fill(Me.Sales_inventory_system_for_groceryDataSet.tbl_profile)
    End Sub

    Private Sub ucPROFILE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_Refresh()
    End Sub

    Private Sub Getmax()
        OpenCon()
        cmd.CommandText = "Select * from tbl_profile"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim getno As Integer
            con.Close()
            OpenCon()
            cmd.CommandText = "Select Max(Customerno) from tbl_profile"
            getno = Convert.ToInt64(cmd.ExecuteScalar())
            con.Close()
            txtCusno.Text = getno + 1
        Else
            txtCusno.Text = 1
            con.Close()
        End If
    End Sub
    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Function_Enabled()
        txtFname.Text = ""
        txtMname.Text = ""
        txtLname.Text = ""
        DataGridView1.Enabled = False
        txtAddress.Text = ""
        txtConnum.Text = ""
        txtFname.Focus()
        Getmax()
    End Sub

    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        'erroe trapping
        If txtFname.Text = "" Or txtLname.Text = "" Or txtAddress.Text = "" Or txtConnum.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
            txtFname.Focus()
            Exit Sub
        End If


        'saving user
        OpenCon()
        cmd.CommandText = "insert into tbl_profile values(@cusno ,@fname, @mname, @lname, @address, @conno)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("cusno", txtCusno.Text)
            .AddWithValue("fname", txtFname.Text)
            .AddWithValue("mname", txtMname.Text)
            .AddWithValue("lname", txtLname.Text)
            .AddWithValue("address", txtAddress.Text)
            .AddWithValue("conno", txtConnum.Text)
        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("New record ha been saved!", vbOKOnly + vbInformation, "Saving Successful")

        activity = "Added new customer account. Customer: " + txtFname.Text + " " + txtLname.Text
        Actlog()

        Function_Disabled()
        txtCusno.Text = ""
        txtFname.Text = ""
        txtMname.Text = ""
        txtLname.Text = ""
        txtAddress.Text = ""
        txtConnum.Text = ""
        DataGridView1.Enabled = True
        DGV_Refresh()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DataGridView1.Rows(e.RowIndex)
            txtCusno.Text = row.Cells(0).Value
            txtFname.Text = row.Cells(1).Value
            txtMname.Text = row.Cells(2).Value
            txtLname.Text = row.Cells(3).Value
            txtAddress.Text = row.Cells(4).Value
            txtConnum.Text = row.Cells(5).Value
        End If
    End Sub

    Private Sub btnEDIT_Click(sender As Object, e As EventArgs) Handles btnEDIT.Click

        If btnEDIT.Text = "EDIT" Then
            If txtCusno.Text = "" Or txtFname.Text = "" Or txtLname.Text = "" Or txtAddress.Text = "" Or txtConnum.Text = "" Then
                MsgBox("Please select a record to edit!", vbOKOnly + vbCritical, "Error Editing")
                Exit Sub
            End If
            Function_Enabled()
            btnSAVE.Enabled = False
            btnEDIT.Enabled = True
            txtCusno.Enabled = False
            btnEDIT.Text = "UPDATE"

        ElseIf btnEDIT.Text = "UPDATE" Then
            'Error trapping
            If txtCusno.Text = "" Or txtFname.Text = "" Or txtLname.Text = "" Or txtAddress.Text = "" Or txtConnum.Text = "" Then
                MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
                txtFname.Focus()
                Exit Sub
            End If


            'code for upate
            OpenCon()
            cmd.CommandText = "Update tbl_profile set Customerno =@cm, Firstname=@fname, Middlename=@mname, Lastname=@lname, Address=@add, Contactno=@cno where Customerno= @cm"
            With cmd.Parameters
                .Clear()
                .AddWithValue("cm", txtCusno.Text)
                .AddWithValue("fname", txtFname.Text)
                .AddWithValue("mname", txtMname.Text)
                .AddWithValue("lname", txtLname.Text)
                .AddWithValue("add", txtAddress.Text)
                .AddWithValue("cno", txtConnum.Text)
            End With
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Record has been updated!", vbOKOnly + vbInformation, "Editing Successful")
            btnEDIT.Text = "EDIT"
            Function_Disabled()
            txtCusno.Text = ""
            txtFname.Text = ""
            txtMname.Text = ""
            txtLname.Text = ""
            txtAddress.Text = ""
            txtConnum.Text = ""
            DGV_Refresh()
        End If
    End Sub

    Private Sub txtSEARCH_TextChanged(sender As Object, e As EventArgs) Handles txtSEARCH.TextChanged
        If txtSEARCH.Text = "" Then
            TblprofileBindingSource.Filter = Nothing
        Else
            TblprofileBindingSource.Filter = "Firstname + Middlename + Lastname like '%" & txtSEARCH.Text & "%' "
        End If
    End Sub

    Private Sub btnCANCEL_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        Function_Disabled()
        txtCusno.Text = ""
        txtFname.Text = ""
        txtMname.Text = ""
        txtLname.Text = ""
        txtAddress.Text = ""
        txtConnum.Text = ""
        txtSEARCH.Text = ""
        btnEDIT.Text = "EDIT"
        DataGridView1.Enabled = True

    End Sub

    Private Sub txtConnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConnum.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
