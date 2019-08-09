<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button_rechne = New System.Windows.Forms.Button()
        Me.Label_formel = New System.Windows.Forms.Label()
        Me.Label_ergebnis = New System.Windows.Forms.Label()
        Me.Label_result = New System.Windows.Forms.Label()
        Me.TextBox_eingabe = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button_rechne
        '
        Me.Button_rechne.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_rechne.Location = New System.Drawing.Point(766, 238)
        Me.Button_rechne.Name = "Button_rechne"
        Me.Button_rechne.Size = New System.Drawing.Size(190, 54)
        Me.Button_rechne.TabIndex = 0
        Me.Button_rechne.Text = "Rechne"
        Me.Button_rechne.UseVisualStyleBackColor = True
        '
        'Label_formel
        '
        Me.Label_formel.AutoSize = True
        Me.Label_formel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_formel.Location = New System.Drawing.Point(29, 68)
        Me.Label_formel.Name = "Label_formel"
        Me.Label_formel.Size = New System.Drawing.Size(123, 39)
        Me.Label_formel.TabIndex = 1
        Me.Label_formel.Text = "Formel"
        '
        'Label_ergebnis
        '
        Me.Label_ergebnis.AutoSize = True
        Me.Label_ergebnis.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ergebnis.Location = New System.Drawing.Point(29, 160)
        Me.Label_ergebnis.Name = "Label_ergebnis"
        Me.Label_ergebnis.Size = New System.Drawing.Size(152, 39)
        Me.Label_ergebnis.TabIndex = 2
        Me.Label_ergebnis.Text = "Ergebnis"
        '
        'Label_result
        '
        Me.Label_result.AutoSize = True
        Me.Label_result.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_result.Location = New System.Drawing.Point(195, 160)
        Me.Label_result.Name = "Label_result"
        Me.Label_result.Size = New System.Drawing.Size(28, 29)
        Me.Label_result.TabIndex = 3
        Me.Label_result.Text = "0"
        '
        'TextBox_eingabe
        '
        Me.TextBox_eingabe.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_eingabe.Location = New System.Drawing.Point(202, 65)
        Me.TextBox_eingabe.Name = "TextBox_eingabe"
        Me.TextBox_eingabe.Size = New System.Drawing.Size(754, 45)
        Me.TextBox_eingabe.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 312)
        Me.Controls.Add(Me.TextBox_eingabe)
        Me.Controls.Add(Me.Label_result)
        Me.Controls.Add(Me.Label_ergebnis)
        Me.Controls.Add(Me.Label_formel)
        Me.Controls.Add(Me.Button_rechne)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formel Interpreter - Fallstudie II"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_rechne As Button
    Friend WithEvents Label_formel As Label
    Friend WithEvents Label_ergebnis As Label
    Friend WithEvents Label_result As Label
    Friend WithEvents TextBox_eingabe As TextBox
End Class
