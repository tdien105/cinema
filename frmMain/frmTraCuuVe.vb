Imports BUS
Imports DAO
Public Class frmTraCuuVe

    Private Sub frmTraCuuVe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dchonngay.DateTime = Today
        LoadData()
    End Sub
    Private Sub LoadData()
        dgvdanhsach.DataSource = VeController.GetAll()
        dgvdanhsach.Columns(0).HeaderText = "Mã vé"
        dgvdanhsach.Columns(1).HeaderText = "Suất chiếu"
        dgvdanhsach.Columns(2).HeaderText = "Tên phòng"
        dgvdanhsach.Columns(3).HeaderText = "Mã ghế"
        dgvdanhsach.Columns(4).HeaderText = "Giá tiền"
        dgvdanhsach.Columns(5).HeaderText = "Ngày"
        dgvdanhsach.Columns(1).DefaultCellStyle.Format = "hh:mm:ss"
        dgvdanhsach.Columns(4).DefaultCellStyle.Format = "c"

        cbosuatchieu.DataSource = SuatChieuController.GetDS()
        cbosuatchieu.DisplayMember = "SC"
        cbosuatchieu.ValueMember = "SuatChieu"

        cbophim.DataSource = PhimController.GetDS()
        cbophim.DisplayMember = "Tenphim"
        cbophim.ValueMember = "Maphim"
    End Sub

    Private Sub btnfillter_Click(sender As Object, e As EventArgs) Handles btnfillter.Click
        dgvdanhsach.DataSource = VeController.Fillter(dchonngay.DateTime, cbosuatchieu.SelectedValue, Integer.Parse(cbophim.SelectedValue))
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        dgvdanhsach.DataSource = VeController.GetAll()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        dgvdanhsach.DataSource = VeController.Search(Integer.Parse(txtmave.Text))
    End Sub
End Class