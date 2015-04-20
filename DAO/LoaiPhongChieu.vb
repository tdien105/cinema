Public Class LoaiPhongChieu
    Private _maLoaiPhong As Integer
    Private _tenLoaiPhong As String


    Public Property MaLoaiPhong As Integer
        Get
            Return _maLoaiPhong
        End Get
        Set(value As Integer)
            _maLoaiPhong = value
        End Set
    End Property

    Public Property TenLoaiPhong As String
        Get
            Return _tenLoaiPhong
        End Get
        Set(value As String)
            _tenLoaiPhong = value
        End Set
    End Property
End Class
