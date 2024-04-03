<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhSachDonHang
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
		Me.btnThemDonHang = New System.Windows.Forms.Button()
		Me.gvDonHang = New System.Windows.Forms.DataGridView()
		Me.colMaTB = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colnv = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colDonGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colDel = New System.Windows.Forms.DataGridViewButtonColumn()
		CType(Me.gvDonHang, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnThemDonHang
		'
		Me.btnThemDonHang.Location = New System.Drawing.Point(13, 13)
		Me.btnThemDonHang.Name = "btnThemDonHang"
		Me.btnThemDonHang.Size = New System.Drawing.Size(138, 42)
		Me.btnThemDonHang.TabIndex = 0
		Me.btnThemDonHang.Text = "Tạo đơn hàng"
		Me.btnThemDonHang.UseVisualStyleBackColor = True
		'
		'gvDonHang
		'
		Me.gvDonHang.AllowUserToAddRows = False
		Me.gvDonHang.AllowUserToDeleteRows = False
		Me.gvDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.gvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.gvDonHang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMaTB, Me.Column2, Me.colnv, Me.Column1, Me.colDonGia, Me.colDel})
		Me.gvDonHang.Location = New System.Drawing.Point(13, 79)
		Me.gvDonHang.Name = "gvDonHang"
		Me.gvDonHang.ReadOnly = True
		Me.gvDonHang.RowHeadersWidth = 49
		Me.gvDonHang.RowTemplate.Height = 24
		Me.gvDonHang.Size = New System.Drawing.Size(775, 359)
		Me.gvDonHang.TabIndex = 2
		'
		'colMaTB
		'
		Me.colMaTB.HeaderText = "Mã HD"
		Me.colMaTB.MinimumWidth = 6
		Me.colMaTB.Name = "colMaTB"
		Me.colMaTB.ReadOnly = True
		'
		'Column2
		'
		Me.Column2.HeaderText = "Khách hàng"
		Me.Column2.MinimumWidth = 6
		Me.Column2.Name = "Column2"
		Me.Column2.ReadOnly = True
		'
		'colnv
		'
		Me.colnv.HeaderText = "Nhân viên"
		Me.colnv.MinimumWidth = 6
		Me.colnv.Name = "colnv"
		Me.colnv.ReadOnly = True
		'
		'Column1
		'
		Me.Column1.HeaderText = "Ngày tạo"
		Me.Column1.MinimumWidth = 6
		Me.Column1.Name = "Column1"
		Me.Column1.ReadOnly = True
		'
		'colDonGia
		'
		Me.colDonGia.HeaderText = "Thành tiền"
		Me.colDonGia.MinimumWidth = 6
		Me.colDonGia.Name = "colDonGia"
		Me.colDonGia.ReadOnly = True
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
		'frmDanhSachDonHang
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.gvDonHang)
		Me.Controls.Add(Me.btnThemDonHang)
		Me.Name = "frmDanhSachDonHang"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Danh sách đơn hàng"
		CType(Me.gvDonHang, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents btnThemDonHang As Button
	Friend WithEvents gvDonHang As DataGridView
	Friend WithEvents colMaTB As DataGridViewTextBoxColumn
	Friend WithEvents Column2 As DataGridViewTextBoxColumn
	Friend WithEvents colnv As DataGridViewTextBoxColumn
	Friend WithEvents Column1 As DataGridViewTextBoxColumn
	Friend WithEvents colDonGia As DataGridViewTextBoxColumn
	Friend WithEvents colDel As DataGridViewButtonColumn
End Class
