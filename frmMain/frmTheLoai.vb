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
        For Each e As Control In Me.Controls
            If (e.GetType() Is GetType(TextBox)) Then
                Dim txt = CType(e, TextBox)
                txt.Text = ""
            End If
        Next
        dgvDS.ClearSelection()
    End Sub

    Private Sub LoadDanhSachTheLoai()
        dgvDS.DataSource = Nothing
        'Set AutoGenerateColumns False
        dgvDS.AutoGenerateColumns = False

        'Set Columns Count
        dgvDS.ColumnCount = 2

        'Add Columns
        dgvDS.Columns(0).Name = "MaTheLoai"
        dgvDS.Columns(0).HeaderText = "Mã TL"
        dgvDS.Columns(0).DataPropertyName = "MaTheLoai"

        dgvDS.Columns(1).Name = "TenTheLoai"
        dgvDS.Columns(1).HeaderText = "Tên TL"
        dgvDS.Columns(1).DataPropertyName = "TenTheLoai"

        dgvDS.DataSource = TheLoaiController.GetDanhSach()

        dgvDS.Columns(0).Visible = False

    End Sub

    Private Sub dgvDS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDS.CellClick
        Dim tl As TheLoai = Get_TheLoai_Info()
        If (Not (IsNothing(tl))) Then txtTenTheLoai.Text = tl.TenTheLoai
    End Sub
End Class