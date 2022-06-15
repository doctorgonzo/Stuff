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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lstMousePos = New System.Windows.Forms.ListBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsMouseX = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsMouseY = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnMoveMouse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMoveClick = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkOnTop = New System.Windows.Forms.CheckBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.numSpeed = New System.Windows.Forms.NumericUpDown()
        Me.lstSelectedPoints = New System.Windows.Forms.ListBox()
        Me.btnChoosePoints = New System.Windows.Forms.Button()
        Me.lblChoosePoints = New System.Windows.Forms.Label()
        Me.btnMoveToAll = New System.Windows.Forms.Button()
        Me.numRepeat = New System.Windows.Forms.NumericUpDown()
        Me.rdoPlayback = New System.Windows.Forms.RadioButton()
        Me.rdoRecord = New System.Windows.Forms.RadioButton()
        Me.rdoRepeat = New System.Windows.Forms.RadioButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblRepetitions = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdoRepeatClick = New System.Windows.Forms.RadioButton()
        Me.numClicks = New System.Windows.Forms.NumericUpDown()
        Me.btnMoveClickRepeat = New System.Windows.Forms.Button()
        Me.numRepetitionSpeed = New System.Windows.Forms.NumericUpDown()
        Me.lblRepetitionSpeed = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.numSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRepeat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.numClicks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRepetitionSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstMousePos
        '
        Me.lstMousePos.FormattingEnabled = True
        Me.lstMousePos.ItemHeight = 16
        Me.lstMousePos.Location = New System.Drawing.Point(12, 12)
        Me.lstMousePos.Name = "lstMousePos"
        Me.lstMousePos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstMousePos.Size = New System.Drawing.Size(104, 276)
        Me.lstMousePos.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.StatusStrip1.GripMargin = New System.Windows.Forms.Padding(0)
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsMouseX, Me.tsMouseY})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 499)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(945, 26)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.Stretch = False
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsMouseX
        '
        Me.tsMouseX.Name = "tsMouseX"
        Me.tsMouseX.Size = New System.Drawing.Size(153, 20)
        Me.tsMouseX.Text = "ToolStripStatusLabel1"
        '
        'tsMouseY
        '
        Me.tsMouseY.Name = "tsMouseY"
        Me.tsMouseY.Size = New System.Drawing.Size(153, 20)
        Me.tsMouseY.Text = "ToolStripStatusLabel2"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'btnMoveMouse
        '
        Me.btnMoveMouse.Location = New System.Drawing.Point(253, 73)
        Me.btnMoveMouse.Name = "btnMoveMouse"
        Me.btnMoveMouse.Size = New System.Drawing.Size(84, 23)
        Me.btnMoveMouse.TabIndex = 4
        Me.btnMoveMouse.Text = "Move"
        Me.btnMoveMouse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(343, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Moves the mouse to the location selected from list"
        '
        'btnMoveClick
        '
        Me.btnMoveClick.Location = New System.Drawing.Point(253, 102)
        Me.btnMoveClick.Name = "btnMoveClick"
        Me.btnMoveClick.Size = New System.Drawing.Size(84, 23)
        Me.btnMoveClick.TabIndex = 4
        Me.btnMoveClick.Text = "Move + Click"
        Me.btnMoveClick.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(343, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(375, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Moves the mouse to selected location and performs a left click"
        '
        'chkOnTop
        '
        Me.chkOnTop.AutoSize = True
        Me.chkOnTop.Location = New System.Drawing.Point(621, 6)
        Me.chkOnTop.Name = "chkOnTop"
        Me.chkOnTop.Size = New System.Drawing.Size(178, 20)
        Me.chkOnTop.TabIndex = 0
        Me.chkOnTop.Text = "Keep this window on top?"
        Me.chkOnTop.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.DarkRed
        Me.lblInfo.Location = New System.Drawing.Point(4, 447)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(929, 52)
        Me.lblInfo.TabIndex = 6
        Me.lblInfo.Text = "Press and hold space to record mouse position"
        '
        'numSpeed
        '
        Me.numSpeed.Location = New System.Drawing.Point(126, 22)
        Me.numSpeed.Name = "numSpeed"
        Me.numSpeed.Size = New System.Drawing.Size(54, 22)
        Me.numSpeed.TabIndex = 7
        '
        'lstSelectedPoints
        '
        Me.lstSelectedPoints.FormattingEnabled = True
        Me.lstSelectedPoints.ItemHeight = 16
        Me.lstSelectedPoints.Location = New System.Drawing.Point(143, 12)
        Me.lstSelectedPoints.Name = "lstSelectedPoints"
        Me.lstSelectedPoints.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstSelectedPoints.Size = New System.Drawing.Size(104, 276)
        Me.lstSelectedPoints.TabIndex = 8
        '
        'btnChoosePoints
        '
        Me.btnChoosePoints.Location = New System.Drawing.Point(253, 15)
        Me.btnChoosePoints.Name = "btnChoosePoints"
        Me.btnChoosePoints.Size = New System.Drawing.Size(84, 23)
        Me.btnChoosePoints.TabIndex = 4
        Me.btnChoosePoints.Text = "Choose Points"
        Me.btnChoosePoints.UseVisualStyleBackColor = True
        '
        'lblChoosePoints
        '
        Me.lblChoosePoints.AutoSize = True
        Me.lblChoosePoints.Location = New System.Drawing.Point(343, 20)
        Me.lblChoosePoints.Name = "lblChoosePoints"
        Me.lblChoosePoints.Size = New System.Drawing.Size(335, 16)
        Me.lblChoosePoints.TabIndex = 5
        Me.lblChoosePoints.Text = "Select items from list on left and click to move them over"
        '
        'btnMoveToAll
        '
        Me.btnMoveToAll.Location = New System.Drawing.Point(6, 19)
        Me.btnMoveToAll.Name = "btnMoveToAll"
        Me.btnMoveToAll.Size = New System.Drawing.Size(84, 23)
        Me.btnMoveToAll.TabIndex = 4
        Me.btnMoveToAll.Text = "Move to All"
        Me.btnMoveToAll.UseVisualStyleBackColor = True
        '
        'numRepeat
        '
        Me.numRepeat.Location = New System.Drawing.Point(126, 45)
        Me.numRepeat.Name = "numRepeat"
        Me.numRepeat.Size = New System.Drawing.Size(54, 22)
        Me.numRepeat.TabIndex = 7
        Me.numRepeat.Visible = False
        '
        'rdoPlayback
        '
        Me.rdoPlayback.AutoSize = True
        Me.rdoPlayback.Location = New System.Drawing.Point(6, 45)
        Me.rdoPlayback.Name = "rdoPlayback"
        Me.rdoPlayback.Size = New System.Drawing.Size(143, 20)
        Me.rdoPlayback.TabIndex = 9
        Me.rdoPlayback.TabStop = True
        Me.rdoPlayback.Text = "Play Saved Pattern"
        Me.rdoPlayback.UseVisualStyleBackColor = True
        '
        'rdoRecord
        '
        Me.rdoRecord.AutoSize = True
        Me.rdoRecord.Location = New System.Drawing.Point(6, 19)
        Me.rdoRecord.Name = "rdoRecord"
        Me.rdoRecord.Size = New System.Drawing.Size(118, 20)
        Me.rdoRecord.TabIndex = 9
        Me.rdoRecord.TabStop = True
        Me.rdoRecord.Text = "Record Pattern"
        Me.rdoRecord.UseVisualStyleBackColor = True
        '
        'rdoRepeat
        '
        Me.rdoRepeat.AutoSize = True
        Me.rdoRepeat.Location = New System.Drawing.Point(6, 45)
        Me.rdoRepeat.Name = "rdoRepeat"
        Me.rdoRepeat.Size = New System.Drawing.Size(138, 20)
        Me.rdoRepeat.TabIndex = 9
        Me.rdoRepeat.TabStop = True
        Me.rdoRepeat.Text = "Repeat the pattern"
        Me.rdoRepeat.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(253, 44)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(343, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Clear everything and start fresh"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(186, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(276, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Speed between mouse moves (milliseconds)"
        '
        'lblRepetitions
        '
        Me.lblRepetitions.AutoSize = True
        Me.lblRepetitions.Location = New System.Drawing.Point(186, 47)
        Me.lblRepetitions.Name = "lblRepetitions"
        Me.lblRepetitions.Size = New System.Drawing.Size(142, 16)
        Me.lblRepetitions.TabIndex = 13
        Me.lblRepetitions.Text = "How many repetitions?"
        Me.lblRepetitions.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblRepetitions)
        Me.GroupBox1.Controls.Add(Me.rdoRepeat)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.numRepeat)
        Me.GroupBox1.Controls.Add(Me.numSpeed)
        Me.GroupBox1.Controls.Add(Me.btnMoveToAll)
        Me.GroupBox1.Location = New System.Drawing.Point(253, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 68)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Movement Options"
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(132, 16)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(75, 23)
        Me.btnRecord.TabIndex = 15
        Me.btnRecord.Text = "Record"
        Me.btnRecord.UseVisualStyleBackColor = True
        Me.btnRecord.Visible = False
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(132, 42)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 16
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        Me.btnPlay.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnPlay)
        Me.GroupBox2.Controls.Add(Me.btnRecord)
        Me.GroupBox2.Controls.Add(Me.rdoPlayback)
        Me.GroupBox2.Controls.Add(Me.rdoRecord)
        Me.GroupBox2.Location = New System.Drawing.Point(253, 205)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(213, 72)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Playback and Recording"
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.Controls.Add(Me.numRepetitionSpeed)
        Me.GroupBox3.Controls.Add(Me.numClicks)
        Me.GroupBox3.Controls.Add(Me.lblRepetitionSpeed)
        Me.GroupBox3.Controls.Add(Me.rdoRepeatClick)
        Me.GroupBox3.Controls.Add(Me.btnMoveClickRepeat)
        Me.GroupBox3.Location = New System.Drawing.Point(473, 206)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(334, 120)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        '
        'rdoRepeatClick
        '
        Me.rdoRepeatClick.AutoSize = True
        Me.rdoRepeatClick.Location = New System.Drawing.Point(7, 22)
        Me.rdoRepeatClick.Name = "rdoRepeatClick"
        Me.rdoRepeatClick.Size = New System.Drawing.Size(243, 20)
        Me.rdoRepeatClick.TabIndex = 0
        Me.rdoRepeatClick.TabStop = True
        Me.rdoRepeatClick.Text = "Move to a point and click repeatedly"
        Me.rdoRepeatClick.UseVisualStyleBackColor = True
        '
        'numClicks
        '
        Me.numClicks.Location = New System.Drawing.Point(31, 44)
        Me.numClicks.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numClicks.Name = "numClicks"
        Me.numClicks.Size = New System.Drawing.Size(120, 22)
        Me.numClicks.TabIndex = 1
        '
        'btnMoveClickRepeat
        '
        Me.btnMoveClickRepeat.Location = New System.Drawing.Point(157, 44)
        Me.btnMoveClickRepeat.Name = "btnMoveClickRepeat"
        Me.btnMoveClickRepeat.Size = New System.Drawing.Size(93, 23)
        Me.btnMoveClickRepeat.TabIndex = 4
        Me.btnMoveClickRepeat.Text = "Move + Click"
        Me.btnMoveClickRepeat.UseVisualStyleBackColor = True
        '
        'numRepetitionSpeed
        '
        Me.numRepetitionSpeed.Location = New System.Drawing.Point(31, 72)
        Me.numRepetitionSpeed.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numRepetitionSpeed.Name = "numRepetitionSpeed"
        Me.numRepetitionSpeed.Size = New System.Drawing.Size(120, 22)
        Me.numRepetitionSpeed.TabIndex = 1
        '
        'lblRepetitionSpeed
        '
        Me.lblRepetitionSpeed.AutoSize = True
        Me.lblRepetitionSpeed.Location = New System.Drawing.Point(157, 74)
        Me.lblRepetitionSpeed.Name = "lblRepetitionSpeed"
        Me.lblRepetitionSpeed.Size = New System.Drawing.Size(171, 16)
        Me.lblRepetitionSpeed.TabIndex = 13
        Me.lblRepetitionSpeed.Text = "Time in between clicks (ms)"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(945, 525)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstSelectedPoints)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.chkOnTop)
        Me.Controls.Add(Me.lblChoosePoints)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnChoosePoints)
        Me.Controls.Add(Me.btnMoveClick)
        Me.Controls.Add(Me.btnMoveMouse)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lstMousePos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = " "
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.numSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRepeat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.numClicks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRepetitionSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstMousePos As System.Windows.Forms.ListBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsMouseX As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsMouseY As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnMoveMouse As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMoveClick As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkOnTop As System.Windows.Forms.CheckBox
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents numSpeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents lstSelectedPoints As System.Windows.Forms.ListBox
    Friend WithEvents btnChoosePoints As System.Windows.Forms.Button
    Friend WithEvents lblChoosePoints As System.Windows.Forms.Label
    Friend WithEvents btnMoveToAll As System.Windows.Forms.Button
    Friend WithEvents numRepeat As System.Windows.Forms.NumericUpDown
    Friend WithEvents rdoPlayback As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRecord As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRepeat As System.Windows.Forms.RadioButton
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblRepetitions As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRecord As System.Windows.Forms.Button
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents numClicks As NumericUpDown
    Friend WithEvents rdoRepeatClick As RadioButton
    Friend WithEvents btnMoveClickRepeat As Button
    Friend WithEvents numRepetitionSpeed As NumericUpDown
    Friend WithEvents lblRepetitionSpeed As Label
End Class
