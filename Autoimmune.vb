Option Strict On
Option Explicit On
Option Infer Off

Public Class Autoimmune
    Private _obese As Boolean
    Private _medication As Boolean
    Private _report As report

    Public Property obese As Boolean
        Get
            Return _obese
        End Get
        Set(value As Boolean)
            _obese = value
        End Set
    End Property

    Public Property medication As Boolean
        Get
            Return _medication
        End Get
        Set(value As Boolean)
            _medication = value
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
End Class
