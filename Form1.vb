Option Strict On
Option Explicit On
Option Infer Off
Imports System.IO

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
        'file
        Dim write As StreamWriter
        write = File.AppendText("Viral.txt")
        write.WriteLine("Amount of drugs taken " & CStr(viral.Drugs))
        write.WriteLine("Age of user " & CStr(viral.age))
        write.WriteLine()

        write.Close()
        highest = bac.likely(viralperc, aimmuneperc, bacperc)
        ' MsgBox(highest)
        Select Case highest
            Case "Viral"

                sort = CInt(InputBox("WHAT sort of the following apply to you
1-Sexual organs feeling unease and un explained wounds after sexual activity
2-Sneezing and nose blockages /coughning
3-Unusual symptoms"))

                viral.Aspect(sort)
                MsgBox("The treatmeant you will need is: " & viral.medicament(sort))


            Case "Bacterial"
                Dim prevention As String
                Dim med As String
                Dim condition As Integer
                Dim whichtest As String
                condition = CInt(InputBox("Which of the following have you experienced lately?" & vbNewLine & "1: Pain in spinal cord (back pain)" & vbNewLine & "2: Stomach Pain" & vbNewLine & "3: Pain in throat" & vbNewLine & "4: Difficulty in breathing" & vbNewLine & "5: Bloody urine or pain after urinating" & vbNewLine & "6: An Open Wound "))
                whichtest = "Go to a doctor and ask for a " & bac.culturetest(condition) & " to confirm if you have a bacterial infection."
                med = "Medicine that is commonly associated with " & bac.culturetest(condition) & " is " & bac.medicament(condition) & "."



                bac.prevention = "To prevent getting a bacterial disease you must do the following: " & vbNewLine & bac.Prevent("Bacterial")

                Rtxtdisplay.Text = "You are more likely to have a Bacterial Disease" & vbNewLine & vbNewLine & "A culture test can help find harmful bacteria in or on your body that is making you sick." & vbNewLine & whichtest & vbNewLine & vbNewLine & "Medication" & vbNewLine & med & vbNewLine & vbNewLine & "Prevention" & vbNewLine & bac.prevention
                diseasecategory(3) = bac
            Case "Auto-Immune"
 Dim write As StreamWriter
        write = File.AppendText("Viral.txt")
        write.WriteLine("Amount of drugs taken " & CStr(viral.Drugs))
        write.WriteLine("Age of user " & CStr(viral.age))
        write.WriteLine(viralperc)
        write.WriteLine(viral.Aspect(sort))
        write.WriteLine(viral.medicament(sort))
        write.Close()

        End Select
    End Sub

End Class
