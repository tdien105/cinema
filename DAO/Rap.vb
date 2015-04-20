Public Class Rap
    Private _marap As Integer
    Private _tenrap As String
    Public Property MaRap As Integer
        Get
            Return _marap
        End Get
        Set(value As Integer)
            _marap = value
        End Set
    End Property
    Public Property TenRap As String
        Get
            Return _tenrap
        End Get
        Set(value As String)
            _tenrap = value
        End Set
    End Property
End Class
