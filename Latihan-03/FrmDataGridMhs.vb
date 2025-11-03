Public Class FrmDataGridMhs
    Sub Buat_DataGridMahasiswa()
        With DataGridMahasiswa.EnableHeadersVisualStyles = False
            Try
                DataGridMahasiswa.Font = New Font(DataGridMahasiswa.Font, FontStyle.Bold)
                DataGridMahasiswa.DefaultCellStyle.Font = New Font("Arial", 10)
                DataGridMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                DataGridMahasiswa.ColumnHeadersHeight = 35

                ' Memberikan nama pada pada header nim
                DataGridMahasiswa.Columns(0).Width = 80
                DataGridMahasiswa.Columns(0).HeaderText = "NIM"
                DataGridMahasiswa.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                ' Memberikan nama pada pada header nama mhs
                DataGridMahasiswa.Columns(1).Width = 150
                DataGridMahasiswa.Columns(1).HeaderText = "NAMA MAHASISWA"
                DataGridMahasiswa.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                ' Memberikan nama pada pada header nim
                DataGridMahasiswa.Columns(2).Width = 90
                DataGridMahasiswa.Columns(2).HeaderText = "JENIS KELAMIN"
                DataGridMahasiswa.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                ' Memberikan nama pada pada header nim
                DataGridMahasiswa.Columns(3).Width = 80
                DataGridMahasiswa.Columns(3).HeaderText = "AGAMA"
                DataGridMahasiswa.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                ' Memberikan nama pada pada header nim
                DataGridMahasiswa.Columns(4).Width = 80
                DataGridMahasiswa.Columns(4).HeaderText = "ALAMAT"
                DataGridMahasiswa.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter


                ' Memberikan nama pada pada header nim
                DataGridMahasiswa.Columns(5).Width = 90
                DataGridMahasiswa.Columns(5).HeaderText = "JURUSAN"
                DataGridMahasiswa.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                ' Memberikan nama pada pada header nim
                DataGridMahasiswa.Columns(6).Width = 120
                DataGridMahasiswa.Columns(6).HeaderText = "STATUS MAHASISWA"
                DataGridMahasiswa.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            Catch ex As Exception

            End Try

        End With
    End Sub
    ' Membuat prosedur untuk menonaktifkan objek
    Sub FormMati()
        TxtNik.Enabled = False
        TxtNama.Enabled = False
        CmbJenisKelamin.Enabled = False
        CmbAgama.Enabled = False
        TxtAlamat.Enabled = False
        CmbJurusan.Enabled = False
        CmbStatusMahasiswa.Enabled = False
        BtnTambah.Focus()
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
        'LbHasil.Text = ""
    End Sub
    Sub FormNormal()
        ' Membuat Sub Prosedure untuk nampilkan Form Normal pada Object
        Kosongkan()
        FormMati()
        BtnHapus.Enabled = False
        BtnHapus.Text = "&HAPUS"
        BtnSimpan.Text = "&SIMPAN"
        BtnSimpan.Enabled = False
        BtnKeluar.Text = "&KELUAR"

    End Sub
    Private Sub FrmDataMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form Load
        Call Buat_DataGridMahasiswa()
        Call FormMati()
        BtnSimpan.Enabled = False
        BtnHapus.Enabled = False
        BtnTambah.Focus()
    End Sub
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TxtNik.Text = "" And TxtNama.Text = "" And CmbJenisKelamin.Text = "" And CmbAgama.Text = "" And TxtAlamat.Text = "" And CmbJurusan.Text = "" And CmbStatusMahasiswa.Text = "" Then
            MsgBox("Lengkapi Data terlebih dahulu")
            TxtNama.Focus()
        Else
            With DataGridMahasiswa
                .Rows.Insert(.NewRowIndex, TxtNik.Text, TxtNama.Text, CmbJenisKelamin.Text, CmbAgama.Text, TxtAlamat.Text, CmbJurusan.Text, CmbStatusMahasiswa.Text)
            End With
            TxtNik.Clear()
            TxtNama.Focus()
            TxtNama.Clear()
            TxtAlamat.Clear()
            CmbJenisKelamin.SelectedItem = ""

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
        If DataGridMahasiswa.CurrentRow.Index <> DataGridMahasiswa.NewRowIndex Then DataGridMahasiswa.Rows.RemoveAt(DataGridMahasiswa.CurrentRow.Index)

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
        BtnSimpan.Enabled = True
        BtnSimpan.Text = "&SIMPAN"
        BtnKeluar.Text = "&BATAL"
    End Sub

    Private Sub DataGridMahasiswa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridMahasiswa.CellContentClick

    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        If BtnKeluar.Text = "&KELUAR" Then
            End
        Else
            Call FormNormal()
            BtnTambah.Enabled = True
        End If
    End Sub
End Class