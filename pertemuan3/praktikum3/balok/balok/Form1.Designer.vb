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
        txtP = New TextBox()
        txtL = New TextBox()
        Label3 = New Label()
        txtT = New TextBox()
        Label4 = New Label()
        txtVolum = New TextBox()
        Label5 = New Label()
        txtLuasP = New TextBox()
        Label6 = New Label()
        btnHitung = New Button()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(64, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(373, 20)
        Label1.TabIndex = 0
        Label1.Text = "VOLUME DAN LUAS PERMUKAAN BALOK"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(74, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 20)
        Label2.TabIndex = 1
        Label2.Text = "Panjang"
        ' 
        ' txtP
        ' 
        txtP.Location = New Point(259, 99)
        txtP.Margin = New Padding(3, 4, 3, 4)
        txtP.Name = "txtP"
        txtP.Size = New Size(100, 27)
        txtP.TabIndex = 2
        ' 
        ' txtL
        ' 
        txtL.Location = New Point(259, 149)
        txtL.Margin = New Padding(3, 4, 3, 4)
        txtL.Name = "txtL"
        txtL.Size = New Size(100, 27)
        txtL.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(74, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 3
        Label3.Text = "Lebar"
        ' 
        ' txtT
        ' 
        txtT.Location = New Point(259, 201)
        txtT.Margin = New Padding(3, 4, 3, 4)
        txtT.Name = "txtT"
        txtT.Size = New Size(100, 27)
        txtT.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(74, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 20)
        Label4.TabIndex = 5
        Label4.Text = "Tinggi"
        ' 
        ' txtVolum
        ' 
        txtVolum.Location = New Point(259, 311)
        txtVolum.Margin = New Padding(3, 4, 3, 4)
        txtVolum.Name = "txtVolum"
        txtVolum.Size = New Size(100, 27)
        txtVolum.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(74, 318)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 20)
        Label5.TabIndex = 7
        Label5.Text = "Volume"
        ' 
        ' txtLuasP
        ' 
        txtLuasP.Location = New Point(259, 370)
        txtLuasP.Margin = New Padding(3, 4, 3, 4)
        txtLuasP.Name = "txtLuasP"
        txtLuasP.Size = New Size(100, 27)
        txtLuasP.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(74, 376)
        Label6.Name = "Label6"
        Label6.Size = New Size(114, 20)
        Label6.TabIndex = 9
        Label6.Text = "Luas Permukaan"
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(269, 254)
        btnHitung.Margin = New Padding(3, 4, 3, 4)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(77, 32)
        btnHitung.TabIndex = 11
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(80, 434)
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
        ClientSize = New Size(530, 494)
        Controls.Add(Label7)
        Controls.Add(btnHitung)
        Controls.Add(txtLuasP)
        Controls.Add(Label6)
        Controls.Add(txtVolum)
        Controls.Add(Label5)
        Controls.Add(txtT)
        Controls.Add(Label4)
        Controls.Add(txtL)
        Controls.Add(Label3)
        Controls.Add(txtP)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Balok - Alfa Nashiha"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtP As TextBox
    Friend WithEvents txtL As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVolum As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLuasP As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents Label7 As Label
End Class
