Public Class FrmDataMhs
    Private selectedRowIndex As Integer = -1
    Sub FormMati()
        'Membuat Sub Prosedure untuk mematikan Object
        TxtNik.Enabled = False
        TxtNama.Enabled = False
        CBJenisKelamin.Enabled = False
        CbAgama.Enabled = False
        TxtAlamat.Enabled = False
        CbJurusan.Enabled = False
        CbStatusMahasiswa.Enabled = False
    End Sub

    Sub FormHidup()
        'Membuat Sub Prosedure untuk Menghidupkan Object
        TxtNik.Enabled = True
        TxtNama.Enabled = True
        CBJenisKelamin.Enabled = True
        CbAgama.Enabled = True
        TxtAlamat.Enabled = True
        CbJurusan.Enabled = True
        CbStatusMahasiswa.Enabled = True
    End Sub
    Sub Kosongkan()
        'Membuat Sub Prosedure untuk Mengosongkan Object
        TxtNik.Clear()
        TxtNama.Clear()
        CBJenisKelamin.Items.Clear()
        CbAgama.Items.Clear()
        TxtAlamat.Clear()
        CbJurusan.Items.Clear()
        CbStatusMahasiswa.Items.Clear()
        LbHasil.Text = ""
    End Sub

    Sub FormNormal()
        Kosongkan()
        FormMati()
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = False
        BtnKeluar.Text = "&KELUAR"
        BtnSimpan.Text = "&SIMPAN"
        selectedRowIndex = -1
    End Sub
    Sub Agama()
        CbAgama.Items.Add("ISLAM")
        CbAgama.Items.Add("KRISTEN")
        CbAgama.Items.Add("HINDU")
        CbAgama.Items.Add("BUDDHA")
        CbAgama.Items.Add("KONGHUCU")
    End Sub
    Sub jeniskelamin()
        CBJenisKelamin.Items.Add("LAKI-LAKI")
        CBJenisKelamin.Items.Add("PEREMPUAN")
    End Sub
    Sub Jurusan()
        CbJurusan.Items.Add("Teknik Informatika")
        CbJurusan.Items.Add("Manajemen Informatik")
        CbJurusan.Items.Add("Teknik Industri")
        CbJurusan.Items.Add("Akuntasi & Bisnis")
    End Sub
    Sub StatusMhs()
        CbStatusMahasiswa.Items.Add("AKTIF")
        CbStatusMahasiswa.Items.Add("NON AKTIF")
        CbStatusMahasiswa.Items.Add("CUTI AKADEMIK")
        CbStatusMahasiswa.Items.Add("DROP OUT")
    End Sub
    Private Sub FrmDataMahasiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Form Load
        Call Buat_DataGridMahasiswa()
        Call FormMati()
        BtnSimpan.Enabled = False
        BtnHapus.Enabled = False
    End Sub
    Sub Buat_DataGridMahasiswa()
        With DataGridMahasiswa
            'Mengisi Nama pada kolom grid
            .Columns.Add("NIK", "NIK")
            .Columns.Add("Nama", "Nama")
            .Columns.Add("Jenis Kelamin", "Jenis Kelamin")
            .Columns.Add("Agama", "Agama")
            .Columns.Add("Alamat", "Alamat")
            .Columns.Add("Jurusan", "Jurusan")
            .Columns.Add("Status Mahasiswa", "Status Mahasiswwa")

            'Mengatur Lebar Kolom pada grid
            .Columns("NIK").Width = 80
            .Columns("Nama").Width = 150
            .Columns("Jenis Kelamin").Width = 100
            .Columns("Agama").Width = 100
            .Columns("Alamat").Width = 150
            .Columns("Jurusan").Width = 100
            .Columns("Status Mahasiswa").Width = 100
        End With
    End Sub
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If BtnSimpan.Text = "&EDIT" Then
            If selectedRowIndex > -1 Then
                With DataGridMahasiswa.Rows(selectedRowIndex)
                    .Cells(0).Value = TxtNik.Text
                    .Cells(1).Value = TxtNama.Text
                    .Cells(2).Value = CBJenisKelamin.Text
                    .Cells(3).Value = CbAgama.Text
                    .Cells(4).Value = TxtAlamat.Text
                    .Cells(5).Value = CbJurusan.Text
                    .Cells(6).Value = CbStatusMahasiswa.Text
                End With
                Call FormNormal()
                BtnTambah.Enabled = True
            End If
        Else
            If TxtNik.Text = "" And TxtNama.Text = "" And CBJenisKelamin.Text = "" And CbAgama.Text = "" And TxtAlamat.Text = "" And CbJurusan.Text = "" And CbStatusMahasiswa.Text = "" Then
                MsgBox("Lengkapi Data terlebih dahulu")
                TxtNama.Focus()
            Else
                With DataGridMahasiswa
                    .Rows.Insert(.NewRowIndex, TxtNik.Text, TxtNama.Text, CBJenisKelamin.Text, CbAgama.Text, TxtAlamat.Text, CbJurusan.Text, CbStatusMahasiswa.Text)
                End With
                Kosongkan()
                Call FormNormal()
                BtnTambah.Enabled = True
            End If
        End If
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Call FormHidup()
        Call jeniskelamin()
        Call Jurusan()
        Call Agama()
        Call StatusMhs()
        TxtNik.Focus()
        BtnTambah.Enabled = False
        BtnSimpan.Enabled = True
        BtnSimpan.Text = "&SIMPAN"
        BtnKeluar.Text = "&BATAL"
    End Sub
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If DataGridMahasiswa.CurrentRow.Index <> DataGridMahasiswa.NewRowIndex Then
            DataGridMahasiswa.Rows.RemoveAt(DataGridMahasiswa.CurrentRow.Index)
            Call FormNormal()
            BtnTambah.Enabled = True
        End If
    End Sub
    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        'menggunakan fungsi if
        If BtnKeluar.Text = "&KELUAR" Then
            End
        Else
            FormNormal()
            BtnTambah.Enabled = True
        End If
    End Sub
    Private Sub DataGridMahasiswa_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridMahasiswa.CellMouseClick
        If e.RowIndex < 0 OrElse DataGridMahasiswa.Rows.Count <= 1 Then
            MsgBox("Data Belum Tersedia!")
            Return
        End If

        If DataGridMahasiswa.Rows(e.RowIndex).IsNewRow Then
            MsgBox("Data Kosong!")
            Return
        End If

        selectedRowIndex = e.RowIndex

        Call FormHidup()
        Call jeniskelamin()
        Call Agama()
        Call Jurusan()
        Call StatusMhs()

        BtnHapus.Enabled = True
        BtnTambah.Enabled = False
        BtnSimpan.Enabled = True
        BtnKeluar.Text = "&BATAL"
        BtnSimpan.Text = "&EDIT"

        With DataGridMahasiswa.Rows(selectedRowIndex)
            TxtNik.Text = .Cells(0).Value.ToString()
            TxtNama.Text = .Cells(1).Value.ToString()
            CBJenisKelamin.Text = .Cells(2).Value.ToString()
            CbAgama.Text = .Cells(3).Value.ToString()
            TxtAlamat.Text = .Cells(4).Value.ToString()
            CbJurusan.Text = .Cells(5).Value.ToString()
            CbStatusMahasiswa.Text.ToString()
        End With
    End Sub
End Class