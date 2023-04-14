<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtNama = New TextBox()
        txtNim = New TextBox()
        Label2 = New Label()
        btnSubmit = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        txtProdi = New TextBox()
        txtKHD = New TextBox()
        txtTGS = New TextBox()
        txtUTS = New TextBox()
        txtUAS = New TextBox()
        Label10 = New Label()
        txtKeteranganProdi = New TextBox()
        Label11 = New Label()
        txtKeteranganNIM = New TextBox()
        Label12 = New Label()
        txtKeteranganNama = New TextBox()
        Label13 = New Label()
        txtNilaiMutu = New TextBox()
        Label14 = New Label()
        txtNilaiAkhir = New TextBox()
        Label15 = New Label()
        btnReset = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(123, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 17)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtNama.Location = New Point(32, 110)
        txtNama.Margin = New Padding(3, 4, 3, 4)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(232, 24)
        txtNama.TabIndex = 1
        ' 
        ' txtNim
        ' 
        txtNim.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtNim.Location = New Point(32, 170)
        txtNim.Margin = New Padding(3, 4, 3, 4)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(232, 24)
        txtNim.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(123, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 17)
        Label2.TabIndex = 2
        Label2.Text = "NIM"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.DeepSkyBlue
        btnSubmit.Font = New Font("Times New Roman", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnSubmit.ForeColor = SystemColors.ControlText
        btnSubmit.Location = New Point(105, 350)
        btnSubmit.Margin = New Padding(3, 4, 3, 4)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(159, 36)
        btnSubmit.TabIndex = 4
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Modern No. 20", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(222, 664)
        Label3.Name = "Label3"
        Label3.Size = New Size(275, 25)
        Label3.TabIndex = 11
        Label3.Text = "Alfa Nashiha (200511007)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(12, 38)
        Label4.Name = "Label4"
        Label4.Size = New Size(516, 29)
        Label4.TabIndex = 12
        Label4.Text = "Aplikasi Penentuan Nilai Mutu Mahasiswa"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(123, 213)
        Label5.Name = "Label5"
        Label5.Size = New Size(39, 17)
        Label5.TabIndex = 13
        Label5.Text = "Prodi"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(351, 89)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 17)
        Label6.TabIndex = 14
        Label6.Text = "Nilai Kehadiran"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(361, 149)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 17)
        Label7.TabIndex = 15
        Label7.Text = "Nilai Tugas"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(368, 213)
        Label8.Name = "Label8"
        Label8.Size = New Size(67, 17)
        Label8.TabIndex = 16
        Label8.Text = "Nilai UTS"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Times New Roman", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(366, 276)
        Label9.Name = "Label9"
        Label9.Size = New Size(69, 17)
        Label9.TabIndex = 17
        Label9.Text = "Nilai UAS"
        ' 
        ' txtProdi
        ' 
        txtProdi.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtProdi.Location = New Point(32, 234)
        txtProdi.Margin = New Padding(3, 4, 3, 4)
        txtProdi.Name = "txtProdi"
        txtProdi.Size = New Size(232, 24)
        txtProdi.TabIndex = 18
        ' 
        ' txtKHD
        ' 
        txtKHD.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtKHD.Location = New Point(286, 110)
        txtKHD.Margin = New Padding(3, 4, 3, 4)
        txtKHD.Name = "txtKHD"
        txtKHD.Size = New Size(232, 24)
        txtKHD.TabIndex = 19
        ' 
        ' txtTGS
        ' 
        txtTGS.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtTGS.Location = New Point(286, 170)
        txtTGS.Margin = New Padding(3, 4, 3, 4)
        txtTGS.Name = "txtTGS"
        txtTGS.Size = New Size(232, 24)
        txtTGS.TabIndex = 20
        ' 
        ' txtUTS
        ' 
        txtUTS.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtUTS.Location = New Point(286, 234)
        txtUTS.Margin = New Padding(3, 4, 3, 4)
        txtUTS.Name = "txtUTS"
        txtUTS.Size = New Size(232, 24)
        txtUTS.TabIndex = 21
        ' 
        ' txtUAS
        ' 
        txtUAS.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtUAS.Location = New Point(286, 297)
        txtUAS.Margin = New Padding(3, 4, 3, 4)
        txtUAS.Name = "txtUAS"
        txtUAS.Size = New Size(232, 24)
        txtUAS.TabIndex = 22
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(32, 409)
        Label10.Name = "Label10"
        Label10.Size = New Size(480, 29)
        Label10.TabIndex = 23
        Label10.Text = "Hasil Penentuan Nilai Mutu Mahasiswa"
        ' 
        ' txtKeteranganProdi
        ' 
        txtKeteranganProdi.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtKeteranganProdi.Location = New Point(168, 537)
        txtKeteranganProdi.Margin = New Padding(3, 4, 3, 4)
        txtKeteranganProdi.Name = "txtKeteranganProdi"
        txtKeteranganProdi.Size = New Size(232, 24)
        txtKeteranganProdi.TabIndex = 29
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Times New Roman", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(246, 516)
        Label11.Name = "Label11"
        Label11.Size = New Size(112, 17)
        Label11.TabIndex = 28
        Label11.Text = "Keterangan Prodi"
        ' 
        ' txtKeteranganNIM
        ' 
        txtKeteranganNIM.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtKeteranganNIM.Location = New Point(286, 478)
        txtKeteranganNIM.Margin = New Padding(3, 4, 3, 4)
        txtKeteranganNIM.Name = "txtKeteranganNIM"
        txtKeteranganNIM.Size = New Size(232, 24)
        txtKeteranganNIM.TabIndex = 27
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Times New Roman", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(341, 457)
        Label12.Name = "Label12"
        Label12.Size = New Size(110, 17)
        Label12.TabIndex = 26
        Label12.Text = "Keterangan NIM"
        ' 
        ' txtKeteranganNama
        ' 
        txtKeteranganNama.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtKeteranganNama.Location = New Point(32, 478)
        txtKeteranganNama.Margin = New Padding(3, 4, 3, 4)
        txtKeteranganNama.Name = "txtKeteranganNama"
        txtKeteranganNama.Size = New Size(232, 24)
        txtKeteranganNama.TabIndex = 25
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Times New Roman", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(94, 457)
        Label13.Name = "Label13"
        Label13.Size = New Size(117, 17)
        Label13.TabIndex = 24
        Label13.Text = "Keterangan Nama"
        ' 
        ' txtNilaiMutu
        ' 
        txtNilaiMutu.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtNilaiMutu.Location = New Point(286, 602)
        txtNilaiMutu.Margin = New Padding(3, 4, 3, 4)
        txtNilaiMutu.Name = "txtNilaiMutu"
        txtNilaiMutu.Size = New Size(232, 24)
        txtNilaiMutu.TabIndex = 33
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Times New Roman", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(365, 581)
        Label14.Name = "Label14"
        Label14.Size = New Size(70, 17)
        Label14.TabIndex = 32
        Label14.Text = "Nilai Mutu"
        ' 
        ' txtNilaiAkhir
        ' 
        txtNilaiAkhir.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtNilaiAkhir.Location = New Point(32, 602)
        txtNilaiAkhir.Margin = New Padding(3, 4, 3, 4)
        txtNilaiAkhir.Name = "txtNilaiAkhir"
        txtNilaiAkhir.Size = New Size(232, 24)
        txtNilaiAkhir.TabIndex = 31
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Times New Roman", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(110, 581)
        Label15.Name = "Label15"
        Label15.Size = New Size(71, 17)
        Label15.TabIndex = 30
        Label15.Text = "Nilai Akhir"
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.Red
        btnReset.Font = New Font("Times New Roman", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnReset.ForeColor = SystemColors.Control
        btnReset.Location = New Point(286, 350)
        btnReset.Margin = New Padding(3, 4, 3, 4)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(159, 36)
        btnReset.TabIndex = 34
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(548, 711)
        Controls.Add(btnReset)
        Controls.Add(txtNilaiMutu)
        Controls.Add(Label14)
        Controls.Add(txtNilaiAkhir)
        Controls.Add(Label15)
        Controls.Add(txtKeteranganProdi)
        Controls.Add(Label11)
        Controls.Add(txtKeteranganNIM)
        Controls.Add(Label12)
        Controls.Add(txtKeteranganNama)
        Controls.Add(Label13)
        Controls.Add(Label10)
        Controls.Add(txtUAS)
        Controls.Add(txtUTS)
        Controls.Add(txtTGS)
        Controls.Add(txtKHD)
        Controls.Add(txtProdi)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnSubmit)
        Controls.Add(txtNim)
        Controls.Add(Label2)
        Controls.Add(txtNama)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Aplikasi Penilaian Angka Mutu Mahasiswa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtProdi As TextBox
    Friend WithEvents txtKHD As TextBox
    Friend WithEvents txtTGS As TextBox
    Friend WithEvents txtUTS As TextBox
    Friend WithEvents txtUAS As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtKeteranganProdi As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtKeteranganNIM As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtKeteranganNama As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNilaiMutu As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtNilaiAkhir As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnReset As Button
End Class
