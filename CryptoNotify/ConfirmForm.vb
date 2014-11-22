Public Class ConfirmForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNOk.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Dispose()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTNCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Dispose()
    End Sub

    Private Sub ConfirmForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TopMost = True
    End Sub
End Class