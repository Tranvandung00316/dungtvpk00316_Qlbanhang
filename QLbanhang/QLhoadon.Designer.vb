<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhoadon
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtmaKH = New System.Windows.Forms.TextBox()
        Me.txtmaHD = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblmaSV = New System.Windows.Forms.Label()
        Me.txtmaNV = New System.Windows.Forms.TextBox()
        Me.lblsdt = New System.Windows.Forms.Label()
        Me.lblhoSV = New System.Windows.Forms.Label()
        Me.txtTonggia = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.lsvbang = New System.Windows.Forms.ListView()
        Me.clnmaHD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnMaNV = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnMaKH = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnTonggia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnketnoi = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnhuy = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnluu = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Coral
        Me.Label1.Location = New System.Drawing.Point(310, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUẢN LÝ HÓA ĐƠN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtmaKH)
        Me.GroupBox1.Controls.Add(Me.txtmaHD)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblmaSV)
        Me.GroupBox1.Controls.Add(Me.txtmaNV)
        Me.GroupBox1.Controls.Add(Me.lblsdt)
        Me.GroupBox1.Controls.Add(Me.lblhoSV)
        Me.GroupBox1.Controls.Add(Me.txtTonggia)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(731, 119)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin hóa đơn"
        '
        'txtmaKH
        '
        Me.txtmaKH.Location = New System.Drawing.Point(497, 27)
        Me.txtmaKH.Name = "txtmaKH"
        Me.txtmaKH.Size = New System.Drawing.Size(223, 20)
        Me.txtmaKH.TabIndex = 2
        '
        'txtmaHD
        '
        Me.txtmaHD.Location = New System.Drawing.Point(92, 26)
        Me.txtmaHD.Name = "txtmaHD"
        Me.txtmaHD.Size = New System.Drawing.Size(245, 20)
        Me.txtmaHD.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(428, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Mã KH"
        '
        'lblmaSV
        '
        Me.lblmaSV.AutoSize = True
        Me.lblmaSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmaSV.ForeColor = System.Drawing.Color.Blue
        Me.lblmaSV.Location = New System.Drawing.Point(39, 27)
        Me.lblmaSV.Name = "lblmaSV"
        Me.lblmaSV.Size = New System.Drawing.Size(46, 15)
        Me.lblmaSV.TabIndex = 1
        Me.lblmaSV.Text = "Mã HD"
        '
        'txtmaNV
        '
        Me.txtmaNV.Location = New System.Drawing.Point(92, 72)
        Me.txtmaNV.Name = "txtmaNV"
        Me.txtmaNV.Size = New System.Drawing.Size(245, 20)
        Me.txtmaNV.TabIndex = 2
        '
        'lblsdt
        '
        Me.lblsdt.AutoSize = True
        Me.lblsdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsdt.ForeColor = System.Drawing.Color.Blue
        Me.lblsdt.Location = New System.Drawing.Point(25, 76)
        Me.lblsdt.Name = "lblsdt"
        Me.lblsdt.Size = New System.Drawing.Size(44, 15)
        Me.lblsdt.TabIndex = 1
        Me.lblsdt.Text = "Mã NV"
        '
        'lblhoSV
        '
        Me.lblhoSV.AutoSize = True
        Me.lblhoSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhoSV.ForeColor = System.Drawing.Color.Blue
        Me.lblhoSV.Location = New System.Drawing.Point(418, 73)
        Me.lblhoSV.Name = "lblhoSV"
        Me.lblhoSV.Size = New System.Drawing.Size(55, 15)
        Me.lblhoSV.TabIndex = 1
        Me.lblhoSV.Text = "Tổng giá"
        '
        'txtTonggia
        '
        Me.txtTonggia.Location = New System.Drawing.Point(497, 72)
        Me.txtTonggia.Name = "txtTonggia"
        Me.txtTonggia.Size = New System.Drawing.Size(223, 20)
        Me.txtTonggia.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QLbanhang.My.Resources.Resources._1422388953_print
        Me.PictureBox1.Location = New System.Drawing.Point(6, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 124)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnprint.Location = New System.Drawing.Point(137, 202)
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
        Me.lsvbang.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clnmaHD, Me.clnMaNV, Me.clnMaKH, Me.clnTonggia})
        Me.lsvbang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvbang.ForeColor = System.Drawing.Color.ForestGreen
        Me.lsvbang.FullRowSelect = True
        Me.lsvbang.GridLines = True
        Me.lsvbang.LabelEdit = True
        Me.lsvbang.Location = New System.Drawing.Point(12, 167)
        Me.lsvbang.Name = "lsvbang"
        Me.lsvbang.Size = New System.Drawing.Size(494, 251)
        Me.lsvbang.TabIndex = 6
        Me.lsvbang.UseCompatibleStateImageBehavior = False
        Me.lsvbang.View = System.Windows.Forms.View.Details
        '
        'clnmaHD
        '
        Me.clnmaHD.Text = "Mã HD"
        Me.clnmaHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clnmaHD.Width = 78
        '
        'clnMaNV
        '
        Me.clnMaNV.Text = "Mã NV"
        Me.clnMaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clnMaNV.Width = 89
        '
        'clnMaKH
        '
        Me.clnMaKH.Text = "Mã KH"
        Me.clnMaKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clnMaKH.Width = 115
        '
        'clnTonggia
        '
        Me.clnTonggia.Text = "Tổng giá"
        Me.clnTonggia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clnTonggia.Width = 205
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnprint)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.btnketnoi)
        Me.GroupBox2.Controls.Add(Me.btnthoat)
        Me.GroupBox2.Controls.Add(Me.btnthem)
        Me.GroupBox2.Controls.Add(Me.btnhuy)
        Me.GroupBox2.Controls.Add(Me.btnsua)
        Me.GroupBox2.Controls.Add(Me.btnxoa)
        Me.GroupBox2.Controls.Add(Me.btnluu)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox2.Location = New System.Drawing.Point(520, 167)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 251)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức năng"
        '
        'btnketnoi
        '
        Me.btnketnoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnketnoi.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnketnoi.Location = New System.Drawing.Point(149, 115)
        Me.btnketnoi.Name = "btnketnoi"
        Me.btnketnoi.Size = New System.Drawing.Size(68, 32)
        Me.btnketnoi.TabIndex = 8
        Me.btnketnoi.Text = "Kết nối"
        Me.btnketnoi.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthoat.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnthoat.Location = New System.Drawing.Point(149, 77)
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
        Me.btnhuy.Location = New System.Drawing.Point(149, 28)
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
        Me.btnxoa.Location = New System.Drawing.Point(76, 28)
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
        Me.btnluu.Location = New System.Drawing.Point(76, 77)
        Me.btnluu.Name = "btnluu"
        Me.btnluu.Size = New System.Drawing.Size(68, 32)
        Me.btnluu.TabIndex = 7
        Me.btnluu.Text = "Lưu"
        Me.btnluu.UseVisualStyleBackColor = True
        '
        'frmhoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 430)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lsvbang)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmhoadon"
        Me.Text = "QL Hóa Đơn"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtmaKH As System.Windows.Forms.TextBox
    Friend WithEvents txtmaHD As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblmaSV As System.Windows.Forms.Label
    Friend WithEvents txtmaNV As System.Windows.Forms.TextBox
    Friend WithEvents lblsdt As System.Windows.Forms.Label
    Friend WithEvents lblhoSV As System.Windows.Forms.Label
    Friend WithEvents txtTonggia As System.Windows.Forms.TextBox
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lsvbang As System.Windows.Forms.ListView
    Friend WithEvents clnmaHD As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnMaNV As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnMaKH As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnTonggia As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnhuy As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnluu As System.Windows.Forms.Button
    Friend WithEvents btnketnoi As System.Windows.Forms.Button
End Class
