Imports System.Data.Common
Imports DAO

Public Class PhimDA
    Public Shared Function GetDanhSach() As DataTable
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "SELECT *  FROM Phim P LEFT JOIN PhieuNhapPhim PN ON P.MaPhim = PN.MaPhim LEFT JOIN TheLoai TL ON P.MaTheLoai = TL.MaTheLoai LEFT JOIN NhaPhatHanhPhim NPH ON P.MaNhaPhatHanh = NPH.MaNPH "
        Return GenericDataAccess.ExecuteSelectCommand(cmd)
    End Function
    'Public Shared Function Fillter(marap As Integer, maphong As Integer) As datatb
    '    Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
    '    cmd.CommandText = "SELECT P.MaPhim, P.TenPhim,P.ThongTinPhim,TL.TenTheLoai,P.HinhAnh,NPH.TenNPH FROM PHIM P LEFT JOIN TheLoai TL ON P.MaTheLoai = TL.MaTheLoai LEFT JOIN NhaPhatHanhPhim NPH ON P.MaNhaPhatHanh = NPH.MaNPH WHERE "
    '    Dim para As DbParameter = cmd.CreateParameter()
    '    para.ParameterName = "@TenPhim"
    '    para.Value = p.TenPhim
    '    para.DbType = DbType.String
    '    cmd.Parameters.Add(para)
    'End Function

    '[MaPhim]
    '  ,[TenPhim]
    '  ,[MaTheLoai]
    '  ,[MaNhaPhatHanh]
    '  ,[ThongTinPhim]
    '  ,[HinhAnh]
    '  ,[DaoDien]
    '  ,[ThoiLuong]
    '  ,[Trailer]
    '  ,[DoTuoi]
    '  ,[NgayCongChieu]
    Public Shared Function Them(p As Phim) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "INSERT INTO PHIM(TenPhim,MaTheLoai,MaNhaPhatHanh,ThongTinPhim,HinhAnh,DaoDien,ThoiLuong,Trailer,DoTuoi,NgayCongChieu) VALUES (@TenPhim,@MaTheLoai,@MaNhaPhatHanh,@ThongTinPhim,@HinhAnh,@DaoDien,@ThoiLuong,@Trailer,@DoTuoi,@NgayCongChieu);Select @@Identity"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@TenPhim"
        para.Value = p.TenPhim
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaTheLoai"
        para.Value = p.MaTheLoai
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaNhaPhatHanh"
        para.Value = p.MaNph
        para.DbType = DbType.Int16
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@ThongTinPhim"
        para.Value = p.ThongTinPhim
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@HinhAnh"
        para.Value = p.HinhAnh
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@DaoDien"
        para.Value = p.DaoDien
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@ThoiLuong"
        para.Value = p.ThoiLuong
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@Trailer"
        para.Value = p.Trailer
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@DoTuoi"
        para.Value = p.DoTuoi
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@NgayCongChieu"
        para.Value = p.NgayCongChieu
        para.DbType = DbType.DateTime
        cmd.Parameters.Add(para)

        Dim result As Integer = -1
        Try
            result = GenericDataAccess.ExecuteScalar(cmd)
        Catch ex As Exception

        End Try
        Return result
    End Function

    Public Shared Function Xoa(maPhim As Integer) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "DELETE FROM PHIM WHERE MAPHIM = @MaPhim"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaPhim"
        para.Value = maPhim
        para.DbType = DbType.Int16
        cmd.Parameters.Add(para)

        Dim result As Integer = -1
        Try
            result = GenericDataAccess.ExecuteNoneQuery(cmd)
        Catch ex As Exception

        End Try
        Return result
    End Function

    Public Shared Function Sua(p As Phim) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "UPDATE PHIM SET TENPHIM = @TenPhim,MATHELOAI = @MaTheLoai,MANHAPHATHANH = @MaNPH,THONGTINPHIM = @ThongTinPhim WHERE MAPHIM = @MaPhim"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaPhim"
        para.Value = p.MaPhim
        para.DbType = DbType.Int16
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@TenPhim"
        para.Value = p.TenPhim
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaTheLoai"
        para.Value = p.MaTheLoai
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaNPH"
        para.Value = p.MaNph
        para.DbType = DbType.Int16
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@ThongTinPhim"
        para.Value = p.ThongTinPhim
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
