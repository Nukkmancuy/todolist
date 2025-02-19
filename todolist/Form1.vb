Imports System.IO ' Untuk membaca dan menulis file

Public Class Form1
    ' List untuk menyimpan daftar tugas
    Dim daftarTugas As New List(Of String)

    ' Prosedur untuk menampilkan daftar tugas di ListBox
    Private Sub TampilkanTugas()
        lstTugas.Items.Clear() ' Bersihkan daftar sebelumnya
        For Each tugas As String In daftarTugas
            lstTugas.Items.Add(tugas)
        Next
    End Sub

    ' Event: Tambah tugas ke dalam daftar
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtTugas.Text.Trim() <> "" Then
            daftarTugas.Add(txtTugas.Text.Trim()) ' Tambahkan tugas ke daftar
            txtTugas.Clear() ' Hapus isi textbox setelah ditambahkan
            TampilkanTugas() ' Perbarui tampilan ListBox
        Else
            MessageBox.Show("Masukkan tugas terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Event: Hapus tugas yang dipilih
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If lstTugas.SelectedIndex <> -1 Then
            daftarTugas.RemoveAt(lstTugas.SelectedIndex) ' Hapus tugas yang dipilih
            TampilkanTugas() ' Perbarui tampilan
        Else
            MessageBox.Show("Pilih tugas yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Event: Simpan daftar tugas ke file
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            File.WriteAllLines("daftar_tugas.txt", daftarTugas) ' Simpan daftar ke file
            MessageBox.Show("Daftar tugas berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event: Muat daftar tugas dari file
    Private Sub btnMuat_Click(sender As Object, e As EventArgs) Handles btnMuat.Click
        Try
            If File.Exists("daftar_tugas.txt") Then
                daftarTugas = File.ReadAllLines("daftar_tugas.txt").ToList() ' Baca daftar dari file
                TampilkanTugas() ' Perbarui tampilan
            Else
                MessageBox.Show("File daftar_tugas.txt tidak ditemukan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal membaca file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
