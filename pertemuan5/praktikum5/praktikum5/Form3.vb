Public Class Form3
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtKodeUniv.Text
            Case "UMC" : txtKeterangan.Text = "Universitas Muhammadiyah Cirebon"

            Case "UMY" : txtKeterangan.Text = "Universitas Muhammadiyah Yogyakarta"

            Case "UMM" : txtKeterangan.Text = "Universitas Muhammadiyah Malang"

            Case Else : txtKeterangan.Text = "Bukan Universitas Muhammadiyah"
        End Select
    End Sub
End Class