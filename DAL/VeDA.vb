Imports DAO
Imports System.Data.Common
Public Class VeDA

    Public Shared Function Fillter(ngay As DateTime, suatchieu As DateTime, maphim As Integer) As DataTable
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("text")
        cmd.CommandText = "select MaVe,suatchieu,tenphong,MaGhe,giatien,Ngay from Ve left join SuatChieu on ve.MaSuat = suatchieu.masuat left join PhongChieu on suatchieu.MaPhong = phongchieu.MaPhong WHERE NGAY = @Ngay AND SUATCHIEU = @SuatChieu AND MAPHIM = @MaPhim"

        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@Ngay"
        para.Value = ngay
        para.DbType = DbType.DateTime
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@SuatChieu"
        para.Value = suatchieu
        para.DbType = DbType.DateTime
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaPhim"
        para.Value = maphim
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)
        Return GenericDataAccess.ExecuteSelectCommand(cmd)
    End Function
    Public Shared Function Search(mave As Integer) As DataTable
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("text")
        cmd.CommandText = "select MaVe,suatchieu,tenphong,MaGhe,giatien,Ngay from Ve left join SuatChieu on ve.MaSuat = suatchieu.masuat left join PhongChieu on suatchieu.MaPhong = phongchieu.MaPhong WHERE MAVE = @MaVe"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaVe"
        para.Value = mave
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)
        Return GenericDataAccess.ExecuteSelectCommand(cmd)
    End Function

    Public Shared Function GetAll() As DataTable
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("text")
        cmd.CommandText = "select MaVe,suatchieu,tenphong,MaGhe,giatien,Ngay from Ve left join SuatChieu on ve.MaSuat = suatchieu.masuat left join PhongChieu on suatchieu.MaPhong = phongchieu.MaPhong"
        Return GenericDataAccess.ExecuteSelectCommand(cmd)
    End Function
    Public Shared Function GetDanhSach(masuat As Integer) As DataTable
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("text")
        cmd.CommandText = "SELECT * FROM VE WHERE MASUAT = @MaSuat"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaSuat"
        para.Value = masuat
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)
        Return GenericDataAccess.ExecuteSelectCommand(cmd)
    End Function
    Public Shared Function Them(p As Ve) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "INSERT INTO VE(MASUAT,MAGHE,GIATIEN,NGAY) VALUES (@MaSuat,@MaGhe,@GiaTien,@Ngay)"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaSuat"
        para.Value = p.MaSuat
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaGhe"
        para.Value = p.MaGhe
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@GiaTien"
        para.Value = p.GiaTien
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@Ngay"
        para.Value = p.Ngay
        para.DbType = DbType.Date
        cmd.Parameters.Add(para)

        Dim result As Integer = -1
        Try
            result = GenericDataAccess.ExecuteNoneQuery(cmd)
        Catch ex As Exception

        End Try
        Return result
    End Function

    Public Shared Function Xoa(mave As Integer) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "DELETE FROM VE WHERE MAVE = @MaVe"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaVe"
        para.Value = mave
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        Dim result As Integer = -1
        Try
            result = GenericDataAccess.ExecuteNoneQuery(cmd)
        Catch ex As Exception

        End Try
        Return result
    End Function

    Public Shared Function Sua(p As Ve) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "UPDATE VE SET MASUAT = @MaSuat,MAGHE = @MaGhe WHERE MAVE = @MaVe"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaSuat"
        para.Value = p.MaSuat
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaGhe"
        para.Value = p.MaGhe
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        para.ParameterName = "@MaVe"
        para.Value = p.MaSuat
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
