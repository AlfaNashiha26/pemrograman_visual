Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim biaya As Integer
        Select Case ComboBox1.SelectedIndex
            Case 0
                'Teknik Informatika'
                biaya = 1500000
            Case 1
                'Sistem Informasi'
                biaya = 1750000
            Case 2
                'Manajemen'
                biaya = 2000000
        End Select
        Label2.Text = "Biaya Registrasi: Rp. " & biaya.ToString("N0")
    End Sub
End Class
