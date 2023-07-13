Public Class ucBRANDNAME

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
        Me.Tbl_brandTableAdapter.Fill(Me.Sales_inventory_system_for_groceryDataSet.tbl_brand)
    End Sub

    Private Sub Function_Enabled()
        btnADD.Enabled = False
        btnSAVE.Enabled = True
        btnEDIT.Enabled = False
        btnCANCEL.Enabled = True
        btnCANCEL.Enabled = True
        txtBRANDNAME.Enabled = True

    End Sub

    Private Sub Function_Disabled()
        btnADD.Enabled = True
        btnSAVE.Enabled = False
        btnEDIT.Enabled = True
        btnCANCEL.Enabled = False
        btnCANCEL.Enabled = False
        txtBRANDNAME.Enabled = False
    End Sub

    Private Sub Getmax()
        OpenCon()
        cmd.CommandText = "Select * from tbl_brand"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim getno As Integer
            con.Close()
            OpenCon()
            cmd.CommandText = "Select Max(brandcode) from tbl_brand"
            getno = Convert.ToInt64(cmd.ExecuteScalar())
            con.Close()
            txtBRANDCODE.Text = getno + 1
        Else
            txtBRANDCODE.Text = 1
            con.Close()
        End If
    End Sub

    Private Sub ucBRANDNAME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_Refresh()
    End Sub





    Private Sub btnEDIT_Click(sender As Object, e As EventArgs) Handles btnEDIT.Click

        If btnEDIT.Text = "EDIT" Then
            If txtBRANDCODE.Text = "" Or txtBRANDNAME.Text = "" Then
                MsgBox("Please select a record to edit!", vbOKOnly + vbCritical, "Error Editing")
                Exit Sub
            End If
            Function_Enabled()
            btnSAVE.Enabled = False
            btnEDIT.Enabled = True
            txtBRANDCODE.Enabled = False
            btnEDIT.Text = "UPDATE"

        ElseIf btnEDIT.Text = "UPDATE" Then
            'Error trapping
            If txtBRANDCODE.Text = "" Or txtBRANDNAME.Text = "" Then
                MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
                txtBRANDNAME.Focus()
                Exit Sub
            End If


            'code for upate
            OpenCon()
            cmd.CommandText = "Update tbl_brand set  brandcode=@cm, brandname=@fname where brandcode= @cm "
            With cmd.Parameters
                .Clear()
                .AddWithValue("cm", txtBRANDCODE.Text)
                .AddWithValue("fname", txtBRANDNAME.Text)

            End With
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Record has been updated!", vbOKOnly + vbInformation, "Editing Successful")

            activity = "Updated brand name. Brandname: " + txtBRANDNAME.Text
            Actlog()

            btnEDIT.Text = "EDIT"
            Function_Disabled()
            txtBRANDCODE.Text = ""
            txtBRANDNAME.Text = ""
            DGV_Refresh()
        End If
    End Sub

    Private Sub btnCANCEL_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        Function_Disabled()
        txtBRANDCODE.Text = ""
        txtBRANDNAME.Text = ""
        DGV_Refresh()
        btnEDIT.Text = "EDIT"
        DataGridView1.Enabled = True
    End Sub

    Private Sub txtSEARCH_TextChanged(sender As Object, e As EventArgs) Handles txtSEARCH.TextChanged
        If txtSEARCH.Text = "" Then
            TblbrandBindingSource.Filter = Nothing
        Else
            TblbrandBindingSource.Filter = "brandname like '%" & txtSEARCH.Text & "%' "
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DataGridView1.Rows(e.RowIndex)
            txtBRANDCODE.Text = row.Cells(0).Value
            txtBRANDNAME.Text = row.Cells(1).Value
        End If
    End Sub



    Private Sub btnADD_Click_1(sender As Object, e As EventArgs) Handles btnADD.Click
        Function_Enabled()
        txtBRANDNAME.Text = ""
        txtBRANDNAME.Focus()
        Getmax()
    End Sub

    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        'erroe trapping
        If txtBRANDCODE.Text = "" Or txtBRANDNAME.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
            txtBRANDNAME.Focus()
            Exit Sub
        End If


        'saving user
        OpenCon()
        cmd.CommandText = "insert into tbl_brand values(@bcode ,@bname)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("bcode", txtBRANDCODE.Text)
            .AddWithValue("bname", txtBRANDNAME.Text)

        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("New record ha been saved!", vbOKOnly + vbInformation, "Saving Successful")

        activity = "Added new brand name. Brandname: " + txtBRANDNAME.Text
        Actlog()

        Function_Disabled()
        txtBRANDCODE.Text = ""
        txtBRANDNAME.Text = ""
        DGV_Refresh()
    End Sub
End Class
