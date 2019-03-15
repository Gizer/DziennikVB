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
        Me.Button_show = New System.Windows.Forms.Button()
        Me.Button_prev = New System.Windows.Forms.Button()
        Me.Button_next = New System.Windows.Forms.Button()
        Me.Label_dziennik = New System.Windows.Forms.Label()
        Me.DataGridView_szczegoly = New System.Windows.Forms.DataGridView()
        Me.Label_szczegoly = New System.Windows.Forms.Label()
        Me.Label_dlCel = New System.Windows.Forms.Label()
        Me.Label_z1p1 = New System.Windows.Forms.Label()
        Me.Label_z1p2 = New System.Windows.Forms.Label()
        Me.Label_z2p1 = New System.Windows.Forms.Label()
        Me.Label_z2p2 = New System.Windows.Forms.Label()
        Me.Label_roznica1 = New System.Windows.Forms.Label()
        Me.Label_roznica2 = New System.Windows.Forms.Label()
        Me.Label_srednia_roznic = New System.Windows.Forms.Label()
        Me.Label_suma_srednich_roznic = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DataGridView_szczegoly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_show
        '
        Me.Button_show.Location = New System.Drawing.Point(93, 534)
        Me.Button_show.Name = "Button_show"
        Me.Button_show.Size = New System.Drawing.Size(75, 23)
        Me.Button_show.TabIndex = 1
        Me.Button_show.Text = "Pokaż"
        Me.Button_show.UseVisualStyleBackColor = True
        '
        'Button_prev
        '
        Me.Button_prev.Location = New System.Drawing.Point(12, 534)
        Me.Button_prev.Name = "Button_prev"
        Me.Button_prev.Size = New System.Drawing.Size(75, 23)
        Me.Button_prev.TabIndex = 1
        Me.Button_prev.Text = "Poprzedni"
        Me.Button_prev.UseVisualStyleBackColor = True
        '
        'Button_next
        '
        Me.Button_next.Location = New System.Drawing.Point(174, 534)
        Me.Button_next.Name = "Button_next"
        Me.Button_next.Size = New System.Drawing.Size(75, 23)
        Me.Button_next.TabIndex = 1
        Me.Button_next.Text = "Nastepny"
        Me.Button_next.UseVisualStyleBackColor = True
        '
        'Label_dziennik
        '
        Me.Label_dziennik.AutoSize = True
        Me.Label_dziennik.Location = New System.Drawing.Point(106, 509)
        Me.Label_dziennik.Name = "Label_dziennik"
        Me.Label_dziennik.Size = New System.Drawing.Size(48, 13)
        Me.Label_dziennik.TabIndex = 2
        Me.Label_dziennik.Text = "Dziennik"
        '
        'DataGridView_szczegoly
        '
        Me.DataGridView_szczegoly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_szczegoly.Location = New System.Drawing.Point(12, 29)
        Me.DataGridView_szczegoly.Name = "DataGridView_szczegoly"
        Me.DataGridView_szczegoly.Size = New System.Drawing.Size(1143, 467)
        Me.DataGridView_szczegoly.TabIndex = 0
        '
        'Label_szczegoly
        '
        Me.Label_szczegoly.AutoSize = True
        Me.Label_szczegoly.Location = New System.Drawing.Point(9, 13)
        Me.Label_szczegoly.Name = "Label_szczegoly"
        Me.Label_szczegoly.Size = New System.Drawing.Size(57, 13)
        Me.Label_szczegoly.TabIndex = 4
        Me.Label_szczegoly.Text = "Szczegóły"
        '
        'Label_dlCel
        '
        Me.Label_dlCel.AutoSize = True
        Me.Label_dlCel.Location = New System.Drawing.Point(507, 530)
        Me.Label_dlCel.Name = "Label_dlCel"
        Me.Label_dlCel.Size = New System.Drawing.Size(39, 13)
        Me.Label_dlCel.TabIndex = 5
        Me.Label_dlCel.Text = "Label1"
        '
        'Label_z1p1
        '
        Me.Label_z1p1.AutoSize = True
        Me.Label_z1p1.Location = New System.Drawing.Point(665, 530)
        Me.Label_z1p1.Name = "Label_z1p1"
        Me.Label_z1p1.Size = New System.Drawing.Size(39, 13)
        Me.Label_z1p1.TabIndex = 6
        Me.Label_z1p1.Text = "Label2"
        '
        'Label_z1p2
        '
        Me.Label_z1p2.AutoSize = True
        Me.Label_z1p2.Location = New System.Drawing.Point(831, 530)
        Me.Label_z1p2.Name = "Label_z1p2"
        Me.Label_z1p2.Size = New System.Drawing.Size(39, 13)
        Me.Label_z1p2.TabIndex = 7
        Me.Label_z1p2.Text = "Label3"
        '
        'Label_z2p1
        '
        Me.Label_z2p1.AutoSize = True
        Me.Label_z2p1.Location = New System.Drawing.Point(665, 565)
        Me.Label_z2p1.Name = "Label_z2p1"
        Me.Label_z2p1.Size = New System.Drawing.Size(39, 13)
        Me.Label_z2p1.TabIndex = 6
        Me.Label_z2p1.Text = "Label2"
        '
        'Label_z2p2
        '
        Me.Label_z2p2.AutoSize = True
        Me.Label_z2p2.Location = New System.Drawing.Point(831, 565)
        Me.Label_z2p2.Name = "Label_z2p2"
        Me.Label_z2p2.Size = New System.Drawing.Size(39, 13)
        Me.Label_z2p2.TabIndex = 7
        Me.Label_z2p2.Text = "Label3"
        '
        'Label_roznica1
        '
        Me.Label_roznica1.AutoSize = True
        Me.Label_roznica1.Location = New System.Drawing.Point(665, 602)
        Me.Label_roznica1.Name = "Label_roznica1"
        Me.Label_roznica1.Size = New System.Drawing.Size(39, 13)
        Me.Label_roznica1.TabIndex = 6
        Me.Label_roznica1.Text = "Label2"
        '
        'Label_roznica2
        '
        Me.Label_roznica2.AutoSize = True
        Me.Label_roznica2.Location = New System.Drawing.Point(831, 602)
        Me.Label_roznica2.Name = "Label_roznica2"
        Me.Label_roznica2.Size = New System.Drawing.Size(39, 13)
        Me.Label_roznica2.TabIndex = 6
        Me.Label_roznica2.Text = "Label2"
        '
        'Label_srednia_roznic
        '
        Me.Label_srednia_roznic.AutoSize = True
        Me.Label_srednia_roznic.Location = New System.Drawing.Point(986, 565)
        Me.Label_srednia_roznic.Name = "Label_srednia_roznic"
        Me.Label_srednia_roznic.Size = New System.Drawing.Size(39, 13)
        Me.Label_srednia_roznic.TabIndex = 6
        Me.Label_srednia_roznic.Text = "Label2"
        '
        'Label_suma_srednich_roznic
        '
        Me.Label_suma_srednich_roznic.AutoSize = True
        Me.Label_suma_srednich_roznic.Location = New System.Drawing.Point(1128, 565)
        Me.Label_suma_srednich_roznic.Name = "Label_suma_srednich_roznic"
        Me.Label_suma_srednich_roznic.Size = New System.Drawing.Size(39, 13)
        Me.Label_suma_srednich_roznic.TabIndex = 6
        Me.Label_suma_srednich_roznic.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(431, 530)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Suma Dł Cel:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(589, 530)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Suma Z1P1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(589, 565)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Suma Z1P2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(589, 602)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Suma Różnic1:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(755, 530)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Suma Z2P1:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(755, 565)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Suma Z2P2:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(755, 602)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Suma Różnic2:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(934, 565)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Średnia:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1040, 565)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Suma Średnich:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1166, 803)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label_z2p2)
        Me.Controls.Add(Me.Label_z1p2)
        Me.Controls.Add(Me.Label_suma_srednich_roznic)
        Me.Controls.Add(Me.Label_srednia_roznic)
        Me.Controls.Add(Me.Label_roznica2)
        Me.Controls.Add(Me.Label_roznica1)
        Me.Controls.Add(Me.Label_z2p1)
        Me.Controls.Add(Me.Label_z1p1)
        Me.Controls.Add(Me.Label_dlCel)
        Me.Controls.Add(Me.Label_szczegoly)
        Me.Controls.Add(Me.Label_dziennik)
        Me.Controls.Add(Me.Button_next)
        Me.Controls.Add(Me.Button_prev)
        Me.Controls.Add(Me.Button_show)
        Me.Controls.Add(Me.DataGridView_szczegoly)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView_szczegoly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_show As Button
    Friend WithEvents Button_prev As Button
    Friend WithEvents Button_next As Button
    Friend WithEvents Label_dziennik As Label
    Friend WithEvents DataGridView_szczegoly As DataGridView
    Friend WithEvents Label_szczegoly As Label
    Friend WithEvents Label_dlCel As Label
    Friend WithEvents Label_z1p1 As Label
    Friend WithEvents Label_z1p2 As Label
    Friend WithEvents Label_z2p1 As Label
    Friend WithEvents Label_z2p2 As Label
    Friend WithEvents Label_roznica1 As Label
    Friend WithEvents Label_roznica2 As Label
    Friend WithEvents Label_srednia_roznic As Label
    Friend WithEvents Label_suma_srednich_roznic As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
