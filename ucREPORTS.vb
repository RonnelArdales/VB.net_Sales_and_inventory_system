Public Class ucREPORTS
    Private Sub btnUserAccount_Click(sender As Object, e As EventArgs) Handles btnUserAccount.Click
        Dim i As Integer
        Dim useraccount As New ucUSERREPORT
        If pnlMAINREPORT.Controls.Count = 1 Then
            For i = 0 To 0
                pnlMAINREPORT.Controls.RemoveAt(i)
            Next
            useraccount.Parent = pnlMAINREPORT
            useraccount.Show()
            useraccount.Dock = DockStyle.Fill
        Else
            useraccount.Parent = pnlMAINREPORT
            useraccount.Show()
            useraccount.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub btnActivityLog_Click(sender As Object, e As EventArgs) Handles btnActivityLog.Click
        Dim i As Integer
        Dim Activitylog As New ucACTIVITYLOGREPORT
        If pnlMAINREPORT.Controls.Count = 1 Then
            For i = 0 To 0
                pnlMAINREPORT.Controls.RemoveAt(i)
            Next
            Activitylog.Parent = pnlMAINREPORT
            Activitylog.Show()
            Activitylog.Dock = DockStyle.Fill
        Else
            Activitylog.Parent = pnlMAINREPORT
            Activitylog.Show()
            Activitylog.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        Dim i As Integer
        Dim Product As New ucPRODUCTREPORT
        If pnlMAINREPORT.Controls.Count = 1 Then
            For i = 0 To 0
                pnlMAINREPORT.Controls.RemoveAt(i)
            Next
            Product.Parent = pnlMAINREPORT
            Product.Show()
            Product.Dock = DockStyle.Fill
        Else
            Product.Parent = pnlMAINREPORT
            Product.Show()
            Product.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub btnProductStock_Click(sender As Object, e As EventArgs) Handles btnProductStock.Click
        Dim i As Integer
        Dim ProductStock As New ucPRODUCTSTOCKREPORT
        If pnlMAINREPORT.Controls.Count = 1 Then
            For i = 0 To 0
                pnlMAINREPORT.Controls.RemoveAt(i)
            Next
            ProductStock.Parent = pnlMAINREPORT
            ProductStock.Show()
            ProductStock.Dock = DockStyle.Fill
        Else
            ProductStock.Parent = pnlMAINREPORT
            ProductStock.Show()
            ProductStock.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub btnCustomerProfile_Click(sender As Object, e As EventArgs) Handles btnCustomerProfile.Click
        Dim i As Integer
        Dim Profile As New ucPROFILEREPORT
        If pnlMAINREPORT.Controls.Count = 1 Then
            For i = 0 To 0
                pnlMAINREPORT.Controls.RemoveAt(i)
            Next
            Profile.Parent = pnlMAINREPORT
            Profile.Show()
            Profile.Dock = DockStyle.Fill
        Else
            Profile.Parent = pnlMAINREPORT
            Profile.Show()
            Profile.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub btnSalesTransaction_Click(sender As Object, e As EventArgs) Handles btnSalesTransaction.Click
        Dim i As Integer
        Dim Transaction As New ucTRANSACTIONREPORT
        If pnlMAINREPORT.Controls.Count = 1 Then
            For i = 0 To 0
                pnlMAINREPORT.Controls.RemoveAt(i)
            Next
            Transaction.Parent = pnlMAINREPORT
            Transaction.Show()
            Transaction.Dock = DockStyle.Fill
        Else
            Transaction.Parent = pnlMAINREPORT
            Transaction.Show()
            Transaction.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub ucREPORTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FRMMAINMENU.LBLUSERTYPE.Text = "Administrator" Then
            btnUserAccount.Enabled = True
            btnActivityLog.Enabled = True
            btnProduct.Enabled = True
            btnCustomerProfile.Enabled = True
            btnSalesTransaction.Enabled = True
            btnProductStock.Enabled = True
        ElseIf FRMMAINMENU.LBLUSERTYPE.Text = "Cashier" Then
            btnCustomerProfile.Enabled = True
            btnSalesTransaction.Enabled = True
        End If

    End Sub
End Class
