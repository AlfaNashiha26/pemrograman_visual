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
        Label7 = New Label()
        btnHitung = New Button()
        txtLuasp = New TextBox()
        Label5 = New Label()
        txtVol = New TextBox()
        Label6 = New Label()
        txtTinggi = New TextBox()
        Label4 = New Label()
        txtGP = New TextBox()
        txtJari = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(110, 440)
        Label7.Name = "Label7"
        Label7.Size = New Size(279, 18)
        Label7.TabIndex = 25
        Label7.Text = "Create By. Alfa Nashiha(200511007)"
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(320, 269)
        btnHitung.Margin = New Padding(3, 4, 3, 4)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(75, 32)
        btnHitung.TabIndex = 24
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' txtLuasp
        ' 
        txtLuasp.Location = New Point(309, 381)
        txtLuasp.Margin = New Padding(3, 4, 3, 4)
        txtLuasp.Name = "txtLuasp"
        txtLuasp.Size = New Size(100, 27)
        txtLuasp.TabIndex = 23
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(110, 385)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 20)
        Label5.TabIndex = 22
        Label5.Text = "Luas Permukaan"
        ' 
        ' txtVol
        ' 
        txtVol.Location = New Point(309, 326)
        txtVol.Margin = New Padding(3, 4, 3, 4)
        txtVol.Name = "txtVol"
        txtVol.Size = New Size(100, 27)
        txtVol.TabIndex = 21
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(110, 330)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 20)
        Label6.TabIndex = 20
        Label6.Text = "Volume"
        ' 
        ' txtTinggi
        ' 
        txtTinggi.Location = New Point(309, 215)
        txtTinggi.Margin = New Padding(3, 4, 3, 4)
        txtTinggi.Name = "txtTinggi"
        txtTinggi.Size = New Size(100, 27)
        txtTinggi.TabIndex = 19
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(110, 219)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 20)
        Label4.TabIndex = 18
        Label4.Text = "Tinggi"
        ' 
        ' txtGP
        ' 
        txtGP.Location = New Point(309, 160)
        txtGP.Margin = New Padding(3, 4, 3, 4)
        txtGP.Name = "txtGP"
        txtGP.Size = New Size(100, 27)
        txtGP.TabIndex = 17
        ' 
        ' txtJari
        ' 
        txtJari.Location = New Point(309, 109)
        txtJari.Margin = New Padding(3, 4, 3, 4)
        txtJari.Name = "txtJari"
        txtJari.Size = New Size(100, 27)
        txtJari.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(110, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 20)
        Label3.TabIndex = 15
        Label3.Text = "Garis Pelukis"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(110, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 17)
        Label2.TabIndex = 14
        Label2.Text = "Jari-Jari"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(75, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(399, 20)
        Label1.TabIndex = 13
        Label1.Text = "VOLUME DAN LUAR PERMUKAAN KERUCUT"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(548, 521)
        Controls.Add(Label7)
        Controls.Add(btnHitung)
        Controls.Add(txtLuasp)
        Controls.Add(Label5)
        Controls.Add(txtVol)
        Controls.Add(Label6)
        Controls.Add(txtTinggi)
        Controls.Add(Label4)
        Controls.Add(txtGP)
        Controls.Add(txtJari)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Kerucut - Alfa Nashiha"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtLuasp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtVol As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTinggi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGP As TextBox
    Friend WithEvents txtJari As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
