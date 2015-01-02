


Imports System.Configuration
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Net.Mail
Imports System.Windows.Forms
Imports System.Collections.Specialized
Imports System.Security.Principal
Imports System.Xml



Structure order
    Dim market As String
    Dim type As String
    Dim quantity As Double
    Dim filled As Double
    Dim remaining As Double
    Dim ID As String
    Dim price As Double
End Structure

Structure RSSMessage
    Dim subject As String
    Dim message As String
    Dim link As String
End Structure

Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim closedorders As New Dictionary(Of String, order)
    Dim openorders As New Dictionary(Of String, order)
    Dim firstrun As Boolean = True
    Dim networkerror As Boolean = False
    Dim InfoError As Boolean = False
    Dim notif As New NotifyIcon


    Private Sub start() Handles Me.Load

        OutputJsonDll()
        SetIcons()
        SetDonationBoxes()
        SetLockoutEmailSMS()
        ShowWelcomeMessage()
        ShowLatestRSSNews()
        ShowUpdateIfNewRSS()

    End Sub





    Private Sub BTNStart_Click(sender As Object, e As EventArgs) Handles BTNStart.Click
        If BTNStart.Text = "Stop" Then
            GetDataTimer.Stop()
            BTNStart.Text = "Start"
            LBLBittrexStatus.Text = "Not Connected"
            LBLBittrexStatusColor.BackColor = Color.Red
            firstrun = True
            Exit Sub
        End If

        If BTNStart.Text = "Start" Then
            BTNStart.Text = "Stop"
            GetData(Nothing, Nothing)
            Exit Sub
        End If

    End Sub
    Private Sub BTNSettings_Click(sender As Object, e As EventArgs) Handles BTNBittrexSettings.Click
        InfoError = False
        BTNStart.Hide()


        If SettingsDialog.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            InfoError = True
            Exit Sub

        End If
        BTNStart.Show()
        'BTNTest.Show()
        BTNSystemTray.Show()





    End Sub

    Private Sub GetData(sender As Object, e As EventArgs)



        LBLBittrexStatusColor.BackColor = Color.Yellow
        LBLBittrexStatus.Text = "Loading Trade Data             "
        LBLBittrexStatus.Update()

        LBLBittrexStatusColor.Update()

        If firstrun = True Then
            SendIconTrayNotificaiton("CryptoNotify", "Loading Data")

        End If
        networkerror = False
        GetBittrexCompleatedOrders()

        GetBittrexPartialOrders()

        If firstrun And Not networkerror Then
            SendIconTrayNotificaiton("CryptoNotify", "Waiting for completed Trades")
            LBLBittrexStatusColor.BackColor = Color.Green
            LBLBittrexStatus.Text = "Connected! API Keys good!"
            LBLBittrexStatus.Update()
        End If

        If Not networkerror Then
            LBLBittrexStatusColor.BackColor = Color.Green
            LBLBittrexStatus.Text = "Connected: API Keys good!"
            LBLBittrexStatus.Update()
        End If



        firstrun = False
        GetDataTimer.Start()

    End Sub
    Private Sub GetBittrexCompleatedOrders()
        Dim method As String = "getorderhistory"

        Dim URI As String = "https://bittrex.com/api/v1.1/account/" & method & "?apikey=" & My.Settings.Pubkey & "&nonce=" & Environment.TickCount


        Dim request = WebRequest.Create("https://bittrex.com/api/v1.1/")




        Dim hmAcSha = New HMACSHA512(Encoding.ASCII.GetBytes(My.Settings.Prikey))
        Dim URIbyte = Encoding.ASCII.GetBytes(URI)
        Dim hashmessage = hmAcSha.ComputeHash(URIbyte)
        Dim sign = BitConverter.ToString(hashmessage)
        sign = sign.Replace("-", "")

        Dim client As New WebClient()
        client.Headers.Add("apisign", sign)




        Dim test As JObject


        Try
            test = JObject.Parse(client.DownloadString(URI))
        Catch ex As Exception
            SendIconTrayNotificaiton("CryptoNotify", "Connection to Bittrex Timed out! :-(")
            LBLBittrexStatus.Text = "Network Error, no connection to Bittrex!"
            LBLBittrexStatusColor.BackColor = Color.Red
            networkerror = True
            GetDataTimer.Start()

            Exit Sub
        End Try

        Dim str As String = test("success")

        If test("success") = "False" Then
            SendIconTrayNotificaiton("ERROR", "CANNOT Connect to Bittrex! API Keys are wrong or non-functional")
            LBLBittrexStatusColor.BackColor = Color.Yellow
            LBLBittrexStatus.Text = "Connected, But API Keys are BAD!"
            networkerror = True
            GetDataTimer.Start()

            Exit Sub
        Else

        End If



        If test("success") = "True" And firstrun = True Then
            SendIconTrayNotificaiton("Connected!", "API Keys good, Listening for completed orders!")
        End If




        For Each x As JObject In test("result")
            Dim neworder As order

            neworder.market = x("Exchange")
            neworder.type = x("OrderType")
            neworder.quantity = x("Quantity")
            neworder.price = Format(x("Limit"), "0.#########")
            neworder.filled = CDbl(x("Quantity")) - CDbl(x("QuantityRemaining"))
            neworder.remaining = x("QuantityRemaining")
            neworder.ID = x("OrderUuid")

            If closedorders.ContainsKey(neworder.ID) Then
                'pretty sure this code is not needed, because orders in this method only show up when the order is complete
                'there should never be a case where the filled # changes. 
                If closedorders(neworder.ID).filled <> neworder.filled Then
                    'updatelistview()
                    SendAlert(neworder, "Comp")

                End If
            Else
                closedorders.Add(neworder.ID, neworder)

                If firstrun = False Then
                    ' updatelistview()
                    If neworder.filled <> neworder.quantity Then Continue For
                    SendAlert(neworder, "Comp")
                End If

            End If
        Next
    End Sub








    Private Sub GetBittrexPartialOrders()
        Dim method As String = "getopenorders"

        Dim URI As String = "https://bittrex.com/api/v1.1/market/" & method & "?apikey=" & My.Settings.Pubkey & "&nonce=" & Environment.TickCount


        Dim request = WebRequest.Create("https://bittrex.com/api/v1.1/")




        Dim hmAcSha = New HMACSHA512(Encoding.ASCII.GetBytes(My.Settings.Prikey))
        Dim URIbyte = Encoding.ASCII.GetBytes(URI)
        Dim hashmessage = hmAcSha.ComputeHash(URIbyte)
        Dim sign = BitConverter.ToString(hashmessage)
        sign = sign.Replace("-", "")

        Dim client As New WebClient()

        client.Headers.Add("apisign", sign)




        Dim test As JObject


        Try
            test = JObject.Parse(client.DownloadString(URI))
        Catch ex As Exception
            SendIconTrayNotificaiton("CryptoNotify", "Connection to Bittrex Timed out! :-(")
            LBLBittrexStatus.Text = "Network Error, no connection to Bittrex!"
            LBLBittrexStatusColor.BackColor = Color.Red
            firstrun = True
            GetDataTimer.Start()
            Exit Sub
        End Try

        Dim str As String = test("success")




        For Each x As JObject In test("result")
            Dim neworder As order

            neworder.market = x("Exchange")
            neworder.type = x("OrderType")
            neworder.quantity = x("Quantity")
            neworder.price = Format(x("Limit"), "0.#########")
            neworder.filled = CDbl(x("Quantity")) - CDbl(x("QuantityRemaining"))
            neworder.remaining = x("QuantityRemaining")
            neworder.ID = x("OrderUuid")

            If openorders.ContainsKey(neworder.ID) Then
                'pretty sure this code is not needed, because orders in this method only show up when the order is complete
                'there should never be a case where the filled # changes. 
                If openorders(neworder.ID).filled <> neworder.filled Then
                    'updatelistview()

                    SendAlert(neworder, "part")
                    openorders.Remove(neworder.ID)
                    openorders.Add(neworder.ID, neworder)
                End If
            Else
                openorders.Add(neworder.ID, neworder)
            End If
        Next
    End Sub










#Region "StartupTasks"

    Private Sub ShowWelcomeMessage()
        ShowLargeMessageBox("", "Welcome to CryptoNotify Beta, and may your trades be ever in your favor!" & Environment.NewLine & Environment.NewLine & _
                                "  + Click 'Settings' to add API Keys and configure notifications" & Environment.NewLine & _
                                "  + Click 'Send Test' to send a test message" & Environment.NewLine & _
                                "  + Click 'Start' to start listening for completed trades " & Environment.NewLine & Environment.NewLine & _
                                "PLEASE Donate! I am a full time nursing student could really use the support." & Environment.NewLine & Environment.NewLine & _
                                "Best Wishes and Peace to all! " & Environment.NewLine & " -JJ12880")

        SendIconTrayNotificaiton("CryptoNotify", "Click settings to get started!")
    End Sub
    Private Sub SetLockoutEmailSMS()
        My.Settings.SendEmail = False
        My.Settings.SendSMS = False
    End Sub
    Private Sub SetDonationBoxes()
        Me.TBBTCADDY.SelectionStart() = 0
        Me.TBBTCADDY.SelectionLength = Me.TBBTCADDY.Text.Length
        Me.TBBTCADDY.ScrollToCaret()


    End Sub
    Private Sub OutputJsonDll()

        Dim FByte() As Byte = My.Resources.Newtonsoft_Json
        Try
            My.Computer.FileSystem.WriteAllBytes(Directory.GetCurrentDirectory & "/Newtonsoft.Json.dll", FByte, False)
        Catch ex As Exception

        End Try

    End Sub

#End Region
#Region "RSS"
    Dim RSSNewsURL As String = "http://www.repeatserver.com/Users/JJ12880/news.xml"
    Dim RSSUpdatesURL As String = "http://www.repeatserver.com/Users/JJ12880/updates.xml"
    Private Sub ReadAllRSS()

        Dim wr As WebRequest = System.Net.WebRequest.Create(RSSNewsURL)
        Dim resp As WebResponse = wr.GetResponse()

        Dim rssStream As Stream = resp.GetResponseStream()
        Dim rssDoc As New XmlDocument()
        rssDoc.Load(rssStream)

        Dim rssItems As XmlNodeList = rssDoc.SelectNodes("rss/channel/item")

        Dim title As String = ""
        Dim link As String = ""
        Dim description As String = ""
        Dim i As Integer

        For i = 0 To rssItems.Count - 1
            Dim rssDetail As XmlNode
            'Get the title
            rssDetail = rssItems.Item(i).SelectSingleNode("title")
            If rssDetail.Equals(Nothing) = False Then
                title = rssDetail.InnerText
            Else
                title = ""
            End If
            'Get the link
            Try
                rssDetail = rssItems.Item(i).SelectSingleNode("link")
                If rssDetail.Equals(Nothing) = False Then
                    link = rssDetail.InnerText
                Else
                    link = ""
                End If
            Catch ex As Exception

            End Try

            'Get the description
            rssDetail = rssItems.Item(i).SelectSingleNode("description")
            If rssDetail.Equals(Nothing) = False Then
                description = rssDetail.InnerText
            Else
                description = ""
            End If

            'title
            'link
            'description 
        Next
    End Sub
    Private Function ReadLatestRSS(ByVal url As String)
        Dim RSSMSG As New RSSMessage
        Dim wr As WebRequest = System.Net.WebRequest.Create(url)
        Dim resp As WebResponse

        Dim task1 As New Task(Sub()
                                  resp = wr.GetResponse
                              End Sub)

        task1.Start()

        Do Until task1.Status = TaskStatus.RanToCompletion
            Application.DoEvents()
        Loop





        Dim rssStream As Stream = resp.GetResponseStream()
        Dim rssDoc As New XmlDocument()
        rssDoc.Load(rssStream)

        Dim rssItems As XmlNodeList = rssDoc.SelectNodes("rss/channel/item")

        Dim title As String = ""
        Dim link As String = ""
        Dim description As String = ""



        Dim rssDetail As XmlNode
        'Get the title
        rssDetail = rssItems.Item(0).SelectSingleNode("title")
        If rssDetail.Equals(Nothing) = False Then
            RSSMSG.subject = rssDetail.InnerText
        Else
            RSSMSG.subject = ""
        End If
        'Get the link
        Try
            rssDetail = rssItems.Item(0).SelectSingleNode("link")
            If rssDetail.Equals(Nothing) = False Then
                RSSMSG.link = rssDetail.InnerText
            Else
                RSSMSG.link = ""
            End If
        Catch ex As Exception
            link = " "
        End Try

        'Get the description
        rssDetail = rssItems.Item(0).SelectSingleNode("description")
        If rssDetail.Equals(Nothing) = False Then
            RSSMSG.message = rssDetail.InnerText
        Else
            RSSMSG.message = ""
        End If

        Return RSSMSG

    End Function
    Private Sub ShowLatestRSSNews()
        Dim msg = ReadLatestRSS(RSSNewsURL)
        If My.Settings.LatestRSS <> msg.subject Then
            My.Settings.LatestRSS = msg.subject
        End If

        RTBAlert.Text = msg.message
        LL1.Text = msg.link
        'ShowLinkLablemMessageBox(msg.subject, msg.message, msg.link)
    End Sub
    Private Sub ShowLatestRSSNewsIfNew()
        Dim msg As RSSMessage = ReadLatestRSS(RSSNewsURL)
        If My.Settings.LatestRSS <> msg.subject Then
            My.Settings.LatestRSS = msg.subject
            ShowLinkLablemMessageBox(msg.subject, msg.message, msg.link)
        End If
    End Sub


    Private Sub ShowUpdateIfNewRSS()
        Dim msg As RSSMessage = ReadLatestRSS(RSSUpdatesURL)
        If "v0.9-beta.3" <> msg.subject Then



            ShowLinkLablemMessageBox("Update Avalible", msg.message, msg.link)
        End If
        If msg.message.Contains("HARDSTOP") And msg.message.Contains("v0.9-beta.3") Then
            ShowLinkLablemMessageBox("ALERT", "Developer has blacklisted this version of CryptoNotify. Please update to the latest version, and/or refer to announcement page or github for more information", "http://coinblab.com/forums/topic/112/crypto-notify-desktop-notifications-for-bittrex-trades")
            End
        End If
    End Sub


#End Region

#Region "Notification"
    Private Sub SendAlert(ByVal neworder As order, ByVal type As String)

        Dim Subject As String = "Bittrex Order Filled"
        Dim message As String

        If type = "part" Then
            message = neworder.market & " " & neworder.type.Remove(0, 6) & "-Part" & Environment.NewLine & _
                "Price " & Format(neworder.price, "0.#########") & Environment.NewLine & _
                "Filled " & neworder.filled & Environment.NewLine & _
                "Remaining " & neworder.quantity - neworder.filled & Environment.NewLine & _
                "Time " & TimeOfDay.TimeOfDay.ToString & Environment.NewLine
        Else
            message = neworder.market & " " & neworder.type.Remove(0, 6) & Environment.NewLine & _
                "Price " & Format(neworder.price, "0.#########") & Environment.NewLine & _
                "Quantity " & neworder.quantity & Environment.NewLine & _
                "Time " & TimeOfDay.TimeOfDay.ToString & Environment.NewLine & _
                "Please Remember To Donate!"
        End If










        If My.Settings.SendEmail = True Then sendnotification(My.Settings.Email, "CryptoNotify Message", message)
        If My.Settings.SendSMS Then sendnotification(My.Settings.CellAddress, "CryptoNotify Message", message)
        If My.Settings.SendSystemTray Then SendIconTrayNotificaiton("CryptoNotify Message", message)
        If My.Settings.SendSound Then My.Computer.Audio.Play(My.Resources.sound1, AudioPlayMode.Background)
        If My.Settings.SendPopup Then ShowLinkLablemMessageBox("CryptoNotify Message", message, "https://bittrex.com/Market/Index?MarketName=" & neworder.market)










    End Sub
    Public Sub sendnotification(ByVal address As String, ByVal subject As String, ByVal message As String)

        Dim mail As New MailMessage()

        mail = New MailMessage()
        mail.From = New MailAddress(My.Settings.OutGoingEmailAddy)
        mail.To.Add(address)




        mail.Subject = subject
        mail.Body = message
        Do While BackgroundEmail.IsBusy = True
            Application.DoEvents()
        Loop
        BackgroundEmail.RunWorkerAsync(mail)


    End Sub
    Private Sub BWEmail(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundEmail.DoWork
        Dim SmtpServer As New SmtpClient
        Dim mail As New MailMessage
        ' inactive in current version 
        SmtpServer.Credentials = New Net.NetworkCredential(My.Settings.OutGoingEmailUsername, My.Settings.OutGoingEmailPass)
        SmtpServer.Port = My.Settings.OutGoingEmailPort
        SmtpServer.Host = My.Settings.OutGoingEmailServer
        SmtpServer.EnableSsl = True
        mail = e.Argument
        Try
            SmtpServer.Send(mail)
        Catch ex As Exception

        End Try



    End Sub
    Public Sub SendTest(sender As Object, e As EventArgs)

        Dim message As String = "BTC-TEST Sell" & Environment.NewLine & "Price TEST Price" & Environment.NewLine & "Quantity TEST" & Environment.NewLine & "Time " & TimeOfDay.TimeOfDay.ToString & Environment.NewLine & "Dev by JJ12880" & Environment.NewLine & "Please Remember To Donate!"



        If My.Settings.SendEmail = True Then sendnotification(My.Settings.Email, "CryptoNotify Test Message", message)
        If My.Settings.SendSMS Then sendnotification(My.Settings.CellAddress, "CryptoNotify Test Message", message)
        If My.Settings.SendSystemTray Then SendIconTrayNotificaiton("CryptoNotify Test Message", message)
        If My.Settings.SendSound Then My.Computer.Audio.Play(My.Resources.sound1, AudioPlayMode.Background)
        If My.Settings.SendPopup Then ShowMessageBox("CryptoNotify Test Message", message)





    End Sub

#End Region

#Region "TrayIcon"
    Private contextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents menuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents menuItem2 As System.Windows.Forms.MenuItem
    Public Sub SetIcons()
        Me.Icon = My.Resources.appicon
        Me.Update()
        LargeMessageForm.Icon = My.Resources.appicon
        LargeMessageForm.Update()
        MessageForm.Icon = My.Resources.appicon
        MessageForm.Update()
        SettingsDialog.Icon = My.Resources.appicon
        SettingsDialog.Update()






        Me.components = New System.ComponentModel.Container
        Me.contextMenu1 = New System.Windows.Forms.ContextMenu
        Me.menuItem1 = New System.Windows.Forms.MenuItem
        Me.menuItem2 = New System.Windows.Forms.MenuItem

        ' Initialize contextMenu1 
        Me.contextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem1})

        ' Initialize menuItem1 
        Me.menuItem1.Index = 0
        Me.menuItem1.Text = "E&xit"
        Me.menuItem2.Index = 1
        Me.menuItem2.Text = "Restore"

        ' Set up how the form should be displayed. 
        'Me.ClientSize = New System.Drawing.Size(292, 266)
        'Me.Text = "Notify Icon Example"

        ' Create the NotifyIcon. 
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)

        ' The Icon property sets the icon that will appear 
        ' in the systray for this application.

        Try
            NotifyIcon1.Icon = My.Resources.appicon
        Catch ex As Exception

        End Try


        ' The ContextMenu property sets the menu that will 
        ' appear when the systray icon is right clicked.
        NotifyIcon1.ContextMenu = Me.contextMenu1

        ' The Text property sets the text that will be displayed, 
        ' in a tooltip, when the mouse hovers over the systray icon.
        NotifyIcon1.Text = "CryptoNotify"
        NotifyIcon1.Visible = True
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BTNSystemTray.Click
        Me.WindowState = FormWindowState.Minimized
        NotifyIcon1.ShowBalloonTip(3000, "CryptoNotify Running in System Tray", "Click Icon to Restore CryptoNotify Window", ToolTipIcon.Info)

        Me.Hide()
    End Sub

    Private Sub notifyIcon1_DoubleClick(Sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        ' Show the form when the user double clicks on the notify icon. 

        ' Set the WindowState to normal if the form is minimized.
        Me.Show()
        Me.WindowState = FormWindowState.Normal



        ' Activate the form.
        Me.Activate()
    End Sub

    Private Sub menuItem1_Click(Sender As Object, e As EventArgs) Handles menuItem1.Click
        ' Close the form, which closes the application.
        Me.Close()
    End Sub
    Private Sub menuItem2_Click(Sender As Object, e As EventArgs) Handles menuItem2.Click
        ' Close the form, which closes the application.
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub SendIconTrayNotificaiton(ByVal title, ByVal message)
        NotifyIcon1.ShowBalloonTip(864000, title, message, ToolTipIcon.Info)
    End Sub

#End Region

#Region "MessageBoxes"
    Sub ShowDialogBox(ByVal subject As String, ByVal message As String)
        Dim msg As New MessageForm
        msg.StartPosition = FormStartPosition.CenterScreen
        msg.RTBAlert.Text = message
        msg.Text = subject
        msg.ShowDialog()
    End Sub
    Sub ShowMessageBox(ByVal subject As String, ByVal message As String)
        Dim msg As New MessageForm
        msg.StartPosition = FormStartPosition.CenterScreen
        msg.RTBAlert.Text = message
        msg.Text = subject
        msg.Show()
    End Sub

    Sub ShowLargeMessageBox(ByVal subject As String, ByVal message As String)
        Dim msg As New LargeMessageForm
        msg.StartPosition = FormStartPosition.CenterScreen
        Dim results As New DialogResult
        msg.RTBAlert.Text = message
        msg.Text = subject
        DialogResult = msg.ShowDialog()


    End Sub


    Function ShowPrivacyMessageBox(ByVal subject As String, ByVal message As String)
        Dim msg As New PrivacyWarningForm
        msg.StartPosition = FormStartPosition.CenterScreen
        Dim results As New DialogResult
        msg.RTBAlert.Text = message
        msg.Text = subject
        DialogResult = msg.ShowDialog()
        Return DialogResult

    End Function

    Function ShowConfirmMessageBox(ByVal subject As String, ByVal message As String)
        Dim msg As New ConfirmForm
        msg.StartPosition = FormStartPosition.CenterParent
        Dim results As New DialogResult
        msg.RTBAlert.Text = message
        msg.Text = subject
        DialogResult = msg.ShowDialog()
        Return DialogResult

    End Function
    Function ShowLinkLablemMessageBox(ByVal subject As String, ByVal message As String, ByVal link As String)
        Dim msg As New LinkLableMessageForm
        msg.StartPosition = FormStartPosition.CenterParent
        msg.RTBAlert.Text = message
        msg.Text = subject
        msg.LinkLabel.Text = link
        DialogResult = msg.ShowDialog()
        Return DialogResult

    End Function
#End Region

#Region "Timers"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles GetDataTimer.Tick
        GetDataTimer.Stop()
        GetData(Nothing, Nothing)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles RSSTimer.Tick
        RSSTimer.Stop()
        If RSSTimer.Interval <> 1800000 Then
            ShowUpdateIfNewRSS()
            ShowLatestRSSNews()
            RSSTimer.Interval = 1800000
            RSSTimer.Start()
            Exit Sub

        End If

        ShowLatestRSSNewsIfNew()
        RSSTimer.Start()

    End Sub

#End Region





End Class
