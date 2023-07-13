Public Class ucSETTINGS
    Private Sub btnPRODUCT_Click(sender As Object, e As EventArgs) Handles btnPRODUCT.Click
        Dim i As Integer
        Dim Category As New ucCATEGORY
        If pnlSETTINGS.Controls.Count = 1 Then
            For i = 0 To 0
                pnlSETTINGS.Controls.RemoveAt(i)
            Next
            Category.Parent = pnlSETTINGS
            Category.Show()
            Category.Dock = DockStyle.Fill
        Else
            Category.Parent = pnlSETTINGS
            Category.Show()
            Category.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub btnBRAND_Click(sender As Object, e As EventArgs) Handles btnBRAND.Click
        Dim i As Integer
        Dim Brandname As New ucBRANDNAME
        If pnlSETTINGS.Controls.Count = 1 Then
            For i = 0 To 0
                pnlSETTINGS.Controls.RemoveAt(i)
            Next
            Brandname.Parent = pnlSETTINGS
            Brandname.Show()
            Brandname.Dock = DockStyle.Fill
        Else
            Brandname.Parent = pnlSETTINGS
            Brandname.Show()
            Brandname.Dock = DockStyle.Fill
        End If
    End Sub
End Class
