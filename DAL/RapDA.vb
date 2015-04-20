Imports DAO
Imports System.Data.Common

Public Class RapDA
    Public Shared Function GetDanhSach() As DataTable
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("text")
        cmd.CommandText = "SELECT * FROM RAPPHIM"
        Return GenericDataAccess.ExecuteSelectCommand(cmd)
    End Function

    Public Shared Function Them(p As Rap) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "INSERT INTO RAPCHIEU(TENRAP) VALUES (@TenRap)"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@TenRap"
        para.Value = p.TenRap
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        Dim result As Integer = -1
        Try
            result = GenericDataAccess.ExecuteNoneQuery(cmd)
        Catch ex As Exception

        End Try
        Return result
    End Function

    Public Shared Function Xoa(marap As Integer) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "DELETE FROM RAPCHIEU WHERE MARAP = @MaRap"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaRap"
        para.Value = marap
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        Dim result As Integer = -1
        Try
            result = GenericDataAccess.ExecuteNoneQuery(cmd)
        Catch ex As Exception

        End Try
        Return result
    End Function

    Public Shared Function Sua(p As Rap) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "UPDATE RAPCHIEU SET TENRAP = @TenRap WHERE MARAP = @MaRap"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@TenRap"
        para.Value = p.TenRap
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaRap"
        para.Value = p.MaRap
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        Dim result As Integer = -1
        Try
            result = GenericDataAccess.ExecuteNoneQuery(cmd)
        Catch ex As Exception

        End Try
        Return result
    End Function
End Class
