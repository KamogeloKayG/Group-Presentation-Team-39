Public Class Bacterial
    Private _hivpositive As Boolean
    Private _druguse As Boolean
    Private _underweight As Boolean
    Private _report As report

    Public Property hivpositive As Boolean
        Get
            Return _hivpositive
        End Get
        Set(value As Boolean)
            _hivpositive = value
        End Set
    End Property

    Public Property druguse As Boolean
        Get
            Return _druguse
        End Get
        Set(value As Boolean)
            _druguse = value
        End Set
    End Property

    Public Property underweight As Boolean
        Get
            Return _underweight
        End Get
        Set(value As Boolean)
            _underweight = value
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
