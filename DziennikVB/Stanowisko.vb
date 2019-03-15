Public Class Stanowisko

    Private roznica1 As Double = 0
    Private roznica2 As Double = 0
    Private sredniaRoznic As Integer = 0
    Private dlugoscCelowychZ1 As Double = 0
    Private dlugoscCelowychZ2 As Double = 0
    Private zabka1_pomiar1 As Double = 0
    Private zabka1_pomiar2 As Double = 0
    Private zabka2_pomiar1 As Double = 0
    Private zabka2_pomiar2 As Double = 0

    Public Function getRoznica1() As Double
        Return roznica1
    End Function

    Public Function getRoznica2() As Double
        Return roznica2
    End Function

    Public Function getSredniaRoznic() As Double
        Return sredniaRoznic
    End Function

    Public Function getDlugoscCelowychZ1() As Double
        Return dlugoscCelowychZ1
    End Function

    Public Function getDlugoscCelowychZ2() As Double
        Return dlugoscCelowychZ2
    End Function

    Public Function getZ1P1() As Double
        Return zabka1_pomiar1
    End Function

    Public Function getZ1P2() As Double
        Return zabka1_pomiar2
    End Function

    Public Function getZ2P1() As Double
        Return zabka2_pomiar1
    End Function

    Public Function getZ2P2() As Double
        Return zabka2_pomiar2
    End Function

    Public Sub setRoznica1(ByVal roznica As Double)
        roznica1 = roznica
    End Sub

    Public Sub setRoznica2(ByVal roznica As Double)
        roznica2 = roznica
    End Sub

    Public Sub setSredniaRoznic(ByVal srRoznic As Double)
        sredniaRoznic = srRoznic
    End Sub

    Public Sub setDlugoscCelowychZ1(ByVal dlCelowych As Double)
        dlugoscCelowychZ1 = dlCelowych
    End Sub

    Public Sub setDlugoscCelowychZ2(ByVal dlCelowych As Double)
        dlugoscCelowychZ2 = dlCelowych
    End Sub

    Public Sub setZ1P1(ByVal pomiar As Double)
        zabka1_pomiar1 = pomiar
    End Sub

    Public Sub setZ1P2(ByVal pomiar As Double)
        zabka1_pomiar2 = pomiar
    End Sub

    Public Sub setZ2P1(ByVal pomiar As Double)
        zabka2_pomiar1 = pomiar
    End Sub

    Public Sub setZ2P2(ByVal pomiar As Double)
        zabka2_pomiar2 = pomiar
    End Sub

    Sub New(ByVal dlCelZ1 As Double, ByVal dlCelZ2 As Double, ByVal z1p1 As Double, ByVal z1p2 As Double, ByVal z2p1 As Double, ByVal z2p2 As Double)
        roznica1 = 0
        roznica2 = 0
        sredniaRoznic = 0
        dlugoscCelowychZ1 = dlCelZ1
        dlugoscCelowychZ2 = dlCelZ2
        zabka1_pomiar1 = z1p1
        zabka1_pomiar2 = z1p2
        zabka2_pomiar1 = z2p1
        zabka2_pomiar2 = z2p2
    End Sub

End Class
