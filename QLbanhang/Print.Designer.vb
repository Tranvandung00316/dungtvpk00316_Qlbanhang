<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmprint
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
        Me.LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        Me.lsvbang.Location = New System.Drawing.Point(1, 61)
        Me.lsvbang.Name = "lsvbang"
        Me.lsvbang.Size = New System.Drawing.Size(948, 333)
        Me.lsvbang.TabIndex = 15
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
        'LinkLabel
        '
        Me.LinkLabel.AutoSize = True
        Me.LinkLabel.Location = New System.Drawing.Point(233, 9)
        Me.LinkLabel.Name = "LinkLabel"
        Me.LinkLabel.Size = New System.Drawing.Size(120, 13)
        Me.LinkLabel.TabIndex = 22
        Me.LinkLabel.TabStop = True
        Me.LinkLabel.Text = "http://www.poly.edu.vn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label3.Location = New System.Drawing.Point(19, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Cao Đẳng FPT Polytechnic"
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnprint.Location = New System.Drawing.Point(510, 9)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(75, 34)
        Me.btnprint.TabIndex = 20
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'frmprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 405)
        Me.Controls.Add(Me.LinkLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.lsvbang)
        Me.Name = "frmprint"
        Me.Text = "Print"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsvbang As System.Windows.Forms.ListView
    Friend WithEvents clnmaCTHD As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnMaHD As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnMaSP As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClnSP As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClntenkH As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnsoluong As System.Windows.Forms.ColumnHeader
    Friend WithEvents clngia As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnngaynhap As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnngayxuat As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnTonggia As System.Windows.Forms.ColumnHeader
    Friend WithEvents LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnprint As System.Windows.Forms.Button
End Class
