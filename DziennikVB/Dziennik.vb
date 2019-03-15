Public Class Dziennik

    Private wysokoscPunktu1 As Integer = 0
    Private wysokoscPunktu2 As Integer = 0
    Private sumaWszystkichRoznicK1 As Double = 0
    Private sumaWszystkichRoznicK2 As Double = 0
    Private sumaSrednichRoznic As Integer = 0
    Private w As Integer ''''''''''''''''''
    Private liczbaStanowisk As Integer
    Private stanowiska() As Stanowisko
    Private ht As Double = 0
    Private dhp As Double = 0
    Private t As Double = 0
    Private v As Double = 0
    Private sumaZ1P1 As Double = 0
    Private sumaZ1P2 As Double = 0
    Private sumaZ2P1 As Double = 0
    Private sumaZ2P2 As Double = 0
    Private sumaCelowych As Double = 0

    Public Function getWysokoscPunktu1() As Integer
        Return wysokoscPunktu1
    End Function

    Public Function getWysokoscPunktu2() As Integer
        Return wysokoscPunktu2
    End Function

    Public Function getSumaSrednichRoznic() As Integer
        Return sumaSrednichRoznic
    End Function

    Public Function getW() As Integer
        Return w
    End Function

    Public Function getLiczbaStanowisk() As Integer
        Return liczbaStanowisk
    End Function

    Public Function getStanowiska(ByVal i As Integer) As Stanowisko
        Return stanowiska(i)
    End Function

    Public Function getHt() As Double
        Return ht
    End Function

    Public Function getDhp() As Double
        Return dhp
    End Function

    Public Function getT() As Double
        Return t
    End Function

    Public Function getV() As Double
        Return v
    End Function

    Public Function getSumaWszystkichRoznicK1() As Double
        Return sumaWszystkichRoznicK1
    End Function

    Public Function getSumaWszystkichRoznicK2() As Double
        Return sumaWszystkichRoznicK2
    End Function

    Public Function getSumaZ1P1() As Double
        Return sumaZ1P1
    End Function

    Public Function getSumaZ1P2() As Double
        Return sumaZ1P2
    End Function

    Public Function getSumaZ2P1() As Double
        Return sumaZ2P1
    End Function

    Public Function getSumaZ2P2() As Double
        Return sumaZ2P2
    End Function

    Public Function getSumaCelowych() As Double
        Return sumaCelowych
    End Function

    Public Sub setWysokoscPunktu1(ByVal wyP As Integer)
        wysokoscPunktu1 = wyP
    End Sub

    Public Sub setWysokoscPunktu2(ByVal wyP As Integer)
        wysokoscPunktu2 = wyP
    End Sub

    Public Sub setSumaSrednichRoznic(ByVal ssr As Integer)
        sumaSrednichRoznic += ssr
    End Sub

    Public Sub setSumaSrednichRoznicNaZero()
        sumaSrednichRoznic = 0
    End Sub

    Public Sub setW(ByVal ww As Integer)
        w = ww
    End Sub

    Public Sub setLiczbaStanowisk(ByVal ls As Integer)
        liczbaStanowisk = ls
    End Sub

    Public Sub setStanowiska(ByVal i As Integer, ByVal dane As Stanowisko)
        stanowiska(i) = dane
    End Sub

    Public Sub setHt(ByVal htn As Double)
        ht = htn
    End Sub

    Public Sub setDhp(ByVal dhpn As Double)
        dhp = dhpn
    End Sub

    Public Sub setT(ByVal tn As Double)
        t = tn
    End Sub

    Public Sub setV(ByVal vn As Double)
        v = vn
    End Sub

    Public Sub setSumaZ1P1(ByVal a As Double)
        sumaZ1P1 += a
    End Sub

    Public Sub setSumaZ1P2(ByVal a As Double)
        sumaZ1P2 += a
    End Sub

    Public Sub setSumaZ2P1(ByVal a As Double)
        sumaZ2P1 += a
    End Sub

    Public Sub setSumaZ2P2(ByVal a As Double)
        sumaZ2P2 += a
    End Sub

    Public Sub setSumaCelowych(ByVal a As Double)
        sumaCelowych += a
    End Sub

    Public Sub setSumaWszystkichRoznicK1(ByVal swr As Double)
        sumaWszystkichRoznicK1 += swr
    End Sub

    Public Sub setSumaWszystkichRoznicK2(ByVal swr As Double)
        sumaWszystkichRoznicK2 += swr
    End Sub

    Sub New(ByVal wysP1 As Integer, ByVal wysP2 As Integer, ByVal lStanowisk As Integer)
        wysokoscPunktu1 = wysP1
        wysokoscPunktu2 = wysP2
        sumaSrednichRoznic = 0
        w = 0
        liczbaStanowisk = lStanowisk
        ReDim stanowiska(lStanowisk - 1)
    End Sub

End Class
