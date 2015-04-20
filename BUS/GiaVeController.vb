
Imports DAL
Imports DAO
Public Class GiaVeController
    Public Shared Function GetDS() As DataTable
        Return GiaVeDA.GetDanhSach()
    End Function
    Public Shared Function GetGia(maloaiphong As Integer, dieukien As String) As Integer
        Return GiaVeDA.GetGia(maloaiphong, dieukien)
    End Function
End Class
