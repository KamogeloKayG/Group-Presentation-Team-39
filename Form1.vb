<<<<<<< HEAD
﻿Public Class frmScreening
    Private profile As user
    Private weight, height As Double

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'overall health
        profile.sick = radSick.Checked
        profile.meds = radMed.Checked
        profile.HIVPos = radHIV.Checked
        profile.sickFam = radRelatives.Checked
        'environment
        profile.waterQual = radWater.Checked
        profile.overcrowded = radOvercrowded.Checked
        profile.stress = radStress.Checked
        'social habits
        profile.smoker = radSmoker.Checked
        profile.alcoholic = radAlcohol.Checked
        profile.sAct = radSActive.Checked
        profile.drugs = radDrugs.Checked
    End Sub
=======
﻿Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1
>>>>>>> 17b94be3b5827feec808198643656002c93cb477

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        rtfReport.Text = "You're more likely to contract a <viral/bacterial/autoimmune> infection" + Environment.NewLine +
        "Diseases to look out for include, but are not limited to:" + Environment.NewLine +
        "Here are some steps to prevent it:"
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        weight = CDbl(txtWeight.Text)
        height = CDbl(txtHeight.Text)

        profile.age = CInt(txtAge.Text)
        profile.gender = cboGender.Text
        profile.bmi = profile.calcBMI(weight, height)
    End Sub
End Class
