<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmForm
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
        Me.BTNCancel = New System.Windows.Forms.Button()
        Me.BTNOk = New System.Windows.Forms.Button()
        Me.RTBAlert = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'BTNCancel
        '
        Me.BTNCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCancel.Location = New System.Drawing.Point(244, 65)
        Me.BTNCancel.Name = "BTNCancel"
        Me.BTNCancel.Size = New System.Drawing.Size(101, 37)
        Me.BTNCancel.TabIndex = 6
        Me.BTNCancel.Text = "Cancel"
        Me.BTNCancel.UseVisualStyleBackColor = True
        '
        'BTNOk
        '
        Me.BTNOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNOk.Location = New System.Drawing.Point(113, 65)
        Me.BTNOk.Name = "BTNOk"
        Me.BTNOk.Size = New System.Drawing.Size(101, 37)
        Me.BTNOk.TabIndex = 5
        Me.BTNOk.Text = "OK"
        Me.BTNOk.UseVisualStyleBackColor = True
        '
        'RTBAlert
        '
        Me.RTBAlert.BackColor = System.Drawing.SystemColors.Control
        Me.RTBAlert.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTBAlert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTBAlert.Location = New System.Drawing.Point(3, 8)
        Me.RTBAlert.Name = "RTBAlert"
        Me.RTBAlert.ReadOnly = True
        Me.RTBAlert.Size = New System.Drawing.Size(454, 51)
        Me.RTBAlert.TabIndex = 7
        Me.RTBAlert.Text = ""
        '
        'ConfirmForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 118)
        Me.ControlBox = False
        Me.Controls.Add(Me.RTBAlert)
        Me.Controls.Add(Me.BTNCancel)
        Me.Controls.Add(Me.BTNOk)
        Me.Name = "ConfirmForm"
        Me.Text = "ConfirmForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTNCancel As System.Windows.Forms.Button
    Friend WithEvents BTNOk As System.Windows.Forms.Button
    Friend WithEvents RTBAlert As System.Windows.Forms.RichTextBox
End Class
