<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThietBi_AddOrUpdate
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtMaTB = New System.Windows.Forms.TextBox()
		Me.txtTenTB = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.numSL = New System.Windows.Forms.NumericUpDown()
		Me.dtBaoHanh = New System.Windows.Forms.DateTimePicker()
		Me.cbNCC = New System.Windows.Forms.ComboBox()
		Me.btnThem = New System.Windows.Forms.Button()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtLoaiChip = New System.Windows.Forms.TextBox()
		Me.txtDonGia = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		CType(Me.numSL, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(51, 24)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(73, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Mã thiết bị"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(51, 79)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(79, 17)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Tên thiết bị"
		'
		'txtMaTB
		'
		Me.txtMaTB.Enabled = False
		Me.txtMaTB.Location = New System.Drawing.Point(54, 45)
		Me.txtMaTB.Name = "txtMaTB"
		Me.txtMaTB.Size = New System.Drawing.Size(131, 22)
		Me.txtMaTB.TabIndex = 1
		'
		'txtTenTB
		'
		Me.txtTenTB.Location = New System.Drawing.Point(54, 99)
		Me.txtTenTB.Name = "txtTenTB"
		Me.txtTenTB.Size = New System.Drawing.Size(231, 22)
		Me.txtTenTB.TabIndex = 1
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(51, 137)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(96, 17)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "Nhà cung cấp"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(51, 323)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(64, 17)
		Me.Label4.TabIndex = 0
		Me.Label4.Text = "Số lượng"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(51, 386)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(69, 17)
		Me.Label5.TabIndex = 0
		Me.Label5.Text = "Bảo hành"
		'
		'numSL
		'
		Me.numSL.Location = New System.Drawing.Point(54, 343)
		Me.numSL.Name = "numSL"
		Me.numSL.Size = New System.Drawing.Size(231, 22)
		Me.numSL.TabIndex = 3
		'
		'dtBaoHanh
		'
		Me.dtBaoHanh.CustomFormat = "dd/MM/yyyy"
		Me.dtBaoHanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtBaoHanh.Location = New System.Drawing.Point(54, 407)
		Me.dtBaoHanh.Name = "dtBaoHanh"
		Me.dtBaoHanh.Size = New System.Drawing.Size(231, 22)
		Me.dtBaoHanh.TabIndex = 4
		'
		'cbNCC
		'
		Me.cbNCC.FormattingEnabled = True
		Me.cbNCC.Location = New System.Drawing.Point(54, 157)
		Me.cbNCC.Name = "cbNCC"
		Me.cbNCC.Size = New System.Drawing.Size(231, 24)
		Me.cbNCC.TabIndex = 2
		'
		'btnThem
		'
		Me.btnThem.Location = New System.Drawing.Point(54, 447)
		Me.btnThem.Name = "btnThem"
		Me.btnThem.Size = New System.Drawing.Size(231, 35)
		Me.btnThem.TabIndex = 5
		Me.btnThem.Text = "Thêm"
		Me.btnThem.UseVisualStyleBackColor = True
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(51, 197)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(65, 17)
		Me.Label6.TabIndex = 0
		Me.Label6.Text = "Loại chip"
		'
		'txtLoaiChip
		'
		Me.txtLoaiChip.Location = New System.Drawing.Point(54, 217)
		Me.txtLoaiChip.Name = "txtLoaiChip"
		Me.txtLoaiChip.Size = New System.Drawing.Size(231, 22)
		Me.txtLoaiChip.TabIndex = 3
		'
		'txtDonGia
		'
		Me.txtDonGia.Location = New System.Drawing.Point(54, 278)
		Me.txtDonGia.Name = "txtDonGia"
		Me.txtDonGia.Size = New System.Drawing.Size(231, 22)
		Me.txtDonGia.TabIndex = 7
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(51, 258)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(57, 17)
		Me.Label7.TabIndex = 6
		Me.Label7.Text = "Đơn giá"
		'
		'frmThietBi_AddOrUpdate
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(344, 508)
		Me.Controls.Add(Me.txtDonGia)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.btnThem)
		Me.Controls.Add(Me.cbNCC)
		Me.Controls.Add(Me.dtBaoHanh)
		Me.Controls.Add(Me.numSL)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtLoaiChip)
		Me.Controls.Add(Me.txtTenTB)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.txtMaTB)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "frmThietBi_AddOrUpdate"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Thêm thiết bị"
		CType(Me.numSL, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents txtMaTB As TextBox
	Friend WithEvents txtTenTB As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents numSL As NumericUpDown
	Friend WithEvents dtBaoHanh As DateTimePicker
	Friend WithEvents cbNCC As ComboBox
	Friend WithEvents btnThem As Button
	Friend WithEvents Label6 As Label
	Friend WithEvents txtLoaiChip As TextBox
	Friend WithEvents txtDonGia As TextBox
	Friend WithEvents Label7 As Label
End Class
