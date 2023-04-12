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
        txtPanjang = New TextBox()
        txtLebar = New TextBox()
        Label2 = New Label()
        txtLuas = New TextBox()
        Label3 = New Label()
        txtKeliling = New TextBox()
        Label4 = New Label()
        btnHitung = New Button()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(101, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 20)
        Label1.TabIndex = 0
        Label1.Text = "Panjang"
        ' 
        ' txtPanjang
        ' 
        txtPanjang.Location = New Point(181, 92)
        txtPanjang.Margin = New Padding(3, 4, 3, 4)
        txtPanjang.Name = "txtPanjang"
        txtPanjang.Size = New Size(100, 27)
        txtPanjang.TabIndex = 1
        ' 
        ' txtLebar
        ' 
        txtLebar.Location = New Point(181, 148)
        txtLebar.Margin = New Padding(3, 4, 3, 4)
        txtLebar.Name = "txtLebar"
        txtLebar.Size = New Size(100, 27)
        txtLebar.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(101, 151)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 2
        Label2.Text = "Lebar"
        ' 
        ' txtLuas
        ' 
        txtLuas.Location = New Point(181, 251)
        txtLuas.Margin = New Padding(3, 4, 3, 4)
        txtLuas.Name = "txtLuas"
        txtLuas.Size = New Size(100, 27)
        txtLuas.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(101, 252)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 20)
        Label3.TabIndex = 4
        Label3.Text = "Luas"
        ' 
        ' txtKeliling
        ' 
        txtKeliling.Location = New Point(181, 300)
        txtKeliling.Margin = New Padding(3, 4, 3, 4)
        txtKeliling.Name = "txtKeliling"
        txtKeliling.Size = New Size(100, 27)
        txtKeliling.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(101, 302)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 20)
        Label4.TabIndex = 6
        Label4.Text = "Keliling"
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(191, 196)
        btnHitung.Margin = New Padding(3, 4, 3, 4)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(75, 41)
        btnHitung.TabIndex = 8
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(39, 38)
        Label5.Name = "Label5"
        Label5.Size = New Size(369, 20)
        Label5.TabIndex = 9
        Label5.Text = "LUAS DAN KELILING PERSEGI PANJANG"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(58, 359)
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
        ClientSize = New Size(457, 428)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(btnHitung)
        Controls.Add(txtKeliling)
        Controls.Add(Label4)
        Controls.Add(txtLuas)
        Controls.Add(Label3)
        Controls.Add(txtLebar)
        Controls.Add(Label2)
        Controls.Add(txtPanjang)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Persegi panjang - Alfa Nashiha"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPanjang As TextBox
    Friend WithEvents txtLebar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLuas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKeliling As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
