Public Class Schedule

    Private Sub Schedule_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub btnCreateSchedule_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateSchedule.Click
        txtPassword.Visible = True
        btnPassword.Visible = True
        txtPassword.Focus()
    End Sub

    Private Sub btnPassword_Click(sender As System.Object, e As System.EventArgs) Handles btnPassword.Click
        If txtPassword.Text <> "password" Then
            MessageBox.Show("NOPE!")
            txtPassword.Visible = False
            btnPassword.Visible = False
            txtPassword.Clear()
        Else
            MessageBox.Show("YEP!")
            txtPassword.Visible = False
            btnPassword.Visible = False
            txtPassword.Clear()
            Me.Hide()
            Schedule_Maker.Show()
        End If
    End Sub

End Class