Imports System.Net
Imports System.IO
Imports System.Net.Sockets
Public Class DataListenerPhone
    Private client As TcpClient
    Private stream As NetworkStream
    Dim PhonePanel As PhoneDisplay



    Delegate Sub _xUpdate(ByVal str As String)
    Sub xUpdate(ByVal str As String)
        If PhonePanel.InvokeRequired Then
            PhonePanel.Invoke(New _xUpdate(AddressOf xUpdate), str)
        Else
            PhonePanel.Text = Format(Now, "hh:mm:ss")
        End If
    End Sub

    Sub read(ByVal ar As IAsyncResult)
        Try
            xUpdate(New StreamReader(client.GetStream).ReadLine)
            client.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf read, Nothing)
        Catch ex As Exception
            xUpdate("Disconnected")
            Exit Sub
        End Try

    End Sub

    Public Sub New(form As PhoneDisplay)
        PhonePanel = form
    End Sub

    Public Sub Connect(IPAddress As String, PortNumber As Integer)

        Try
            client = New TcpClient(IPAddress, PortNumber)
            client.GetStream.BeginRead(New Byte() {0}, 0, 0, New AsyncCallback(AddressOf read), Nothing)
        Catch ex As Exception
            xUpdate("Can't connect to the server!")
            xUpdate(ex.Message)
        End Try
    End Sub

    Dim sWriter As StreamWriter

    Private Sub Send_Click(data As String)
        Try
            sWriter = New StreamWriter(client.GetStream)
            sWriter.WriteLine(data)
            sWriter.Flush()
        Catch ex As Exception
            xUpdate("You're not server")
        End Try
    End Sub
End Class
