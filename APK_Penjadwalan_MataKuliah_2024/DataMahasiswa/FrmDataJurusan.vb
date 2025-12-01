Imports MySql.Data.MySqlClient

Public Class FrmDataJurusan

    Private Sub FrmDataJurusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FormNonAktif()
    End Sub

    Sub TampilkanDataGridJurusan()
        Try
            Call KoneksiDB()
            DA = New MySqlDataAdapter("SELECT * FROM tbl_prodi ORDER BY Kd_Prodi", DBKoneksi)
            DS = New DataSet
            DA.Fill(DS)

            DataGridJurusan.DataSource = DS.Tables(0)
            DataGridJurusan.ReadOnly = True
            Call StyleDataGrid()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "ERROR")
        End Try
    End Sub

    Sub StyleDataGrid()
        With DataGridJurusan
            .EnableHeadersVisualStyles = False
            .Font = New Font(.Font, FontStyle.Bold)
            .DefaultCellStyle.Font = New Font("Arial", 10)
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            .ColumnHeadersHeight = 35
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AllowUserToAddRows = False

            .Columns(0).Width = 200
            .Columns(0).HeaderText = "KODE JURUSAN"
            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(1).Width = 400
            .Columns(1).HeaderText = "NAMA JURUSAN"
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    Sub FormNormal()
        TxtCariProdi.Text = ""
        TxtCariProdi.Enabled = True
        BtnCari.Text = "CARI"
        BtnCari.Enabled = True
        BtnTambah.Text = "TAMBAH DATA"
        BtnTambah.Enabled = True
        BtnKeluar.Text = "BATAL"
        BtnKeluar.Enabled = True
        DataGridJurusan.Enabled = False
    End Sub

    Sub FormNonAktif()
        TxtCariProdi.Text = ""
        TxtCariProdi.Enabled = False
        BtnCari.Text = "AKTIFKAN FORM"
        BtnTambah.Enabled = False
        BtnKeluar.Text = "KELUAR"
        BtnKeluar.Enabled = True
        DataGridJurusan.DataSource = Nothing
    End Sub

    Sub BuatKodeJurusan()
        Try
            Call KoneksiDB()
            Dim SQLCek As String = "SELECT Kd_Prodi FROM tbl_prodi ORDER BY Kd_Prodi DESC LIMIT 1"
            Dim CMDCek As New MySqlCommand(SQLCek, DBKoneksi)
            Dim DRCek As MySqlDataReader = CMDCek.ExecuteReader()
            Dim KodeBaru As String

            If DRCek.Read() Then
                Dim KodeLama As String = DRCek("Kd_Prodi").ToString()
                Dim Angka As Integer = CInt(KodeLama.Substring(2)) + 1
                KodeBaru = "PR" & Angka.ToString("000")
            Else
                KodeBaru = "PR001"
            End If

            DRCek.Close()
            FrmInputJurusan.TxtKdProdi.Text = KodeBaru

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "ERROR")
        End Try
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        Try
            Call KoneksiDB()

            If BtnCari.Text = "CARI" Then
                If String.IsNullOrWhiteSpace(TxtCariProdi.Text) Then
                    MsgBox("Silahkan isi field pencarian terlebih dahulu.", vbInformation + vbOKOnly, "INFORMASI")
                    TxtCariProdi.Focus()
                    Return
                End If

                Dim SQLCari As String = "SELECT * FROM tbl_prodi WHERE Kd_Prodi LIKE @Keyword OR Nm_Prodi LIKE @Keyword ORDER BY Kd_Prodi"
                DA = New MySqlDataAdapter(SQLCari, DBKoneksi)
                DA.SelectCommand.Parameters.AddWithValue("@Keyword", "%" & TxtCariProdi.Text.Trim() & "%")

                DS = New DataSet()
                DA.Fill(DS)

                If DS.Tables(0).Rows.Count > 0 Then
                    DataGridJurusan.DataSource = DS.Tables(0)
                    DataGridJurusan.Enabled = True
                    Call StyleDataGrid()
                    MsgBox("Ditemukan " & DS.Tables(0).Rows.Count & " data.", vbInformation + vbOKOnly, "INFORMASI")
                Else
                    MsgBox("Data '" & TxtCariProdi.Text & "' tidak ditemukan.", vbInformation + vbOKOnly, "INFORMASI")
                    TxtCariProdi.SelectAll()
                    TxtCariProdi.Focus()
                End If

            ElseIf BtnCari.Text = "AKTIFKAN FORM" Then
                Call FormNormal()
                Call TampilkanDataGridJurusan()
            End If

        Catch ex As MySqlException
            MsgBox("Error Database: " & ex.Message, vbCritical + vbOKOnly, "ERROR")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "ERROR")
        End Try
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Me.Enabled = False
        Call BuatKodeJurusan()
        With FrmInputJurusan
            .Show()
            .TxtKdProdi.Enabled = False
            .TxtNmProdi.Focus()
            .MdiParent = FrmMenuUtama
            .BtnHapus.Enabled = False
            .BtnHapus.BackColor = Color.Red
        End With
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        If BtnKeluar.Text = "BATAL" Then
            Call FormNonAktif()
        ElseIf BtnKeluar.Text = "KELUAR" Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtCariProdi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCariProdi.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            BtnCari.PerformClick()
        End If
    End Sub

    Private Sub DataGridJurusan_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridJurusan.CellMouseDoubleClick
        Try
            If e.RowIndex < 0 Then Exit Sub

            If DataGridJurusan.Rows.Count = 0 OrElse DataGridJurusan.CurrentRow Is Nothing Then
                MsgBox("Tidak ada data yang dipilih!", vbExclamation + vbOKOnly, "PERINGATAN")
                Exit Sub
            End If

            If IsDBNull(DataGridJurusan.Item(0, e.RowIndex).Value) OrElse String.IsNullOrEmpty(DataGridJurusan.Item(0, e.RowIndex).Value?.ToString()) Then
                MsgBox("Baris yang dipilih kosong!", vbExclamation + vbOKOnly, "PERINGATAN")
                Exit Sub
            End If

            Call KoneksiDB()

            Dim KdProdi As String = DataGridJurusan.Item(0, e.RowIndex).Value.ToString()
            Kode_Jurusan = KdProdi

            Dim SQLCek As String = "SELECT * FROM tbl_prodi WHERE Kd_Prodi = @KdProdi"
            CMD = New MySqlCommand(SQLCek, DBKoneksi)
            CMD.Parameters.AddWithValue("@KdProdi", KdProdi)
            DR = CMD.ExecuteReader()

            If DR.Read() Then
                Me.Enabled = False
                With FrmInputJurusan
                    .Show()
                    .MdiParent = FrmMenuUtama
                    .BtnSimpan.Text = "UBAH"
                    .BtnKeluar.Text = "BATAL"
                    .TxtKdProdi.Text = DR("Kd_Prodi").ToString()
                    .TxtKdProdi.Enabled = False

                    'Pisahkan nama prodi dan jenjang
                    Dim NamaProdi As String = DR("Nm_Prodi").ToString()

                    If NamaProdi.Contains("(") AndAlso NamaProdi.Contains(")") Then
                        Dim indexBuka As Integer = NamaProdi.LastIndexOf("(")
                        Dim indexTutup As Integer = NamaProdi.LastIndexOf(")")

                        'Ambil nama prodi (sebelum kurung buka)
                        .TxtNmProdi.Text = NamaProdi.Substring(0, indexBuka).Trim()

                        'Ambil jenjang (di dalam kurung)
                        Dim jenjang As String = NamaProdi.Substring(indexBuka + 1, indexTutup - indexBuka - 1).Trim()
                        .CmbJenjang.Text = jenjang
                    End If

                    .TxtNmProdi.Focus()
                End With
            Else
                MsgBox("Data tidak ditemukan di database!", vbExclamation + vbOKOnly, "PERINGATAN")
            End If

            DR.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "ERROR")
        End Try
    End Sub

End Class