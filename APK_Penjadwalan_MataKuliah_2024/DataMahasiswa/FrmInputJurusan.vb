Imports MySql.Data.MySqlClient

Public Class FrmInputJurusan
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Try
            Call KoneksiDB()

            If String.IsNullOrWhiteSpace(TxtKdProdi.Text) OrElse String.IsNullOrWhiteSpace(TxtNmProdi.Text) Then
                MsgBox("Semua field harus diisi!", vbExclamation + vbOKOnly, "PERINGATAN")
                TxtNmProdi.Focus()
                Exit Sub
            End If

            If BtnSimpan.Text = "UBAH" Then
                Call UpdateData()
            ElseIf BtnSimpan.Text = "SIMPAN" Then
                Call InsertData()
            End If

        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MsgBox("Data sudah ada di database!", vbExclamation + vbOKOnly, "DUPLIKAT")
            Else
                MsgBox("Error Database: " & ex.Message, vbCritical + vbOKOnly, "ERROR")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "ERROR")
        End Try
    End Sub
    Sub InsertData()
        If CmbJenjang.SelectedIndex = -1 Then
            MsgBox("Pilih jenjang terlebih dahulu!", vbExclamation + vbOKOnly, "PERINGATAN")
            CmbJenjang.Focus()
            Exit Sub
        End If

        Dim NamaProdiLengkap As String = TxtNmProdi.Text.Trim() & " (" & CmbJenjang.Text & ")"

        Dim SQLCek As String = "SELECT COUNT(*) FROM tbl_prodi WHERE Nm_Prodi = @NmProdi OR Kd_Prodi = @KdProdi"
        Dim CMDCek As New MySqlCommand(SQLCek, DBKoneksi)
        CMDCek.Parameters.AddWithValue("@NmProdi", NamaProdiLengkap)
        CMDCek.Parameters.AddWithValue("@KdProdi", TxtKdProdi.Text.Trim())

        If Convert.ToInt32(CMDCek.ExecuteScalar()) > 0 Then
            MsgBox("Kode Prodi atau Nama Prodi sudah ada!", vbExclamation + vbOKOnly, "DUPLIKAT")
            TxtNmProdi.Focus()
            Exit Sub
        End If

        SQLInsert = "INSERT INTO tbl_prodi (Kd_Prodi, Nm_Prodi) VALUES(@KdProdi, @NmProdi)"
        CMD = New MySqlCommand(SQLInsert, DBKoneksi)
        CMD.Parameters.AddWithValue("@KdProdi", TxtKdProdi.Text.Trim())
        CMD.Parameters.AddWithValue("@NmProdi", NamaProdiLengkap)
        CMD.ExecuteNonQuery()

        MsgBox("Data berhasil ditambahkan!", vbInformation + vbOKOnly, "INFORMASI")
        Call FormKeluar()
    End Sub
    Sub UpdateData()
        If CmbJenjang.SelectedIndex = -1 Then
            MsgBox("Pilih jenjang terlebih dahulu!", vbExclamation + vbOKOnly, "PERINGATAN")
            CmbJenjang.Focus()
            Exit Sub
        End If

        Dim NamaProdiLengkap As String = TxtNmProdi.Text.Trim() & " (" & CmbJenjang.Text & ")"

        Dim SQLCek As String = "SELECT COUNT(*) FROM tbl_prodi WHERE Nm_Prodi = @NmProdi AND Kd_Prodi <> @KodeJurusan"
        Dim CMDCek As New MySqlCommand(SQLCek, DBKoneksi)
        CMDCek.Parameters.AddWithValue("@NmProdi", NamaProdiLengkap)
        CMDCek.Parameters.AddWithValue("@KodeJurusan", Kode_Jurusan)

        If Convert.ToInt32(CMDCek.ExecuteScalar()) > 0 Then
            MsgBox("Nama Prodi sudah ada! Gunakan nama yang berbeda.", vbExclamation + vbOKOnly, "DUPLIKAT")
            TxtNmProdi.Focus()
            Exit Sub
        End If

        SQLUpdate = "UPDATE tbl_prodi SET Nm_Prodi = @NmProdi WHERE Kd_Prodi = @KodeJurusan"
        CMD = New MySqlCommand(SQLUpdate, DBKoneksi)
        CMD.Parameters.AddWithValue("@NmProdi", NamaProdiLengkap)
        CMD.Parameters.AddWithValue("@KodeJurusan", Kode_Jurusan)

        Dim rowsAffected As Integer = CMD.ExecuteNonQuery()

        If rowsAffected > 0 Then
            MsgBox("Data berhasil diubah!", vbInformation + vbOKOnly, "INFORMASI")
            Call FormKeluar()
        Else
            MsgBox("Data tidak ditemukan atau tidak ada perubahan!", vbExclamation + vbOKOnly, "PERINGATAN")
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Try
            If MsgBox("Anda yakin ingin menghapus data ini?", vbYesNo + vbQuestion, "KONFIRMASI") = vbYes Then
                Call KoneksiDB()

                SQLDelete = "DELETE FROM tbl_prodi WHERE Kd_Prodi = @KodeJurusan"
                CMD = New MySqlCommand(SQLDelete, DBKoneksi)
                CMD.Parameters.AddWithValue("@KodeJurusan", Kode_Jurusan)

                Dim rowsAffected As Integer = CMD.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MsgBox("Data berhasil dihapus!", vbInformation + vbOKOnly, "INFORMASI")
                Else
                    MsgBox("Data tidak ditemukan!", vbExclamation + vbOKOnly, "PERINGATAN")
                End If
            End If

            Call FormKeluar()

        Catch ex As MySqlException
            If ex.Number = 1451 Then
                MsgBox("Data tidak dapat dihapus karena masih digunakan di tabel lain!", vbExclamation + vbOKOnly, "ERROR")
            Else
                MsgBox("Error Database: " & ex.Message, vbCritical + vbOKOnly, "ERROR")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "ERROR")
        End Try
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        If BtnKeluar.Text = "BATAL" Then
            Call FormNonAktif()
        ElseIf BtnKeluar.Text = "KELUAR" Then
            Call FormKeluar()
        End If
    End Sub

    Sub FormNonAktif()
        TxtKdProdi.Text = ""
        TxtKdProdi.Enabled = False
        TxtNmProdi.Text = ""
        TxtNmProdi.Enabled = False
        CmbJenjang.SelectedIndex = 0
        CmbJenjang.Enabled = False

        BtnSimpan.Enabled = False
        BtnSimpan.BackColor = Color.Gray
        BtnHapus.Enabled = False
        BtnHapus.BackColor = Color.Gray
        BtnKeluar.Text = "KELUAR"
        BtnKeluar.BackColor = Color.Red
    End Sub


    Sub FormKeluar()
        Me.Close()
        With FrmDataJurusan
            .Enabled = True
            .TampilkanDataGridJurusan()
            .TxtCariProdi.Text = ""
            .TxtCariProdi.Focus()
        End With
    End Sub
    Private Sub FrmInputJurusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbJenjang.Items.Clear()
        CmbJenjang.Items.Add("D3")
        CmbJenjang.Items.Add("D4")
        CmbJenjang.SelectedIndex = 0 'Default D3
    End Sub
End Class
