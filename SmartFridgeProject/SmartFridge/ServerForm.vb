Imports System.Net
Imports System.IO
Imports System.Net.Sockets
Public Class ServerForm
    Dim Listening As TcpListener
    Dim Allclient As TcpClient
    Dim clientList As New List(Of ClientClass)
    Dim pReader As StreamReader
    Dim pClient As ClientClass
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub InitNetwork(PortNumber As Integer)
        Listening = New TcpListener(IPAddress.Any, PortNumber)
        Listening.Start()
        UpdateList("Server Starting", False)
        Listening.BeginAcceptTcpClient(New AsyncCallback(AddressOf AcceptClient), Listening)
    End Sub

    ' create a delegate
    Delegate Sub _cUpdate(ByVal str As String, ByVal relay As Boolean)
    Sub UpdateList(ByVal str As String, ByVal relay As Boolean)
        On Error Resume Next
        If InvokeRequired Then
            Invoke(New _cUpdate(AddressOf UpdateList), str, relay)
        Else
            DGV.Rows.Add(New String() {Format(Now, "hh:mm:ss"), str})
            ' if relay we will send a string
            If relay Then send(str)
        End If
    End Sub
    Sub send(ByVal str As String)
        For x As Integer = 0 To clientList.Count - 1
            Try
                clientList(x).Send(str)
            Catch ex As Exception
                clientList.RemoveAt(x)
            End Try
        Next
    End Sub
    Sub AcceptClient(ByVal ar As IAsyncResult)
        pClient = New ClientClass(Listening.EndAcceptTcpClient(ar))
        AddHandler(pClient.getMessage), AddressOf MessageReceived
        AddHandler(pClient.clientLogout), AddressOf ClientExited
        clientList.Add(pClient)
        UpdateList("New Client Joined!", True)
        Listening.BeginAcceptTcpClient(New AsyncCallback(AddressOf AcceptClient), Listening)
    End Sub
    Sub MessageReceived(ByVal str As String)
        UpdateList(str, True)
    End Sub
    Sub ClientExited(ByVal client As ClientClass)
        clientList.Remove(client)
        UpdateList("Client Exited!", True)
    End Sub

End Class