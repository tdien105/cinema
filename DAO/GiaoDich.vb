Public Class GiaoDich
    Private _maGiaoDich As Integer
    Private _ngayGiaoDich As DateTime
    Private _tongTien As Double

    Public Property MaGiaoDich As Integer
        Get
            Return _maGiaoDich
        End Get
        Set(value As Integer)
            _maGiaoDich = value
        End Set
    End Property

    Public Property NgayGiaoDich As Date
        Get
            Return _ngayGiaoDich
        End Get
        Set(value As Date)
            _ngayGiaoDich = value
        End Set
    End Property

    Public Property TongTien As Double
        Get
            Return _tongTien
        End Get
        Set(value As Double)
            _tongTien = value
        End Set
    End Property
End Class
