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
        txtSisi = New TextBox()
        txtVolum = New TextBox()
        Label2 = New Label()
        txtLuasP = New TextBox()
        Label3 = New Label()
        btnHitung = New Button()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(82, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 20)
        Label1.TabIndex = 0
        Label1.Text = "Sisi"
        ' 
        ' txtSisi
        ' 
        txtSisi.Location = New Point(238, 101)
        txtSisi.Margin = New Padding(3, 4, 3, 4)
        txtSisi.Name = "txtSisi"
        txtSisi.Size = New Size(100, 27)
        txtSisi.TabIndex = 1
        ' 
        ' txtVolum
        ' 
        txtVolum.Location = New Point(238, 229)
        txtVolum.Margin = New Padding(3, 4, 3, 4)
        txtVolum.Name = "txtVolum"
        txtVolum.Size = New Size(100, 27)
        txtVolum.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(82, 229)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 20)
        Label2.TabIndex = 2
        Label2.Text = "Volume"
        ' 
        ' txtLuasP
        ' 
        txtLuasP.Location = New Point(238, 275)
        txtLuasP.Margin = New Padding(3, 4, 3, 4)
        txtLuasP.Name = "txtLuasP"
        txtLuasP.Size = New Size(100, 27)
        txtLuasP.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(82, 275)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 20)
        Label3.TabIndex = 4
        Label3.Text = "Luas Permukaan"
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(238, 169)
        btnHitung.Margin = New Padding(3, 4, 3, 4)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(91, 36)
        btnHitung.TabIndex = 6
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(41, 42)
        Label4.Name = "Label4"
        Label4.Size = New Size(374, 20)
        Label4.TabIndex = 7
        Label4.Text = "VOLUME DAN LUAS PERMUKAAN KUBUS"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(55, 329)
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
        ClientSize = New Size(495, 392)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnHitung)
        Controls.Add(txtLuasP)
        Controls.Add(Label3)
        Controls.Add(txtVolum)
        Controls.Add(Label2)
        Controls.Add(txtSisi)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Kubus - Alfa Nashiha"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSisi As TextBox
    Friend WithEvents txtVolum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLuasP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
