Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, delta, x, y As Double

        a = Label2.Text
        b = Label3.Text
        c = Label4.Text

        delta = b ^ 2 - 4 * a * c

        If a = 0 Then
            Label1.Text = "A solução desta equação é " + Math.Round((-c) / b).ToString
        ElseIf a <> 0 Then
            If delta > 0 Then
                x = (-b + Math.Sqrt(delta)) / (2 * a)
                y = (-b - Math.Sqrt(delta)) / (2 * a)
                Label1.Text = "Esta equação tem 2 soluções que são " + Math.Round((x), 2).ToString + " e " + Math.Round((y), 2).ToString
            ElseIf delta = 0 Then
                x = -b / (2 * a)
                Label1.Text = "Esta equação tem 1 soluçao que é " + Math.Round((x), 2).ToString
            ElseIf delta < 0 Then
                Label1.Text = "Esta equação é impossivel"
            End If
        End If

    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form7.Label2.Text = "" And Form8.Label2.Text = "" And Form9.Label2.Text = "" And Form10.Label2.Text = "" And Form11.Label2.Text = "" Then
            Label2.Text = Form6.Label4.Text
        ElseIf Not Form7.Label2.Text = "" Then
            Label2.Text = Form7.Label2.Text
        ElseIf Not Form8.Label2.Text = "" Then
            Label2.Text = Form8.Label2.Text
        ElseIf Not Form9.Label2.Text = "" Then
            Label2.Text = Form9.Label2.Text
        ElseIf Not Form10.Label2.Text = "" Then
            Label2.Text = Form10.Label2.Text
        ElseIf Not Form11.Label2.Text = ""
            Label2.Text = Form11.Label2.Text
        End If

        If Form7.Label3.Text = "" And Form8.Label3.Text = "" And Form9.Label3.Text = "" And Form10.Label3.Text = "" And Form11.Label3.Text = "" Then
            Label3.Text = Form6.Label7.Text
        ElseIf Form6.Label7.Text = "" And Form8.Label3.Text = "" And Form9.Label3.Text = "" And Form10.Label3.Text = "" And Form11.Label3.Text = "" Then
            Label3.Text = Form7.Label3.Text
        ElseIf Form6.Label7.Text = "" And Form7.Label3.Text = "" And Form9.Label3.Text = "" And Form10.Label3.Text = "" And Form11.Label3.Text = "" Then
            Label3.Text = Form8.Label3.Text
        ElseIf Form6.Label7.Text = "" And Form7.Label3.Text = "" And Form8.Label3.Text = "" And Form10.Label3.Text = "" And Form11.Label3.Text = "" Then
            Label3.Text = Form9.Label3.Text
        ElseIf Form6.Label7.Text = "" And Form7.Label3.Text = "" And Form8.Label3.Text = "" And Form9.Label3.Text = "" And Form11.Label3.Text = "" Then
            Label3.Text = Form10.Label3.Text
        ElseIf Form6.Label7.Text = "" And Form7.Label3.Text = "" And Form8.Label3.Text = "" And Form9.Label3.Text = "" And Form10.Label3.Text = "" Then
            Label3.Text = Form11.Label3.Text
        End If

        If Label3.Text < 0 Then
            Label8.Show()
            Label10.Show()
        Else
            Label8.Hide()
            Label10.Hide()
        End If

        If Form7.Label4.Text = "" And Form8.Label4.Text = "" And Form9.Label4.Text = "" And Form10.Label4.Text = "" And Form11.Label4.Text = "" Then
            Label4.Text = Form6.Label8.Text
        ElseIf Form6.Label8.Text = "" And Form8.Label4.Text = "" And Form9.Label4.Text = "" And Form10.Label4.Text = "" And Form11.Label4.Text = "" Then
            Label4.Text = Form7.Label4.Text
        ElseIf Form6.Label8.Text = "" And Form7.Label4.Text = "" And Form9.Label4.Text = "" And Form10.Label4.Text = "" And Form11.Label4.Text = "" Then
            Label4.Text = Form8.Label4.Text
        ElseIf Form6.Label8.Text = "" And Form8.Label4.Text = "" And Form7.Label4.Text = "" And Form10.Label4.Text = "" And Form11.Label4.Text = "" Then
            Label4.Text = Form9.Label4.Text
        ElseIf Form6.Label8.Text = "" And Form8.Label4.Text = "" And Form9.Label4.Text = "" And Form7.Label4.Text = "" And Form11.Label4.Text = "" Then
            Label4.Text = Form10.Label4.Text
        ElseIf Form6.Label8.Text = "" And Form8.Label4.Text = "" And Form9.Label4.Text = "" And Form10.Label4.Text = "" And Form7.Label4.Text = "" Then
            Label4.Text = Form11.Label4.Text
        End If

        If Label4.Text < 0 Then
            Label9.Show()
            Label11.Show()
        Else
            Label9.Hide()
            Label11.Hide()
        End If



    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Close()
        Form3.Close()
        Form7.Close()
        Form8.Close()
        Form9.Close()
        Form10.Close()
        Form11.Close()
    End Sub
End Class