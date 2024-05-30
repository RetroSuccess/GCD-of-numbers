Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim GCD As Double

        num1 = TextBox1.Text
        num2 = TextBox2.Text

        Do While (num1 <> 0)
            GCD = num1
            num1 = num2 Mod num1
            num2 = GCD
        Loop

        TextBox3.Text = num2

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
