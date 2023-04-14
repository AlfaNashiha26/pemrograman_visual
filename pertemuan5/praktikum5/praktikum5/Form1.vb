Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtNoUndian.Text) >= 100) Then
            txtKeterangan.Text = "Anda mendapat bonus TV"

        ElseIf (txtNoUndian.Text >= 70) Then
            txtKeterangan.Text = "Anda mendapat bonus Sepeda"

        ElseIf (txtNoUndian.Text >= 30) Then
            txtKeterangan.Text = "Anda mendapat bonus Voucher Belanja"

        ElseIf (txtNoUndian.Text <= 29) Then
            txtKeterangan.Text = "Anda mendapat bonus Makan Gratos"

        Else
            txtKeterangan.Text = "Maaf anda belum layak dapat bonus"
        End If
    End Sub
End Class