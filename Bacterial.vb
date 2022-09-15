'Team Number: 39
'Team Member Details: Mabatha, KA (221077585)
'Team Member Details:Maposa T 222078730
'Team Member Details: Mogoane, M (222002111)
'Team Member Details:PANANA R 218026867
'Practical: Team Project
'Class Name: Bacterial
Option Strict On
Option Explicit On
Option Infer Off

Public Class Bacterial
    Inherits Diseasecategory
    Private _unprotectedsex As Boolean
    Private _hivpositive As Boolean
    Private _obese As Boolean
    Private _contactwithaninfectedperson As Boolean
    Private _smoking As Boolean
    Private _nophysicalactivity As Boolean

    Public Sub New()
        MyBase.New()
    End Sub

    Public Property unprotectedsex As Boolean
        Get
            Return _unprotectedsex
        End Get
        Set(value As Boolean)
            _unprotectedsex = value
        End Set
    End Property

    Public Property hivpositive As Boolean
        Get
            Return _hivpositive
        End Get
        Set(value As Boolean)
            _hivpositive = value
        End Set
    End Property
    Public Property exercise As Boolean
        Get
            Return _nophysicalactivity
        End Get
        Set(value As Boolean)
            _nophysicalactivity = value
        End Set
    End Property

    Public Property obese As Boolean
        Get
            Return _obese
        End Get
        Set(value As Boolean)
            _obese = value
        End Set
    End Property

    Public Property smoking As Boolean
        Get
            Return _smoking
        End Get
        Set(value As Boolean)
            _smoking = value
        End Set
    End Property

    Public Property contactwithaninfectedperson As Boolean
        Get
            Return _contactwithaninfectedperson
        End Get
        Set(value As Boolean)
            _contactwithaninfectedperson = value
        End Set
    End Property


    Public Function culturetest(x As Integer) As String
        Dim test As String
        test = ""
        Select Case x

            Case 1
                test = "Cerebrospinal (CSF) Fluid Culture"

            Case 2
                test = "Stool Culture"

            Case 3
                test = "Throat Culture"

            Case 4
                test = "Sputum Culture"

            Case 5
                test = "Urine Culture"

            Case 6
                test = "Wound Culture"

        End Select
        Return test

    End Function

    Public Overrides Function medicament(x As Integer) As String
        Dim treatment As String
        treatment = ""
        Select Case x
            Case 1
                treatment = "Ampicillin"


            Case 2
                treatment = "Amoxicillin or Ampicillin"

            Case 3

                treatment = "Penicillin or Amoxicillin"

            Case 4

                treatment = "Azithromycin or Erythromycin"

            Case 5

                treatment = "Trimethoprim"

            Case 6

                treatment = "Amoxicilin-Clavulanate"
        End Select
        Return treatment
    End Function
End Class
