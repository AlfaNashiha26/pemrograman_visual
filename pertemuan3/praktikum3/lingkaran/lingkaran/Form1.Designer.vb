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
        txtKeliling = New TextBox()
        Label4 = New Label()
        txtLuas = New TextBox()
        Label3 = New Label()
        btnHitung = New Button()
        txtJari = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(52, 360)
        Label5.Name = "Label5"
        Label5.Size = New Size(338, 22)
        Label5.TabIndex = 17
        Label5.Text = "Create By. Alfa Nashiha(200511007)"
        ' 
        ' txtKeliling
        ' 
        txtKeliling.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtKeliling.Location = New Point(263, 296)
        txtKeliling.Margin = New Padding(3, 4, 3, 4)
        txtKeliling.Name = "txtKeliling"
        txtKeliling.Size = New Size(100, 27)
        txtKeliling.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(103, 300)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 20)
        Label4.TabIndex = 15
        Label4.Text = "Keliling"
        ' 
        ' txtLuas
        ' 
        txtLuas.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtLuas.Location = New Point(263, 242)
        txtLuas.Margin = New Padding(3, 4, 3, 4)
        txtLuas.Name = "txtLuas"
        txtLuas.Size = New Size(100, 27)
        txtLuas.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(103, 246)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 13
        Label3.Text = "Luas"
        ' 
        ' btnHitung
        ' 
        btnHitung.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        btnHitung.Location = New Point(273, 176)
        btnHitung.Margin = New Padding(3, 4, 3, 4)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(79, 44)
        btnHitung.TabIndex = 12
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' txtJari
        ' 
        txtJari.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtJari.Location = New Point(263, 120)
        txtJari.Margin = New Padding(3, 4, 3, 4)
        txtJari.Name = "txtJari"
        txtJari.Size = New Size(100, 27)
        txtJari.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(103, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 20)
        Label2.TabIndex = 10
        Label2.Text = "Jari-Jari"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(78, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(319, 22)
        Label1.TabIndex = 9
        Label1.Text = "LUAS DAN KELILING LINGKARAN"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(478, 442)
        Controls.Add(Label5)
        Controls.Add(txtKeliling)
        Controls.Add(Label4)
        Controls.Add(txtLuas)
        Controls.Add(Label3)
        Controls.Add(btnHitung)
        Controls.Add(txtJari)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Lingkaran - Alfa Nashiha"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txtKeliling As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLuas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtJari As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
