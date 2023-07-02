Public Class Form2
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pgb1.Increment(3)
        If pgb1.Value = 100 Then
            Form1.Show()
            Me.Hide()
            Timer1.Stop()
        Else
            pgb1.Value = pgb1.Value + 1
            Label2.Text = pgb1.Value & " % "

        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class