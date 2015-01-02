Imports System.Net.Configuration
Imports System.Configuration
Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public NotInheritable Class SmtpHelper
    Private Sub New()
    End Sub
   

    ''' <summary>
    ''' test the smtp connection by sending a HELO command
    ''' </summary>
    ''' <param name="smtpServerAddress"></param>
    ''' <param name="port"></param>
    Public Shared Function TestConnection(smtpServerAddress As String, port As Integer) As Boolean
        Dim hostEntry As IPHostEntry = Dns.GetHostEntry(smtpServerAddress)
        Dim endPoint As New IPEndPoint(hostEntry.AddressList(0), port)
        Using tcpSocket As New Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp)
            'try to connect and test the rsponse for code 220 = success
            Try
                tcpSocket.Connect(endPoint)
            Catch ex As Exception
                Return False
            End Try

            If Not CheckResponse(tcpSocket, 220) Then
                Return False
            End If

            ' send HELO and test the response for code 250 = proper response
            SendData(tcpSocket, String.Format("HELO {0}" & vbCr & vbLf, Dns.GetHostName()))
            If Not CheckResponse(tcpSocket, 250) Then
                Return False
            End If

            ' if we got here it's that we can connect to the smtp server
            Return True
        End Using
    End Function

    Private Shared Sub SendData(socket As Socket, data As String)
        Dim dataArray As Byte() = Encoding.ASCII.GetBytes(data)
        socket.Send(dataArray, 0, dataArray.Length, SocketFlags.None)
    End Sub

    Private Shared Function CheckResponse(socket As Socket, expectedCode As Integer) As Boolean
        While socket.Available = 0
            System.Threading.Thread.Sleep(100)
        End While
        Dim responseArray As Byte() = New Byte(1023) {}
        socket.Receive(responseArray, 0, socket.Available, SocketFlags.None)
        Dim responseData As String = Encoding.ASCII.GetString(responseArray)
        Dim responseCode As Integer = Convert.ToInt32(responseData.Substring(0, 3))
        If responseCode = expectedCode Then
            Return True
        End If
        Return False
    End Function
End Class
