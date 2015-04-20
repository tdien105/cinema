Public Class TheLoai
    Private _maTheLoai As Integer
    Private _tenTheLoai As String

    Public Property MaTheLoai As Integer
        Get
            Return _maTheLoai
        End Get
        Set(value As Integer)
            _maTheLoai = value
        End Set
    End Property

    Public Property TenTheLoai As String
        Get
            Return _tenTheLoai
        End Get
        Set(value As String)
            _tenTheLoai = value
        End Set
    End Property
End Class
