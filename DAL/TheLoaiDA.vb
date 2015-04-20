Imports System.Data.Common
Imports DAO

Public Class TheLoaiDA
    Public Shared Function GetDanhSach() As DataTable
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("text")
        cmd.CommandText = "SELECT * FROM THELOAI"
        Return GenericDataAccess.ExecuteSelectCommand(cmd)
    End Function

    Public Shared Function Them(t As TheLoai) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "INSERT INTO TheLoai(TenTheLoai) VALUES (@TenTheLoai)"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@TenTheLoai"
        para.Value = t.TenTheLoai
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        Dim result As Integer = -1
        Try
            result = GenericDataAccess.ExecuteNoneQuery(cmd)
        Catch ex As Exception

        End Try
        Return result
    End Function

    Public Shared Function Xoa(maTheLoai As Integer) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "DELETE FROM THELOAI WHERE Id = @MaTheLoai"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaTheLoai"
        para.Value = maTheLoai
        para.DbType = DbType.Int16
        cmd.Parameters.Add(para)

        Dim result As Integer = -1
        Try
            result = GenericDataAccess.ExecuteNoneQuery(cmd)
        Catch ex As Exception

        End Try
        Return result
    End Function

    Shared Function CapNhat(tl As TheLoai) As Boolean
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "UPDATE THELOAI SET TENTHELOAI = @TenTheLoai WHERE ID = @MaTheLoai"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaTheLoai"
        para.Value = tl.MaTheLoai
        para.DbType = DbType.Int16
        cmd.Parameters.Add(para)
        para = cmd.CreateParameter()
        para.ParameterName = "@TenTheLoai"
        para.Value = tl.TenTheLoai
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        Dim result As Integer = -1
        Try
            result = GenericDataAccess.ExecuteNoneQuery(cmd)
        Catch ex As Exception

        End Try
        Return result
    End Function

End Class
