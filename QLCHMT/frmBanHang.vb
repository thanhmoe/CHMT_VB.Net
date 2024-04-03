Imports System.Data.SqlClient

Public Class frmBanHang
	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()
		LoadNhanVien()
		LoadKhachHang()
		LoadThietBi()
	End Sub




	Private Sub LoadNhanVien()
		Dim sql = "select * from NHANVIEN"
		MoKetNoi()
		Dim data = LoadDuLieu(sql)
		cbNhanVien.DataSource = data
		cbNhanVien.DisplayMember = "TenNV"
		cbNhanVien.ValueMember = "MaNV"
		DongKetNoi()
	End Sub

	Private Sub LoadKhachHang()
		Dim sql = "select * from KHACHHANG"
		MoKetNoi()
		Dim data = LoadDuLieu(sql)
		cbKhachHang.DataSource = data
		cbKhachHang.DisplayMember = "TenKH"
		cbKhachHang.ValueMember = "MaKH"
		DongKetNoi()
	End Sub

	Private Sub LoadThietBi()
		Dim sql = "select MaTB, TenTB from THIETBI"
		MoKetNoi()
		Dim data = LoadDuLieu(sql)
		cbThietBi.DataSource = data
		cbThietBi.DisplayMember = "TenTB"
		cbThietBi.ValueMember = "MaTB"
		DongKetNoi()
	End Sub

	Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
		ThemDataVaoGV()
	End Sub

	Sub ThemDataVaoGV()
		MoKetNoi()
		Dim maTB = cbThietBi.SelectedValue.ToString()
		Dim tenTB = cbThietBi.Text
		Dim donGia = Convert.ToDouble(LoadDuLieu($"select GiaBan from THIETBI where MaTB = '{maTB}'")(0)(0))
		Dim sl = numSL.Value

		Dim lstMaTB = New List(Of String)
		If gvDonHang.Rows.Count > 0 Then
			For i = 0 To gvDonHang.Rows.Count - 1
				lstMaTB.Add(gvDonHang(0, i).Value)
			Next
		End If

		If lstMaTB.Contains(maTB) Then
			Dim idx = lstMaTB.IndexOf(maTB)
			Dim old_sl = Convert.ToInt32(gvDonHang(3, idx).Value)
			sl = sl + old_sl
			DeleteRowByIndex(idx)
		End If

		Dim thanhTien = sl * donGia
		gvDonHang.Rows.Add(maTB, tenTB, donGia, sl, thanhTien, "Xóa")
		DongKetNoi()
		TinhTongTien()
	End Sub

	Private Sub DeleteRowByIndex(idx As Integer)
		gvDonHang.Rows.RemoveAt(idx)
	End Sub

	Private Sub btnXoaHet_Click(sender As Object, e As EventArgs) Handles btnXoaHet.Click
		gvDonHang.Rows.Clear()
		txtTongTien.Clear()
	End Sub

	Sub TinhTongTien()
		Const THANH_TIEN_IDX = 4
		Dim sum = 0.0
		For i = 0 To gvDonHang.Rows.Count - 1
			sum = sum + Convert.ToDouble(gvDonHang(THANH_TIEN_IDX, i).Value)
		Next
		txtTongTien.Text = sum
	End Sub

	Private Sub gvDonHang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvDonHang.CellContentClick
		Const XOA_IDX = 5
		If e.ColumnIndex = XOA_IDX Then
			DeleteRowByIndex(e.RowIndex)
			TinhTongTien()
		End If
	End Sub

	Private Sub btnTao_Click(sender As Object, e As EventArgs) Handles btnTao.Click
		If txtTongTien.Text = "" Then
			txtTongTien.Text = "0"
		End If

		Dim maHD = GetMaHD()
		Dim query = "insert into HOADON values(" &
					$"'{maHD}'," &
					$"'{DateTime.Now.ToString("yyyy-MM-dd")}'," &
					$"'{cbKhachHang.SelectedValue.ToString()}'," &
					$"'{cbNhanVien.SelectedValue.ToString()}'," &
					$"{txtTongTien.Text})"
		MoKetNoi()
		Try
			Dim cmd = New SqlCommand(query, conn)
			cmd.ExecuteNonQuery()
			For i = 0 To gvDonHang.Rows.Count - 1
				Dim query_ct = "insert into CTHOADONXUAT(MaHD,NgayHD,MaTB,TenTB,SoLuongBan,BaoHanh,ThanhTien) values(" &
								$"'{maHD}'," &
								$"'{DateTime.Now.ToString("yyyy-MM-dd")}'," &
								$"'{gvDonHang(0, i).Value}'," &
								$"'{gvDonHang(1, i).Value}'," &
								$"{gvDonHang(3, i).Value}," &
								$"'2025-01-01'," &
								$"{gvDonHang(4, i).Value})"
				Dim cmd_ct = New SqlCommand(query_ct, conn)
				cmd_ct.ExecuteNonQuery()
			Next
			MessageBox.Show("Tạo đơn hàng thành công")
			gvDonHang.Rows.Clear()
			txtTongTien.Clear()
		Catch ex As Exception
			MessageBox.Show("Tạo đơn hàng thất bại", "Thông báo",
							MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
		DongKetNoi()

	End Sub

	Private Function GetMaHD() As String
		MoKetNoi()
		Dim data = LoadDuLieu("select count(*) from HOADON")
		DongKetNoi()
		Dim maTB = Convert.ToInt32(data(0)(0)) + 1
		Return "HD" + maTB.ToString("D6")
	End Function
End Class