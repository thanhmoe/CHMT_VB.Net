<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThietBi
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
		Me.gvThietBi = New System.Windows.Forms.DataGridView()
		Me.btnThemTB = New System.Windows.Forms.Button()
		Me.colMaTB = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colTenTB = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colNCC = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colChip = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colSoLuong = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colDonGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colEdit = New System.Windows.Forms.DataGridViewButtonColumn()
		Me.colDel = New System.Windows.Forms.DataGridViewButtonColumn()
		CType(Me.gvThietBi, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'gvThietBi
		'
		Me.gvThietBi.AllowUserToAddRows = False
		Me.gvThietBi.AllowUserToDeleteRows = False
		Me.gvThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.gvThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.gvThietBi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMaTB, Me.colTenTB, Me.colNCC, Me.colChip, Me.colSoLuong, Me.colDonGia, Me.colEdit, Me.colDel})
		Me.gvThietBi.Location = New System.Drawing.Point(12, 88)
		Me.gvThietBi.Name = "gvThietBi"
		Me.gvThietBi.ReadOnly = True
		Me.gvThietBi.RowHeadersWidth = 49
		Me.gvThietBi.RowTemplate.Height = 24
		Me.gvThietBi.Size = New System.Drawing.Size(901, 318)
		Me.gvThietBi.TabIndex = 1
		'
		'btnThemTB
		'
		Me.btnThemTB.Location = New System.Drawing.Point(12, 12)
		Me.btnThemTB.Name = "btnThemTB"
		Me.btnThemTB.Size = New System.Drawing.Size(126, 55)
		Me.btnThemTB.TabIndex = 2
		Me.btnThemTB.Text = "Thêm thiết bị"
		Me.btnThemTB.UseVisualStyleBackColor = True
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
		'colNCC
		'
		Me.colNCC.HeaderText = "NCC"
		Me.colNCC.MinimumWidth = 6
		Me.colNCC.Name = "colNCC"
		Me.colNCC.ReadOnly = True
		'
		'colChip
		'
		Me.colChip.HeaderText = "Chip"
		Me.colChip.MinimumWidth = 6
		Me.colChip.Name = "colChip"
		Me.colChip.ReadOnly = True
		'
		'colSoLuong
		'
		Me.colSoLuong.HeaderText = "Số Lượng"
		Me.colSoLuong.MinimumWidth = 6
		Me.colSoLuong.Name = "colSoLuong"
		Me.colSoLuong.ReadOnly = True
		'
		'colDonGia
		'
		Me.colDonGia.HeaderText = "Đơn giá"
		Me.colDonGia.MinimumWidth = 6
		Me.colDonGia.Name = "colDonGia"
		Me.colDonGia.ReadOnly = True
		'
		'colEdit
		'
		Me.colEdit.FillWeight = 50.0!
		Me.colEdit.HeaderText = ""
		Me.colEdit.MinimumWidth = 6
		Me.colEdit.Name = "colEdit"
		Me.colEdit.ReadOnly = True
		Me.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.colEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
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
		'frmThietBi
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(925, 432)
		Me.Controls.Add(Me.btnThemTB)
		Me.Controls.Add(Me.gvThietBi)
		Me.Name = "frmThietBi"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Danh sách thiết bị"
		CType(Me.gvThietBi, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents gvThietBi As DataGridView
	Friend WithEvents btnThemTB As Button
	Friend WithEvents colMaTB As DataGridViewTextBoxColumn
	Friend WithEvents colTenTB As DataGridViewTextBoxColumn
	Friend WithEvents colNCC As DataGridViewTextBoxColumn
	Friend WithEvents colChip As DataGridViewTextBoxColumn
	Friend WithEvents colSoLuong As DataGridViewTextBoxColumn
	Friend WithEvents colDonGia As DataGridViewTextBoxColumn
	Friend WithEvents colEdit As DataGridViewButtonColumn
	Friend WithEvents colDel As DataGridViewButtonColumn
End Class
