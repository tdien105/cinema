Imports System.Data.Common

Public Class NHPDA
    Public Shared Function GetDanhSach() As DataTable
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("text")
        cmd.CommandText = "SELECT * FROM NhaPhatHanhPhim"
        Return GenericDataAccess.ExecuteSelectCommand(cmd)
    End Function
End Class
