'*******************************************************************************
'Team Number: 39
'Team Member Details:
'Team Member Details: Mogoane, M (222002111)
'Team Member Details:
'Team Member Details:
'Practical: Team Project
'Class Name: DiseaseCategory
'*******************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Imports System.IO

Public MustInherit Class Diseasecategory
    Inherits report

    Private viral As Viral
    Private AI As Autoimmune
    Private bacterial As Bacterial
    Private likelihood As String

    Public Sub New()

    End Sub

    Private Function likely() As String
        If (viral.vPerc > bacterial.bPerc) And (viral.vPerc > AI.aPerc) Then
            likelihood = "Viral"
        End If

        If (bacterial.bPerc > viral.vPerc) And (bacterial.bPerc > AI.aPerc) Then
            likelihood = "Bacterial"
        End If

        If (AI.aPerc > bacterial.bPerc) And (AI.aPerc > viral.vPerc) Then
            likelihood = "Auto-Immune"
        End If

        Return likelihood
    End Function

    Public Overrides Function Disease() As String
        Dim sick As String

        sick = "Visit a Doctor"

        Select Case likelihood
            Case "Viral"
                sick = "Cold, Flu, AIDS, Stomach Flu, Hepatitis"
            Case "Bacterial"
                sick = "Strep Throat, Salmonella, Tuberculosis, STDs"
            Case "Auto-Immune"
                sick = "Arthritis, Multiple Sclerosis, Type 1 Diabetes, Lupus, Crohn's Disease"
        End Select

        Return MyBase.Disease + sick
    End Function
    Public Overrides Function Prevent() As String
        Dim prevents As String

        Select Case likelihood
            Case "Viral"
                prevents = "Eat healthily. Take your vitamins. Wash/ Sanitize your hands often. Get enough sleep"
            Case "Bacterial"
                prevents = "Strep Throat, Salmonella, Tuberculosis, STDs"
            Case "Auto-Immune"
                prevents = "Arthritis, Multiple Sclerosis, Type 1 Diabetes, Lupus, Crohn's Disease"
        End Select

        Return MyBase.prevention + prevents

    End Function

End Class
