Imports System.Data.SqlClient

Public Class frmThietBi_AddOrUpdate
	Private Property IsUpdateMode As Boolean

	Public Sub New(Optional isUpdate As Boolean = False, Optional maTB As String = "")

		' This call is required by the designer.
		InitializeComponent()
		MoKetNoi()
		Dim data = LoadDuLieu("select * from NHACC")
		cbNCC.DataSource = data
		cbNCC.DisplayMember = "TenNCC"
		cbNCC.ValueMember = "MaNCC"
		DongKetNoi()

		IsUpdateMode = isUpdate
		If IsUpdateMode Then
			LoadThietBi(maTB)
			btnThem.Text = "Cập nhật"
			Me.Text = "Cập nhật thiết bị"
		Else
			TaoMaTB()
		End If

	End Sub
	Private Sub LoadThietBi(maTB As String)
		MoKetNoi()
		Dim query = $"select * from THIETBI where MaTB = '{maTB}'"
		Dim data = LoadDuLieu(query)
		txtMaTB.Text = data(0)("MaTB").ToString()
		txtTenTB.Text = data(0)("TenTB").ToString()
		cbNCC.SelectedValue = data(0)("MaNCC").ToString()
		txtLoaiChip.Text = data(0)("LoaiChip").ToString()
		numSL.Value = Convert.ToDouble(data(0)("SoLuongTrongKho"))
		dtBaoHanh.Value = Convert.ToDateTime(data(0)("BaoHanh"))
		txtDonGia.Text = data(0)("GiaBan").ToString()
	End Sub
	Private Sub TaoMaTB()
		txtMaTB.Text = GetMaTB()
	End Sub

	Private Function GetMaTB() As String
		MoKetNoi()
		Dim data = LoadDuLieu("select count(*) from THIETBI")
		DongKetNoi()
		Dim maTB = Convert.ToInt32(data(0)(0)) + 1
		Return "TB" + maTB.ToString("D6")
	End Function

	Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
		If IsUpdateMode Then
			CapNhatThietBi()
		Else
			ThemThietBi()
		End If
	End Sub

	Sub ThemThietBi()
		Try
			MoKetNoi()
			Dim query = "insert into THIETBI values(" &
					$"'{txtMaTB.Text}'," &
					$"N'{txtTenTB.Text}'," &
					$"'{cbNCC.SelectedValue}'," &
					$"N'{txtLoaiChip.Text}'," &
					$"{numSL.Value}," &
					$"'{dtBaoHanh.Value.ToString("yyyy-MM-dd")}'," &
					$"{Convert.ToDecimal(txtDonGia.Text)}" &
					$")"
			Dim cmd = New SqlCommand(query, conn)
			cmd.ExecuteNonQuery()
			DongKetNoi()
			MessageBox.Show("Thêm thiết bị thành công")
			txtLoaiChip.Clear()
			txtTenTB.Clear()
			TaoMaTB()
		Catch ex As Exception
			MessageBox.Show("Thêm thiết bị thất bại", "Thông báo",
							MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Sub CapNhatThietBi()
		Try
			MoKetNoi()
			Dim query = "update THIETBI set " &
					$"TenTB = N'{txtTenTB.Text}'," &
					$"MaNCC = '{cbNCC.SelectedValue}'," &
					$"LoaiChip = N'{txtLoaiChip.Text}'," &
					$"SoLuongTrongKho = {numSL.Value}," &
					$"BaoHanh = '{dtBaoHanh.Value.ToString("yyyy-MM-dd")}'," &
					$"GiaBan = {Convert.ToDecimal(txtDonGia.Text)}" &
					$" where MaTB = '{txtMaTB.Text}'"
			Dim cmd = New SqlCommand(query, conn)
			cmd.ExecuteNonQuery()
			DongKetNoi()
			MessageBox.Show("Cập nhật thiết bị thành công")
		Catch ex As Exception
			MessageBox.Show("Cập nhật thiết bị thất bại", "Thông báo",
							MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub
End Class