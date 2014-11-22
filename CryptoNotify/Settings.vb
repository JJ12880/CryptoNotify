Imports System.Windows.Forms

Public Class Settings
    Public pubkey As String
    Public prikey As String
    Public addy As String

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pubkey = TextBox1.Text
        prikey = TextBox2.Text
        addy = TextBox3.Text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged
        Button1.Show()
    End Sub

   
End Class