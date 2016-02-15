
Public Class mainmenu
    Public Sub Logout_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logout.Click
        DisconnectDatabase()
        Dim RE = New MainWindow()
        RE.Show()
        namauser.Content = ""
        Me.Close()
    End Sub
End Class
