<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLSP
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
        Me.lblMaSP = New System.Windows.Forms.Label()
        Me.lblTenSP = New System.Windows.Forms.Label()
        Me.lblDonGia = New System.Windows.Forms.Label()
        Me.lblSoLuong = New System.Windows.Forms.Label()
        Me.lblCTSP = New System.Windows.Forms.Label()
        Me.lblMaLoai = New System.Windows.Forms.Label()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.txtCTSP = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.dgvSP = New System.Windows.Forms.DataGridView()
        Me.cbxMaLoai = New System.Windows.Forms.ComboBox()
        CType(Me.dgvSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMaSP
        '
        Me.lblMaSP.AutoSize = True
        Me.lblMaSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaSP.Location = New System.Drawing.Point(28, 18)
        Me.lblMaSP.Name = "lblMaSP"
        Me.lblMaSP.Size = New System.Drawing.Size(44, 15)
        Me.lblMaSP.TabIndex = 0
        Me.lblMaSP.Text = "Mã SP"
        '
        'lblTenSP
        '
        Me.lblTenSP.AutoSize = True
        Me.lblTenSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenSP.Location = New System.Drawing.Point(25, 50)
        Me.lblTenSP.Name = "lblTenSP"
        Me.lblTenSP.Size = New System.Drawing.Size(47, 15)
        Me.lblTenSP.TabIndex = 1
        Me.lblTenSP.Text = "Tên SP"
        '
        'lblDonGia
        '
        Me.lblDonGia.AutoSize = True
        Me.lblDonGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDonGia.Location = New System.Drawing.Point(20, 82)
        Me.lblDonGia.Name = "lblDonGia"
        Me.lblDonGia.Size = New System.Drawing.Size(52, 15)
        Me.lblDonGia.TabIndex = 2
        Me.lblDonGia.Text = "Đơn Giá"
        '
        'lblSoLuong
        '
        Me.lblSoLuong.AutoSize = True
        Me.lblSoLuong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoLuong.Location = New System.Drawing.Point(12, 115)
        Me.lblSoLuong.Name = "lblSoLuong"
        Me.lblSoLuong.Size = New System.Drawing.Size(60, 15)
        Me.lblSoLuong.TabIndex = 3
        Me.lblSoLuong.Text = "Số Lượng"
        '
        'lblCTSP
        '
        Me.lblCTSP.AutoSize = True
        Me.lblCTSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCTSP.Location = New System.Drawing.Point(5, 148)
        Me.lblCTSP.Name = "lblCTSP"
        Me.lblCTSP.Size = New System.Drawing.Size(67, 15)
        Me.lblCTSP.TabIndex = 4
        Me.lblCTSP.Text = "Chi Tiết SP"
        '
        'lblMaLoai
        '
        Me.lblMaLoai.AutoSize = True
        Me.lblMaLoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaLoai.Location = New System.Drawing.Point(20, 181)
        Me.lblMaLoai.Name = "lblMaLoai"
        Me.lblMaLoai.Size = New System.Drawing.Size(52, 15)
        Me.lblMaLoai.TabIndex = 5
        Me.lblMaLoai.Text = "Mã Loại"
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(98, 17)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(141, 20)
        Me.txtMaSP.TabIndex = 6
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(98, 49)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(141, 20)
        Me.txtTenSP.TabIndex = 7
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(98, 81)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(141, 20)
        Me.txtDonGia.TabIndex = 8
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(98, 114)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(141, 20)
        Me.txtSoLuong.TabIndex = 9
        '
        'txtCTSP
        '
        Me.txtCTSP.Location = New System.Drawing.Point(98, 148)
        Me.txtCTSP.Name = "txtCTSP"
        Me.txtCTSP.Size = New System.Drawing.Size(141, 20)
        Me.txtCTSP.TabIndex = 10
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(15, 234)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 11
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(111, 234)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 12
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(207, 234)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 13
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'dgvSP
        '
        Me.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSP.Location = New System.Drawing.Point(258, 11)
        Me.dgvSP.Name = "dgvSP"
        Me.dgvSP.Size = New System.Drawing.Size(387, 200)
        Me.dgvSP.TabIndex = 14
        '
        'cbxMaLoai
        '
        Me.cbxMaLoai.FormattingEnabled = True
        Me.cbxMaLoai.Items.AddRange(New Object() {"VNM", "HLM", "LTM", "OTM", "YMM"})
        Me.cbxMaLoai.Location = New System.Drawing.Point(98, 181)
        Me.cbxMaLoai.Name = "cbxMaLoai"
        Me.cbxMaLoai.Size = New System.Drawing.Size(141, 21)
        Me.cbxMaLoai.TabIndex = 15
        '
        'frmQLSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 278)
        Me.Controls.Add(Me.cbxMaLoai)
        Me.Controls.Add(Me.dgvSP)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtCTSP)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.lblMaLoai)
        Me.Controls.Add(Me.lblCTSP)
        Me.Controls.Add(Me.lblSoLuong)
        Me.Controls.Add(Me.lblDonGia)
        Me.Controls.Add(Me.lblTenSP)
        Me.Controls.Add(Me.lblMaSP)
        Me.Name = "frmQLSP"
        Me.Text = "Quản Lý Sản Phẩm"
        CType(Me.dgvSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMaSP As System.Windows.Forms.Label
    Friend WithEvents lblTenSP As System.Windows.Forms.Label
    Friend WithEvents lblDonGia As System.Windows.Forms.Label
    Friend WithEvents lblSoLuong As System.Windows.Forms.Label
    Friend WithEvents lblCTSP As System.Windows.Forms.Label
    Friend WithEvents lblMaLoai As System.Windows.Forms.Label
    Friend WithEvents txtMaSP As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSP As System.Windows.Forms.TextBox
    Friend WithEvents txtDonGia As System.Windows.Forms.TextBox
    Friend WithEvents txtSoLuong As System.Windows.Forms.TextBox
    Friend WithEvents txtCTSP As System.Windows.Forms.TextBox
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents dgvSP As System.Windows.Forms.DataGridView
    Friend WithEvents cbxMaLoai As System.Windows.Forms.ComboBox
End Class
