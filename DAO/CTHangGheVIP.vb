Public Class CTHangGheVIP
    Private _id As Integer
    Private _maphong As Integer
    Private _mahang As String
    Public Property MaHang As String
        Get
            Return _mahang
        End Get
        Set(ByVal value As String)
            _mahang = value
        End Set
    End Property

    Public Property MaPhong As Integer
        Get
            Return _maphong
        End Get
        Set(ByVal value As Integer)
            _maphong = value
        End Set
    End Property

    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

End Class
