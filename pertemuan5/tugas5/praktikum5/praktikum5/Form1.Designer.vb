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
        txtNoUndian = New TextBox()
        txtKeterangan = New TextBox()
        Label2 = New Label()
        btnSubmit = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(29, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 18)
        Label1.TabIndex = 0
        Label1.Text = "Nomor Undian"
        ' 
        ' txtNoUndian
        ' 
        txtNoUndian.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtNoUndian.Location = New Point(32, 51)
        txtNoUndian.Margin = New Padding(3, 4, 3, 4)
        txtNoUndian.Name = "txtNoUndian"
        txtNoUndian.Size = New Size(142, 24)
        txtNoUndian.TabIndex = 1
        ' 
        ' txtKeterangan
        ' 
        txtKeterangan.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtKeterangan.Location = New Point(32, 124)
        txtKeterangan.Margin = New Padding(3, 4, 3, 4)
        txtKeterangan.Name = "txtKeterangan"
        txtKeterangan.Size = New Size(411, 24)
        txtKeterangan.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(29, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 18)
        Label2.TabIndex = 2
        Label2.Text = "Keterangan"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnSubmit.Location = New Point(195, 51)
        btnSubmit.Margin = New Padding(3, 4, 3, 4)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(85, 36)
        btnSubmit.TabIndex = 4
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Modern No. 20", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(246, 190)
        Label3.Name = "Label3"
        Label3.Size = New Size(242, 22)
        Label3.TabIndex = 11
        Label3.Text = "Alfa Nashiha (200511007)"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(500, 232)
        Controls.Add(Label3)
        Controls.Add(btnSubmit)
        Controls.Add(txtKeterangan)
        Controls.Add(Label2)
        Controls.Add(txtNoUndian)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Hadiah Undian 17 Agustus"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNoUndian As TextBox
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label3 As Label
End Class
