Public Class frmMain
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Dim testkey As String
        Dim rand As Random = New Random
        Dim letter() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
        Dim randLetter As Random = New Random
        'Dim number As String = rand.Next(0, 10).ToString
        'Dim keyLetter As Integer = randLetter.Next(0, letter.Count)
        testkey = letter.GetValue(randLetter.Next(0, letter.Count)).ToString & rand.Next(0, 10).ToString & letter.GetValue(randLetter.Next(0, letter.Count)).ToString & rand.Next(0, 10).ToString & letter.GetValue(randLetter.Next(0, letter.Count)).ToString & rand.Next(0, 10).ToString & letter.GetValue(randLetter.Next(0, letter.Count)).ToString & rand.Next(0, 10).ToString & letter.GetValue(randLetter.Next(0, letter.Count)).ToString & rand.Next(0, 10).ToString & letter.GetValue(randLetter.Next(0, letter.Count)).ToString & rand.Next(0, 10).ToString
        txtKey.Text = testkey
    End Sub
End Class
