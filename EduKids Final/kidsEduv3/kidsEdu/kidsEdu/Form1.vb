Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dtable As New DataTable
        DS = New DataSet
        query = "select id_siswa,password from tbl_siswa where id_siswa='" & TextBox1.Text & "' AND password = '" & TextBox2.Text & "' "
        DA = New MySqlDataAdapter(query, conn)
        DA.Fill(dtable)
        If dtable.Rows.Count = Nothing Then
            MsgBox("Id siswa atau password salah")
        Else
            MsgBox("Login Berhasil")
            idkiriman = TextBox1.Text
            Me.Hide()
            Home.Show()
            conn.Close()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
    End Sub
End Class
