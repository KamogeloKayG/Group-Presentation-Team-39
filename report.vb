Option Strict On
Option Explicit On
Option Infer Off

Public Class report
    'comment
    Private _diseases As String
    Private _prevention As String

    Public Property diseases As String
        Get
            Return _diseases
        End Get
        Set(value As String)
            _diseases = value
        End Set
    End Property

    Public Property prevention As String
        Get
            Return _prevention
        End Get
        Set(value As String)
            _prevention = value
        End Set
    End Property

End Class
