Imports DAL
Imports DAO
Public Class RapController
    Shared Function GetDS() As DataTable
        Return RapDA.GetDanhSach()
    End Function

End Class
