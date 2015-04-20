Imports DAO
Imports System.Data.Common
Public Class LoaiPhongChieuDA
    Public Shared Function GetDanhSach() As DataTable
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("text")
        cmd.CommandText = "SELECT * FROM LOAIPHONGCHIEU"
        Return GenericDataAccess.ExecuteSelectCommand(cmd)
    End Function
    Public Shared Function Them(p As LoaiPhongChieu) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "INSERT INTO LOAIPHONGCHIEU(TENLOAIPHONG) VALUES (@TenLoaiPhong)"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@TenLoaiPhong"
        para.Value = p.TenLoaiPhong
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        Dim result As Integer = -1
        Try
            result = GenericDataAccess.ExecuteNoneQuery(cmd)
        Catch ex As Exception

        End Try
        Return result
    End Function

    Public Shared Function Xoa(maloaiphong As Integer) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "DELETE FROM LOAIPHONGCHIEU WHERE MALOAIPHONG = @MaLoaiPhong"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaLoaiPhong"
        para.Value = maloaiphong
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        Dim result As Integer = -1
        Try
            result = GenericDataAccess.ExecuteNoneQuery(cmd)
        Catch ex As Exception

        End Try
        Return result
    End Function

    Public Shared Function Sua(p As LoaiPhongChieu) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "UPDATE LOAIPHONGCHIEU SET TENLOAIPHONG = @TenLoaiPhong WHERE MALOAIPHONG = @MaLoaiPhong"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@TenLoaiPhong"
        para.Value = p.TenLoaiPhong
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaLoaiPhong"
        para.Value = p.MaLoaiPhong
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
