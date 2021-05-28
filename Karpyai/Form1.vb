Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FromA As New Form2()
        FromA.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' PictureBox1.ImageLocation = " ../../PictureC/background1.png"
        PictureBox1.ImageLocation = "../../PictureC/LonlyI.jpg"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
