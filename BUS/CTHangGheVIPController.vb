
Imports DAL
Imports DAO
Public Class CTHangGheVIPController
    Public Shared Function CheckVIP(maphong As Integer, maghe As String) As Boolean
        Return CTHangGheVIPDA.CheckVIP(maphong, maghe)
    End Function

    Shared Function Them(vip As CTHangGheVIP) As Boolean
        Return CTHangGheVIPDA.Them(vip) <> -1
    End Function

End Class
