<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label_liczba_stanowisk = New System.Windows.Forms.Label()
        Me.TextBox_liczba_stanowisk = New System.Windows.Forms.TextBox()
        Me.Button_zatwierdz_liczbe_stanowisk = New System.Windows.Forms.Button()
        Me.Label_wys1 = New System.Windows.Forms.Label()
        Me.TextBox_wys1 = New System.Windows.Forms.TextBox()
        Me.TextBox_wys2 = New System.Windows.Forms.TextBox()
        Me.Label_wys2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label_liczba_stanowisk
        '
        Me.Label_liczba_stanowisk.AutoSize = True
        Me.Label_liczba_stanowisk.Location = New System.Drawing.Point(12, 9)
        Me.Label_liczba_stanowisk.Name = "Label_liczba_stanowisk"
        Me.Label_liczba_stanowisk.Size = New System.Drawing.Size(90, 13)
        Me.Label_liczba_stanowisk.TabIndex = 8
        Me.Label_liczba_stanowisk.Text = "Liczba Stanowisk"
        '
        'TextBox_liczba_stanowisk
        '
        Me.TextBox_liczba_stanowisk.Location = New System.Drawing.Point(11, 39)
        Me.TextBox_liczba_stanowisk.Name = "TextBox_liczba_stanowisk"
        Me.TextBox_liczba_stanowisk.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_liczba_stanowisk.TabIndex = 7
        '
        'Button_zatwierdz_liczbe_stanowisk
        '
        Me.Button_zatwierdz_liczbe_stanowisk.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button_zatwierdz_liczbe_stanowisk.Location = New System.Drawing.Point(0, 91)
        Me.Button_zatwierdz_liczbe_stanowisk.Name = "Button_zatwierdz_liczbe_stanowisk"
        Me.Button_zatwierdz_liczbe_stanowisk.Size = New System.Drawing.Size(392, 23)
        Me.Button_zatwierdz_liczbe_stanowisk.TabIndex = 9
        Me.Button_zatwierdz_liczbe_stanowisk.Text = "Zatwierdź"
        Me.Button_zatwierdz_liczbe_stanowisk.UseVisualStyleBackColor = True
        '
        'Label_wys1
        '
        Me.Label_wys1.AutoSize = True
        Me.Label_wys1.Location = New System.Drawing.Point(143, 9)
        Me.Label_wys1.Name = "Label_wys1"
        Me.Label_wys1.Size = New System.Drawing.Size(103, 13)
        Me.Label_wys1.TabIndex = 11
        Me.Label_wys1.Text = "Wysokość Punktu 1"
        '
        'TextBox_wys1
        '
        Me.TextBox_wys1.Location = New System.Drawing.Point(146, 39)
        Me.TextBox_wys1.Name = "TextBox_wys1"
        Me.TextBox_wys1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_wys1.TabIndex = 10
        '
        'TextBox_wys2
        '
        Me.TextBox_wys2.Location = New System.Drawing.Point(277, 39)
        Me.TextBox_wys2.Name = "TextBox_wys2"
        Me.TextBox_wys2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_wys2.TabIndex = 10
        '
        'Label_wys2
        '
        Me.Label_wys2.AutoSize = True
        Me.Label_wys2.Location = New System.Drawing.Point(274, 9)
        Me.Label_wys2.Name = "Label_wys2"
        Me.Label_wys2.Size = New System.Drawing.Size(103, 13)
        Me.Label_wys2.TabIndex = 11
        Me.Label_wys2.Text = "Wysokość Punktu 2"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 114)
        Me.Controls.Add(Me.Label_wys2)
        Me.Controls.Add(Me.TextBox_wys2)
        Me.Controls.Add(Me.Label_wys1)
        Me.Controls.Add(Me.TextBox_wys1)
        Me.Controls.Add(Me.Button_zatwierdz_liczbe_stanowisk)
        Me.Controls.Add(Me.Label_liczba_stanowisk)
        Me.Controls.Add(Me.TextBox_liczba_stanowisk)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_liczba_stanowisk As Label
    Friend WithEvents TextBox_liczba_stanowisk As TextBox
    Friend WithEvents Button_zatwierdz_liczbe_stanowisk As Button
    Friend WithEvents Label_wys1 As Label
    Friend WithEvents TextBox_wys1 As TextBox
    Friend WithEvents TextBox_wys2 As TextBox
    Friend WithEvents Label_wys2 As Label
End Class
