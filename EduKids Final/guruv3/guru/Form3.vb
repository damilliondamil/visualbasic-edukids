Imports MySql.Data.MySqlClient

Public Class Form3


    Sub showscoresiswa()
        DS = New DataSet
        query = "SELECT * from tbl_score"
        DA = New MySqlDataAdapter(query, conn)
        DS.Clear()
        DA.Fill(DS, "tbl_score")
        dgv1.DataSource = DS.Tables(0)
    End Sub




    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        showscoresiswa()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs)
        conn.Open()
        query = "update tbl_score set komentar='" & txtkomen.Text & "' where id_score='" & txtidscore.Text & "'"
        cmd.CommandText = query
        cmd.ExecuteNonQuery()
        MsgBox("Comment berhasil ditambahkan atau diubah", vbInformation, "alert")
        showscoresiswa()
        conn.Close()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick

        Dim i As Integer
        i = dgv1.CurrentRow.Index
        txtidscore.Text = dgv1.Item(0, i).Value
        txtidsiswa.Text = dgv1.Item(1, i).Value
        txtscore.Text = dgv1.Item(2, i).Value
        Txttanggal.Text = dgv1.Item(3, i).Value
        txtkomen.Text = dgv1.Item(4, i).Value
    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        menuguru.Show()
    End Sub

    Private Sub btnedit_Click_1(sender As Object, e As EventArgs) Handles btnedit.Click
        conn.Open()
        query = "update tbl_score set komentar='" & txtkomen.Text & "' where id_score='" & txtidscore.Text & "'"
        cmd.CommandText = query
        cmd.ExecuteNonQuery()
        MsgBox("Comment berhasil ditambahkan atau diubah", vbInformation, "alert")
        showscoresiswa()
        conn.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        menuguru.Show()
        Me.Hide()
    End Sub
End Class