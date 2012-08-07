<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPorn = New System.Windows.Forms.Button()
        Me.btnGames = New System.Windows.Forms.Button()
        Me.btnNews = New System.Windows.Forms.Button()
        Me.btnVideos = New System.Windows.Forms.Button()
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Iskoola Pota", 70.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(0, -13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 138)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "So..."
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Iskoola Pota", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(188, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(376, 70)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "what are we doing today?"
        '
        'btnPorn
        '
        Me.btnPorn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnPorn.Location = New System.Drawing.Point(473, 48)
        Me.btnPorn.Name = "btnPorn"
        Me.btnPorn.Size = New System.Drawing.Size(80, 80)
        Me.btnPorn.TabIndex = 2
        Me.btnPorn.Text = "Porn?"
        Me.btnPorn.UseVisualStyleBackColor = True
        '
        'btnGames
        '
        Me.btnGames.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnGames.Location = New System.Drawing.Point(473, 156)
        Me.btnGames.Name = "btnGames"
        Me.btnGames.Size = New System.Drawing.Size(80, 80)
        Me.btnGames.TabIndex = 2
        Me.btnGames.Text = "Games?"
        Me.btnGames.UseVisualStyleBackColor = True
        '
        'btnNews
        '
        Me.btnNews.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnNews.Location = New System.Drawing.Point(473, 264)
        Me.btnNews.Name = "btnNews"
        Me.btnNews.Size = New System.Drawing.Size(80, 80)
        Me.btnNews.TabIndex = 2
        Me.btnNews.Text = "News?"
        Me.btnNews.UseVisualStyleBackColor = True
        '
        'btnVideos
        '
        Me.btnVideos.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnVideos.Location = New System.Drawing.Point(473, 372)
        Me.btnVideos.Name = "btnVideos"
        Me.btnVideos.Size = New System.Drawing.Size(80, 80)
        Me.btnVideos.TabIndex = 2
        Me.btnVideos.Text = "Videos?"
        Me.btnVideos.UseVisualStyleBackColor = True
        '
        'btnRandom
        '
        Me.btnRandom.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnRandom.Location = New System.Drawing.Point(473, 480)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(80, 80)
        Me.btnRandom.TabIndex = 2
        Me.btnRandom.Text = "I DON'T FUCKING KNOW!?"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Bored_as_Hell.My.Resources.Resources.idontknow
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(565, 610)
        Me.Controls.Add(Me.btnRandom)
        Me.Controls.Add(Me.btnVideos)
        Me.Controls.Add(Me.btnNews)
        Me.Controls.Add(Me.btnGames)
        Me.Controls.Add(Me.btnPorn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPorn As System.Windows.Forms.Button
    Friend WithEvents btnGames As System.Windows.Forms.Button
    Friend WithEvents btnNews As System.Windows.Forms.Button
    Friend WithEvents btnVideos As System.Windows.Forms.Button
    Friend WithEvents btnRandom As System.Windows.Forms.Button
End Class
