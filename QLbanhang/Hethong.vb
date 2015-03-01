Public Class frmhethong
    Public tendangnhap As String
    Private Sub frmhethong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            frmdangnhap.ShowDialog()
            If tendangnhap = "admin" Then
                menuquanly.Enabled = True
                menuthongke.Enabled = True
                menudangnhap.Visible = False
                menudangxuat.Visible = True
                lblwelcome.Text = "Welcome" + tendangnhap
            ElseIf tendangnhap = "dung" Then
                menuquanly.Enabled = False
                menuthongke.Enabled = False
                menudangnhap.Visible = False
                menudangxuat.Visible = True
                lblwelcome.Text = "Welcome" + tendangnhap
            End If
        Catch x As Exception
            MessageBox.Show("Lỗi")
        End Try
    End Sub

    Private Sub menudangxuat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menudangxuat.Click
        Try
            menudangnhap.Visible = True
            menudangxuat.Visible = False
            menuthoat.Visible = False
            lblwelcome.Text = "Xin đăng nhập!"
        Catch ex As Exception
            MessageBox.Show("Lỗi")
        End Try
    End Sub

    Private Sub menudangnhap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menudangnhap.Click
        Try
            menudangnhap.Visible = True
            menudangxuat.Visible = False
            menuthoat.Visible = True
            frmdangnhap.ShowDialog()
            If tendangnhap = "admin" Then
                menuquanly.Enabled = True
                menuthongke.Enabled = True
                menudangnhap.Visible = False
                menudangxuat.Visible = True
                lblwelcome.Text = "Welcome" + tendangnhap
            ElseIf tendangnhap = "dung" Then
                menuquanly.Enabled = False
                menuthongke.Enabled = False
                menudangnhap.Visible = False
                menudangxuat.Visible = True
                lblwelcome.Text = "Welcome" + tendangnhap
            End If
        Catch x As Exception
            MessageBox.Show("Lỗi")
        End Try
    End Sub

    Private Sub menuthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuthoat.Click
        menudangnhap.Visible = True
        menudangxuat.Visible = True
        Close()
    End Sub

    Private Sub menuSV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSV.Click
        frmhoadon.ShowDialog()
    End Sub

    Private Sub menudiemSV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menudiemSV.Click
        frmchitiethoadon.ShowDialog()
    End Sub

    Private Sub menuGV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmnhanvien.ShowDialog()
    End Sub

    Private Sub QLLoạiSảnPhẩmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QLLoạiSảnPhẩmToolStripMenuItem.Click
        frmloaisanpham.ShowDialog()
    End Sub

    Private Sub QLSảnPhẩmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QLSảnPhẩmToolStripMenuItem.Click
        frmsanpham.ShowDialog()
    End Sub

    Private Sub QLNhàSảnXuấtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QLNhàSảnXuấtToolStripMenuItem.Click
        frmnhasanxuat.ShowDialog()
    End Sub

    Private Sub menuGV_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuGV.Click
        frmnhanvien.ShowDialog()
    End Sub

    Private Sub QlKháchHàngToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QlKháchHàngToolStripMenuItem.Click
        frmkhachhang.ShowDialog()
    End Sub

    Private Sub TổngDoanhThuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TổngDoanhThuToolStripMenuItem.Click
        frmdoanhthu.ShowDialog()
    End Sub
End Class