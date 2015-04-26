Imports BUS

Public Class frmQLDoanhThu_TheoTime__Nhat
    Private Sub frmQLDoanhThu_TheoTime__Nhat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_DS_Theo_Ngay()
    End Sub

    Private Sub Load_DS_Theo_Ngay()
        Populate_DGV()
        dgvDS.DataSource = VeController.Lay_DS_DoanhThu_Theo_Ngay()
    End Sub

    Private Sub Populate_DGV()

        dgvDS.AutoGenerateColumns = False

        dgvDS.ColumnCount = 2

        dgvDS.Columns(0).Name = "Ngay"
        dgvDS.Columns(0).HeaderText = "Ngày-Tháng-Năm"
        dgvDS.Columns(0).DataPropertyName = "Ngay"

        dgvDS.Columns(0).Name = "DoanhThu"
        dgvDS.Columns(0).HeaderText = "Doanh Thu"
        dgvDS.Columns(0).DataPropertyName = "Tongtien"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Populate_DGV()
        Dim dtpFrom As Date = dtpFrom.ToShortDateString()
        Dim dtpTo As Date = dtpTo.ToShortDateString()
        dgvDS.DataSource = VeController.Lay_DS_DoanhThu_Between_Ngay(dtpFrom, dtpTo)
    End Sub
End Class