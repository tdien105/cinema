Imports DAO
Imports BUS
Public Class frmGhe
    Public Sub New(ByVal TenPhong As String)
        InitializeComponent()
        cbophong.DataSource = PhongChieuController.GetDanhSach()
        cbophong.ValueMember = "MaPhong"
        cbophong.DisplayMember = "TenPhong"
        cbophong.SelectedIndex = cbophong.FindStringExact(TenPhong)
    End Sub
    Private Function CheckData() As Boolean
        Dim soghe As Integer
        If Not (txtMaHang.Text = "" Or txtSoGhe.Text = "" Or Integer.TryParse(txtSoGhe.Text, soghe) = False) Then
            If soghe > 0 Then
                Return True
            End If
        End If
        Return False

    End Function

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If CheckData() Then
            Dim mangghe As New List(Of CTGhe)
            For i As Integer = 0 To Integer.Parse((txtSoGhe.Text))
                Dim ct As New CTGhe With {.mahang = txtMaHang.Text, .MaGhe = txtMaHang.Text + i.ToString(), .MaPhong = cbophong.SelectedValue}
                mangghe.Add(ct)
            Next
            If ckbVIP.Checked Then
                Dim vip As New CTHangGheVIP With {.MaHang = txtMaHang.Text, .MaPhong = cbophong.SelectedValue}
                If CTHangGheVIPController.Them(vip) = False Then
                    MessageBox.Show("Failed")
                    Return
                End If
            End If
            For Each g In mangghe
                If CTGheController.Them(g) = False Then
                    MessageBox.Show("Failed")
                    Return
                End If
            Next
            MessageBox.Show("Thêm thành công.")
        Else
            MessageBox.Show("Nhập đầy đủ dữ liệu")
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class