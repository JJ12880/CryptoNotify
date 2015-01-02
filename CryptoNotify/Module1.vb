Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Security.Cryptography

Module Module1
    Dim pKey As String = "Public Key Here"
    Dim sKey As String = "Private Key Here"

    Public Function CryptsyAPIRequest(ByVal method As String, ByVal pkey As String, ByVal skey As String)



        Dim postReq As HttpWebRequest = DirectCast(WebRequest.Create("https://api.cryptsy.com/api"), HttpWebRequest)
        Dim randomn As String = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalSeconds)

        '//Dependant upon Method
        Dim postData As String = "method=" & method & "&nonce=" & randomn

        '//Start Encryption

        Dim KeyByte() As Byte = Encoding.ASCII.GetBytes(skey)
        Dim HMAcSha As New HMACSHA512(Encoding.ASCII.GetBytes(skey))

        Using HMAcSha

            Dim messagebyte() As Byte = Encoding.ASCII.GetBytes(postData)
            Dim hashmessage() As Byte = HMAcSha.ComputeHash(messagebyte)
            Dim Sign As String = BitConverter.ToString(hashmessage)

            Sign = Sign.Replace("-", "")

            '//Generate Post Information
            postReq.Method = "POST"
            postReq.KeepAlive = False
            postReq.Headers.Add("Key", pkey)
            postReq.Headers.Add("Sign", LCase(Sign))

            postReq.ContentType = "application/x-www-form-urlencoded"
            postReq.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.AUR CLR 3.5.30729)"
            postReq.ContentLength = messagebyte.Length

            Try
                '//Send Request
                System.Net.ServicePointManager.Expect100Continue = False

                Dim postreqstream As Stream = postReq.GetRequestStream()
                postreqstream.Write(messagebyte, 0, messagebyte.Length)
                postreqstream.Close()
                Dim postresponse As HttpWebResponse

                postresponse = DirectCast(postReq.GetResponse(), HttpWebResponse)

                Using postreqreader As New StreamReader(postresponse.GetResponseStream())
                    'The Response Text
                    Dim thepage As String = postreqreader.ReadToEnd
                    thepage = thepage.Replace(Chr(34), Chr(39))

                    Dim Resp As String = Replace(thepage, "}", "")
                    Return Resp


                End Using

            Catch ex As Exception

            End Try

        End Using



    End Function

    Function BalAvailable(ByVal BalResponse As String, ByVal MarketTag As String) As String

        Try

            Dim Currency As String = MarketTag & "':"

            'Find 1st Instance of Coin
            Dim Coin As Integer = InStr(BalResponse, Currency)
            'Position of Next (:) after Found Coin
            Dim Colon As Integer = InStr(Coin, BalResponse, ":") + 2
            'Position of Next (,) after Found Coin
            Dim Comma As Integer = InStr(Coin, BalResponse, ",") - 1

            Dim Available As String = Mid(BalResponse, Colon, Comma - Colon)

            Return Available

        Catch ex As Exception

            Return "0.00000000"

        End Try

    End Function
End Module
