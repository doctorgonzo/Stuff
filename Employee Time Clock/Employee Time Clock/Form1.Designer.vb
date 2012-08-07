<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblColon = New System.Windows.Forms.Label()
        Me.pnlTime = New System.Windows.Forms.Panel()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbEmployees = New System.Windows.Forms.ComboBox()
        Me.btnPunch = New System.Windows.Forms.Button()
        Me.lblKelly = New System.Windows.Forms.Label()
        Me.lblCindy = New System.Windows.Forms.Label()
        Me.lblAndrew = New System.Windows.Forms.Label()
        Me.lblNick = New System.Windows.Forms.Label()
        Me.lblKellyStatus = New System.Windows.Forms.Label()
        Me.lblCindyStatus = New System.Windows.Forms.Label()
        Me.lblNickStatus = New System.Windows.Forms.Label()
        Me.lblAndrewStatus = New System.Windows.Forms.Label()
        Me.btnCheckSchedule = New System.Windows.Forms.Button()
        Me.pnlTime.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.BackColor = System.Drawing.Color.Transparent
        Me.lblHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblHours.Location = New System.Drawing.Point(-1, 0)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(31, 29)
        Me.lblHours.TabIndex = 0
        Me.lblHours.Text = "H"
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.BackColor = System.Drawing.Color.Transparent
        Me.lblMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutes.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblMinutes.Location = New System.Drawing.Point(46, 0)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(34, 29)
        Me.lblMinutes.TabIndex = 0
        Me.lblMinutes.Text = "M"
        '
        'Timer1
        '
        '
        'lblColon
        '
        Me.lblColon.BackColor = System.Drawing.Color.Transparent
        Me.lblColon.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColon.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblColon.Location = New System.Drawing.Point(31, -1)
        Me.lblColon.Name = "lblColon"
        Me.lblColon.Size = New System.Drawing.Size(14, 30)
        Me.lblColon.TabIndex = 1
        Me.lblColon.Text = ":"
        '
        'pnlTime
        '
        Me.pnlTime.AutoSize = True
        Me.pnlTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTime.Controls.Add(Me.lblMinutes)
        Me.pnlTime.Controls.Add(Me.lblColon)
        Me.pnlTime.Controls.Add(Me.lblHours)
        Me.pnlTime.Controls.Add(Me.lblSeconds)
        Me.pnlTime.Controls.Add(Me.Label1)
        Me.pnlTime.Location = New System.Drawing.Point(547, 11)
        Me.pnlTime.Name = "pnlTime"
        Me.pnlTime.Size = New System.Drawing.Size(131, 31)
        Me.pnlTime.TabIndex = 2
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.BackColor = System.Drawing.Color.Transparent
        Me.lblSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblSeconds.Location = New System.Drawing.Point(96, 0)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(30, 29)
        Me.lblSeconds.TabIndex = 0
        Me.lblSeconds.Text = "S"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label1.Location = New System.Drawing.Point(81, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = ":"
        '
        'cmbEmployees
        '
        Me.cmbEmployees.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEmployees.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEmployees.FormattingEnabled = True
        Me.cmbEmployees.Location = New System.Drawing.Point(13, 21)
        Me.cmbEmployees.Name = "cmbEmployees"
        Me.cmbEmployees.Size = New System.Drawing.Size(221, 21)
        Me.cmbEmployees.TabIndex = 3
        '
        'btnPunch
        '
        Me.btnPunch.Location = New System.Drawing.Point(240, 19)
        Me.btnPunch.Name = "btnPunch"
        Me.btnPunch.Size = New System.Drawing.Size(76, 23)
        Me.btnPunch.TabIndex = 4
        Me.btnPunch.Text = "Punch Clock"
        Me.btnPunch.UseVisualStyleBackColor = True
        '
        'lblKelly
        '
        Me.lblKelly.AutoSize = True
        Me.lblKelly.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKelly.Location = New System.Drawing.Point(493, 59)
        Me.lblKelly.Name = "lblKelly"
        Me.lblKelly.Size = New System.Drawing.Size(128, 20)
        Me.lblKelly.TabIndex = 5
        Me.lblKelly.Text = "Kelly is currently: "
        '
        'lblCindy
        '
        Me.lblCindy.AutoSize = True
        Me.lblCindy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCindy.Location = New System.Drawing.Point(493, 88)
        Me.lblCindy.Name = "lblCindy"
        Me.lblCindy.Size = New System.Drawing.Size(135, 20)
        Me.lblCindy.TabIndex = 5
        Me.lblCindy.Text = "Cindy is currently: "
        '
        'lblAndrew
        '
        Me.lblAndrew.AutoSize = True
        Me.lblAndrew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAndrew.Location = New System.Drawing.Point(493, 146)
        Me.lblAndrew.Name = "lblAndrew"
        Me.lblAndrew.Size = New System.Drawing.Size(150, 20)
        Me.lblAndrew.TabIndex = 5
        Me.lblAndrew.Text = "Andrew is currently: "
        '
        'lblNick
        '
        Me.lblNick.AutoSize = True
        Me.lblNick.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNick.Location = New System.Drawing.Point(493, 117)
        Me.lblNick.Name = "lblNick"
        Me.lblNick.Size = New System.Drawing.Size(126, 20)
        Me.lblNick.TabIndex = 5
        Me.lblNick.Text = "Nick is currently: "
        '
        'lblKellyStatus
        '
        Me.lblKellyStatus.AutoSize = True
        Me.lblKellyStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKellyStatus.Location = New System.Drawing.Point(638, 59)
        Me.lblKellyStatus.Name = "lblKellyStatus"
        Me.lblKellyStatus.Size = New System.Drawing.Size(0, 20)
        Me.lblKellyStatus.TabIndex = 6
        '
        'lblCindyStatus
        '
        Me.lblCindyStatus.AutoSize = True
        Me.lblCindyStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCindyStatus.Location = New System.Drawing.Point(638, 88)
        Me.lblCindyStatus.Name = "lblCindyStatus"
        Me.lblCindyStatus.Size = New System.Drawing.Size(0, 20)
        Me.lblCindyStatus.TabIndex = 6
        '
        'lblNickStatus
        '
        Me.lblNickStatus.AutoSize = True
        Me.lblNickStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNickStatus.Location = New System.Drawing.Point(638, 117)
        Me.lblNickStatus.Name = "lblNickStatus"
        Me.lblNickStatus.Size = New System.Drawing.Size(0, 20)
        Me.lblNickStatus.TabIndex = 6
        '
        'lblAndrewStatus
        '
        Me.lblAndrewStatus.AutoSize = True
        Me.lblAndrewStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAndrewStatus.Location = New System.Drawing.Point(638, 146)
        Me.lblAndrewStatus.Name = "lblAndrewStatus"
        Me.lblAndrewStatus.Size = New System.Drawing.Size(0, 20)
        Me.lblAndrewStatus.TabIndex = 6
        '
        'btnCheckSchedule
        '
        Me.btnCheckSchedule.Location = New System.Drawing.Point(497, 190)
        Me.btnCheckSchedule.Name = "btnCheckSchedule"
        Me.btnCheckSchedule.Size = New System.Drawing.Size(96, 23)
        Me.btnCheckSchedule.TabIndex = 7
        Me.btnCheckSchedule.Text = "Check Schedule"
        Me.btnCheckSchedule.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 443)
        Me.Controls.Add(Me.btnCheckSchedule)
        Me.Controls.Add(Me.lblAndrewStatus)
        Me.Controls.Add(Me.lblNickStatus)
        Me.Controls.Add(Me.lblCindyStatus)
        Me.Controls.Add(Me.lblKellyStatus)
        Me.Controls.Add(Me.lblNick)
        Me.Controls.Add(Me.lblAndrew)
        Me.Controls.Add(Me.lblCindy)
        Me.Controls.Add(Me.lblKelly)
        Me.Controls.Add(Me.btnPunch)
        Me.Controls.Add(Me.cmbEmployees)
        Me.Controls.Add(Me.pnlTime)
        Me.Name = "Form1"
        Me.Text = "Schedule and Time Clock"
        Me.pnlTime.ResumeLayout(False)
        Me.pnlTime.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents lblMinutes As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblColon As System.Windows.Forms.Label
    Friend WithEvents pnlTime As System.Windows.Forms.Panel
    Friend WithEvents lblSeconds As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbEmployees As System.Windows.Forms.ComboBox
    Friend WithEvents btnPunch As System.Windows.Forms.Button
    Friend WithEvents lblKelly As System.Windows.Forms.Label
    Friend WithEvents lblCindy As System.Windows.Forms.Label
    Friend WithEvents lblAndrew As System.Windows.Forms.Label
    Friend WithEvents lblNick As System.Windows.Forms.Label
    Friend WithEvents lblKellyStatus As System.Windows.Forms.Label
    Friend WithEvents lblCindyStatus As System.Windows.Forms.Label
    Friend WithEvents lblNickStatus As System.Windows.Forms.Label
    Friend WithEvents lblAndrewStatus As System.Windows.Forms.Label
    Friend WithEvents btnCheckSchedule As System.Windows.Forms.Button

End Class
