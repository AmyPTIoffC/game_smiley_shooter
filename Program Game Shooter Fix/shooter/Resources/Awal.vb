Public Class Awal
    Private Sub FadeIn()
        Dim iCount As Integer
        For iCount = 10 To 100 Step +2
            Me.Opacity = iCount / 100
            Me.Refresh()
            Threading.Thread.Sleep(50)
        Next
    End Sub
    Private Sub FadeOut()
        Dim iCount As Integer
        For iCount = 100 To 10 Step -2
            Me.Opacity = iCount / 100
            Me.Refresh()
            Threading.Thread.Sleep(50)
        Next
        Me.Close()
    End Sub

    Private Sub Awal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FadeIn()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        FadeOut()
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewGameToolStripMenuItem.Click
        Me.Hide()
        FormMain.Show()
    End Sub

    Private Sub AuthorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuthorToolStripMenuItem.Click
        Me.Hide()
        author.Show()
    End Sub
End Class