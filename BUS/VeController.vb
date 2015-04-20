Imports DAL
Imports DAO
Public Class VeController
    Public Shared Function Them(v As Ve) As Integer
        Return VeDA.Them(v)
    End Function
    Public Shared Function GetDS(masuat As Integer) As DataTable
        Return VeDA.GetDanhSach(masuat)
    End Function
    Public Shared Function GetAll() As DataTable
        Return VeDA.GetAll()
    End Function
    Public Shared Function Fillter(ngay As DateTime, suatchieu As DateTime, maphim As Integer) As DataTable
        Return VeDA.Fillter(ngay, suatchieu, maphim)
    End Function
    Public Shared Function Search(mave As Integer) As DataTable
        Return VeDA.Search(mave)
    End Function
End Class
