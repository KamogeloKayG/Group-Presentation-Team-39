'Team Number: 39
'Team Member Details: Mabatha, KA (221077585)
'Team Member Details:Maposa T 222078730
'Team Member Details: Mogoane, M (222002111)
'Team Member Details:PANANA R 218026867
'Practical: Team Project
'Class Name: user-report
Option Strict On
Option Explicit On
Option Infer Off

Public Class user_report


    Private _usersName As String
    Private _weight As Double
    Private _height As Double
    Private _bloodsugarlevel As Double

    Public Property bloodsugarlevel As Double
        Get
            Return _bloodsugarlevel
        End Get
        Set(value As Double)
            _bloodsugarlevel = value
        End Set
    End Property

    Public Property username As String
        Get
            Return _usersName
        End Get
        Set(value As String)
            _usersName = value
        End Set
    End Property
    Public Property weight As Double
        Get
            Return _weight
        End Get
        Set(value As Double)
            _weight = value
        End Set
    End Property
    Public Property height As Double
        Get
            Return _height
        End Get
        Set(value As Double)
            _height = value
        End Set
    End Property

    Public Function BMI(weight As Double, height As Double) As Double
        Return (weight / height) ^ 2
    End Function
End Class
