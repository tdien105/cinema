Public Class frmMain 

    Private Sub biDatVe_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles biDatVe.ItemClick
        Dim f = New frmBookVe()
        If (ExistedFrm(f) = True) Then Return
        f.MdiParent = Me
        f.Show()
    End Sub
    Private Function ExistedFrm(ByVal f As Form) As Boolean
        For Each child As Form In MdiChildren
            If (child.Name = f.Name) Then
                child.Activate()
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub biTraCuuVe_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles biTraCuuVe.ItemClick
        Dim f = New frmTraCuuVe()
        If (ExistedFrm(f) = True) Then Return
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub bi_Them_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bi_Them.ItemClick
        Dim f = New frmQLPhim()
        If (ExistedFrm(f) = True) Then Return
        f.MdiParent = Me
        f.Show()
    End Sub
End Class