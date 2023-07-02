Imports MySql.Data.MySqlClient
Public Class menuguru

    Sub showdataguru()
        DS = New DataSet
        query = "select *  from tbl_guru where id_guru = '" & idkiriman & "'"
        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        lblidgr.Text = "ID Guru : " & rd.Item("id_guru")
        lblnmgr.Text = "Nama Guru : " & rd.Item("nama_guru")
        conn.Close()

    End Sub
    Private Sub menuguru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showdataguru()
        Form1.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.Windows.Forms.Application.Restart()
    End Sub
End Class