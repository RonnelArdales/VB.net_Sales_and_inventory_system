Imports MySql.Data.MySqlClient
Module Moduledb
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader

    Public activity As String
    Sub OpenCon()
        con.ConnectionString = My.Settings.sales_inventory_system_for_groceryConnectionString
        con.Open()
        cmd.Connection = con
    End Sub

End Module
