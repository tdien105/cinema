Imports System.Data.Common
Imports System.Data.SqlClient

Module GenericDataAccess
    Public Function CreateCommand(ByVal type As String) As DbCommand
        Dim providerName As String = CinemaConfiguration.ProviderName
        Dim connectionString As String = CinemaConfiguration.ChuoiKetNoi
        Dim factory As DbProviderFactory = DbProviderFactories.GetFactory(providerName)
        Dim conn As DbConnection = factory.CreateConnection()
        conn.ConnectionString = connectionString
        Dim cmd As DbCommand = conn.CreateCommand()
        If (type = "stored") Then
            cmd.CommandType = CommandType.StoredProcedure
        Else
            cmd.CommandType = CommandType.Text
        End If
        Return cmd
    End Function
    Public Function ExecuteNoneQuery(cmd As DbCommand) As Integer
        Dim effectedRows As Integer = -1
        Try
            cmd.Connection.Open()
            effectedRows = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw
        Finally
            cmd.Connection.Close()
        End Try
        Return effectedRows
    End Function

    Public Function ExecuteScalar(cmd As DbCommand) As Object
        Dim ob As Object
        Try
            cmd.Connection.Open()
            ob = cmd.ExecuteScalar()
        Catch ex As Exception
            Throw
        Finally
            cmd.Connection.Close()
        End Try
        Return ob
    End Function

    Public Function ExecuteSelectCommand(cmd As DbCommand) As DataTable
        Dim dt As DataTable
        Try
            cmd.Connection.Open()
            Dim dr As DbDataReader = cmd.ExecuteReader()
            dt = New DataTable()
            dt.Load(dr)
            dr.Close()
        Catch ex As Exception
            Throw
        Finally
            cmd.Connection.Close()
        End Try
        Return dt
    End Function
End Module
