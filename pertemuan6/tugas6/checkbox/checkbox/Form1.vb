Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim hargaBarang As Double = CDbl(txtHargaBarang.Text)
        Dim jumlahBarang As Integer = CInt(txtJumlahBarang.Text)
        Dim totalBayar As Double = hargaBarang * jumlahBarang

        If chkMember.Checked Then
            totalBayar *= 0.9 'diskon 10% untuk anggota
        End If

        lblTotalBayar.Text = "Total Bayar: Rp " & Format(totalBayar, "N0")
    End Sub
End Class
