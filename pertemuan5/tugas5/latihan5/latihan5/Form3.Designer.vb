<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Label3 = New Label()
        btnSubmit = New Button()
        txtKeterangan = New TextBox()
        Label2 = New Label()
        txtKodeJabatan = New TextBox()
        Label1 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(49, 239)
        Label3.Name = "Label3"
        Label3.Size = New Size(180, 18)
        Label3.TabIndex = 17
        Label3.Text = " Alfa Nashiha (200711007)"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnSubmit.Location = New Point(215, 95)
        btnSubmit.Margin = New Padding(3, 4, 3, 4)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(85, 36)
        btnSubmit.TabIndex = 16
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' txtKeterangan
        ' 
        txtKeterangan.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtKeterangan.Location = New Point(52, 182)
        txtKeterangan.Margin = New Padding(3, 4, 3, 4)
        txtKeterangan.Name = "txtKeterangan"
        txtKeterangan.Size = New Size(411, 24)
        txtKeterangan.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(49, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 18)
        Label2.TabIndex = 14
        Label2.Text = "Keterangan"
        ' 
        ' txtKodeJabatan
        ' 
        txtKodeJabatan.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtKodeJabatan.Location = New Point(52, 95)
        txtKodeJabatan.Margin = New Padding(3, 4, 3, 4)
        txtKodeJabatan.Name = "txtKodeJabatan"
        txtKodeJabatan.Size = New Size(142, 24)
        txtKodeJabatan.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(49, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 18)
        Label1.TabIndex = 12
        Label1.Text = "Kode Jabatan"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(164, 29)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 18)
        Label4.TabIndex = 18
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(544, 316)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnSubmit)
        Controls.Add(txtKeterangan)
        Controls.Add(Label2)
        Controls.Add(txtKodeJabatan)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form3"
        Text = "Kode Jabatan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKodeJabatan As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
