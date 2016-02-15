Imports MySql.Data.MySqlClient
Imports System.Data
Public Class DataGudang
    Private Sub btn_search_keluar(sender As Object, e As RoutedEventArgs) Handles search_klr.Click


        If search_filter.SelectedItem = "Kode Barang" Then
            Dim da As New MySqlDataAdapter("select * from data_gudang_klr where kode_barang like '%" & search_box.Text & "%'", conn)
            Dim dt = New DataTable()
            da.Fill(dt)
            dataGrid.ItemsSource = dt.DefaultView
        End If

    End Sub
End Class
