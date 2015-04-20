Imports BUS
Imports DAO

Public Class frmQLPhongChieu

    Private Sub frmQLPhongChieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_DS_Rap()
        Load_DS_Phong_Chieu()
        LoadLoaiPhong()
    End Sub

    Private Sub LoadLoaiPhong()
        cboLoaiPhong.DataSource = LoaiPhongChieuController.GetDS()
        cboLoaiPhong.ValueMember = "MaLoaiPhong"
        cboLoaiPhong.DisplayMember = "TenLoaiPhong"
        cboLoaiPhong.SelectedIndex = -1
    End Sub

    Private Sub Load_DS_Rap()
        cboloadrap.DataSource = RapController.GetDS()
        cboloadrap.ValueMember = "MaRap"
        cboloadrap.DisplayMember = "TenRap"
        cboloadrap.SelectedIndex = 1

        cboRap.DataSource = RapController.GetDS()
        cboRap.ValueMember = "MaRap"
        cboRap.DisplayMember = "TenRap"
        cboRap.SelectedIndex = -1
    End Sub

    Private Sub Load_DS_Phong_Chieu()
        dgvDSPhongChieu.AutoGenerateColumns = False
        Dim maRap As Integer = cboRap.SelectedValue
        dgvDSPhongChieu.DataSource = PhongChieuController.GetDanhSach_PhongChieu_Va_LoaiPhong_Theo_Rap(maRap)

        dgvDSPhongChieu.ClearSelection()
        FormatDatagridViewRow()
    End Sub

    Private Sub dgvDSPhongChieu_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDSPhongChieu.SelectionChanged
        If (dgvDSPhongChieu.SelectedRows.Count > 0) Then
            cboRap.SelectedValue = dgvDSPhongChieu.SelectedRows(0).Cells("MaRap").Value
            cboLoaiPhong.SelectedValue = dgvDSPhongChieu.SelectedRows(0).Cells("MaLoaiPhong").Value
            txtTenPhong.Text = dgvDSPhongChieu.SelectedRows(0).Cells("TenPhong").Value.ToString()
        End If
    End Sub

    Private Sub FormatDatagridViewRow()
        For Each row As DataGridViewRow In dgvDSPhongChieu.Rows
            If (IsDBNull(row.Cells("TinhTrang").Value) Or Convert.ToInt16(row.Cells("TinhTrang").Value) = 0) Then
                row.DefaultCellStyle.BackColor = Color.Brown
            End If
        Next
    End Sub

    Private Sub btnBaoHu_Click(sender As Object, e As EventArgs) Handles btnBaoHu.Click
        Dim frmChonNgay As New LuaChonNgay
        frmChonNgay.ShowDialog()
        Dim ngay As Date = frmChonNgay.DateTimePicker1.Value.ToShortDateString()
        If (DateDiff(DateInterval.Day, ngay, Now) = 0) Then
            MessageBox.Show("Chọn ngày sai qui định.")
            Return
        End If
        Dim maPhong As Integer = Get_Ma_Phong()
        If (maPhong = 0) Then
            MessageBox.Show("Chọn phòng cần báo hư.")
            Return
        End If
        If (PhongChieuController.SetPhongChieuHu(maPhong, ngay)) Then
            MessageBox.Show("Thành công.")
            Load_DS_Phong_Chieu()
            FormatDatagridViewRow()
        Else
            MessageBox.Show("Thất bại.")
        End If
    End Sub

    Private Function Get_Ma_Phong() As Integer

        If (dgvDSPhongChieu.SelectedRows.Count > 0) Then
            Return dgvDSPhongChieu.SelectedRows(0).Cells("MaPhong").Value
        End If
        Return 0
    End Function

    Private Sub cboloadrap_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboloadrap.SelectedIndexChanged
        Load_DS_Phong_Chieu()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim phongChieu As New PhongChieu With {.MaRap = cboRap.SelectedValue,
                                               .MaLoaiPhong = cboLoaiPhong.SelectedValue,
                                               .TenPhong = txtTenPhong.Text}
        If PhongChieuController.Them(phongChieu) Then
            MessageBox.Show("Sucess!")
            Load_DS_Phong_Chieu()
        Else
            MessageBox.Show("Failed")
        End If

    End Sub

    Private Sub btnThemGhe_Click(sender As Object, e As EventArgs) Handles btnThemGhe.Click
        If (dgvDSPhongChieu.SelectedRows.Count = 0) Then
            MessageBox.Show("Chon phong")
        Else
            Dim TenPhong = dgvDSPhongChieu.SelectedRows(0).Cells("TenPhong").Value
            Dim f As New frmGhe(TenPhong)
            f.Show()
        End If
        
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If (dgvDSPhongChieu.SelectedRows.Count = 0) Then
            MessageBox.Show("Chọn phòng")
        Else
            Dim ma = Get_Ma_Phong()
            If Not PhongChieuController.Xoa(ma) = -1 Then
                MessageBox.Show("Success")
                Load_DS_Phong_Chieu()
            Else
                MessageBox.Show("Failed")
            End If
        End If
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        
        If (dgvDSPhongChieu.SelectedRows.Count = 0) Then
            MessageBox.Show("Chọn phòng")
        Else
            Dim phongChieu As New PhongChieu With {.MaPhong = Get_Ma_Phong(),
                                               .MaRap = cboRap.SelectedValue,
                                               .MaLoaiPhong = cboLoaiPhong.SelectedValue,
                                               .TenPhong = txtTenPhong.Text}
            If Not PhongChieuController.Update(phongChieu) = -1 Then
                MessageBox.Show("Success")
                Load_DS_Phong_Chieu()
            Else
                MessageBox.Show("Failed")
            End If
        End If
    End Sub
End Class