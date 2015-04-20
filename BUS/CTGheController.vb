
Imports DAL
Imports DAO
Public Class CTGheController
    Public Shared Function GetHangGhe(maphong As Integer) As DataTable
        Return CTGheDA.GetHangGhe(maphong)
    End Function
    Public Shared Function GetMaGhe(maphong As Integer, mahang As String) As DataTable
        Return CTGheDA.GetMaGhe(maphong, mahang)
    End Function

    Shared Function Them(g As CTGhe) As Boolean
        Return CTGheDA.Them(g) <> -1
    End Function

End Class
