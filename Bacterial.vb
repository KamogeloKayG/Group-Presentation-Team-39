Option Strict On
Option Explicit On
Option Infer Off

Public Class Bacterial

    Private _report As report
    Private _unprotectedsex As Boolean
    Private _hivpositive As Boolean
    Private _obese As Boolean
    Private _contactwithaninfectedperson As Boolean
    Private _smoking As Boolean
    Private _regularphysicalactivity As Boolean

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
            Return _regularphysicalactivity
        End Get
        Set(value As Boolean)
            _regularphysicalactivity = value
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

    Public Property report As report
        Get
            Return _report
        End Get
        Set(value As report)
            _report = value
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

    Public Function medicament(x As Integer) As String
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
