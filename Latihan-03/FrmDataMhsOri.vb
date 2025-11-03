Public Class FrmDataMhsOri
    ' Membuat prosedur untuk menonaktifkan objek
    Sub FormMati()
        TxtNik.Enabled = False
        TxtNama.Enabled = False
        CmbJenisKelamin.Enabled = False
        CmbAgama.Enabled = False
        TxtAlamat.Enabled = False
        CmbJurusan.Enabled = False
        CmbStatusMahasiswa.Enabled = False
    End Sub
    Sub FormHidup()
        ' Membuat Sub Prosedure untuk menghidupkan object
        TxtNik.Enabled = True
        TxtNama.Enabled = True
        CmbJenisKelamin.Enabled = True
        TxtAlamat.Enabled = True
        CmbAgama.Enabled = True
        CmbJurusan.Enabled = True
        CmbStatusMahasiswa.Enabled = True
    End Sub
    Sub Kosongkan()
        ' Membuat Sub Prosedure untuk mengosongkan object
        TxtNik.Clear()
        TxtNama.Clear()
        CmbJenisKelamin.Items.Clear()
        CmbAgama.Items.Clear()
        TxtAlamat.Clear()
        CmbJurusan.Items.Clear()
        CmbStatusMahasiswa.Items.Clear()
        LbHasil.Text = ""
    End Sub
    Sub FormNormal()
        ' Membuat Sub Prosedure untuk nampilkan Form Normal pada Object
        Kosongkan()
        FormMati()
        BtnHapus.Enabled = False
        BtnHapus.Text = "&HAPUS"
        BtnTampilkan.Text = "&TAMPILKAN"
        BtnTampilkan.Enabled = False
        BtnKeluar.Text = "&KELUAR"
    End Sub
    Private Sub FrmDataMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form Load
        Call FormMati()
        BtnTampilkan.Enabled = False
        BtnHapus.Enabled = False
    End Sub

    Private Sub BtnTampilkan_Click(sender As Object, e As EventArgs) Handles BtnTampilkan.Click
        ' Menampilkan ke dalam MessageBox
        MessageBox.Show(TxtNik.Text & vbCrLf &
                        TxtNama.Text & vbCrLf &
                        CmbJenisKelamin.Text & vbCrLf &
                        TxtAlamat.Text & vbCrLf &
                        CmbJurusan.Text & vbCrLf &
                        CmbStatusMahasiswa.Text, "Hasil Pengisian", MessageBoxButtons.OK,
                                                 MessageBoxIcon.Information)
        ' Memasukkan hasil ke dalam Label
        LbHasil.Text = "NIK                 : " + TxtNik.Text & vbCrLf &
                       "Nama Anda        : " + TxtNama.Text & vbCrLf &
                       "Jenis Kelamin   : " + CmbJenisKelamin.Text & vbCrLf &
                       "Agama           : " + CmbAgama.Text & vbCrLf &
                       "Alamat          : " + TxtAlamat.Text & vbCrLf &
                       "Jurusan         : " + CmbJurusan.Text & vbCrLf &
                       "Status          : " + CmbStatusMahasiswa.Text
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        ' Menggunakan Fungsi IF
        If BtnKeluar.Text = "&KELUAR" Then
            End
        Else
            FormNormal()
            BtnTambah.Enabled = True
        End If
    End Sub
    Sub Agama()
        ' Membuat Sub Prosedure untuk menambahkan item ke dalam obnject ComboBox
        CmbAgama.Items.Add("ISLAM")
        CmbAgama.Items.Add("KRISTEN")
        CmbAgama.Items.Add("HINDU")
        CmbAgama.Items.Add("BUDDHA")
        CmbAgama.Items.Add("KONGHUCU")
    End Sub
    Sub StatusMahasiswa()
        ' Membuat Sub Prosedure untuk menambahkan item ke dalam object ComboBox
        CmbStatusMahasiswa.Items.Add("AKTIF")
        CmbStatusMahasiswa.Items.Add("NON-AKTIF")
        CmbStatusMahasiswa.Items.Add("CUTI AKADEMIK")
        CmbStatusMahasiswa.Items.Add("DROP-OUT")
    End Sub
    Sub JenisKelamin()
        CmbJenisKelamin.Items.Add("LAKI-LAKI")
        CmbJenisKelamin.Items.Add("PEREMPUAN")
    End Sub
    Sub Jurusan()
        ' Membuat Sub Prosedure untu menambahkan item ke dalam object ComboBox
        CmbJurusan.Items.Add("Teknologi Rekayasa Perangkat Lunak")
        CmbJurusan.Items.Add("Teknologi Rekayasa Manufaktur")
        CmbJurusan.Items.Add("Teknologi Rekayasa Mekatronika")
        CmbJurusan.Items.Add("Teknologi Listrik")
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        ' Menggunakan Event Click pada Button Hapus dengan memanggil
        ' Sub Prosedure yang telah di buat sebelumnya
        Call Kosongkan()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        ' Menggunakan Event Click pada Button Hapus dengan memanggil
        ' Sub Prosedure yang telah di buat sebelumnya
        Call FormHidup()
        Call JenisKelamin()
        Call Jurusan()
        Call Agama()
        Call StatusMahasiswa()
        TxtNik.Focus()
        BtnTambah.Enabled = False
        BtnTampilkan.Enabled = True
        BtnTampilkan.Text = "&TAMPILKAN"
        BtnKeluar.Text = "&BATAL"
    End Sub
End Class
