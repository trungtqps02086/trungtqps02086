Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmQLSP
    Dim tb As New DataTable
    Dim connect As String = "workstation id=PS02086.mssql.somee.com;packet size=4096;user id=trungtq;pwd=abc12345;data source=PS02086.mssql.somee.com;persist security info=False;initial catalog=PS02086"
  
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim ketnoi As SqlConnection = New SqlConnection(connect)
        Dim sql3 As String = "delete from SanPham where MaSP=@MaSP"
        Dim truyvan2 As New SqlCommand(sql3, ketnoi)
        ketnoi.Open()
        truyvan2.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
        truyvan2.ExecuteNonQuery()
        MessageBox.Show("Xóa Thành Công")
        Dim Focus As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", ketnoi)
        tb.Clear()
        Focus.Fill(tb)
        dgvSP.DataSource = tb

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSP.CellContentClick
        'Khi click vào 1 cell bất kỳ, lấy giá trị tại dòng đó đưa lên các textbox tương ứng
        Dim index As Integer = dgvSP.CurrentCell.RowIndex
        txtMaSP.Text = dgvSP.Item(0, index).Value
        txtTenSP.Text = dgvSP.Item(1, index).Value
        txtDonGia.Text = dgvSP.Item(2, index).Value
        txtSoLuong.Text = dgvSP.Item(3, index).Value
        txtCTSP.Text = dgvSP.Item(4, index).Value
        cbxMaLoai.SelectedItem = dgvSP.Item(5, index).Value
    End Sub

    Private Sub frmQLSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ketnoi As New SqlConnection(connect)
        Dim sqlAdapter As New SqlDataAdapter("select * from SanPham", connect)
        ketnoi.Open()
        sqlAdapter.Fill(tb)
        dgvSP.DataSource = tb
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim ketnoi As SqlConnection = New SqlConnection(connect)
        Dim sql As String = "insert into SanPham values(@MaSP,@TenSP,@DonGia,@SoLuong,@ChiTietSP,@MaLoai)"
        Dim truyvan As New SqlCommand(sql, ketnoi)
        ketnoi.Open()
        truyvan.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
        truyvan.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
        truyvan.Parameters.AddWithValue("@DonGia", txtDonGia.Text)
        truyvan.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text)
        truyvan.Parameters.AddWithValue("@ChiTietSP", txtCTSP.Text)
        truyvan.Parameters.AddWithValue("@MaLoai", cbxMaLoai.SelectedItem)
        truyvan.ExecuteNonQuery()
        MessageBox.Show("Thêm Thành Công")
        Dim sql1 As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", ketnoi)
        tb.Clear()
        sql1.Fill(tb)
        dgvSP.DataSource = tb
    End Sub

    Private Sub cbxMaLoai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMaLoai.SelectedIndexChanged

    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim ketnoi As SqlConnection = New SqlConnection(connect)
        Dim sql2 As String = "UPDATE SanPham Set TenSP = @TenSP, DonGia = @DonGia, SoLuong = @soluong, ChiTietSP = @ChiTietSP, LoaiSanPham_MaLoai = @MaLoai Where MaSP = @MaSP"
        Dim truyvan1 As New SqlCommand(sql2, ketnoi)
        ketnoi.Open()
        truyvan1.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
        truyvan1.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
        truyvan1.Parameters.AddWithValue("@DonGia", txtDonGia.Text)
        truyvan1.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text)
        truyvan1.Parameters.AddWithValue("@ChiTietSP", txtCTSP.Text)
        truyvan1.Parameters.AddWithValue("@MaLoai", cbxMaLoai.SelectedItem)
        truyvan1.ExecuteNonQuery()

        MessageBox.Show("Sửa Thành Công")
        Dim Focus As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", ketnoi)
        tb.Clear()
        Focus.Fill(tb)
        dgvSP.DataSource = tb

    End Sub
End Class