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
        Label5 = New Label()
        Label4 = New Label()
        btnHitung = New Button()
        txtLuasp = New TextBox()
        Label3 = New Label()
        txtVol = New TextBox()
        txtJari = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(55, 345)
        Label5.Name = "Label5"
        Label5.Size = New Size(315, 20)
        Label5.TabIndex = 17
        Label5.Text = "Create By. Alfa Nashiha(200511007)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(98, 39)
        Label4.Name = "Label4"
        Label4.Size = New Size(241, 20)
        Label4.TabIndex = 16
        Label4.Text = "VOLUME DAN LUAS BOLA"
        ' 
        ' btnHitung
        ' 
        btnHitung.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnHitung.Location = New Point(253, 158)
        btnHitung.Margin = New Padding(3, 4, 3, 4)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(77, 36)
        btnHitung.TabIndex = 15
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' txtLuasp
        ' 
        txtLuasp.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtLuasp.Location = New Point(243, 269)
        txtLuasp.Margin = New Padding(3, 4, 3, 4)
        txtLuasp.Name = "txtLuasp"
        txtLuasp.Size = New Size(100, 24)
        txtLuasp.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(84, 269)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 18)
        Label3.TabIndex = 13
        Label3.Text = "Luas Permukaan"
        ' 
        ' txtVol
        ' 
        txtVol.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtVol.Location = New Point(243, 219)
        txtVol.Margin = New Padding(3, 4, 3, 4)
        txtVol.Name = "txtVol"
        txtVol.Size = New Size(100, 24)
        txtVol.TabIndex = 12
        ' 
        ' txtJari
        ' 
        txtJari.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtJari.Location = New Point(243, 98)
        txtJari.Margin = New Padding(3, 4, 3, 4)
        txtJari.Name = "txtJari"
        txtJari.Size = New Size(100, 24)
        txtJari.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(84, 219)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 18)
        Label2.TabIndex = 10
        Label2.Text = "Volume"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(84, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 18)
        Label1.TabIndex = 9
        Label1.Text = "Jari-jari"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(479, 434)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnHitung)
        Controls.Add(txtLuasp)
        Controls.Add(Label3)
        Controls.Add(txtVol)
        Controls.Add(txtJari)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Bola - Alfa Nashiha"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtLuasp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtVol As TextBox
    Friend WithEvents txtJari As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
