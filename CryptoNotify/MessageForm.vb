Public Class MessageForm
    Private Sub meload() Handles Me.Load
        Me.Activate()

    End Sub
    Private Sub BTNOK_Click(sender As Object, e As EventArgs) Handles BTNOK.Click
        Me.Dispose()
    End Sub
End Class