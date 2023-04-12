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
        txtFahrenheit = New TextBox()
        txtCelcius = New TextBox()
        Label2 = New Label()
        txtReamur = New TextBox()
        Label3 = New Label()
        txtKelvin = New TextBox()
        Label4 = New Label()
        Button1 = New Button()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(8, 242)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 20)
        Label1.TabIndex = 0
        Label1.Text = "Fahrenheit"
        ' 
        ' txtFahrenheit
        ' 
        txtFahrenheit.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtFahrenheit.Location = New Point(151, 245)
        txtFahrenheit.Margin = New Padding(3, 4, 3, 4)
        txtFahrenheit.Name = "txtFahrenheit"
        txtFahrenheit.Size = New Size(146, 27)
        txtFahrenheit.TabIndex = 1
        ' 
        ' txtCelcius
        ' 
        txtCelcius.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtCelcius.Location = New Point(155, 184)
        txtCelcius.Margin = New Padding(3, 4, 3, 4)
        txtCelcius.Name = "txtCelcius"
        txtCelcius.Size = New Size(146, 27)
        txtCelcius.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(12, 181)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 20)
        Label2.TabIndex = 2
        Label2.Text = "Celcius"
        ' 
        ' txtReamur
        ' 
        txtReamur.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtReamur.Location = New Point(151, 311)
        txtReamur.Margin = New Padding(3, 4, 3, 4)
        txtReamur.Name = "txtReamur"
        txtReamur.Size = New Size(146, 27)
        txtReamur.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(8, 309)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 20)
        Label3.TabIndex = 4
        Label3.Text = "Reamur"
        ' 
        ' txtKelvin
        ' 
        txtKelvin.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtKelvin.Location = New Point(151, 52)
        txtKelvin.Margin = New Padding(3, 4, 3, 4)
        txtKelvin.Name = "txtKelvin"
        txtKelvin.Size = New Size(146, 27)
        txtKelvin.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(8, 50)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 20)
        Label4.TabIndex = 6
        Label4.Text = "Kelvin"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(161, 115)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(136, 50)
        Button1.TabIndex = 8
        Button1.Text = "Convert"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.ForeColor = Color.Lime
        Label5.Location = New Point(11, 394)
        Label5.Name = "Label5"
        Label5.Size = New Size(446, 28)
        Label5.TabIndex = 9
        Label5.Text = "Alfa Nashiha - 200511007 - TI20C"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(624, 554)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(txtKelvin)
        Controls.Add(Label4)
        Controls.Add(txtReamur)
        Controls.Add(Label3)
        Controls.Add(txtCelcius)
        Controls.Add(Label2)
        Controls.Add(txtFahrenheit)
        Controls.Add(Label1)
        ForeColor = SystemColors.MenuText
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Kelvin Convreter - Alfa Nashiha"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtReamur As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKelvin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
End Class
