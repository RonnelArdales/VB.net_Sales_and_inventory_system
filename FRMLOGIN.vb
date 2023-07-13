Public Class FRMLOGIN
    Dim astat As String = "Active"

    Private Sub Actlog()
        con.Close()
        OpenCon()
        cmd.CommandText = "insert into tbl_actlog values(@un, @act, @dt )"
        With cmd.Parameters
            .Clear()
            .AddWithValue("un", TXTUN.Text)
            .AddWithValue("act", activity)
            .AddWithValue("dt", Date.Now.ToString("MM/dd/yyyy hh:mm:ss tt"))
        End With
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub BTNLOGIN_Click(sender As Object, e As EventArgs) Handles BTNLOGIN.Click
        OpenCon()
        cmd.CommandText = "select * from tbl_user where username = '" & TXTUN.Text & "' and password = '" & TXTPW.Text & "' and status = '" & astat & "' "
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            If dr(3) = "Administrator" Then
                activity = "Logged-In"
                Actlog()
                FRMMAINMENU.LBLUSERTYPE.Text = "Administrator"
                FRMMAINMENU.lblUN.Text = TXTUN.Text
                FRMMAINMENU.Show()
                Me.Close()

            ElseIf dr(3) = "Cashier" Then
                activity = "Logged-In"
                Actlog()
                FRMMAINMENU.LBLUSERTYPE.Text = "Cashier"
                FRMMAINMENU.lblUN.Text = TXTUN.Text
                FRMMAINMENU.Show()
                Me.Close()
            ElseIf dr(3) = "Inventory Clerk" Then
                activity = "Logged-In"
                Actlog()
                FRMMAINMENU.LBLUSERTYPE.Text = "Inventory Clerk"
                FRMMAINMENU.lblUN.Text = TXTUN.Text
                FRMMAINMENU.Show()
                Me.Close()
            End If
        Else
            MsgBox("Sorry wrong username and pasword", vbOKOnly + vbCritical, "Error Login")
            TXTUN.Text = ""
            TXTPW.Text = ""
            TXTUN.Focus()
        End If
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TXTUN.Text = "admin"
        TXTPW.Text = "admin"
    End Sub

    Private Sub BTNEXIT_Click(sender As Object, e As EventArgs) Handles BTNEXIT.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TXTUN.Text = "cashier"
        TXTPW.Text = "cashier"
    End Sub
End Class
