Imports DAL
Imports DAO

Public Class PhimController
    Public Shared Function GetDS() As DataTable
        Return PhimDA.GetDanhSach()
    End Function
    Public Shared Function Them(p As Phim) As Boolean
        Return PhimDA.Them(p) <> -1
    End Function

    Public Shared Function Sua(p As Phim) As Boolean
        Return PhimDA.Sua(p) <> -1
    End Function
    Public Shared Function Xoa(maphim As Integer) As Integer
        Return PhimDA.Xoa(maphim)
    End Function

    Shared Function SearchResult(keyWord As String, tieuChi As Integer) As DataView
        Dim result As New DataView(PhimDA.GetDanhSach())
        Dim key As String = String.Empty
        Select Case tieuChi
            Case 1
                key = "TenPhim like '*" + keyWord + "*'"
                result.RowFilter = key
            Case 2
                key = "TenTheLoai like '*" + keyWord + "*'"
                result.RowFilter = key
            Case 3
                key = "TenNPH like '*" + keyWord + "*'"
                result.RowFilter = key
            Case Else
                key = "TenPhim like '*" + keyWord + "*'"
                result.RowFilter = key
        End Select

        Return result

    End Function

End Class
