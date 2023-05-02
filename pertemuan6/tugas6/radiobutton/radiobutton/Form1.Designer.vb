Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

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
        rbAnak = New Windows.Forms.RadioButton()
        rbDewasa = New Windows.Forms.RadioButton()
        btnHitung = New Button()
        txtHarga = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 31)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 20)
        Label1.TabIndex = 0
        Label1.Text = "Pilih Kategori"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(16, 282)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 1
        Label2.Text = "Harga Tiket:"
        ' 
        ' rbAnak
        ' 
        rbAnak.AutoSize = True
        rbAnak.Location = New Point(20, 75)
        rbAnak.Margin = New Padding(4, 5, 4, 5)
        rbAnak.Name = "rbAnak"
        rbAnak.Size = New Size(63, 24)
        rbAnak.TabIndex = 2
        rbAnak.TabStop = True
        rbAnak.Text = "Anak"
        rbAnak.UseVisualStyleBackColor = True
        ' 
        ' rbDewasa
        ' 
        rbDewasa.AutoSize = True
        rbDewasa.Location = New Point(20, 128)
        rbDewasa.Margin = New Padding(4, 5, 4, 5)
        rbDewasa.Name = "rbDewasa"
        rbDewasa.Size = New Size(82, 24)
        rbDewasa.TabIndex = 3
        rbDewasa.TabStop = True
        rbDewasa.Text = "Dewasa"
        rbDewasa.UseVisualStyleBackColor = True
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(20, 198)
        btnHitung.Margin = New Padding(4, 5, 4, 5)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(100, 35)
        btnHitung.TabIndex = 4
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(115, 277)
        txtHarga.Margin = New Padding(4, 5, 4, 5)
        txtHarga.Name = "txtHarga"
        txtHarga.ReadOnly = True
        txtHarga.Size = New Size(132, 27)
        txtHarga.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Stencil", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(68, 373)
        Label3.Name = "Label3"
        Label3.Size = New Size(268, 24)
        Label3.TabIndex = 6
        Label3.Text = "Alfa Nashiha (200511007)"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(409, 406)
        Controls.Add(Label3)
        Controls.Add(txtHarga)
        Controls.Add(btnHitung)
        Controls.Add(rbDewasa)
        Controls.Add(rbAnak)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        Text = "Harga Tiket Wisata, By. Alfa Nashiha"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rbAnak As Windows.Forms.RadioButton
    Friend WithEvents rbDewasa As Windows.Forms.RadioButton
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label3 As Label
End Class