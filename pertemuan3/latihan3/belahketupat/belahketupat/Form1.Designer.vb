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
        txtD1 = New TextBox()
        txtD2 = New TextBox()
        Label3 = New Label()
        txtSisi = New TextBox()
        Label4 = New Label()
        txtLuas = New TextBox()
        Label5 = New Label()
        txtKeliling = New TextBox()
        Label6 = New Label()
        btnHitung = New Button()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(65, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(405, 25)
        Label1.TabIndex = 0
        Label1.Text = "LUAS DAN KELILING BELAH KETUPAT"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(67, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 18)
        Label2.TabIndex = 1
        Label2.Text = "Diagonal1"
        ' 
        ' txtD1
        ' 
        txtD1.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtD1.Location = New Point(153, 104)
        txtD1.Margin = New Padding(3, 4, 3, 4)
        txtD1.Name = "txtD1"
        txtD1.Size = New Size(100, 24)
        txtD1.TabIndex = 2
        ' 
        ' txtD2
        ' 
        txtD2.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtD2.Location = New Point(154, 169)
        txtD2.Margin = New Padding(3, 4, 3, 4)
        txtD2.Name = "txtD2"
        txtD2.Size = New Size(100, 24)
        txtD2.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(67, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 18)
        Label3.TabIndex = 3
        Label3.Text = "Diagonal 2"
        ' 
        ' txtSisi
        ' 
        txtSisi.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtSisi.Location = New Point(355, 104)
        txtSisi.Margin = New Padding(3, 4, 3, 4)
        txtSisi.Name = "txtSisi"
        txtSisi.Size = New Size(100, 24)
        txtSisi.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(296, 110)
        Label4.Name = "Label4"
        Label4.Size = New Size(32, 18)
        Label4.TabIndex = 5
        Label4.Text = "Sisi"
        ' 
        ' txtLuas
        ' 
        txtLuas.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtLuas.Location = New Point(251, 319)
        txtLuas.Margin = New Padding(3, 4, 3, 4)
        txtLuas.Name = "txtLuas"
        txtLuas.Size = New Size(100, 24)
        txtLuas.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(164, 325)
        Label5.Name = "Label5"
        Label5.Size = New Size(40, 18)
        Label5.TabIndex = 7
        Label5.Text = "Luas"
        ' 
        ' txtKeliling
        ' 
        txtKeliling.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtKeliling.Location = New Point(251, 370)
        txtKeliling.Margin = New Padding(3, 4, 3, 4)
        txtKeliling.Name = "txtKeliling"
        txtKeliling.Size = New Size(100, 24)
        txtKeliling.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(164, 374)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 18)
        Label6.TabIndex = 9
        Label6.Text = "Keliling"
        ' 
        ' btnHitung
        ' 
        btnHitung.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnHitung.Location = New Point(202, 236)
        btnHitung.Margin = New Padding(3, 4, 3, 4)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(115, 45)
        btnHitung.TabIndex = 11
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(65, 459)
        Label7.Name = "Label7"
        Label7.Size = New Size(367, 25)
        Label7.TabIndex = 12
        Label7.Text = "Create By. Alfa Nashiha(200511007)"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        ClientSize = New Size(544, 552)
        Controls.Add(Label7)
        Controls.Add(btnHitung)
        Controls.Add(txtKeliling)
        Controls.Add(Label6)
        Controls.Add(txtLuas)
        Controls.Add(Label5)
        Controls.Add(txtSisi)
        Controls.Add(Label4)
        Controls.Add(txtD2)
        Controls.Add(Label3)
        Controls.Add(txtD1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = SystemColors.InfoText
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Belah Ketupat - Alfa Nashiha"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtD1 As TextBox
    Friend WithEvents txtD2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSisi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLuas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtKeliling As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents Label7 As Label
End Class
