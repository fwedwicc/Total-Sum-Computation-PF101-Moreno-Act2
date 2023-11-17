Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btncomp.Click
        If IsNumeric(txtnum1.Text) And IsNumeric(txtnum2.Text) Then
            Dim num1 As Double = Convert.ToDouble(txtnum1.Text)
            Dim num2 As Double = Convert.ToDouble(txtnum2.Text)
            Dim sum As Double = num1 + num2
            Dim thirtyPercent As Double = 0.3 * sum

            lblsum.Text = "" & sum.ToString()
            lbltp.Text = "" & thirtyPercent.ToString()

        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtnum1.Clear()
        txtnum2.Clear()
        lblsum.Text = ""
        lbltp.Text = ""

    End Sub
End Class
