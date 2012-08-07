Public Class frmGames

    Private Sub btnAgain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgain.Click
        Dim choices() As String
        choices = {"http://www.addictinggames.com/shooting-games/index.jsp", "http://www.i-am-bored.com/im_bored_cat_0_1.htm", "http://games.yahoo.com/card-games", "http://word-games.pogo.com/?pageSection=hp_categorybar_word"}
        Dim rndChoice As Integer
        rndChoice = GetRandom(0, choices.Length - 1)
        Dim url As String
        url = choices(rndChoice)
        webGames.Navigate(url)
    End Sub

    Private Sub frmGames_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        frmMain.Show()
    End Sub
End Class