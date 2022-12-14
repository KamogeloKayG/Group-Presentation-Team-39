
'Team Number: 39
'Team Member Details: Mabatha, KA (221077585)
'Team Member Details:Maposa T 222078730
'Team Member Details: Mogoane, M (222002111)
'Team Member Details:PANANA R 218026867
'Practical: Team Project
'Class Name: Autoimmune
'*******************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public Class Autoimmune
    Inherits Diseasecategory

    Implements Diabetes
    'attributes
    Private _userreport As user_report


    Private _type As String
    Private _treatment As String
    Private _Obese As Boolean
    Private _female As Boolean
    Private _highbloodmeds As Boolean
    Private _anxietymeds As Boolean
    Private _cholesterolmeds As Boolean
    Private _exebvirus As Boolean

    'constructor
    Public Sub New()
        MyBase.New()
    End Sub
    'property methods
    Public Property type() As String
        Get
            Return _type
        End Get
        Set(value As String)
            _type = value
        End Set
    End Property
    Public Property treatment() As String
        Get
            Return _treatment
        End Get
        Set(value As String)
            _treatment = value
        End Set
    End Property
    Public Property obese() As Boolean
        Get
            Return _Obese
        End Get
        Set(value As Boolean)
            _Obese = value
        End Set
    End Property
    Public Property highbloodmeds() As Boolean
        Get
            Return _highbloodmeds
        End Get
        Set(value As Boolean)
            _highbloodmeds = value
        End Set
    End Property

    Public Property anxietymeds As Boolean
        Get
            Return _anxietymeds
        End Get
        Set(value As Boolean)
            _anxietymeds = value
        End Set
    End Property

    Public Property Cholesterol() As Boolean
        Get
            Return _cholesterolmeds
        End Get
        Set(value As Boolean)
            _cholesterolmeds = value
        End Set
    End Property

    Public Property exebvirus() As Boolean
        Get
            Return _exebvirus
        End Get
        Set(value As Boolean)
            _exebvirus = value
        End Set
    End Property
    Public Property Female() As Boolean
        Get
            Return _female
        End Get
        Set(value As Boolean)
            _female = value
        End Set
    End Property


    'checks whether the user is diabetic or not
    Public Function Diabetic(bloodsugarlevel As Double) As Boolean Implements Diabetes.Diabetic
        Dim temp As Boolean
        If bloodsugarlevel <= 99 Then
            temp = False
        Else
            If bloodsugarlevel >= 126 Then
                temp = True
            End If
        End If
        Return temp
    End Function
    'specifies which autoimmnune disease the user might possibly have
    Public Function autoimmumetype(temp As Integer) As String
        Select Case temp
            Case 1
                type = "Diabetes type 1"
            Case 2
                type = "Grave Disease"
            Case 3
                type = "Gastritis"
            Case 4
                type = "Addison's disease"
            Case 5
                type = "Vitiligo"

        End Select

        Return type
    End Function

    Public Property userreport As user_report
        Get
            Return _userreport
        End Get
        Set(value As user_report)
            _userreport = value
        End Set
    End Property
    'states the treatment specific to the type of autoimmune disease at hand
    Public Overrides Function Medicament(x As Integer) As String
        Select Case x
            Case 1
                treatment = "Insulin"
            Case 2
                treatment = "Radiolodine therapy and surgery"
            Case 3
                treatment = "Antibiotic medications"
            Case 4
                treatment = " Corticosteroids"
            Case 5
                treatment = "Repigmentation therapy and light therapy"

        End Select

        Return treatment
    End Function


End Class

