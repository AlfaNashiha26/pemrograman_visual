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
        txtB1 = New TextBox()
        txtB2 = New TextBox()
        txtHsl = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnHitung = New Button()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(58, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(342, 20)
        Label1.TabIndex = 0
        Label1.Text = "APLIKASI PERKALIAN DUA BILANGAN"
        ' 
        ' txtB1
        ' 
        txtB1.Location = New Point(245, 101)
        txtB1.Margin = New Padding(3, 4, 3, 4)
        txtB1.Name = "txtB1"
        txtB1.Size = New Size(100, 27)
        txtB1.TabIndex = 1
        ' 
        ' txtB2
        ' 
        txtB2.Location = New Point(245, 158)
        txtB2.Margin = New Padding(3, 4, 3, 4)
        txtB2.Name = "txtB2"
        txtB2.Size = New Size(100, 27)
        txtB2.TabIndex = 2
        ' 
        ' txtHsl
        ' 
        txtHsl.Location = New Point(245, 280)
        txtHsl.Margin = New Padding(3, 4, 3, 4)
        txtHsl.Name = "txtHsl"
        txtHsl.Size = New Size(100, 27)
        txtHsl.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(66, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 20)
        Label2.TabIndex = 4
        Label2.Text = "Bilangan Pertama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(66, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 20)
        Label3.TabIndex = 5
        Label3.Text = "Bilangan Kedua"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(69, 285)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 20)
        Label4.TabIndex = 6
        Label4.Text = "Hasil"
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(251, 216)
        btnHitung.Margin = New Padding(3, 4, 3, 4)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(88, 36)
        btnHitung.TabIndex = 7
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(58, 338)
        Label5.Name = "Label5"
        Label5.Size = New Size(315, 20)
        Label5.TabIndex = 8
        Label5.Text = "Create By. Alfa Nashiha(200511007)"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(463, 392)
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
        Text = "Perkalian - Alfa Nashiha"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtB1 As TextBox
    Friend WithEvents txtB2 As TextBox
    Friend WithEvents txtHsl As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents Label5 As Label
End Class
