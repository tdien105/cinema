Imports DAL
Imports DAO
Public Class SuatChieuController
    Public Shared Function GetDS()
        Return SuatChieuDA.GetDanhSach()
    End Function
    Public Shared Function IsExist(p As SuatChieu, loaiphong As String) As SuatChieu
        Return SuatChieuDA.IsExist(p, loaiphong)
    End Function
    Public Shared Function GetMaLoaiPhong(masuat As Integer) As Integer
        Return SuatChieuDA.GetMaLoaiPhong(masuat)
    End Function

    Shared Function Get_DS_By_Ma_Phim(maPhim As Integer) As DataTable
        Return SuatChieuDA.Get_DS_By_Ma_Phim(maPhim)
    End Function

    Shared Function Them(sc As SuatChieu) As Boolean
        Return SuatChieuDA.Them(sc) <> -1
    End Function

    Shared Function Xoa(maSuat As Integer) As Boolean
        Return SuatChieuDA.Xoa(maSuat) <> -1
    End Function

    Shared Function CapNhat(sc As SuatChieu) As Boolean
        Return SuatChieuDA.Sua(sc) <> -1
    End Function

End Class
