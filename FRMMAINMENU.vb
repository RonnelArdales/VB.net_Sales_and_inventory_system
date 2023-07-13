Public Class FRMMAINMENU

    Private Sub Actlog()
        con.Close()
        OpenCon()
        cmd.CommandText = "insert into tbl_actlog values(@un, @act, @dt )"
        With cmd.Parameters
            .Clear()
            .AddWithValue("un", lblUN.Text)
            .AddWithValue("act", activity)
            .AddWithValue("dt", Date.Now.ToString("MM/dd/yyyy hh:mm:ss tt"))
        End With
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub FRMMAINMENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LBLUSERTYPE.Text = "Administrator" Then
            btnDASHBOARD.Enabled = True
            btnUSERMANAGEMENT.Enabled = True
            btnPRODUCT.Enabled = True
            btnCUSTOMERPROFILE.Enabled = True
            btnREPORT.Enabled = True
            btnSETTINGS.Enabled = True
            btnPRODUCTSTOCK.Enabled = True
        ElseIf LBLUSERTYPE.Text = "Cashier" Then
            btnDASHBOARD.Enabled = True
            btnTRANSACTION.Enabled = True
            btnCUSTOMERPROFILE.Enabled = True
            btnREPORT.Enabled = True
        ElseIf LBLUSERTYPE.Text = "Inventory Clerk" Then
            btnDASHBOARD.Enabled = True
            btnPRODUCTSTOCK.Enabled = True
        End If

        Dim Dashboard As New ucDASHBOARDvb()
        Dashboard.Parent = pnlMAIN
        Dashboard.Show()
        Dashboard.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNEXIT_Click(sender As Object, e As EventArgs) Handles BTNEXIT.Click
        activity = "Logged-out"
        Actlog()
        Me.Close()
    End Sub

    Private Sub btnREPORT_Click(sender As Object, e As EventArgs) Handles btnREPORT.Click
        Dim i As Integer
        For i = 0 To 0
            pnlMAIN.Controls.RemoveAt(i)

            Dim Report As New ucREPORTS()
            Report.Parent = pnlMAIN
            Report.Show()
            Report.Dock = DockStyle.Fill

        Next
    End Sub



    Private Sub btnUSERMANAGEMENT_Click(sender As Object, e As EventArgs) Handles btnUSERMANAGEMENT.Click
        Dim i As Integer
        For i = 0 To 0
            pnlMAIN.Controls.RemoveAt(i)

            Dim Useraccount As New ucUSERACCOUNT()
            Useraccount.Parent = pnlMAIN
            Useraccount.Show()
            Useraccount.Dock = DockStyle.Fill

        Next
    End Sub

    Private Sub btnPRODUCT_Click(sender As Object, e As EventArgs) Handles btnPRODUCT.Click
        Dim i As Integer
        For i = 0 To 0
            pnlMAIN.Controls.RemoveAt(i)

            Dim Product As New ucPRODUCT()
            Product.Parent = pnlMAIN
            Product.Show()
            Product.Dock = DockStyle.Fill

        Next
    End Sub

    Private Sub btnPRODUCTSTOCK_Click(sender As Object, e As EventArgs) Handles btnPRODUCTSTOCK.Click
        Dim i As Integer
        For i = 0 To 0
            pnlMAIN.Controls.RemoveAt(i)

            Dim Productstock As New ucPRODUCTSTOCK()
            Productstock.Parent = pnlMAIN
            Productstock.Show()
            Productstock.Dock = DockStyle.Fill

        Next
    End Sub

    Private Sub btnCUSTOMERPROFILE_Click(sender As Object, e As EventArgs) Handles btnCUSTOMERPROFILE.Click
        Dim i As Integer
        For i = 0 To 0
            pnlMAIN.Controls.RemoveAt(i)

            Dim Profile As New ucPROFILE()
            Profile.Parent = pnlMAIN
            Profile.Show()
            Profile.Dock = DockStyle.Fill

        Next
    End Sub

    Private Sub btnSETTINGS_Click(sender As Object, e As EventArgs) Handles btnSETTINGS.Click
        Dim i As Integer
        For i = 0 To 0
            pnlMAIN.Controls.RemoveAt(i)

            Dim Settings As New ucSETTINGS()
            Settings.Parent = pnlMAIN
            Settings.Show()
            Settings.Dock = DockStyle.Fill
        Next
    End Sub

    Private Sub btnLOGOUT_Click(sender As Object, e As EventArgs) Handles btnLOGOUT.Click
        Dim ans

        ans = MsgBox("Do you want to log out?", vbYesNo + vbCritical, "Warning")
        If ans = vbYes Then
            activity = "Logged-out"
            Actlog()
            FRMLOGIN.Show()
            Me.Close()
        ElseIf ans = vbNo Then

        End If

    End Sub

    Private Sub btnDASHBOARD_Click(sender As Object, e As EventArgs) Handles btnDASHBOARD.Click
        Dim i As Integer
        For i = 0 To 0
            pnlMAIN.Controls.RemoveAt(i)

            Dim Dashboard As New ucDASHBOARDvb()
            Dashboard.Parent = pnlMAIN
            Dashboard.Show()
            Dashboard.Dock = DockStyle.Fill
        Next
    End Sub

    Private Sub btnTRANSACTION_Click(sender As Object, e As EventArgs) Handles btnTRANSACTION.Click
        Dim i As Integer
        For i = 0 To 0
            pnlMAIN.Controls.RemoveAt(i)

            Dim Transaction As New ucTRANSACTION()
            Transaction.Parent = pnlMAIN
            Transaction.Show()
            Transaction.Dock = DockStyle.Fill
        Next
    End Sub
End Class