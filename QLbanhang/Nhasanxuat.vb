Imports System.Data
Imports System.Data.SqlClient
Public Class frmnhasanxuat
    Dim dung As New SqlConnection("workstation id=QLbandang.mssql.somee.com;packet size=4096;user id=dungtvpk00316;pwd=27020106;data source=QLbandang.mssql.somee.com;persist security info=False;initial catalog=QLbandang")
    Private Sub loaddatabase()
        Try
            dung.Open()
            Dim load As New SqlCommand("select * from Nhasanxuat", dung)
            Dim sqldata As New SqlDataAdapter(load)
            Dim sqldatatabel As New DataTable
            sqldata.Fill(sqldatatabel)
            dung.Close()
            lsvbang.Items.Clear()
            Dim a As Integer
            For Each Row As DataRow In sqldatatabel.Rows
                lsvbang.Items.Add(Row("Manhasanxuat").ToString())
                lsvbang.Items(a).SubItems.Add(Row("Tennhasanxuat").ToString())
                lsvbang.Items(a).SubItems.Add(Row("Diachi").ToString())
                a += 1
            Next
        Catch ex As Exception
            If (MessageBox.Show("Kết nối không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error) = Windows.Forms.DialogResult.OK) Then
                Me.Close()
                Global.System.Windows.Forms.Application.Exit()
            End If
        End Try
    End Sub

    Private Sub frmnhasanxuat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddatabase()
    End Sub

    Private Sub lsvbang_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvbang.SelectedIndexChanged
        If lsvbang.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lsvbang.SelectedItems
                txtNSX.Text = lis.SubItems(0).Text
                txttenNSX.Text = lis.SubItems(1).Text
                txtdiachi.Text = lis.SubItems(2).Text
            Next
        End If
    End Sub

    Private Sub btnthem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthem.Click
        Try
            dung.Open()
            Dim Ma As String = txtNSX.Text
            Dim Ten As String = txttenNSX.Text
            Dim Dia As String = txtdiachi.Text
            Dim them As New SqlCommand("Insert into Nhasanxuat(Manhasanxuat,Tennhasanxuat,Diachi) values('" + Ma + "' , N'" + Ten + "', N'" + Dia + "')", dung)
            them.ExecuteNonQuery()
            dung.Close()
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loaddatabase()
        Catch ex As Exception
            MessageBox.Show("Thêm Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dung.Close()

        End Try
    End Sub

    Private Sub btnluu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnluu.Click
        loaddatabase()
    End Sub

    Private Sub btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthoat.Click
        If (MessageBox.Show("Có chắc là bạn muốn thoát hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Me.Close()
            Global.System.Windows.Forms.Application.Exit()
        End If
    End Sub

    Private Sub btnxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxoa.Click
        Try
            dung.Open()
            Dim MaNSX As String = txtNSX.Text
            Dim xoa As New SqlCommand("delete from Nhasanxuat where Manhasanxuat ='" + MaNSX + "'", dung)
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
            Dim MaNSX As String = txtNSX.Text
            Dim TenNSX As String = txttenNSX.Text
            Dim Diachi As String = txtdiachi.Text
            Dim sua As New SqlCommand("update Nhasanxuat set Tennhasanxuat = N'" + TenNSX + "', Diachi = N'" + Diachi + "' where  Manhasanxuat = '" + MaNSX + "'", dung)
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
        txtNSX.Text = ""
        txtdiachi.Text = ""
        txttenNSX.Text = ""
    End Sub
End Class