Imports BUS
Imports DAO
Imports System.IO

Public Class frmQLPhim

    Private Sub frmQLPhim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        cboTheLoai.DataSource = TheLoaiController.GetDanhSach()
        cboTheLoai.ValueMember = "MaTheLoai"
        cboTheLoai.DisplayMember = "TenTheLoai"
        cboTheLoai.SelectedIndex = -1

        cboNPH.DataSource = NPHController.GetDanhSach()
        cboNPH.ValueMember = "MaNPH"
        cboNPH.DisplayMember = "TenNPH"
        cboNPH.SelectedIndex = -1

        dgvDS.DataSource = Nothing
        'Set AutoGenerateColumns False
        dgvDS.AutoGenerateColumns = False

        'Set Columns Count
        dgvDS.ColumnCount = 16

        'Add Columns
        dgvDS.Columns(0).Name = "MaPhim"
        dgvDS.Columns(0).HeaderText = "Mã phim"
        dgvDS.Columns(0).DataPropertyName = "MaPhim"

        dgvDS.Columns(1).Name = "NgayNhap"
        dgvDS.Columns(1).HeaderText = "Ngày Nhập"
        dgvDS.Columns(1).DataPropertyName = "NgayNhap"

        dgvDS.Columns(2).Name = "TenPhim"
        dgvDS.Columns(2).HeaderText = "Tên phim"
        dgvDS.Columns(2).DataPropertyName = "TenPhim"

        dgvDS.Columns(3).Name = "TenTheLoai"
        dgvDS.Columns(3).HeaderText = "Tên thể loại"
        dgvDS.Columns(3).DataPropertyName = "TenTheLoai"

        dgvDS.Columns(4).Name = "DaoDien"
        dgvDS.Columns(4).HeaderText = "Đạo diễn"
        dgvDS.Columns(4).DataPropertyName = "DaoDien"

        dgvDS.Columns(5).Name = "ThoiLuong"
        dgvDS.Columns(5).HeaderText = "Thời lượng"
        dgvDS.Columns(5).DataPropertyName = "ThoiLuong"

        dgvDS.Columns(6).Name = "DoTuoi"
        dgvDS.Columns(6).HeaderText = "Độ tuổi"
        dgvDS.Columns(6).DataPropertyName = "DoTuoi"

        dgvDS.Columns(7).Name = "ThongTinPhim"
        dgvDS.Columns(7).HeaderText = "Tóm tắt"
        dgvDS.Columns(7).DataPropertyName = "ThongTinPhim"

        dgvDS.Columns(8).Name = "TenNPH"
        dgvDS.Columns(8).HeaderText = "Nhà PH"
        dgvDS.Columns(8).DataPropertyName = "TenNPH"


        dgvDS.Columns(9).Name = "HinhAnh"
        dgvDS.Columns(9).HeaderText = "Hình Ảnh"
        dgvDS.Columns(9).DataPropertyName = "HinhAnh"

        dgvDS.Columns(10).Name = "MaNPH"
        dgvDS.Columns(10).HeaderText = "Mã NPH"
        dgvDS.Columns(10).DataPropertyName = "MaNPH"

        dgvDS.Columns(11).Name = "MaTheLoai"
        dgvDS.Columns(11).DataPropertyName = "MaTheLoai"

        dgvDS.Columns(12).Name = "NgayCongChieu"
        dgvDS.Columns(12).DataPropertyName = "NgayCongChieu"

        dgvDS.Columns(13).Name = "Trailer"
        dgvDS.Columns(13).DataPropertyName = "Trailer"

        dgvDS.Columns(14).Name = "SoTien"
        dgvDS.Columns(14).HeaderText = "Số tiền"
        dgvDS.Columns(14).DataPropertyName = "SoTien"

        dgvDS.Columns(15).Name = "MaPhieu"
        dgvDS.Columns(15).DataPropertyName = "MaPhieu"

        'dgvDS.Columns(2).Name = "TenPhim"
        'dgvDS.Columns(2).HeaderText = "Tên phim"
        'dgvDS.Columns(2).DataPropertyName = "TenPhim"

        dgvDS.DataSource = PhimController.GetDS()
        dgvDS.Columns(10).Visible = False
        dgvDS.Columns(11).Visible = False
        dgvDS.Columns(12).Visible = False
        dgvDS.Columns(13).Visible = False
        dgvDS.Columns(9).Visible = False
        dgvDS.Columns(7).Visible = False
        dgvDS.Columns(15).Visible = False

    End Sub

    Private Sub btntrailer_Click(sender As Object, e As EventArgs) Handles btntrailer.Click
        Dim o As New OpenFileDialog()
        If o.ShowDialog = Windows.Forms.DialogResult.OK Then
            o.Filter = "Video file |*.mp4"
            video.URL = o.FileName
            GlobalVars.trailer = o.FileName
        End If
    End Sub

    Private Function GetInfo() As Phim
        Dim P As New Phim With {.TenPhim = txtTenPhim.Text,
                                .MaNph = cboNPH.SelectedValue,
                                .DoTuoi = Integer.Parse(txtdotuoi.Text),
                                .DaoDien = txtdaodien.Text,
                                .HinhAnh = GlobalVars.hinh,
                                .NgayCongChieu = datengaynhap.DateTime,
                                .MaTheLoai = cboTheLoai.SelectedValue,
                                .ThoiLuong = Integer.Parse(txtthoiluong.Text),
                                .ThongTinPhim = txttomtat.Text,
                                .Trailer = GlobalVars.trailer}
        Return P
    End Function

    Private Function CheckData() As Boolean
        If txtTenPhim.Text = "" Or txtdotuoi.Text = "" Or txtthoiluong.Text = "" Or txtsotien.Text = "" Or GlobalVars.trailer = "" Or GlobalVars.hinh = "" Then Return False
            Return True
    End Function

    Private Sub btnposter_Click(sender As Object, e As EventArgs) Handles btnposter.Click
        If opd.ShowDialog = Windows.Forms.DialogResult.OK Then
            opd.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg, | *.jpg|Png, | *.png|Bmp, | *.bmp|Gif, | *.gif|Ico | *.ico"
            pic.BackgroundImage = Image.FromFile(opd.FileName)
            pic.BackgroundImageLayout = ImageLayout.Zoom
            GlobalVars.hinh = opd.FileName
        End If
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If CheckData() Then
            Dim P = GetInfo()
            Dim result = PhimController.Them(P)
            If Not result = -1 Then
                Dim PN As New PhieuNhapPhim With {.MaPhim = result,
                                                  .NgayNhap = datengaynhap.DateTime,
                                                  .SoTien = Integer.Parse(txtsotien.Text)}
                If PhieuNhapPhimController.Them(PN) = True Then
                    MessageBox.Show("Success")
                    GlobalVars.trailer = ""
                    GlobalVars.hinh = ""
                    LoadData()
                Else
                    MessageBox.Show("Lỗi ghi dữ liệu!")
                    PhimController.Xoa(result)
                End If
            Else
                MessageBox.Show("Lỗi ghi dữ liệu!")
            End If
        Else
            MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!")
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If (isSelected()) Then
            Dim maPhim = dgvDS.SelectedRows(0).Cells("MaPhim").Value
            Dim maphieu = dgvDS.SelectedRows(0).Cells("MaPhieu").Value
            If PhieuNhapPhimController.Xoa(maphieu) Then
                If (PhimController.Xoa(maPhim)) Then
                    MessageBox.Show("Xóa thành công.")
                    LoadData()
                End If
            Else
                MessageBox.Show("Xóa thất bại.")
            End If
        End If
    End Sub

    Private Function isSelected() As Boolean
        If (dgvDS.SelectedRows.Count > 0) Then
            Return True
        End If
        Return False
    End Function
    'P.MaPhim, PN.NgayNhap,P.TenPhim,TL.TenTheLoai,P.DaoDien,P.ThoiLuong,P.DoTuoi,P.ThongTinPhim,NPH.TenNPH,SoTien,P.HinhAnh
    Private Function Get_Phim_Info_DGV() As Phim
        Dim phim As New Phim With {.DaoDien = dgvDS.SelectedRows(0).Cells("DaoDien").Value.ToString(),
                                  .DoTuoi = dgvDS.SelectedRows(0).Cells("DoTuoi").Value,
                                  .HinhAnh = dgvDS.SelectedRows(0).Cells("HinhAnh").Value.ToString(),
                                  .MaNph = dgvDS.SelectedRows(0).Cells("MaNph").Value,
                                  .MaPhim = dgvDS.SelectedRows(0).Cells("MaPhim").Value,
                                  .MaTheLoai = dgvDS.SelectedRows(0).Cells("MaTheLoai").Value,
                                   .NgayCongChieu = DateTime.Parse(dgvDS.SelectedRows(0).Cells("NgayCongChieu").Value),
                                   .TenPhim = dgvDS.SelectedRows(0).Cells("TenPhim").Value.ToString(),
                                   .ThoiLuong = dgvDS.SelectedRows(0).Cells("ThoiLuong").Value,
                                   .ThongTinPhim = dgvDS.SelectedRows(0).Cells("ThongTinPhim").Value.ToString(),
                                   .Trailer = dgvDS.SelectedRows(0).Cells("Trailer").Value.ToString()}
        Return phim
    End Function

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        If CheckData() Then
            Dim phim As Phim = Get_Phim_Info_DGV()
            Dim result = PhimController.Sua(phim)
            If PhimController.Sua(phim) Then
                Dim PN As New PhieuNhapPhim With {.MaPhim = phim.MaPhim,
                                                  .NgayNhap = datengaynhap.DateTime,
                                                  .SoTien = Integer.Parse(txtsotien.Text),
                                                  .MaPhieu = dgvDS.SelectedRows(0).Cells("MaPhieu").Value}
                If PhieuNhapPhimController.Sua(PN) Then
                    MessageBox.Show("Success")
                    GlobalVars.trailer = ""
                    GlobalVars.hinh = ""
                    LoadData()
                Else
                    MessageBox.Show("Lỗi ghi dữ liệu!")
                End If
            Else
                MessageBox.Show("Lỗi ghi dữ liệu!")
            End If
        End If
    End Sub

    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
        txtTenPhim.Text = ""
        txtdotuoi.Text = ""
        txtdaodien.Text = ""
        pic.ImageLocation = ""
        datengaynhap.DateTime = Today
        txtthoiluong.Text = ""
        txttomtat.Text = ""
        video.URL = ""
        GlobalVars.trailer = ""
        GlobalVars.hinh = ""
        txtsotien.Text = ""
    End Sub

    Private Sub frmQLPhim_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        GlobalVars.trailer = ""
        GlobalVars.hinh = ""
    End Sub

    Private Sub dgvDS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDS.CellClick
        Dim phim As Phim = Get_Phim_Info_DGV()
        txtTenPhim.Text = phim.TenPhim
        datengaynhap.DateTime = phim.NgayCongChieu
        cboTheLoai.SelectedValue = phim.MaTheLoai
        cboNPH.SelectedValue = phim.MaNph
        txtdaodien.Text = phim.DaoDien
        txtthoiluong.Text = phim.ThoiLuong
        txtdotuoi.Text = phim.DoTuoi
        txtsotien.Text = dgvDS.SelectedRows(0).Cells("SoTien").Value
        txttomtat.Text = phim.ThongTinPhim

        pic.ImageLocation = phim.HinhAnh
        video.URL = phim.Trailer
    End Sub
End Class
