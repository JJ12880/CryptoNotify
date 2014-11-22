<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LinkLableMessageForm
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
        Me.LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'BTNOK
        '
        Me.BTNOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTNOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNOK.Location = New System.Drawing.Point(92, 153)
        Me.BTNOK.Name = "BTNOK"
        Me.BTNOK.Size = New System.Drawing.Size(94, 30)
        Me.BTNOK.TabIndex = 3
        Me.BTNOK.Text = "OK"
        Me.BTNOK.UseVisualStyleBackColor = True
        '
        'RTBAlert
        '
        Me.RTBAlert.BackColor = System.Drawing.SystemColors.Control
        Me.RTBAlert.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTBAlert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTBAlert.Location = New System.Drawing.Point(-2, 2)
        Me.RTBAlert.Name = "RTBAlert"
        Me.RTBAlert.ReadOnly = True
        Me.RTBAlert.Size = New System.Drawing.Size(285, 120)
        Me.RTBAlert.TabIndex = 2
        Me.RTBAlert.Text = ""
        '
        'LinkLabel
        '
        Me.LinkLabel.AutoSize = True
        Me.LinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel.Location = New System.Drawing.Point(3, 125)
        Me.LinkLabel.Name = "LinkLabel"
        Me.LinkLabel.Size = New System.Drawing.Size(0, 20)
        Me.LinkLabel.TabIndex = 4
        '
        'LinkLableMessageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 188)
        Me.ControlBox = False
        Me.Controls.Add(Me.LinkLabel)
        Me.Controls.Add(Me.BTNOK)
        Me.Controls.Add(Me.RTBAlert)
        Me.Name = "LinkLableMessageForm"
        Me.Text = "LinkLableMessageForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNOK As System.Windows.Forms.Button
    Friend WithEvents RTBAlert As System.Windows.Forms.RichTextBox
    Friend WithEvents LinkLabel As System.Windows.Forms.LinkLabel
End Class
