<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BWTestEmail = New System.ComponentModel.BackgroundWorker()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CBUseOutgoingEmail = New System.Windows.Forms.CheckBox()
        Me.GBOutgoingEmail = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBOutgoingEmailAddy = New System.Windows.Forms.TextBox()
        Me.TBOutgoingEmailUsername = New System.Windows.Forms.TextBox()
        Me.TBOutgoingEmailServer = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnTestEmailSettings = New System.Windows.Forms.Button()
        Me.TBOutgoingEmailPass = New System.Windows.Forms.TextBox()
        Me.BTNOutgoinSave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTNOutgoingCancel = New System.Windows.Forms.Button()
        Me.BTNOutgoingSaveClose = New System.Windows.Forms.Button()
        Me.TBOutgointEmailPort = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblEmailStatusColor = New System.Windows.Forms.Label()
        Me.LblEmailStatus = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LblOutgoingEmailSettingsColor = New System.Windows.Forms.Label()
        Me.LblOutgoingEmailSettingsStatus = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BTNTestNotification = New System.Windows.Forms.Button()
        Me.TBCellNumber = New System.Windows.Forms.TextBox()
        Me.TBEmailAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBEmail = New System.Windows.Forms.CheckBox()
        Me.CBMobile = New System.Windows.Forms.CheckBox()
        Me.CBIconTray = New System.Windows.Forms.CheckBox()
        Me.CBPopup = New System.Windows.Forms.CheckBox()
        Me.CBPlaySound = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RBATT = New System.Windows.Forms.RadioButton()
        Me.RBalltel = New System.Windows.Forms.RadioButton()
        Me.RBUSCellular = New System.Windows.Forms.RadioButton()
        Me.RBVerizon = New System.Windows.Forms.RadioButton()
        Me.RBTmobile = New System.Windows.Forms.RadioButton()
        Me.RBVirginMobile = New System.Windows.Forms.RadioButton()
        Me.RBsprint = New System.Windows.Forms.RadioButton()
        Me.RBnextell = New System.Windows.Forms.RadioButton()
        Me.BTNotificationSettingsSaveClose = New System.Windows.Forms.Button()
        Me.BTNNotificationCancle = New System.Windows.Forms.Button()
        Me.BtnNotificationSettingsSave = New System.Windows.Forms.Button()
        Me.LBLNotificationSettingsColor = New System.Windows.Forms.Label()
        Me.LblNotificationSettingsStatus = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BTNExchangeSettingsSaveClose = New System.Windows.Forms.Button()
        Me.BTNExchangeSettingsCancel = New System.Windows.Forms.Button()
        Me.BTNSaveExchangeSettings = New System.Windows.Forms.Button()
        Me.LblExchangeSettingsSavedColor = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TBPubKey = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBPriKey = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBLBittrexStatusColor = New System.Windows.Forms.Label()
        Me.LBLBittrexStatus = New System.Windows.Forms.Label()
        Me.BTNTestAPIKeys = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TBRefreshInterval = New System.Windows.Forms.TextBox()
        Me.LBLExchangeSettingsSaved = New System.Windows.Forms.Label()
        Me.TABDonations = New System.Windows.Forms.TabControl()
        Me.TabPage3.SuspendLayout()
        Me.GBOutgoingEmail.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TABDonations.SuspendLayout()
        Me.SuspendLayout()
        '
        'BWTestEmail
        '
        Me.BWTestEmail.WorkerReportsProgress = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.LblOutgoingEmailSettingsStatus)
        Me.TabPage3.Controls.Add(Me.LblOutgoingEmailSettingsColor)
        Me.TabPage3.Controls.Add(Me.GBOutgoingEmail)
        Me.TabPage3.Controls.Add(Me.CBUseOutgoingEmail)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(460, 389)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Outging Email Settings"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 20)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Use Outgoing Email?"
        '
        'CBUseOutgoingEmail
        '
        Me.CBUseOutgoingEmail.AutoSize = True
        Me.CBUseOutgoingEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBUseOutgoingEmail.Location = New System.Drawing.Point(194, 47)
        Me.CBUseOutgoingEmail.Name = "CBUseOutgoingEmail"
        Me.CBUseOutgoingEmail.Size = New System.Drawing.Size(171, 21)
        Me.CBUseOutgoingEmail.TabIndex = 42
        Me.CBUseOutgoingEmail.Text = "Enable Outgoing Email"
        Me.CBUseOutgoingEmail.UseVisualStyleBackColor = True
        '
        'GBOutgoingEmail
        '
        Me.GBOutgoingEmail.Controls.Add(Me.Label13)
        Me.GBOutgoingEmail.Controls.Add(Me.Label12)
        Me.GBOutgoingEmail.Controls.Add(Me.LblEmailStatus)
        Me.GBOutgoingEmail.Controls.Add(Me.LblEmailStatusColor)
        Me.GBOutgoingEmail.Controls.Add(Me.Label11)
        Me.GBOutgoingEmail.Controls.Add(Me.TBOutgointEmailPort)
        Me.GBOutgoingEmail.Controls.Add(Me.BTNOutgoingSaveClose)
        Me.GBOutgoingEmail.Controls.Add(Me.BTNOutgoingCancel)
        Me.GBOutgoingEmail.Controls.Add(Me.Label8)
        Me.GBOutgoingEmail.Controls.Add(Me.BTNOutgoinSave)
        Me.GBOutgoingEmail.Controls.Add(Me.TBOutgoingEmailPass)
        Me.GBOutgoingEmail.Controls.Add(Me.BtnTestEmailSettings)
        Me.GBOutgoingEmail.Controls.Add(Me.Label9)
        Me.GBOutgoingEmail.Controls.Add(Me.TBOutgoingEmailServer)
        Me.GBOutgoingEmail.Controls.Add(Me.TBOutgoingEmailUsername)
        Me.GBOutgoingEmail.Controls.Add(Me.TBOutgoingEmailAddy)
        Me.GBOutgoingEmail.Controls.Add(Me.Label7)
        Me.GBOutgoingEmail.Controls.Add(Me.Label6)
        Me.GBOutgoingEmail.Controls.Add(Me.Label5)
        Me.GBOutgoingEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GBOutgoingEmail.Location = New System.Drawing.Point(8, 74)
        Me.GBOutgoingEmail.Name = "GBOutgoingEmail"
        Me.GBOutgoingEmail.Size = New System.Drawing.Size(446, 309)
        Me.GBOutgoingEmail.TabIndex = 43
        Me.GBOutgoingEmail.TabStop = False
        Me.GBOutgoingEmail.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 20)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Outgoing Email Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 20)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "SMTP Server"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "SMTP Port"
        '
        'TBOutgoingEmailAddy
        '
        Me.TBOutgoingEmailAddy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBOutgoingEmailAddy.Location = New System.Drawing.Point(203, 15)
        Me.TBOutgoingEmailAddy.Name = "TBOutgoingEmailAddy"
        Me.TBOutgoingEmailAddy.Size = New System.Drawing.Size(232, 26)
        Me.TBOutgoingEmailAddy.TabIndex = 31
        '
        'TBOutgoingEmailUsername
        '
        Me.TBOutgoingEmailUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBOutgoingEmailUsername.Location = New System.Drawing.Point(129, 47)
        Me.TBOutgoingEmailUsername.Name = "TBOutgoingEmailUsername"
        Me.TBOutgoingEmailUsername.Size = New System.Drawing.Size(163, 26)
        Me.TBOutgoingEmailUsername.TabIndex = 32
        '
        'TBOutgoingEmailServer
        '
        Me.TBOutgoingEmailServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBOutgoingEmailServer.Location = New System.Drawing.Point(129, 111)
        Me.TBOutgoingEmailServer.Name = "TBOutgoingEmailServer"
        Me.TBOutgoingEmailServer.Size = New System.Drawing.Size(163, 26)
        Me.TBOutgoingEmailServer.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 20)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "UserName"
        '
        'BtnTestEmailSettings
        '
        Me.BtnTestEmailSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTestEmailSettings.Location = New System.Drawing.Point(148, 211)
        Me.BtnTestEmailSettings.Name = "BtnTestEmailSettings"
        Me.BtnTestEmailSettings.Size = New System.Drawing.Size(136, 39)
        Me.BtnTestEmailSettings.TabIndex = 30
        Me.BtnTestEmailSettings.Text = "Test Email"
        Me.BtnTestEmailSettings.UseVisualStyleBackColor = True
        '
        'TBOutgoingEmailPass
        '
        Me.TBOutgoingEmailPass.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBOutgoingEmailPass.Location = New System.Drawing.Point(129, 79)
        Me.TBOutgoingEmailPass.Name = "TBOutgoingEmailPass"
        Me.TBOutgoingEmailPass.Size = New System.Drawing.Size(163, 25)
        Me.TBOutgoingEmailPass.TabIndex = 33
        '
        'BTNOutgoinSave
        '
        Me.BTNOutgoinSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNOutgoinSave.Location = New System.Drawing.Point(6, 256)
        Me.BTNOutgoinSave.Name = "BTNOutgoinSave"
        Me.BTNOutgoinSave.Size = New System.Drawing.Size(136, 39)
        Me.BTNOutgoinSave.TabIndex = 29
        Me.BTNOutgoinSave.Text = "Save"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 20)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Password"
        '
        'BTNOutgoingCancel
        '
        Me.BTNOutgoingCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTNOutgoingCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNOutgoingCancel.Location = New System.Drawing.Point(148, 256)
        Me.BTNOutgoingCancel.Name = "BTNOutgoingCancel"
        Me.BTNOutgoingCancel.Size = New System.Drawing.Size(136, 39)
        Me.BTNOutgoingCancel.TabIndex = 28
        Me.BTNOutgoingCancel.Text = "Cancel"
        '
        'BTNOutgoingSaveClose
        '
        Me.BTNOutgoingSaveClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNOutgoingSaveClose.Location = New System.Drawing.Point(6, 211)
        Me.BTNOutgoingSaveClose.Name = "BTNOutgoingSaveClose"
        Me.BTNOutgoingSaveClose.Size = New System.Drawing.Size(136, 39)
        Me.BTNOutgoingSaveClose.TabIndex = 27
        Me.BTNOutgoingSaveClose.Text = "Save and Close"
        '
        'TBOutgointEmailPort
        '
        Me.TBOutgointEmailPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBOutgointEmailPort.Location = New System.Drawing.Point(129, 143)
        Me.TBOutgointEmailPort.Name = "TBOutgointEmailPort"
        Me.TBOutgointEmailPort.Size = New System.Drawing.Size(163, 26)
        Me.TBOutgointEmailPort.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 182)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(162, 20)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Email Settings Status"
        '
        'LblEmailStatusColor
        '
        Me.LblEmailStatusColor.AutoSize = True
        Me.LblEmailStatusColor.BackColor = System.Drawing.Color.Red
        Me.LblEmailStatusColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmailStatusColor.Location = New System.Drawing.Point(183, 182)
        Me.LblEmailStatusColor.Name = "LblEmailStatusColor"
        Me.LblEmailStatusColor.Size = New System.Drawing.Size(16, 17)
        Me.LblEmailStatusColor.TabIndex = 42
        Me.LblEmailStatusColor.Text = "  "
        '
        'LblEmailStatus
        '
        Me.LblEmailStatus.AutoSize = True
        Me.LblEmailStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmailStatus.Location = New System.Drawing.Point(205, 182)
        Me.LblEmailStatus.Name = "LblEmailStatus"
        Me.LblEmailStatus.Size = New System.Drawing.Size(87, 20)
        Me.LblEmailStatus.TabIndex = 43
        Me.LblEmailStatus.Text = "Not Tested"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(298, 146)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 20)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "(Default: 587)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(298, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 20)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "(smtp.gmail.com)"
        '
        'LblOutgoingEmailSettingsColor
        '
        Me.LblOutgoingEmailSettingsColor.AutoSize = True
        Me.LblOutgoingEmailSettingsColor.BackColor = System.Drawing.Color.Green
        Me.LblOutgoingEmailSettingsColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOutgoingEmailSettingsColor.Location = New System.Drawing.Point(4, 3)
        Me.LblOutgoingEmailSettingsColor.Name = "LblOutgoingEmailSettingsColor"
        Me.LblOutgoingEmailSettingsColor.Size = New System.Drawing.Size(17, 20)
        Me.LblOutgoingEmailSettingsColor.TabIndex = 46
        Me.LblOutgoingEmailSettingsColor.Text = "  "
        '
        'LblOutgoingEmailSettingsStatus
        '
        Me.LblOutgoingEmailSettingsStatus.AutoSize = True
        Me.LblOutgoingEmailSettingsStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOutgoingEmailSettingsStatus.Location = New System.Drawing.Point(27, 3)
        Me.LblOutgoingEmailSettingsStatus.Name = "LblOutgoingEmailSettingsStatus"
        Me.LblOutgoingEmailSettingsStatus.Size = New System.Drawing.Size(117, 20)
        Me.LblOutgoingEmailSettingsStatus.TabIndex = 47
        Me.LblOutgoingEmailSettingsStatus.Text = "Settings Saved"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.LblNotificationSettingsStatus)
        Me.TabPage2.Controls.Add(Me.LBLNotificationSettingsColor)
        Me.TabPage2.Controls.Add(Me.BtnNotificationSettingsSave)
        Me.TabPage2.Controls.Add(Me.BTNNotificationCancle)
        Me.TabPage2.Controls.Add(Me.BTNotificationSettingsSaveClose)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.TBEmailAddress)
        Me.TabPage2.Controls.Add(Me.TBCellNumber)
        Me.TabPage2.Controls.Add(Me.BTNTestNotification)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(460, 389)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Notification Settings"
        '
        'BTNTestNotification
        '
        Me.BTNTestNotification.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNTestNotification.Location = New System.Drawing.Point(122, 327)
        Me.BTNTestNotification.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNTestNotification.Name = "BTNTestNotification"
        Me.BTNTestNotification.Size = New System.Drawing.Size(210, 39)
        Me.BTNTestNotification.TabIndex = 30
        Me.BTNTestNotification.Text = "Send Test Notifications"
        Me.BTNTestNotification.UseVisualStyleBackColor = True
        '
        'TBCellNumber
        '
        Me.TBCellNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCellNumber.Location = New System.Drawing.Point(140, 73)
        Me.TBCellNumber.Name = "TBCellNumber"
        Me.TBCellNumber.Size = New System.Drawing.Size(304, 26)
        Me.TBCellNumber.TabIndex = 22
        '
        'TBEmailAddress
        '
        Me.TBEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBEmailAddress.Location = New System.Drawing.Point(140, 41)
        Me.TBEmailAddress.Name = "TBEmailAddress"
        Me.TBEmailAddress.Size = New System.Drawing.Size(304, 26)
        Me.TBEmailAddress.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Mobile #"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Email Address "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBPlaySound)
        Me.GroupBox1.Controls.Add(Me.CBPopup)
        Me.GroupBox1.Controls.Add(Me.CBIconTray)
        Me.GroupBox1.Controls.Add(Me.CBMobile)
        Me.GroupBox1.Controls.Add(Me.CBEmail)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(153, 134)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Send Alerts Via.."
        '
        'CBEmail
        '
        Me.CBEmail.AutoSize = True
        Me.CBEmail.Location = New System.Drawing.Point(3, 16)
        Me.CBEmail.Name = "CBEmail"
        Me.CBEmail.Size = New System.Drawing.Size(71, 24)
        Me.CBEmail.TabIndex = 0
        Me.CBEmail.Text = "Email "
        Me.CBEmail.UseVisualStyleBackColor = True
        '
        'CBMobile
        '
        Me.CBMobile.AutoSize = True
        Me.CBMobile.Location = New System.Drawing.Point(3, 39)
        Me.CBMobile.Name = "CBMobile"
        Me.CBMobile.Size = New System.Drawing.Size(74, 24)
        Me.CBMobile.TabIndex = 1
        Me.CBMobile.Text = "Mobile"
        Me.CBMobile.UseVisualStyleBackColor = True
        '
        'CBIconTray
        '
        Me.CBIconTray.AutoSize = True
        Me.CBIconTray.Location = New System.Drawing.Point(3, 62)
        Me.CBIconTray.Name = "CBIconTray"
        Me.CBIconTray.Size = New System.Drawing.Size(93, 24)
        Me.CBIconTray.TabIndex = 3
        Me.CBIconTray.Text = "Icon Tray"
        Me.CBIconTray.UseVisualStyleBackColor = True
        '
        'CBPopup
        '
        Me.CBPopup.AutoSize = True
        Me.CBPopup.Location = New System.Drawing.Point(3, 83)
        Me.CBPopup.Name = "CBPopup"
        Me.CBPopup.Size = New System.Drawing.Size(148, 24)
        Me.CBPopup.TabIndex = 4
        Me.CBPopup.Text = "Pop-up Message"
        Me.CBPopup.UseVisualStyleBackColor = True
        '
        'CBPlaySound
        '
        Me.CBPlaySound.AutoSize = True
        Me.CBPlaySound.Location = New System.Drawing.Point(3, 106)
        Me.CBPlaySound.Name = "CBPlaySound"
        Me.CBPlaySound.Size = New System.Drawing.Size(108, 24)
        Me.CBPlaySound.TabIndex = 5
        Me.CBPlaySound.Text = "Play Sound"
        Me.CBPlaySound.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBnextell)
        Me.GroupBox2.Controls.Add(Me.RBsprint)
        Me.GroupBox2.Controls.Add(Me.RBVirginMobile)
        Me.GroupBox2.Controls.Add(Me.RBTmobile)
        Me.GroupBox2.Controls.Add(Me.RBVerizon)
        Me.GroupBox2.Controls.Add(Me.RBUSCellular)
        Me.GroupBox2.Controls.Add(Me.RBalltel)
        Me.GroupBox2.Controls.Add(Me.RBATT)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(184, 128)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(225, 140)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Mobile Carrier"
        '
        'RBATT
        '
        Me.RBATT.AutoSize = True
        Me.RBATT.Checked = True
        Me.RBATT.Location = New System.Drawing.Point(6, 17)
        Me.RBATT.Margin = New System.Windows.Forms.Padding(2)
        Me.RBATT.Name = "RBATT"
        Me.RBATT.Size = New System.Drawing.Size(56, 24)
        Me.RBATT.TabIndex = 7
        Me.RBATT.TabStop = True
        Me.RBATT.Text = "ATT"
        Me.RBATT.UseVisualStyleBackColor = True
        '
        'RBalltel
        '
        Me.RBalltel.AutoSize = True
        Me.RBalltel.Location = New System.Drawing.Point(97, 39)
        Me.RBalltel.Margin = New System.Windows.Forms.Padding(2)
        Me.RBalltel.Name = "RBalltel"
        Me.RBalltel.Size = New System.Drawing.Size(61, 24)
        Me.RBalltel.TabIndex = 8
        Me.RBalltel.TabStop = True
        Me.RBalltel.Text = "Alltel"
        Me.RBalltel.UseVisualStyleBackColor = True
        '
        'RBUSCellular
        '
        Me.RBUSCellular.AutoSize = True
        Me.RBUSCellular.Location = New System.Drawing.Point(97, 61)
        Me.RBUSCellular.Margin = New System.Windows.Forms.Padding(2)
        Me.RBUSCellular.Name = "RBUSCellular"
        Me.RBUSCellular.Size = New System.Drawing.Size(106, 24)
        Me.RBUSCellular.TabIndex = 9
        Me.RBUSCellular.TabStop = True
        Me.RBUSCellular.Text = "US Cellular"
        Me.RBUSCellular.UseVisualStyleBackColor = True
        '
        'RBVerizon
        '
        Me.RBVerizon.AutoSize = True
        Me.RBVerizon.Location = New System.Drawing.Point(6, 39)
        Me.RBVerizon.Margin = New System.Windows.Forms.Padding(2)
        Me.RBVerizon.Name = "RBVerizon"
        Me.RBVerizon.Size = New System.Drawing.Size(81, 24)
        Me.RBVerizon.TabIndex = 10
        Me.RBVerizon.TabStop = True
        Me.RBVerizon.Text = "Verizon"
        Me.RBVerizon.UseVisualStyleBackColor = True
        '
        'RBTmobile
        '
        Me.RBTmobile.AutoSize = True
        Me.RBTmobile.Location = New System.Drawing.Point(6, 61)
        Me.RBTmobile.Margin = New System.Windows.Forms.Padding(2)
        Me.RBTmobile.Name = "RBTmobile"
        Me.RBTmobile.Size = New System.Drawing.Size(87, 24)
        Me.RBTmobile.TabIndex = 11
        Me.RBTmobile.TabStop = True
        Me.RBTmobile.Text = "T-Mobile" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RBTmobile.UseVisualStyleBackColor = True
        '
        'RBVirginMobile
        '
        Me.RBVirginMobile.AutoSize = True
        Me.RBVirginMobile.Location = New System.Drawing.Point(97, 83)
        Me.RBVirginMobile.Margin = New System.Windows.Forms.Padding(2)
        Me.RBVirginMobile.Name = "RBVirginMobile"
        Me.RBVirginMobile.Size = New System.Drawing.Size(117, 24)
        Me.RBVirginMobile.TabIndex = 12
        Me.RBVirginMobile.TabStop = True
        Me.RBVirginMobile.Text = "Virgin Mobile"
        Me.RBVirginMobile.UseVisualStyleBackColor = True
        '
        'RBsprint
        '
        Me.RBsprint.AutoSize = True
        Me.RBsprint.Location = New System.Drawing.Point(6, 83)
        Me.RBsprint.Margin = New System.Windows.Forms.Padding(2)
        Me.RBsprint.Name = "RBsprint"
        Me.RBsprint.Size = New System.Drawing.Size(69, 24)
        Me.RBsprint.TabIndex = 13
        Me.RBsprint.TabStop = True
        Me.RBsprint.Text = "Sprint"
        Me.RBsprint.UseVisualStyleBackColor = True
        '
        'RBnextell
        '
        Me.RBnextell.AutoSize = True
        Me.RBnextell.Location = New System.Drawing.Point(97, 17)
        Me.RBnextell.Margin = New System.Windows.Forms.Padding(2)
        Me.RBnextell.Name = "RBnextell"
        Me.RBnextell.Size = New System.Drawing.Size(71, 24)
        Me.RBnextell.TabIndex = 14
        Me.RBnextell.TabStop = True
        Me.RBnextell.Text = "Nextel"
        Me.RBnextell.UseVisualStyleBackColor = True
        '
        'BTNotificationSettingsSaveClose
        '
        Me.BTNotificationSettingsSaveClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNotificationSettingsSaveClose.Location = New System.Drawing.Point(158, 285)
        Me.BTNotificationSettingsSaveClose.Name = "BTNotificationSettingsSaveClose"
        Me.BTNotificationSettingsSaveClose.Size = New System.Drawing.Size(134, 39)
        Me.BTNotificationSettingsSaveClose.TabIndex = 27
        Me.BTNotificationSettingsSaveClose.Text = "Save and Close"
        '
        'BTNNotificationCancle
        '
        Me.BTNNotificationCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTNNotificationCancle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNotificationCancle.Location = New System.Drawing.Point(308, 285)
        Me.BTNNotificationCancle.Name = "BTNNotificationCancle"
        Me.BTNNotificationCancle.Size = New System.Drawing.Size(136, 39)
        Me.BTNNotificationCancle.TabIndex = 28
        Me.BTNNotificationCancle.Text = "Cancel"
        '
        'BtnNotificationSettingsSave
        '
        Me.BtnNotificationSettingsSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNotificationSettingsSave.Location = New System.Drawing.Point(10, 285)
        Me.BtnNotificationSettingsSave.Name = "BtnNotificationSettingsSave"
        Me.BtnNotificationSettingsSave.Size = New System.Drawing.Size(136, 39)
        Me.BtnNotificationSettingsSave.TabIndex = 29
        Me.BtnNotificationSettingsSave.Text = "Save"
        '
        'LBLNotificationSettingsColor
        '
        Me.LBLNotificationSettingsColor.AutoSize = True
        Me.LBLNotificationSettingsColor.BackColor = System.Drawing.Color.Green
        Me.LBLNotificationSettingsColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNotificationSettingsColor.Location = New System.Drawing.Point(4, 3)
        Me.LBLNotificationSettingsColor.Name = "LBLNotificationSettingsColor"
        Me.LBLNotificationSettingsColor.Size = New System.Drawing.Size(17, 20)
        Me.LBLNotificationSettingsColor.TabIndex = 33
        Me.LBLNotificationSettingsColor.Text = "  "
        '
        'LblNotificationSettingsStatus
        '
        Me.LblNotificationSettingsStatus.AutoSize = True
        Me.LblNotificationSettingsStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNotificationSettingsStatus.Location = New System.Drawing.Point(27, 3)
        Me.LblNotificationSettingsStatus.Name = "LblNotificationSettingsStatus"
        Me.LblNotificationSettingsStatus.Size = New System.Drawing.Size(117, 20)
        Me.LblNotificationSettingsStatus.TabIndex = 34
        Me.LblNotificationSettingsStatus.Text = "Settings Saved"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.LBLExchangeSettingsSaved)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.LblExchangeSettingsSavedColor)
        Me.TabPage1.Controls.Add(Me.BTNSaveExchangeSettings)
        Me.TabPage1.Controls.Add(Me.BTNExchangeSettingsCancel)
        Me.TabPage1.Controls.Add(Me.BTNExchangeSettingsSaveClose)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(460, 389)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Exchange Settings"
        '
        'BTNExchangeSettingsSaveClose
        '
        Me.BTNExchangeSettingsSaveClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNExchangeSettingsSaveClose.Location = New System.Drawing.Point(9, 240)
        Me.BTNExchangeSettingsSaveClose.Name = "BTNExchangeSettingsSaveClose"
        Me.BTNExchangeSettingsSaveClose.Size = New System.Drawing.Size(136, 39)
        Me.BTNExchangeSettingsSaveClose.TabIndex = 0
        Me.BTNExchangeSettingsSaveClose.Text = "Save and Close"
        '
        'BTNExchangeSettingsCancel
        '
        Me.BTNExchangeSettingsCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTNExchangeSettingsCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNExchangeSettingsCancel.Location = New System.Drawing.Point(292, 240)
        Me.BTNExchangeSettingsCancel.Name = "BTNExchangeSettingsCancel"
        Me.BTNExchangeSettingsCancel.Size = New System.Drawing.Size(136, 39)
        Me.BTNExchangeSettingsCancel.TabIndex = 1
        Me.BTNExchangeSettingsCancel.Text = "Cancel"
        '
        'BTNSaveExchangeSettings
        '
        Me.BTNSaveExchangeSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSaveExchangeSettings.Location = New System.Drawing.Point(150, 240)
        Me.BTNSaveExchangeSettings.Name = "BTNSaveExchangeSettings"
        Me.BTNSaveExchangeSettings.Size = New System.Drawing.Size(136, 39)
        Me.BTNSaveExchangeSettings.TabIndex = 25
        Me.BTNSaveExchangeSettings.Text = "Save"
        '
        'LblExchangeSettingsSavedColor
        '
        Me.LblExchangeSettingsSavedColor.AutoSize = True
        Me.LblExchangeSettingsSavedColor.BackColor = System.Drawing.Color.Green
        Me.LblExchangeSettingsSavedColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExchangeSettingsSavedColor.Location = New System.Drawing.Point(4, 3)
        Me.LblExchangeSettingsSavedColor.Name = "LblExchangeSettingsSavedColor"
        Me.LblExchangeSettingsSavedColor.Size = New System.Drawing.Size(17, 20)
        Me.LblExchangeSettingsSavedColor.TabIndex = 29
        Me.LblExchangeSettingsSavedColor.Text = "  "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TBRefreshInterval)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.BTNTestAPIKeys)
        Me.GroupBox3.Controls.Add(Me.LBLBittrexStatus)
        Me.GroupBox3.Controls.Add(Me.LBLBittrexStatusColor)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TBPriKey)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TBPubKey)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(449, 155)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bittrex Exchange"
        '
        'TBPubKey
        '
        Me.TBPubKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPubKey.Location = New System.Drawing.Point(137, 17)
        Me.TBPubKey.Name = "TBPubKey"
        Me.TBPubKey.Size = New System.Drawing.Size(304, 26)
        Me.TBPubKey.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Private API Key"
        '
        'TBPriKey
        '
        Me.TBPriKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPriKey.Location = New System.Drawing.Point(137, 49)
        Me.TBPriKey.Name = "TBPriKey"
        Me.TBPriKey.Size = New System.Drawing.Size(304, 26)
        Me.TBPriKey.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "API Key"
        '
        'LBLBittrexStatusColor
        '
        Me.LBLBittrexStatusColor.AutoSize = True
        Me.LBLBittrexStatusColor.BackColor = System.Drawing.Color.Red
        Me.LBLBittrexStatusColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBittrexStatusColor.Location = New System.Drawing.Point(143, 129)
        Me.LBLBittrexStatusColor.Name = "LBLBittrexStatusColor"
        Me.LBLBittrexStatusColor.Size = New System.Drawing.Size(17, 20)
        Me.LBLBittrexStatusColor.TabIndex = 19
        Me.LBLBittrexStatusColor.Text = "  "
        '
        'LBLBittrexStatus
        '
        Me.LBLBittrexStatus.AutoSize = True
        Me.LBLBittrexStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBittrexStatus.Location = New System.Drawing.Point(166, 129)
        Me.LBLBittrexStatus.Name = "LBLBittrexStatus"
        Me.LBLBittrexStatus.Size = New System.Drawing.Size(116, 20)
        Me.LBLBittrexStatus.TabIndex = 20
        Me.LBLBittrexStatus.Text = "Not Connected"
        '
        'BTNTestAPIKeys
        '
        Me.BTNTestAPIKeys.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNTestAPIKeys.Location = New System.Drawing.Point(6, 123)
        Me.BTNTestAPIKeys.Name = "BTNTestAPIKeys"
        Me.BTNTestAPIKeys.Size = New System.Drawing.Size(125, 26)
        Me.BTNTestAPIKeys.TabIndex = 28
        Me.BTNTestAPIKeys.Text = "Test API Keys"
        Me.BTNTestAPIKeys.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 86)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(196, 20)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Refresh Interval (seconds)"
        '
        'TBRefreshInterval
        '
        Me.TBRefreshInterval.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBRefreshInterval.Location = New System.Drawing.Point(211, 86)
        Me.TBRefreshInterval.Name = "TBRefreshInterval"
        Me.TBRefreshInterval.Size = New System.Drawing.Size(99, 26)
        Me.TBRefreshInterval.TabIndex = 30
        Me.TBRefreshInterval.Text = "10"
        '
        'LBLExchangeSettingsSaved
        '
        Me.LBLExchangeSettingsSaved.AutoSize = True
        Me.LBLExchangeSettingsSaved.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLExchangeSettingsSaved.Location = New System.Drawing.Point(27, 3)
        Me.LBLExchangeSettingsSaved.Name = "LBLExchangeSettingsSaved"
        Me.LBLExchangeSettingsSaved.Size = New System.Drawing.Size(117, 20)
        Me.LBLExchangeSettingsSaved.TabIndex = 30
        Me.LBLExchangeSettingsSaved.Text = "Settings Saved"
        '
        'TABDonations
        '
        Me.TABDonations.Controls.Add(Me.TabPage1)
        Me.TABDonations.Controls.Add(Me.TabPage2)
        Me.TABDonations.Controls.Add(Me.TabPage3)
        Me.TABDonations.Location = New System.Drawing.Point(0, 2)
        Me.TABDonations.Name = "TABDonations"
        Me.TABDonations.SelectedIndex = 0
        Me.TABDonations.Size = New System.Drawing.Size(468, 415)
        Me.TABDonations.TabIndex = 27
        '
        'SettingsDialog
        '
        Me.AcceptButton = Me.BTNExchangeSettingsSaveClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 429)
        Me.ControlBox = False
        Me.Controls.Add(Me.TABDonations)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GBOutgoingEmail.ResumeLayout(False)
        Me.GBOutgoingEmail.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TABDonations.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BWTestEmail As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents LblOutgoingEmailSettingsStatus As System.Windows.Forms.Label
    Friend WithEvents LblOutgoingEmailSettingsColor As System.Windows.Forms.Label
    Friend WithEvents GBOutgoingEmail As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LblEmailStatus As System.Windows.Forms.Label
    Friend WithEvents LblEmailStatusColor As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TBOutgointEmailPort As System.Windows.Forms.TextBox
    Friend WithEvents BTNOutgoingSaveClose As System.Windows.Forms.Button
    Friend WithEvents BTNOutgoingCancel As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BTNOutgoinSave As System.Windows.Forms.Button
    Friend WithEvents TBOutgoingEmailPass As System.Windows.Forms.TextBox
    Friend WithEvents BtnTestEmailSettings As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TBOutgoingEmailServer As System.Windows.Forms.TextBox
    Friend WithEvents TBOutgoingEmailUsername As System.Windows.Forms.TextBox
    Friend WithEvents TBOutgoingEmailAddy As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CBUseOutgoingEmail As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents LblNotificationSettingsStatus As System.Windows.Forms.Label
    Friend WithEvents LBLNotificationSettingsColor As System.Windows.Forms.Label
    Friend WithEvents BtnNotificationSettingsSave As System.Windows.Forms.Button
    Friend WithEvents BTNNotificationCancle As System.Windows.Forms.Button
    Friend WithEvents BTNotificationSettingsSaveClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RBnextell As System.Windows.Forms.RadioButton
    Friend WithEvents RBsprint As System.Windows.Forms.RadioButton
    Friend WithEvents RBVirginMobile As System.Windows.Forms.RadioButton
    Friend WithEvents RBTmobile As System.Windows.Forms.RadioButton
    Friend WithEvents RBVerizon As System.Windows.Forms.RadioButton
    Friend WithEvents RBUSCellular As System.Windows.Forms.RadioButton
    Friend WithEvents RBalltel As System.Windows.Forms.RadioButton
    Friend WithEvents RBATT As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CBPlaySound As System.Windows.Forms.CheckBox
    Friend WithEvents CBPopup As System.Windows.Forms.CheckBox
    Friend WithEvents CBIconTray As System.Windows.Forms.CheckBox
    Friend WithEvents CBMobile As System.Windows.Forms.CheckBox
    Friend WithEvents CBEmail As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents TBCellNumber As System.Windows.Forms.TextBox
    Friend WithEvents BTNTestNotification As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents LBLExchangeSettingsSaved As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TBRefreshInterval As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents BTNTestAPIKeys As System.Windows.Forms.Button
    Friend WithEvents LBLBittrexStatus As System.Windows.Forms.Label
    Friend WithEvents LBLBittrexStatusColor As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBPriKey As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBPubKey As System.Windows.Forms.TextBox
    Friend WithEvents LblExchangeSettingsSavedColor As System.Windows.Forms.Label
    Friend WithEvents BTNSaveExchangeSettings As System.Windows.Forms.Button
    Friend WithEvents BTNExchangeSettingsCancel As System.Windows.Forms.Button
    Friend WithEvents BTNExchangeSettingsSaveClose As System.Windows.Forms.Button
    Friend WithEvents TABDonations As System.Windows.Forms.TabControl

End Class
