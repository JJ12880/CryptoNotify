Public Class LargeMessageForm


    Private Sub BTNOK_Click(sender As Object, e As EventArgs) Handles BTNOK.Click
        Me.Dispose()
    End Sub

    Private Sub LargeMessageForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TopMost = True
    End Sub
End Class