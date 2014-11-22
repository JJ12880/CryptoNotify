Public Class LinkLableMessageForm

   
 

    Private Sub LinkLabel_Click(sender As Object, e As EventArgs) Handles LinkLabel.Click
        System.Diagnostics.Process.Start(LinkLabel.Text)
    End Sub

    Private Sub BTNOK_Click(sender As Object, e As EventArgs) Handles BTNOK.Click
        Me.Dispose()
    End Sub

    Private Sub LinkLableMessageForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TopMost = True
    End Sub
End Class