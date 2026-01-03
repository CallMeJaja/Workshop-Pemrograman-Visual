Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmLapDataMahasiswa
    Sub TampilkanFilterDataProdi()
        Try
            Call KoneksiDB()

            Dim sqlProdi As String = "SELECT Nm_Prodi FROM tbl_prodi ORDER BY Nm_Prodi"
            CMD = New MySqlCommand(sqlProdi, DBKoneksi)
            DR = CMD.ExecuteReader()

            CbNamaJurusan.Items.Clear()

            While DR.Read()
                CbNamaJurusan.Items.Add(DR("Nm_Prodi").ToString())
            End While
            DR.Close()

            CbNamaJurusan.SelectedIndex = -1

        Catch ex As Exception
            If DR IsNot Nothing AndAlso Not DR.IsClosed Then DR.Close()
            MsgBox("Error: " & ex.Message, vbCritical, "ERROR")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilkanFilterDataProdi()
    End Sub

    Private Sub BtnCetakLaporan_Click(sender As Object, e As EventArgs) Handles BtnCetakLaporan.Click
        Dim LapReport As New ReportDocument()
        Dim rptPath As String = IO.Path.Combine(Application.StartupPath, "LatihanCrystalReport_DataMahasiswa.rpt")

        If Not IO.File.Exists(rptPath) Then
            MessageBox.Show("File report tidak ditemukan: " & rptPath)
            Return
        End If

        If CbNamaJurusan.SelectedIndex = -1 Then
            MsgBox("Silahkan pilih jurusan terlebih dahulu.", vbInformation + vbOKOnly, "INFORMASI")
            Return
        End If

        Try
            LapReport.Load(rptPath)
            Dim filterQuery As String = ""

            ' Filter berdasarkan Nama Prodi (Nm_Prodi)
            If CbNamaJurusan.SelectedIndex <> -1 Then
                filterQuery = "{vlaporandatamahasiswa1.Nm_Prodi} = '" & CbNamaJurusan.Text & "'"
            End If

            ' Filter berdasarkan Tahun Angkatan (diambil dari 4 digit awal NIM/NIK_Mhs)
            If CmbTahunAngkatan.SelectedIndex <> -1 Then
                If filterQuery <> "" Then filterQuery &= " AND "
                ' Fungsi Left dalam Crystal Report memotong 4 digit awal dari NIM
                filterQuery &= "Left({vlaporandatamahasiswa1.NIK_Mhs}, 4) = '" & CmbTahunAngkatan.Text & "'"
            End If

            CrLapJurusan.SelectionFormula = filterQuery
            CrLapJurusan.ReportSource = LapReport
            CrLapJurusan.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("Gagal memuat laporan: " & ex.Message)
        End Try
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim message = MsgBox("Apakah anda yakin ingin keluar?", vbQuestion + vbYesNo, "Warning")
        If message = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Function GetKodeProdiByNama(namaProdi As String) As String
        Try
            Call KoneksiDB()
            Dim SQL As String = "SELECT Kd_Prodi FROM tbl_prodi WHERE Nm_Prodi = @NamaProdi"
            Dim CMD As New MySqlCommand(SQL, DBKoneksi)
            CMD.Parameters.AddWithValue("@NamaProdi", namaProdi)

            Dim result As String = CMD.ExecuteScalar()?.ToString()
            Return If(String.IsNullOrEmpty(result), "", result)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub CbNamaJurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbNamaJurusan.SelectedIndexChanged
        Try
            Call KoneksiDB()
            Dim sqlTahunByProdi As String = "SELECT DISTINCT LEFT(NIK_Mhs, 4) AS Tahun " &
                                        "FROM vlaporandatamahasiswa " &
                                        "WHERE Nm_Prodi = '" & CbNamaJurusan.Text & "' " &
                                        "ORDER BY Tahun DESC"

            CMD = New MySqlCommand(sqlTahunByProdi, DBKoneksi)
            DR = CMD.ExecuteReader()
            CmbTahunAngkatan.Items.Clear()
            While DR.Read()
                CmbTahunAngkatan.Items.Add(DR("Tahun").ToString())
            End While
            CmbTahunAngkatan.SelectedIndex = 0
            DR.Close()
        Catch ex As Exception
            If DR IsNot Nothing AndAlso Not DR.IsClosed Then DR.Close()
        End Try
    End Sub
End Class