Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Form3
    Dim scoretotal, score1, score2, score3, score4, score5 As Integer
    Dim FIlepath As String
    Dim file_counter As Integer

    Sub playvideo()
        AxWindowsMediaPlayer1.URL = FIlepath
        AxWindowsMediaPlayer1.Ctlcontrols.play()

    End Sub

    Sub hitungscore()
        scoretotal = 0

        If RadioButton1.Checked Then
            score1 = 20
        End If

        If RadioButton10.Checked Then
            score2 = 20
        End If

        If RadioButton5.Checked Then
            score3 = 20
        End If

        If RadioButton16.Checked Then
            score4 = 20
        End If

        If RadioButton20.Checked Then
            score5 = 20
        End If

        scoretotal = score1 + score2 + score3 + score4 + score5
        MsgBox("Score anda:" & scoretotal)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lbldetik.Text += 1
        If lbldetik.Text >= 60 Then
            Timer2.Stop()
            Button2.PerformClick()
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        AxWindowsMediaPlayer1.uiMode = "full"
        FIlepath = Path.Combine(Application.StartupPath, "piano.mp4")
        If (Not File.Exists(FIlepath)) Then
            File.WriteAllBytes(FIlepath, My.Resources.piano)
        End If
        file_counter = 1
        playvideo()


    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If GroupBox1.Visible = True Then
            GroupBox1.Visible = False
            GroupBox2.Visible = True

        ElseIf GroupBox2.Visible = True Then
            GroupBox2.Visible = False
            GroupBox3.Visible = True

        ElseIf GroupBox3.Visible = True Then
            GroupBox3.Visible = False
            GroupBox4.Visible = True


        ElseIf GroupBox4.Visible = True Then
            GroupBox4.Visible = False
            GroupBox5.Visible = True
            Button2.Visible = True
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If GroupBox2.Visible = True Then
            GroupBox2.Visible = False
            GroupBox1.Visible = True

        ElseIf GroupBox3.Visible = True Then
            GroupBox3.Visible = False
            GroupBox2.Visible = True

        ElseIf GroupBox4.Visible = True Then
            GroupBox4.Visible = False
            GroupBox3.Visible = True
            AxWindowsMediaPlayer1.Ctlcontrols.stop()

        ElseIf GroupBox5.Visible = True Then
            GroupBox5.Visible = False
            GroupBox4.Visible = True
            Button2.Visible = False
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        hitungscore()
        conn.Open()
        query = "insert into tbl_score(id_siswa, score, tanggal) VALUES ('" & idkiriman & "','" & scoretotal & "', '" & lbldate.Text & "')"
        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader
        MsgBox("Data berhasil ditambahkan", vbInformation, "Announcement")
        conn.Close()
        Me.Hide()
        Home.Show()

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.mixkit_wild_lion_animal_roar_6, AudioPlayMode.Background)
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.uiMode = "full"
        FIlepath = Path.Combine(Application.StartupPath, "piano.mp4")
        If (Not File.Exists(FIlepath)) Then
            File.WriteAllBytes(FIlepath, My.Resources.piano)
        End If
        file_counter = 1
        playvideo()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        hitungscore()
        cmd.Connection = conn
        conn.Open()
        query = "insert into tbl_score(id_siswa, score, tanggal) VALUES ('" & idkiriman & "','" & scoretotal & "', '" & lbldate.Text & "')"
        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader
        MsgBox("Data berhasil ditambahkan", vbInformation, "Announcement")
        conn.Close()
        System.Windows.Forms.Application.Restart()
    End Sub

    Private Sub Form3_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        MsgBox("Selesaikan Quiz terlebih dahulu")
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GroupBox2.Hide()
        GroupBox3.Hide()
        GroupBox4.Hide()
        GroupBox5.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        lbldate.Text = Date.Now.ToString("dd-MM-yyyy -  hh:mm:ss")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldate.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        My.Computer.Audio.Play(My.Resources.mixkit_wild_lion_animal_roar_6, AudioPlayMode.Background)
    End Sub
End Class