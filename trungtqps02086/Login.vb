Imports System.Data.SqlClient
Public Class frmLogin
   
    Private Sub lblusername_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub btndangnhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        Dim chuoiketnoi As String = "workstation id=PS02086.mssql.somee.com;packet size=4096;user id=trungtq;pwd=abc12345;data source=PS02086.mssql.somee.com;persist security info=False;initial catalog=PS02086"
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien where MaNV= '" & txtUser.Text & " ' and Password= '" & txtPass.Text & "' ", ketnoi)
        Dim tb As New DataTable
        Try
            ketnoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Đăng Nhập Thành Công")
                frmMain.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai tai khoan hoac mat khau")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        txtUser.Clear()
        txtPass.Clear()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Demo test chinh sua
    End Sub
End Class
