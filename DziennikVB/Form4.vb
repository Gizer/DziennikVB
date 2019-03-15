Public Class Form4

    Private buttonPresed As Boolean = False

    Public Sub New()

        InitializeComponent()

        Me.Show()
        For i As Integer = 0 To Form1.liczbaDziennikow - 1
            For j As Integer = 0 To Form1.dziennikiF1(i).getLiczbaStanowisk() - 1
                Me.Text() = "Dane Stanowiska " & j + 1.ToString() & ", Dziennik " & i + 1.ToString()
                Do Until buttonPresed
                    Application.DoEvents()
                Loop
                Dim dane As Stanowisko = New Stanowisko(CInt(TextBox_dlCel_z1.Text()), CInt(TextBox_dlCel_z2.Text()), CInt(TextBox_z1p1.Text()), CInt(TextBox_z1p2.Text()), CInt(TextBox_z2p1.Text()), CInt(TextBox_z2p2.Text()))
                Form1.dziennikiF1(i).setStanowiska(j, dane)
                Form1.dziennikiF1(i).getStanowiska(j).setRoznica1(Form1.dziennikiF1(i).getStanowiska(j).getZ1P1() - Form1.dziennikiF1(i).getStanowiska(j).getZ2P1())
                Form1.dziennikiF1(i).getStanowiska(j).setRoznica2(Form1.dziennikiF1(i).getStanowiska(j).getZ1P2() - Form1.dziennikiF1(i).getStanowiska(j).getZ2P2())
                Form1.dziennikiF1(i).getStanowiska(j).setSredniaRoznic(Parzyste((Form1.dziennikiF1(i).getStanowiska(j).getRoznica1() + Form1.dziennikiF1(i).getStanowiska(j).getRoznica2()) / 2))
                Form1.dziennikiF1(i).setSumaSrednichRoznic(Form1.dziennikiF1(i).getStanowiska(j).getSredniaRoznic())
                Form1.dziennikiF1(i).setHt(Form1.dziennikiF1(i).getWysokoscPunktu2() - Form1.dziennikiF1(i).getWysokoscPunktu1())
                Form1.dziennikiF1(i).setSumaWszystkichRoznicK1(Form1.dziennikiF1(i).getStanowiska(j).getRoznica1())
                Form1.dziennikiF1(i).setSumaWszystkichRoznicK2(Form1.dziennikiF1(i).getStanowiska(j).getRoznica2())
                Form1.dziennikiF1(i).setDhp(Parzyste(((Form1.dziennikiF1(i).getSumaWszystkichRoznicK2() + Form1.dziennikiF1(i).getSumaWszystkichRoznicK1()) / 2 + Form1.dziennikiF1(i).getSumaSrednichRoznic()) / 2))
                Form1.dziennikiF1(i).setT(Form1.dziennikiF1(i).getDhp() - Form1.dziennikiF1(i).getHt())
                Form1.dziennikiF1(i).setV(Math.Ceiling(Form1.dziennikiF1(i).getT() / Form1.dziennikiF1(i).getLiczbaStanowisk()))
                Form1.dziennikiF1(i).setSumaZ1P1(Form1.dziennikiF1(i).getStanowiska(j).getZ1P1())
                Form1.dziennikiF1(i).setSumaZ1P2(Form1.dziennikiF1(i).getStanowiska(j).getZ1P2())
                Form1.dziennikiF1(i).setSumaZ2P1(Form1.dziennikiF1(i).getStanowiska(j).getZ2P1())
                Form1.dziennikiF1(i).setSumaZ2P2(Form1.dziennikiF1(i).getStanowiska(j).getZ2P2())
                Form1.dziennikiF1(i).setSumaCelowych(Form1.dziennikiF1(i).getStanowiska(j).getDlugoscCelowychZ1() + Form1.dziennikiF1(i).getStanowiska(j).getDlugoscCelowychZ2())
                buttonPresed = False
                MessageBox.Show("Dodano już " & j + 1.ToString() & " stanowisk. Zostało " & Form1.dziennikiF1(i).getLiczbaStanowisk() - 1 - j, "Info")
            Next
        Next
        Me.Close()
    End Sub

    Private Function Parzyste(ByVal num As Double) As Integer
        num = Fix(num)
        num = num + (num Mod 2)
        Return num
    End Function

    Private Sub Button_zatwierdz_dane_stanowiska_Click(sender As Object, e As EventArgs) Handles Button_zatwierdz_dane_stanowiska.Click
        buttonPresed = True
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Text() = "Dane Stanowiska 1, Dziennik 1"
    End Sub

End Class