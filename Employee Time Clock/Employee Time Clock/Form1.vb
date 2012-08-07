Imports System.IO

Public Class Form1

    Dim employeeName As String
    Public Const maxPunches As Integer = 4
    Dim path As String = "C:\Users\" & System.Environment.UserName & "\My Documents\"
    Dim writer As StreamWriter

    Dim NickString As String
    Dim KellyString As String
    Dim AndrewString As String
    Dim CindyString As String

    Dim NickStatus As String
    Dim KellyStatus As String
    Dim AndrewStatus As String
    Dim CindyStatus As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If TimeOfDay.Hour > 12 Then
            lblHours.Text = "0" & TimeOfDay.Hour - 12
        End If

        If TimeOfDay.Minute <= 9 Then
            lblMinutes.Text = "0" & TimeOfDay.Minute
        End If

        If TimeOfDay.Second <= 9 Then
            lblSeconds.Text = "0" & TimeOfDay.Second
        End If

        If TimeOfDay.Hour <= 12 Then
            lblHours.Text = CStr(TimeOfDay.Hour)
        End If

        If TimeOfDay.Minute > 9 Then
            lblMinutes.Text = CStr(TimeOfDay.Minute)
        End If

        If TimeOfDay.Second > 9 Then
            lblSeconds.Text = CStr(TimeOfDay.Second)
        End If

        Timer1.Start()
        cmbEmployees.Items.Add("Nick")
        cmbEmployees.Items.Add("Andrew")
        cmbEmployees.Items.Add("Kelly")
        cmbEmployees.Items.Add("Cindy")
        GetStatus()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If TimeOfDay.Hour > 12 Then
            lblHours.Text = "0" & TimeOfDay.Hour - 12
        End If

        If TimeOfDay.Minute <= 9 Then
            lblMinutes.Text = "0" & TimeOfDay.Minute
        End If

        If TimeOfDay.Second <= 9 Then
            lblSeconds.Text = "0" & TimeOfDay.Second
        End If

        If TimeOfDay.Hour <= 12 Then
            lblHours.Text = CStr(TimeOfDay.Hour)
        End If

        If TimeOfDay.Minute > 9 Then
            lblMinutes.Text = CStr(TimeOfDay.Minute)
        End If

        If TimeOfDay.Second > 9 Then
            lblSeconds.Text = CStr(TimeOfDay.Second)
        End If

    End Sub
    ''' <summary>
    ''' This procedure reads the Time Records.txt file and decides if an employee is currently clocked in or out and calls the appropiate subroutine to perform punches.
    ''' </summary>
    Private Sub btnPunch_Click(sender As System.Object, e As System.EventArgs) Handles btnPunch.Click
        employeeName = CStr(cmbEmployees.SelectedItem)
        'If Not File.Exists(path & "Time Records.txt") Then
        '    writer = File.CreateText(path & "Time Records.txt")
        '    writer.Close()
        '    ClockIn()
        'Else
        If employeeName <> Nothing Then
            Dim textLine As String = File.ReadAllLines(path & "Time Records.txt").LastOrDefault(Function(s As String) s.Contains(employeeName) And s.Contains(CStr(Date.Today)))
            If textLine <> Nothing Then
                If textLine.Contains(CStr(Date.Today)) AndAlso textLine.Contains(employeeName) AndAlso textLine.Contains("OUT") Then
                    ClockIn()
                ElseIf textLine.Contains(CStr(Date.Today)) AndAlso textLine.Contains(employeeName) AndAlso textLine.Contains("IN") Then
                    ClockOut()
                End If
            Else
                ClockIn()
            End If
        Else
            MessageBox.Show("You must choose an employee name.", "No name selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        'End If
    End Sub

    Private Sub ClockIn()
        employeeName = CStr(cmbEmployees.SelectedItem)
        If employeeName <> Nothing Then
            writer = File.AppendText(path & "Time Records.txt")
            writer.WriteLine(Date.Today & " - " & employeeName & " - " & TimeOfDay & " -- IN")
            writer.Close()
        Else
            MessageBox.Show("You must choose an employee name.", "No name selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Select Case employeeName
            Case "Nick" : lblNickStatus.Text = "IN" : lblNickStatus.ForeColor = Color.Green
            Case "Kelly" : lblKellyStatus.Text = "IN" : lblKellyStatus.ForeColor = Color.Green
            Case "Andrew" : lblAndrewStatus.Text = "IN" : lblAndrewStatus.ForeColor = Color.Green
            Case "Cindy" : lblCindyStatus.Text = "IN" : lblCindyStatus.ForeColor = Color.Green
        End Select
        MessageBox.Show(employeeName & " clocked in at " & TimeOfDay, "Clocked In", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ClockOut()
        employeeName = CStr(cmbEmployees.SelectedItem)
        If employeeName <> Nothing Then
            writer = File.AppendText(path & "Time Records.txt")
            writer.WriteLine(Date.Today & " - " & employeeName & " - " & TimeOfDay & " -- OUT")
            writer.Close()
        End If
        Select Case employeeName
            Case "Nick" : lblNickStatus.Text = "OUT" : lblNickStatus.ForeColor = Color.Red
            Case "Kelly" : lblKellyStatus.Text = "OUT" : lblKellyStatus.ForeColor = Color.Red
            Case "Andrew" : lblAndrewStatus.Text = "OUT" : lblAndrewStatus.ForeColor = Color.Red
            Case "Cindy" : lblCindyStatus.Text = "OUT" : lblCindyStatus.ForeColor = Color.Red
        End Select
        MessageBox.Show(employeeName & " clocked out at " & TimeOfDay, "Clocked Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub GetStatus()
        If File.Exists(path & "Time Records.txt") Then
            Dim ps = File.ReadAllText(path & "Time Records.txt")
            If ps = "" Then
                lblNickStatus.Text = ""
                lblKellyStatus.Text = ""
                lblCindyStatus.Text = ""
                lblAndrewStatus.Text = ""
            Else
                Try
                    NickString = File.ReadAllLines(path & "Time Records.txt").LastOrDefault(Function(s As String) s.Contains("Nick"))
                    KellyString = File.ReadAllLines(path & "Time Records.txt").LastOrDefault(Function(s As String) s.Contains("Kelly"))
                    CindyString = File.ReadAllLines(path & "Time Records.txt").LastOrDefault(Function(s As String) s.Contains("Cindy"))
                    AndrewString = File.ReadAllLines(path & "Time Records.txt").LastOrDefault(Function(s As String) s.Contains("Andrew"))

                    NickStatus = NickString.Substring(33)
                    lblNickStatus.Text = NickStatus

                    KellyStatus = KellyString.Substring(34)
                    lblKellyStatus.Text = KellyStatus

                    CindyStatus = CindyString.Substring(34)
                    lblCindyStatus.Text = CindyStatus

                    AndrewStatus = AndrewString.Substring(35)
                    lblAndrewStatus.Text = AndrewStatus
                Catch ex As Exception
                    MessageBox.Show("One or more Employee names does not exist in the Time Records file." & vbCrLf & "Press OK to continue loading.")
                End Try
            End If
            'Else
            '    File.CreateText(path & "Time Records.txt")
        End If

        If lblNickStatus.Text = "IN" Then
            lblNickStatus.ForeColor = Color.Green
        Else
            lblNickStatus.ForeColor = Color.Red
        End If

        If lblAndrewStatus.Text = "IN" Then
            lblAndrewStatus.ForeColor = Color.Green
        Else
            lblAndrewStatus.ForeColor = Color.Red
        End If

        If lblKellyStatus.Text = "IN" Then
            lblKellyStatus.ForeColor = Color.Green
        Else
            lblKellyStatus.ForeColor = Color.Red
        End If

        If lblCindyStatus.Text = "IN" Then
            lblCindyStatus.ForeColor = Color.Green
        Else
            lblCindyStatus.ForeColor = Color.Red
        End If


    End Sub

    Private Sub btnCheckSchedule_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckSchedule.Click
        Me.Hide()
        Schedule.Show()
    End Sub
End Class
