<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label_liczba_dziennikow = New System.Windows.Forms.Label()
        Me.TextBox_liczba_dziennikow = New System.Windows.Forms.TextBox()
        Me.Button_zatwierdz_liczbe_dziennikow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label_liczba_dziennikow
        '
        Me.Label_liczba_dziennikow.AutoSize = True
        Me.Label_liczba_dziennikow.Location = New System.Drawing.Point(118, 9)
        Me.Label_liczba_dziennikow.Name = "Label_liczba_dziennikow"
        Me.Label_liczba_dziennikow.Size = New System.Drawing.Size(96, 13)
        Me.Label_liczba_dziennikow.TabIndex = 5
        Me.Label_liczba_dziennikow.Text = "Liczba Dzienników"
        '
        'TextBox_liczba_dziennikow
        '
        Me.TextBox_liczba_dziennikow.Location = New System.Drawing.Point(121, 25)
        Me.TextBox_liczba_dziennikow.Name = "TextBox_liczba_dziennikow"
        Me.TextBox_liczba_dziennikow.Size = New System.Drawing.Size(93, 20)
        Me.TextBox_liczba_dziennikow.TabIndex = 3
        '
        'Button_zatwierdz_liczbe_dziennikow
        '
        Me.Button_zatwierdz_liczbe_dziennikow.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button_zatwierdz_liczbe_dziennikow.Location = New System.Drawing.Point(0, 74)
        Me.Button_zatwierdz_liczbe_dziennikow.Name = "Button_zatwierdz_liczbe_dziennikow"
        Me.Button_zatwierdz_liczbe_dziennikow.Size = New System.Drawing.Size(338, 23)
        Me.Button_zatwierdz_liczbe_dziennikow.TabIndex = 6
        Me.Button_zatwierdz_liczbe_dziennikow.Text = "Zatwierdź"
        Me.Button_zatwierdz_liczbe_dziennikow.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 97)
        Me.Controls.Add(Me.Button_zatwierdz_liczbe_dziennikow)
        Me.Controls.Add(Me.Label_liczba_dziennikow)
        Me.Controls.Add(Me.TextBox_liczba_dziennikow)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_liczba_dziennikow As Label
    Friend WithEvents TextBox_liczba_dziennikow As TextBox
    Friend WithEvents Button_zatwierdz_liczbe_dziennikow As Button
End Class
