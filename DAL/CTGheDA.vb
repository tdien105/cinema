Imports DAO
Imports System.Data.Common
Public Class CTGheDA

    Public Shared Function GetMaGhe(maphong As Integer, mahang As String) As DataTable
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("text")
        cmd.CommandText = "SELECT MAGHE FROM CTGHE WHERE MAPHONG = @MaPhong AND MAHANG = @MaHang"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaPhong"
        para.Value = maphong
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaHang"
        para.Value = mahang
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        Return GenericDataAccess.ExecuteSelectCommand(cmd)
    End Function

    Public Shared Function GetHangGhe(maphong As Integer) As DataTable
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("text")
        cmd.CommandText = "SELECT MAHANG FROM CTGHE GROUP BY MAPHONG,MAHANG HAVING MAPHONG = @MaPhong"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaPhong"
        para.Value = maphong
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)
        Return GenericDataAccess.ExecuteSelectCommand(cmd)
    End Function

    Public Shared Function GetDanhSach() As DataTable
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("text")
        cmd.CommandText = "SELECT * FROM CTGHE"
        Return GenericDataAccess.ExecuteSelectCommand(cmd)
    End Function

    Public Shared Function Them(p As CTGhe) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "INSERT INTO CTGHE(MAPHONG,MAHANG,MAGHE) VALUES (@MaPhong,@MaHang,@MaGhe)"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaPhong"
        para.Value = p.MaPhong
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaHang"
        para.Value = p.mahang
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaGhe"
        para.Value = p.MaGhe
        para.DbType = DbType.String
        cmd.Parameters.Add(para)
        Dim result As Integer = -1
        Try
            result = GenericDataAccess.ExecuteNoneQuery(cmd)
        Catch ex As Exception

        End Try
        Return result
    End Function

    Public Shared Function Xoa(id As Integer) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "DELETE FROM CTGHE WHERE ID = @ID"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@ID"
        para.Value = id
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        Dim result As Integer = -1
        Try
            result = GenericDataAccess.ExecuteNoneQuery(cmd)
        Catch ex As Exception

        End Try
        Return result
    End Function

    Public Shared Function Sua(p As CTGhe) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "UPDATE CTGHE SET MAPHONG = @MaPhong,MAHANG = @MaHang,MAGHE = @MaGhe WHERE ID = @ID"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaPhong"
        para.Value = p.MaPhong
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaHang"
        para.Value = p.mahang
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaGhe"
        para.Value = p.MaGhe
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@ID"
        para.Value = p.ID
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
