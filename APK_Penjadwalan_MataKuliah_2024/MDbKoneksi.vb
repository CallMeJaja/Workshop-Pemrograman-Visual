Imports MySql.Data.MySqlClient

Module MDbKoneksi
    Public DBKoneksi As MySqlConnection
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public CMD As MySqlCommand
    Public DR As MySqlDataReader
    Public Hitung As Integer = 0
    Public Hasil As String
    Public Kode_Jurusan As String
    Public Kode_Semester As String
    Public Nomor As Integer
    Public isLogin As Boolean = False
    Public Nama As String
    Public Nama_Jurusan As String

    Public DBLokasi As String
    Public Query As String
    Public SQLInsert As String
    Public SQLUpdate As String
    Public SQLDelete As String
    Public Pesan As String
    Public PesanMkl As String
    Public PesanSmtr As String

    Public Sub KoneksiDB()
        Try
            DBLokasi = "Server=localhost;Uid=root;pwd='';Database=db_akademik24"

            DBKoneksi = New MySqlConnection(DBLokasi)
            If DBKoneksi.State = ConnectionState.Closed Then
                DBKoneksi.Open()
            End If
            ' MsgBox("Koneksi Berhasil", vbOKOnly, "Koneksi Berhasil")
        Catch ex As Exception
            MsgBox("Koneksi Gagal!", vbExclamation, "Koneksi Gagal")
        End Try
    End Sub

    Function DisconnectDB()
        DBKoneksi.Clone()
        Return DBKoneksi
    End Function
End Module
