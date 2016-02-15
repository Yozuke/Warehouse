Imports System.Data
Imports MySql.Data.MySqlClient

Module Connection
    Public conn As New MySqlConnection
    Public Sub ConnectDatabase()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "server=192.168.1.164;userid=root;password=mmmaos123;database=warehouse"
                conn.Open()
            End If
        Catch myerror As Exception
            MsgBox("Connection Error")
            End
        End Try
    End Sub
    Public Sub DisconnectDatabase()
        Try
            conn.Close()
        Catch myerror As MySql.Data.MySqlClient.MySqlException
        End Try
    End Sub

End Module
