Public Class Form2

    Dim firstvalue, secondvalue, result As Double
    Dim op As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        txtTextBox.Text = txtTextBox.Text + btn1.Text
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtTextBox.Text = txtTextBox.Text + btn2.Text

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtTextBox.Text = txtTextBox.Text + btn3.Text

    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtTextBox.Text = txtTextBox.Text + btn4.Text

    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtTextBox.Text = txtTextBox.Text + btn5.Text

    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtTextBox.Text = txtTextBox.Text + btn6.Text

    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtTextBox.Text = txtTextBox.Text + btn7.Text

    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtTextBox.Text = txtTextBox.Text + btn8.Text

    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtTextBox.Text = txtTextBox.Text + btn9.Text

    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtTextBox.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FromB As New Form1()
        FromB.Show()
    End Sub



    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click

        Dim btnPlus As Button = sender

        firstvalue = txtTextBox.Text

        op = btnPlus.Text

        txtTextBox.Text = ""


    End Sub

    Private Sub btnMine_Click(sender As Object, e As EventArgs) Handles btnMine.Click

        Dim btnMine As Button = sender

        firstvalue = txtTextBox.Text

        op = btnMine.Text

        txtTextBox.Text = ""
    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click

        Dim btnMult As Button = sender

        firstvalue = txtTextBox.Text

        op = btnMult.Text

        txtTextBox.Text = ""
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click

        Dim btnDivision As Button = sender

        firstvalue = txtTextBox.Text

        op = btnDivision.Text

        txtTextBox.Text = ""
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        secondvalue = txtTextBox.Text
        If op = "+" Then
            result = firstvalue + secondvalue
            txtTextBox.Text = result
        ElseIf op = "-" Then
            result = firstvalue - secondvalue
            txtTextBox.Text = result
        ElseIf op = "*" Then
            result = firstvalue * secondvalue
            txtTextBox.Text = result
        ElseIf op = "/" Then
            result = firstvalue / secondvalue
            txtTextBox.Text = result
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtTextBox.Text = txtTextBox.Text + btn0.Text
    End Sub

    Private Sub btndoc_Click(sender As Object, e As EventArgs) Handles btndoc.Click
        txtTextBox.Text = txtTextBox.Text + btndoc.Text
    End Sub

    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
        txtTextBox.Text = "0"
    End Sub

    Private Sub btnPM_Click(sender As Object, e As EventArgs) Handles btnPM.Click
        If (txtTextBox.Text.Contains("-")) Then
            txtTextBox.Text = txtTextBox.Text.Remove(0, 1)
        Else
            txtTextBox.Text = "-" + txtTextBox.Text

        End If
    End Sub

    Private Sub btnBs_Click(sender As Object, e As EventArgs) Handles btnBs.Click
        If (txtTextBox.Text.Length > 0) Then
            txtTextBox.Text = txtTextBox.Text.Remove(txtTextBox.Text.Length - 1, 1)
        End If
        ' If (txtTextBox.Text = "") Then
        'txtTextBox.Text = "0"
        ' End If
    End Sub


End Class