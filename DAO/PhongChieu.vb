Public Class PhongChieu
    Private _maPhong As Integer
    Private _tenPhong As String
    Private _maLoaiPhong As Integer
    Private _marap As Integer
    Private _tinhTrang As Short
    Private _ngayHoanThanh as Date


    Public Property MaPhong As Integer
        Get
            Return _maPhong
        End Get
        Set(value As Integer)
            _maPhong = value
        End Set
    End Property

    Public Property TenPhong As String
        Get
            Return _tenPhong
        End Get
        Set(value As String)
            _tenPhong = value
        End Set
    End Property

    Public Property MaLoaiPhong As Integer
        Get
            Return _maLoaiPhong
        End Get
        Set(value As Integer)
            _maLoaiPhong = value
        End Set
    End Property

    Public Property MaRap As Integer
        Get
            Return _marap
        End Get
        Set(ByVal value As Integer)
            _marap = value
        End Set
    End Property

    Public Property TinhTrang As Short
        Get
            Return _tinhTrang
        End Get
        Set(value As Short)
            _tinhTrang = value
        End Set
    End Property

    Public Property NgayHoanThanh As Date
        Get
            Return _ngayHoanThanh
        End Get
        Set(value As Date)
            _ngayHoanThanh = value
        End Set
    End Property
End Class
