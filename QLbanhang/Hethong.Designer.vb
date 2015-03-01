<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhethong
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuhethong = New System.Windows.Forms.ToolStripMenuItem()
        Me.menudangnhap = New System.Windows.Forms.ToolStripMenuItem()
        Me.menudangxuat = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuthoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuquanly = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSV = New System.Windows.Forms.ToolStripMenuItem()
        Me.menudiemSV = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuGV = New System.Windows.Forms.ToolStripMenuItem()
        Me.QlKháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QLSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QLLoạiSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QLNhàSảnXuấtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuthongke = New System.Windows.Forms.ToolStripMenuItem()
        Me.TheoKhoaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TheoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TổngDoanhThuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menukhoa = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCNTT = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuKT = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuNH = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuhethong, Me.menuquanly, Me.menuthongke, Me.menukhoa})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(586, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuhethong
        '
        Me.menuhethong.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menudangnhap, Me.menudangxuat, Me.menuthoat})
        Me.menuhethong.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuhethong.ForeColor = System.Drawing.Color.DarkOrange
        Me.menuhethong.Image = Global.QLbanhang.My.Resources.Resources._1422431314_xfce_system_settings
        Me.menuhethong.Name = "menuhethong"
        Me.menuhethong.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.menuhethong.Size = New System.Drawing.Size(97, 23)
        Me.menuhethong.Text = "Hệ Thống"
        '
        'menudangnhap
        '
        Me.menudangnhap.Name = "menudangnhap"
        Me.menudangnhap.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.menudangnhap.Size = New System.Drawing.Size(195, 24)
        Me.menudangnhap.Text = "Đăng nhập"
        '
        'menudangxuat
        '
        Me.menudangxuat.Name = "menudangxuat"
        Me.menudangxuat.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.menudangxuat.Size = New System.Drawing.Size(195, 24)
        Me.menudangxuat.Text = "Đăng xuất"
        '
        'menuthoat
        '
        Me.menuthoat.Name = "menuthoat"
        Me.menuthoat.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.menuthoat.Size = New System.Drawing.Size(195, 24)
        Me.menuthoat.Text = "Thoát"
        '
        'menuquanly
        '
        Me.menuquanly.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuSV, Me.menudiemSV, Me.menuGV, Me.QlKháchHàngToolStripMenuItem, Me.QLSảnPhẩmToolStripMenuItem, Me.QLLoạiSảnPhẩmToolStripMenuItem, Me.QLNhàSảnXuấtToolStripMenuItem})
        Me.menuquanly.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuquanly.ForeColor = System.Drawing.Color.DarkOrange
        Me.menuquanly.Image = Global.QLbanhang.My.Resources.Resources._1422431235_Admin
        Me.menuquanly.Name = "menuquanly"
        Me.menuquanly.Size = New System.Drawing.Size(84, 23)
        Me.menuquanly.Text = "Quản lý"
        '
        'menuSV
        '
        Me.menuSV.Name = "menuSV"
        Me.menuSV.Size = New System.Drawing.Size(209, 24)
        Me.menuSV.Text = "QL Hóa Đơn"
        '
        'menudiemSV
        '
        Me.menudiemSV.Name = "menudiemSV"
        Me.menudiemSV.Size = New System.Drawing.Size(209, 24)
        Me.menudiemSV.Text = "QL Chi Tiết Hóa Đơn"
        '
        'menuGV
        '
        Me.menuGV.Name = "menuGV"
        Me.menuGV.Size = New System.Drawing.Size(209, 24)
        Me.menuGV.Text = "QL Nhân Viên"
        '
        'QlKháchHàngToolStripMenuItem
        '
        Me.QlKháchHàngToolStripMenuItem.Name = "QlKháchHàngToolStripMenuItem"
        Me.QlKháchHàngToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.QlKháchHàngToolStripMenuItem.Text = "Ql Khách Hàng"
        '
        'QLSảnPhẩmToolStripMenuItem
        '
        Me.QLSảnPhẩmToolStripMenuItem.Name = "QLSảnPhẩmToolStripMenuItem"
        Me.QLSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.QLSảnPhẩmToolStripMenuItem.Text = "QL Sản Phẩm"
        '
        'QLLoạiSảnPhẩmToolStripMenuItem
        '
        Me.QLLoạiSảnPhẩmToolStripMenuItem.Name = "QLLoạiSảnPhẩmToolStripMenuItem"
        Me.QLLoạiSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.QLLoạiSảnPhẩmToolStripMenuItem.Text = "QL Loại Sản Phẩm"
        '
        'QLNhàSảnXuấtToolStripMenuItem
        '
        Me.QLNhàSảnXuấtToolStripMenuItem.Name = "QLNhàSảnXuấtToolStripMenuItem"
        Me.QLNhàSảnXuấtToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.QLNhàSảnXuấtToolStripMenuItem.Text = "QL Nhà Sản Xuất"
        '
        'menuthongke
        '
        Me.menuthongke.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TheoKhoaToolStripMenuItem, Me.TheoToolStripMenuItem, Me.TổngDoanhThuToolStripMenuItem})
        Me.menuthongke.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuthongke.ForeColor = System.Drawing.Color.DarkOrange
        Me.menuthongke.Name = "menuthongke"
        Me.menuthongke.Size = New System.Drawing.Size(82, 23)
        Me.menuthongke.Text = "Thống Kê"
        '
        'TheoKhoaToolStripMenuItem
        '
        Me.TheoKhoaToolStripMenuItem.Name = "TheoKhoaToolStripMenuItem"
        Me.TheoKhoaToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.TheoKhoaToolStripMenuItem.Text = "Số Khách hàng"
        '
        'TheoToolStripMenuItem
        '
        Me.TheoToolStripMenuItem.Name = "TheoToolStripMenuItem"
        Me.TheoToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.TheoToolStripMenuItem.Text = "Số lượng hóa đơn"
        '
        'TổngDoanhThuToolStripMenuItem
        '
        Me.TổngDoanhThuToolStripMenuItem.Name = "TổngDoanhThuToolStripMenuItem"
        Me.TổngDoanhThuToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.TổngDoanhThuToolStripMenuItem.Text = "Tổng doanh thu"
        '
        'menukhoa
        '
        Me.menukhoa.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCNTT, Me.menuKT, Me.menuNH})
        Me.menukhoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menukhoa.ForeColor = System.Drawing.Color.DarkOrange
        Me.menukhoa.Name = "menukhoa"
        Me.menukhoa.Size = New System.Drawing.Size(68, 23)
        Me.menukhoa.Text = "Tin Tức"
        '
        'menuCNTT
        '
        Me.menuCNTT.Name = "menuCNTT"
        Me.menuCNTT.Size = New System.Drawing.Size(148, 24)
        Me.menuCNTT.Text = "Công nghệ"
        '
        'menuKT
        '
        Me.menuKT.Name = "menuKT"
        Me.menuKT.Size = New System.Drawing.Size(148, 24)
        Me.menuKT.Text = "Trong nước"
        '
        'menuNH
        '
        Me.menuNH.Name = "menuNH"
        Me.menuNH.Size = New System.Drawing.Size(148, 24)
        Me.menuNH.Text = "Thế giới"
        '
        'lblwelcome
        '
        Me.lblwelcome.AutoSize = True
        Me.lblwelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwelcome.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblwelcome.Location = New System.Drawing.Point(383, 4)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(66, 16)
        Me.lblwelcome.TabIndex = 2
        Me.lblwelcome.Text = "Welcome"
        '
        'frmhethong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QLbanhang.My.Resources.Resources.banhangonline
        Me.ClientSize = New System.Drawing.Size(586, 313)
        Me.Controls.Add(Me.lblwelcome)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmhethong"
        Me.Text = "Hệ thống"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuhethong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menudangnhap As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menudangxuat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuthoat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuquanly As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSV As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menudiemSV As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuGV As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuthongke As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TheoKhoaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TheoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menukhoa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCNTT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuKT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuNH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblwelcome As System.Windows.Forms.Label
    Friend WithEvents QlKháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QLSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QLLoạiSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QLNhàSảnXuấtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TổngDoanhThuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
