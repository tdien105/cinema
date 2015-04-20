Imports DAO
Imports System.Data.Common

Public Class PhongChieuDA

    Public Shared Function GetDanhSach() As DataTable
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("text")
        cmd.CommandText = "SELECT * FROM PHONGCHIEU"
        Return GenericDataAccess.ExecuteSelectCommand(cmd)
    End Function

    Public Shared Function GetDanhSach_PhongChieu_Va_LoaiPhong_Theo_Rap(maRap As Integer) As DataTable
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("text")
        cmd.CommandText = "SELECT *, SOGHEVIP = (SELECT COUNT(MAGHE) FROM CTGHE GROUP BY MaPhong,MAHANG HAVING MAPHONG = P.MaPhong AND MaHang = V.MaHang ) ,SOGHE = (SELECT COUNT(MAGHE) FROM CTGhe GROUP BY MaPhong HAVING MaPhong = P.MaPhong) FROM PHONGCHIEU P JOIN LOAIPHONGCHIEU LP ON P.MALOAIPHONG = LP.MALOAIPHONG LEFT JOIN CTHangGheVIP V ON P.MaPhong = V.MaPhong  "
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaRap"
        para.Value = maRap
        para.DbType = DbType.Int16
        cmd.Parameters.Add(para)

        Return GenericDataAccess.ExecuteSelectCommand(cmd)
    End Function

    Public Shared Function Them(p As PhongChieu) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "INSERT INTO PHONGCHIEU(TENPHONG,MALOAIPHONG,MARAP) VALUES (@TenPhong,@MaLoaiPhong,@MaRap)"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@TenPhong"
        para.Value = p.TenPhong
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaLoaiPhong"
        para.Value = p.MaLoaiPhong
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@Marap"
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

    Public Shared Function Xoa(maphong As Integer) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "DELETE FROM PHONGCHIEU WHERE MAPHONG = @MaPhong"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaPhong"
        para.Value = maphong
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        Dim result As Integer = -1
        Try
            result = GenericDataAccess.ExecuteNoneQuery(cmd)
        Catch ex As Exception

        End Try
        Return result
    End Function

    Public Shared Function Sua(p As PhongChieu) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "UPDATE PHONGCHIEU SET TENPHONG = @TenPhong,MALOAIPHONG = @MaLoaiPhong,MARAP = @MaRap, TinhTrang=@TinhTrang, NgayHoanThanh=@NgayHoanThanh WHERE MAPHONG = @MaPhong"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@TenPhong"
        para.Value = p.TenPhong
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaLoaiPhong"
        para.Value = p.MaLoaiPhong
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@Marap"
        para.Value = p.MaRap
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaPhong"
        para.Value = p.MaPhong
        para.DbType = DbType.Binary
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@NgayHoanThanh"
        para.Value = p.NgayHoanThanh
        para.DbType = DbType.Date
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@TinhTrang"
        para.Value = p.TinhTrang
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        Dim result As Integer = -1
        Try
            result = GenericDataAccess.ExecuteNoneQuery(cmd)
        Catch ex As Exception

        End Try
        Return result
    End Function

    Shared Function SetPhongChieuHu(maPhong As Integer, ngayHoanThanh As Date) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "UPDATE PHONGCHIEU SET TinhTrang = 0, NgayHoanThanh=@NgayHoanThanh WHERE MAPHONG = @MaPhong"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaPhong"
        para.Value = maPhong
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@NgayHoanThanh"
        para.Value = ngayHoanThanh
        para.DbType = DbType.Date
        cmd.Parameters.Add(para)

        Dim result As Integer = -1
        Try
            result = GenericDataAccess.ExecuteNoneQuery(cmd)
        Catch ex As Exception

        End Try
        Return result
    End Function

    Shared Function GetLatestID() As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("text")
        cmd.CommandText = "SELECT COUNT(*) FROM PHONGCHIEU"

        Return Int16.Parse(GenericDataAccess.ExecuteScalar(cmd))
    End Function

End Class
