Public Class Form3

    Public buttonPressed As Boolean = False

    Public Sub New(ByVal ldz As Integer)

        InitializeComponent()

        Me.Show()
        ReDim Form1.dziennikiF1(ldz - 1)
        For i As Integer = 0 To ldz - 1
            Me.Text() = "Dane Dziennika " & i + 1
            Do Until buttonPressed
                Application.DoEvents()
            Loop
            Form1.dziennikiF1(i) = New Dziennik(CInt(TextBox_wys1.Text()), CInt(TextBox_wys2.Text()), CInt(TextBox_liczba_stanowisk.Text()))
            buttonPressed = False
            MessageBox.Show("Dodano już " & i + 1.ToString() & " dzienników. Zostało " & ldz - i - 1, "Info")
        Next
        Me.Close()
    End Sub

    Private Sub Button_zatwierdz_liczbe_stanowisk_Click(sender As Object, e As EventArgs) Handles Button_zatwierdz_liczbe_stanowisk.Click
        buttonPressed = True
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Text() = "Dane Dziennika 1"
    End Sub
End Class