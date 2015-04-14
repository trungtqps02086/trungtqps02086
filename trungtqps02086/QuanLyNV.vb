Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmQLNV
    Dim tb As New DataTable
    Dim connect As String = "workstation id=PS02086.mssql.somee.com;packet size=4096;user id=trungtq;pwd=abc12345;data source=PS02086.mssql.somee.com;persist security info=False;initial catalog=PS02086"
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim ketnoi As SqlConnection = New SqlConnection(connect)
        Dim sql As String = "insert into NhanVien values(@MaNV,@Pass,@TenNV,@SoDT,@DiaChi)"
        Dim truyvan As New SqlCommand(sql, ketnoi)
        ketnoi.Open()
        truyvan.Parameters.AddWithValue("@MaNV", txtMaNV.Text)
        truyvan.Parameters.AddWithValue("@Pass", txtTenNV.Text)
        truyvan.Parameters.AddWithValue("@TenNV", txtTenNV.Text)
        truyvan.Parameters.AddWithValue("@SoDT", txtSoDT.Text)
        truyvan.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
        truyvan.ExecuteNonQuery()
        MessageBox.Show("Thêm Thành Công")
        Dim sql1 As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", ketnoi)
        tb.Clear()
        sql1.Fill(tb)
        dgvNV.DataSource = tb
    End Sub

    Private Sub frmQLNV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ketnoi As New SqlConnection(connect)
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien", connect)
        ketnoi.Open()
        sqlAdapter.Fill(tb)
        dgvNV.DataSource = tb
    End Sub

    Private Sub dgvNV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNV.CellContentClick
        Dim index As Integer = dgvNV.CurrentCell.RowIndex
        txtMaNV.Text = dgvNV.Item(0, index).Value
        txtPass.Text = dgvNV.Item(1, index).Value
        txtTenNV.Text = dgvNV.Item(2, index).Value
        txtSoDT.Text = dgvNV.Item(3, index).Value
        txtDiaChi.Text = dgvNV.Item(4, index).Value
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim ketnoi As SqlConnection = New SqlConnection(connect)
        Dim sql3 As String = "delete from NhanVien where MaNV=@MaNV"
        Dim truyvan2 As New SqlCommand(sql3, ketnoi)
        ketnoi.Open()
        truyvan2.Parameters.AddWithValue("@MaNV", txtMaNV.Text)
        truyvan2.ExecuteNonQuery()
        MessageBox.Show("Xóa Thành Công")
        Dim Focus As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", ketnoi)
        tb.Clear()
        Focus.Fill(tb)
        dgvNV.DataSource = tb
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim ketnoi As SqlConnection = New SqlConnection(connect)
        Dim sql2 As String = "UPDATE NhanVien Set Password = @Pass, TenNV = @TenNV, SoDT = @SoDT, DiaChi = @DiaChi Where MaNV = @MaNV"
        Dim truyvan1 As New SqlCommand(sql2, ketnoi)
        ketnoi.Open()
        truyvan1.Parameters.AddWithValue("@MaNV", txtMaNV.Text)
        truyvan1.Parameters.AddWithValue("@Pass", txtPass.Text)
        truyvan1.Parameters.AddWithValue("@TenNV", txtTenNV.Text)
        truyvan1.Parameters.AddWithValue("@SoDT", txtSoDT.Text)
        truyvan1.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
        truyvan1.ExecuteNonQuery()

        MessageBox.Show("Sửa Thành Công")
        Dim Focus As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", ketnoi)
        tb.Clear()
        Focus.Fill(tb)
        dgvNV.DataSource = tb
    End Sub
End Class