Imports System.Data
Imports System.Data.SqlClient
Public Class frmdoanhthu
    Dim dung As New SqlConnection("workstation id=QLbandang.mssql.somee.com;packet size=4096;user id=dungtvpk00316;pwd=27020106;data source=QLbandang.mssql.somee.com;persist security info=False;initial catalog=QLbandang")
    Private Sub btntinh_Click(sender As Object, e As EventArgs) Handles btntinh.Click
      
    End Sub

    Private Sub txtdoanhthu_TextChanged(sender As Object, e As EventArgs) Handles txtdoanhthu.TextChanged
        dung.Open()
        Dim them As New SqlCommand("select Sum(Tonggia) from Chitiethoadon", dung)
        dung.Close()
    End Sub
End Class