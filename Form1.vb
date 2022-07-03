Public Class frmBasicMath

    Dim intNum1 As Integer
    Dim intNum2 As Integer
    Dim stExit As String



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        stExit = MsgBox("Do you want to Exit?", vbYesNo)

        If stExit = vbYes Then
            Application.Exit()
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        intNum1 = txtFirstNumber.Text
        intNum2 = txtSecondNumber.Text

        txtAnswer.Text = intNum1 + intNum2

    End Sub

    Private Sub btnSubr_Click(sender As Object, e As EventArgs) Handles btnSubr.Click

        intNum1 = txtFirstNumber.Text
        intNum2 = txtSecondNumber.Text

        txtAnswer.Text = intNum1 - intNum2

    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click

        intNum1 = txtFirstNumber.Text
        intNum2 = txtSecondNumber.Text

        txtAnswer.Text = intNum1 * intNum2

    End Sub

    Private Sub btnDivi_Click(sender As Object, e As EventArgs) Handles btnDivi.Click

        intNum1 = txtFirstNumber.Text
        intNum2 = txtSecondNumber.Text

        txtAnswer.Text = intNum1 / intNum2

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        For Each Control As Control In Me.Controls

            If TypeOf Control Is TextBox Then

                Control.Text = String.Empty

            End If

        Next
    End Sub


End Class
