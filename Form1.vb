Public Class frmScreening
    Private user As user
    Private weight, height As Double

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        user.age = CInt(txtAge.Text)
        user.gender = cboGender.Text
        user.bmi = weight / height ^ 2
    End Sub
End Class
