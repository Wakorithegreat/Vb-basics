Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fontStyle As FontStyle = If(cbBold.Checked, FontStyle.Bold, FontStyle.Regular) Or If(cbItalic.Checked, FontStyle.Italic, FontStyle.Regular)
        Dim fontName As String = If(rbGaramond.Checked, "Garamond", If(rbMagneto.Checked, "Magneto", "Tahoma"))
        lblDisplayTest.Font = New Font(fontName, lblDisplayTest.Font.Size, fontStyle)

        ' Change the color based on the selected option
        lblDisplayTest.ForeColor = If(rbGreen.Checked, Color.Green, If(rbBlue.Checked, Color.Blue, Color.Red))
    End Sub

    Private Sub rbGaramond_CheckedChanged(sender As Object, e As EventArgs) Handles rbGaramond.CheckedChanged,
        rbMagneto.CheckedChanged, rbTahoma.CheckedChanged, cbBold.CheckedChanged, cbItalic.CheckedChanged,
        rbGreen.CheckedChanged, rbBlue.CheckedChanged, rbRed.CheckedChanged

        Form2_Load()

    End Sub

    Private Sub Form2_Load()
        Throw New NotImplementedException()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbItalic.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog As New OpenFileDialog


        openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF"
        openFileDialog.Title = "Select an Image"


        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Button1.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbBlue.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblDisplayTest.Click

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub
End Class



