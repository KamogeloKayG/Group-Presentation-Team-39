'Team Number: 39
'Team Member Details: Mabatha, KA (221077585)
'Team Member Details:Maposa T 222078730
'Team Member Details: Mogoane, M (222002111)
'Team Member Details:PANANA R 218026867
'Practical: Team Project
'Class Name: 
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
        Dim sort As Integer
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
                viral.medicament(sort)
                viral.prevention = "To prevent getting a viral disease you must do the following: " & vbNewLine & viral.Prevent("V")
                Rtxtdisplay.Text = "You are more likely to have a viral Disease" & vbNewLine & vbNewLine & "Caused due to viral infection; may be transmitted through contaminated air, water, food or contact." & vbNewLine & "You may specifically have " & viral.Aspect(sort) & vbNewLine & vbNewLine & "The treatmeant you will need is: " & viral.medicament(sort) & vbNewLine & viral.prevention

                diseasecategory(1) = viral
            Case "Bacterial"

                Dim med As String
                Dim condition As Integer
                Dim whichtest As String
                condition = CInt(InputBox("Which of the following have you experienced lately?" & vbNewLine & "1: Pain in spinal cord (back pain)" & vbNewLine & "2: Stomach Pain" & vbNewLine & "3: Pain in throat" & vbNewLine & "4: Difficulty in breathing" & vbNewLine & "5: Bloody urine or pain after urinating" & vbNewLine & "6: An Open Wound " & vbNewLine))
                whichtest = "Go to a doctor and ask for a " & bac.culturetest(condition) & " to confirm if you have a bacterial infection."
                med = "Medicine that is commonly associated with " & bac.culturetest(condition) & " is " & bac.medicament(condition) & "."



                bac.prevention = "To prevent getting a bacterial disease you must do the following: " & vbNewLine & bac.Prevent("Bacterial")

                Rtxtdisplay.Text = "You are more likely to have a Bacterial Disease" & vbNewLine & vbNewLine & "A culture test can help find harmful bacteria in or on your body that is making you sick." & vbNewLine & whichtest & vbNewLine & vbNewLine & "Medication" & vbNewLine & med & vbNewLine & vbNewLine & "Prevention" & vbNewLine & bac.prevention
                diseasecategory(3) = bac
            Case "Auto-Immune"
                Dim temp As Integer
                Dim text As String = ""

                aimmune = TryCast(diseasecategory(2), Autoimmune)
                If Not (aimmune Is Nothing) Then
                    temp = CInt((InputBox("Enter organ that the pain is situated" & Environment.NewLine & "1.The beta cells of the endocrine pancreas" & Environment.NewLine & "2.Thyroid" & Environment.NewLine & "3.gastric parietal cells" & Environment.NewLine & "4.adrenal and ovary" & Environment.NewLine & "5.Skin")))
                    If temp = 1 Then
                        aimmune.report.bloodsugarlevel = CDbl(InputBox("Enter your blood sugar level"))
                        aimmune.Diabetic(aimmune.report.bloodsugarlevel)
                    End If
                    aimmune.autoimmumetype(temp)
                    aimmune.Medicament(temp)
                    aimmune.prevention = "To reduce the risk of having an autoimmune disease follow these preventitive measures:" & Environment.NewLine & aimmune.Prevent("Auto-Immune")
                    text &= "You are susceptible to having an autoimmune disease" & Environment.NewLine
                    text &= "The type of autoimmune disease that you are susceptile to is:" & Environment.NewLine & aimmune.autoimmumetype(temp) & Environment.NewLine
                    text &= "The treatment you should take is:" & Environment.NewLine & aimmune.Medicament(temp) & Environment.NewLine
                    text &= aimmune.prevention
                    Rtxtdisplay.Text = text
                    
                End If

                diseasecategory(2) = aimmune
        End Select
    End Sub

End Class
