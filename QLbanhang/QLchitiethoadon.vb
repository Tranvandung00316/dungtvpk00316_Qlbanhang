Imports System.Data
Imports System.Data.SqlClient
Public Class frmchitiethoadon
    Dim dung As New SqlConnection("workstation id=QLbandang.mssql.somee.com;packet size=4096;user id=dungtvpk00316;pwd=27020106;data source=QLbandang.mssql.somee.com;persist security info=False;initial catalog=QLbandang")
    Private Sub loaddatabase()
        dung.Open()
        Dim load As New SqlCommand("select * from Chitiethoadon", dung)
        Dim sqldata As New SqlDataAdapter(load)
        Dim sqldatatabel As New DataTable
        sqldata.Fill(sqldatatabel)
        dung.Close()
        lsvbang.Items.Clear()
        Dim a As Integer
        For Each Row As DataRow In sqldatatabel.Rows
            lsvbang.Items.Add(Row("Machitiethoadon").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Mahoadon").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Masanpham").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Tensanpham").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Tenkhachhang").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Soluong").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Giasanpham").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Ngaynhap").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Ngayxuat").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Tonggia").ToString())
            a += 1
        Next
    End Sub

    Private Sub frmchitiethoadon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddatabase()
    End Sub

    Private Sub lsvbang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvbang.SelectedIndexChanged
        If lsvbang.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lsvbang.SelectedItems
                txtmaCTHD.Text = lis.SubItems(0).Text
                TxtmaHD.Text = lis.SubItems(1).Text
                txtmaSP.Text = lis.SubItems(2).Text
                txttenSP.Text = lis.SubItems(3).Text
                TxttenKH.Text = lis.SubItems(4).Text
                txtSL.Text = lis.SubItems(5).Text
                txtgia.Text = lis.SubItems(6).Text
                dtnn.Text = lis.SubItems(7).Text
                dtnnX.Text = lis.SubItems(8).Text
                txtTG.Text = lis.SubItems(9).Text
            Next
        End If
    End Sub
    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Try
            dung.Open()
            Dim MaCTHD As String = txtmaCTHD.Text
            Dim MaHD As String = TxtmaHD.Text
            Dim MaSP As String = txtmaSP.Text
            Dim TenSP As String = txttenSP.Text
            Dim TenKH As String = TxttenKH.Text
            Dim SL As String = txtSL.Text
            Dim gia As String = txtgia.Text
            Dim NN As String = dtnn.Text
            Dim NX As String = dtnnX.Text
            Dim TG As String = txtTG.Text
            Dim them As New SqlCommand("Insert into Chitiethoadon(Machitiethoadon,Mahoadon,Masanpham,Tensanpham,Tenkhachhang,Soluong,Giasanpham,Ngaynhap,Ngayxuat,Tonggia) values('" + MaCTHD + "' , '" + MaHD + "', '" + MaSP + "', N'" + TenSP + "', N'" + TenKH + "', '" + SL + "','" + gia + "', '" + NN + "', '" + NX + "','" + TG + "')", dung)
            them.ExecuteNonQuery()
            dung.Close()
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loaddatabase()
        Catch ex As Exception
            MessageBox.Show("Thêm Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dung.Close()
        End Try
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Try
            dung.Open()
            Dim MaCTHD As String = txtmaCTHD.Text
            Dim MaHD As String = TxtmaHD.Text
            Dim MaSP As String = txtmaSP.Text
            Dim TenSP As String = txttenSP.Text
            Dim TenKH As String = TxttenKH.Text
            Dim SL As String = txtSL.Text
            Dim gia As String = txtgia.Text
            Dim NN As String = dtnn.Text
            Dim NX As String = dtnnX.Text
            Dim TG As String = txtTG.Text
            Dim sua As New SqlCommand("update Chitiethoadon set Mahoadon = '" + MaHD + "', Masanpham = '" + MaSP + "',Tensanpham = N'" + TenSP + "',Tenkhachhang = N'" + TenKH + "',Soluong = '" + SL + "',Giasanpham = '" + gia + "',Ngaynhap = '" + NN + "',Ngayxuat = '" + NX + "',Tonggia = '" + TG + "' where  Machitiethoadon = '" + MaCTHD + "'", dung)
            sua.ExecuteNonQuery()
            dung.Close()
            MessageBox.Show("Sũa đã thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question)
            loaddatabase()
        Catch ex As Exception
            MessageBox.Show("Sữa Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dung.Close()
        End Try
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Try
            dung.Open()
            Dim MaCTHD As String = txtmaCTHD.Text
            Dim xoa As New SqlCommand("delete from Chitiethoadon where Machitiethoadon ='" + MaCTHD + "'", dung)
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

    Private Sub btnluu_Click(sender As Object, e As EventArgs) Handles btnluu.Click
        loaddatabase()
    End Sub

    Private Sub btnhuy_Click(sender As Object, e As EventArgs) Handles btnhuy.Click
        txtmaCTHD.Text = ""
        TxtmaHD.Text = ""
        txtmaSP.Text = ""
        txttenSP.Text = ""
        TxttenKH.Text = ""
        txtSL.Text = ""
        txtgia.Text = ""
        dtnn.Text = ""
        dtnnX.Text = ""
        txtTG.Text = ""
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        If (MessageBox.Show("Có chắc là bạn muốn thoát hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Me.Close()
            Global.System.Windows.Forms.Application.Exit()
        End If
    End Sub
End Class