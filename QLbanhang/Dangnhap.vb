Public Class frmdangnhap

    Private Sub btndangnhap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndangnhap.Click
        Try
            If (txtdangnhap.Text = "admin" And txtmatkhau.Text = "123") Then
                MessageBox.Show("Đăng nhập thành công - admin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
                frmhethong.tendangnhap = "admin"
            ElseIf (txtdangnhap.Text = "dung" And txtmatkhau.Text = "111") Then
                MessageBox.Show("Đăng nhập thành công - Sinh viện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
                frmhethong.tendangnhap = "dung"
            Else
                MessageBox.Show("Đăng nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch x As Exception
            MessageBox.Show("Lỗi")
        End Try
    End Sub

    Private Sub btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthoat.Click
        If (MessageBox.Show("Có chắc là bạn muốn thoát hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Me.Close()
            Global.System.Windows.Forms.Application.Exit()
        End If
    End Sub

    Private Sub frmdangnhap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtdangnhap.ResetText()
        txtmatkhau.ResetText()
    End Sub
    Private Sub LinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel.LinkClicked
        Dim webs As String = "http://www.poly.edu.vn/"
        Process.Start(webs)
    End Sub
    Private Sub txtmatkhau_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtmatkhau.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then btndangnhap.PerformClick()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        txtdangnhap.Text = "admin"
        txtmatkhau.Text = "123"
    End Sub
End Class
