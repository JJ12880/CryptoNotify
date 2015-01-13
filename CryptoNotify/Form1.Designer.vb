<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.BTNStart = New System.Windows.Forms.Button()
        Me.GetDataTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundEmail = New System.ComponentModel.BackgroundWorker()
        Me.BTNBittrexSettings = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.BTNSystemTray = New System.Windows.Forms.Button()
        Me.RSSTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TBBTCADDY = New System.Windows.Forms.TextBox()
        Me.LBLBittrexStatusColor = New System.Windows.Forms.Label()
        Me.LBLBittrexStatus = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LL1 = New System.Windows.Forms.LinkLabel()
        Me.RTBAlert = New System.Windows.Forms.RichTextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTNStart
        '
        Me.BTNStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNStart.Location = New System.Drawing.Point(370, 134)
        Me.BTNStart.Name = "BTNStart"
        Me.BTNStart.Size = New System.Drawing.Size(116, 41)
        Me.BTNStart.TabIndex = 1
        Me.BTNStart.Text = "Start"
        Me.BTNStart.UseVisualStyleBackColor = True
        Me.BTNStart.Visible = False
        '
        'GetDataTimer
        '
        Me.GetDataTimer.Interval = 5000
        '
        'BackgroundEmail
        '
        '
        'BTNBittrexSettings
        '
        Me.BTNBittrexSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBittrexSettings.Location = New System.Drawing.Point(217, 134)
        Me.BTNBittrexSettings.Name = "BTNBittrexSettings"
        Me.BTNBittrexSettings.Size = New System.Drawing.Size(142, 41)
        Me.BTNBittrexSettings.TabIndex = 8
        Me.BTNBittrexSettings.Text = "Configure"
        Me.BTNBittrexSettings.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 339)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Development by JJ12880"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 362)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "BTC:"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'BTNSystemTray
        '
        Me.BTNSystemTray.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSystemTray.Location = New System.Drawing.Point(12, 134)
        Me.BTNSystemTray.Name = "BTNSystemTray"
        Me.BTNSystemTray.Size = New System.Drawing.Size(199, 41)
        Me.BTNSystemTray.TabIndex = 14
        Me.BTNSystemTray.Text = "Minimize to System Tray"
        Me.BTNSystemTray.UseVisualStyleBackColor = True
        '
        'RSSTimer
        '
        Me.RSSTimer.Interval = 150
        '
        'TBBTCADDY
        '
        Me.TBBTCADDY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBBTCADDY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBBTCADDY.Location = New System.Drawing.Point(57, 362)
        Me.TBBTCADDY.Name = "TBBTCADDY"
        Me.TBBTCADDY.ReadOnly = True
        Me.TBBTCADDY.Size = New System.Drawing.Size(340, 19)
        Me.TBBTCADDY.TabIndex = 15
        Me.TBBTCADDY.Text = "13zcYHbYgbLScCE8BWZZ1SZZ6mdmqEbMyz"
        '
        'LBLBittrexStatusColor
        '
        Me.LBLBittrexStatusColor.AutoSize = True
        Me.LBLBittrexStatusColor.BackColor = System.Drawing.Color.Red
        Me.LBLBittrexStatusColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBittrexStatusColor.Location = New System.Drawing.Point(105, 34)
        Me.LBLBittrexStatusColor.Name = "LBLBittrexStatusColor"
        Me.LBLBittrexStatusColor.Size = New System.Drawing.Size(24, 26)
        Me.LBLBittrexStatusColor.TabIndex = 16
        Me.LBLBittrexStatusColor.Text = "  "
        '
        'LBLBittrexStatus
        '
        Me.LBLBittrexStatus.AutoSize = True
        Me.LBLBittrexStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBittrexStatus.Location = New System.Drawing.Point(135, 35)
        Me.LBLBittrexStatus.Name = "LBLBittrexStatus"
        Me.LBLBittrexStatus.Size = New System.Drawing.Size(157, 26)
        Me.LBLBittrexStatus.TabIndex = 18
        Me.LBLBittrexStatus.Text = "Not Connected"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(201, 337)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(183, 19)
        Me.TextBox2.TabIndex = 19
        Me.TextBox2.Text = "CryptoNotify@gmail.com"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(10, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(80, 31)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.Text = "Bittrex "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.LBLBittrexStatusColor)
        Me.GroupBox1.Controls.Add(Me.LBLBittrexStatus)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(474, 102)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Exchanges"
        '
        'LL1
        '
        Me.LL1.AutoSize = True
        Me.LL1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LL1.Location = New System.Drawing.Point(8, 315)
        Me.LL1.Name = "LL1"
        Me.LL1.Size = New System.Drawing.Size(38, 20)
        Me.LL1.TabIndex = 25
        Me.LL1.TabStop = True
        Me.LL1.Text = "Link"
        '
        'RTBAlert
        '
        Me.RTBAlert.BackColor = System.Drawing.SystemColors.Control
        Me.RTBAlert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RTBAlert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTBAlert.Location = New System.Drawing.Point(12, 206)
        Me.RTBAlert.Name = "RTBAlert"
        Me.RTBAlert.ReadOnly = True
        Me.RTBAlert.Size = New System.Drawing.Size(474, 106)
        Me.RTBAlert.TabIndex = 24
        Me.RTBAlert.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(12, 181)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(221, 19)
        Me.TextBox3.TabIndex = 26
        Me.TextBox3.Text = "Latest News from CryptoNotify"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(504, 389)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.LL1)
        Me.Controls.Add(Me.RTBAlert)
        Me.Controls.Add(Me.BTNBittrexSettings)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TBBTCADDY)
        Me.Controls.Add(Me.BTNSystemTray)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNStart)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CryptoNotify v0.9-beta.3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNStart As System.Windows.Forms.Button
    Friend WithEvents GetDataTimer As System.Windows.Forms.Timer
    Friend WithEvents BackgroundEmail As System.ComponentModel.BackgroundWorker
    Friend WithEvents BTNBittrexSettings As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents BTNSystemTray As System.Windows.Forms.Button
    Friend WithEvents RSSTimer As System.Windows.Forms.Timer
    Friend WithEvents TBBTCADDY As System.Windows.Forms.TextBox
    Friend WithEvents LBLBittrexStatusColor As System.Windows.Forms.Label
    Friend WithEvents LBLBittrexStatus As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LL1 As System.Windows.Forms.LinkLabel
    Friend WithEvents RTBAlert As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox

End Class
