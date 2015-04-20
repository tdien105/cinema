Imports DAO
Imports System.Data.Common
Public Class GiaVeDA

    Public Shared Function GetGia(maloaiphong As Integer, dieukien As String) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("Text")
        cmd.CommandText = "SELECT GIAVE FROM GIAVE WHERE MALOAIPHONG = @MaLoaiPhong AND DIEUKIEN = @DieuKien"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaLoaiPhong"
        para.Value = maloaiphong
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@DieuKien"
        para.Value = dieukien
        para.DbType = DbType.String
        cmd.Parameters.Add(para)
        Return Integer.Parse(GenericDataAccess.ExecuteScalar(cmd))
    End Function
    Public Shared Function GetDanhSach() As DataTable
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "SELECT * FROM GIAVE"
        Return GenericDataAccess.ExecuteSelectCommand(cmd)
    End Function

    Public Shared Function Them(p As GiaVe) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "INSERT INTO GIAVE(MALOAIPHONG,GIAVE,DIEUKIEN) VALUES (@MaLoaiPhong,@GiaVe,@DieuKien"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaLoaiPhong"
        para.Value = p.MaLoaiPhong
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@GiaVe"
        para.Value = p.GiaVe
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@DieuKien"
        para.Value = p.DieuKien
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
        cmd.CommandText = "DELETE FROM GiaVe WHERE ID = @ID"
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

    Public Shared Function Sua(p As GiaVe) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "UPDATE GIAVE SET MALOAIPHONG = @MaLoaiPhong,GIAVE = @GiaVe,DIEUKIEN = @DieuKien WHERE ID = @ID"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaLoaiPhong"
        para.Value = p.MaLoaiPhong
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@GiaVe"
        para.Value = p.GiaVe
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@DieuKien"
        para.Value = p.DieuKien
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
