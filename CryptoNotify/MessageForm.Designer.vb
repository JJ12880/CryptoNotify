<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageForm
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
        Me.RTBAlert = New System.Windows.Forms.RichTextBox()
        Me.BTNOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RTBAlert
        '
        Me.RTBAlert.BackColor = System.Drawing.SystemColors.Control
        Me.RTBAlert.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTBAlert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTBAlert.Location = New System.Drawing.Point(2, 4)
        Me.RTBAlert.Name = "RTBAlert"
        Me.RTBAlert.ReadOnly = True
        Me.RTBAlert.Size = New System.Drawing.Size(274, 120)
        Me.RTBAlert.TabIndex = 0
        Me.RTBAlert.Text = ""
        '
        'BTNOK
        '
        Me.BTNOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNOK.Location = New System.Drawing.Point(97, 144)
        Me.BTNOK.Name = "BTNOK"
        Me.BTNOK.Size = New System.Drawing.Size(83, 30)
        Me.BTNOK.TabIndex = 1
        Me.BTNOK.Text = "OK"
        Me.BTNOK.UseVisualStyleBackColor = True
        '
        'MessageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 186)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTNOK)
        Me.Controls.Add(Me.RTBAlert)
        Me.Name = "MessageForm"
        Me.Text = "Crypto Notify Alert!"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RTBAlert As System.Windows.Forms.RichTextBox
    Friend WithEvents BTNOK As System.Windows.Forms.Button
End Class
