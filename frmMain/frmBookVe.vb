Imports BUS
Imports DAL
Imports DAO

Public Class frmBookVe

    Private Sub frmBookVe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()

    End Sub
    Private Sub LoadData()
        cborap.DataSource = RapController.GetDS()
        cborap.DisplayMember = "TenRap"
        cborap.ValueMember = "MaRap"

        dchonngay.DateTime = Today

        cbochonphong.DataSource = LoaiPhongChieuController.GetDS()
        cbochonphong.DisplayMember = "TenLoaiPhong"
        cbochonphong.ValueMember = "TenLoaiPhong"

        cbophim.DataSource = PhimController.GetDS()
        cbophim.DisplayMember = "TenPhim"
        cbophim.ValueMember = "MaPhim"

        cbosuatchieu.DataSource = SuatChieuController.GetDS()
        cbosuatchieu.DisplayMember = "SC"
        cbosuatchieu.ValueMember = "SuatChieu"



    End Sub
    Private Sub btnhienthi_Click(sender As Object, e As EventArgs) Handles btnhienthi.Click
        btnbook.Enabled = False
        GlobalVars.VeChon = 0
        GlobalVars.ListGhe.Clear()
        GlobalVars.SoVe = Integer.Parse(txtsove.Value)
        If GlobalVars.SoVe < 1 Then
            MessageBox.Show("Vui long chon it nhat 1 ve")
            Return
        End If
        LoadGhe()
    End Sub

    Private Sub LoadGhe()
        pnMain.Controls.Clear()
        Dim SC As New SuatChieu()
        Dim loaiphong = cbochonphong.SelectedValue
        SC.MaPhim = cbophim.SelectedValue
        SC.MaRap = cborap.SelectedValue
        SC.NgayChieu = dchonngay.DateTime
        SC.SuatChieu = DateTime.Parse(cbosuatchieu.SelectedValue.ToString())
        GlobalVars.sc = SuatChieuController.IsExist(SC, loaiphong)
        Dim DaChon = VeController.GetDS(GlobalVars.sc.MaSuat)
        If GlobalVars.sc.MaSuat >= 1 Then
            Dim HangGhe = CTGheController.GetHangGhe(GlobalVars.sc.MaPhong)
            'MessageBox.Show(HangGhe.Rows.Count)
            For Each row As DataRow In HangGhe.Rows
                Dim maghe = CTGheController.GetMaGhe(GlobalVars.sc.MaPhong, row("MaHang").ToString())
                For Each ghe As DataRow In maghe.Rows
                    Dim btn As New Button
                    btn.Name = ghe("maghe")
                    btn.Text = ghe("maghe")
                    For Each g As DataRow In DaChon.Rows
                        If btn.Text = g("maghe") Then
                            btn.Enabled = False
                        End If
                    Next
                    AddHandler btn.Click, AddressOf Me.Button_Click   ' Again from answer by Reed.
                    pnMain.Controls.Add(btn)
                Next
            Next
        Else
            MessageBox.Show("Chua co suat chieu, vui long chon lai!")
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        Dim b As Button = DirectCast(sender, Button)
        If b.BackColor = Color.Black Then
            b.BackColor = Color.White
        Else
            b.BackColor = Color.Black
        End If
        If GlobalVars.ListGhe.Contains(b.Text) Then
            GlobalVars.ListGhe.Remove(b.Text)
            GlobalVars.VeChon -= 1
        Else
            GlobalVars.ListGhe.Add(b.Text)
            GlobalVars.VeChon += 1
        End If
        If (GlobalVars.VeChon = GlobalVars.SoVe) Then
            btnbook.Enabled = True
        Else
            btnbook.Enabled = False
        End If
    End Sub

    Private Sub btnbook_Click(sender As Object, e As EventArgs) Handles btnbook.Click
        If GlobalVars.ListGhe.Count() > 0 Then
            Dim TongTien As Double = 0
            For Each ghe As String In GlobalVars.ListGhe
                '----------TINH GIA TIEN
                Dim dieukien = GlobalVars.CheckTime(GlobalVars.sc.SuatChieu.ToString("hh:mm:ss"))
                Dim VIP = CTHangGheVIPController.CheckVIP(GlobalVars.sc.MaPhong, ghe)
                Dim LoaiPhong = SuatChieuController.GetMaLoaiPhong(GlobalVars.sc.MaSuat)
                Dim GiaTien = GiaVeController.GetGia(LoaiPhong, dieukien)
                '----------END TINH GIA TIEN
                Dim v As New Ve
                v.MaSuat = GlobalVars.sc.MaSuat
                v.MaGhe = ghe
                If VIP = True Then
                    GiaTien = GiaTien + GiaTien * 0.05
                End If
                v.GiaTien = GiaTien
                v.Ngay = Date.Now
                TongTien += GiaTien
                VeController.Them(v)
            Next
            GlobalVars.ListGhe.Clear()
            MessageBox.Show("Success! Tong tien ve cua ban la: " + TongTien.ToString())
            LoadGhe()
        Else
            MessageBox.Show("Vui long chon ghe")
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        LoadGhe()
        GlobalVars.VeChon = 0
        GlobalVars.ListGhe.Clear()
        btnbook.Enabled = False
    End Sub
End Class