Public Class frmDoiMatKhau
    Private Sub btnDoiMatkhau_Click(sender As Object, e As EventArgs) Handles btnDoiMatkhau.Click
        If txtMatKhauCu.Text <> MatKhau Then
            MsgBox("Bạn nhập lại mật khẩu cũ chưa đúng")
            txtMatKhauCu.Focus()
            Exit Sub
        End If
        If txtMatKhauMoi.Text = "" Or txtNhapLai.Text = "" Then
            MsgBox("Bạn nhập chưa đủ mật khẩu mới")
            txtMatKhauMoi.Focus()
            Exit Sub
        End If
        If txtMatKhauMoi.Text <> txtNhapLai.Text Then
            MsgBox("Bạn nhập mật khẩu mới không giống nhau")
            txtNhapLai.Focus()
            Exit Sub
        End If
        Dim tl As DialogResult
        tl = MsgBox("Bạn có muốn đổi mật khẩu không", MsgBoxStyle.YesNo)
        If tl = DialogResult.No Then Exit Sub
        sql = "update NguoiDung set matkhau = '" & txtMatKhauMoi.Text & "' where taikhoan=taikhoan"
        command = New SqlClient.SqlCommand(sql, conn)
        command.ExecuteNonQuery()
        MsgBox("Đổi mật khẩu thành công")
        MatKhau = txtMatKhauMoi.Text
        txtMatKhauCu.Text = "" : txtMatKhauMoi.Text = "" : txtNhapLai.Text = ""
        txtMatKhauCu.Focus()
    End Sub

    Private Sub frmDoiMatKhau_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTaiKhoan.Text = TaiKhoan
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class