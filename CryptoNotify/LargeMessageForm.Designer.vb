<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LargeMessageForm
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
        Me.BTNOK = New System.Windows.Forms.Button()
        Me.RTBAlert = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'BTNOK
        '
        Me.BTNOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNOK.Location = New System.Drawing.Point(269, 285)
        Me.BTNOK.Name = "BTNOK"
        Me.BTNOK.Size = New System.Drawing.Size(93, 29)
        Me.BTNOK.TabIndex = 3
        Me.BTNOK.Text = "OK"
        Me.BTNOK.UseVisualStyleBackColor = True
        '
        'RTBAlert
        '
        Me.RTBAlert.BackColor = System.Drawing.SystemColors.Control
        Me.RTBAlert.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTBAlert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTBAlert.Location = New System.Drawing.Point(12, 12)
        Me.RTBAlert.Name = "RTBAlert"
        Me.RTBAlert.ReadOnly = True
        Me.RTBAlert.Size = New System.Drawing.Size(613, 267)
        Me.RTBAlert.TabIndex = 2
        Me.RTBAlert.Text = ""
        '
        'LargeMessageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 317)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTNOK)
        Me.Controls.Add(Me.RTBAlert)
        Me.Name = "LargeMessageForm"
        Me.Text = "LargeMessageForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTNOK As System.Windows.Forms.Button
    Friend WithEvents RTBAlert As System.Windows.Forms.RichTextBox
End Class
