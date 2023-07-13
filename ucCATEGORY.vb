Public Class ucCATEGORY


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

    Private Sub DGV_Refresh()
        Me.Tbl_categoryTableAdapter.Fill(Me.Sales_inventory_system_for_groceryDataSet.tbl_category)
    End Sub

    Private Sub Function_Enabled()
        btnADD.Enabled = False
        btnSAVE.Enabled = True
        btnEDIT.Enabled = False
        btnCANCEL.Enabled = True
        btnCANCEL.Enabled = True
        txtCATEGORYNAME.Enabled = True

    End Sub

    Private Sub Function_Disabled()
        btnADD.Enabled = True
        btnSAVE.Enabled = False
        btnEDIT.Enabled = True
        btnCANCEL.Enabled = False
        btnCANCEL.Enabled = False
        txtCATEGORYNAME.Enabled = False
    End Sub

    Private Sub Getmax()
        OpenCon()
        cmd.CommandText = "Select * from tbl_category"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim getno As Integer
            con.Close()
            OpenCon()
            cmd.CommandText = "Select Max(categorycode) from tbl_category"
            getno = Convert.ToInt64(cmd.ExecuteScalar())
            con.Close()
            txtCATEGORYCODE.Text = getno + 1
        Else
            txtCATEGORYCODE.Text = 1
            con.Close()
        End If
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Function_Enabled()
        txtCATEGORYNAME.Text = ""
        txtCATEGORYNAME.Focus()
        Getmax()
    End Sub

    Private Sub txtSEARCH_TextChanged(sender As Object, e As EventArgs) Handles txtSEARCH.TextChanged
        If txtSEARCH.Text = "" Then
            TblcategoryBindingSource.Filter = Nothing
        Else
            TblcategoryBindingSource.Filter = "categoryname like '%" & txtSEARCH.Text & "%' "
        End If
    End Sub

    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        If txtCATEGORYCODE.Text = "" Or txtCATEGORYNAME.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
            txtCATEGORYNAME.Focus()
            Exit Sub
        End If


        'saving user
        OpenCon()
        cmd.CommandText = "insert into tbl_category values(@ccode ,@cname)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("ccode", txtCATEGORYCODE.Text)
            .AddWithValue("cname", txtCATEGORYNAME.Text)

        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("New record ha been saved!", vbOKOnly + vbInformation, "Saving Successful")

        activity = "Added new category. Category: " + txtCATEGORYNAME.Text
        Actlog()

        Function_Disabled()
        txtCATEGORYCODE.Text = ""
        txtCATEGORYNAME.Text = ""
        DGV_Refresh()
    End Sub

    Private Sub btnEDIT_Click(sender As Object, e As EventArgs) Handles btnEDIT.Click
        If btnEDIT.Text = "EDIT" Then
            If txtCATEGORYCODE.Text = "" Or txtCATEGORYNAME.Text = "" Then
                MsgBox("Please select a record to edit!", vbOKOnly + vbCritical, "Error Editing")
                Exit Sub
            End If
            Function_Enabled()
            btnSAVE.Enabled = False
            btnEDIT.Enabled = True
            txtCATEGORYCODE.Enabled = False
            btnEDIT.Text = "UPDATE"

        ElseIf btnEDIT.Text = "UPDATE" Then
            'Error trapping
            If txtCATEGORYCODE.Text = "" Or txtCATEGORYNAME.Text = "" Then
                MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
                txtCATEGORYNAME.Focus()
                Exit Sub
            End If


            'code for upate
            OpenCon()
            cmd.CommandText = "Update tbl_category set categorycode =@cm, categoryname=@fname  where categorycode= @cm"
            With cmd.Parameters
                .Clear()
                .AddWithValue("cm", txtCATEGORYCODE.Text)
                .AddWithValue("fname", txtCATEGORYNAME.Text)

            End With
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Record has been updated!", vbOKOnly + vbInformation, "Editing Successful")
            activity = "Updated category. Category: " + txtCATEGORYNAME.Text
            Actlog()

            btnEDIT.Text = "EDIT"
            Function_Disabled()
            txtCATEGORYCODE.Text = ""
            txtCATEGORYNAME.Text = ""

            DGV_Refresh()
        End If
    End Sub

    Private Sub btnCANCEL_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        Function_Disabled()
        txtCATEGORYCODE.Text = ""
        txtCATEGORYNAME.Text = ""
        DGV_Refresh()
        btnEDIT.Text = "EDIT"
        DataGridView1.Enabled = True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DataGridView1.Rows(e.RowIndex)
            txtCATEGORYCODE.Text = row.Cells(0).Value
            txtCATEGORYNAME.Text = row.Cells(1).Value
        End If
    End Sub

    Private Sub ucCATEGORY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_Refresh()
    End Sub
End Class
