Public Class Form4
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtKodeSpesies.Text
            Case "KRN" : txtKeterangan.Text = "Karnivora"

            Case "HRB" : txtKeterangan.Text = "Herbivora"

            Case "OMN" : txtKeterangan.Text = "Omnivora"

            Case Else : txtKeterangan.Text = "Tidak Ada di Data Spesies"
        End Select
    End Sub
End Class