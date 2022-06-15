Imports System.IO

Public Class Form1
    Dim xo As OpenFileDialog = New OpenFileDialog
    Dim x As SaveFileDialog = New SaveFileDialog
    'Begin "borrowed" code
    Private Declare Sub mouse_event Lib "user32.dll" (ByVal dwflags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Private Sub mouse_click(ByVal button As Integer, ByVal state As String)
        Select Case button
            Case 1
                If state = "down" Then
                    mouse_event(2, 100, 100, 0, 0)
                Else
                    mouse_event(4, 100, 100, 0, 0)
                End If
            Case 2
                If state = "down" Then
                    mouse_event(8, 100, 100, 0, 0)
                Else
                    mouse_event(16, 100, 100, 0, 0)
                End If
            Case 3
                If state = "down" Then
                    mouse_event(32, 100, 100, 0, 0)
                Else
                    mouse_event(64, 100, 100, 0, 0)
                End If
        End Select
    End Sub
    'End "borrowed" code
    Private Sub tracker(ByVal posX As String, ByVal posY As String)
        posX = MousePosition.X
        posY = MousePosition.Y
        tsMouseX.Text = "Mouse X: " & posX
        tsMouseY.Text = "Mouse Y: " & posY
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        tracker(MousePosition.X, MousePosition.Y)
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Me.KeyPreview = True
        lstMousePos.Focus()
        numSpeed.Value = 55
        numSpeed.Maximum = 9999
    End Sub

    Public Sub listScroll()
        Dim lastItem As Integer
        lastItem = lstMousePos.Items.Count
        lstMousePos.SelectedIndex = lastItem - 1
    End Sub

    Private Sub Form1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Space) Then
            Dim capturedPosition As Drawing.Point
            capturedPosition = (MousePosition)
            lstMousePos.Items.Add(capturedPosition)
            listScroll()
            lstMousePos.ClearSelected()
            lstMousePos.SelectedIndex = lstMousePos.Items.Count - 1
        End If
        'If e.KeyChar = ChrW(Keys.Escape) Then


        'End If
    End Sub

    Private Sub btnMoveMouse_Click(sender As System.Object, e As System.EventArgs) Handles btnMoveMouse.Click
        Dim lastItem As Point
        lastItem = lstMousePos.SelectedItem
        Cursor.Position = lastItem
        lstMousePos.Focus()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnChoosePoints.Click
        Dim selectedItems = (From i In lstMousePos.SelectedItems).ToArray()
        For Each selectedItem In selectedItems
            lstSelectedPoints.Items.Add(selectedItem)
        Next
        lstMousePos.Focus()
    End Sub

    Private Sub chkOnTop_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkOnTop.CheckedChanged
        If Me.TopMost = True Then
            Me.TopMost = False
        ElseIf Me.TopMost = False Then
            Me.TopMost = True
        End If
        chkOnTop.Enabled = False
        lstMousePos.Focus()
    End Sub

    Private Sub btnMoveClick_Click(sender As System.Object, e As System.EventArgs) Handles btnMoveClick.Click
        Dim lastItem As Point
        lastItem = lstMousePos.SelectedItem
        Cursor.Position = lastItem
        mouse_click(1, "down")
        mouse_click(1, "up")
        lstMousePos.Focus()
    End Sub

    Private Sub chkOnTop_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles chkOnTop.PreviewKeyDown
        If e.KeyCode = Keys.Space Then
            lstMousePos.Focus()
        End If
    End Sub

    Private Sub btnMoveToAll_Click(sender As System.Object, e As System.EventArgs) Handles btnMoveToAll.Click
        Dim counter As Integer = 0
        Do Until counter >= lstSelectedPoints.SelectedItems.Count
            Dim selectedItems = (From i In lstSelectedPoints.SelectedItems).ToArray()
            Dim currentItem = selectedItems.GetValue(counter)
            Cursor.Position = currentItem
            counter += 1
            System.Threading.Thread.Sleep(numSpeed.Value)
        Loop
        If rdoRepeat.Checked = True Then
            repeat(numRepeat.Value - 1)
        End If
    End Sub

    Private Sub lstSelectedPoints_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lstSelectedPoints.DoubleClick
        For i = 0 To lstSelectedPoints.Items.Count - 1
            lstSelectedPoints.SetSelected(i, True)
        Next
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        lstSelectedPoints.Items.Clear()
        lstMousePos.Items.Clear()
        numSpeed.Value = 55
        numRepeat.Value = 0
        rdoRepeat.Checked = False
        rdoPlayback.Checked = False
        rdoRecord.Checked = False
        lstMousePos.Focus()
    End Sub

    Private Sub rdoRepeat_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoRepeat.CheckedChanged
        If rdoRepeat.Checked = True Then
            numRepeat.Visible = True
            lblRepetitions.Visible = True
        Else
            numRepeat.Visible = False
            lblRepetitions.Visible = False
        End If
    End Sub

    Private Sub repeat(ByVal numOfReps As Integer)
        Dim counter As Integer = 0
        Do Until counter >= numOfReps
            Dim counter2 As Integer = 0
            Do Until counter2 >= lstSelectedPoints.SelectedItems.Count
                Dim selectedItems = (From i In lstSelectedPoints.SelectedItems).ToArray()
                Dim currentItem = selectedItems.GetValue(counter2)
                Cursor.Position = currentItem
                counter2 += 1
                System.Threading.Thread.Sleep(numSpeed.Value)
            Loop
            counter += 1
        Loop
    End Sub

    Private Sub rdoRecord_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoRecord.CheckedChanged
        If rdoRecord.Checked = True Then
            btnRecord.Visible = True
            x.AddExtension = True
            x.DefaultExt = ".txt"
            x.OverwritePrompt = True
            x.FileName = "My Pattern"
            x.CreatePrompt = True
            x.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            x.Title = "Where would you like to save your pattern?"
            x.ShowDialog()
        Else
            btnRecord.Visible = False
        End If
    End Sub

    Private Sub btnRecord_Click(sender As System.Object, e As System.EventArgs) Handles btnRecord.Click
        Dim w As StreamWriter = File.AppendText(x.FileName)
        Dim counter As Integer = 0
        Do Until counter >= lstSelectedPoints.SelectedItems.Count
            'Dim selectedItems = (From i In lstSelectedPoints.SelectedItems).ToArray()
            'Dim currentItem = selectedItems.GetValue(counter)
            Dim selectedItems = (From i In lstMousePos.SelectedItems).ToArray()
            For Each selectedItem In selectedItems
                w.WriteLine(selectedItem)
                counter += 1
            Next
        Loop
        w.Close()
        If File.Exists(x.FileName) Then
            MessageBox.Show("Successfully saved pattern to: " & x.FileName)
        End If
    End Sub

    Private Sub rdoPlayback_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoPlayback.CheckedChanged
        If rdoPlayback.Checked = True Then
            xo.ShowDialog()
            lstMousePos.Items.Clear()
            lstSelectedPoints.Items.Clear()
            btnPlay.Visible = True
        Else
            btnPlay.Visible = False
        End If
    End Sub

    Private Sub Play_Click(sender As System.Object, e As System.EventArgs) Handles btnPlay.Click
        lstSelectedPoints.Items.Clear()
        If rdoPlayback.Checked = False Then
            MessageBox.Show("You didn't select a file to play.", "Dumbass", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim r As StreamReader = File.OpenText(xo.FileName)
            Dim counter As Integer = 0
            Do Until r.Peek = -1
                lstSelectedPoints.Items.Add(r.ReadLine & vbCrLf)
                lstSelectedPoints.SetSelected(counter, True)
                counter += 1
            Loop
            Dim chars() As Char = {"{", "X", CChar("Y"), CChar("="), "}"}
            For i = 0 To lstSelectedPoints.Items.Count - 1
                Dim newString = lstSelectedPoints.Items.Item(i).ToString.Split(chars)
                Dim a = newString.GetValue(3)
                Dim b = newString.GetValue(5)
                Dim c = a & b
                Dim d As System.Drawing.Point
                d.X = a
                d.Y = b
                Cursor.Position = d
                i += 1
                System.Threading.Thread.Sleep(numSpeed.Value)
            Next
            If rdoRepeat.Checked = True Then
                For y = 0 To numRepeat.Value - 2
                    For i = 0 To lstSelectedPoints.Items.Count - 1
                        Dim newString = lstSelectedPoints.Items.Item(i).ToString.Split(chars)
                        Dim a = newString.GetValue(3)
                        Dim b = newString.GetValue(5)
                        Dim c = a & b
                        Dim d As System.Drawing.Point
                        d.X = a
                        d.Y = b
                        Cursor.Position = d
                        i += 1
                        System.Threading.Thread.Sleep(numSpeed.Value)
                    Next
                Next
            End If
            r.Close()
        End If
    End Sub

    Private Sub btnMoveClickRepeat_Click(sender As Object, e As EventArgs) Handles btnMoveClickRepeat.Click
        Dim lastItem As Point
        lastItem = lstMousePos.SelectedItem
        Cursor.Position = lastItem
        For index = 0 To numClicks.Value
            mouse_click(1, "down")
            mouse_click(1, "up")
            lstMousePos.Focus()
            System.Threading.Thread.Sleep(numRepetitionSpeed.Value)
        Next
    End Sub
End Class
