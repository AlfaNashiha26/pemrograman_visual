Public Class Form2
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtNoVoucher.Text) >= 10) Then
            txtKeterangan.Text = "Anda mendapat Voucher makan Steak Daging"

        ElseIf (txtNoVoucher.Text >= 7) Then
            txtKeterangan.Text = "Anda mendapat Voucher makan Sate Thaichan"

        ElseIf (txtNoVoucher.Text >= 4) Then
            txtKeterangan.Text = "Anda mendapat Voucher makan Ayam Goreng"

        ElseIf (txtNoVoucher.Text >= 1) Then
            txtKeterangan.Text = "Anda mendapat Voucher makan Nasi Padang"

        Else
            txtKeterangan.Text = "Maaf anda belum layak dapat Voucher"
        End If
    End Sub
End Class