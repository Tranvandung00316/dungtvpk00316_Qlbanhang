Imports System.Data
Imports System.Data.SqlClient
Class frmsanpham
    Dim dung As New SqlConnection("workstation id=QLbandang.mssql.somee.com;packet size=4096;user id=dungtvpk00316;pwd=27020106;data source=QLbandang.mssql.somee.com;persist security info=False;initial catalog=QLbandang")
    Private Sub loaddatabase()
        dung.Open()
        Dim load As New SqlCommand("select * from Sanpham", dung)
        Dim sqldata As New SqlDataAdapter(load)
        Dim sqldatatabel As New DataTable
        sqldata.Fill(sqldatatabel)
        dung.Close()
        lsvbang.Items.Clear()
        Dim a As Integer
        For Each Row As DataRow In sqldatatabel.Rows
            lsvbang.Items.Add(Row("Masanpham").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Tensanpham").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Nhasanxuat").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Maloaisanpham").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Mota").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Gia").ToString())
            a += 1
        Next
    End Sub

    Private Sub lsvbang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvbang.SelectedIndexChanged
        If lsvbang.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lsvbang.SelectedItems
                txtmaSP.Text = lis.SubItems(0).Text
                txtTenSP.Text = lis.SubItems(1).Text
                TxtnhaSX.Text = lis.SubItems(2).Text
                txtMaLSP.Text = lis.SubItems(3).Text
                txtmota.Text = lis.SubItems(4).Text '
                txtgia.Text = lis.SubItems(5).Text
            Next
        End If
    End Sub

    Private Sub frmsanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnhuy_Click(sender As Object, e As EventArgs) Handles btnhuy.Click
        txtmaSP.Text = ""
        txtTenSP.Text = ""
        TxtnhaSX.Text = ""
        txtMaLSP.Text = ""
        txtmota.Text = ""
        txtgia.Text = ""
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Try
            dung.Open()
            Dim MaSP As String = txtmaSP.Text
            Dim TenSP As String = TxtnhaSX.Text
            Dim Nhasx As String = TxtnhaSX.Text
            Dim MaLSP As String = txtMaLSP.Text
            Dim Mota As String = txtmota.Text
            Dim Gia As String = txtgia.Text
            Dim them As New SqlCommand("Insert into Sanpham(Masanpham,Tensanpham,Nhasanxuat,Maloaisanpham,Mota,Gia) values('" + MaSP + "' , N'" + TenSP + "', N'" + Nhasx + "','" + MaLSP + "',N'" + Mota + "','" + Gia + "')", dung)
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
            Dim MaSP As String = txtmaSP.Text
            Dim TenSP As String = TxtnhaSX.Text
            Dim Nhasx As String = TxtnhaSX.Text
            Dim MaLSP As String = txtMaLSP.Text
            Dim Mota As String = txtmota.Text
            Dim Gia As String = txtgia.Text
            Dim sua As New SqlCommand("update Sanpham set Tensanpham = N'" + TenSP + "', Nhasanxuat = N'" + Nhasx + "', Maloaisanpham = '" + MaLSP + "', Mota = N'" + Mota + "', Gia = N'" + Gia + "' where  Masanpham = '" + MaSP + "'", dung)
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
            Dim MaSP As String = txtmaSP.Text
            Dim xoa As New SqlCommand("delete from Sanpham where Masanpham ='" + MaSP + "'", dung)
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