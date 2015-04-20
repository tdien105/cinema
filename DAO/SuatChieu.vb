Public Class SuatChieu
    Private _maSuat As Integer
    Private _maPhong As Integer
    Private _maphim As Integer
    Private _marap As Integer
    Private _suatChieu As DateTime
    Private _ngaychieu As DateTime

    Public Property MaSuat As Integer
        Get
            Return _maSuat
        End Get
        Set(value As Integer)
            _maSuat = value
        End Set
    End Property

    Public Property MaPhong As Integer
        Get
            Return _maPhong
        End Get
        Set(value As Integer)
            _maPhong = value
        End Set
    End Property

    Public Property MaPhim() As Integer
        Get
            Return _maphim
        End Get
        Set(ByVal value As Integer)
            _maphim = value
        End Set
    End Property

    Public Property MaRap As Integer
        Get
            Return _marap
        End Get
        Set(value As Integer)
            _marap = value
        End Set
    End Property

    Public Property NgayChieu As Date
        Get
            Return _ngaychieu
        End Get
        Set(value As Date)
            _ngaychieu = value
        End Set
    End Property

    Public Property SuatChieu As Date
        Get
            Return _suatChieu
        End Get
        Set(value As Date)
            _suatChieu = value
        End Set
    End Property
End Class
