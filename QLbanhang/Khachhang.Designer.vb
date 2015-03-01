<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkhachhang
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
        Me.dtngaysinh = New System.Windows.Forms.DateTimePicker()
        Me.txttimkiem = New System.Windows.Forms.TextBox()
        Me.txtmaKH = New System.Windows.Forms.TextBox()
        Me.lbldiachi = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblngaysinh = New System.Windows.Forms.Label()
        Me.lblmaNV = New System.Windows.Forms.Label()
        Me.txtCMND = New System.Windows.Forms.TextBox()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.lblsdt = New System.Windows.Forms.Label()
        Me.lblgioitinh = New System.Windows.Forms.Label()
        Me.lblhovatenV = New System.Windows.Forms.Label()
        Me.lbltCMND = New System.Windows.Forms.Label()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txthoten = New System.Windows.Forms.TextBox()
        Me.clnngaysinh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnhovatenNV = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clngioitinh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnmaNV = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnCMND = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clndienthoai = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvbang = New System.Windows.Forms.ListView()
        Me.clndiachi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnhuy = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnluu = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Txtgioitinh = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Txtgioitinh)
        Me.GroupBox1.Controls.Add(Me.dtngaysinh)
        Me.GroupBox1.Controls.Add(Me.txttimkiem)
        Me.GroupBox1.Controls.Add(Me.txtmaKH)
        Me.GroupBox1.Controls.Add(Me.lbldiachi)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblngaysinh)
        Me.GroupBox1.Controls.Add(Me.lblmaNV)
        Me.GroupBox1.Controls.Add(Me.txtCMND)
        Me.GroupBox1.Controls.Add(Me.txtsdt)
        Me.GroupBox1.Controls.Add(Me.lblsdt)
        Me.GroupBox1.Controls.Add(Me.lblgioitinh)
        Me.GroupBox1.Controls.Add(Me.lblhovatenV)
        Me.GroupBox1.Controls.Add(Me.lbltCMND)
        Me.GroupBox1.Controls.Add(Me.txtdiachi)
        Me.GroupBox1.Controls.Add(Me.txthoten)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(772, 141)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin khách hàng"
        '
        'dtngaysinh
        '
        Me.dtngaysinh.CustomFormat = "dd /MM/yy"
        Me.dtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtngaysinh.Location = New System.Drawing.Point(91, 67)
        Me.dtngaysinh.Name = "dtngaysinh"
        Me.dtngaysinh.Size = New System.Drawing.Size(141, 20)
        Me.dtngaysinh.TabIndex = 4
        Me.dtngaysinh.TabStop = False
        Me.dtngaysinh.Value = New Date(2014, 6, 8, 0, 0, 0, 0)
        '
        'txttimkiem
        '
        Me.txttimkiem.Location = New System.Drawing.Point(320, 103)
        Me.txttimkiem.Name = "txttimkiem"
        Me.txttimkiem.Size = New System.Drawing.Size(142, 20)
        Me.txttimkiem.TabIndex = 2
        '
        'txtmaKH
        '
        Me.txtmaKH.Location = New System.Drawing.Point(91, 26)
        Me.txtmaKH.Name = "txtmaKH"
        Me.txtmaKH.Size = New System.Drawing.Size(142, 20)
        Me.txtmaKH.TabIndex = 2
        '
        'lbldiachi
        '
        Me.lbldiachi.AutoSize = True
        Me.lbldiachi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiachi.ForeColor = System.Drawing.Color.Blue
        Me.lbldiachi.Location = New System.Drawing.Point(480, 105)
        Me.lbldiachi.Name = "lbldiachi"
        Me.lbldiachi.Size = New System.Drawing.Size(45, 15)
        Me.lbldiachi.TabIndex = 1
        Me.lbldiachi.Text = "Địa chỉ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(248, 104)
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
        Me.lblngaysinh.Location = New System.Drawing.Point(25, 69)
        Me.lblngaysinh.Name = "lblngaysinh"
        Me.lblngaysinh.Size = New System.Drawing.Size(61, 15)
        Me.lblngaysinh.TabIndex = 1
        Me.lblngaysinh.Text = "Ngày sinh"
        '
        'lblmaNV
        '
        Me.lblmaNV.AutoSize = True
        Me.lblmaNV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmaNV.ForeColor = System.Drawing.Color.Blue
        Me.lblmaNV.Location = New System.Drawing.Point(41, 26)
        Me.lblmaNV.Name = "lblmaNV"
        Me.lblmaNV.Size = New System.Drawing.Size(45, 15)
        Me.lblmaNV.TabIndex = 1
        Me.lblmaNV.Text = "Mã KH"
        '
        'txtCMND
        '
        Me.txtCMND.Location = New System.Drawing.Point(582, 25)
        Me.txtCMND.Name = "txtCMND"
        Me.txtCMND.Size = New System.Drawing.Size(140, 20)
        Me.txtCMND.TabIndex = 2
        '
        'txtsdt
        '
        Me.txtsdt.Location = New System.Drawing.Point(93, 104)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(140, 20)
        Me.txtsdt.TabIndex = 2
        '
        'lblsdt
        '
        Me.lblsdt.AutoSize = True
        Me.lblsdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsdt.ForeColor = System.Drawing.Color.Blue
        Me.lblsdt.Location = New System.Drawing.Point(7, 104)
        Me.lblsdt.Name = "lblsdt"
        Me.lblsdt.Size = New System.Drawing.Size(79, 15)
        Me.lblsdt.TabIndex = 1
        Me.lblsdt.Text = "Số điện thoại"
        '
        'lblgioitinh
        '
        Me.lblgioitinh.AutoSize = True
        Me.lblgioitinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgioitinh.ForeColor = System.Drawing.Color.Blue
        Me.lblgioitinh.Location = New System.Drawing.Point(256, 69)
        Me.lblgioitinh.Name = "lblgioitinh"
        Me.lblgioitinh.Size = New System.Drawing.Size(52, 15)
        Me.lblgioitinh.TabIndex = 1
        Me.lblgioitinh.Text = "Giới tính"
        '
        'lblhovatenV
        '
        Me.lblhovatenV.AutoSize = True
        Me.lblhovatenV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhovatenV.ForeColor = System.Drawing.Color.Blue
        Me.lblhovatenV.Location = New System.Drawing.Point(256, 27)
        Me.lblhovatenV.Name = "lblhovatenV"
        Me.lblhovatenV.Size = New System.Drawing.Size(50, 15)
        Me.lblhovatenV.TabIndex = 1
        Me.lblhovatenV.Text = "Họ & Tên"
        '
        'lbltCMND
        '
        Me.lbltCMND.AutoSize = True
        Me.lbltCMND.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltCMND.ForeColor = System.Drawing.Color.Blue
        Me.lbltCMND.Location = New System.Drawing.Point(532, 27)
        Me.lbltCMND.Name = "lbltCMND"
        Me.lbltCMND.Size = New System.Drawing.Size(44, 15)
        Me.lbltCMND.TabIndex = 1
        Me.lbltCMND.Text = "CMND"
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(535, 103)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(195, 20)
        Me.txtdiachi.TabIndex = 2
        '
        'txthoten
        '
        Me.txthoten.Location = New System.Drawing.Point(320, 26)
        Me.txthoten.Name = "txthoten"
        Me.txthoten.Size = New System.Drawing.Size(195, 20)
        Me.txthoten.TabIndex = 2
        '
        'clnngaysinh
        '
        Me.clnngaysinh.Text = "Ngày Sinh"
        Me.clnngaysinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clnngaysinh.Width = 118
        '
        'clnhovatenNV
        '
        Me.clnhovatenNV.Text = "Tên SV"
        Me.clnhovatenNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clnhovatenNV.Width = 156
        '
        'clngioitinh
        '
        Me.clngioitinh.Text = "Giới Tính"
        Me.clngioitinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clngioitinh.Width = 62
        '
        'clnmaNV
        '
        Me.clnmaNV.Text = "Mã NV"
        Me.clnmaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clnmaNV.Width = 62
        '
        'clnCMND
        '
        Me.clnCMND.Text = "CMND"
        Me.clnCMND.Width = 103
        '
        'clndienthoai
        '
        Me.clndienthoai.Text = "Điện thoai"
        Me.clndienthoai.Width = 119
        '
        'lsvbang
        '
        Me.lsvbang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvbang.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clnmaNV, Me.clnhovatenNV, Me.clnngaysinh, Me.clngioitinh, Me.clndienthoai, Me.clndiachi, Me.clnCMND})
        Me.lsvbang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvbang.ForeColor = System.Drawing.Color.ForestGreen
        Me.lsvbang.FullRowSelect = True
        Me.lsvbang.GridLines = True
        Me.lsvbang.LabelEdit = True
        Me.lsvbang.Location = New System.Drawing.Point(8, 28)
        Me.lsvbang.Name = "lsvbang"
        Me.lsvbang.Size = New System.Drawing.Size(764, 281)
        Me.lsvbang.TabIndex = 0
        Me.lsvbang.UseCompatibleStateImageBehavior = False
        Me.lsvbang.View = System.Windows.Forms.View.Details
        '
        'clndiachi
        '
        Me.clndiachi.Text = "Địa chỉ"
        Me.clndiachi.Width = 137
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
        Me.GroupBox2.Location = New System.Drawing.Point(10, 326)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(766, 65)
        Me.GroupBox2.TabIndex = 6
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
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.lsvbang)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox3.Location = New System.Drawing.Point(12, 159)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(782, 397)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bảng khách hàng"
        '
        'Txtgioitinh
        '
        Me.Txtgioitinh.Location = New System.Drawing.Point(320, 70)
        Me.Txtgioitinh.Name = "Txtgioitinh"
        Me.Txtgioitinh.Size = New System.Drawing.Size(91, 20)
        Me.Txtgioitinh.TabIndex = 5
        '
        'frmkhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 561)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmkhachhang"
        Me.Text = "QL Khách hàng"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtngaysinh As System.Windows.Forms.DateTimePicker
    Friend WithEvents txttimkiem As System.Windows.Forms.TextBox
    Friend WithEvents txtmaKH As System.Windows.Forms.TextBox
    Friend WithEvents lbldiachi As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblngaysinh As System.Windows.Forms.Label
    Friend WithEvents lblmaNV As System.Windows.Forms.Label
    Friend WithEvents txtCMND As System.Windows.Forms.TextBox
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents lblsdt As System.Windows.Forms.Label
    Friend WithEvents lblgioitinh As System.Windows.Forms.Label
    Friend WithEvents lblhovatenV As System.Windows.Forms.Label
    Friend WithEvents lbltCMND As System.Windows.Forms.Label
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txthoten As System.Windows.Forms.TextBox
    Friend WithEvents clnngaysinh As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnhovatenNV As System.Windows.Forms.ColumnHeader
    Friend WithEvents clngioitinh As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnmaNV As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnCMND As System.Windows.Forms.ColumnHeader
    Friend WithEvents clndienthoai As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvbang As System.Windows.Forms.ListView
    Friend WithEvents clndiachi As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnhuy As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnluu As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Txtgioitinh As System.Windows.Forms.TextBox
End Class
