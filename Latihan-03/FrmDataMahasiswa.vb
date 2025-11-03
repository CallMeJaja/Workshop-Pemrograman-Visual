Imports MySql.Data.MySqlClient

Public Class FrmDataMahasiswa

    Sub AktifDataGridMahasiswa()
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

                ' Memberikan nama pada pada header nama
                DataGridMahasiswa.Columns(1).Width = 80
                DataGridMahasiswa.Columns(1).HeaderText = "NAMA"
                DataGridMahasiswa.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                ' Memberikan nama pada pada header jk
                DataGridMahasiswa.Columns(2).Width = 80
                DataGridMahasiswa.Columns(2).HeaderText = "JENIS KELAMIN"
                DataGridMahasiswa.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                ' Memberikan nama pada pada header tmptLahir
                DataGridMahasiswa.Columns(3).Width = 80
                DataGridMahasiswa.Columns(3).HeaderText = "TEMPAT LAHIR"
                DataGridMahasiswa.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                ' Memberikan nama pada pada header tglLahir
                DataGridMahasiswa.Columns(4).Width = 80
                DataGridMahasiswa.Columns(4).HeaderText = "TANGGAL LAHIR"
                DataGridMahasiswa.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                ' Memberikan nama pada pada header alamat
                DataGridMahasiswa.Columns(5).Width = 80
                DataGridMahasiswa.Columns(5).HeaderText = "ALAMAT"
                DataGridMahasiswa.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                ' Memberikan nama pada pada header status
                DataGridMahasiswa.Columns(6).Width = 80
                DataGridMahasiswa.Columns(6).HeaderText = "STATUS MAHASISWA"
                DataGridMahasiswa.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            Catch ex As Exception
            End Try
        End With
    End Sub

    Sub TampilkanDataMahasiswa()
        Call KoneksiDB()
        DA = New MySqlDataAdapter("SELECT
  tbl_mahasiswa.NIK_Mhs,
  tbl_mahasiswa.Nm_Mhs,
  tbl_mahasiswa.JK_Mhs,
  tbl_mahasiswa.tmptlahir_Mhs,
  tbl_mahasiswa.TglLahir_Mhs,
  tbl_mahasiswa.Alamat_Mhs,
  tbl_mahasiswa.Status_Mhs
FROM
  tbl_mahasiswa
ORDER BY
  NIK_Mhs ASC", DBKoneksi)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS)
        DataGridMahasiswa.DataSource = DS.Tables(0)
        DataGridMahasiswa.ReadOnly = True
        Call AktifDataGridMahasiswa()
    End Sub

    Private Sub FrmDataMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDB()
        Call TampilkanDataMahasiswa()
    End Sub
End Class