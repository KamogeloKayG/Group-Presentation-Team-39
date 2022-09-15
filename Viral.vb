'Team Number: 39
'Team Member Details: Mabatha, KA (221077585)
'Team Member Details:Maposa T 222078730
'Team Member Details: Mogoane, M (222002111)
'Team Member Details:PANANA R 218026867
'Practical: Team Project
'Class Name: Viral
Option Strict On
Option Explicit On
Option Infer Off

Public Class Viral
    Inherits Diseasecategory
    Private _userreport As user_report


    Private _age As Integer
    Private _female As Boolean
    Private _sexualActivity As Integer
    Private _drugintake As Integer


    Public Sub New()

        MyBase.New()

    End Sub
    Public Property age As Integer
        Get
            Return _age
        End Get
        Set(value As Integer)
            _age = value
        End Set
    End Property
    Public Property female As Boolean
        Get
            Return _female

        End Get
        Set(value As Boolean)
            _female = value
        End Set
    End Property
    Public Property SexualActivity As Integer
        Get
            Return _sexualActivity
        End Get
        Set(value As Integer)
            _sexualActivity = value
        End Set
    End Property

    Public Property userreport As user_report
        Get
            Return _userreport
        End Get
        Set(value As user_report)
            _userreport = value
        End Set
    End Property


    Public Property Drugs As Integer
        Get
            Return _drugintake
        End Get
        Set(value As Integer)
            _drugintake = value
        End Set
    End Property
    Public Function Aspect(x As Integer) As String
        Dim test As String
        test = ""
        Select Case x

            Case 1
                test = "Sexual Tranmitted viral disease"

            Case 2
                test = "Influenza  or lung effecting viral disease "

            Case 3
                test = "You have a general viral disease"



        End Select
        Return test
    End Function
    Public Overrides Function medicament(x As Integer) As String
        Dim treatment As String
        treatment = ""
        Select Case x
            Case 1
                treatment = "ARVS"
            Case 2
                treatment = "ACETAMINOPHEN"
            Case 3
                treatment = "ACYCLOVIR"

        End Select

        Return treatment

    End Function
End Class
