Public Class GiaVe
    Private _id As Integer
    Private _maloaiphong As Integer
    Private _dieukien As String
    Private _giave As Double
    Public Property GiaVe As String
        Get
            Return _giave
        End Get
        Set(ByVal value As String)
            _giave = value
        End Set
    End Property

    Public Property DieuKien As String
        Get
            Return _dieukien
        End Get
        Set(ByVal value As String)
            _dieukien = value
        End Set
    End Property

    Public Property MaLoaiPhong As Integer
        Get
            Return _maloaiphong
        End Get
        Set(ByVal value As Integer)
            _maloaiphong = value
        End Set
    End Property



    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

End Class
