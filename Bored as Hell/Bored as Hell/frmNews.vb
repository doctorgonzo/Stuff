Public Class frmNews

    Private Sub btnGoogle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoogle.Click
        webNews.Navigate("http://news.google.com/nwshp?hl=en&tab=wn")
    End Sub

    Private Sub btnArsTechnica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArsTechnica.Click
        webNews.Navigate("http://arstechnica.com/")
    End Sub

    Private Sub btnBBC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBBC.Click
        webNews.Navigate("http://www.bbc.co.uk/news/")
    End Sub

    Private Sub btnFark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFark.Click
        webNews.Navigate("http://www.fark.com")
    End Sub

    Private Sub btnCracked_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCracked.Click
        webNews.Navigate("http://www.cracked.com")
    End Sub

    Private Sub btnOnion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOnion.Click
        webNews.Navigate("http://www.theonion.com/")
    End Sub

    Private Sub btnSTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSTP.Click
        webNews.Navigate("http://www.stevenspointjournal.com/")
    End Sub

    Private Sub frmNews_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        frmMain.Show()
    End Sub
End Class