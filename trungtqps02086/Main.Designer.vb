<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HệThốngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýNhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnTrịToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýKháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HỗTrợToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HỗTrợToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HệThốngToolStripMenuItem, Me.NhânViênToolStripMenuItem, Me.QuảnTrịToolStripMenuItem, Me.HỗTrợToolStripMenuItem, Me.HỗTrợToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(467, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HệThốngToolStripMenuItem
        '
        Me.HệThốngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThoátToolStripMenuItem})
        Me.HệThốngToolStripMenuItem.Name = "HệThốngToolStripMenuItem"
        Me.HệThốngToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.HệThốngToolStripMenuItem.Text = "Hệ Thống"
        '
        'NhânViênToolStripMenuItem
        '
        Me.NhânViênToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýNhânViênToolStripMenuItem})
        Me.NhânViênToolStripMenuItem.Name = "NhânViênToolStripMenuItem"
        Me.NhânViênToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.NhânViênToolStripMenuItem.Text = "Nhân Viên"
        '
        'QuảnLýNhânViênToolStripMenuItem
        '
        Me.QuảnLýNhânViênToolStripMenuItem.Name = "QuảnLýNhânViênToolStripMenuItem"
        Me.QuảnLýNhânViênToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.QuảnLýNhânViênToolStripMenuItem.Text = "Quản Lý Nhân Viên"
        '
        'QuảnTrịToolStripMenuItem
        '
        Me.QuảnTrịToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýKháchHàngToolStripMenuItem})
        Me.QuảnTrịToolStripMenuItem.Name = "QuảnTrịToolStripMenuItem"
        Me.QuảnTrịToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.QuảnTrịToolStripMenuItem.Text = "Khách Hàng"
        '
        'QuảnLýKháchHàngToolStripMenuItem
        '
        Me.QuảnLýKháchHàngToolStripMenuItem.Name = "QuảnLýKháchHàngToolStripMenuItem"
        Me.QuảnLýKháchHàngToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.QuảnLýKháchHàngToolStripMenuItem.Text = "Quản Lý Khách Hàng"
        '
        'HỗTrợToolStripMenuItem
        '
        Me.HỗTrợToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýSảnPhẩmToolStripMenuItem})
        Me.HỗTrợToolStripMenuItem.Name = "HỗTrợToolStripMenuItem"
        Me.HỗTrợToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.HỗTrợToolStripMenuItem.Text = "Sản Phẩm"
        '
        'QuảnLýSảnPhẩmToolStripMenuItem
        '
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Name = "QuảnLýSảnPhẩmToolStripMenuItem"
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Text = "Quản Lý Sản Phẩm"
        '
        'HỗTrợToolStripMenuItem1
        '
        Me.HỗTrợToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.HỗTrợToolStripMenuItem1.Name = "HỗTrợToolStripMenuItem1"
        Me.HỗTrợToolStripMenuItem1.Size = New System.Drawing.Size(56, 20)
        Me.HỗTrợToolStripMenuItem1.Text = "Hỗ Trợ"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.HelpToolStripMenuItem.Text = "Help (F1)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.sua_dau_nanh_vinamilk_2
        Me.PictureBox1.Location = New System.Drawing.Point(6, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(454, 236)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 269)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HệThốngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NhânViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnTrịToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HỗTrợToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents QuảnLýNhânViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýKháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HỗTrợToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
