<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsanpham
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txttimkiem = New System.Windows.Forms.TextBox()
        Me.txtmaSP = New System.Windows.Forms.TextBox()
        Me.lbldiachi = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblngaysinh = New System.Windows.Forms.Label()
        Me.lblmaSP = New System.Windows.Forms.Label()
        Me.txtgia = New System.Windows.Forms.TextBox()
        Me.txtMaLSP = New System.Windows.Forms.TextBox()
        Me.lblsdt = New System.Windows.Forms.Label()
        Me.lbltenSP = New System.Windows.Forms.Label()
        Me.lbltCMND = New System.Windows.Forms.Label()
        Me.txtmota = New System.Windows.Forms.TextBox()
        Me.TxtnhaSX = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.lsvbang = New System.Windows.Forms.ListView()
        Me.clnmaSP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clntenSP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnnhasanxuat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnMaLSP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnmota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clngia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnhuy = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnluu = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txttimkiem)
        Me.GroupBox1.Controls.Add(Me.txtmaSP)
        Me.GroupBox1.Controls.Add(Me.lbldiachi)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblngaysinh)
        Me.GroupBox1.Controls.Add(Me.lblmaSP)
        Me.GroupBox1.Controls.Add(Me.txtgia)
        Me.GroupBox1.Controls.Add(Me.txtMaLSP)
        Me.GroupBox1.Controls.Add(Me.lblsdt)
        Me.GroupBox1.Controls.Add(Me.lbltenSP)
        Me.GroupBox1.Controls.Add(Me.lbltCMND)
        Me.GroupBox1.Controls.Add(Me.txtmota)
        Me.GroupBox1.Controls.Add(Me.TxtnhaSX)
        Me.GroupBox1.Controls.Add(Me.txtTenSP)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox1.Location = New System.Drawing.Point(1, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(808, 134)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin sản phẩm"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QLbanhang.My.Resources.Resources._1422429758_Item_3D_64
        Me.PictureBox1.Location = New System.Drawing.Point(611, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 83)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'txttimkiem
        '
        Me.txttimkiem.Location = New System.Drawing.Point(91, 100)
        Me.txttimkiem.Name = "txttimkiem"
        Me.txttimkiem.Size = New System.Drawing.Size(142, 20)
        Me.txttimkiem.TabIndex = 2
        '
        'txtmaSP
        '
        Me.txtmaSP.Location = New System.Drawing.Point(91, 26)
        Me.txtmaSP.Name = "txtmaSP"
        Me.txtmaSP.Size = New System.Drawing.Size(142, 20)
        Me.txtmaSP.TabIndex = 2
        '
        'lbldiachi
        '
        Me.lbldiachi.AutoSize = True
        Me.lbldiachi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiachi.ForeColor = System.Drawing.Color.Blue
        Me.lbldiachi.Location = New System.Drawing.Point(265, 104)
        Me.lbldiachi.Name = "lbldiachi"
        Me.lbldiachi.Size = New System.Drawing.Size(38, 15)
        Me.lbldiachi.TabIndex = 1
        Me.lbldiachi.Text = "Mô tả"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(27, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tim kiếm"
        '
        'lblngaysinh
        '
        Me.lblngaysinh.AutoSize = True
        Me.lblngaysinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblngaysinh.ForeColor = System.Drawing.Color.Blue
        Me.lblngaysinh.Location = New System.Drawing.Point(256, 65)
        Me.lblngaysinh.Name = "lblngaysinh"
        Me.lblngaysinh.Size = New System.Drawing.Size(49, 15)
        Me.lblngaysinh.TabIndex = 1
        Me.lblngaysinh.Text = "Nhà SX"
        '
        'lblmaSP
        '
        Me.lblmaSP.AutoSize = True
        Me.lblmaSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmaSP.ForeColor = System.Drawing.Color.Blue
        Me.lblmaSP.Location = New System.Drawing.Point(41, 26)
        Me.lblmaSP.Name = "lblmaSP"
        Me.lblmaSP.Size = New System.Drawing.Size(44, 15)
        Me.lblmaSP.TabIndex = 1
        Me.lblmaSP.Text = "Mã SP"
        '
        'txtgia
        '
        Me.txtgia.Location = New System.Drawing.Point(584, 100)
        Me.txtgia.Name = "txtgia"
        Me.txtgia.Size = New System.Drawing.Size(183, 20)
        Me.txtgia.TabIndex = 2
        '
        'txtMaLSP
        '
        Me.txtMaLSP.Location = New System.Drawing.Point(91, 64)
        Me.txtMaLSP.Name = "txtMaLSP"
        Me.txtMaLSP.Size = New System.Drawing.Size(142, 20)
        Me.txtMaLSP.TabIndex = 2
        '
        'lblsdt
        '
        Me.lblsdt.AutoSize = True
        Me.lblsdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsdt.ForeColor = System.Drawing.Color.Blue
        Me.lblsdt.Location = New System.Drawing.Point(34, 65)
        Me.lblsdt.Name = "lblsdt"
        Me.lblsdt.Size = New System.Drawing.Size(51, 15)
        Me.lblsdt.TabIndex = 1
        Me.lblsdt.Text = "Mã LSP"
        '
        'lbltenSP
        '
        Me.lbltenSP.AutoSize = True
        Me.lbltenSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltenSP.ForeColor = System.Drawing.Color.Blue
        Me.lbltenSP.Location = New System.Drawing.Point(256, 27)
        Me.lbltenSP.Name = "lbltenSP"
        Me.lbltenSP.Size = New System.Drawing.Size(47, 15)
        Me.lbltenSP.TabIndex = 1
        Me.lbltenSP.Text = "Tên SP"
        '
        'lbltCMND
        '
        Me.lbltCMND.AutoSize = True
        Me.lbltCMND.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltCMND.ForeColor = System.Drawing.Color.Blue
        Me.lbltCMND.Location = New System.Drawing.Point(552, 101)
        Me.lbltCMND.Name = "lbltCMND"
        Me.lbltCMND.Size = New System.Drawing.Size(26, 15)
        Me.lbltCMND.TabIndex = 1
        Me.lbltCMND.Text = "Giá"
        '
        'txtmota
        '
        Me.txtmota.Location = New System.Drawing.Point(320, 100)
        Me.txtmota.Name = "txtmota"
        Me.txtmota.Size = New System.Drawing.Size(220, 20)
        Me.txtmota.TabIndex = 2
        '
        'TxtnhaSX
        '
        Me.TxtnhaSX.Location = New System.Drawing.Point(320, 64)
        Me.TxtnhaSX.Name = "TxtnhaSX"
        Me.TxtnhaSX.Size = New System.Drawing.Size(220, 20)
        Me.TxtnhaSX.TabIndex = 2
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(320, 26)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(220, 20)
        Me.txtTenSP.TabIndex = 2
        '
        'lsvbang
        '
        Me.lsvbang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvbang.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clnmaSP, Me.clntenSP, Me.clnnhasanxuat, Me.clnMaLSP, Me.clnmota, Me.clngia})
        Me.lsvbang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvbang.ForeColor = System.Drawing.Color.ForestGreen
        Me.lsvbang.FullRowSelect = True
        Me.lsvbang.GridLines = True
        Me.lsvbang.LabelEdit = True
        Me.lsvbang.Location = New System.Drawing.Point(8, 19)
        Me.lsvbang.Name = "lsvbang"
        Me.lsvbang.Size = New System.Drawing.Size(792, 278)
        Me.lsvbang.TabIndex = 9
        Me.lsvbang.UseCompatibleStateImageBehavior = False
        Me.lsvbang.View = System.Windows.Forms.View.Details
        '
        'clnmaSP
        '
        Me.clnmaSP.Text = "Mã SP"
        Me.clnmaSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clnmaSP.Width = 86
        '
        'clntenSP
        '
        Me.clntenSP.Text = "Tên SP"
        Me.clntenSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clntenSP.Width = 165
        '
        'clnnhasanxuat
        '
        Me.clnnhasanxuat.Text = "Nhà sản xuất"
        Me.clnnhasanxuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clnnhasanxuat.Width = 152
        '
        'clnMaLSP
        '
        Me.clnMaLSP.Text = "Mã LSP"
        Me.clnMaLSP.Width = 101
        '
        'clnmota
        '
        Me.clnmota.Text = "Mô tả"
        Me.clnmota.Width = 164
        '
        'clngia
        '
        Me.clngia.Text = "Giá"
        Me.clngia.Width = 124
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnthoat)
        Me.GroupBox2.Controls.Add(Me.btnthem)
        Me.GroupBox2.Controls.Add(Me.btnhuy)
        Me.GroupBox2.Controls.Add(Me.btnsua)
        Me.GroupBox2.Controls.Add(Me.btnluu)
        Me.GroupBox2.Controls.Add(Me.btnxoa)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox2.Location = New System.Drawing.Point(9, 491)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(777, 68)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức năng"
        '
        'btnthoat
        '
        Me.btnthoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthoat.ForeColor = System.Drawing.Color.Crimson
        Me.btnthoat.Location = New System.Drawing.Point(637, 19)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnthoat.Size = New System.Drawing.Size(79, 34)
        Me.btnthoat.TabIndex = 3
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthem.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnthem.Location = New System.Drawing.Point(65, 18)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(80, 34)
        Me.btnthem.TabIndex = 3
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnhuy
        '
        Me.btnhuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhuy.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnhuy.Location = New System.Drawing.Point(529, 19)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(79, 34)
        Me.btnhuy.TabIndex = 3
        Me.btnhuy.Text = "Hủy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsua.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnsua.Location = New System.Drawing.Point(178, 19)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(79, 34)
        Me.btnsua.TabIndex = 3
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnluu
        '
        Me.btnluu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnluu.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnluu.Location = New System.Drawing.Point(414, 19)
        Me.btnluu.Name = "btnluu"
        Me.btnluu.Size = New System.Drawing.Size(79, 34)
        Me.btnluu.TabIndex = 3
        Me.btnluu.Text = "Lưu"
        Me.btnluu.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxoa.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnxoa.Location = New System.Drawing.Point(293, 19)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(79, 34)
        Me.btnxoa.TabIndex = 3
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lsvbang)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox4.Location = New System.Drawing.Point(1, 167)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(808, 318)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Bảng chi tiết"
        '
        'frmsanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 571)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "frmsanpham"
        Me.Text = "Sản phẩm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txttimkiem As System.Windows.Forms.TextBox
    Friend WithEvents txtmaSP As System.Windows.Forms.TextBox
    Friend WithEvents lbldiachi As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblngaysinh As System.Windows.Forms.Label
    Friend WithEvents lblmaSP As System.Windows.Forms.Label
    Friend WithEvents txtgia As System.Windows.Forms.TextBox
    Friend WithEvents txtMaLSP As System.Windows.Forms.TextBox
    Friend WithEvents lblsdt As System.Windows.Forms.Label
    Friend WithEvents lbltenSP As System.Windows.Forms.Label
    Friend WithEvents lbltCMND As System.Windows.Forms.Label
    Friend WithEvents txtmota As System.Windows.Forms.TextBox
    Friend WithEvents TxtnhaSX As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSP As System.Windows.Forms.TextBox
    Friend WithEvents lsvbang As System.Windows.Forms.ListView
    Friend WithEvents clnmaSP As System.Windows.Forms.ColumnHeader
    Friend WithEvents clntenSP As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnnhasanxuat As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnMaLSP As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnmota As System.Windows.Forms.ColumnHeader
    Friend WithEvents clngia As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnhuy As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnluu As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
