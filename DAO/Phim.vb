Public Class Phim
    Private _maPhim As Integer
    Private _tenPhim As String
    Private _matheloai As Integer
    Private _maNPH As Integer
    Private _thongTinPhim As String
    Private _hinhAnh As String
    Private _daodien As String
    Private _thoiluong As Integer
    Private _dotuoi As Integer
    Private _trailer As String
    Private _ngaycongchieu As DateTime
    Public Property NgayCongChieu As DateTime
        Get
            Return _ngaycongchieu
        End Get
        Set(ByVal value As DateTime)
            _ngaycongchieu = value
        End Set
    End Property

    Public Property Trailer As String
        Get
            Return _trailer
        End Get
        Set(ByVal value As String)
            _trailer = value
        End Set
    End Property

    Public Property DoTuoi As Integer
        Get
            Return _dotuoi
        End Get
        Set(ByVal value As Integer)
            _dotuoi = value
        End Set
    End Property


    Public Property ThoiLuong As Integer
        Get
            Return _thoiluong
        End Get
        Set(ByVal value As Integer)
            _thoiluong = value
        End Set
    End Property

    Public Property DaoDien As String
        Get
            Return _daodien
        End Get
        Set(ByVal value As String)
            _daodien = value
        End Set
    End Property


    Public Property MaPhim As Integer
        Get
            Return _maPhim
        End Get
        Set(value As Integer)
            _maPhim = value
        End Set
    End Property

    Public Property TenPhim As String
        Get
            Return _tenPhim
        End Get
        Set(value As String)
            _tenPhim = value
        End Set
    End Property

    Public Property MaTheLoai As Integer
        Get
            Return _matheloai
        End Get
        Set(value As Integer)
            _matheloai = value
        End Set
    End Property

    Public Property MaNph As Integer
        Get
            Return _maNPH
        End Get
        Set(value As Integer)
            _maNPH = value
        End Set
    End Property

    Public Property ThongTinPhim As String
        Get
            Return _thongTinPhim
        End Get
        Set(value As String)
            _thongTinPhim = value
        End Set
    End Property

    Public Property HinhAnh As String
        Get
            Return _hinhAnh
        End Get
        Set(value As String)
            _hinhAnh = value
        End Set
    End Property
End Class
