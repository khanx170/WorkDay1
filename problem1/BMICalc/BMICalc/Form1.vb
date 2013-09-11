Option Strict On

Public Class Form1

    Private Sub btnCalcBMI_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcBMI.Click


        Dim hST As String
        Dim wSt As String

        hST = txtHeight.Text
        wSt = txtWeight.Text


        Dim h As Double
        Dim w As Double

        h = CDbl(hST)
        w = CDbl(wSt)

        Dim bmi As Double
        bmi = (w * 703) / (h ^ 2)

        TextBox1.Text = CStr(bmi)



    End Sub
End Class
