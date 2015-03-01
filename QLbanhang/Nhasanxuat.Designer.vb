<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmnhasanxuat
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
        Me.txtNSX = New System.Windows.Forms.TextBox()
        Me.lblmaNV = New System.Windows.Forms.Label()
        Me.txttenNSX = New System.Windows.Forms.TextBox()
        Me.lblhovatenV = New System.Windows.Forms.Label()
        Me.lbltCMND = New System.Windows.Forms.Label()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lsvbang = New System.Windows.Forms.ListView()
        Me.clnmaNSX = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnhovatenNV = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnMaNX = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnhuy = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnluu = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtNSX)
        Me.GroupBox1.Controls.Add(Me.lblmaNV)
        Me.GroupBox1.Controls.Add(Me.txttenNSX)
        Me.GroupBox1.Controls.Add(Me.lblhovatenV)
        Me.GroupBox1.Controls.Add(Me.lbltCMND)
        Me.GroupBox1.Controls.Add(Me.txtdiachi)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 90)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin nhà sản xuất"
        '
        'txtNSX
        '
        Me.txtNSX.Location = New System.Drawing.Point(91, 26)
        Me.txtNSX.Name = "txtNSX"
        Me.txtNSX.Size = New System.Drawing.Size(127, 20)
        Me.txtNSX.TabIndex = 2
        '
        'lblmaNV
        '
        Me.lblmaNV.AutoSize = True
        Me.lblmaNV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmaNV.ForeColor = System.Drawing.Color.Blue
        Me.lblmaNV.Location = New System.Drawing.Point(232, 27)
        Me.lblmaNV.Name = "lblmaNV"
        Me.lblmaNV.Size = New System.Drawing.Size(56, 15)
        Me.lblmaNV.TabIndex = 1
        Me.lblmaNV.Text = "Tên NSX"
        '
        'txttenNSX
        '
        Me.txttenNSX.Location = New System.Drawing.Point(294, 26)
        Me.txttenNSX.Name = "txttenNSX"
        Me.txttenNSX.Size = New System.Drawing.Size(216, 20)
        Me.txttenNSX.TabIndex = 2
        '
        'lblhovatenV
        '
        Me.lblhovatenV.AutoSize = True
        Me.lblhovatenV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhovatenV.ForeColor = System.Drawing.Color.Blue
        Me.lblhovatenV.Location = New System.Drawing.Point(34, 58)
        Me.lblhovatenV.Name = "lblhovatenV"
        Me.lblhovatenV.Size = New System.Drawing.Size(45, 15)
        Me.lblhovatenV.TabIndex = 1
        Me.lblhovatenV.Text = "Địa chỉ"
        '
        'lbltCMND
        '
        Me.lbltCMND.AutoSize = True
        Me.lbltCMND.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltCMND.ForeColor = System.Drawing.Color.Blue
        Me.lbltCMND.Location = New System.Drawing.Point(26, 27)
        Me.lbltCMND.Name = "lbltCMND"
        Me.lbltCMND.Size = New System.Drawing.Size(53, 15)
        Me.lbltCMND.TabIndex = 1
        Me.lbltCMND.Text = "Mã NSX"
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(91, 57)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(322, 20)
        Me.txtdiachi.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.lsvbang)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox3.Location = New System.Drawing.Point(12, 104)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(526, 290)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bảng nhà sản xuất"
        '
        'lsvbang
        '
        Me.lsvbang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvbang.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clnmaNSX, Me.clnhovatenNV, Me.clnMaNX})
        Me.lsvbang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvbang.ForeColor = System.Drawing.Color.ForestGreen
        Me.lsvbang.FullRowSelect = True
        Me.lsvbang.GridLines = True
        Me.lsvbang.LabelEdit = True
        Me.lsvbang.Location = New System.Drawing.Point(12, 19)
        Me.lsvbang.Name = "lsvbang"
        Me.lsvbang.Size = New System.Drawing.Size(503, 265)
        Me.lsvbang.TabIndex = 0
        Me.lsvbang.UseCompatibleStateImageBehavior = False
        Me.lsvbang.View = System.Windows.Forms.View.Details
        '
        'clnmaNSX
        '
        Me.clnmaNSX.Text = "Mã NSX"
        Me.clnmaNSX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clnmaNSX.Width = 81
        '
        'clnhovatenNV
        '
        Me.clnhovatenNV.Text = "Tên NSX"
        Me.clnhovatenNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clnhovatenNV.Width = 166
        '
        'clnMaNX
        '
        Me.clnMaNX.Text = "Địa chỉ"
        Me.clnMaNX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clnMaNX.Width = 248
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
        Me.GroupBox2.Location = New System.Drawing.Point(24, 400)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(503, 74)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức năng"
        '
        'btnthoat
        '
        Me.btnthoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthoat.ForeColor = System.Drawing.Color.Crimson
        Me.btnthoat.Location = New System.Drawing.Point(426, 23)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnthoat.Size = New System.Drawing.Size(77, 34)
        Me.btnthoat.TabIndex = 3
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthem.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnthem.Location = New System.Drawing.Point(0, 23)
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
        Me.btnhuy.Location = New System.Drawing.Point(341, 23)
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
        Me.btnsua.Location = New System.Drawing.Point(86, 23)
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
        Me.btnluu.Location = New System.Drawing.Point(256, 23)
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
        Me.btnxoa.Location = New System.Drawing.Point(171, 23)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(79, 34)
        Me.btnxoa.TabIndex = 3
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'frmnhasanxuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 486)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmnhasanxuat"
        Me.Text = "Nhà sản xuất"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNSX As System.Windows.Forms.TextBox
    Friend WithEvents lblmaNV As System.Windows.Forms.Label
    Friend WithEvents txttenNSX As System.Windows.Forms.TextBox
    Friend WithEvents lblhovatenV As System.Windows.Forms.Label
    Friend WithEvents lbltCMND As System.Windows.Forms.Label
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lsvbang As System.Windows.Forms.ListView
    Friend WithEvents clnmaNSX As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnhovatenNV As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnMaNX As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnhuy As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnluu As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
End Class
