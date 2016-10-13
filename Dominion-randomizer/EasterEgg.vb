'imdb.com/title/tt1212027/goofs?item=gf1175507
Public Class EasterEgg
    Private egg As Integer = 1
    Public Sub Trigger()
        If egg < 5 Then
            egg += 1
        Else
            Dim strHostName As String
            Dim strIPAddress As String
            strHostName = System.Net.Dns.GetHostName()
            strIPAddress = System.Net.Dns.GetHostEntry(strHostName).AddressList(0).ToString()
            MsgBox("Your IP Address is " & strIPAddress & " CSI: New York has been notified", , "You are the killer")
            egg = 1
        End If
    End Sub
    Public Sub Clear()
        egg = 1
    End Sub
End Class
