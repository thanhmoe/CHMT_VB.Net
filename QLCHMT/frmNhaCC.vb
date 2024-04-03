Imports System.Data.SqlClient
Public Class frmNhaCC
    Public kt As Boolean
    Public vt As Integer
    Public Sub SetControl(b As Boolean)
        btnThem.Enabled = b
        btnSua.Enabled = b
        btnXoa.Enabled = b
        btnLuu.Enabled = Not b
        btnHuy.Enabled = Not b
    End Sub
    Public Sub SetLock(b As Boolean)
        txtMaNCC.Enabled = Not b
        txtTenNCC.Enabled = Not b
    End Sub

    Private Sub frmNhaCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MoKetNoi()
        LoadDataGridView(dgvNhaCC, "select * from NHACC")
        SetControl(True)
        SetLock(True)
    End Sub

    Private Sub dgvNhaCC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNhaCC.CellContentClick
        If dgvNhaCC.RowCount <= 0 Then Exit Sub
        vt = e.RowIndex
        If e.RowIndex >= 0 Then
            Dim dong As Integer
            dong = dgvNhaCC.CurrentCell.RowIndex
            txtMaNCC.Text = dgvNhaCC.Rows(dong).Cells(0).Value
            txtTenNCC.Text = dgvNhaCC.Rows(dong).Cells(1).Value
        End If
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        kt = True
        SetControl(False)
        SetLock(False)
        txtMaNCC.Text = ""
        txtTenNCC.Text = ""
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If txtMaNCC.Text = "" Then
            MsgBox("Bạn chưa chọn bản ghi cần sửa")
            Exit Sub
        End If
        kt = False
        SetControl(False)
        SetLock(False)
        txtMaNCC.Enabled = False
    End Sub
    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        SetControl(True)
        SetLock(True)
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaNCC.Text = "" Then
            MsgBox("Bạn chưa chọn bản ghi cần xóa")
            Exit Sub
        End If
        Dim tl As DialogResult
        tl = MsgBox("Bạn có muốn xóa không?", MsgBoxStyle.YesNo)
        If tl = DialogResult.Yes Then
            sql = "select count(*) from THIETBI where MaNCC ='" & txtMaNCC.Text & "'"
            command.Connection = conn
            command.CommandType = CommandType.Text
            command.CommandText = sql
            If command.ExecuteScalar() > 0 Then
                MsgBox("Nhà cung cấp đã có dữ liệu")
            Else
                Try
                    sql = "delete from NHACC where MaNCC = '" & txtMaNCC.Text & "'"
                    command = New SqlCommand(sql, conn)
                    command.ExecuteNonQuery()
                    LoadDataGridView(dgvNhaCC, "select * from NHACC")
                    MsgBox(vt)
                    dgvNhaCC.Rows.RemoveAt(vt)
                    MsgBox("Xóa thành công")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtMaNCC.Text = "" Then
            MsgBox("Chưa nhập mã nhà cung cấp")
            txtMaNCC.Focus()
            Exit Sub
        End If
        If txtTenNCC.Text = "" Then
            MsgBox("Chưa nhập tên nhà cung cấp")
            txtTenNCC.Focus()
            Exit Sub
        End If
        If kt Then
            sql = "select count(*) from NHACC where MaNCC='" & txtMaNCC.Text & "'"
            command = New SqlCommand(sql, conn)
            Dim count As Integer
            count = command.ExecuteScalar()
            If count > 0 Then
                MsgBox("Mã nhà cung cấp này đã tồn tại")
                Exit Sub
            End If
            sql = "insert into NHACC values (@MaNCC,@TenNCC)"
        Else
            sql = "update NHACC set TenNCC=@TenNCC where MaNCC=@MaNCC"
        End If
        Try
            command = New SqlCommand(sql, conn)
            command.Parameters.AddWithValue("@MaNCC", txtMaNCC.Text)
            command.Parameters.AddWithValue("@TenNCC", txtTenNCC.Text)
            command.ExecuteNonQuery()

            LoadDataGridView(dgvNhaCC, "select * from NHACC")
            Dim mancc As String = txtMaNCC.Text
            Dim tenncc As String = txtTenNCC.Text
            dgvNhaCC.Rows.Add(New String() {mancc, tenncc})
            MessageBox.Show("Đã cập nhật thành công")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        SetControl(True)
        SetLock(True)
    End Sub

End Class