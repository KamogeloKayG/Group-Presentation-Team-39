﻿'*******************************************************************************
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


    Private likelihood As String
    Private report As report
    Public Sub New()
        report = New report
    End Sub

    Public Function likely(viralperc As Double, autoimmuneperc As Double, bacperc As Double) As String
        If (viralperc > bacperc) And (viralperc > autoimmuneperc) Then
            likelihood = "Viral"
        End If

        If (bacperc > viralperc) And (bacperc > autoimmuneperc) Then
            likelihood = "Bacterial"
        End If

        If (autoimmuneperc > bacperc) And (autoimmuneperc > viralperc) Then
            likelihood = "Auto-Immune"
        End If

        Return likelihood
    End Function



    Public MustOverride Function medicament(x As Integer) As String


    Public Function Prevent() As String
        Dim prevents As String
        prevents = ""
        Select Case likelihood
            Case "Viral"
                prevents = "Eat healthily. Take your vitamins. Wash/ Sanitize your hands often. Get enough sleep"
            Case "Bacterial"
                prevents = "Avoid clse contact with sick people. Cover coughs and sneezes. Avoid touching your face. Stay home if you are sick. Clean and disinfect surfaces that are touched often. Avoid contaminated food and water"
            Case "Auto-Immune"
                prevents = "Exercise consistently. Stay away from cigarettes. Avoid toxins. Maintain a healthy diet. Limit processed foods from your diet"
        End Select

        Return prevents

    End Function

End Class
