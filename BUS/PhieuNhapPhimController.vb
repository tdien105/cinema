Imports DAL
Imports DAO
Public Class PhieuNhapPhimController
    Public Shared Function Them(p As PhieuNhapPhim) As Boolean
        Return PhieuNhapPhimDA.Them(p) <> -1
    End Function
    Public Shared Function Sua(p As PhieuNhapPhim) As Boolean
        Return PhieuNhapPhimDA.Sua(p) <> -1
    End Function
    Public Shared Function Xoa(maphieu As Integer) As Boolean
        Return PhieuNhapPhimDA.Xoa(maphieu) <> -1
    End Function

    Shared Function Lay_DS_DoanhThu() As DataTable
        Return PhieuNhapPhimDA.Lay_DS_DoanhThu()
    End Function

End Class
