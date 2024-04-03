Imports System.Data.SqlClient

Public Class frmThietBi
	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		LoadThietBi()
	End Sub

	Sub LoadThietBi()
		Dim query = "select * from THIETBI " &
					"left join NHACC on NHACC.MaNCC = THIETBI.MaNCC"
		MoKetNoi()
		Dim cmd = New SqlCommand(query, conn)
		Dim reader = cmd.ExecuteReader()
		gvThietBi.ClearSelection()
		gvThietBi.Rows.Clear()

		While reader.Read()
			gvThietBi.Rows.Add(
				reader("MaTB").ToString(),
				reader("TenTB").ToString(),
				reader("TenNCC").ToString(),
				reader("LoaiChip").ToString(),
				reader("SoLuongTrongKho").ToString(),
				reader("GiaBan").ToString(),
				"Sửa",
				"Xóa"
			)
		End While
		DongKetNoi()

	End Sub

	Private Sub btnThemTB_Click(sender As Object, e As EventArgs) Handles btnThemTB.Click
		Dim fThemTB = New frmThietBi_AddOrUpdate
		fThemTB.ShowDialog()
		LoadThietBi()
	End Sub

	Private Sub gvThietBi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvThietBi.CellContentClick
		Const SUA_IDX = 6
		Const XOA_IDX = 7
		Dim maTb = gvThietBi(0, e.RowIndex).Value.ToString()
		If e.ColumnIndex = SUA_IDX Then
			CapNhatThietBi(maTb)
		ElseIf e.ColumnIndex = XOA_IDX Then
			Dim result = MessageBox.Show("Thao tác này sẽ xóa dữ liệu liên quan, xác nhận xóa?",
							"Thông báo",
							MessageBoxButtons.YesNo,
							MessageBoxIcon.Warning)
			If result = DialogResult.Yes Then
				XoaThietBi(maTb)
			End If
		End If
	End Sub

	Sub CapNhatThietBi(maTB As String)
		Dim fCapNhat = New frmThietBi_AddOrUpdate(True, maTB)
		fCapNhat.ShowDialog()
		LoadThietBi()
	End Sub

	Sub XoaThietBi(maTB As String)
		Dim query1 = $"delete CTHOADONXUAT where MaTB = '{maTB}'"
		Dim query2 = $"delete CTHOADONNNHAP where MaTB = '{maTB}'"
		Dim query3 = $"delete THIETBI where MaTB = '{maTB}'"

		MoKetNoi()
		Dim cmd1 = New SqlCommand(query1, conn)
		Dim cmd2 = New SqlCommand(query2, conn)
		Dim cmd3 = New SqlCommand(query3, conn)

		cmd1.ExecuteNonQuery()
		cmd2.ExecuteNonQuery()
		cmd3.ExecuteNonQuery()

		DongKetNoi()
		LoadThietBi()
	End Sub
End Class