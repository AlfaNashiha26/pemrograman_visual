Imports System

Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Mengambil input dari pengguna
        Dim nim As String = txtNim.Text
        Dim nama As String = txtNama.Text
        Dim prodi As String = txtProdi.Text
        Dim kehadiran As Double = Convert.ToDouble(txtKHD.Text)
        Dim tugas As Double = Convert.ToDouble(txtTGS.Text)
        Dim uts As Double = Convert.ToDouble(txtUTS.Text)
        Dim uas As Double = Convert.ToDouble(txtUAS.Text)

        ' Menghitung nilai akhir
        Dim nilaiAkhir As Double = (0.25 * kehadiran) + (0.35 * tugas) + (0.2 * uts) + (0.2 * uas)

        ' Menentukan nilai mutu
        Dim mutu As String = ""
        If nilaiAkhir >= 85 And nilaiAkhir <= 100 Then
            mutu = "A"
        ElseIf nilaiAkhir >= 75 And nilaiAkhir < 85 Then
            mutu = "B"
        ElseIf nilaiAkhir >= 55 And nilaiAkhir < 75 Then
            mutu = "C"
        ElseIf nilaiAkhir >= 30 And nilaiAkhir < 55 Then
            mutu = "D"
        Else
            mutu = "E"
        End If

        ' Menampilkan hasil penilaian
        txtKeteranganNama.Text = nama
        txtKeteranganNIM.Text = nim
        txtKeteranganProdi.Text = prodi
        txtNilaiAkhir.Text = nilaiAkhir.ToString()
        txtNilaiMutu.Text = mutu
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Mereset semua input dan output
        txtNim.Clear()
        txtNama.Clear()
        txtProdi.Clear()
        txtKHD.Clear()
        txtTGS.Clear()
        txtUTS.Clear()
        txtUAS.Clear()
        txtKeteranganNama.Clear()
        txtKeteranganNIM.Clear()
        txtKeteranganProdi.Clear()
        txtNilaiAkhir.Clear()
        txtNilaiMutu.Clear()
    End Sub
End Class
