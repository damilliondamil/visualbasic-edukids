Imports MySql.Data.MySqlClient

Public Class report

    Sub showscoresiswa()
        DS = New DataSet
        query = "SELECT * from tbl_score where id_siswa = '" & idkiriman & "'"
        DA = New MySqlDataAdapter(query, conn)
        DS.Clear()
        DA.Fill(DS, "tbl_score")
        dgv1.DataSource = DS.Tables(0)
    End Sub

    Private Sub report_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        showscoresiswa()

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index

        TextBox1.Text = dgv1.Item(0, i).Value
        TextBox2.Text = dgv1.Item(1, i).Value
        TextBox3.Text = dgv1.Item(2, i).Value
        TextBox4.Text = dgv1.Item(3, i).Value
        TextBox5.Text = dgv1.Item(4, i).Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        showscoresiswa()
    End Sub
End Class