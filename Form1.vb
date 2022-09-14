Option Strict On
Option Explicit On
Option Infer Off


Public Class Form1
    Private counterviral, counteraimmune, counterbacterial As Integer
    Private diseasecategory() As Diseasecategory



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ReDim diseasecategory(3)
        Dim bac As Bacterial
        bac = New Bacterial

        Dim aimmune As Autoimmune
        aimmune = New Autoimmune

        Dim viral As Viral
        viral = New Viral
        If Checkboxsmoke.Checked Then
            counterbacterial += 1
            counteraimmune += 1
            bac.smoking = True
        End If

        If checkboxAnxmeds.Checked Then
            counteraimmune += 1
            aimmune.anxietymeds = True
        End If

        If CheckBoxUnprotectedsex.Checked Then
            counterbacterial += 1
            bac.unprotectedsex = True
        End If

        If CheckBoxcontact.Checked Then
            counterbacterial += 1
            bac.contactwithaninfectedperson = True
        End If

        If CheckBoxhivpositive.Checked Then
            counterbacterial += 1
            bac.hivpositive = True

        End If

        If CheckBoxregularPactivity.Checked Then
            counterbacterial += 1
        End If

        If CheckBoxObese.Checked Then
            counterbacterial += 1
            counteraimmune += 1
            bac.obese = True
            aimmune.obese = True
        End If

        If CheckBoxcholesterolmeds.Checked Then
            counteraimmune += 1
            aimmune.Cholesterol = True

        End If

        If CheckBoxhighbloodmeds.Checked Then
            counteraimmune += 1
            aimmune.highbloodmeds = True
        End If
        If CheckBoxexebvirus.Checked Then
            counteraimmune += 1
            aimmune.exebvirus = True
        End If

        viral.age = CInt(txtage.Text)
        If viral.age >= 18 And viral.age <= 35 Then

            counterviral += 1
        End If
        If txtgender.Text = "2" Then
            viral.female = True
            aimmune.Female = True
            counterviral += 1
            counteraimmune += 1

        End If


        viral.Drugs = CInt(txtdrugintake.Text)
        If viral.Drugs >= 10 Then
            counterviral += 1
        End If

        'upcasting
        diseasecategory(1) = viral
        diseasecategory(2) = aimmune
        diseasecategory(3) = bac

        Dim bacperc, aimmuneperc, viralperc As Double
        bacperc = counterbacterial / 6 * 100
        aimmuneperc = counteraimmune / 7 * 100
        viralperc = counterviral / 4 * 100

        Dim highest As String
        highest = bac.likely(viralperc, aimmuneperc, bacperc)

        Select Case highest
            Case "Viral"

            Case "Bacterial"

            Case "Auto-Immune"
        End Select
    End Sub
End Class
