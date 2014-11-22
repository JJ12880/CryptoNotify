Public Class PrivacyWarningForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Dispose()
    End Sub

    Private Sub PrivacyWarningForm_BackgroundImageChanged(sender As Object, e As EventArgs) Handles Me.BackgroundImageChanged

    End Sub

    Private Sub PrivacyWarningForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TopMost = True
    End Sub
End Class