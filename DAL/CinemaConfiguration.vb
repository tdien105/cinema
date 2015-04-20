Imports System.Configuration

Module CinemaConfiguration
    Private dbConnectionString As String
    Private dbProviderName As String

    Sub New()
        dbConnectionString = ConfigurationManager.ConnectionStrings("CinemaConnectionString").ConnectionString
        dbProviderName = ConfigurationManager.ConnectionStrings("CinemaConnectionString").ProviderName
    End Sub

    Public ReadOnly Property ChuoiKetNoi() As String
        Get
            Return dbConnectionString
        End Get
    End Property

    Public ReadOnly Property ProviderName() As String
        Get
            Return dbProviderName
        End Get
    End Property
End Module
