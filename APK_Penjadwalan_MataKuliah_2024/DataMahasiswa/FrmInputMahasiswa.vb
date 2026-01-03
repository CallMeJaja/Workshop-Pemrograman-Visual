Imports MySql.Data.MySqlClient

Public Class FrmInputMahasiswa
    Private Sub FrmMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call InitializeComboBoxes()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If Not ValidateInput() Then Exit Sub

        Try
            Call KoneksiDB()

            If BtnSimpan.Text = "SIMPAN" Then
                Call InsertMahasiswa()
            ElseIf BtnSimpan.Text = "UBAH" Then
                Call UpdateMahasiswa()
            End If

        Catch ex As MySqlException
            MsgBox("Error Database: " & ex.Message, vbCritical, "ERROR")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "ERROR")
        End Try
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If MsgBox("Anda yakin ingin menghapus data ini?", vbYesNo + vbQuestion, "KONFIRMASI") = vbNo Then
            Exit Sub
        End If

        Try
            Call KoneksiDB()
            Call DeleteMahasiswa()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "ERROR")
        End Try
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Select Case BtnKeluar.Text
            Case "KELUAR"
                If MsgBox("Anda yakin ingin keluar?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
                    Call CloseAndReturnToList()
                End If
            Case "BATAL"
                Call FormNonAktif()
            Case Else
                BtnSimpan.Text = "SIMPAN"
                BtnSimpan.Enabled = True
                BtnSimpan.BackColor = Color.LightGray
        End Select
    End Sub

    Sub InsertMahasiswa()
        If IsNamaDuplikatDiAngkatan(isUpdate:=False) Then Exit Sub

        Dim sqlInsert As String = "INSERT INTO tbl_mahasiswa (NIK_Mhs, Nm_Mhs, JK_Mhs, tmptlahir_Mhs, TglLahir_Mhs, Alamat_Mhs, Kd_Prodi, Status_Mhs) " &
                                  "VALUES (@NIM, @Nama, @JK, @Tempat, @TglLahir, @Alamat, @KdProdi, @Status)"

        CMD = New MySqlCommand(sqlInsert, DBKoneksi)
        Call AddParameters(CMD)
        CMD.ExecuteNonQuery()

        MsgBox("Data berhasil disimpan!", vbInformation, "INFORMASI")
        Call ResetForm()
        Call CloseAndRefresh()
    End Sub

    Sub UpdateMahasiswa()
        If IsNamaDuplikatDiAngkatan(isUpdate:=True) Then Exit Sub

        Dim sqlUpdate As String = "UPDATE tbl_mahasiswa SET " &
                                  "Nm_Mhs = @Nama, JK_Mhs = @JK, tmptlahir_Mhs = @Tempat, " &
                                  "TglLahir_Mhs = @TglLahir, Alamat_Mhs = @Alamat, " &
                                  "Status_Mhs = @Status, Kd_Prodi = @KdProdi " &
                                  "WHERE NIK_Mhs = @NIM"

        CMD = New MySqlCommand(sqlUpdate, DBKoneksi)
        Call AddParameters(CMD)

        Dim rowsAffected As Integer = CMD.ExecuteNonQuery()

        If rowsAffected > 0 Then
            MsgBox("Data berhasil diperbarui!", vbInformation, "INFORMASI")
            Call CloseAndRefresh()
        Else
            MsgBox("Data tidak ditemukan atau tidak ada perubahan!", vbExclamation, "PERINGATAN")
        End If
    End Sub

    Sub DeleteMahasiswa()
        Dim sqlDelete As String = "DELETE FROM tbl_mahasiswa WHERE NIK_Mhs = @NIM"
        CMD = New MySqlCommand(sqlDelete, DBKoneksi)
        CMD.Parameters.AddWithValue("@NIM", LbNimVal.Text)

        Dim rowsAffected As Integer = CMD.ExecuteNonQuery()

        If rowsAffected > 0 Then
            MsgBox("Data berhasil dihapus!", vbInformation, "INFORMASI")
            Call CloseAndRefresh()
        Else
            MsgBox("Data tidak ditemukan!", vbExclamation, "PERINGATAN")
        End If
    End Sub

    Private Sub AddParameters(cmd As MySqlCommand)
        cmd.Parameters.AddWithValue("@NIM", LbNimVal.Text.Trim())
        cmd.Parameters.AddWithValue("@Nama", TxtNama.Text.Trim())
        cmd.Parameters.AddWithValue("@JK", CmbJenisKelamin.Text)
        cmd.Parameters.AddWithValue("@Tempat", TxtTempatLahir.Text.Trim())
        cmd.Parameters.AddWithValue("@TglLahir", DateTimePickerMhs.Value.ToString("yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@Alamat", TxtAlamat.Text.Trim())
        cmd.Parameters.AddWithValue("@KdProdi", LbKdJurusan.Text.Trim())
        cmd.Parameters.AddWithValue("@Status", CmbStatusMahasiswa.Text)
    End Sub

    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(TxtNama.Text) OrElse
           CmbJenisKelamin.SelectedIndex = -1 OrElse
           String.IsNullOrWhiteSpace(TxtTempatLahir.Text) OrElse
           String.IsNullOrWhiteSpace(TxtAlamat.Text) OrElse
           CmbStatusMahasiswa.SelectedIndex = -1 Then

            MsgBox("Semua field harus diisi!", vbExclamation, "PERINGATAN")
            Return False
        End If

        Return True
    End Function

    Private Sub InitializeComboBoxes()
        If CmbJenisKelamin.Items.Count = 0 And CmbStatusMahasiswa.Items.Count = 0 Then
            CmbJenisKelamin.Items.AddRange({"LAKI-LAKI", "PEREMPUAN"})
            CmbStatusMahasiswa.Items.AddRange({"AKTIF", "NON AKTIF", "CUTI AKADEMIK", "DROP OUT"})
        End If
    End Sub

    Private Sub CloseAndRefresh()
        Dim nimBaru As String = LbNimVal.Text
        Dim tahunAngkatan As String = ""
        Dim kdProdi As String = LbKdJurusan.Text.Trim()

        If nimBaru.Length >= 4 Then
            tahunAngkatan = nimBaru.Substring(0, 4)
        End If


        Call KoneksiDB()
        Dim sqlCek As String = "SELECT COUNT(*) FROM tbl_mahasiswa WHERE Kd_Prodi = @kdProdi"
        CMD = New MySqlCommand(sqlCek, DBKoneksi)
        CMD.Parameters.AddWithValue("@kdProdi", kdProdi)
        Dim sisaData As Integer = CInt(CMD.ExecuteScalar())

        Me.Close()

        With FrmDataMahasiswa
            .Enabled = True
            .RefreshWithFilter(tahunAngkatan)
        End With

        With FrmDataMhsPagination
            .Enabled = True

            If sisaData > 0 Then
                .LoadTahunAngkatan(kdProdi)
                If .CmbTahunAngkatan.Items.Count > 1 Then
                    .CmbTahunAngkatan.SelectedIndex = 1
                Else
                    .CmbTahunAngkatan.SelectedIndex = 0
                End If
                .RefreshPaging()
            Else
                .ResetTampilan()
                MsgBox("Data mahasiswa untuk prodi ini sekarang sudah kosong.", vbExclamation, "Informasi")
            End If
        End With
    End Sub


    Private Sub CloseAndReturnToList()
        Me.Close()
        With FrmDataMahasiswa
            .MdiParent = FrmMenuUtama
            .Show()
            .Enabled = True
        End With
    End Sub

    Sub FormNonAktif()
        TxtNama.Clear()
        TxtNama.Enabled = False
        CmbJenisKelamin.SelectedIndex = -1
        CmbJenisKelamin.Enabled = False
        TxtTempatLahir.Clear()
        TxtTempatLahir.Enabled = False
        DateTimePickerMhs.Enabled = False
        TxtAlamat.Clear()
        TxtAlamat.Enabled = False
        CmbJurusan.Enabled = False
        CmbStatusMahasiswa.SelectedIndex = -1
        CmbStatusMahasiswa.Enabled = False

        LbNimVal.Text = ""
        LbKdJurusan.Text = ""
        FrmDataMahasiswa.CbNamaJurusan.SelectedIndex = -1

        BtnSimpan.Enabled = False
        BtnSimpan.BackColor = Color.Red
        BtnHapus.Enabled = False
        BtnHapus.BackColor = Color.Red
        BtnKeluar.Text = "KELUAR"
    End Sub

    Private Function IsNamaDuplikatDiAngkatan(isUpdate As Boolean)
        Dim nim As String = LbNimVal.Text.Trim()
        If nim.Length < 4 Then Return False

        Dim tahun As String = nim.Substring(0, 4)
        Dim nama As String = TxtNama.Text.Trim()
        Dim kdProdi As String = LbKdJurusan.Text.Trim()

        Dim sqlCek As String = "SELECT COUNT(*) FROM tbl_mahasiswa WHERE Nm_Mhs = @Nama AND LEFT(NIK_Mhs, 4) = @Tahun AND Kd_Prodi = @KdProdi"

        If isUpdate Then
            sqlCek &= " AND NIK_Mhs <> @NIM"
        End If

        CMD = New MySqlCommand(sqlCek, DBKoneksi)
        CMD.Parameters.AddWithValue("@Nama", nama)
        CMD.Parameters.AddWithValue("@Tahun", tahun)
        CMD.Parameters.AddWithValue("@KdProdi", kdProdi)
        If isUpdate Then
            CMD.Parameters.AddWithValue("@NIM", nim)
        End If

        Dim jumlah As Integer = CInt(CMD.ExecuteScalar())

        If jumlah > 0 Then
            MsgBox("Nama Mahasiswa '" & nama & "' sudah terdaftar pada prodi ini di angkatan " & tahun & "!" & vbCrLf &
               "Tidak boleh ada nama sama dalam prodi dan angkatan yang sama.", vbExclamation, "DUPLIKAT NAMA")
            Return True
        End If
        Return False
    End Function

    Sub ResetForm()
        TxtNama.Clear()
        TxtTempatLahir.Clear()
        DateTimePickerMhs.Value = Now
        TxtAlamat.Clear()

        CmbJenisKelamin.SelectedIndex = -1
        CmbStatusMahasiswa.SelectedIndex = -1

        TxtNama.Focus()
        BtnSimpan.Text = "SIMPAN"
        BtnSimpan.BackColor = Color.LightGray
    End Sub
End Class