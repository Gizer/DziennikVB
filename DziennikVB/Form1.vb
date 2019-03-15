Imports System.Data.DataTable
Public Class Form1

    Public Shared dziennikiF1() As Dziennik
    Public Shared liczbaDziennikow As Integer = 0
    Private _i As Integer = 0
    Private _t As Integer = 0
    Dim tableDet As New DataTable("TableDet")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tableDet.Columns.Add("Nr Stanowiska", Type.GetType("System.Int32"))
        tableDet.Columns.Add("Długość Celowych Z1", Type.GetType("System.Int32"))
        tableDet.Columns.Add("Długość Celowych Z2", Type.GetType("System.Int32"))
        tableDet.Columns.Add("Z1 Pomiar I", Type.GetType("System.Int32"))
        tableDet.Columns.Add("Z2 Pomiar I", Type.GetType("System.Int32"))
        tableDet.Columns.Add("Różnica pomiarów I", Type.GetType("System.Int32"))
        tableDet.Columns.Add("Z1 Pomiar II", Type.GetType("System.Int32"))
        tableDet.Columns.Add("Z2 Pomiar II", Type.GetType("System.Int32"))
        tableDet.Columns.Add("Różnica pomiarów II", Type.GetType("System.Int32"))
        tableDet.Columns.Add("Średnia różnica", Type.GetType("System.String"))
        tableDet.Columns.Add("Wysokość Punktów", Type.GetType("System.Int32"))

        DataGridView_szczegoly.DataSource = tableDet

        Dim dziennikiForm As New Form2
        Me.Hide()
        dziennikiForm.ShowDialog()
        Dim daneStanowiska As New Form4
        Me.Show()
    End Sub

    Private Sub Button_show_Click(sender As Object, e As EventArgs) Handles Button_show.Click
        Pokaz()
    End Sub

    Private Sub Pokaz()
        Dim wysokosc As Integer = dziennikiF1(_i).getWysokoscPunktu1()
        If liczbaDziennikow Then
            If DataGridView_szczegoly.Rows.Count() > 1 Then
                tableDet.Clear()
                DataGridView_szczegoly.DataSource = tableDet
            End If
            For i As Integer = 0 To dziennikiF1(_i).getLiczbaStanowisk() - 1
                If _t < dziennikiF1(_i).getT() Then
                    tableDet.Rows.Add(i + 1, dziennikiF1(_i).getStanowiska(i).getDlugoscCelowychZ1(), dziennikiF1(_i).getStanowiska(i).getDlugoscCelowychZ2(), dziennikiF1(_i).getStanowiska(i).getZ1P1(), dziennikiF1(_i).getStanowiska(i).getZ2P1(), dziennikiF1(_i).getStanowiska(i).getRoznica1(), dziennikiF1(_i).getStanowiska(i).getZ1P2(), dziennikiF1(_i).getStanowiska(i).getZ2P2(), dziennikiF1(_i).getStanowiska(i).getRoznica2(), dziennikiF1(_i).getStanowiska(i).getSredniaRoznic().ToString() & "-" & dziennikiF1(_i).getV().ToString(), wysokosc + dziennikiF1(_i).getStanowiska(i).getSredniaRoznic() - dziennikiF1(_i).getV())
                Else
                    tableDet.Rows.Add(i + 1, dziennikiF1(_i).getStanowiska(i).getDlugoscCelowychZ1(), dziennikiF1(_i).getStanowiska(i).getDlugoscCelowychZ2(), dziennikiF1(_i).getStanowiska(i).getZ1P1(), dziennikiF1(_i).getStanowiska(i).getZ2P1(), dziennikiF1(_i).getStanowiska(i).getRoznica1(), dziennikiF1(_i).getStanowiska(i).getZ1P2(), dziennikiF1(_i).getStanowiska(i).getZ2P2(), dziennikiF1(_i).getStanowiska(i).getRoznica2(), dziennikiF1(_i).getStanowiska(i).getSredniaRoznic(), wysokosc + dziennikiF1(_i).getStanowiska(i).getSredniaRoznic())
                End If
                Label_dlCel.Text() = dziennikiF1(_i).getSumaCelowych()
                Label_z1p1.Text() = dziennikiF1(_i).getSumaZ1P1()
                Label_z1p2.Text() = dziennikiF1(_i).getSumaZ1P2()
                Label_z2p1.Text() = dziennikiF1(_i).getSumaZ2P1()
                Label_z2p2.Text() = dziennikiF1(_i).getSumaZ2P2()
                Label_roznica1.Text() = dziennikiF1(_i).getSumaWszystkichRoznicK1()
                Label_roznica2.Text() = dziennikiF1(_i).getSumaWszystkichRoznicK2()
                Label_srednia_roznic.Text() = (dziennikiF1(_i).getSumaWszystkichRoznicK1() + dziennikiF1(_i).getSumaWszystkichRoznicK2()) \ 2
                Label_suma_srednich_roznic.Text() = dziennikiF1(_i).getSumaSrednichRoznic()
                wysokosc += dziennikiF1(_i).getStanowiska(i).getSredniaRoznic() - dziennikiF1(_i).getV()
                _t += 1
            Next
        End If
        DataGridView_szczegoly.DataSource = tableDet
    End Sub

    Private Sub Button_prev_Click(sender As Object, e As EventArgs) Handles Button_prev.Click
        If _i - 1 < 0 Then
            _i = liczbaDziennikow - 1
        Else
            _i -= 1
        End If
        Pokaz()
    End Sub

    Private Sub Button_next_Click(sender As Object, e As EventArgs) Handles Button_next.Click
        If _i + 1 > liczbaDziennikow - 1 Then
            _i = 0
        Else
            _i += 1
        End If
        Pokaz()
    End Sub
End Class
