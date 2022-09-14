'***************************************************************************************
'Team Member: Mogoane, M (222002111)
'Practical: Team Project
'Class Name: User
'***************************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Public Class user
    Private _age As Integer
    Private _bmi As Double
    Private _gender As String
    Private _sick, _meds, _HIVstatus, _sickFam As Boolean         'overall health
    Private _waterQA, _overcrowded, _stress As Boolean   'environmental factor
    Private _smoker, _alcoholic, _sActivity, _druggie As Boolean 'social habits

    'constructor
    Public Sub New()

    End Sub

    'property
    Public Property age As Integer
        Get
            Return _age
        End Get
        Set(value As Integer)
            valAge(value)
        End Set
    End Property

    Public Property bmi As Double
        Get
            Return _bmi
        End Get
        Set(value As Double)
            _bmi = value
        End Set
    End Property

    Public Property gender As String
        Get
            Return _gender
        End Get
        Set(value As String)
            _gender = value
        End Set
    End Property

    Public Property sick As Boolean
        Get
            Return _sick
        End Get
        Set(value As Boolean)
            _sick = value
        End Set
    End Property

    Public Property meds As Boolean
        Get
            Return _meds
        End Get
        Set(value As Boolean)
            _meds = value
        End Set
    End Property

    Public Property HIVPos As Boolean
        Get
            Return _HIVstatus
        End Get
        Set(value As Boolean)
            _HIVstatus = value
        End Set
    End Property

    Public Property waterQual As Boolean
        Get
            Return _waterQA
        End Get
        Set(value As Boolean)
            _waterQA = value
        End Set
    End Property

    Public Property overcrowded As Boolean
        Get
            Return _overcrowded
        End Get
        Set(value As Boolean)
            _overcrowded = value
        End Set
    End Property

    Public Property smoker As Boolean
        Get
            Return _smoker
        End Get
        Set(value As Boolean)
            _smoker = value
        End Set
    End Property

    Public Property alcoholic As Boolean
        Get
            Return _alcoholic
        End Get
        Set(value As Boolean)
            _alcoholic = value
        End Set
    End Property

    Public Property sAct As Boolean
        Get
            Return _sActivity
        End Get
        Set(value As Boolean)
            _sActivity = value
        End Set
    End Property

    Public Property stress As Boolean
        Get
            Return _stress
        End Get
        Set(value As Boolean)
            _stress = value
        End Set
    End Property

    Public Property drugs As Boolean
        Get
            Return _druggie
        End Get
        Set(value As Boolean)
            _druggie = value
        End Set
    End Property

    Public Property sickFam As Boolean
        Get
            Return _sickFam
        End Get
        Set(value As Boolean)
            _sickFam = value
        End Set
    End Property


    'method
    Public Function calcBMI(ByVal weight As Double, ByVal height As Double) As Double
        Return weight / height ^ 2
    End Function

    'utility
    Private Function valAge(ByVal num As Integer) As Integer
        If num < 0 Then
            MsgBox("Enter a valid age")
            _age = 0
        Else
            _age = num
        End If

        Return _age
    End Function

    'Private Function valGen(ByVal gender As String) As String
    '    If gender = "Select" Then
    '        MsgBox("Enter a valid gender")
    '        _gender = "Male"
    '    End If
    '    Return _gender
    'End Function
End Class
