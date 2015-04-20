Imports BUS
Imports DAO

Public Class frmThemGhe
    Public Sub New(ByVal maphong As Integer)
        cbophong.DataSource = PhongChieuController.GetDanhSach()
        cbophong.ValueMember = "MaPhong"
        cbophong.DisplayMember = "TenPhong"
        cbophong.SelectedItem = maphong

        Dim mangghe As New List(Of CTGhe)
        For i As Integer = 0 To Integer.Parse((txtSoGhe.Text))
            Dim ct As New CTGhe With {.mahang = txtMaHang.Text, .MaGhe = txtMaHang.Text + i.ToString(), .MaPhong = cbophong.SelectedValue}
            mangghe.Add(ct)
        Next
        Dim isSucceed = False
        For Each g In mangghe
            If CTGheController.Them(g) Then
                If ckbVIP.Checked Then
                    Dim vip As New CTHangGheVIP With {.MaHang = txtMaHang.Text, .MaPhong = cbophong.SelectedValue}
                    If CTHangGheVIPController.Them(vip) Then
                        isSucceed = True
                    End If
                End If
            Else
                Return
            End If
        Next
        If isSucceed Then
            MessageBox.Show("Thêm thành công.")
            Return
        End If
        MessageBox.Show("Failed")
    End Sub
End Class