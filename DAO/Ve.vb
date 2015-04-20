Public Class Ve
    Private _maVe As Integer
    Private _maSuat As Integer
    Private _maGhe As String
    Private _giaTien As Double
    Private _ngay As Date
    Public Property Ngay As Date
        Get
            Return _ngay
        End Get
        Set(ByVal value As Date)
            _ngay = value
        End Set
    End Property


    Public Property MaVe As Integer
        Get
            Return _maVe
        End Get
        Set(value As Integer)
            _maVe = value
        End Set
    End Property

    Public Property MaSuat As Integer
        Get
            Return _maSuat
        End Get
        Set(value As Integer)
            _maSuat = value
        End Set
    End Property

    Public Property MaGhe As String
        Get
            Return _maGhe
        End Get
        Set(value As String)
            _maGhe = value
        End Set
    End Property

    Public Property GiaTien As Double
        Get
            Return _giaTien
        End Get
        Set(value As Double)
            _giaTien = value
        End Set
    End Property
End Class
