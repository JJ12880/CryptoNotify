Imports System.Windows.Forms
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text
Imports Newtonsoft.Json.Linq
Imports System.Net.Sockets
Imports System.Net.Mail

Public Class SettingsDialog
    Dim donated As Boolean = False
    Dim infoerror As Boolean = False



#Region "ExchangeSettingsTab"
    Private Function SaveExchangeSettings(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSaveExchangeSettings.Click


        If Not IsNumeric(TBRefreshInterval.Text) Then
            Form1.ShowMessageBox("ERROR!", "Refresh interval must be a number!")
            Return 0
        End If

        If TBRefreshInterval.Text < 5 Then
            Form1.ShowMessageBox("ERROR!", "Fastest refresh interval is 5 seconds!" & Environment.NewLine & Environment.NewLine & "Please increase refresh interval")
            Return 0
        End If

        If TBPriKey.Text.Length <> 32 Or TBPubKey.Text.Length <> 32 Then
            Form1.ShowMessageBox("ERROR!", "There is a problem with the API Keys")
            infoerror = True
            Return 0
        End If
        My.Settings.RefreshInterval = TBRefreshInterval.Text
        My.Settings.Pubkey = TBPubKey.Text
        My.Settings.Prikey = TBPriKey.Text

        LBLExchangeSettingsSaved.Text = "Settings Saved"
        LblExchangeSettingsSavedColor.BackColor = Color.Green

        Form1.GetDataTimer.Interval = CDbl(TBRefreshInterval.Text) * 1000



        Return 1


    End Function
    Private Sub TestAPIKeys(sender As Object, e As EventArgs) Handles BTNTestAPIKeys.Click
        LBLBittrexStatusColor.BackColor = Color.Yellow
        LBLBittrexStatus.Text = "Testing"


        My.Settings.Pubkey = TBPubKey.Text
        My.Settings.Prikey = TBPriKey.Text
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




        Dim test As Object


        Try
            Dim t As Task = Task.Run(Sub()
                                         test = client.DownloadString(URI)

                                     End Sub)
            Do While t.IsCompleted = False
                Application.DoEvents()
            Loop
            test = JObject.Parse(test)

            ' test = JObject.Parse(client.DownloadString(URI))
        Catch ex As Exception
            LBLBittrexStatus.Text = "Network Error, no connection to Bittrex!"
            LBLBittrexStatusColor.BackColor = Color.Red
            Exit Sub
        End Try

        Dim str As String = test("success")

        If test("success") = "False" Then
            LBLBittrexStatusColor.BackColor = Color.Yellow
            LBLBittrexStatus.Text = "Connected, But API Keys are BAD!"

            Exit Sub
        Else
            LBLBittrexStatusColor.BackColor = Color.Green
            LBLBittrexStatus.Text = "Connected! API Keys good!"
        End If

    End Sub
    Private Sub TBPubKey_TextChanged(sender As Object, e As EventArgs) Handles TBPubKey.TextChanged

        LBLExchangeSettingsSaved.Text = "Form Contains Unsaved Settings!"
        LblExchangeSettingsSavedColor.BackColor = Color.Red
    End Sub
    Private Sub TBPriKey_TextChanged(sender As Object, e As EventArgs) Handles TBPriKey.TextChanged

        LBLExchangeSettingsSaved.Text = "Form Contains Unsaved Settings!"
        LblExchangeSettingsSavedColor.BackColor = Color.Red
    End Sub
    Private Sub ExchangeSettingsCancel(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNExchangeSettingsCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

#End Region

#Region "NotificatonSettingsTab"
    Private Sub CBEmail_CheckedChanged(sender As Object, e As EventArgs) Handles CBEmail.CheckStateChanged

        If CBEmail.CheckState = CheckState.Checked Then
            TBEmailAddress.Enabled = True
            If CBUseOutgoingEmail.CheckState = False Then

                Form1.ShowDialogBox("Warning!", "Outgoing Email Must be Enabled and Configured to use this feature!")
                'If result1 = Windows.Forms.DialogResult.No Then CBMobile.CheckState = CheckState.Unchecked
                'If result1 = Windows.Forms.DialogResult.OK Then result2 = Form1.ShowConfirmMessageBox("Are you sure?", "I understand this option is unsecure and still want to enable it")
                CBEmail.CheckState = CheckState.Unchecked
                TABDonations.SelectTab(2)
            End If
        Else
            TBEmailAddress.Enabled = False
        End If




    End Sub
    Private Sub CBMobile_CheckedChanged(sender As Object, e As EventArgs) Handles CBMobile.CheckStateChanged

        If CBMobile.CheckState = CheckState.Checked Then
            TBCellNumber.Enabled = True

            If CBUseOutgoingEmail.CheckState = False Then
                TBCellNumber.Enabled = False
                Form1.ShowDialogBox("Warning!", "Outgoing Email Must be Enabled and Configured to use this feature!")
                'If result1 = Windows.Forms.DialogResult.No Then CBMobile.CheckState = CheckState.Unchecked
                'If result1 = Windows.Forms.DialogResult.OK Then result2 = Form1.ShowConfirmMessageBox("Are you sure?", "I understand this option is unsecure and still want to enable it")
                CBMobile.CheckState = CheckState.Unchecked
                TABDonations.SelectTab(2)
            End If
            If SaveOutgoinEmail(Nothing, Nothing) = 0 Then
                TBCellNumber.Enabled = False
                Form1.ShowDialogBox("Warning!", "Outgoing Email is not correctly configured!")
                'If result1 = Windows.Forms.DialogResult.No Then CBMobile.CheckState = CheckState.Unchecked
                'If result1 = Windows.Forms.DialogResult.OK Then result2 = Form1.ShowConfirmMessageBox("Are you sure?", "I understand this option is unsecure and still want to enable it")
                CBMobile.CheckState = CheckState.Unchecked
                TABDonations.SelectTab(2)
            End If




        Else
            TBCellNumber.Enabled = False
        End If
    End Sub
    Function MakeCellAddress(CellNumber As String) As String




        If RBATT.Checked = True Then My.Settings.Network = "@txt.att.net"
        If RBnextell.Checked = True Then My.Settings.Network = "messaging.nextel.com"
        If RBsprint.Checked = True Then My.Settings.Network = "messaging.sprintpcs.com"
        If RBTmobile.Checked = True Then My.Settings.Network = "@tmomail.net"
        If RBUSCellular.Checked = True Then My.Settings.Network = "@mms.uscc.net"
        If RBVerizon.Checked = True Then My.Settings.Network = "@vtext.com"
        If RBalltel.Checked = True Then My.Settings.Network = "@message.alltel.com"
        If RBVirginMobile.Checked = True Then My.Settings.Network = "@vmobl.com"




        My.Settings.CellAddress = My.Settings.Cellnumber & My.Settings.Network

        Return My.Settings.CellAddress
    End Function
    Private Sub BTNTest_Click(sender As Object, e As EventArgs) Handles BTNTestNotification.Click
        If SaveNotificationSettings(Nothing, Nothing) = 0 Then Exit Sub



        My.Settings.CellAddress = MakeCellAddress(TBCellNumber.Text)
        Form1.SendTest(Nothing, Nothing)
    End Sub
    Private Function SaveNotificationSettings(sender As Object, e As EventArgs) Handles BtnNotificationSettingsSave.Click

        If (IsNumeric(TBCellNumber.Text) = False Or TBCellNumber.Text.Length <> 10) And (CBMobile.Checked) Then
            TABDonations.SelectTab(1)
            Form1.ShowMessageBox("ERROR!", "There is a problem with your cell #!")
            infoerror = True
            Return 0
        End If

        If (TBEmailAddress.Text.Contains("@") = False Or TBEmailAddress.Text = "") And (CBEmail.Checked) Then
            TABDonations.SelectTab(1)
            Form1.ShowMessageBox("ERROR!", "There is a problem with your Email!")
            infoerror = True
            Return 0
        End If
        If CBEmail.Checked = False And CBMobile.Checked = False And CBPlaySound.Checked = False And CBPopup.Checked = False And CBIconTray.Checked = False Then
            TABDonations.SelectTab(1)
            Form1.ShowMessageBox("ERROR!", "You Must Enable at Least one Form of Notification!")
            Return 0
        End If

        If CBEmail.Checked = True Or CBMobile.Checked = True Then
            If SaveOutgoinEmail(Nothing, Nothing) = 0 Then Return 0
        End If





        My.Settings.Email = TBEmailAddress.Text
        My.Settings.Cellnumber = TBCellNumber.Text
        If CBEmail.Checked = True Then My.Settings.SendEmail = True Else My.Settings.SendEmail = False
        If CBMobile.Checked = True Then My.Settings.SendSMS = True Else My.Settings.SendSMS = False
        If CBIconTray.Checked = True Then My.Settings.SendSystemTray = True Else My.Settings.SendSystemTray = False
        If CBPopup.Checked = True Then My.Settings.SendPopup = True Else My.Settings.SendPopup = False
        If CBPlaySound.Checked = True Then My.Settings.SendSound = True Else My.Settings.SendSound = False

        My.Settings.CellAddress = MakeCellAddress(TBCellNumber.Text)
        LblNotificationSettingsStatus.Text = "Settings Saved"
        LBLNotificationSettingsColor.BackColor = Color.Green
        Return 1
    End Function
    Private Sub NotificationSettingsUnsaved(sender As Object, e As EventArgs) Handles TBEmailAddress.TextChanged, TBCellNumber.TextChanged, CBEmail.CheckedChanged, CBIconTray.CheckedChanged, CBPopup.CheckedChanged, CBPlaySound.CheckedChanged, RBATT.CheckedChanged, RBVerizon.CheckedChanged, RBTmobile.CheckedChanged, RBsprint.CheckedChanged, RBnextell.CheckedChanged, RBalltel.CheckedChanged, RBUSCellular.CheckedChanged, RBVirginMobile.CheckedChanged, CBMobile.CheckedChanged
        LblNotificationSettingsStatus.Text = "Form Contains Unsaved Settings!"
        LBLNotificationSettingsColor.BackColor = Color.Red
    End Sub
    Private Sub BTNotificationSettingsSaveClose_Click(sender As Object, e As EventArgs) Handles BTNotificationSettingsSaveClose.Click
        SaveNotificationSettings(Nothing, Nothing)



        Form1.ShowDialogBox("Sucess!", "Settings updated! Click the Start button to begin waiting for new trades!")
        My.Settings.CellAddress = MakeCellAddress(TBCellNumber.Text)
        DialogResult = System.Windows.Forms.DialogResult.OK

        UpdateConfigSettings()
        Me.Close()

    End Sub
    Private Sub BTNNotificationCancle_Click(sender As Object, e As EventArgs) Handles BTNNotificationCancle.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub



#End Region

#Region "OutgoingEmailTab"
    Private Sub BtnTestEmailSettings_Click(sender As Object, e As EventArgs) Handles BtnTestEmailSettings.Click
        My.Settings.OutGoingEmailAddy = TBOutgoingEmailAddy.Text
        My.Settings.OutGoingEmailPass = TBOutgoingEmailPass.Text
        My.Settings.OutGoingEmailPort = TBOutgointEmailPort.Text
        My.Settings.OutGoingEmailServer = TBOutgoingEmailServer.Text
        My.Settings.OutGoingEmailUsername = TBOutgoingEmailUsername.Text
        My.Settings.UseOutgoinEmail = CBUseOutgoingEmail.CheckState




        If Not SmtpHelper.TestConnection(TBOutgoingEmailServer.Text, TBOutgointEmailPort.Text) Then
            LblEmailStatusColor.BackColor = Color.Red
            LblEmailStatus.Text = "Unable to connect to smtp server"
            Exit Sub
        Else
            LblEmailStatusColor.BackColor = Color.Yellow
            LblEmailStatus.Text = "Connected to server, checking"
        End If


        Dim mail As New MailMessage()

        mail = New MailMessage()
        mail.From = New MailAddress(My.Settings.OutGoingEmailAddy)
        mail.To.Add(My.Settings.OutGoingEmailAddy)




        mail.Subject = "CryptoNotify Test Message"
        mail.Body = "If you have recieved this email, your outgoing email settings are working!"



        BWTestEmail.RunWorkerAsync(mail)


    End Sub
    Private Sub EnableOutgoignEmail_CheckedChanged(sender As Object, e As EventArgs) Handles CBUseOutgoingEmail.CheckedChanged

        My.Settings.UseOutgoinEmail = CBUseOutgoingEmail.CheckState
        GBOutgoingEmail.Visible = CBUseOutgoingEmail.CheckState
        LblOutgoingEmailSettingsColor.BackColor = Color.Red
        LblOutgoingEmailSettingsStatus.Text = "Form Contains Unsaved Settings!"
        If CBUseOutgoingEmail.CheckState = False Then

            CBMobile.Checked = False
            CBEmail.Checked = False
            TBEmailAddress.Enabled = False
            TBCellNumber.Enabled = False
        End If

    End Sub
    Private Sub BWTestEmail_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BWTestEmail.DoWork
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
            BWTestEmail.ReportProgress(0)
            Exit Sub
        End Try
        BWTestEmail.ReportProgress(1)
    End Sub
    Private Sub EmailTestResults(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BWTestEmail.ProgressChanged
        If e.ProgressPercentage = 1 Then
            LblEmailStatusColor.BackColor = Color.Green
            LblEmailStatus.Text = "Able to send email!"
        Else
            LblEmailStatusColor.BackColor = Color.Yellow
            LblEmailStatus.Text = "Invalid Login"
        End If

    End Sub
    Private Sub OutgoingEmailSettingsUnsaved(sender As Object, e As EventArgs) Handles TBOutgoingEmailAddy.TextChanged, TBOutgoingEmailUsername.TextChanged, TBOutgoingEmailPass.TextChanged, TBOutgoingEmailServer.TextChanged, TBOutgointEmailPort.TextChanged
        LblOutgoingEmailSettingsStatus.Text = "Form Contains Unsaved Settings!"
        LblOutgoingEmailSettingsColor.BackColor = Color.Red
    End Sub
    Private Function SaveOutgoinEmail(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNOutgoinSave.Click

        If CBUseOutgoingEmail.Checked = False Then Return 1


        If (TBOutgoingEmailAddy.Text.Contains("@") = False Or TBOutgoingEmailAddy.Text = "") Then
            TABDonations.SelectTab(2)
            Form1.ShowMessageBox("ERROR!", "There is a problem with your outgoing email address!")
            Return 0
        End If

        If (TBOutgoingEmailUsername.Text = "") Then
            TABDonations.SelectTab(2)
            Form1.ShowMessageBox("ERROR!", "Username cannot be blank!")
            Return 0
        End If
        If (TBOutgoingEmailPass.Text = "") Then
            TABDonations.SelectTab(2)
            Form1.ShowMessageBox("ERROR!", "Password cannot be blank!")
            Return 0
        End If

        If TBOutgoingEmailServer.Text.ToUpper.Contains("SMTP") = False Then
            TABDonations.SelectTab(2)
            Form1.ShowMessageBox("ERROR!", "Outgoing Server must be a SMTP server")
            Return 0
        End If




        If (TBOutgointEmailPort.Text = "") Then
            TABDonations.SelectTab(2)
            Form1.ShowMessageBox("ERROR!", "Port cannot be blank!")
            Return 0
        End If

        If IsNumeric(TBOutgointEmailPort.Text) = False Then
            TABDonations.SelectTab(2)
            Form1.ShowMessageBox("ERROR!", "Port must be numeric!")
            Return 0
        End If

        My.Settings.OutGoingEmailAddy = TBOutgoingEmailAddy.Text
        My.Settings.OutGoingEmailPass = TBOutgoingEmailPass.Text
        My.Settings.OutGoingEmailPort = TBOutgointEmailPort.Text
        My.Settings.OutGoingEmailServer = TBOutgoingEmailServer.Text
        My.Settings.OutGoingEmailUsername = TBOutgoingEmailUsername.Text
        My.Settings.UseOutgoinEmail = CBUseOutgoingEmail.CheckState


        LblOutgoingEmailSettingsStatus.Text = "Settings Saved"
        LblOutgoingEmailSettingsColor.BackColor = Color.Green


        Return 1

    End Function
    Private Sub OutgoinEmailSaveClose()
        SaveOutgoinEmail(Nothing, Nothing)
        Me.Close()
    End Sub
    Private Sub BTNOutgoingCancel_Click(sender As Object, e As EventArgs) Handles BTNOutgoingCancel.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub

#End Region

#Region "DonationsTab"



    'Private Function getdonationamountpast30()


    '    Dim URI As String = "https://bittrex.com/api/v1.1/account/getwithdrawalhistory?currency=BTC&" & "apikey=" & My.Settings.Pubkey & "&nonce=" & Environment.TickCount


    '    Dim request = WebRequest.Create("https://bittrex.com/api/v1.1/")




    '    Dim hmAcSha = New HMACSHA512(Encoding.ASCII.GetBytes(My.Settings.Prikey))
    '    Dim URIbyte = Encoding.ASCII.GetBytes(URI)
    '    Dim hashmessage = hmAcSha.ComputeHash(URIbyte)
    '    Dim sign = BitConverter.ToString(hashmessage)
    '    sign = sign.Replace("-", "")

    '    Dim client As New WebClient()
    '    client.Headers.Add("apisign", sign)




    '    Dim test As JObject


    '    Try
    '        test = JObject.Parse(client.DownloadString(URI))
    '    Catch ex As Exception



    '    End Try


    '    For Each x As JObject In test("result")
    '        If x("Address") = "13zcYHbYgbLScCE8BWZZ1SZZ6mdmqEbMyz" Then
    '            Dim time As DateTime = x("Opened")
    '            Dim amount As Double = x("Amount")
    '            Dim exp As DateTime = DateTime.Now.AddDays(-30)

    '            If time > exp Then
    '                LBLDonations.Text = "You have donated " & amount & " in the past 30 days"
    '                donated = True
    '            End If




    '        End If


    '        'neworder.market = x("Exchange")
    '        'neworder.type = x("OrderType")
    '        'neworder.quantity = x("Quantity")
    '        'neworder.price = Format(x("Limit"), "0.#########")
    '        'neworder.filled = CDbl(x("Quantity")) - CDbl(x("QuantityRemaining"))
    '        'neworder.remaining = x("QuantityRemaining")
    '        'neworder.ID = x("OrderUuid")


    '    Next














    'End Function

#End Region







#Region "Configuration Settings"
    Private Sub UpdateConfigSettings()
        My.Settings.Pubkey = TBPubKey.Text
        My.Settings.Prikey = TBPriKey.Text
        My.Settings.Email = TBEmailAddress.Text
        My.Settings.Cellnumber = TBCellNumber.Text
        My.Settings.OutGoingEmailAddy = TBOutgoingEmailAddy.Text
        My.Settings.OutGoingEmailPass = TBOutgoingEmailPass.Text
        My.Settings.OutGoingEmailPort = TBOutgointEmailPort.Text
        My.Settings.OutGoingEmailServer = TBOutgoingEmailServer.Text
        My.Settings.OutGoingEmailUsername = TBOutgoingEmailUsername.Text
        My.Settings.UseOutgoinEmail = CBUseOutgoingEmail.CheckState
        If CBEmail.Checked = True Then My.Settings.SendEmail = True Else My.Settings.SendEmail = False
        If CBMobile.Checked = True Then My.Settings.SendSMS = True Else My.Settings.SendSMS = False
        If CBIconTray.Checked = True Then My.Settings.SendSystemTray = True Else My.Settings.SendSystemTray = False
        If CBPopup.Checked = True Then My.Settings.SendPopup = True Else My.Settings.SendPopup = False
        If CBPlaySound.Checked = True Then My.Settings.SendSound = True Else My.Settings.SendSound = False
    End Sub
    Private Sub LoadConfigSettings() Handles Me.Load
        TBPubKey.Text = My.Settings.Pubkey
        TBPriKey.Text = My.Settings.Prikey
        TBEmailAddress.Text = My.Settings.Email
        TBCellNumber.Text = My.Settings.Cellnumber
        TBOutgoingEmailAddy.Text = My.Settings.OutGoingEmailAddy
        TBOutgoingEmailUsername.Text = My.Settings.OutGoingEmailUsername
        TBOutgoingEmailPass.Text = My.Settings.OutGoingEmailPass
        TBOutgoingEmailServer.Text = My.Settings.OutGoingEmailServer
        TBOutgointEmailPort.Text = My.Settings.OutGoingEmailPort
        CBUseOutgoingEmail.Checked = My.Settings.UseOutgoinEmail

        'getdonationamountpast30()






        If My.Settings.SendEmail = True Then
            CBEmail.CheckState = CheckState.Checked
            If My.Settings.UseOutgoinEmail Then TBEmailAddress.Enabled = True
        Else
            CBEmail.CheckState = CheckState.Unchecked
            TBEmailAddress.Enabled = False
        End If




        If My.Settings.SendSMS = True Then
            CBMobile.CheckState = CheckState.Checked
            If My.Settings.UseOutgoinEmail Then TBCellNumber.Enabled = True
        Else
            CBMobile.CheckState = CheckState.Unchecked
            TBCellNumber.Enabled = False
        End If



        If My.Settings.SendSystemTray = True Then CBIconTray.CheckState = CheckState.Checked Else CBIconTray.CheckState = CheckState.Unchecked
        If My.Settings.SendPopup = True Then CBPopup.CheckState = CheckState.Checked Else CBPopup.CheckState = CheckState.Unchecked
        If My.Settings.SendSound = True Then CBPlaySound.CheckState = CheckState.Checked Else CBPlaySound.CheckState = CheckState.Unchecked






        Select Case My.Settings.Network
            Case "@txt.att.net"
                RBATT.Checked = True
            Case "messaging.nextel.com"
                RBnextell.Checked = True
            Case "messaging.sprintpcs.com"
                RBsprint.Checked = True
            Case "@tmomail.net"
                RBTmobile.Checked = True
            Case "@mms.uscc.net"
                RBUSCellular.Checked = True
            Case "@vtext.com"
                RBVerizon.Checked = True
            Case "@message.alltel.com"
                RBalltel.Checked = True
        End Select

        Application.DoEvents()

        LblNotificationSettingsStatus.Text = "Settings Saved"
        LBLNotificationSettingsColor.BackColor = Color.Green()


        LblOutgoingEmailSettingsStatus.Text = "Settings Saved"
        LblOutgoingEmailSettingsColor.BackColor = Color.Green()

        LBLExchangeSettingsSaved.Text = "Settings Saved"
        LblExchangeSettingsSavedColor.BackColor = Color.Green()


    End Sub
#End Region




    Private Sub ClearAll(sender As Object, e As EventArgs)
        My.Settings.SendEmail = False
        My.Settings.SendPopup = False
        My.Settings.SendSMS = False
        My.Settings.SendSystemTray = False
        My.Settings.SendSound = False
        My.Settings.CellAddress = ""
        My.Settings.Cellnumber = ""
        My.Settings.Email = ""
        My.Settings.Network = ""
        My.Settings.Prikey = ""
        My.Settings.Pubkey = ""
        My.Settings.Save()
        LoadConfigSettings()
    End Sub


    Private Sub BTNExchangeSettingsSaveClose_Click(sender As Object, e As EventArgs) Handles BTNExchangeSettingsSaveClose.Click, BTNotificationSettingsSaveClose.Click, BTNOutgoingSaveClose.Click
        If SaveExchangeSettings(Nothing, Nothing) = 0 Then Exit Sub
        If SaveOutgoinEmail(Nothing, Nothing) = 0 Then Exit Sub
        If SaveNotificationSettings(Nothing, Nothing) = 0 Then Exit Sub

        'Insert settings validation here!!!
        Form1.BTNStart.Show()
        Me.Close()





    End Sub






End Class
