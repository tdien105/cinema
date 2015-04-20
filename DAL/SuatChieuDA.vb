Imports DAO
Imports System.Data.Common

Public Class SuatChieuDA
    'select * from SuatChieu
    'where MaPhong in (select MaPhong from phongchieu P
    'left join LoaiPhongChieu L on P.MaLoaiPhong = L.MaLoaiPhong where TenLoaiPhong = 'VIP')
    Public Shared Function IsExist(p As SuatChieu, loaiphong As String) As SuatChieu
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("Text")
        cmd.CommandText = "SELECT * FROM SUATCHIEU WHERE MAPHIM = @MaPhim AND MARAP = @MaRap AND SUATCHIEU = @SuatChieu AND NGAYCHIEU = @NgayChieu AND MAPHONG IN (select MaPhong from phongchieu P left join LoaiPhongChieu L on P.MaLoaiPhong = L.MaLoaiPhong where TenLoaiPhong = @LoaiPhong)"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@LoaiPhong"
        para.Value = loaiphong
        para.DbType = DbType.String
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaPhim"
        para.Value = p.MaPhim
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaRap"
        para.Value = p.MaRap
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@SuatChieu"
        para.Value = p.SuatChieu
        para.DbType = DbType.DateTime
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@NgayChieu"
        para.Value = p.NgayChieu
        para.DbType = DbType.Date
        cmd.Parameters.Add(para)

        Dim SC As New SuatChieu
        For Each s As DataRow In GenericDataAccess.ExecuteSelectCommand(cmd).Rows
            SC.MaSuat = Integer.Parse(s("masuat"))
            SC.MaPhim = Integer.Parse(s("maphim"))
            SC.MaPhong = Integer.Parse(s("maphong"))
            SC.MaRap = Integer.Parse(s("marap"))
            SC.NgayChieu = Date.Parse(s("ngaychieu"))
            SC.SuatChieu = DateTime.Parse(s("suatchieu"))
        Next
        Return SC
    End Function
    Public Shared Function GetDanhSach() As DataTable
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("text")
        cmd.CommandText = "SELECT LTRIM(RIGHT(CONVERT(VARCHAR(20), SUATCHIEU, 100), 7)) AS SC, * FROM SUATCHIEU"
        'cmd.CommandText = "SELECT SUATCHIEU FROM SUATCHIEU"
        Return GenericDataAccess.ExecuteSelectCommand(cmd)
    End Function
    Public Shared Function GetMaLoaiPhong(masuat As Integer) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("Text")
        cmd.CommandText = "SELECT MaLoaiPhong FROM SuatChieu SC LEFT JOIN PhongChieu PC ON SC.MaPhong = PC.MaPhong WHERE MASUAT = @MaSuat "
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaSuat"
        para.Value = masuat
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)
        Return Integer.Parse(GenericDataAccess.ExecuteScalar(cmd))

    End Function
    Public Shared Function Them(p As SuatChieu) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "INSERT INTO SUATCHIEU(MAPHONG,MAPHIM,MARAP,SUATCHIEU,NGAYCHIEU) VALUES (@MaPhong,@MaPhim,@MaRap,@SuatChieu,@NgayChieu)"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaPhong"
        para.Value = p.MaPhong
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaPhim"
        para.Value = p.MaPhim
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaRap"
        para.Value = p.MaRap
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@SuatChieu"
        para.Value = p.SuatChieu
        para.DbType = DbType.DateTime
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@NgayChieu"
        para.Value = p.NgayChieu
        para.DbType = DbType.Date
        cmd.Parameters.Add(para)

        Dim result As Integer = -1
        Try
            result = GenericDataAccess.ExecuteNoneQuery(cmd)
        Catch ex As Exception

        End Try
        Return result
    End Function

    Public Shared Function Xoa(masuat As Integer) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "DELETE FROM SUATCHIEU WHERE MASUAT = @MaSuat"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaSuat"
        para.Value = masuat
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        Dim result As Integer = -1
        Try
            result = GenericDataAccess.ExecuteNoneQuery(cmd)
        Catch ex As Exception

        End Try
        Return result
    End Function

    Public Shared Function Sua(p As SuatChieu) As Integer
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("TEXT")
        cmd.CommandText = "UPDATE SUATCHIEU SET MAPHONG = @MaPhong,MAPHIM = @MaPhim,MARAP = @MaRap,SUATCHIEU = @SuatChieu,NGAYCHIEU = @NgayChieu WHERE MASUAT = @MaSuat"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaPhong"
        para.Value = p.MaPhong
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaPhim"
        para.Value = p.MaPhim
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)
        para = cmd.CreateParameter()
        para.ParameterName = "@MaRap"
        para.Value = p.MaRap
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@SuatChieu"
        para.Value = p.SuatChieu
        para.DbType = DbType.DateTime
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@NgayChieu"
        para.Value = p.NgayChieu
        para.DbType = DbType.Date
        cmd.Parameters.Add(para)

        para = cmd.CreateParameter()
        para.ParameterName = "@MaSuat"
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

    Shared Function Get_DS_By_Ma_Phim(maPhim As Integer) As DataTable
        Dim cmd As DbCommand = GenericDataAccess.CreateCommand("text")
        cmd.CommandText = "SELECT * from SuatChieu join RapPhim on SuatChieu.MaRap = RapPhim.MaRap join PhongChieu on SuatChieu.MaPhong = PhongChieu.MaPhong join LoaiPhongChieu on PhongChieu.MaLoaiPhong = LoaiPhongChieu.MaLoaiPhong where SuatChieu.MaPhim = @MaPhim"
        Dim para As DbParameter = cmd.CreateParameter()
        para.ParameterName = "@MaPhim"
        para.Value = maPhim
        para.DbType = DbType.Int32
        cmd.Parameters.Add(para)

        Return GenericDataAccess.ExecuteSelectCommand(cmd)
    End Function

End Class
