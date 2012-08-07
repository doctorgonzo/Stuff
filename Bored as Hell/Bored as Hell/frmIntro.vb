Public Class frmIntro

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmrPage.Start()
    End Sub

    Private Sub tmrPage_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPage.Tick
        Me.Close()
        frmMain.Show()
        tmrPage.Stop()
    End Sub

    Private Sub frmIntro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Me.Close()
        frmMain.Show()
        tmrPage.Stop()
    End Sub

    Private Sub frmIntro_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        frmMain.Show()
        tmrPage.Stop()
    End Sub
End Class
