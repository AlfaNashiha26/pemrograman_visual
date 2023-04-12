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
        txtCelcius = New TextBox()
        txtFahrenheit = New TextBox()
        Label2 = New Label()
        txtReamur = New TextBox()
        Label3 = New Label()
        txtKelvin = New TextBox()
        Label4 = New Label()
        btnConvert = New Button()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(57, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 18)
        Label1.TabIndex = 0
        Label1.Text = "Celcius"
        ' 
        ' txtCelcius
        ' 
        txtCelcius.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtCelcius.Location = New Point(233, 42)
        txtCelcius.Margin = New Padding(3, 4, 3, 4)
        txtCelcius.Name = "txtCelcius"
        txtCelcius.Size = New Size(141, 24)
        txtCelcius.TabIndex = 1
        ' 
        ' txtFahrenheit
        ' 
        txtFahrenheit.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtFahrenheit.Location = New Point(233, 169)
        txtFahrenheit.Margin = New Padding(3, 4, 3, 4)
        txtFahrenheit.Name = "txtFahrenheit"
        txtFahrenheit.Size = New Size(141, 24)
        txtFahrenheit.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(57, 172)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 18)
        Label2.TabIndex = 2
        Label2.Text = "Fahrenheit"
        ' 
        ' txtReamur
        ' 
        txtReamur.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtReamur.Location = New Point(233, 225)
        txtReamur.Margin = New Padding(3, 4, 3, 4)
        txtReamur.Name = "txtReamur"
        txtReamur.Size = New Size(141, 24)
        txtReamur.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(57, 228)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 18)
        Label3.TabIndex = 4
        Label3.Text = "Reamur"
        ' 
        ' txtKelvin
        ' 
        txtKelvin.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtKelvin.Location = New Point(233, 285)
        txtKelvin.Margin = New Padding(3, 4, 3, 4)
        txtKelvin.Name = "txtKelvin"
        txtKelvin.Size = New Size(141, 24)
        txtKelvin.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(57, 285)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 18)
        Label4.TabIndex = 6
        Label4.Text = "Kelvin"
        ' 
        ' btnConvert
        ' 
        btnConvert.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnConvert.Location = New Point(244, 101)
        btnConvert.Margin = New Padding(3, 4, 3, 4)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(75, 34)
        btnConvert.TabIndex = 8
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.ForeColor = Color.Lime
        Label5.Location = New Point(32, 373)
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
        ClientSize = New Size(538, 444)
        Controls.Add(Label5)
        Controls.Add(btnConvert)
        Controls.Add(txtKelvin)
        Controls.Add(Label4)
        Controls.Add(txtReamur)
        Controls.Add(Label3)
        Controls.Add(txtFahrenheit)
        Controls.Add(Label2)
        Controls.Add(txtCelcius)
        Controls.Add(Label1)
        ForeColor = SystemColors.MenuText
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Celcius Converter - Alfa Nashiha"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtReamur As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKelvin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents Label5 As Label
End Class
