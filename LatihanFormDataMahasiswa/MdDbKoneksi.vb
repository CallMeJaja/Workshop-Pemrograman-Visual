Imports MySql.Data.MySqlClient

Module MdDbKoneksi
    Public DBKoneksi As MySqlConnection
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public CMD As MySqlCommand
    Public DR As MySqlDataReader
    Public Hitung As Integer = 1
    Public Kode_Jurusan As String
    Public Kode_Semester As String

    Public Nomor As Integer

    ' Membuat Variable SQL dan Lokasi Database
    Public LokasiDatabase As String
    Public SQLInsert As String
    Public SQLUpdate As String
    Public SQLDelete As String
    Public Pesan As String
    Public PesanMkl As String
    Public PesanSmtr As String

    ' Membuat Prosedur Publik untuk koneksi Database
    Public Sub KoneksiDB()
        Try
            ' Lokasi Database
            LokasiDatabase = "Server=localhost;Uid=root;pwd='';Database=db_akademik24"
            DBKoneksi = New MySqlConnection(LokasiDatabase)

            If DBKoneksi.State = ConnectionState.Closed Then
                DBKoneksi.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi Gagal!", vbExclamation, "Koneksi Gagal")
        End Try
    End Sub

    Function DisconnectDB()
        DBKoneksi.Close()
        Return DBKoneksi
    End Function
End Module
