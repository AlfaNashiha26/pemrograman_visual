Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

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
        lblHargaBarang = New Label()
        txtHargaBarang = New TextBox()
        lblJumlahBarang = New Label()
        txtJumlahBarang = New TextBox()
        chkMember = New Windows.Forms.CheckBox()
        btnHitung = New Button()
        lblTotalBayar = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lblHargaBarang
        ' 
        lblHargaBarang.AutoSize = True
        lblHargaBarang.Location = New Point(16, 23)
        lblHargaBarang.Margin = New Padding(4, 0, 4, 0)
        lblHargaBarang.Name = "lblHargaBarang"
        lblHargaBarang.Size = New Size(101, 20)
        lblHargaBarang.TabIndex = 0
        lblHargaBarang.Text = "Harga Barang"
        ' 
        ' txtHargaBarang
        ' 
        txtHargaBarang.Location = New Point(140, 18)
        txtHargaBarang.Margin = New Padding(4, 5, 4, 5)
        txtHargaBarang.Name = "txtHargaBarang"
        txtHargaBarang.Size = New Size(326, 27)
        txtHargaBarang.TabIndex = 1
        ' 
        ' lblJumlahBarang
        ' 
        lblJumlahBarang.AutoSize = True
        lblJumlahBarang.Location = New Point(16, 63)
        lblJumlahBarang.Margin = New Padding(4, 0, 4, 0)
        lblJumlahBarang.Name = "lblJumlahBarang"
        lblJumlahBarang.Size = New Size(106, 20)
        lblJumlahBarang.TabIndex = 2
        lblJumlahBarang.Text = "Jumlah Barang"
        ' 
        ' txtJumlahBarang
        ' 
        txtJumlahBarang.Location = New Point(140, 58)
        txtJumlahBarang.Margin = New Padding(4, 5, 4, 5)
        txtJumlahBarang.Name = "txtJumlahBarang"
        txtJumlahBarang.Size = New Size(326, 27)
        txtJumlahBarang.TabIndex = 3
        ' 
        ' chkMember
        ' 
        chkMember.AutoSize = True
        chkMember.Location = New Point(140, 98)
        chkMember.Margin = New Padding(4, 5, 4, 5)
        chkMember.Name = "chkMember"
        chkMember.Size = New Size(87, 24)
        chkMember.TabIndex = 4
        chkMember.Text = "Member"
        chkMember.UseVisualStyleBackColor = True
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(140, 132)
        btnHitung.Margin = New Padding(4, 5, 4, 5)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(106, 35)
        btnHitung.TabIndex = 5
        btnHitung.Text = "Hitung Total Bayar"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' lblTotalBayar
        ' 
        lblTotalBayar.AutoSize = True
        lblTotalBayar.Location = New Point(16, 189)
        lblTotalBayar.Margin = New Padding(4, 0, 4, 0)
        lblTotalBayar.Name = "lblTotalBayar"
        lblTotalBayar.Size = New Size(83, 20)
        lblTotalBayar.TabIndex = 6
        lblTotalBayar.Text = "Total Bayar"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(103, 254)
        Label1.Name = "Label1"
        Label1.Size = New Size(268, 24)
        Label1.TabIndex = 7
        Label1.Text = "Alfa Nashiha (200511007)"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(479, 287)
        Controls.Add(Label1)
        Controls.Add(lblTotalBayar)
        Controls.Add(btnHitung)
        Controls.Add(chkMember)
        Controls.Add(txtJumlahBarang)
        Controls.Add(lblJumlahBarang)
        Controls.Add(txtHargaBarang)
        Controls.Add(lblHargaBarang)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        Text = "Aplikasi Hitung Total Bayar, By. Alfa Nashiha"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHargaBarang As Label
    Friend WithEvents txtHargaBarang As TextBox
    Friend WithEvents lblJumlahBarang As Label
    Friend WithEvents txtJumlahBarang As TextBox
    Friend WithEvents chkMember As Windows.Forms.CheckBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents lblTotalBayar As Label
    Friend WithEvents Label1 As Label
End Class
