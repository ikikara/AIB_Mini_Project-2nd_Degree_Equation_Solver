Public Class Form3

    Private Sub Fração_Click(sender As Object, e As EventArgs) Handles Fração.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form10.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form11.Show()
        Me.Hide()
    End Sub

 
    Private Sub f_MouseEnter(sender As Object, e As EventArgs) Handles Fração.MouseEnter
        Fração.Image = My.Resources.button3
    End Sub

    Private Sub f_MouseLeave(sender As Object, e As EventArgs) Handles Fração.MouseLeave
        Fração.Image = My.Resources.Screenshot_75
    End Sub

    Private Sub Raiz_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.Image = My.Resources.button4
    End Sub

    Private Sub Raiz_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.Image = My.Resources.Screenshot_1
    End Sub

    Private Sub Expoente_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Button4.Image = My.Resources.button5
    End Sub

    Private Sub Expoente_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.Image = My.Resources.Screenshot_2
    End Sub
  
    Private Sub Trignometria_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.Image = My.Resources.button6
    End Sub

    Private Sub Trignometria_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.Image = My.Resources.Screenshot_3
    End Sub

    Private Sub Logaritmo_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.Image = My.Resources.button7
    End Sub

    Private Sub Logaritmo_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.Image = My.Resources.Screenshot_4
    End Sub

    Private Sub Numero_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        Button5.Image = My.Resources.button8
    End Sub

    Private Sub Numero_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.Image = My.Resources.Screenshot_5
    End Sub


End Class