Imports DAL

Public Class NPHController
    Public Shared Function GetDanhSach() As DataTable
        Return NHPDA.GetDanhSach()
    End Function
End Class
