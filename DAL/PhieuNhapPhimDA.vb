Imports DAO
Imports System.Data.Common
Public Class PhieuNhapPhimDA
    Public Shared Function GetDanhSach() As DataTable
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("text")
        cmd.CommandText = "SELECT * FROM PHIEUNHAPPHIM"
        Return GenericDataAccess.ExecuteSelectCommand(cmd)
    End Function

    Public Shared Function Them(p As PhieuNhapPhim) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "INSERT INTO PHIEUNHAPPHIM(MAPHIM,NGAYNHAP,SOTIEN) VALUES (@MaPhim,@NgayNhap,@SoTien)"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaPhim"
        para.Value = p.MaPhim
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@NgayNhap"
        para.Value = p.NgayNhap
        para.DbType = DbType.DateTime
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@SoTien"
        para.Value = p.SoTien
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        Dim result As Integer = -1
        Try
            result = GenericDataAccess.ExecuteNoneQuery(cmd)
        Catch ex As Exception

        End Try
        Return result
    End Function

    Public Shared Function Xoa(maphieu As Integer) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "DELETE FROM PHIEUNHAPPHIM WHERE MAPHIEU = @MaPhieu"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaPhieu"
        para.Value = maphieu
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        Dim result As Integer = -1
        Try
            result = GenericDataAccess.ExecuteNoneQuery(cmd)
        Catch ex As Exception

        End Try
        Return result
    End Function

    Public Shared Function Sua(p As PhieuNhapPhim) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "UPDATE PHIEUNHAPPHIM SET MAPHIM = @MaPhim,NGAYNHAP =@NgayNhap,SOTIEN =@SoTien WHERE MAPHIEU = @MaPhieu"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaPhim"
        para.Value = p.MaPhieu
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@NgayNhap"
        para.Value = p.NgayNhap
        para.DbType = DbType.DateTime
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@SoTien"
        para.Value = p.SoTien
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaPhieu"
        para.Value = p.MaPhieu
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
