Public Class Form2
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtMasaKerja.Text) >= 20) Then
            txtKeterangan.Text = "Anda mendapat bonus mobil"

        ElseIf (txtMasaKerja.Text >= 15) Then
            txtKeterangan.Text = "Anda mendapat bonus umroh"

        ElseIf (txtMasaKerja.Text >= 10) Then
            txtKeterangan.Text = "Anda mendapat bonus liburan"

        ElseIf (txtMasaKerja.Text >= 5) Then
            txtKeterangan.Text = "Anda mendapat bonus emas 2gram"

        Else
            txtKeterangan.Text = "Maaf anda belum layak dapat bonus"
        End If
    End Sub
End Class