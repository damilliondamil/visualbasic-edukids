Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dtable As New DataTable
        DS = New DataSet
        query = "select id_guru,password from tbl_guru where id_guru='" & idguru.Text & "' AND password = '" & pwguru.Text & "' "
        DA = New MySqlDataAdapter(query, conn)
        DA.Fill(dtable)
        If dtable.Rows.Count = Nothing Then
            MsgBox("Id guru atau password salah")
        Else
            MsgBox("Login Berhasil")
            idkiriman = idguru.Text
            Me.Hide()
            menuguru.Show()
            conn.Close()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub idguru_TextChanged(sender As Object, e As EventArgs) Handles idguru.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub pwguru_TextChanged(sender As Object, e As EventArgs) Handles pwguru.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub label1_Click(sender As Object, e As EventArgs) Handles label1.Click

    End Sub
End Class
