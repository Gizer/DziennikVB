Public Class Form2
    Private Sub Button_zatwierdz_liczbe_dziennikow_Click(sender As Object, e As EventArgs) Handles Button_zatwierdz_liczbe_dziennikow.Click

        Me.Hide()
        Form1.liczbaDziennikow = CInt(TextBox_liczba_dziennikow.Text())
        Dim stanowiska As New Form3(CInt(TextBox_liczba_dziennikow.Text()))

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Text() = "Liczba Dzienników"
    End Sub
End Class