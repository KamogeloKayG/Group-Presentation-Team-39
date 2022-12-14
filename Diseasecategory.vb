'*******************************************************************************
'Team Number: 39
'Team Member Details: Mabatha, KA (221077585)
'Team Member Details:Maposa T 222078730
'Team Member Details: Mogoane, M (222002111)
'Team Member Details:PANANA R 218026867
'Practical: Team Project
'Class Name: DiseaseCategory
'*******************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Imports System.IO

Public MustInherit Class Diseasecategory
    'logic
    Private _prevention As String
    Private likelihood As String
    Private _report As user_report
    'constructor
    Public Sub New()
        _report = New user_report
    End Sub
    'properties
    Public Property prevention As String
        Get
            Return _prevention
        End Get
        Set(value As String)
            _prevention = value
        End Set
    End Property
    Public Property report As user_report
        Get
            Return _report
        End Get
        Set(value As user_report)
            _report = value
        End Set
    End Property

    'methods(functions)
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


    Public Function Prevent(x As String) As String
        Dim prevents As String
        prevents = ""
        Select Case x
            Case "V"
                prevents = "1. Eat healthily." & vbNewLine & "2. Take your vitamins." & vbNewLine & "3. Wash/ Sanitize your hands often." & vbNewLine & "4. Get enough sleep" & vbNewLine & "5. Avoid having to many casual sexual partner " & vbNewLine & "6. Always use protection in your daily life such as condoms, masks and ect" & vbNewLine & " 7. Overall keep yourself safe all the time"
            Case "Bacterial"
                prevents = "1. Avoid clse contact with sick people. " & vbNewLine & "2. Cover coughs and sneezes. " & vbNewLine & "3. Avoid touching your face. " & vbNewLine & "4. Stay home if you are sick. " & vbNewLine & "5. Clean and disinfect surfaces that are touched often. " & vbNewLine & "6. Avoid contaminated food and water"
            Case "Auto-Immune"
                prevents = "1. Exercise consistently." & vbNewLine & "2. Stay away from cigarettes." & vbNewLine & "3. Avoid toxins." & vbNewLine & "4. Maintain a healthy diet." & vbNewLine & "5. Limit processed foods from your diet"
        End Select

        Return prevents

    End Function

End Class
