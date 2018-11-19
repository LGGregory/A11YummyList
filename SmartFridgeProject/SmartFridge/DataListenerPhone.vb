Imports Newtonsoft.Json
Imports System.Net
Imports System.IO
Imports System.Net.Sockets
Imports SmartFridge

Public Class DataListenerPhone
    Implements DataListener
    Private client As TcpClient
    Private stream As NetworkStream
    Dim FridgePanel As SmartFridgeDisplay

    Delegate Sub _xUpdate(ByVal str As String)
    Sub xUpdate(ByVal str As String)
        If FridgePanel.InvokeRequired Then
            FridgePanel.Invoke(New _xUpdate(AddressOf xUpdate), str)
        Else
            Try
                Dim aJson As ActionJson
                aJson = JsonConvert.DeserializeObject(Of ActionJson)(str)
                If aJson.Action = "update" Then
                    FridgePanel.CurrentListPanel.LoadList(aJson.List)
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Sub read(ByVal ar As IAsyncResult) Implements DataListener.Read
        Try
            xUpdate(New StreamReader(client.GetStream).ReadLine)
            client.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf read, Nothing)
        Catch ex As Exception
            xUpdate("Disconnected")
            Exit Sub
        End Try

    End Sub

    Public Sub FormSet(form As SmartFridgeDisplay) Implements DataListener.formSet
        FridgePanel = form
    End Sub

    Public Sub Connect(IPAddress As String, PortNumber As Integer) Implements DataListener.Connect

        Try
            client = New TcpClient(IPAddress, PortNumber)
            client.GetStream.BeginRead(New Byte() {0}, 0, 0, New AsyncCallback(AddressOf read), Nothing)
        Catch ex As Exception
            xUpdate("Can't connect to the server!")
            xUpdate(ex.Message)
        End Try
    End Sub

    Dim sWriter As StreamWriter
    Public Sub Send(data As String) Implements DataListener.Send
        Try
            sWriter = New StreamWriter(client.GetStream)
            sWriter.WriteLine(data)
            sWriter.Flush()
        Catch ex As Exception
            xUpdate("You're not server")
        End Try
    End Sub


    Public Event AddData(iInfo As ItemInfo) Implements DataListener.AddData
    Public Event ChangeList(gList As GroceryList) Implements DataListener.ChangeList



End Class
