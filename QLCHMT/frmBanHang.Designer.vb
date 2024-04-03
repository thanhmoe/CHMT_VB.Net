<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBanHang
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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.cbKhachHang = New System.Windows.Forms.ComboBox()
		Me.cbNhanVien = New System.Windows.Forms.ComboBox()
		Me.gvDonHang = New System.Windows.Forms.DataGridView()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.numSL = New System.Windows.Forms.NumericUpDown()
		Me.cbThietBi = New System.Windows.Forms.ComboBox()
		Me.btnThem = New System.Windows.Forms.Button()
		Me.colMaTB = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colTenTB = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colDonGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colSoLuong = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colThanhTien = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colDel = New System.Windows.Forms.DataGridViewButtonColumn()
		Me.btnTao = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtTongTien = New System.Windows.Forms.TextBox()
		Me.btnXoaHet = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		CType(Me.gvDonHang, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox3.SuspendLayout()
		CType(Me.numSL, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.cbNhanVien)
		Me.GroupBox1.Controls.Add(Me.cbKhachHang)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(265, 166)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Thông tin bán hàng"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(6, 99)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(72, 17)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Nhân viên"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 38)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(84, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Khách hàng"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.btnXoaHet)
		Me.GroupBox2.Controls.Add(Me.txtTongTien)
		Me.GroupBox2.Controls.Add(Me.gvDonHang)
		Me.GroupBox2.Controls.Add(Me.Label5)
		Me.GroupBox2.Location = New System.Drawing.Point(301, 12)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(705, 434)
		Me.GroupBox2.TabIndex = 1
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Thông tin đơn hàng"
		'
		'cbKhachHang
		'
		Me.cbKhachHang.FormattingEnabled = True
		Me.cbKhachHang.Location = New System.Drawing.Point(9, 59)
		Me.cbKhachHang.Name = "cbKhachHang"
		Me.cbKhachHang.Size = New System.Drawing.Size(247, 24)
		Me.cbKhachHang.TabIndex = 1
		'
		'cbNhanVien
		'
		Me.cbNhanVien.FormattingEnabled = True
		Me.cbNhanVien.Location = New System.Drawing.Point(9, 119)
		Me.cbNhanVien.Name = "cbNhanVien"
		Me.cbNhanVien.Size = New System.Drawing.Size(247, 24)
		Me.cbNhanVien.TabIndex = 2
		'
		'gvDonHang
		'
		Me.gvDonHang.AllowUserToAddRows = False
		Me.gvDonHang.AllowUserToDeleteRows = False
		Me.gvDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.gvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.gvDonHang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMaTB, Me.colTenTB, Me.colDonGia, Me.colSoLuong, Me.colThanhTien, Me.colDel})
		Me.gvDonHang.Location = New System.Drawing.Point(6, 21)
		Me.gvDonHang.Name = "gvDonHang"
		Me.gvDonHang.ReadOnly = True
		Me.gvDonHang.RowHeadersWidth = 49
		Me.gvDonHang.RowTemplate.Height = 24
		Me.gvDonHang.Size = New System.Drawing.Size(693, 356)
		Me.gvDonHang.TabIndex = 2
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.btnThem)
		Me.GroupBox3.Controls.Add(Me.cbThietBi)
		Me.GroupBox3.Controls.Add(Me.numSL)
		Me.GroupBox3.Controls.Add(Me.Label3)
		Me.GroupBox3.Controls.Add(Me.Label4)
		Me.GroupBox3.Location = New System.Drawing.Point(12, 196)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(265, 155)
		Me.GroupBox3.TabIndex = 3
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Thông tin sản phẩm"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(6, 99)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(64, 17)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "Số lượng"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(6, 38)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(55, 17)
		Me.Label4.TabIndex = 0
		Me.Label4.Text = "Thiết bị"
		'
		'numSL
		'
		Me.numSL.Location = New System.Drawing.Point(9, 120)
		Me.numSL.Name = "numSL"
		Me.numSL.Size = New System.Drawing.Size(120, 22)
		Me.numSL.TabIndex = 1
		'
		'cbThietBi
		'
		Me.cbThietBi.FormattingEnabled = True
		Me.cbThietBi.Location = New System.Drawing.Point(6, 58)
		Me.cbThietBi.Name = "cbThietBi"
		Me.cbThietBi.Size = New System.Drawing.Size(247, 24)
		Me.cbThietBi.TabIndex = 3
		'
		'btnThem
		'
		Me.btnThem.Location = New System.Drawing.Point(148, 118)
		Me.btnThem.Name = "btnThem"
		Me.btnThem.Size = New System.Drawing.Size(105, 23)
		Me.btnThem.TabIndex = 4
		Me.btnThem.Text = "Thêm"
		Me.btnThem.UseVisualStyleBackColor = True
		'
		'colMaTB
		'
		Me.colMaTB.HeaderText = "Mã TB"
		Me.colMaTB.MinimumWidth = 6
		Me.colMaTB.Name = "colMaTB"
		Me.colMaTB.ReadOnly = True
		'
		'colTenTB
		'
		Me.colTenTB.HeaderText = "Tên TB"
		Me.colTenTB.MinimumWidth = 6
		Me.colTenTB.Name = "colTenTB"
		Me.colTenTB.ReadOnly = True
		'
		'colDonGia
		'
		Me.colDonGia.HeaderText = "Đơn giá"
		Me.colDonGia.MinimumWidth = 6
		Me.colDonGia.Name = "colDonGia"
		Me.colDonGia.ReadOnly = True
		'
		'colSoLuong
		'
		Me.colSoLuong.FillWeight = 50.0!
		Me.colSoLuong.HeaderText = "SL"
		Me.colSoLuong.MinimumWidth = 6
		Me.colSoLuong.Name = "colSoLuong"
		Me.colSoLuong.ReadOnly = True
		'
		'colThanhTien
		'
		Me.colThanhTien.HeaderText = "Thành tiền"
		Me.colThanhTien.MinimumWidth = 6
		Me.colThanhTien.Name = "colThanhTien"
		Me.colThanhTien.ReadOnly = True
		'
		'colDel
		'
		Me.colDel.FillWeight = 50.0!
		Me.colDel.HeaderText = ""
		Me.colDel.MinimumWidth = 6
		Me.colDel.Name = "colDel"
		Me.colDel.ReadOnly = True
		Me.colDel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.colDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		'
		'btnTao
		'
		Me.btnTao.Location = New System.Drawing.Point(12, 384)
		Me.btnTao.Name = "btnTao"
		Me.btnTao.Size = New System.Drawing.Size(265, 56)
		Me.btnTao.TabIndex = 4
		Me.btnTao.Text = "Tạo đơn hàng"
		Me.btnTao.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(340, 392)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(68, 17)
		Me.Label5.TabIndex = 0
		Me.Label5.Text = "Tổng tiền"
		'
		'txtTongTien
		'
		Me.txtTongTien.Enabled = False
		Me.txtTongTien.Location = New System.Drawing.Point(415, 392)
		Me.txtTongTien.Name = "txtTongTien"
		Me.txtTongTien.Size = New System.Drawing.Size(284, 22)
		Me.txtTongTien.TabIndex = 3
		'
		'btnXoaHet
		'
		Me.btnXoaHet.Location = New System.Drawing.Point(6, 392)
		Me.btnXoaHet.Name = "btnXoaHet"
		Me.btnXoaHet.Size = New System.Drawing.Size(91, 36)
		Me.btnXoaHet.TabIndex = 4
		Me.btnXoaHet.Text = "Xóa hết"
		Me.btnXoaHet.UseVisualStyleBackColor = True
		'
		'frmBanHang
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1018, 460)
		Me.Controls.Add(Me.btnTao)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "frmBanHang"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Tạo đơn hàng"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		CType(Me.gvDonHang, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		CType(Me.numSL, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents cbNhanVien As ComboBox
	Friend WithEvents cbKhachHang As ComboBox
	Friend WithEvents gvDonHang As DataGridView
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents txtTongTien As TextBox
	Friend WithEvents colMaTB As DataGridViewTextBoxColumn
	Friend WithEvents colTenTB As DataGridViewTextBoxColumn
	Friend WithEvents colDonGia As DataGridViewTextBoxColumn
	Friend WithEvents colSoLuong As DataGridViewTextBoxColumn
	Friend WithEvents colThanhTien As DataGridViewTextBoxColumn
	Friend WithEvents colDel As DataGridViewButtonColumn
	Friend WithEvents Label5 As Label
	Friend WithEvents btnThem As Button
	Friend WithEvents cbThietBi As ComboBox
	Friend WithEvents numSL As NumericUpDown
	Friend WithEvents btnTao As Button
	Friend WithEvents btnXoaHet As Button
End Class
