<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdangnhap
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
        Me.LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.txtmatkhau = New System.Windows.Forms.TextBox()
        Me.btndangnhap = New System.Windows.Forms.Button()
        Me.txtdangnhap = New System.Windows.Forms.TextBox()
        Me.lblmatkhau = New System.Windows.Forms.Label()
        Me.lbltendangnhap = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.GroupBox1.Controls.Add(Me.LinkLabel)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.btnthoat)
        Me.GroupBox1.Controls.Add(Me.txtmatkhau)
        Me.GroupBox1.Controls.Add(Me.btndangnhap)
        Me.GroupBox1.Controls.Add(Me.txtdangnhap)
        Me.GroupBox1.Controls.Add(Me.lblmatkhau)
        Me.GroupBox1.Controls.Add(Me.lbltendangnhap)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(502, 241)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin đăng nhập"
        '
        'LinkLabel
        '
        Me.LinkLabel.AutoSize = True
        Me.LinkLabel.Location = New System.Drawing.Point(16, 218)
        Me.LinkLabel.Name = "LinkLabel"
        Me.LinkLabel.Size = New System.Drawing.Size(120, 13)
        Me.LinkLabel.TabIndex = 4
        Me.LinkLabel.TabStop = True
        Me.LinkLabel.Text = "http://www.poly.edu.vn"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Image = Global.QLbanhang.My.Resources.Resources._1422381845_preferences_desktop_cryptography
        Me.PictureBox4.InitialImage = Nothing
        Me.PictureBox4.Location = New System.Drawing.Point(6, 37)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(148, 168)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(270, 126)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(110, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Ghi nhớ mật khẩu"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnthoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthoat.ForeColor = System.Drawing.Color.Crimson
        Me.btnthoat.Image = Global.QLbanhang.My.Resources.Resources._1422382424_Gnome_Application_Exit_64
        Me.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnthoat.Location = New System.Drawing.Point(371, 165)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(104, 40)
        Me.btnthoat.TabIndex = 1
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnthoat.UseVisualStyleBackColor = False
        '
        'txtmatkhau
        '
        Me.txtmatkhau.Location = New System.Drawing.Point(270, 84)
        Me.txtmatkhau.Name = "txtmatkhau"
        Me.txtmatkhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtmatkhau.Size = New System.Drawing.Size(205, 20)
        Me.txtmatkhau.TabIndex = 1
        '
        'btndangnhap
        '
        Me.btndangnhap.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btndangnhap.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndangnhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndangnhap.ForeColor = System.Drawing.Color.Blue
        Me.btndangnhap.Image = Global.QLbanhang.My.Resources.Resources._1422382337_login
        Me.btndangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndangnhap.Location = New System.Drawing.Point(235, 165)
        Me.btndangnhap.Name = "btndangnhap"
        Me.btndangnhap.Size = New System.Drawing.Size(112, 40)
        Me.btndangnhap.TabIndex = 1
        Me.btndangnhap.Text = "Đăng nhập"
        Me.btndangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndangnhap.UseVisualStyleBackColor = False
        '
        'txtdangnhap
        '
        Me.txtdangnhap.Location = New System.Drawing.Point(270, 38)
        Me.txtdangnhap.Name = "txtdangnhap"
        Me.txtdangnhap.Size = New System.Drawing.Size(205, 20)
        Me.txtdangnhap.TabIndex = 1
        '
        'lblmatkhau
        '
        Me.lblmatkhau.AutoSize = True
        Me.lblmatkhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmatkhau.ForeColor = System.Drawing.Color.Purple
        Me.lblmatkhau.Location = New System.Drawing.Point(186, 83)
        Me.lblmatkhau.Name = "lblmatkhau"
        Me.lblmatkhau.Size = New System.Drawing.Size(69, 18)
        Me.lblmatkhau.TabIndex = 0
        Me.lblmatkhau.Text = "Mật khẩu"
        '
        'lbltendangnhap
        '
        Me.lbltendangnhap.AutoSize = True
        Me.lbltendangnhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltendangnhap.ForeColor = System.Drawing.Color.Purple
        Me.lbltendangnhap.Location = New System.Drawing.Point(150, 37)
        Me.lbltendangnhap.Name = "lbltendangnhap"
        Me.lbltendangnhap.Size = New System.Drawing.Size(105, 18)
        Me.lbltendangnhap.TabIndex = 0
        Me.lbltendangnhap.Text = "Tên đăng nhập"
        '
        'frmdangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 258)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmdangnhap"
        Me.Text = "Đăng nhập"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents txtmatkhau As System.Windows.Forms.TextBox
    Friend WithEvents btndangnhap As System.Windows.Forms.Button
    Friend WithEvents txtdangnhap As System.Windows.Forms.TextBox
    Friend WithEvents lblmatkhau As System.Windows.Forms.Label
    Friend WithEvents lbltendangnhap As System.Windows.Forms.Label

End Class
