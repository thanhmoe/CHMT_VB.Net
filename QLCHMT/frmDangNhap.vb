Public Class frmDangNhap
    Dim daNguoiDung As DataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtTaiKhoan.Text = "" Then
            MsgBox("Bạn nhập thiếu tài khoản")
            txtTaiKhoan.Focus()
            Exit Sub
        End If
        If txtMatKhau.Text = "" Then
            MsgBox("Bạn nhập thiếu mật khẩu")
            txtMatKhau.Focus()
            Exit Sub
        End If
        sql = "select * from NguoiDung where taikhoan = '" & txtTaiKhoan.Text & "' and matkhau ='" & txtMatKhau.Text & "'"
        daNguoiDung = LoadDuLieu(sql)
        If daNguoiDung.Rows.Count > 0 Then
            TaiKhoan = daNguoiDung.Rows(0).Item("TaiKhoan")
            MatKhau = daNguoiDung.Rows(0).Item("MatKhau")
            frmMainForm.Show()
            txtMatKhau.Text = ""
            txtTaiKhoan.Text = ""
            Me.Hide()
        Else
            MsgBox("Bạn nhập chưa đúng thông tin")
        End If
    End Sub

    Private Sub frmDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MoKetNoi()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim thongbao As DialogResult
        thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If (thongbao = DialogResult.OK) Then
            Application.Exit()
        End If
    End Sub
End Class
