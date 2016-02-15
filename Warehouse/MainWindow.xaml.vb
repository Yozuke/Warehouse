Imports MySql.Data.MySqlClient

Class MainWindow

    Public Sub Submit_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        If userName.Text = "" Then
            MsgBox("Mohon diisi untuk username")
        ElseIf passwordBox.Password = "" Then
            MsgBox("Mohon diisi untuk password")
        Else
            Dim admin As New MySqlCommand
            Dim dr1 As MySqlDataReader
            Dim loginmasuk As String
            ConnectDatabase()
            admin.Connection = conn
            admin.CommandText = "Select * from login where id = '" & userName.Text & "' and pass = SHA('" & passwordBox.Password & "')"
            dr1 = admin.ExecuteReader
            If dr1.HasRows Then
                dr1.Read()
                loginmasuk = dr1(1).ToString
                Select Case dr1(3).ToString()
                    Case Is = "1"
                        Dim newway = New mainmenu()
                        newway.Show()
                        newway.namauser.Content = loginmasuk
                        Me.Close()
                End Select
            Else
                MsgBox("ID / Password anda tidak terdapat di database")
                DisconnectDatabase()
            End If


        End If
    End Sub

End Class
