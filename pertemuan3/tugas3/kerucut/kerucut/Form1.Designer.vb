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
        Label2 = New Label()
        Label3 = New Label()
        txtJari = New TextBox()
        txtGP = New TextBox()
        txtTinggi = New TextBox()
        Label4 = New Label()
        txtLuasp = New TextBox()
        Label5 = New Label()
        txtVol = New TextBox()
        Label6 = New Label()
        btnHitung = New Button()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(67, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(399, 20)
        Label1.TabIndex = 0
        Label1.Text = "VOLUME DAN LUAR PERMUKAAN KERUCUT"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(102, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 17)
        Label2.TabIndex = 1
        Label2.Text = "Jari-Jari"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(102, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 20)
        Label3.TabIndex = 2
        Label3.Text = "Garis Pelukis"
        ' 
        ' txtJari
        ' 
        txtJari.Location = New Point(301, 105)
        txtJari.Margin = New Padding(3, 4, 3, 4)
        txtJari.Name = "txtJari"
        txtJari.Size = New Size(100, 27)
        txtJari.TabIndex = 3
        ' 
        ' txtGP
        ' 
        txtGP.Location = New Point(301, 156)
        txtGP.Margin = New Padding(3, 4, 3, 4)
        txtGP.Name = "txtGP"
        txtGP.Size = New Size(100, 27)
        txtGP.TabIndex = 4
        ' 
        ' txtTinggi
        ' 
        txtTinggi.Location = New Point(301, 211)
        txtTinggi.Margin = New Padding(3, 4, 3, 4)
        txtTinggi.Name = "txtTinggi"
        txtTinggi.Size = New Size(100, 27)
        txtTinggi.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(102, 215)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 20)
        Label4.TabIndex = 5
        Label4.Text = "Tinggi"
        ' 
        ' txtLuasp
        ' 
        txtLuasp.Location = New Point(301, 378)
        txtLuasp.Margin = New Padding(3, 4, 3, 4)
        txtLuasp.Name = "txtLuasp"
        txtLuasp.Size = New Size(100, 27)
        txtLuasp.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(102, 381)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 20)
        Label5.TabIndex = 9
        Label5.Text = "Luas Permukaan"
        ' 
        ' txtVol
        ' 
        txtVol.Location = New Point(301, 322)
        txtVol.Margin = New Padding(3, 4, 3, 4)
        txtVol.Name = "txtVol"
        txtVol.Size = New Size(100, 27)
        txtVol.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(102, 326)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 20)
        Label6.TabIndex = 7
        Label6.Text = "Volume"
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(312, 265)
        btnHitung.Margin = New Padding(3, 4, 3, 4)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(75, 32)
        btnHitung.TabIndex = 11
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(102, 436)
        Label7.Name = "Label7"
        Label7.Size = New Size(315, 20)
        Label7.TabIndex = 12
        Label7.Text = "Create By. Alfa Nashiha(200511007)"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(557, 518)
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

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtJari As TextBox
    Friend WithEvents txtGP As TextBox
    Friend WithEvents txtTinggi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLuasp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtVol As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents Label7 As Label
End Class
