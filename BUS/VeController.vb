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

    Shared Function Lay_DS_DoanhThu() As DataTable
        Return VeDA.Lay_DS_DoanhThu_Theo_Phim()
    End Function

    Shared Function Lay_DS_DoanhThu_Theo_Phong_Chieu() As Object
        Return VeDA.Lay_DS_DoanhThu_Theo_Phong_Chieu()
    End Function

    Shared Function Lay_DS_DoanhThu_Theo_Ngay() As Object
        Return VeDA.Lay_DS_DoanhThu_Theo_Ngay()
    End Function

    Shared Function Lay_DS_DoanhThu_Between_Ngay(dtpFrom As Date, dtpTo As Date) As DataTable
        Return VeDA.Lay_DS_DoanhThu_Between_Ngay(dtpFrom, dtpTo)
    End Function

End Class
