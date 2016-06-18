Public Class Form1
    Dim calctype As String
    Dim firstInput As Double
    Dim secondInput As Double
    Dim answer As Double
    Dim thirdinput As Double

    Function screenInput(i As Double)
        TextBox1.AppendText(i)
    End Function

    Function Add()
        firstInput = CDbl(TextBox1.Text)
        calctype = "add"
        Clear()
        'Check()
    End Function

    Function Subtract()
        firstInput = Convert.ToDouble(TextBox1.Text)
        calctype = "subtract"
        Clear()
    End Function

    Function Multiply()
        firstInput = Convert.ToDouble(TextBox1.Text)
        calctype = "multiply"
        Clear()
    End Function

    Function Divide()
        firstInput = Convert.ToDouble(TextBox1.Text)
        calctype = "divide"
        Clear()
    End Function

    Function Clear()
        TextBox1.Text = ""
    End Function

    Function Equals()
        secondInput = Convert.ToDouble(TextBox1.Text)
        If calctype = "add" Then
            answer = firstInput + secondInput
        ElseIf calctype = "subtract" Then
            answer = firstInput - secondInput
        ElseIf calctype = "multiply" Then
            answer = firstInput * secondInput
        ElseIf calctype = "divide" Then
            answer = firstInput / secondInput
        End If
        TextBox1.Text = answer



    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.AppendText("1")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.AppendText("2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.AppendText("3")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.AppendText("4")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.AppendText("5")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.AppendText("6")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.AppendText("7")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.AppendText("9")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.AppendText("0")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.AppendText(".")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Clear()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Add()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Subtract()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Multiply()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Divide()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Equals()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.AppendText("8")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
