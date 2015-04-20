
Imports System.Data.Common
Imports DAO
Imports System.Data.SqlClient
Public Class CTHangGheVIPDA

    Public Shared Function CheckVIP(maphong As Integer, maghe As String) As Boolean
        Dim MaHang = maghe.First()
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "SELECT * FROM CTHANGGHEVIP WHERE MAPHONG = @MaPhong AND MAHANG = @MaHang"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaPhong"
        para.Value = maphong
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaHang"
        para.Value = MaHang
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        If Not GenericDataAccess.ExecuteSelectCommand(cmd).Rows.Count() = 0 Then
            Return True
        End If
        Return False
    End Function

    Public Shared Function GetDanhSach() As DataTable
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("text")
        cmd.CommandText = "SELECT * FROM CTHANGGHEVIP"
        Return GenericDataAccess.ExecuteSelectCommand(cmd)
    End Function

    Public Shared Function Them(p As CTHangGheVIP) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "INSERT INTO CTHANGGHEVIP(MAPHONG,MAHANG) VALUES (@MaPhong,@MaHang)"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaPhong"
        para.Value = p.MaPhong
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaHang"
        para.Value = p.MaPhong
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        Dim result As Integer = -1
        Try
            result = GenericDataAccess.ExecuteNoneQuery(cmd)
        Catch ex As Exception

        End Try
        Return result
    End Function

    Public Shared Function Xoa(ID As Integer) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "DELETE FROM CTHANGGHEVIP WHERE ID = @ID"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@ID"
        para.Value = ID
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        Dim result As Integer = -1
        Try
            result = GenericDataAccess.ExecuteNoneQuery(cmd)
        Catch ex As Exception

        End Try
        Return result
    End Function

    Public Shared Function Sua(p As CTHangGheVIP) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "UPDATE CTHANGGHEVIP SET MAPHONG = @MaPhong,MAHANG = @MaHang WHERE ID = @ID"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaPhong"
        para.Value = p.MaPhong
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaHang"
        para.Value = p.MaHang
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@ID"
        para.Value = p.ID
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
