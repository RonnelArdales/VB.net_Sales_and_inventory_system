Public Class ucUSERACCOUNT

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
        txtUn.Enabled = True
        txtPW.Enabled = True
        txtCONPASS.Enabled = True
        txtACCNAME.Enabled = True
        cboSTATUS.Enabled = True
        cboUSERTYPE.Enabled = True
    End Sub

    Private Sub Function_Disabled()
        btnADD.Enabled = True
        btnSAVE.Enabled = False
        btnEDIT.Enabled = True
        btnCANCEL.Enabled = False
        btnCANCEL.Enabled = False
        txtUn.Enabled = False
        txtPW.Enabled = False
        txtCONPASS.Enabled = False
        txtACCNAME.Enabled = False
        cboSTATUS.Enabled = False
        cboUSERTYPE.Enabled = False
    End Sub
    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Function_Enabled()
        txtUn.Text = ""
        txtPW.Text = ""
        txtCONPASS.Text = ""
        txtACCNAME.Text = ""
        cboUSERTYPE.Text = ""
        cboSTATUS.Text = ""
        dgvUser.Enabled = False
        txtUn.Focus()
    End Sub

    Private Sub refreshgrid()
        Me.Tbl_userTableAdapter.Fill(Me.Sales_inventory_system_for_groceryDataSet.tbl_user)
    End Sub

    Private Sub btnEDIT_Click(sender As Object, e As EventArgs) Handles btnEDIT.Click
        If btnEDIT.Text = "EDIT" Then
            If txtUn.Text = "" Or txtPW.Text = "" Or txtCONPASS.Text = "" Or txtACCNAME.Text = "" Or cboUSERTYPE.Text = "" Or cboSTATUS.Text = "" Then
                MsgBox("Please select a record to edit!", vbOKOnly + vbCritical, "Error Editing")
                Exit Sub
            End If
            Function_Enabled()
            btnSAVE.Enabled = False
            btnEDIT.Enabled = True
            txtUn.Enabled = False
            btnEDIT.Text = "UPDATE"

        ElseIf btnEDIT.Text = "UPDATE" Then
            'Error trapping
            If txtUn.Text = "" Or txtPW.Text = "" Or txtCONPASS.Text = "" Or txtACCNAME.Text = "" Or cboUSERTYPE.Text = "" Or cboSTATUS.Text = "" Then
                MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
                txtUn.Focus()
                Exit Sub
            End If
            If txtPW.Text <> txtCONPASS.Text Then
                MsgBox("Password should match!", vbOKOnly + vbCritical, "Error Saving")
                txtPW.Focus()
                Exit Sub
            End If
            'code for upate
            OpenCon()
            cmd.CommandText = "Update tbl_user set username =@un, password=@pw, loginname=@ln, usertype=@ut, status=@st where username= @un"
            With cmd.Parameters
                .Clear()
                .AddWithValue("un", txtUn.Text)
                .AddWithValue("pw", txtPW.Text)
                .AddWithValue("ln", txtACCNAME.Text)
                .AddWithValue("ut", cboUSERTYPE.Text)
                .AddWithValue("st", cboSTATUS.Text)
            End With
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Record has been updated!", vbOKOnly + vbInformation, "Editing Successful")
            activity = "Update user account. Username: " + txtUn.Text
            Actlog()

            btnEDIT.Text = "EDIT"
            Function_Disabled()
            txtUn.Text = ""
            txtPW.Text = ""
            txtCONPASS.Text = ""
            txtACCNAME.Text = ""
            cboUSERTYPE.Text = ""
            cboSTATUS.Text = ""
            refreshgrid()
        End If
    End Sub

    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        'erroe trapping

        If txtUn.Text <> txtDUN.Text Then
            OpenCon()
            cmd.CommandText = "Select * from tbl_user where username =  '" & txtUn.Text & "'  "
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                MsgBox("Sorry username already exist!", vbOKOnly + vbCritical, "Error Saving")
                con.Close()
                txtUn.Text = ""
                txtUn.Focus()
                Exit Sub
            End If
            con.Close()
        End If
        If txtUn.Text = "" Or txtPW.Text = "" Or txtCONPASS.Text = "" Or txtACCNAME.Text = "" Or cboUSERTYPE.Text = "" Or cboSTATUS.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
            txtUn.Focus()
            Exit Sub
        End If

        If txtPW.Text <> txtCONPASS.Text Then
            MsgBox("Password should match!", vbOKOnly + vbCritical, "Error Saving")
            txtPW.Focus()
            Exit Sub
        End If



        'saving user
        OpenCon()
        cmd.CommandText = "insert into tbl_user values(@un, @pw, @ln, @ut, @st)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("un", txtUn.Text)
            .AddWithValue("pw", txtPW.Text)
            .AddWithValue("ln", txtACCNAME.Text)
            .AddWithValue("ut", cboUSERTYPE.Text)
            .AddWithValue("st", cboSTATUS.Text)
        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("New record ha been saved!", vbOKOnly + vbInformation, "Saving Successful")

        activity = "Added new user account. Username: " + txtUn.Text
        Actlog()

        Function_Disabled()
        txtUn.Text = ""
        txtPW.Text = ""
        txtCONPASS.Text = ""
        txtACCNAME.Text = ""
        cboUSERTYPE.Text = ""
        cboSTATUS.Text = ""
        dgvUser.Enabled = True
        refreshgrid()
    End Sub

    Private Sub txtSEARCH_TextChanged(sender As Object, e As EventArgs) Handles txtSEARCH.TextChanged
        If txtSEARCH.Text = "" Then
            TbluserBindingSource.Filter = Nothing
        Else
            TbluserBindingSource.Filter = "username like '%" & txtSEARCH.Text & "%' "
        End If
    End Sub

    Private Sub ucUSERACCOUNT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshgrid()
    End Sub

    Private Sub dgvUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgvUser.Rows(e.RowIndex)
            txtUn.Text = row.Cells(0).Value
            txtPW.Text = row.Cells(1).Value
            txtCONPASS.Text = row.Cells(1).Value
            txtACCNAME.Text = row.Cells(2).Value
            cboUSERTYPE.Text = row.Cells(3).Value
            cboSTATUS.Text = row.Cells(4).Value
        End If
    End Sub

    Private Sub btnCANCEL_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        Function_Disabled()
        txtUn.Text = ""
        txtPW.Text = ""
        txtCONPASS.Text = ""
        txtACCNAME.Text = ""
        cboUSERTYPE.Text = ""
        cboSTATUS.Text = ""
        refreshgrid()
        btnEDIT.Text = "EDIT"
        dgvUser.Enabled = True

    End Sub

    Private Sub dgvUser_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvUser.CellFormatting
        If e.ColumnIndex = 1 Then
            e.Value = New String("*", e.Value.ToString.Length)
        End If
    End Sub

End Class
