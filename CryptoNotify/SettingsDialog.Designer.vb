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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBEmailAddress = New System.Windows.Forms.TextBox()
        Me.TBPriKey = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBPubKey = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBPlaySound = New System.Windows.Forms.CheckBox()
        Me.CBPopup = New System.Windows.Forms.CheckBox()
        Me.CBIconTray = New System.Windows.Forms.CheckBox()
        Me.CBMobile = New System.Windows.Forms.CheckBox()
        Me.CBEmail = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBCellNumber = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RBnextell = New System.Windows.Forms.RadioButton()
        Me.RBsprint = New System.Windows.Forms.RadioButton()
        Me.RBVirginMobile = New System.Windows.Forms.RadioButton()
        Me.RBTmobile = New System.Windows.Forms.RadioButton()
        Me.RBVerizon = New System.Windows.Forms.RadioButton()
        Me.RBUSCellular = New System.Windows.Forms.RadioButton()
        Me.RBalltel = New System.Windows.Forms.RadioButton()
        Me.RBATT = New System.Windows.Forms.RadioButton()
        Me.BTNClearAll = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Location = New System.Drawing.Point(12, 310)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(136, 39)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Save and Close"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.Location = New System.Drawing.Point(307, 310)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(136, 39)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Email Address "
        '
        'TBEmailAddress
        '
        Me.TBEmailAddress.Enabled = False
        Me.TBEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBEmailAddress.Location = New System.Drawing.Point(136, 74)
        Me.TBEmailAddress.Name = "TBEmailAddress"
        Me.TBEmailAddress.Size = New System.Drawing.Size(304, 26)
        Me.TBEmailAddress.TabIndex = 18
        '
        'TBPriKey
        '
        Me.TBPriKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPriKey.Location = New System.Drawing.Point(136, 41)
        Me.TBPriKey.Name = "TBPriKey"
        Me.TBPriKey.Size = New System.Drawing.Size(304, 26)
        Me.TBPriKey.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = " API Key"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Private API Key"
        '
        'TBPubKey
        '
        Me.TBPubKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPubKey.Location = New System.Drawing.Point(136, 9)
        Me.TBPubKey.Name = "TBPubKey"
        Me.TBPubKey.Size = New System.Drawing.Size(304, 26)
        Me.TBPubKey.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBPlaySound)
        Me.GroupBox1.Controls.Add(Me.CBPopup)
        Me.GroupBox1.Controls.Add(Me.CBIconTray)
        Me.GroupBox1.Controls.Add(Me.CBMobile)
        Me.GroupBox1.Controls.Add(Me.CBEmail)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(153, 134)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Send Alerts Via.."
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
        'CBMobile
        '
        Me.CBMobile.AutoSize = True
        Me.CBMobile.Enabled = False
        Me.CBMobile.Location = New System.Drawing.Point(3, 39)
        Me.CBMobile.Name = "CBMobile"
        Me.CBMobile.Size = New System.Drawing.Size(74, 24)
        Me.CBMobile.TabIndex = 1
        Me.CBMobile.Text = "Mobile"
        Me.CBMobile.UseVisualStyleBackColor = True
        '
        'CBEmail
        '
        Me.CBEmail.AutoSize = True
        Me.CBEmail.Enabled = False
        Me.CBEmail.Location = New System.Drawing.Point(3, 16)
        Me.CBEmail.Name = "CBEmail"
        Me.CBEmail.Size = New System.Drawing.Size(71, 24)
        Me.CBEmail.TabIndex = 0
        Me.CBEmail.Text = "Email "
        Me.CBEmail.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Mobile #"
        '
        'TBCellNumber
        '
        Me.TBCellNumber.Enabled = False
        Me.TBCellNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCellNumber.Location = New System.Drawing.Point(136, 106)
        Me.TBCellNumber.Name = "TBCellNumber"
        Me.TBCellNumber.Size = New System.Drawing.Size(304, 26)
        Me.TBCellNumber.TabIndex = 22
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
        Me.GroupBox2.Location = New System.Drawing.Point(204, 151)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(225, 140)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Mobile Carrier"
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
        'BTNClearAll
        '
        Me.BTNClearAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNClearAll.Location = New System.Drawing.Point(161, 310)
        Me.BTNClearAll.Name = "BTNClearAll"
        Me.BTNClearAll.Size = New System.Drawing.Size(136, 39)
        Me.BTNClearAll.TabIndex = 25
        Me.BTNClearAll.Text = "Clear All"
        '
        'SettingsDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 361)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTNClearAll)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBCellNumber)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBEmailAddress)
        Me.Controls.Add(Me.TBPriKey)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBPubKey)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents TBPriKey As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBPubKey As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBCellNumber As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RBnextell As System.Windows.Forms.RadioButton
    Friend WithEvents RBsprint As System.Windows.Forms.RadioButton
    Friend WithEvents RBVirginMobile As System.Windows.Forms.RadioButton
    Friend WithEvents RBTmobile As System.Windows.Forms.RadioButton
    Friend WithEvents RBVerizon As System.Windows.Forms.RadioButton
    Friend WithEvents RBUSCellular As System.Windows.Forms.RadioButton
    Friend WithEvents RBalltel As System.Windows.Forms.RadioButton
    Friend WithEvents RBATT As System.Windows.Forms.RadioButton
    Friend WithEvents CBIconTray As System.Windows.Forms.CheckBox
    Friend WithEvents CBMobile As System.Windows.Forms.CheckBox
    Friend WithEvents CBEmail As System.Windows.Forms.CheckBox
    Friend WithEvents CBPopup As System.Windows.Forms.CheckBox
    Friend WithEvents CBPlaySound As System.Windows.Forms.CheckBox
    Friend WithEvents BTNClearAll As System.Windows.Forms.Button

End Class
