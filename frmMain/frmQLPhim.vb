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

        dgvDS.DataSource = PhimController.GetDS()
        dgvDS.Columns(0).HeaderText = "ID"
        dgvDS.Columns(1).HeaderText = "Ngày nhập"
        dgvDS.Columns(2).HeaderText = "Tên phim"
        dgvDS.Columns(3).HeaderText = "Thể loại"
        dgvDS.Columns(4).HeaderText = "Đạo diễn"
        dgvDS.Columns(5).HeaderText = "Thời lượng"
        dgvDS.Columns(6).HeaderText = "Độ tuổi"
        dgvDS.Columns(7).HeaderText = "Tóm tắt"
        dgvDS.Columns(8).HeaderText = "Nhà PH"
        dgvDS.Columns(9).HeaderText = "Số tiền"
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
        If txtTenPhim.Text = "" Or txtdotuoi.Text = "" Or txtthoiluong.Text = "" Or txtsotien.Text = "" Then Return False
        Return True
    End Function

    Private Sub dgvDS_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDS.SelectionChanged
        Dim phim As Phim = Get_Phim_Info_DGV()
        txtTenPhim.Text = phim.TenPhim
        datengaynhap.DateTime = phim.NgayCongChieu
        cboTheLoai.SelectedValue = phim.MaTheLoai
        cboNPH.SelectedValue = phim.MaNph
        txtdaodien.Text = phim.DaoDien
        txtthoiluong.Text = phim.ThoiLuong
        txtdotuoi.Text = phim.DoTuoi
        txtsotien.Text = dgvDS.SelectedRows(0).Cells("SoTien").Value
    End Sub

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

            If PhimController.Them(P) = False Then
                MessageBox.Show("Lỗi thêm dữ liệu")
            End If
            MessageBox.Show("Success!")
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If (isSelected()) Then
            Dim maPhim As Integer = dgvDS.SelectedRows(0).Cells("MaPhim").Value
            If (PhimController.Xoa(maPhim)) Then
                MessageBox.Show("Xóa thành công.")
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

    Private Function Get_Phim_Info_DGV() As Phim
        Dim phim As New Phim With {.DaoDien = dgvDS.SelectedRows(0).Cells("DaoDien").Value.ToString,
                                  .DoTuoi = dgvDS.SelectedRows(0).Cells("DoTuoi").Value,
                                  .HinhAnh = dgvDS.SelectedRows(0).Cells("HinhAnh").Value.ToString,
                                  .MaNph = dgvDS.SelectedRows(0).Cells("MaNph").Value,
                                  .MaPhim = dgvDS.SelectedRows(0).Cells("MaPhim").Value,
                                  .MaTheLoai = dgvDS.SelectedRows(0).Cells("MaTheLoai").Value,
                                   .NgayCongChieu = DateTime.Parse(dgvDS.SelectedRows(0).Cells("NgayCongChieu").Value),
                                   .TenPhim = dgvDS.SelectedRows(0).Cells("TenPhim").Value.ToString,
                                   .ThoiLuong = dgvDS.SelectedRows(0).Cells("ThoiLuong").Value,
                                   .ThongTinPhim = dgvDS.SelectedRows(0).Cells("ThongTinPhim").Value.ToString,
                                   .Trailer = dgvDS.SelectedRows(0).Cells("Trailer").Value.ToString}
        Return phim
    End Function
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        Dim phim As Phim = Get_Phim_Info_DGV()

        If (PhimController.Sua(phim)) Then
            MessageBox.Show("Cập nhật thành công.")
        Else
            MessageBox.Show("Cập nhật thất bại.")
        End If

    End Sub

    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
        txtTenPhim.Text = ""

    End Sub
End Class
