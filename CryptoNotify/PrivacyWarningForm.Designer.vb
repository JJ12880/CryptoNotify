<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrivacyWarningForm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RTBAlert = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(197, 234)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 37)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RTBAlert
        '
        Me.RTBAlert.BackColor = System.Drawing.SystemColors.Control
        Me.RTBAlert.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTBAlert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTBAlert.Location = New System.Drawing.Point(12, 12)
        Me.RTBAlert.Name = "RTBAlert"
        Me.RTBAlert.ReadOnly = True
        Me.RTBAlert.Size = New System.Drawing.Size(613, 202)
        Me.RTBAlert.TabIndex = 3
        Me.RTBAlert.Text = ""
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(337, 234)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 37)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PrivacyWarningForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 290)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RTBAlert)
        Me.Controls.Add(Me.Button1)
        Me.Name = "PrivacyWarningForm"
        Me.Text = "PrivacyWarningForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RTBAlert As System.Windows.Forms.RichTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
