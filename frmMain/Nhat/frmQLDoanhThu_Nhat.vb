Public Class frmQLDoanhThu_Nhat

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmQLDoanhThu_TheoTime__Nhat
        frm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New frmQLDoanhThu_TheoPhongChieu__Nhat
        frm.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New frmQLDoanhThu_TheoPhim__Nhat
        frm.ShowDialog()
    End Sub
End Class