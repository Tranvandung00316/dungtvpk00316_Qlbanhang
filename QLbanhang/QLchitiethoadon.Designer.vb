<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmchitiethoadon
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnhuy = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnluu = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.lsvbang = New System.Windows.Forms.ListView()
        Me.clnmaCTHD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnMaHD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnMaSP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClnSP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClntenkH = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnsoluong = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clngia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnngaynhap = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnngayxuat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnTonggia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxttenKH = New System.Windows.Forms.TextBox()
        Me.txttenSP = New System.Windows.Forms.TextBox()
        Me.TxtmaHD = New System.Windows.Forms.TextBox()
        Me.txtmaCTHD = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbnMaHD = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMaCTHD = New System.Windows.Forms.Label()
        Me.txtmaSP = New System.Windows.Forms.TextBox()
        Me.lblsdt = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Lbgia = New System.Windows.Forms.Label()
        Me.lblhoSV = New System.Windows.Forms.Label()
        Me.txtTG = New System.Windows.Forms.TextBox()
        Me.txtgia = New System.Windows.Forms.TextBox()
        Me.txtSL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtnnX = New System.Windows.Forms.DateTimePicker()
        Me.dtnn = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnthoat)
        Me.GroupBox2.Controls.Add(Me.btnthem)
        Me.GroupBox2.Controls.Add(Me.btnhuy)
        Me.GroupBox2.Controls.Add(Me.btnsua)
        Me.GroupBox2.Controls.Add(Me.btnxoa)
        Me.GroupBox2.Controls.Add(Me.btnluu)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox2.Location = New System.Drawing.Point(953, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(85, 331)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức năng"
        '
        'btnthoat
        '
        Me.btnthoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthoat.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnthoat.Location = New System.Drawing.Point(6, 269)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(68, 32)
        Me.btnthoat.TabIndex = 8
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthem.ForeColor = System.Drawing.Color.Navy
        Me.btnthem.Location = New System.Drawing.Point(6, 28)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(68, 32)
        Me.btnthem.TabIndex = 4
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnhuy
        '
        Me.btnhuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhuy.ForeColor = System.Drawing.Color.Navy
        Me.btnhuy.Location = New System.Drawing.Point(6, 219)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(68, 32)
        Me.btnhuy.TabIndex = 9
        Me.btnhuy.Text = "Hủy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsua.ForeColor = System.Drawing.Color.Navy
        Me.btnsua.Location = New System.Drawing.Point(6, 77)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(68, 32)
        Me.btnsua.TabIndex = 6
        Me.btnsua.Text = "Sữa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxoa.ForeColor = System.Drawing.Color.Navy
        Me.btnxoa.Location = New System.Drawing.Point(6, 124)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(68, 32)
        Me.btnxoa.TabIndex = 5
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnluu
        '
        Me.btnluu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnluu.ForeColor = System.Drawing.Color.Navy
        Me.btnluu.Location = New System.Drawing.Point(6, 171)
        Me.btnluu.Name = "btnluu"
        Me.btnluu.Size = New System.Drawing.Size(68, 32)
        Me.btnluu.TabIndex = 7
        Me.btnluu.Text = "Lưu"
        Me.btnluu.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnprint.Location = New System.Drawing.Point(875, 83)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(75, 34)
        Me.btnprint.TabIndex = 17
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'lsvbang
        '
        Me.lsvbang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvbang.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clnmaCTHD, Me.clnMaHD, Me.clnMaSP, Me.ClnSP, Me.ClntenkH, Me.clnsoluong, Me.clngia, Me.clnngaynhap, Me.clnngayxuat, Me.clnTonggia})
        Me.lsvbang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvbang.ForeColor = System.Drawing.Color.ForestGreen
        Me.lsvbang.FullRowSelect = True
        Me.lsvbang.GridLines = True
        Me.lsvbang.LabelEdit = True
        Me.lsvbang.Location = New System.Drawing.Point(-2, 160)
        Me.lsvbang.Name = "lsvbang"
        Me.lsvbang.Size = New System.Drawing.Size(949, 342)
        Me.lsvbang.TabIndex = 14
        Me.lsvbang.UseCompatibleStateImageBehavior = False
        Me.lsvbang.View = System.Windows.Forms.View.Details
        '
        'clnmaCTHD
        '
        Me.clnmaCTHD.Text = "Mã CTHD"
        Me.clnmaCTHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clnmaCTHD.Width = 69
        '
        'clnMaHD
        '
        Me.clnMaHD.Text = "Mã HD"
        Me.clnMaHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clnMaHD.Width = 74
        '
        'clnMaSP
        '
        Me.clnMaSP.Text = "Mã SP"
        Me.clnMaSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clnMaSP.Width = 76
        '
        'ClnSP
        '
        Me.ClnSP.Text = "Tên SP"
        Me.ClnSP.Width = 111
        '
        'ClntenkH
        '
        Me.ClntenkH.Text = "Tên KH"
        Me.ClntenkH.Width = 137
        '
        'clnsoluong
        '
        Me.clnsoluong.Text = "Số Lượng"
        Me.clnsoluong.Width = 67
        '
        'clngia
        '
        Me.clngia.Text = "Giá"
        Me.clngia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clngia.Width = 81
        '
        'clnngaynhap
        '
        Me.clnngaynhap.Text = "Ngày nhập"
        Me.clnngaynhap.Width = 107
        '
        'clnngayxuat
        '
        Me.clnngayxuat.Text = "Ngày xuất"
        Me.clnngayxuat.Width = 104
        '
        'clnTonggia
        '
        Me.clnTonggia.Text = "Tổng giá"
        Me.clnTonggia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clnTonggia.Width = 117
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dtnn)
        Me.GroupBox1.Controls.Add(Me.dtnnX)
        Me.GroupBox1.Controls.Add(Me.btnprint)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.TxttenKH)
        Me.GroupBox1.Controls.Add(Me.txttenSP)
        Me.GroupBox1.Controls.Add(Me.TxtmaHD)
        Me.GroupBox1.Controls.Add(Me.txtmaCTHD)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lbnMaHD)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblMaCTHD)
        Me.GroupBox1.Controls.Add(Me.txtmaSP)
        Me.GroupBox1.Controls.Add(Me.lblsdt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Lbgia)
        Me.GroupBox1.Controls.Add(Me.lblhoSV)
        Me.GroupBox1.Controls.Add(Me.txtTG)
        Me.GroupBox1.Controls.Add(Me.txtgia)
        Me.GroupBox1.Controls.Add(Me.txtSL)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox1.Location = New System.Drawing.Point(12, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1017, 117)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin hóa đơn"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QLbanhang.My.Resources.Resources._1422390839_print
        Me.PictureBox1.Location = New System.Drawing.Point(875, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 59)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'TxttenKH
        '
        Me.TxttenKH.Location = New System.Drawing.Point(291, 54)
        Me.TxttenKH.Name = "TxttenKH"
        Me.TxttenKH.Size = New System.Drawing.Size(254, 20)
        Me.TxttenKH.TabIndex = 2
        '
        'txttenSP
        '
        Me.txttenSP.Location = New System.Drawing.Point(291, 26)
        Me.txttenSP.Name = "txttenSP"
        Me.txttenSP.Size = New System.Drawing.Size(254, 20)
        Me.txttenSP.TabIndex = 2
        '
        'TxtmaHD
        '
        Me.TxtmaHD.Location = New System.Drawing.Point(85, 87)
        Me.TxtmaHD.Name = "TxtmaHD"
        Me.TxtmaHD.Size = New System.Drawing.Size(114, 20)
        Me.TxtmaHD.TabIndex = 2
        '
        'txtmaCTHD
        '
        Me.txtmaCTHD.Location = New System.Drawing.Point(85, 26)
        Me.txtmaCTHD.Name = "txtmaCTHD"
        Me.txtmaCTHD.Size = New System.Drawing.Size(114, 20)
        Me.txtmaCTHD.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(567, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Ngày nhập"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(229, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên KH"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(568, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Ngày xuất"
        '
        'lbnMaHD
        '
        Me.lbnMaHD.AutoSize = True
        Me.lbnMaHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbnMaHD.ForeColor = System.Drawing.Color.Blue
        Me.lbnMaHD.Location = New System.Drawing.Point(29, 88)
        Me.lbnMaHD.Name = "lbnMaHD"
        Me.lbnMaHD.Size = New System.Drawing.Size(46, 15)
        Me.lbnMaHD.TabIndex = 1
        Me.lbnMaHD.Text = "Mã HD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(229, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tên SP"
        '
        'lblMaCTHD
        '
        Me.lblMaCTHD.AutoSize = True
        Me.lblMaCTHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaCTHD.ForeColor = System.Drawing.Color.Blue
        Me.lblMaCTHD.Location = New System.Drawing.Point(14, 28)
        Me.lblMaCTHD.Name = "lblMaCTHD"
        Me.lblMaCTHD.Size = New System.Drawing.Size(61, 15)
        Me.lblMaCTHD.TabIndex = 1
        Me.lblMaCTHD.Text = "Mã CTHD"
        '
        'txtmaSP
        '
        Me.txtmaSP.Location = New System.Drawing.Point(85, 58)
        Me.txtmaSP.Name = "txtmaSP"
        Me.txtmaSP.Size = New System.Drawing.Size(114, 20)
        Me.txtmaSP.TabIndex = 2
        '
        'lblsdt
        '
        Me.lblsdt.AutoSize = True
        Me.lblsdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsdt.ForeColor = System.Drawing.Color.Blue
        Me.lblsdt.Location = New System.Drawing.Point(31, 59)
        Me.lblsdt.Name = "lblsdt"
        Me.lblsdt.Size = New System.Drawing.Size(44, 15)
        Me.lblsdt.TabIndex = 1
        Me.lblsdt.Text = "Mã SP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(574, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Tổng giá"
        '
        'Lbgia
        '
        Me.Lbgia.AutoSize = True
        Me.Lbgia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbgia.ForeColor = System.Drawing.Color.Blue
        Me.Lbgia.Location = New System.Drawing.Point(394, 88)
        Me.Lbgia.Name = "Lbgia"
        Me.Lbgia.Size = New System.Drawing.Size(26, 15)
        Me.Lbgia.TabIndex = 1
        Me.Lbgia.Text = "Giá"
        '
        'lblhoSV
        '
        Me.lblhoSV.AutoSize = True
        Me.lblhoSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhoSV.ForeColor = System.Drawing.Color.Blue
        Me.lblhoSV.Location = New System.Drawing.Point(220, 87)
        Me.lblhoSV.Name = "lblhoSV"
        Me.lblhoSV.Size = New System.Drawing.Size(56, 15)
        Me.lblhoSV.TabIndex = 1
        Me.lblhoSV.Text = "Số lượng"
        '
        'txtTG
        '
        Me.txtTG.Location = New System.Drawing.Point(644, 87)
        Me.txtTG.Name = "txtTG"
        Me.txtTG.Size = New System.Drawing.Size(125, 20)
        Me.txtTG.TabIndex = 2
        '
        'txtgia
        '
        Me.txtgia.Location = New System.Drawing.Point(426, 88)
        Me.txtgia.Name = "txtgia"
        Me.txtgia.Size = New System.Drawing.Size(119, 20)
        Me.txtgia.TabIndex = 2
        '
        'txtSL
        '
        Me.txtSL.Location = New System.Drawing.Point(291, 86)
        Me.txtSL.Name = "txtSL"
        Me.txtSL.Size = New System.Drawing.Size(70, 20)
        Me.txtSL.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(436, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "QUẢN LÝ CHI TIẾT HÓA ĐƠN"
        '
        'dtnnX
        '
        Me.dtnnX.CustomFormat = "dd /MM/yy"
        Me.dtnnX.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtnnX.Location = New System.Drawing.Point(645, 27)
        Me.dtnnX.Name = "dtnnX"
        Me.dtnnX.Size = New System.Drawing.Size(141, 20)
        Me.dtnnX.TabIndex = 18
        Me.dtnnX.TabStop = False
        Me.dtnnX.Value = New Date(2014, 6, 8, 0, 0, 0, 0)
        '
        'dtnn
        '
        Me.dtnn.CustomFormat = "dd /MM/yy"
        Me.dtnn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtnn.Location = New System.Drawing.Point(644, 55)
        Me.dtnn.Name = "dtnn"
        Me.dtnn.Size = New System.Drawing.Size(141, 20)
        Me.dtnn.TabIndex = 19
        Me.dtnn.TabStop = False
        Me.dtnn.Value = New Date(2014, 6, 8, 0, 0, 0, 0)
        '
        'frmchitiethoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 503)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lsvbang)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmchitiethoadon"
        Me.Text = "Chi tiết hóa đơn"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnhuy As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnluu As System.Windows.Forms.Button
    Friend WithEvents lsvbang As System.Windows.Forms.ListView
    Friend WithEvents clnmaCTHD As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnMaHD As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnMaSP As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnTonggia As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txttenSP As System.Windows.Forms.TextBox
    Friend WithEvents txtmaCTHD As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblMaCTHD As System.Windows.Forms.Label
    Friend WithEvents txtmaSP As System.Windows.Forms.TextBox
    Friend WithEvents lblsdt As System.Windows.Forms.Label
    Friend WithEvents lblhoSV As System.Windows.Forms.Label
    Friend WithEvents txtSL As System.Windows.Forms.TextBox
    Friend WithEvents TxtmaHD As System.Windows.Forms.TextBox
    Friend WithEvents lbnMaHD As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TxttenKH As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTG As System.Windows.Forms.TextBox
    Friend WithEvents ClnSP As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClntenkH As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnsoluong As System.Windows.Forms.ColumnHeader
    Friend WithEvents clngia As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnngaynhap As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnngayxuat As System.Windows.Forms.ColumnHeader
    Friend WithEvents Lbgia As System.Windows.Forms.Label
    Friend WithEvents txtgia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtnn As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtnnX As System.Windows.Forms.DateTimePicker
End Class
