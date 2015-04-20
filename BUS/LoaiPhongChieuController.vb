Imports DAL
Imports DAO
Public Class LoaiPhongChieuController
    Public Shared Function GetDS() As DataTable
        Return LoaiPhongChieuDA.GetDanhSach()
    End Function
End Class
