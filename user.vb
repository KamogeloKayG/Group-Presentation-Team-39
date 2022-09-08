Public Class user
    Private _age As Integer
    Private _bmi As Double
    'Private _smoker, _alcoholic As Boolean
    Private _gender As String

    'constructor
    Public Sub New()

    End Sub

    'property
    Public Property age As Double
        Get
            Return _age
        End Get
        Set(value As Double)
            _age = value
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

    'method
    'utility
End Class
