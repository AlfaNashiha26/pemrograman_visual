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
        Label10 = New Label()
        Label9 = New Label()
        btnHitung = New Button()
        txtLuasP = New TextBox()
        Label8 = New Label()
        txtVolum = New TextBox()
        Label7 = New Label()
        txtSisi = New TextBox()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(65, 358)
        Label10.Name = "Label10"
        Label10.Size = New Size(315, 20)
        Label10.TabIndex = 17
        Label10.Text = "Create By. Alfa Nashiha(200511007)"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(51, 71)
        Label9.Name = "Label9"
        Label9.Size = New Size(374, 20)
        Label9.TabIndex = 16
        Label9.Text = "VOLUME DAN LUAS PERMUKAAN KUBUS"
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(248, 198)
        btnHitung.Margin = New Padding(3, 4, 3, 4)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(91, 36)
        btnHitung.TabIndex = 15
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' txtLuasP
        ' 
        txtLuasP.Location = New Point(248, 304)
        txtLuasP.Margin = New Padding(3, 4, 3, 4)
        txtLuasP.Name = "txtLuasP"
        txtLuasP.Size = New Size(100, 27)
        txtLuasP.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(92, 304)
        Label8.Name = "Label8"
        Label8.Size = New Size(114, 20)
        Label8.TabIndex = 13
        Label8.Text = "Luas Permukaan"
        ' 
        ' txtVolum
        ' 
        txtVolum.Location = New Point(248, 258)
        txtVolum.Margin = New Padding(3, 4, 3, 4)
        txtVolum.Name = "txtVolum"
        txtVolum.Size = New Size(100, 27)
        txtVolum.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(92, 258)
        Label7.Name = "Label7"
        Label7.Size = New Size(59, 20)
        Label7.TabIndex = 11
        Label7.Text = "Volume"
        ' 
        ' txtSisi
        ' 
        txtSisi.Location = New Point(248, 130)
        txtSisi.Margin = New Padding(3, 4, 3, 4)
        txtSisi.Name = "txtSisi"
        txtSisi.Size = New Size(100, 27)
        txtSisi.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(92, 130)
        Label6.Name = "Label6"
        Label6.Size = New Size(31, 20)
        Label6.TabIndex = 9
        Label6.Text = "Sisi"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(476, 452)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(btnHitung)
        Controls.Add(txtLuasP)
        Controls.Add(Label8)
        Controls.Add(txtVolum)
        Controls.Add(Label7)
        Controls.Add(txtSisi)
        Controls.Add(Label6)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Kubus - Alfa Nashiha"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtLuasP As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtVolum As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSisi As TextBox
    Friend WithEvents Label6 As Label
End Class
