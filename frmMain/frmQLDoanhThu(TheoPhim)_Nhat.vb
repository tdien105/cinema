Imports BUS

Public Class frmQLDoanhThu_TheoPhim__Nhat

    Private Sub frmQLDoanhThu_TheoPhim__Nhat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_DS()
    End Sub

    Private Sub Load_DS()
        dgvDS.AutoGenerateColumns = False

        dgvDS.ColumnCount = 2

        dgvDS.Columns(0).Name = "TenPhim"
        dgvDS.Columns(0).HeaderText = "Tên phim"
        dgvDS.Columns(0).DataPropertyName = "TenPhim"

        dgvDS.Columns(1).Name = "SoTien"
        dgvDS.Columns(1).HeaderText = "Doanh Thu"
        dgvDS.Columns(1).DataPropertyName = "SoTien"

        dgvDS.DataSource = VeController.Lay_DS_DoanhThu()
    End Sub
End Class