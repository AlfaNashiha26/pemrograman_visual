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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtProdi = New System.Windows.Forms.TextBox()
        Me.txtSKS = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(417, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alfa Nashiha (200511007) TIF20R3"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(550, 154)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(116, 30)
        Me.btnHapus.TabIndex = 23
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(550, 116)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(116, 31)
        Me.btnSimpan.TabIndex = 22
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(550, 77)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(116, 29)
        Me.btnReset.TabIndex = 21
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtProdi
        '
        Me.txtProdi.Location = New System.Drawing.Point(139, 188)
        Me.txtProdi.Name = "txtProdi"
        Me.txtProdi.Size = New System.Drawing.Size(302, 22)
        Me.txtProdi.TabIndex = 20
        '
        'txtSKS
        '
        Me.txtSKS.Location = New System.Drawing.Point(139, 149)
        Me.txtSKS.Name = "txtSKS"
        Me.txtSKS.Size = New System.Drawing.Size(302, 22)
        Me.txtSKS.TabIndex = 19
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(139, 114)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(302, 22)
        Me.txtNama.TabIndex = 18
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(139, 75)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(302, 22)
        Me.txtKode.TabIndex = 17
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(12, 188)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(48, 20)
        Me.label5.TabIndex = 16
        Me.label5.Text = "Prodi"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(12, 151)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(42, 20)
        Me.label4.TabIndex = 15
        Me.label4.Text = "SKS"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(12, 116)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(83, 20)
        Me.label3.TabIndex = 14
        Me.label3.Text = "Nama MK"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(12, 80)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(77, 20)
        Me.label2.TabIndex = 13
        Me.label2.Text = "Kode MK"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 232)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(638, 255)
        Me.DataGridView1.TabIndex = 24
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(685, 517)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtProdi)
        Me.Controls.Add(Me.txtSKS)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Matakuliah"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtProdi As TextBox
    Friend WithEvents txtSKS As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtKode As TextBox
    Friend WithEvents label5 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
