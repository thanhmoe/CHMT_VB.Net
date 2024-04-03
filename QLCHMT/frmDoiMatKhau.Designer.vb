<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoiMatKhau
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTaiKhoan = New System.Windows.Forms.TextBox()
        Me.txtNhapLai = New System.Windows.Forms.TextBox()
        Me.txtMatKhauMoi = New System.Windows.Forms.TextBox()
        Me.txtMatKhauCu = New System.Windows.Forms.TextBox()
        Me.btnDoiMatkhau = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tài Khoản"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mật Khẩu Cũ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mật Khẩu Mới"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.Location = New System.Drawing.Point(81, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nhập Lại"
        '
        'txtTaiKhoan
        '
        Me.txtTaiKhoan.Enabled = False
        Me.txtTaiKhoan.Location = New System.Drawing.Point(176, 59)
        Me.txtTaiKhoan.Multiline = True
        Me.txtTaiKhoan.Name = "txtTaiKhoan"
        Me.txtTaiKhoan.Size = New System.Drawing.Size(173, 30)
        Me.txtTaiKhoan.TabIndex = 4
        '
        'txtNhapLai
        '
        Me.txtNhapLai.Location = New System.Drawing.Point(176, 241)
        Me.txtNhapLai.Multiline = True
        Me.txtNhapLai.Name = "txtNhapLai"
        Me.txtNhapLai.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNhapLai.Size = New System.Drawing.Size(173, 30)
        Me.txtNhapLai.TabIndex = 5
        '
        'txtMatKhauMoi
        '
        Me.txtMatKhauMoi.Location = New System.Drawing.Point(176, 186)
        Me.txtMatKhauMoi.Multiline = True
        Me.txtMatKhauMoi.Name = "txtMatKhauMoi"
        Me.txtMatKhauMoi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatKhauMoi.Size = New System.Drawing.Size(173, 30)
        Me.txtMatKhauMoi.TabIndex = 6
        '
        'txtMatKhauCu
        '
        Me.txtMatKhauCu.Location = New System.Drawing.Point(176, 121)
        Me.txtMatKhauCu.Multiline = True
        Me.txtMatKhauCu.Name = "txtMatKhauCu"
        Me.txtMatKhauCu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatKhauCu.Size = New System.Drawing.Size(173, 30)
        Me.txtMatKhauCu.TabIndex = 7
        '
        'btnDoiMatkhau
        '
        Me.btnDoiMatkhau.Location = New System.Drawing.Point(108, 346)
        Me.btnDoiMatkhau.Name = "btnDoiMatkhau"
        Me.btnDoiMatkhau.Size = New System.Drawing.Size(117, 44)
        Me.btnDoiMatkhau.TabIndex = 8
        Me.btnDoiMatkhau.Text = "Đổi Mật Khẩu"
        Me.btnDoiMatkhau.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(244, 346)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(105, 44)
        Me.btnThoat.TabIndex = 9
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'frmDoiMatKhau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 482)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDoiMatkhau)
        Me.Controls.Add(Me.txtMatKhauCu)
        Me.Controls.Add(Me.txtMatKhauMoi)
        Me.Controls.Add(Me.txtNhapLai)
        Me.Controls.Add(Me.txtTaiKhoan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDoiMatKhau"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đổi Mật Khẩu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTaiKhoan As TextBox
    Friend WithEvents txtNhapLai As TextBox
    Friend WithEvents txtMatKhauMoi As TextBox
    Friend WithEvents txtMatKhauCu As TextBox
    Friend WithEvents btnDoiMatkhau As Button
    Friend WithEvents btnThoat As Button
End Class
