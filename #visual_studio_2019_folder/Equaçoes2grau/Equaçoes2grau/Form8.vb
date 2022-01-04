Public Class Form8

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text ^ (TextBox2.Text)
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox2.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text ^ 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text ^ 3
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        TextBox1.Text = Math.Round((Math.PI), 2)
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        TextBox1.Text = Math.Round((Math.E), 2)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If TextBox3.Text = 2 Then

            Label2.Text = TextBox1.Text

            Label2.Show()
            Label3.Hide()
            Label4.Hide()
            Label5.Hide()
        ElseIf TextBox3.Text = 1 Then

            Label3.Text = TextBox1.Text

            Label2.Hide()
            Label3.Show()
            Label4.Hide()
            Label5.Hide()
        ElseIf TextBox3.Text = 0 Then

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
            TextBox2.Text = ""
            Button6.Text = "Apresentar o 1ºtermo"
            Button7.Text = "Continuar para o termo independente"
            Label1.Text = "O 1ºtermo é"
            Form6.Button2.Text = "Apresenta o 1ºtermo"
            Form6.Button1.Text = "Continuar para o termo independente"
            Form6.Label2.Text = "O 1ºtermo é"
            Form7.Button6.Text = "Apresenta o 1ºtermo"
            Form7.Button7.Text = "Continuar para o termo independente"
            Form7.Label1.Text = "O 1ºtermo é"
            Form9.Button6.Text = "Apresenta o 1ºtermo"
            Form9.Button7.Text = "Continuar para o termo independente"
            Form9.Label1.Text = "O 1ºtermo é"
            Form10.Button6.Text = "Apresenta o 1ºtermo"
            Form10.Button7.Text = "Continuar para o termo independente"
            Form10.Label1.Text = "O 1ºtermo é"
            Form11.Button6.Text = "Apresenta o 1ºtermo"
            Form11.Button7.Text = "Continuar para o termo independente"
            Form11.Label1.Text = "O 1ºtermo é"

            Label2.Hide()
            Label3.Hide()
            Label4.Hide()
            Label5.Hide()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
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
            Form7.Button6.Text = "Apresenta o termo independente"
            Form7.Button7.Text = "Continuar para a resoluçao da equação"
            Form7.Label1.Text = "O termo independente é"
            Form9.Button6.Text = "Apresenta o termo independente"
            Form9.Button7.Text = "Continuar para a resoluçao da equação"
            Form9.Label1.Text = "O termo independente é"
            Form10.Button6.Text = "Apresenta o termo independente"
            Form10.Button7.Text = "Continuar para a resoluçao da equação"
            Form10.Label1.Text = "O termo independente é"
            Form11.Button6.Text = "Apresenta o termo independente"
            Form11.Button7.Text = "Continuar para a resoluçao da equação"
            Form11.Label1.Text = "O termo independente é"

            Label2.Hide()
            Label3.Hide()
            Label4.Hide()
            Label5.Hide()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""

        ElseIf Button7.Text = "Continuar para a resoluçao da equação" Then
            Form2.Show()
            Me.Hide()

        End If
  

    End Sub


    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text = Math.Round((Math.Log(TextBox1.Text)), 2)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = Math.Round((Math.Log10(TextBox1.Text)), 2)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = Math.Round((Math.Acos(TextBox1.Text) * 180 / Math.PI), 2)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = Math.Round(Math.Sin(System.Math.PI * TextBox1.Text / 180), 2)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = Math.Round(Math.Cos(System.Math.PI * TextBox1.Text / 180), 2)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox1.Text Mod 180 = 0 Then
            TextBox1.Text = "0"
        ElseIf TextBox1.Text Mod 90 = 0 Then
            TextBox1.Text = "Impossivel"
        Else
            TextBox1.Text = Math.Round(Math.Tan(System.Math.PI * TextBox1.Text / 180), 2)
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = Math.Round((Math.Asin(TextBox1.Text) * 180 / Math.PI), 2)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = Math.Round((Math.Atan(TextBox1.Text) * 180 / Math.PI), 2)
    End Sub

    
End Class