﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdoanhthu
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
        Me.txtdoanhthu = New System.Windows.Forms.TextBox()
        Me.btntinh = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtdoanhthu
        '
        Me.txtdoanhthu.Location = New System.Drawing.Point(93, 22)
        Me.txtdoanhthu.Name = "txtdoanhthu"
        Me.txtdoanhthu.Size = New System.Drawing.Size(180, 20)
        Me.txtdoanhthu.TabIndex = 3
        '
        'btntinh
        '
        Me.btntinh.ForeColor = System.Drawing.Color.Maroon
        Me.btntinh.Location = New System.Drawing.Point(12, 16)
        Me.btntinh.Name = "btntinh"
        Me.btntinh.Size = New System.Drawing.Size(75, 30)
        Me.btntinh.TabIndex = 4
        Me.btntinh.Text = "Tính"
        Me.btntinh.UseVisualStyleBackColor = True
        '
        'frmdoanhthu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 71)
        Me.Controls.Add(Me.btntinh)
        Me.Controls.Add(Me.txtdoanhthu)
        Me.Name = "frmdoanhthu"
        Me.Text = "Tổng doanh thu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtdoanhthu As System.Windows.Forms.TextBox
    Friend WithEvents btntinh As System.Windows.Forms.Button
End Class
