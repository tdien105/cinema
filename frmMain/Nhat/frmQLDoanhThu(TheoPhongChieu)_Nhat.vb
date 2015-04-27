Imports BUS

Public Class frmQLDoanhThu_TheoPhongChieu__Nhat

    Private Sub frmQLDoanhThu_TheoPhongChieu__Nhat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_DS_TheoPhong()
    End Sub

    Private Sub Load_DS_TheoPhong()
        dgvDS.AutoGenerateColumns = False
        dgvDS.ColumnCount = 2

        dgvDS.Columns(0).Name = "TenPhong"
        dgvDS.Columns(0).HeaderText = "Tên phòng"
        dgvDS.Columns(0).DataPropertyName = "TenPhòng"

        dgvDS.Columns(1).Name = "SoTien"
        dgvDS.Columns(1).HeaderText = "Doanh Thu"
        dgvDS.Columns(1).DataPropertyName = "Tongtien"

        dgvDS.DataSource = VeController.Lay_DS_DoanhThu_Theo_Phong_Chieu()
    End Sub
End Class