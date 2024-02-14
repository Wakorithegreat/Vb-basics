Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Click
        Me.WindowState = FormWindowState.Maximized

        Me.BackColor = Color.Red
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub
End Class
