Public Class Schedule_Maker

    Private Sub Schedule_Maker_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Schedule.Show()
    End Sub

    Private Sub Schedule_Maker_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        'Dim rect As New Rectangle(241, 12, 120, 120)
        For i As Integer = 241 To 997 Step 126
            For j As Integer = 12 To 516 Step 126
                e.Graphics.DrawPath(Pens.Black, Shape.RoundedRectangle(New Rectangle(i, j, 120, 120), 5, Shape.Corner.None))

            Next
        Next
    End Sub

    Private Sub Schedule_Maker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To pnlCalendar.Controls.Count
            For Each thing As Label In pnlCalendar.Controls
                i += 1
                thing.Name = "label" & i
            Next
        Next
    End Sub

  
    Private Sub Label8_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Label8.MouseDoubleClick


        

    End Sub
End Class