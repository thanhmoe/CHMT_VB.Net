Public Class frmMainForm
    Private Sub QuảnLýTàiKhoảnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýTàiKhoảnToolStripMenuItem.Click

    End Sub

    Private Sub ĐổiMậtKhẩuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐổiMậtKhẩuToolStripMenuItem.Click
        frmDoiMatKhau.MdiParent = Me
        frmDoiMatKhau.Show()
    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        Me.Close()
        frmDangNhap.Show()
        DongKetNoi()
    End Sub

    Private Sub NhàCungCấpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhàCungCấpToolStripMenuItem.Click
        frmNhaCC.MdiParent = Me
        frmNhaCC.Show()
    End Sub

    Private Sub NhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhânViênToolStripMenuItem.Click
        frmNhanVien.MdiParent = Me
        frmNhanVien.Show()
    End Sub

    Private Sub ThiếtBịToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThiếtBịToolStripMenuItem.Click
        frmThietBi.MdiParent = Me
        frmThietBi.Show()
    End Sub

    Private Sub frmMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class