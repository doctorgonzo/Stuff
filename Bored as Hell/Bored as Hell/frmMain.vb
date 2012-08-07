Imports System.IO
Public Class frmMain



    Private Sub btnPorn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPorn.Click
        Me.Hide()
        frmPorn.Show()
        frmPorn.webPorn.Navigate("http://youjizz.com/random.php")
    End Sub

    Private Sub btnGames_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGames.Click
        Me.Hide()
        frmGames.Show()
    End Sub

    Private Sub btnRandom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandom.Click
        Me.Hide()
        Dim frm As New Form
        frm.BackgroundImage = Image.FromFile("hahaguy.jpg")
        frm.BackgroundImageLayout = ImageLayout.Stretch
        frm.Show()
        For x = 1 To 99999
            Do While x <> 0
                Dim frm2, frm3, frm4 As New Form
                Dim rnd As New Random
                frm2.Show()    'makes this whole thing possible
                Dim ha As Image = Image.FromFile("hahaguy.jpg")
                frm2.BackgroundImage = ha
                frm2.BackgroundImageLayout = ImageLayout.Stretch
                frm2.SetDesktopLocation(rnd.Next(0, 2400), rnd.Next(0, 2400))
                frm3.Show()    'makes this whole thing possible
                frm3.BackgroundImage = ha
                frm3.BackgroundImageLayout = ImageLayout.Stretch
                frm3.SetDesktopLocation(rnd.Next(0, 2400), rnd.Next(0, 2400))
                frm4.Show()    'makes this whole thing possible
                frm4.BackgroundImage = ha
                frm4.BackgroundImageLayout = ImageLayout.Stretch
                frm4.SetDesktopLocation(rnd.Next(0, 2400), rnd.Next(0, 2400))
            Loop
        Next x
    End Sub

    Private Sub btnNews_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNews.Click
        Me.Hide()
        frmNews.Show()
    End Sub

    Private Sub btnVideos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVideos.Click
        Me.Hide()
        frmVideos.Show()
    End Sub
End Class