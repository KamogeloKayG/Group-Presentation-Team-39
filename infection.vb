Option Strict On
Option Explicit On
Option Infer Off

Public Class infection
    Private _signsofinfection As String
    Private _source As String
    Private _transmisson As String
    Private _causes As String

    Public Property signsofinfection As String
        Get
            Return _signsofinfection
        End Get
        Set(value As String)
            _signsofinfection = value
        End Set
    End Property
    Private Property source As String
        Get
            Return _source
        End Get
        Set(value As String)
            _source = value
        End Set
    End Property
    Public Property transmission As String
        Get
            Return _transmisson
        End Get
        Set(value As String)
            _transmisson = value
        End Set
    End Property
    Public Property causes As String
        Get
            Return _causes
        End Get
        Set(value As String)
            _causes = value
        End Set
    End Property
End Class
