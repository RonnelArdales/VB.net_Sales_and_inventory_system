Public Class ucDASHBOARDvb
    Private Sub ucDASHBOARDvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim user As String
        con.Close()
        OpenCon()
        cmd.CommandText = "Select count(*) from tbl_user"
        user = cmd.ExecuteScalar()
        lblUsersNo.Text = user
        con.Close()

        Dim stock As String
        con.Close()
        OpenCon()
        cmd.CommandText = "Select sum(Quantity) from tbl_product"
        stock = cmd.ExecuteScalar()
        If stock = 0 Then
            lblSTOCK.Text = 0
        Else
            lblSTOCK.Text = stock
        End If

        con.Close()

        Dim customer As String
        con.Close()
        OpenCon()
        cmd.CommandText = "Select count(Customerno) from tbl_profile"
        customer = cmd.ExecuteScalar()
        lblCUSTOMER.Text = customer
        con.Close()

        Dim product As String
        con.Close()
        OpenCon()
        cmd.CommandText = "Select count(ProductCode) from tbl_product"
        product = cmd.ExecuteScalar()
        lblproduct.Text = customer
        con.Close()
    End Sub
End Class
