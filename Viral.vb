Option Strict On
Option Explicit On
Option Infer Off

Public Class Viral

    Private _report As report
    Private _age As Integer
    Private _female As Boolean
    Private _sexualActivity As Integer
    Private _drugintake As Integer
    Private _chances As Integer
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


    Public Property Drugs As Integer
        Get
            Return _drugintake
        End Get
        Set(value As Integer)
            _drugintake = value
        End Set
    End Property

    'Public Function Chnces() As Integer
    '    If _sexualActivity > 10 Then
    '        _chances = 50%
    '    Else
    '        _chances = 0
    '    End If
    '    Return _chances
    'End Function

    Public Property report As report
        Get
            Return _report
        End Get
        Set(value As report)
            _report = value
        End Set
    End Property
End Class
