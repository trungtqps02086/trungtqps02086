<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLNV
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
        Me.dgvNV = New System.Windows.Forms.DataGridView()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtSoDT = New System.Windows.Forms.TextBox()
        Me.txtTenNV = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.lblDiaChi = New System.Windows.Forms.Label()
        Me.lblSoDT = New System.Windows.Forms.Label()
        Me.lblTenNV = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblMaNV = New System.Windows.Forms.Label()
        CType(Me.dgvNV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvNV
        '
        Me.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNV.Location = New System.Drawing.Point(240, 7)
        Me.dgvNV.Name = "dgvNV"
        Me.dgvNV.Size = New System.Drawing.Size(339, 170)
        Me.dgvNV.TabIndex = 30
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(200, 196)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 29
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(107, 196)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 28
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(15, 196)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 27
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(80, 144)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(141, 20)
        Me.txtDiaChi.TabIndex = 26
        '
        'txtSoDT
        '
        Me.txtSoDT.Location = New System.Drawing.Point(80, 110)
        Me.txtSoDT.Name = "txtSoDT"
        Me.txtSoDT.Size = New System.Drawing.Size(141, 20)
        Me.txtSoDT.TabIndex = 25
        '
        'txtTenNV
        '
        Me.txtTenNV.Location = New System.Drawing.Point(80, 77)
        Me.txtTenNV.Name = "txtTenNV"
        Me.txtTenNV.Size = New System.Drawing.Size(141, 20)
        Me.txtTenNV.TabIndex = 24
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(80, 45)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(141, 20)
        Me.txtPass.TabIndex = 23
        '
        'txtMaNV
        '
        Me.txtMaNV.Location = New System.Drawing.Point(80, 13)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(141, 20)
        Me.txtMaNV.TabIndex = 22
        '
        'lblDiaChi
        '
        Me.lblDiaChi.AutoSize = True
        Me.lblDiaChi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiaChi.Location = New System.Drawing.Point(22, 144)
        Me.lblDiaChi.Name = "lblDiaChi"
        Me.lblDiaChi.Size = New System.Drawing.Size(47, 15)
        Me.lblDiaChi.TabIndex = 20
        Me.lblDiaChi.Text = "Địa Chỉ"
        '
        'lblSoDT
        '
        Me.lblSoDT.AutoSize = True
        Me.lblSoDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoDT.Location = New System.Drawing.Point(28, 111)
        Me.lblSoDT.Name = "lblSoDT"
        Me.lblSoDT.Size = New System.Drawing.Size(41, 15)
        Me.lblSoDT.TabIndex = 19
        Me.lblSoDT.Text = "Số ĐT"
        '
        'lblTenNV
        '
        Me.lblTenNV.AutoSize = True
        Me.lblTenNV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenNV.Location = New System.Drawing.Point(25, 78)
        Me.lblTenNV.Name = "lblTenNV"
        Me.lblTenNV.Size = New System.Drawing.Size(47, 15)
        Me.lblTenNV.TabIndex = 18
        Me.lblTenNV.Text = "Tên NV"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(11, 45)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(61, 15)
        Me.lblPass.TabIndex = 17
        Me.lblPass.Text = "Password"
        '
        'lblMaNV
        '
        Me.lblMaNV.AutoSize = True
        Me.lblMaNV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaNV.Location = New System.Drawing.Point(28, 14)
        Me.lblMaNV.Name = "lblMaNV"
        Me.lblMaNV.Size = New System.Drawing.Size(44, 15)
        Me.lblMaNV.TabIndex = 16
        Me.lblMaNV.Text = "Mã NV"
        '
        'frmQLNV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 236)
        Me.Controls.Add(Me.dgvNV)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtSoDT)
        Me.Controls.Add(Me.txtTenNV)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtMaNV)
        Me.Controls.Add(Me.lblDiaChi)
        Me.Controls.Add(Me.lblSoDT)
        Me.Controls.Add(Me.lblTenNV)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblMaNV)
        Me.Name = "frmQLNV"
        Me.Text = "Quản Lý Nhân viên"
        CType(Me.dgvNV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvNV As System.Windows.Forms.DataGridView
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txtSoDT As System.Windows.Forms.TextBox
    Friend WithEvents txtTenNV As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtMaNV As System.Windows.Forms.TextBox
    Friend WithEvents lblDiaChi As System.Windows.Forms.Label
    Friend WithEvents lblSoDT As System.Windows.Forms.Label
    Friend WithEvents lblTenNV As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents lblMaNV As System.Windows.Forms.Label
End Class
