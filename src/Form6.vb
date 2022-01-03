Public Class Form6

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Continuar para o 1ºtermo" Then

            Form3.Show()
            Me.Hide()
            Form3.Label1.Text = "Introduza o 1ºtermo"
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox2.Hide()
            TextBox3.Hide()
            TextBox4.Hide()
            Label5.Hide()
            Label6.Hide()
            PictureBox1.Hide()
            Label1.Show()
            Label2.Show()
            TextBox1.Show()

            Button3.Show()
            Button4.Show()
            Button6.Show()
            Button8.Show()
            Label4.Hide()
            Label7.Hide()
            Label8.Hide()
            TextBox5.Text = ""

            Button2.Text = "Apresentar o 1ºtermo"
            Button1.Text = "Continuar para o termo independente"
            Label3.Text = "O 1ºtermo é"
            Form7.Button6.Text = "Apresenta o 1ºtermo"
            Form7.Button7.Text = "Continuar para o termo independente"
            Form7.Label1.Text = "O 1ºtermo é"
            Form8.Button6.Text = "Apresenta o 1ºtermo"
            Form8.Button7.Text = "Continuar para o termo independente"
            Form8.Label1.Text = "O 1ºtermo é"
            Form9.Button6.Text = "Apresenta o 1ºtermo"
            Form9.Button7.Text = "Continuar para o termo independente"
            Form9.Label1.Text = "O 1ºtermo é"
            Form10.Button6.Text = "Apresenta o 1ºtermo"
            Form10.Button7.Text = "Continuar para o termo independente"
            Form10.Label1.Text = "O 1ºtermo é"
            Form11.Button6.Text = "Apresenta o 1ºtermo"
            Form11.Button7.Text = "Continuar para o termo independente"
            Form11.Label1.Text = "O 1ºtermo é"

        ElseIf Button1.Text = "Continuar para o termo independente" Then
            Form3.Show()
            Me.Hide()
            Form3.Label1.Text = "Introduza o termo independente"
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox2.Hide()
            TextBox3.Hide()
            TextBox4.Hide()
            Label5.Hide()
            Label6.Hide()
            PictureBox1.Hide()
            Label1.Show()
            Label2.Show()
            TextBox1.Show()

            Button3.Show()
            Button4.Show()
            Button6.Show()
            Button8.Show()
            Label4.Hide()
            Label7.Hide()
            Label8.Hide()
            TextBox5.Text = ""

            Button2.Text = "Apresentar o termo independente"
            Button1.Text = "Continuar para a resoluçao da equação"
            Label3.Text = "O termo independente é"
            Form7.Button6.Text = "Apresenta o termo independente"
            Form7.Button7.Text = "Continuar para a resoluçao da equação"
            Form7.Label1.Text = "O termo independente é"
            Form8.Button6.Text = "Apresenta o termo independente"
            Form8.Button7.Text = "Continuar para a resoluçao da equação"
            Form8.Label1.Text = "O termo independente é"
            Form9.Button6.Text = "Apresenta o termo independente"
            Form9.Button7.Text = "Continuar para a resoluçao da equação"
            Form9.Label1.Text = "O termo independente é"
            Form10.Button6.Text = "Apresenta o termo independente"
            Form10.Button7.Text = "Continuar para a resoluçao da equação"
            Form10.Label1.Text = "O termo independente é"
            Form11.Button6.Text = "Apresenta o termo independente"
            Form11.Button7.Text = "Continuar para a resoluçao da equação"
            Form11.Label1.Text = "O termo independente é"

        ElseIf Button1.Text = "Continuar para a resoluçao da equação" Then
            Form2.Show()
            Me.Hide()

            
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Not TextBox1.Text = "" And TextBox2.Text = "" Then
            TextBox1.Text = Math.Round(Math.Sin(System.Math.PI * TextBox1.Text / 180), 2)
            TextBox1.Hide()
            TextBox2.Text = ""
            TextBox2.Show()
            Button3.Hide()
            Button8.Hide()
        ElseIf Not TextBox2.Text = "" Then
            TextBox2.Text = Math.Round(Math.Sin(System.Math.PI * TextBox2.Text / 180), 2)
            TextBox1.Text = TextBox1.Text
            TextBox1.Hide()
            TextBox2.Hide()
            Button4.Hide()
            Button6.Hide()

        End If

    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Not TextBox1.Text = "" And TextBox2.Text = "" Then
            TextBox1.Text = Math.Round(Math.Cos(System.Math.PI * TextBox1.Text / 180), 2)
            TextBox1.Hide()
            TextBox2.Text = ""
            TextBox2.Show()
            Button3.Hide()
            Button8.Hide()
        ElseIf Not TextBox2.Text = "" Then
            TextBox2.Text = Math.Round(Math.Cos(System.Math.PI * TextBox2.Text / 180), 2)
            TextBox1.Text = TextBox1.Text
            TextBox1.Hide()
            TextBox2.Hide()
            Button4.Hide()
            Button6.Hide()
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If Not TextBox1.Text = "" And TextBox2.Text = "" Then
            If TextBox1.Text Mod 180 = 0 Then
                TextBox1.Text = "0"
            ElseIf TextBox1.Text Mod 90 = 0 Then
                TextBox1.Text = "Impossivel"
            Else
                TextBox1.Text = Math.Round(Math.Tan(System.Math.PI * TextBox1.Text / 180), 2)
            End If
            TextBox1.Hide()
            TextBox2.Text = ""
            TextBox2.Show()
            Button3.Hide()
            Button8.Hide()
        ElseIf Not TextBox2.Text = "" Then
            If TextBox2.Text Mod 180 = 0 Then
                TextBox2.Text = "0"
            ElseIf TextBox2.Text Mod 90 = 0 Then
                TextBox2.Text = "Impossivel"
            Else
                TextBox2.Text = Math.Round(Math.Tan(System.Math.PI * TextBox2.Text / 180), 2)
            End If
            TextBox1.Text = TextBox1.Text
            TextBox1.Hide()
            TextBox2.Hide()
            Button4.Hide()
            Button6.Hide()

        End If
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        If Not TextBox1.Text = "" And TextBox2.Text = "" Then
            TextBox1.Text = Math.Round((Math.Asin(TextBox1.Text) * 180 / Math.PI), 2)
            TextBox1.Hide()
            TextBox2.Text = ""
            TextBox2.Show()
            Button3.Hide()
            Button8.Hide()
        ElseIf Not TextBox2.Text = "" Then
            TextBox2.Text = Math.Round((Math.Asin(TextBox2.Text) * 180 / Math.PI), 2)
            TextBox1.Text = TextBox1.Text
            TextBox1.Hide()
            TextBox2.Hide()
            Button4.Hide()
            Button6.Hide()
        End If
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        If Not TextBox1.Text = "" And TextBox2.Text = "" Then
            TextBox1.Text = Math.Round((Math.Acos(TextBox1.Text) * 180 / Math.PI), 2)
            TextBox1.Hide()
            TextBox2.Text = ""
            TextBox2.Show()
            Button3.Hide()
            Button8.Hide()
        ElseIf Not TextBox2.Text = "" Then
            TextBox2.Text = Math.Round((Math.Acos(TextBox2.Text) * 180 / Math.PI), 2)
            TextBox1.Text = TextBox1.Text
            TextBox1.Hide()
            TextBox2.Hide()
            Button4.Hide()
            Button6.Hide()
        End If
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        If Not TextBox1.Text = "" And TextBox2.Text = "" Then
            TextBox1.Text = Math.Round((Math.Atan(TextBox1.Text) * 180 / Math.PI), 2)
            TextBox1.Hide()
            TextBox2.Text = ""
            TextBox2.Show()
            Button3.Hide()
            Button8.Hide()
        ElseIf Not TextBox2.Text = "" Then
            TextBox2.Text = Math.Round((Math.Atan(TextBox2.Text) * 180 / Math.PI), 2)
            TextBox1.Text = TextBox1.Text
            TextBox1.Hide()
            TextBox2.Hide()
            Button4.Hide()
            Button6.Hide()
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If Not TextBox1.Text = "" And TextBox2.Text = "" Then
            TextBox1.Text = Math.Round(Math.Log(TextBox1.Text), 2)
            TextBox1.Hide()
            TextBox2.Text = ""
            TextBox2.Show()
            Button3.Hide()
            Button8.Hide()
        ElseIf Not TextBox2.Text = "" Then
            TextBox2.Text = Math.Round(Math.Log(TextBox2.Text), 2)
            TextBox1.Text = TextBox1.Text
            TextBox1.Hide()
            TextBox2.Hide()
            Button4.Hide()
            Button6.Hide()
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If Not TextBox1.Text = "" And TextBox2.Text = "" Then
            TextBox1.Text = Math.Round(Math.E ^ (TextBox1.Text), 2)
            TextBox1.Hide()
            TextBox2.Text = ""
            TextBox2.Show()
            Button3.Hide()
            Button8.Hide()
        ElseIf Not TextBox2.Text = "" Then
            TextBox2.Text = Math.Round(Math.E ^ (TextBox2.Text), 2)
            TextBox1.Text = TextBox1.Text
            TextBox1.Hide()
            TextBox2.Hide()
            Button4.Hide()
            Button6.Hide()
        End If
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        If Not TextBox1.Text = "" And TextBox2.Text = "" Then
            Dim num As Double = TextBox1.Text
            Dim fatorial As Integer = 1

            For i = num To 1 Step -1
                fatorial *= i

            Next
            TextBox1.Text = Math.Round(fatorial, 2)
            TextBox1.Hide()
            TextBox2.Text = ""
            TextBox2.Show()
            Button3.Hide()
            Button8.Hide()
        ElseIf Not TextBox2.Text = "" Then
            Dim num2 As Double = TextBox2.Text
            Dim fatorial2 As Integer = 1
            For i = num2 To 1 Step -1
                fatorial2 *= i

            Next
            TextBox2.Text = Math.Round(fatorial2, 2)
            TextBox1.Text = TextBox1.Text
            TextBox1.Hide()
            TextBox2.Hide()
            Button4.Hide()
            Button6.Hide()
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        If Not TextBox1.Text = "" And TextBox2.Text = "" Then
            TextBox1.Text = Math.Round(Math.Log10(TextBox1.Text), 2)
            TextBox1.Hide()
            TextBox2.Text = ""
            TextBox2.Show()
            Button3.Hide()
            Button8.Hide()
        ElseIf Not TextBox2.Text = "" Then
            TextBox2.Text = Math.Round(Math.Log10(TextBox2.Text), 2)
            TextBox1.Text = TextBox1.Text
            TextBox1.Hide()
            TextBox2.Hide()
            Button4.Hide()
            Button6.Hide()
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()
        Label5.Hide()
        Label6.Hide()
        PictureBox1.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim d, n As Double

        n = TextBox1.Text
        d = TextBox2.Text

        If TextBox5.Text = 2 Then
            If d > 0 Or d < 0 Then
                Label4.Text = Math.Round((n / d), 2)
            ElseIf d = 0 Then
                Label4.Text = "Impossivel de determinar"
            End If
            Label4.Show()
            Label7.Hide()
            Label8.Hide()
            Label9.Hide()

            Label1.Hide()
            Label2.Hide()
            Label5.Text = TextBox1.Text
            Label6.Text = TextBox2.Text
            Label5.Show()
            Label6.Show()
            PictureBox1.Show()
            TextBox1.Hide()
            TextBox2.Hide()
            Button4.Hide()
            Button6.Hide()
        ElseIf TextBox5.Text = 1 Then
            If d > 0 Or d < 0 Then
                Label7.Text = n / d
            ElseIf d = 0 Then
                Label7.Text = "Impossivel de determinar"
            End If
            Label7.Show()
            Label1.Hide()
            Label8.Hide()
            Label9.Hide()

            Label1.Hide()
            Label2.Hide()
            Label5.Text = TextBox1.Text
            Label6.Text = TextBox2.Text
            Label5.Show()
            Label6.Show()
            PictureBox1.Show()
            TextBox1.Hide()
            TextBox2.Hide()
            Button4.Hide()
            Button6.Hide()
        ElseIf TextBox5.Text = 0 Then
            If d > 0 Or d < 0 Then
                Label8.Text = n / d
            ElseIf d = 0 Then
                Label7.Text = "Impossivel de determinar"
            End If

            Label1.Hide()
            Label7.Hide()
            Label8.Show()
            Label9.Hide()


            Label1.Hide()
            Label2.Hide()
            Label5.Text = TextBox1.Text
            Label6.Text = TextBox2.Text
            Label5.Show()
            Label6.Show()
            PictureBox1.Show()
            TextBox1.Hide()
            TextBox2.Hide()
            Button4.Hide()
            Button6.Hide()
        Else
            Label9.Text = "Erro"
            Label9.Show()
            Label8.Hide()
            Label1.Hide()
            Label7.Hide()

            Label1.Hide()
            Label2.Hide()
            Label5.Show()
            Label6.Show()
            PictureBox1.Show()
            TextBox1.Hide()
            TextBox2.Hide()
            Button4.Hide()
            Button6.Hide()
        End If


        Label1.Hide()
        Label2.Hide()
        Label5.Show()
        Label6.Show()
        PictureBox1.Show()
        TextBox1.Hide()
        TextBox2.Hide()
        Button4.Hide()
        Button6.Hide()

    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        If Not TextBox1.Text = "" And TextBox2.Text = "" Then
            TextBox1.Text = TextBox1.Text ^ -1
            TextBox1.Hide()
            TextBox2.Text = ""
            TextBox2.Show()
            Button3.Hide()
            Button8.Hide()
        ElseIf Not TextBox2.Text = "" Then
            TextBox2.Text = TextBox2.Text ^ -1
            TextBox1.Text = TextBox1.Text
            TextBox1.Hide()
            TextBox2.Hide()
            Button4.Hide()
            Button6.Hide()

        End If
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        If Not TextBox1.Text = "" And TextBox2.Text = "" Then
            TextBox1.Text = 10 ^ (TextBox1.Text)
            TextBox1.Hide()
            TextBox2.Text = ""
            TextBox2.Show()
            Button3.Hide()
            Button8.Hide()
        ElseIf Not TextBox2.Text = "" Then
            TextBox2.Text = 10 ^ (TextBox2.Text)
            TextBox1.Text = TextBox1.Text
            TextBox1.Hide()
            TextBox2.Hide()
            Button4.Hide()
            Button6.Hide()
        End If
    End Sub


    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        If Not TextBox1.Text = "" And TextBox2.Text = "" Then
            TextBox1.Text = TextBox1.Text ^ (1 / (TextBox3.Text))
            TextBox1.Hide()
            TextBox2.Text = ""
            TextBox2.Show()
            TextBox3.Hide()
            Button3.Hide()
            Button8.Hide()
        ElseIf Not TextBox2.Text = "" Then
            TextBox2.Text = TextBox2.Text ^ (1 / (TextBox4.Text))
            TextBox1.Text = TextBox1.Text
            TextBox1.Hide()
            TextBox2.Hide()
            TextBox4.Hide()
            Button4.Hide()
            Button6.Hide()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        
        TextBox3.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
     
        TextBox4.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Hide()
        TextBox2.Show()
        TextBox3.Hide()
        Button3.Hide()
        Button8.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Hide()
        TextBox2.Hide()
        TextBox4.Hide()
        Button4.Hide()
        Button6.Hide()


    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            TextBox1.Text = Math.Round(Math.PI, 2)
            TextBox1.Hide()
            TextBox2.Text = ""
            TextBox2.Show()
            Button3.Hide()
            Button8.Hide()
        ElseIf TextBox2.Text = "" Then
            TextBox2.Text = Math.Round(Math.PI, 2)
            TextBox1.Text = TextBox1.Text
            TextBox1.Hide()
            TextBox2.Hide()
            Button4.Hide()
            Button6.Hide()

        End If
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            TextBox1.Text = Math.Round(Math.E, 2)
            TextBox1.Hide()
            TextBox2.Text = ""
            TextBox2.Show()
            Button3.Hide()
            Button8.Hide()
        ElseIf TextBox2.Text = "" Then
            TextBox2.Text = Math.Round(Math.E, 2)
            TextBox1.Text = TextBox1.Text
            TextBox1.Hide()
            TextBox2.Hide()
            Button4.Hide()
            Button6.Hide()

        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Not TextBox1.Text = "" And TextBox2.Text = "" Then
            TextBox1.Text = TextBox1.Text ^ TextBox3.Text
            TextBox1.Hide()
            TextBox2.Text = ""
            TextBox2.Show()
            TextBox3.Hide()
            Button3.Hide()
            Button8.Hide()
        ElseIf Not TextBox2.Text = "" Then
            TextBox2.Text = TextBox2.Text ^ TextBox4.Text
            TextBox1.Text = TextBox1.Text
            TextBox1.Hide()
            TextBox2.Hide()
            TextBox4.Hide()
            Button4.Hide()
            Button6.Hide()
        End If
    End Sub

   
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.ResetText()
        TextBox1.Show()
        Button3.Show()
        Button8.Show()
        Label5.Hide()
        Label6.Hide()
        PictureBox1.Hide()
    End Sub


End Class