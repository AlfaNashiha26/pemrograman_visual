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
        txtD1 = New TextBox()
        Label2 = New Label()
        txtD2 = New TextBox()
        Label3 = New Label()
        txtSisiA = New TextBox()
        Label4 = New Label()
        txtSisiB = New TextBox()
        Label5 = New Label()
        txtSIsiC = New TextBox()
        Label6 = New Label()
        txtSisiD = New TextBox()
        Label7 = New Label()
        btnHitung = New Button()
        txtLuas = New TextBox()
        Label8 = New Label()
        txtKeliling = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(96, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(410, 25)
        Label1.TabIndex = 0
        Label1.Text = "LUAS DAN KELILING LAYANG-LAYANG"
        ' 
        ' txtD1
        ' 
        txtD1.Location = New Point(179, 86)
        txtD1.Margin = New Padding(3, 4, 3, 4)
        txtD1.Name = "txtD1"
        txtD1.Size = New Size(100, 27)
        txtD1.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(89, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 20)
        Label2.TabIndex = 3
        Label2.Text = "Diagonal 1"
        ' 
        ' txtD2
        ' 
        txtD2.Location = New Point(179, 140)
        txtD2.Margin = New Padding(3, 4, 3, 4)
        txtD2.Name = "txtD2"
        txtD2.Size = New Size(100, 27)
        txtD2.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(89, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 20)
        Label3.TabIndex = 5
        Label3.Text = "Dianogal 2"
        ' 
        ' txtSisiA
        ' 
        txtSisiA.Location = New Point(179, 199)
        txtSisiA.Margin = New Padding(3, 4, 3, 4)
        txtSisiA.Name = "txtSisiA"
        txtSisiA.Size = New Size(100, 27)
        txtSisiA.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(89, 205)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 20)
        Label4.TabIndex = 7
        Label4.Text = "Sisi A"
        ' 
        ' txtSisiB
        ' 
        txtSisiB.Location = New Point(406, 85)
        txtSisiB.Margin = New Padding(3, 4, 3, 4)
        txtSisiB.Name = "txtSisiB"
        txtSisiB.Size = New Size(100, 27)
        txtSisiB.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(322, 92)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 20)
        Label5.TabIndex = 9
        Label5.Text = "Sisi B"
        ' 
        ' txtSIsiC
        ' 
        txtSIsiC.Location = New Point(406, 140)
        txtSIsiC.Margin = New Padding(3, 4, 3, 4)
        txtSIsiC.Name = "txtSIsiC"
        txtSIsiC.Size = New Size(100, 27)
        txtSIsiC.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(322, 148)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 20)
        Label6.TabIndex = 11
        Label6.Text = "Sisi C"
        ' 
        ' txtSisiD
        ' 
        txtSisiD.Location = New Point(406, 200)
        txtSisiD.Margin = New Padding(3, 4, 3, 4)
        txtSisiD.Name = "txtSisiD"
        txtSisiD.Size = New Size(100, 27)
        txtSisiD.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(322, 208)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 20)
        Label7.TabIndex = 13
        Label7.Text = "Sisi D"
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(240, 254)
        btnHitung.Margin = New Padding(3, 4, 3, 4)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(126, 35)
        btnHitung.TabIndex = 15
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' txtLuas
        ' 
        txtLuas.Location = New Point(179, 309)
        txtLuas.Margin = New Padding(3, 4, 3, 4)
        txtLuas.Name = "txtLuas"
        txtLuas.Size = New Size(100, 27)
        txtLuas.TabIndex = 17
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(89, 312)
        Label8.Name = "Label8"
        Label8.Size = New Size(38, 20)
        Label8.TabIndex = 16
        Label8.Text = "Luas"
        ' 
        ' txtKeliling
        ' 
        txtKeliling.Location = New Point(406, 309)
        txtKeliling.Margin = New Padding(3, 4, 3, 4)
        txtKeliling.Name = "txtKeliling"
        txtKeliling.Size = New Size(100, 27)
        txtKeliling.TabIndex = 19
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(322, 315)
        Label9.Name = "Label9"
        Label9.Size = New Size(59, 20)
        Label9.TabIndex = 18
        Label9.Text = "Keliling"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(115, 369)
        Label10.Name = "Label10"
        Label10.Size = New Size(367, 25)
        Label10.TabIndex = 20
        Label10.Text = "Create By. Alfa Nashiha(200511007)"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(617, 441)
        Controls.Add(Label10)
        Controls.Add(txtKeliling)
        Controls.Add(Label9)
        Controls.Add(txtLuas)
        Controls.Add(Label8)
        Controls.Add(btnHitung)
        Controls.Add(txtSisiD)
        Controls.Add(Label7)
        Controls.Add(txtSIsiC)
        Controls.Add(Label6)
        Controls.Add(txtSisiB)
        Controls.Add(Label5)
        Controls.Add(txtSisiA)
        Controls.Add(Label4)
        Controls.Add(txtD2)
        Controls.Add(Label3)
        Controls.Add(txtD1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "layang layang - Alfa Nashiha"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtD1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtD2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSisiA As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSisiB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSIsiC As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSisiD As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtLuas As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtKeliling As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
