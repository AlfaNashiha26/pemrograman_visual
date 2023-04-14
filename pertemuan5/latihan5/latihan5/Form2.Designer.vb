<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        btnSubmit = New Button()
        txtKeterangan = New TextBox()
        Label2 = New Label()
        txtMasaKerja = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(200, 91)
        btnSubmit.Margin = New Padding(3, 4, 3, 4)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(75, 32)
        btnSubmit.TabIndex = 9
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' txtKeterangan
        ' 
        txtKeterangan.Location = New Point(37, 175)
        txtKeterangan.Margin = New Padding(3, 4, 3, 4)
        txtKeterangan.Name = "txtKeterangan"
        txtKeterangan.Size = New Size(403, 27)
        txtKeterangan.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(34, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 20)
        Label2.TabIndex = 7
        Label2.Text = "Keterangan"
        ' 
        ' txtMasaKerja
        ' 
        txtMasaKerja.Location = New Point(37, 91)
        txtMasaKerja.Margin = New Padding(3, 4, 3, 4)
        txtMasaKerja.Name = "txtMasaKerja"
        txtMasaKerja.Size = New Size(142, 27)
        txtMasaKerja.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 20)
        Label1.TabIndex = 5
        Label1.Text = "Masa Kerja"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(34, 233)
        Label3.Name = "Label3"
        Label3.Size = New Size(180, 18)
        Label3.TabIndex = 10
        Label3.Text = " Alfa Nashiha (200711007)"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(521, 334)
        Controls.Add(Label3)
        Controls.Add(btnSubmit)
        Controls.Add(txtKeterangan)
        Controls.Add(Label2)
        Controls.Add(txtMasaKerja)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form2"
        Text = "Bonus Ulang Tahun"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMasaKerja As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
