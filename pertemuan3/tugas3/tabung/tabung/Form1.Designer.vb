﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        txtJari = New TextBox()
        txtTi = New TextBox()
        Label3 = New Label()
        txtVol = New TextBox()
        Label4 = New Label()
        txtLuasP = New TextBox()
        Label5 = New Label()
        btnHitung = New Button()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(74, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(387, 20)
        Label1.TabIndex = 0
        Label1.Text = "VOLUME DAN LUAS PERMUKAAN TABUNG"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(110, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 20)
        Label2.TabIndex = 1
        Label2.Text = "Jari-Jari"
        ' 
        ' txtJari
        ' 
        txtJari.Location = New Point(306, 84)
        txtJari.Margin = New Padding(3, 4, 3, 4)
        txtJari.Name = "txtJari"
        txtJari.Size = New Size(100, 27)
        txtJari.TabIndex = 2
        ' 
        ' txtTi
        ' 
        txtTi.Location = New Point(306, 136)
        txtTi.Margin = New Padding(3, 4, 3, 4)
        txtTi.Name = "txtTi"
        txtTi.Size = New Size(100, 27)
        txtTi.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(110, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 20)
        Label3.TabIndex = 3
        Label3.Text = "Tinggi"
        ' 
        ' txtVol
        ' 
        txtVol.Location = New Point(306, 252)
        txtVol.Margin = New Padding(3, 4, 3, 4)
        txtVol.Name = "txtVol"
        txtVol.Size = New Size(100, 27)
        txtVol.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(110, 259)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 20)
        Label4.TabIndex = 5
        Label4.Text = "Volume"
        ' 
        ' txtLuasP
        ' 
        txtLuasP.Location = New Point(306, 311)
        txtLuasP.Margin = New Padding(3, 4, 3, 4)
        txtLuasP.Name = "txtLuasP"
        txtLuasP.Size = New Size(100, 27)
        txtLuasP.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(110, 318)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 20)
        Label5.TabIndex = 7
        Label5.Text = "Luas Permukaan"
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(317, 189)
        btnHitung.Margin = New Padding(3, 4, 3, 4)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(75, 35)
        btnHitung.TabIndex = 9
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(92, 370)
        Label6.Name = "Label6"
        Label6.Size = New Size(315, 20)
        Label6.TabIndex = 10
        Label6.Text = "Create By. Alfa Nashiha(200511007)"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(565, 424)
        Controls.Add(Label6)
        Controls.Add(btnHitung)
        Controls.Add(txtLuasP)
        Controls.Add(Label5)
        Controls.Add(txtVol)
        Controls.Add(Label4)
        Controls.Add(txtTi)
        Controls.Add(Label3)
        Controls.Add(txtJari)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Tabung - Alfa Nashiha"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtJari As TextBox
    Friend WithEvents txtTi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtVol As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLuasP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents Label6 As Label
End Class
