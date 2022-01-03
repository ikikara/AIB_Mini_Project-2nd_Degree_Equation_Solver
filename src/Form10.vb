Public Class Form10
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = Math.Round(Math.Log(TextBox1.Text), 2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = Math.Round(Math.Log10(TextBox1.Text), 2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = Math.Round(Math.E, 2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = Math.Round(Math.PI, 2)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox2.Text = 2 Then

            Label2.Text = TextBox1.Text

            Label2.Show()
            Label3.Hide()
            Label4.Hide()
            Label5.Hide()
        ElseIf TextBox2.Text = 1 Then

            Label3.Text = TextBox1.Text

            Label2.Hide()
            Label3.Show()
            Label4.Hide()
            Label5.Hide()
        ElseIf TextBox2.Text = 0 Then

            Label4.Text = TextBox1.Text

            Label2.Hide()
            Label3.Hide()
            Label4.Show()
            Label5.Hide()
        Else
            Label5.Text = "Erro"

            Label2.Hide()
            Label3.Hide()
            Label4.Hide()
            Label5.Show()
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Button7.Text = "Continuar para o 1ºtermo" Then
            Form3.Show()
            Me.Hide()
            Form3.Label1.Text = "Introduza o 1ºtermo"
            TextBox1.Text = ""
            Button6.Text = "Apresentar o 1ºtermo"
            Button7.Text = "Continuar para o termo independente"
            Label1.Text = "O 1ºtermo é"
            Form6.Button2.Text = "Apresenta o 1ºtermo"
            Form6.Button1.Text = "Continuar para o termo independente"
            Form6.Label2.Text = "O 1ºtermo é"
            Form8.Button6.Text = "Apresenta o 1ºtermo"
            Form8.Button7.Text = "Continuar para o termo independente"
            Form8.Label1.Text = "O 1ºtermo é"
            Form9.Button6.Text = "Apresenta o 1ºtermo"
            Form9.Button7.Text = "Continuar para o termo independente"
            Form9.Label1.Text = "O 1ºtermo é"
            Form7.Button6.Text = "Apresenta o 1ºtermo"
            Form7.Button7.Text = "Continuar para o termo independente"
            Form7.Label1.Text = "O 1ºtermo é"
            Form11.Button6.Text = "Apresenta o 1ºtermo"
            Form11.Button7.Text = "Continuar para o termo independente"
            Form11.Label1.Text = "O 1ºtermo é"

            Label2.Hide()
            Label3.Hide()
            Label4.Hide()
            Label5.Hide()
            TextBox1.Text = ""
            TextBox2.Text = ""

        ElseIf Button7.Text = "Continuar para o termo independente" Then
            Form3.Show()
            Me.Hide()
            Form3.Label1.Text = "Introduza o termo independente"

            Button6.Text = "Apresentar o termo independente"
            Button7.Text = "Continuar para a resoluçao da equação"
            Label1.Text = "O termo independente é"
            Form6.Button2.Text = "Apresenta o termo independente"
            Form6.Button1.Text = "Continuar para a resoluçao da equação"
            Form6.Label2.Text = "O termo independente é"
            Form8.Button6.Text = "Apresenta o termo independente"
            Form8.Button7.Text = "Continuar para a resoluçao da equação"
            Form8.Label1.Text = "O termo independente é"
            Form9.Button6.Text = "Apresenta o termo independente"
            Form9.Button7.Text = "Continuar para a resoluçao da equação"
            Form9.Label1.Text = "O termo independente é"
            Form7.Button6.Text = "Apresenta o termo independente"
            Form7.Button7.Text = "Continuar para a resoluçao da equação"
            Form7.Label1.Text = "O termo independente é"
            Form11.Button6.Text = "Apresenta o termo independente"
            Form11.Button7.Text = "Continuar para a resoluçao da equação"
            Form11.Label1.Text = "O termo independente é"

            Label2.Hide()
            Label3.Hide()
            Label4.Hide()
            Label5.Hide()
            TextBox1.Text = ""
            TextBox2.Text = ""

        ElseIf Button7.Text = "Continuar para a resoluçao da equação" Then
            Form2.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
    End Sub



End Class