Imports System.Data.SqlClient
Imports System.Configuration
Public Module KetNoi
    Public conn As SqlConnection
    Public command As SqlCommand = New SqlCommand()
    Public sql As String
    Public TaiKhoan, MatKhau As String
    Public Sub MoKetNoi()
        If conn Is Nothing Then
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
            conn = New SqlConnection(connectionString)
        End If
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Public Sub DongKetNoi()
        conn.Close()
    End Sub
    Public Function LoadDuLieu(sql As String) As DataTable
        Dim Data As DataTable = New DataTable()
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(sql, conn)
        adapter.Fill(Data)
        Return Data
    End Function
    Public Sub LoadDataGridView(dgvName As DataGridView, sql As String)
        dgvName.DataSource = LoadDuLieu(sql)
    End Sub
End Module
