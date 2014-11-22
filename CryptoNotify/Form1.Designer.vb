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
        Me.BTNTest = New System.Windows.Forms.Button()
        Me.BTNSettings = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.BTNSystemTray = New System.Windows.Forms.Button()
        Me.RSSTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LBLStatusColor = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LBLStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTNStart
        '
        Me.BTNStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNStart.Location = New System.Drawing.Point(12, 12)
        Me.BTNStart.Name = "BTNStart"
        Me.BTNStart.Size = New System.Drawing.Size(116, 51)
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
        'BTNTest
        '
        Me.BTNTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNTest.Location = New System.Drawing.Point(134, 12)
        Me.BTNTest.Name = "BTNTest"
        Me.BTNTest.Size = New System.Drawing.Size(145, 51)
        Me.BTNTest.TabIndex = 7
        Me.BTNTest.Text = "Send Test"
        Me.BTNTest.UseVisualStyleBackColor = True
        Me.BTNTest.Visible = False
        '
        'BTNSettings
        '
        Me.BTNSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSettings.Location = New System.Drawing.Point(285, 12)
        Me.BTNSettings.Name = "BTNSettings"
        Me.BTNSettings.Size = New System.Drawing.Size(124, 51)
        Me.BTNSettings.TabIndex = 8
        Me.BTNSettings.Text = "Settings"
        Me.BTNSettings.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Development by JJ12880"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 169)
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
        Me.BTNSystemTray.Location = New System.Drawing.Point(12, 69)
        Me.BTNSystemTray.Name = "BTNSystemTray"
        Me.BTNSystemTray.Size = New System.Drawing.Size(397, 38)
        Me.BTNSystemTray.TabIndex = 14
        Me.BTNSystemTray.Text = "Minimize to System Tray"
        Me.BTNSystemTray.UseVisualStyleBackColor = True
        Me.BTNSystemTray.Visible = False
        '
        'RSSTimer
        '
        Me.RSSTimer.Interval = 150
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(62, 169)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(340, 19)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Text = "13zcYHbYgbLScCE8BWZZ1SZZ6mdmqEbMyz"
        '
        'LBLStatusColor
        '
        Me.LBLStatusColor.AutoSize = True
        Me.LBLStatusColor.BackColor = System.Drawing.Color.Red
        Me.LBLStatusColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLStatusColor.Location = New System.Drawing.Point(78, 117)
        Me.LBLStatusColor.Name = "LBLStatusColor"
        Me.LBLStatusColor.Size = New System.Drawing.Size(17, 20)
        Me.LBLStatusColor.TabIndex = 16
        Me.LBLStatusColor.Text = "  "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Status:"
        '
        'LBLStatus
        '
        Me.LBLStatus.AutoSize = True
        Me.LBLStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLStatus.Location = New System.Drawing.Point(101, 117)
        Me.LBLStatus.Name = "LBLStatus"
        Me.LBLStatus.Size = New System.Drawing.Size(116, 20)
        Me.LBLStatus.TabIndex = 18
        Me.LBLStatus.Text = "Not Connected"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(421, 200)
        Me.Controls.Add(Me.LBLStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LBLStatusColor)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BTNSystemTray)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNSettings)
        Me.Controls.Add(Me.BTNTest)
        Me.Controls.Add(Me.BTNStart)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CryptoNotify v0.9-beta.2.1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNStart As System.Windows.Forms.Button
    Friend WithEvents GetDataTimer As System.Windows.Forms.Timer
    Friend WithEvents BackgroundEmail As System.ComponentModel.BackgroundWorker
    Friend WithEvents BTNTest As System.Windows.Forms.Button
    Friend WithEvents BTNSettings As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents BTNSystemTray As System.Windows.Forms.Button
    Friend WithEvents RSSTimer As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LBLStatusColor As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LBLStatus As System.Windows.Forms.Label

End Class
