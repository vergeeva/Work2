Public Class Form1
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ValueA.KeyPress
        If Not (Char.IsControl(e.KeyChar)) And Not (Char.IsDigit(e.KeyChar)) And (e.KeyChar <> ".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ValueB.KeyPress
        If e.KeyChar = "0" And Symbols.Text = ":" Then
            MessageBox.Show("На ноль делить нельзя", "Китайское предупреждение")
            e.Handled = True
        End If
        If Not (Char.IsControl(e.KeyChar)) And Not (Char.IsDigit(e.KeyChar)) And (e.KeyChar <> ".") Then
            e.Handled = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Key As String
        Dim a As Double
        Dim b As Double
        If ValueA.Text <> "" And ValueB.Text <> "" Then
            a = Convert.ToDouble(ValueA.Text)
            b = Convert.ToDouble(ValueB.Text)
            Key = Symbols.Text
            Select Case Key
                Case = "+"
                    Result.Text = Convert.ToString(a + b)
                Case = "-"
                    Result.Text = Convert.ToString(a - b)
                Case = ":"
                    Result.Text = Convert.ToString(a / b)
                Case = "*"
                    Result.Text = Convert.ToString(a * b)
            End Select
        Else
            MessageBox.Show("Введите данные в окна!", "Китайское предупреждение")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Symbols.SelectedItem = "+"
    End Sub

    Private Sub Symbols_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Symbols.SelectedIndexChanged
        If Symbols.SelectedItem = ":" And ValueB.Text = "0" Then
            ValueB.Text = ""
        End If

    End Sub
End Class
