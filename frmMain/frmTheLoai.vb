Imports BUS
Imports DAL
Imports DAO

Public Class frmTheLoai

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim tl As New TheLoai With {.TenTheLoai = txtTenTheLoai.Text}
        If TheLoaiController.Them(tl) Then
            MessageBox.Show("Thêm thể loại thành công.")
            LoadDanhSachTheLoai()
        Else
            MessageBox.Show("Thêm thể loại thất bại.")
        End If

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim tl As TheLoai = Get_TheLoai_Info()
        If TheLoaiController.Xoa(tl.MaTheLoai) Then
            MessageBox.Show("Xoá thể loại thành công.")
            LoadDanhSachTheLoai()
        Else
            MessageBox.Show("Xoá thể loại thất bại.")
        End If
    End Sub

    'fix cho nay
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        Dim tl As TheLoai = Get_TheLoai_Info()
        tl.TenTheLoai = txtTenTheLoai.Text
        If TheLoaiController.CapNhat(tl) Then 'luon false ko hieu tai sao
            MessageBox.Show("Cập nhật thể loại thành công.")
            LoadDanhSachTheLoai()
        Else
            MessageBox.Show("Cập nhật thể loại thất bại.")
        End If
    End Sub

    Private Sub dgvDS_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDS.SelectionChanged
        Dim tl As TheLoai = Get_TheLoai_Info()
        If (Not (IsNothing(tl))) Then txtTenTheLoai.Text = tl.TenTheLoai
    End Sub

    Private Function Get_TheLoai_Info() As TheLoai
        If dgvDS.SelectedRows.Count > 0 Then
            Return New TheLoai With {.MaTheLoai = dgvDS.SelectedRows(0).Cells("MaTheLoai").Value,
                                     .TenTheLoai = dgvDS.SelectedRows(0).Cells("TenTheLoai").Value.ToString()}
        End If
        Return Nothing
    End Function

    Private Sub frmTheLoai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDanhSachTheLoai()
        Clear()
    End Sub

    Private Sub Clear()
        txtTenTheLoai.Text = String.Empty
        dgvDS.ClearSelection()
    End Sub

    Private Sub LoadDanhSachTheLoai()
        dgvDS.AutoGenerateColumns = False
        dgvDS.DataSource = TheLoaiDA.GetDanhSach()

    End Sub

End Class