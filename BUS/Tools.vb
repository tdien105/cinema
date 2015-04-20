Imports DAO
Public Module GlobalVars
    Public sc As New SuatChieu()
    Public ListGhe As New List(Of String)
    Public SoVe As Integer = 0
    Public VeChon As Integer = 0
    Public hinh As String = ""
    Public trailer As String = ""
    Public Function CheckTime(time As DateTime) As String
        Dim m As DateTime = #12:00:00 PM#
        Dim e As DateTime = #5:00:00 PM#
        Dim r As Integer = DateTime.Compare(time, m)
        Dim rr As Integer = DateTime.Compare(time, e)
        If r < 0 Then
            Return "Morning"
        ElseIf r > 0 And rr < 0 Then
            Return "Afternoon"
        End If
        Return "Evening"
    End Function
End Module

