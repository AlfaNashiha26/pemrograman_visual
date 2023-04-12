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
        btnHitung = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtHsl = New TextBox()
        txtB2 = New TextBox()
        txtB1 = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(62, 354)
        Label5.Name = "Label5"
        Label5.Size = New Size(315, 20)
        Label5.TabIndex = 17
        Label5.Text = "Create By. Alfa Nashiha(200511007)"
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(255, 232)
        btnHitung.Margin = New Padding(3, 4, 3, 4)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(88, 36)
        btnHitung.TabIndex = 16
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(73, 301)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 20)
        Label4.TabIndex = 15
        Label4.Text = "Hasil"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(70, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 20)
        Label3.TabIndex = 14
        Label3.Text = "Bilangan Kedua"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(70, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 20)
        Label2.TabIndex = 13
        Label2.Text = "Bilangan Pertama"
        ' 
        ' txtHsl
        ' 
        txtHsl.Location = New Point(249, 296)
        txtHsl.Margin = New Padding(3, 4, 3, 4)
        txtHsl.Name = "txtHsl"
        txtHsl.Size = New Size(100, 27)
        txtHsl.TabIndex = 12
        ' 
        ' txtB2
        ' 
        txtB2.Location = New Point(249, 174)
        txtB2.Margin = New Padding(3, 4, 3, 4)
        txtB2.Name = "txtB2"
        txtB2.Size = New Size(100, 27)
        txtB2.TabIndex = 11
        ' 
        ' txtB1
        ' 
        txtB1.Location = New Point(249, 118)
        txtB1.Margin = New Padding(3, 4, 3, 4)
        txtB1.Name = "txtB1"
        txtB1.Size = New Size(100, 27)
        txtB1.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(62, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(377, 20)
        Label1.TabIndex = 9
        Label1.Text = "APLIKASI PENJUMLAHAN DUA BILANGAN"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(512, 425)
        Controls.Add(Label5)
        Controls.Add(btnHitung)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtHsl)
        Controls.Add(txtB2)
        Controls.Add(txtB1)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Penjumlahan - Alfa Nashiha"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHsl As TextBox
    Friend WithEvents txtB2 As TextBox
    Friend WithEvents txtB1 As TextBox
    Friend WithEvents Label1 As Label
End Class
