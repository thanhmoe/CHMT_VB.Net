Imports System.Data.SqlClient

Public Class frmDanhSachDonHang
	Public Sub New()

		InitializeComponent()
		LoadDonHang()
	End Sub
	Private Sub btnThemDonHang_Click(sender As Object, e As EventArgs) Handles btnThemDonHang.Click
		Dim f = New frmBanHang
		f.ShowDialog()
		LoadDonHang()

	End Sub

	Sub LoadDonHang()
		Dim query = "select * from HOADON HD " &
					"left join KHACHHANG KH on KH.MaKH = HD.MaKH " &
					"left join NHANVIEN NV on NV.MaNV = HD.MaNV "
		MoKetNoi()
		gvDonHang.Rows.Clear()
		Dim data = LoadDuLieu(query)
		For i = 0 To data.Rows.Count - 1
			gvDonHang.Rows.Add(
				data(i)("MaHD"),
				data(i)("TenKH"),
				data(i)("TenNV"),
				data(i)("NgayHD"),
				data(i)("TongTien"),
				"Xóa")
		Next
		DongKetNoi()
	End Sub

	Private Sub gvDonHang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvDonHang.CellContentClick
		Const XOA_IDX = 5
		Dim maHD = gvDonHang(0, e.RowIndex).Value.ToString()
		If e.ColumnIndex = XOA_IDX Then
			Dim result = MessageBox.Show("Thao tác này sẽ xóa dữ liệu liên quan, xác nhận xóa?",
							"Thông báo",
							MessageBoxButtons.YesNo,
							MessageBoxIcon.Warning)
			If result = DialogResult.Yes Then
				XoaDonHang(maHD)
			End If
		End If
	End Sub

	Sub XoaDonHang(maHD As String)
		Dim query1 = $"delete CTHOADONXUAT where MaHD = '{maHD}'"
		Dim query2 = $"delete HOADON where MaHD = '{maHD}'"

		MoKetNoi()
		Dim cmd1 = New SqlCommand(query1, conn)
		Dim cmd2 = New SqlCommand(query2, conn)

		cmd1.ExecuteNonQuery()
		cmd2.ExecuteNonQuery()
		DongKetNoi()

		LoadDonHang()
	End Sub
End Class