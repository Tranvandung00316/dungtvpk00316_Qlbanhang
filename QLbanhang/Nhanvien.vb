Imports System.Data
Imports System.Data.SqlClient
Public Class frmnhanvien
    Dim dung As New SqlConnection("workstation id=QLbandang.mssql.somee.com;packet size=4096;user id=dungtvpk00316;pwd=27020106;data source=QLbandang.mssql.somee.com;persist security info=False;initial catalog=QLbandang")
    Private Sub loaddatabase()
        dung.Open()
        Dim load As New SqlCommand("select * from Nhanvien", dung)
        Dim sqldata As New SqlDataAdapter(load)
        Dim sqldatatabel As New DataTable
        sqldata.Fill(sqldatatabel)
        dung.Close()
        lsvbang.Items.Clear()
        Dim a As Integer
        For Each Row As DataRow In sqldatatabel.Rows
            lsvbang.Items.Add(Row("Manhanvien").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Tennhanvien").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Ngaysinh").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Gioitinh").ToString())
            lsvbang.Items(a).SubItems.Add(Row("CMND").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Sodienthoai").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Diachi").ToString())
            a += 1
        Next
    End Sub
 
    Private Sub btnhuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhuy.Click
        txtmaNV.Text = ""
        txttebNV.Text = ""
        dtngaysinh.Text = ""
        txtCMND.Text = ""
        txtsdt.Text = ""
        txtdiachi.Text = ""
    End Sub
    Private Sub frmnhanvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddatabase()
    End Sub
    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        If (MessageBox.Show("Có chắc là bạn muốn thoát hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Me.Close()
            Global.System.Windows.Forms.Application.Exit()
        End If
    End Sub
    Private Sub btnluu_Click(sender As Object, e As EventArgs) Handles btnluu.Click
        loaddatabase()
    End Sub
    Private Sub lsvbang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvbang.SelectedIndexChanged
        If lsvbang.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lsvbang.SelectedItems
                txtmaNV.Text = lis.SubItems(0).Text
                txttebNV.Text = lis.SubItems(1).Text
                dtngaysinh.Text = lis.SubItems(2).Text
                Txtgioitinh.Text = lis.SubItems(3).Text
                txtCMND.Text = lis.SubItems(4).Text
                txtsdt.Text = lis.SubItems(5).Text
                txtdiachi.Text = lis.SubItems(6).Text
            Next
        End If
    End Sub
    Private Sub btnthem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthem.Click
        Try
            dung.Open()
            Dim Ma As String = txtmaNV.Text
            Dim Ten As String = txttebNV.Text
            Dim ngay As String = dtngaysinh.Text
            Dim gioitinh As String = Txtgioitinh.Text
            Dim CMND As String = txtCMND.Text
            Dim Sdt As String = txtsdt.Text
            Dim dia As String = txtdiachi.Text
            Dim them As New SqlCommand("Insert into Nhanvien(Manhanvien,Tennhanvien,Ngaysinh,Gioitinh,CMND,Sodienthoai,Diachi) values ('" + Ma + "' , N'" + Ten + "', '" + ngay + "','" + gioitinh + "','" + CMND + "','" + Sdt + "',N'" + dia + "')", dung)
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
            Dim MaNV As String = txtmaNV.Text
            Dim Ten As String = txttebNV.Text
            Dim ngay As String = dtngaysinh.Text
            Dim gioitinh As String = Txtgioitinh.Text
            Dim CMND As String = txtCMND.Text
            Dim Sdt As String = txtsdt.Text
            Dim dia As String = txtdiachi.Text
            Dim sua As New SqlCommand("update Nhanvien set Tennhanvien = N'" + Ten + "', Ngaysinh = '" + ngay + "', Gioitinh = '" + gioitinh + "', CMND = '" + CMND + "', Sodienthoai = '" + Sdt + "', Diachi = N'" + dia + "' where Manhanvien = '" + MaNV + "'", dung)
            sua.ExecuteNonQuery()
            dung.Close()
            MessageBox.Show("Sữa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loaddatabase()
        Catch ex As Exception
            MessageBox.Show("Sữa Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dung.Close()
        End Try
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Try
            dung.Open()
            Dim MaNV As String = txtmaNV.Text
            Dim xoa As New SqlCommand("delete from Nhanvien where Manhanvien ='" + MaNV + "'", dung)
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class