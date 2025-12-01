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
        Dim sqlInsert As String = "INSERT INTO tbl_mahasiswa (NIK_Mhs, Nm_Mhs, JK_Mhs, tmptlahir_Mhs, TglLahir_Mhs, Alamat_Mhs, Kd_Prodi, Status_Mhs) " &
                                  "VALUES (@NIM, @Nama, @JK, @Tempat, @TglLahir, @Alamat, @KdProdi, @Status)"

        CMD = New MySqlCommand(sqlInsert, DBKoneksi)
        Call AddParameters(CMD)
        CMD.ExecuteNonQuery()

        MsgBox("Data berhasil disimpan!", vbInformation, "INFORMASI")
        Call CloseAndRefresh()
    End Sub

    Sub UpdateMahasiswa()
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
        cmd.Parameters.AddWithValue("@KdProdi", Kode_Jurusan)
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
        CmbJenisKelamin.Items.AddRange({"LAKI-LAKI", "PEREMPUAN"})
        CmbStatusMahasiswa.Items.AddRange({"AKTIF", "NON AKTIF", "CUTI AKADEMIK", "DROP OUT"})
    End Sub

    Private Sub CloseAndRefresh()
        Dim nimBaru As String = LbNimVal.Text
        Dim tahunAngkatan As String = ""

        If nimBaru.Length >= 4 Then
            tahunAngkatan = nimBaru.Substring(0, 4)
        End If

        Me.Close()

        With FrmDataMahasiswa
            .Enabled = True
            .RefreshWithFilter(tahunAngkatan)
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

End Class