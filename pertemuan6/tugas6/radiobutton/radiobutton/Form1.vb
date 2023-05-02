Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim harga As Integer

        'Cek kategori tiket yang dipilih
        If rbAnak.Checked Then
            harga = 50000 'Harga tiket anak-anak
        ElseIf rbDewasa.Checked Then
            harga = 100000 'Harga tiket dewasa
        Else
            MessageBox.Show("Pilih kategori tiket terlebih dahulu")
            Exit Sub
        End If

        'Tampilkan harga tiket
        txtHarga.Text = harga.ToString("C0") 'Format harga dalam bentuk mata uang
    End Sub
End Class
