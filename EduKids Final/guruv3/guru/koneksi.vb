Imports MySql.Data.MySqlClient

Module koneksi
    Public conn As New MySqlConnection
    Public query As String
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader



    Sub connect()
        Try
            conn.Close()
            conn.ConnectionString = "server=localhost; user id=root; password=; database=db_kidsedu"
            conn.Open()
        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try
    End Sub




End Module