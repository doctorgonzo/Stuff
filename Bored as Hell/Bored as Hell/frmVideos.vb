Public Class frmVideos

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim choices() As String
        choices = {"http://www.youtube.com/user/RayWilliamJohnson", "http://www.youtube.com/user/machinima", "http://www.fark.com/video/", "http://www.wimp.com", "http://www.youtube.com/user/FPSRussia", "http://nyan.cat/", "http://r33b.net/", "http://www.youtube.com/watch?v=uE-1RPDqJAY", "http://www.youtube.com/watch?v=COkrsPzEmrI", "http://www.weebls-stuff.com/songs/magical+trevor/", "http://movies.netflix.com/WiHome", "http://www.google.com/search?q=explosions&tbo=p&tbm=vid&source=vgc&hl=en&aq=f", "http://www.break.com/"}
        Dim rndChoice As Integer
        rndChoice = GetRandom(0, choices.Length - 1)
        Dim url As String
        url = choices(rndChoice)
        webVideos.Navigate(url)
    End Sub

    Private Sub frmVideos_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        frmMain.Show()
    End Sub
End Class