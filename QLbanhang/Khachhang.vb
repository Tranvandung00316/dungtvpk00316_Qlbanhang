Imports System.Data
Imports System.Data.SqlClient
Public Class frmkhachhang
    Dim dung As New SqlConnection("workstation id=QLbandang.mssql.somee.com;packet size=4096;user id=dungtvpk00316;pwd=27020106;data source=QLbandang.mssql.somee.com;persist security info=False;initial catalog=QLbandang")
    Private Sub loaddatabase()
        dung.Open()
        Dim load As New SqlCommand("select * from Khachhang", dung)
        Dim sqldata As New SqlDataAdapter(load)
        Dim sqldatatabel As New DataTable
        sqldata.Fill(sqldatatabel)
        dung.Close()
        lsvbang.Items.Clear()
        Dim a As Integer
        For Each Row As DataRow In sqldatatabel.Rows
            lsvbang.Items.Add(Row("MaKhachhang").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Tenkhachhang").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Ngaysinh").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Gioitinh").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Sodienthoai").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Diachi").ToString())
            lsvbang.Items(a).SubItems.Add(Row("CMND").ToString())
            a += 1
        Next
    End Sub
    Private Sub frmkhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddatabase()
    End Sub
    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Try
            dung.Open()
            Dim MaKH As String = txtmaKH.Text
            Dim Ten As String = txthoten.Text
            Dim ngay As String = dtngaysinh.Text
            Dim gioitinh As String = Txtgioitinh.Text        
            Dim Sdt As String = txtsdt.Text
            Dim dia As String = txtdiachi.Text
            Dim CMND As String = txtCMND.Text
            Dim them As New SqlCommand("Insert into Khachhang(Makhachhang,Tenkhachhang,Ngaysinh,Gioitinh,Sodienthoai,Diachi,CMND) values ('" + MaKH + "', N'" + Ten + "', '" + ngay + "','" + gioitinh + "','" + Sdt + "',N'" + dia + "','" + CMND + "')", dung)
            them.ExecuteNonQuery()
            dung.Close()
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loaddatabase()
        Catch ex As Exception
            MessageBox.Show("Thêm Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Try
            dung.Open()
            Dim Ma As String = txtmaKH.Text
            Dim Ten As String = txthoten.Text
            Dim ngay As String = dtngaysinh.Text
            Dim gioitinh As String = Txtgioitinh.Text
            Dim CMND As String = txtCMND.Text
            Dim Sdt As String = txtsdt.Text
            Dim dia As String = txtdiachi.Text
            Dim sua As New SqlCommand("update Khachhang set Tenkhachhang = N'" + Ten + "', Ngaysinh = '" + ngay + "',Gioitinh = '" + gioitinh + "', Sodienthoai = '" + Sdt + "',Diachi = N'" + dia + "',CMND = '" + CMND + "' where  Mannhanvien = '" + Ma + "'", dung)
            sua.ExecuteNonQuery()
            dung.Close()
            MessageBox.Show("Sũa đã thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question)
            loaddatabase()
        Catch ex As Exception
            MessageBox.Show("Sữa Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dung.Close()
        End Try
    End Sub

    Private Sub lsvbang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvbang.SelectedIndexChanged
        If lsvbang.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lsvbang.SelectedItems
                txtmaKH.Text = lis.SubItems(0).Text
                txthoten.Text = lis.SubItems(1).Text
                dtngaysinh.Text = lis.SubItems(2).Text
                Txtgioitinh.Text = lis.SubItems(3).Text
                txtsdt.Text = lis.SubItems(4).Text
                txtdiachi.Text = lis.SubItems(5).Text
                txtCMND.Text = lis.SubItems(6).Text
            Next
        End If
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Try
            dung.Open()
            Dim MaNV As String = txtmaKH.Text
            Dim xoa As New SqlCommand("delete from Khachhang where Makhachhang ='" + MaNV + "'", dung)
            If (MessageBox.Show("Có chắc là bạn muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                xoa.ExecuteNonQuery()
                dung.Close()
                loaddatabase()
            End If
        Catch ex As Exception
            MessageBox.Show("Xóa Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dung.Close()
        End Try
    End Sub

    Private Sub btnhuy_Click(sender As Object, e As EventArgs) Handles btnhuy.Click
        txtmaKH.Text = ""
        txtmaKH.Text = ""
        dtngaysinh.Text = ""
        Txtgioitinh.Text = ""
        txtsdt.Text = ""
        txtdiachi.Text = ""
        txtCMND.Text = ""
    End Sub

    Private Sub cbblanthi_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Close()
    End Sub
End Class