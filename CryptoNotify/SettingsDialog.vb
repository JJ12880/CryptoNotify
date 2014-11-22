Imports System.Windows.Forms

Public Class SettingsDialog
   
    Dim infoerror As Boolean = False
   
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        My.Settings.Pubkey = TBPubKey.Text
        My.Settings.Prikey = TBPriKey.Text
        My.Settings.Email = TBEmailAddress.Text
        My.Settings.Cellnumber = TBCellNumber.Text
        infoerror = False


        If (IsNumeric(My.Settings.Cellnumber) = False Or My.Settings.Cellnumber.Length <> 10) And (CBMobile.Checked) Then
            Form1.ShowMessageBox("ERROR!", "There is a problem with your cell #!")
            infoerror = True
        End If

        If (My.Settings.Email.Contains("@") = False Or My.Settings.Email = "") And (CBEmail.Checked) Then
            Form1.ShowMessageBox("ERROR!", "There is a problem with your Email!")
            infoerror = True
        End If



        If My.Settings.Prikey.Length <> 32 Or My.Settings.Pubkey.Length <> 32 Then
            Form1.ShowMessageBox("ERROR!", "There is a problem with the API Keys")
            infoerror = True
        End If



        If infoerror = False Then

            Form1.ShowDialogBox("Sucess!", "Settings updated! Click the Start button to begin waiting for new trades!")
            My.Settings.CellAddress = MakeCellAddress(TBCellNumber.Text)
            DialogResult = System.Windows.Forms.DialogResult.OK

            UpdateConfigSettings()
            Me.Close()
        End If


    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
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
   
    Private Sub CBEmail_CheckedChanged(sender As Object, e As EventArgs) Handles CBEmail.CheckStateChanged
        If CBEmail.CheckState = CheckState.Checked Then
            Dim result2 As DialogResult




            Dim result1 As DialogResult = Form1.ShowPrivacyMessageBox("Privacy & Security Alert", "Email Notifications are not secure! Your email address will be accessable to the developer, in the form of logs generated for each alert sent." & Environment.NewLine & Environment.NewLine & _
                                                                      "Also, there is not *YET* encryption of your email address, which means your email could be exposed in the event of a security breach. This will be addressed in a future program version. Use your primary email address at your own risk. Please contact JJ12880 with any questions." _
                                                                      & Environment.NewLine & Environment.NewLine & "Please donate to BTC address at the bottom of the main window!" & Environment.NewLine & "Please confirm you wish to enable this option") 'MessageBox.Show("Email Notifications are not secure!  Your email address and trade data will be accessable to the developer, in the form of logs generated for each alert sent. Also, there is not *YET* encryption of your email address, which could be a concern in the case of a security breach. This will be addressed in a future program version. Use your primary email address at your own risk. Please contact JJ12880 with any questions.  Also feel free to donate to BTC address at the bottom of the main window. ", , MessageBoxButtons.YesNo)
            If result1 = Windows.Forms.DialogResult.No Then CBEmail.CheckState = CheckState.Unchecked
            If result1 = Windows.Forms.DialogResult.OK Then result2 = Form1.ShowConfirmMessageBox("Are you sure?", "I understand this option is unsecure and still want to enable it")
            If result2 = Windows.Forms.DialogResult.OK Then CBEmail.CheckState = CheckState.Checked Else CBEmail.CheckState = CheckState.Unchecked
        End If




    End Sub

    Private Sub CBMobile_CheckedChanged(sender As Object, e As EventArgs) Handles CBMobile.CheckStateChanged
        If CBMobile.CheckState = CheckState.Checked Then
            Dim result2 As DialogResult

            Dim result1 As DialogResult = Form1.ShowPrivacyMessageBox("Privacy & Security Alert", "Mobile Notifications are not secure!  Your mobile # will be accessable to the developer, in the form of logs generated for each alert sent." & Environment.NewLine & Environment.NewLine & _
                                                                      "Also, there is not *YET* encryption of your number, which means your number could be exposed in the event of a security breach. This will be addressed in a future program version. Use your primary number at your own risk. Please contact JJ12880 with any questions." _
                                                                      & Environment.NewLine & Environment.NewLine & "Please donate to BTC address at the bottom of the main window!" & Environment.NewLine & "Please confirm you wish to enable this option")
            If result1 = Windows.Forms.DialogResult.No Then CBMobile.CheckState = CheckState.Unchecked
            If result1 = Windows.Forms.DialogResult.OK Then result2 = Form1.ShowConfirmMessageBox("Are you sure?", "I understand this option is unsecure and still want to enable it")
            If result2 = Windows.Forms.DialogResult.OK Then CBMobile.CheckState = CheckState.Checked Else CBMobile.CheckState = CheckState.Unchecked


        End If
    End Sub

#Region "Configuration Settings"
    Private Sub UpdateConfigSettings()
       
        
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



        ' If My.Settings.SendEmail = True Then CBEmail.CheckState = CheckState.Checked Else CBEmail.CheckState = CheckState.Unchecked
        ' If My.Settings.SendSMS = True Then CBMobile.CheckState = CheckState.Checked Else CBMobile.CheckState = CheckState.Unchecked
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


    End Sub
#End Region


    Private Sub TBPubKey_TextChanged(sender As Object, e As EventArgs) Handles TBPubKey.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNClearAll.Click
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
End Class
