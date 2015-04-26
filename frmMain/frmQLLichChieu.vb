Imports BUS
Imports DAO

Public Class frmQLLichChieu
    Private Sub frmQLLichChieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDSRap()
        LoadDSPhongChieu()
        LoadDSPhim()
        LoadTieuChi()
    End Sub

    Private Sub LoadTieuChi()
        cboTieuChi.Items.Clear()
        cboTieuChi.Items.Add("------------")
        cboTieuChi.Items.Add("Theo tên")
        cboTieuChi.Items.Add("Theo thể loại")
        cboTieuChi.Items.Add("Theo nhà phát hành")
    End Sub

    Private Sub LoadDSPhim()
        dgvDSPhim.AutoGenerateColumns = False
        dgvDSPhim.DataSource = PhimController.GetDS()
        'dgvDSPhim.ClearSelection()
    End Sub

    Private Sub LoadDSPhongChieu()
        cboPhongChieu.DataSource = PhongChieuController.GetDanhSach()
        cboPhongChieu.ValueMember = "MaPhong"
        cboPhongChieu.DisplayMember = "TenPhong"
        cboPhongChieu.SelectedIndex = -1
    End Sub

    Private Sub LoadDSRap()
        cboRapPhim.DataSource = RapController.GetDS()
        cboRapPhim.DisplayMember = "TenRap"
        cboRapPhim.ValueMember = "Marap"
        cboRapPhim.SelectedIndex = -1
    End Sub



    Private Sub dgvDSPhim_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDSPhim.SelectionChanged
        If GetMaPhim() <> 0 Then
            Dim maPhim As Integer = GetMaPhim()
            Load_DS_SuatChieu_Theo_Ma_Phim(maPhim)
        End If
    End Sub

    Private Function GetMaPhim() As Integer
        If (dgvDSPhim.SelectedRows.Count > 0) Then
            Return dgvDSPhim.SelectedRows(0).Cells("MaPhim").Value
        End If
        Return 0
    End Function

    Private Sub Load_DS_SuatChieu_Theo_Ma_Phim(ByVal maPhim As Integer)
        dgvSuatChieu.AutoGenerateColumns = False
        dgvSuatChieu.DataSource = SuatChieuController.Get_DS_By_Ma_Phim(maPhim)
        'dgvSuatChieu.Columns(0).DefaultCellStyle.Format = "hh:mm:ss"
        dgvSuatChieu.ClearSelection()

    End Sub

    Private Sub txtDSPhimSearch_TextChanged(sender As Object, e As EventArgs) Handles txtDSPhimSearch.TextChanged
        Dim keyWord As String = txtDSPhimSearch.Text
        dgvDSPhim.DataSource = PhimController.SearchResult(keyWord, cboTieuChi.SelectedValue)
    End Sub

    Private Sub dtpFrom_Leave(sender As Object, e As EventArgs) Handles dtpFrom.Leave
        dtp_Leave(dtpFrom)
    End Sub

    Private Sub dtp_Leave(ByRef dtpFrom As DateTimePicker)
        If dtpFrom.Value = Format(Today, "MM/dd/yyyy") & " 12:00:00 AM" Then
            dtpFrom.Format = DateTimePickerFormat.Custom
        End If
    End Sub

    Private Sub dtp_Erase(ByRef dtpFrom As DateTimePicker)
        dtpFrom.Format = DateTimePickerFormat.Custom
    End Sub

    Private Sub dtp_MouseDown(ByRef dtpFrom As DateTimePicker)
        If dtpFrom.Format = DateTimePickerFormat.Custom Then
            dtpFrom.Format = DateTimePickerFormat.Time
            dtpFrom.Value = Format(Today, "MM/dd/yyyy") & " 12:00:00 AM"
        End If
    End Sub
    Private Sub dtpFrom_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpFrom.MouseDown
        dtp_MouseDown(dtpFrom)
    End Sub

    Private Sub dtpFrom_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFrom.KeyDown
        If e.KeyCode = 8 Or e.KeyCode = 46 Then
            dtp_Erase(dtpFrom)
        End If
    End Sub

    Private Sub dgvSuatChieu_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSuatChieu.SelectionChanged
        If (dgvSuatChieu.SelectedRows.Count > 0) Then
            cboRapPhim.SelectedValue = dgvSuatChieu.SelectedRows(0).Cells("MaRap").Value
            cboPhongChieu.SelectedValue = dgvSuatChieu.SelectedRows(0).Cells("MaPhong").Value
            If (Not (IsDBNull(dgvSuatChieu.SelectedRows(0).Cells("NgayChieu").Value))) Then dtpNgayChieu.Value = dgvSuatChieu.SelectedRows(0).Cells("NgayChieu").Value
            If (Not (IsDBNull(dgvSuatChieu.SelectedRows(0).Cells("SuatChieu").Value))) Then dtpFrom.Value = dgvSuatChieu.SelectedRows(0).Cells("SuatChieu").Value

        End If
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim maPhim As Integer = 0
        If (dgvDSPhim.SelectedRows.Count > 0) Then
            maPhim = dgvDSPhim.SelectedRows(0).Cells("MaPhim").Value
            Dim sc As New SuatChieu With {.MaRap = cboRapPhim.SelectedValue,
                                     .MaPhong = cboPhongChieu.SelectedValue,
                                     .MaPhim = maPhim,
                                     .NgayChieu = dtpNgayChieu.Value,
                                     .SuatChieu = dtpFrom.Value}
            If (SuatChieuController.Them(sc)) Then
                MessageBox.Show("Thêm suất chiều thành công.")
                Load_DS_SuatChieu_Theo_Ma_Phim(maPhim)
            Else
                MessageBox.Show("Thêm suất chiều thất bại.")
            End If
        End If
        If maPhim = 0 Then
            MessageBox.Show("Chọn phim cần thêm suất.")
        End If

    End Sub

    Private Function Get_Suat_Chieu() As SuatChieu

        Dim ngayChieu As DateTime
        If (Not (IsDBNull(dgvSuatChieu.SelectedRows(0).Cells("NgayChieu").Value))) Then ngayChieu = dgvSuatChieu.SelectedRows(0).Cells("NgayChieu").Value

        Dim suatBatDau As DateTime
        If (Not (IsDBNull(dgvSuatChieu.SelectedRows(0).Cells("SuatChieu").Value))) Then ngayChieu = dgvSuatChieu.SelectedRows(0).Cells("SuatChieu").Value

        Return New SuatChieu With {.MaPhim = dgvDSPhim.SelectedRows(0).Cells("MaPhim").Value,
            .MaPhong = dgvSuatChieu.SelectedRows(0).Cells("MaPhong").Value,
            .MaRap = dgvSuatChieu.SelectedRows(0).Cells("MaRap").Value,
            .NgayChieu = ngayChieu,
            .SuatChieu = suatBatDau,
            .MaSuat = Get_Ma_Suat()}
    End Function

    Private Function Get_Ma_Suat() As Integer
        If (dgvSuatChieu.SelectedRows.Count > 0) Then Return dgvSuatChieu.SelectedRows(0).Cells("MaSuat").Value
        Return 0
    End Function

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim maSuat As Integer = Get_Ma_Suat()
        If maSuat <> 0 Then
            If (SuatChieuController.Xoa(maSuat)) Then
                MessageBox.Show("Xoá thành công.")
                Load_DS_SuatChieu_Theo_Ma_Phim(GetMaPhim())
            Else
                MessageBox.Show("Xoá thất bại.")
            End If
        Else
            MessageBox.Show("Chọn suất cần xoá.")
        End If
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        Dim sc As SuatChieu = Get_Suat_Chieu()
        If (SuatChieuController.CapNhat(sc)) Then
            MessageBox.Show("Cập nhật thành công.")
        Else
            MessageBox.Show("Cập nhật thất bai.")
        End If
    End Sub
End Class