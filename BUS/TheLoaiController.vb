Imports DAL

Public Class TheLoaiController
    Public Shared Function GetDanhSach() As DataTable
        Return TheLoaiDA.GetDanhSach()
    End Function
    Public Shared Function Them(tl As DAO.TheLoai) As Boolean
        Return TheLoaiDA.Them(tl) <> -1
    End Function

    Public Shared Function Xoa(maTheLoai As Integer) As Boolean
        Return TheLoaiDA.Xoa(maTheLoai) <> -1
    End Function

    Public Shared Function CapNhat(tl As DAO.TheLoai) As Boolean
        Return TheLoaiDA.CapNhat(tl) <> -1
    End Function

End Class

