Imports MySql.Data.MySqlClient
Public Class Home
    Sub menampilkanscoreboard()
        DS = New DataSet
        query = "SELECT id_score, id_siswa, score, tanggal FROM tbl_score ORDER BY score DESC"
        DA = New MySqlDataAdapter(query, conn)
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        conn.Close()
    End Sub

    Sub menampilkannama()
        DS = New DataSet
        query = "select *  from tbl_siswa where id_siswa = '" & idkiriman & "'"
        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        lblid.Text = "ID Siswa : " & rd.Item("id_siswa")
        lblnama.Text = "Nama : " & rd.Item("nama_siswa")
        lblkelas.Text = "Kelas : " & rd.Item("kelas")
        idkiriman = rd.Item("id_siswa")
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menampilkannama()
        menampilkanscoreboard()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblid.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        menampilkanscoreboard()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        System.Windows.Forms.Application.Restart()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldate.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        report.Show()
    End Sub
End Class