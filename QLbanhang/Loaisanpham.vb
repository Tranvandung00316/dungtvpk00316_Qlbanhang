Imports System.Data
Imports System.Data.SqlClient
Public Class frmloaisanpham
    Dim dung As New SqlConnection("workstation id=QLbandang.mssql.somee.com;packet size=4096;user id=dungtvpk00316;pwd=27020106;data source=QLbandang.mssql.somee.com;persist security info=False;initial catalog=QLbandang")
    Private Sub loaddatabase()
        dung.Open()
        Dim load As New SqlCommand("select * from Loaisanpham", dung)
        Dim sqldata As New SqlDataAdapter(load)
        Dim sqldatatabel As New DataTable
        sqldata.Fill(sqldatatabel)
        dung.Close()
        lsvbang.Items.Clear()
        Dim a As Integer
        For Each Row As DataRow In sqldatatabel.Rows
            lsvbang.Items.Add(Row("Maloaisanpham").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Tensanpham").ToString())
            lsvbang.Items(a).SubItems.Add(Row("Manhasanxuat").ToString())
            a += 1
        Next
    End Sub

    Private Sub btnthem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthem.Click
        Try
            dung.Open()
            Dim Ma As String = txmaLSP.Text
            Dim Ten As String = txtTenLSP.Text
            Dim MaNSX As String = txtmaNSX.Text
            Dim them As New SqlCommand("Insert into Loaisanpham(Maloaisanpham,Tensanpham,Manhasanxuat) values('" + Ma + "' , N'" + Ten + "', '" + MaNSX + "')", dung)
            them.ExecuteNonQuery()
            dung.Close()
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loaddatabase()
        Catch ex As Exception
            MessageBox.Show("Thêm Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dung.Close()
        End Try
    End Sub

    Private Sub lsvbang_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvbang.SelectedIndexChanged
        If lsvbang.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lsvbang.SelectedItems
                txmaLSP.Text = lis.SubItems(0).Text
                txtTenLSP.Text = lis.SubItems(1).Text
                txtmaNSX.Text = lis.SubItems(2).Text
            Next
        End If
    End Sub

    Private Sub btnxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxoa.Click
        Try
            dung.Open()
            Dim MaLSP As String = txmaLSP.Text
            Dim xoa As New SqlCommand("delete from Loaisanpham where Maloaisanpham ='" + MaLSP + "'", dung)
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

    Private Sub btnsua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsua.Click
        Try
            dung.Open()
            Dim MaLSP As String = txmaLSP.Text
            Dim TenLSP As String = txtTenLSP.Text
            Dim MaNSX As String = txtmaNSX.Text
            Dim sua As New SqlCommand("update Loaisanpham set Tensanpham = N'" + TenLSP + "', Manhasanxuat = '" + MaNSX + "' where Maloaisanpham = '" + MaLSP + "'", dung)
            sua.ExecuteNonQuery()
            dung.Close()
            MessageBox.Show("Sũa đã thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question)
            loaddatabase()
        Catch ex As Exception
            MessageBox.Show("Sữa Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dung.Close()
        End Try
    End Sub

    Private Sub btnhuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhuy.Click
        txmaLSP.Text = ""
        txtTenLSP.Text = ""
        txtmaNSX.Text = ""
    End Sub

    Private Sub btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthoat.Click
        If (MessageBox.Show("Có chắc là bạn muốn thoát hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Me.Close()
            Global.System.Windows.Forms.Application.Exit()
        End If
    End Sub

    Private Sub btnluu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnluu.Click
        loaddatabase()
    End Sub

    Private Sub frmloaisanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddatabase()
    End Sub
End Class