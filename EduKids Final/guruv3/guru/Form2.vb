Imports MySql.Data.MySqlClient
Public Class Form2

    Sub menampilkandatasiswa()
        DS = New DataSet
        query = "SELECT * from tbl_siswa"
        DA = New MySqlDataAdapter(query, conn)
        DA.Fill(DS)
        dgv1.DataSource = DS.Tables(0)

    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menampilkandatasiswa()
    End Sub

    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        conn.Open()
        query = "INSERT INTO tbl_siswa (id_siswa, password, nama_siswa, kelas, email)
                VALUES('" & txtid.Text & "','" & txtpw.Text & "', '" & txtname.Text & "', '" & txkelas.Text & "','" & txtemail.Text & "')"
        cmd.CommandText = query
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Ditambahkan ", vbInformation, "alert")
        menampilkandatasiswa()
        txtid.Text = ("")
        txtpw.Text = ("")
        txtname.Text = ("")
        txkelas.Text = ("")
        txtemail.Text = ("")
        conn.Close()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        conn.Open()
        query = "update tbl_siswa set password= '" & txtpw.Text & "', nama_siswa='" & txtname.Text & "', kelas='" & txkelas.Text & "', email='" & txtemail.Text & "' where id_siswa = '" & txtid.Text & "'"
        cmd.CommandText = query
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Diedit", vbInformation, "alert")
        menampilkandatasiswa()
        conn.Close()

    End Sub

    Private Sub dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index

        txtid.Text = dgv1.Item(0, i).Value
        txtpw.Text = dgv1.Item(1, i).Value
        txtname.Text = dgv1.Item(2, i).Value
        txkelas.Text = dgv1.Item(3, i).Value
        txtemail.Text = dgv1.Item(4, i).Value
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If MsgBox("Apakah anda yakin ingin menghapusnya?", vbYesNo) = vbYes Then
            conn.Open()
            query = " delete from tbl_siswa where id_siswa= '" & txtid.Text & "' "
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhail Dihapus", vbInformation, "alert")
            menampilkandatasiswa()
            txtid.Text = ("")
            txtpw.Text = ("")
            txtname.Text = ("")
            txkelas.Text = ("")
            txtemail.Text = ("")
            conn.Close()
        End If

    End Sub

    Private Sub lblidgr_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        menuguru.Show()
        Me.Hide()
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub
End Class