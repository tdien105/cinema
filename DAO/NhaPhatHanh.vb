Public Class NhaPhatHanh
    Private _maNPH As Integer
    Private _tenNPH As String


    Public Property MaNph As Integer
        Get
            Return _maNPH
        End Get
        Set(value As Integer)
            _maNPH = value
        End Set
    End Property

    Public Property TenNph As String
        Get
            Return _tenNPH
        End Get
        Set(value As String)
            _tenNPH = value
        End Set
    End Property
End Class
