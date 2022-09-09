Public Class Bacterial
    Private _meandivisiontime As Double
    Private _initialnumbacteria As Integer
    Private _finalnumbacteria As Integer

    Private _report As report

    Public Property meandivisiontime As Double
        Get
            Return _meandivisiontime
        End Get
        Set(value As Double)
            _meandivisiontime = value
        End Set
    End Property

    Public Property initialnumbacteria As Integer
        Get
            Return _initialnumbacteria
        End Get
        Set(value As Integer)
            _initialnumbacteria = value
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

    Public Property finalnumbacteria As Integer
        Get
            Return _finalnumbacteria
        End Get
        Set(value As Integer)
            _finalnumbacteria = value
        End Set
    End Property

    Public Function calcnumbacteria(x As Integer) As Integer
        Dim numdivision As Integer
        numdivision = CInt(60 / _meandivisiontime)
        Return _initialnumbacteria * 2 ^ numdivision
    End Function
End Class
