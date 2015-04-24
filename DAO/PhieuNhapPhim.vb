Public Class PhieuNhapPhim
    Private _maPhieu As Integer
    Private _maPhim As Integer
    Private _ngayNhap As DateTime
    Private _soTien As Double


    Public Property MaPhieu As Integer
        Get
            Return _maPhieu
        End Get
        Set(value As Integer)
            _maPhieu = value
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

    Public Property NgayNhap As DateTime
        Get
            Return _ngayNhap
        End Get
        Set(value As DateTime)
            _ngayNhap = value
        End Set
    End Property

    Public Property SoTien As Double
        Get
            Return _soTien
        End Get
        Set(value As Double)
            _soTien = value
        End Set
    End Property
End Class
