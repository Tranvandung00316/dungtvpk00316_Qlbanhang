Imports System.Data
Imports System.Data.SqlClient
Public Class frmhoadon
    Dim dung As New SqlConnection("workstation id=QLbandang.mssql.somee.com;packet size=4096;user id=dungtvpk00316;pwd=27020106;data source=QLbandang.mssql.somee.com;persist security info=False;initial catalog=QLbandang")
    Private Sub btnketnoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnketnoi.Click
        Try
            dung.Open()
            MessageBox.Show("kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dung.Close()
        Catch ex As Exception
            MessageBox.Show("Kết nối không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub loaddatabase()
        dung.Open()
        Dim load As New SqlCommand("select * from Hoadon", dung)
        Dim sqldata As New SqlDataAdapter(load)
        Dim sqldatatabel As New DataTable
        sqldata.Fill(sqldatatabel)
        dung.Close()
        lsvbang.Items.Clear()
        Dim a As Integer
        For Each Row As DataRow In sqldatatabel.Rows
            lsvbang.Items.Add(Row("Mahoadon").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Manhanvien").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Makhachhang").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Tonggia").ToString())
            a += 1
        Next
    End Sub

    Private Sub frmhoadon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddatabase()
    End Sub

    Private Sub lsvbang_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvbang.SelectedIndexChanged
        If lsvbang.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lsvbang.SelectedItems
                txtmaHD.Text = lis.SubItems(0).Text
                txtmaNV.Text = lis.SubItems(1).Text
                txtmaKH.Text = lis.SubItems(2).Text
                txtTonggia.Text = lis.SubItems(3).Text
            Next
        End If
    End Sub

    Private Sub btnxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxoa.Click
        Try
            dung.Open()
            Dim MaHD As String = txtmaHD.Text
            Dim xoa As New SqlCommand("delete from Hoadon where Mahoadon ='" + MaHD + "'", dung)
            xoa.ExecuteNonQuery()
            dung.Close()
            If (MessageBox.Show("Có chắc là bạn muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                Me.Close()
                Global.System.Windows.Forms.Application.Exit()
            End If
            loaddatabase()
        Catch ex As Exception
            MessageBox.Show("Xóa Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dung.Close()
        End Try
    End Sub

    Private Sub btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthoat.Click
        If (MessageBox.Show("Có chắc là bạn muốn thoát hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Me.Close()
            Global.System.Windows.Forms.Application.Exit()
        End If
    End Sub

    Private Sub btnsua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsua.Click
        Try
            dung.Open()
            Dim MaHD As String = txtmaHD.Text
            Dim MaNV As String = txtmaNV.Text
            Dim MaKH As String = txtmaKH.Text
            Dim Tonggia As Integer = txtTonggia.Text
            Dim sua As New SqlCommand("update Hoadon set Manhanvien = '" + MaNV + "',Makhachhang = '" + MaKH + "',Tonggia = '" + Tonggia + "' where Mahoadon ='" + MaHD + "' ", dung)
            sua.ExecuteNonQuery()
            dung.Close()
            MessageBox.Show("Sũa đã thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            loaddatabase()
        Catch ex As Exception
            MessageBox.Show("Sữa Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dung.Close()
        End Try
    End Sub

    Private Sub btnluu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnluu.Click
        loaddatabase()
    End Sub

    Private Sub btnhuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhuy.Click
        txtmaHD.Text = ""
        txtmaKH.Text = ""
        txtmaNV.Text = ""
        txtTonggia.Text = """
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Try
            dung.Open()
            Dim MaHD As String = txtmaHD.Text
            Dim MaNV As String = txtmaNV.Text
            Dim MaKH As String = txtTonggia.Text
            Dim Tonggia As String = txtTonggia.Text
            Dim them As New SqlCommand("Insert into Hoadon(Mahoadon,Manhanvien,Makhachhang,Tonggia) values('" + MaHD + "' , '" + MaNV + "', '" + MaKH + "', '" + Tonggia + "')", dung)
            them.ExecuteNonQuery()
            dung.Close()
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loaddatabase()
        Catch ex As Exception
            MessageBox.Show("Thêm Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dung.Close()

        End Try
    End Sub
End Class