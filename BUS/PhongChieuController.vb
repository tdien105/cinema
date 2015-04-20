Imports DAL
Imports DAO
Public Class PhongChieuController
    Shared Function GetDanhSach() As DataTable
        Return PhongChieuDA.GetDanhSach()
    End Function

    Shared Function GetDanhSach_PhongChieu_Va_LoaiPhong_Theo_Rap(maRap As Integer) As DataTable
        Return PhongChieuDA.GetDanhSach_PhongChieu_Va_LoaiPhong_Theo_Rap(maRap)
    End Function

    Shared Function SetPhongChieuHu(maPhong As Integer, ngayHoanThanh As Date) As Boolean
        Return PhongChieuDA.SetPhongChieuHu(maPhong, ngayHoanThanh) <> -1
    End Function

    Shared Function Them(phongChieu As PhongChieu) As Boolean
        Return PhongChieuDA.Them(phongChieu) <> -1
    End Function

    Shared Function GetLatestID() As Integer
        Return PhongChieuDA.GetLatestID()
    End Function

   

End Class
