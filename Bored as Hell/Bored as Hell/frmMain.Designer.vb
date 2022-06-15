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
        Me.btnPorn = New System.Windows.Forms.Button()
        Me.btnNews = New System.Windows.Forms.Button()
        Me.btnVideos = New System.Windows.Forms.Button()
        Me.btnGames = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPorn
        '
        Me.btnPorn.Location = New System.Drawing.Point(495, 87)
        Me.btnPorn.Name = "btnPorn"
        Me.btnPorn.Size = New System.Drawing.Size(75, 23)
        Me.btnPorn.TabIndex = 0
        Me.btnPorn.Text = "Porn"
        Me.btnPorn.UseVisualStyleBackColor = True
        '
        'btnNews
        '
        Me.btnNews.Location = New System.Drawing.Point(495, 133)
        Me.btnNews.Name = "btnNews"
        Me.btnNews.Size = New System.Drawing.Size(75, 23)
        Me.btnNews.TabIndex = 0
        Me.btnNews.Text = "News"
        Me.btnNews.UseVisualStyleBackColor = True
        '
        'btnVideos
        '
        Me.btnVideos.Location = New System.Drawing.Point(495, 191)
        Me.btnVideos.Name = "btnVideos"
        Me.btnVideos.Size = New System.Drawing.Size(75, 23)
        Me.btnVideos.TabIndex = 0
        Me.btnVideos.Text = "Videos"
        Me.btnVideos.UseVisualStyleBackColor = True
        '
        'btnGames
        '
        Me.btnGames.Location = New System.Drawing.Point(495, 243)
        Me.btnGames.Name = "btnGames"
        Me.btnGames.Size = New System.Drawing.Size(75, 23)
        Me.btnGames.TabIndex = 0
        Me.btnGames.Text = "Games"
        Me.btnGames.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.ClientSize = New System.Drawing.Size(3844, 1055)
        Me.Controls.Add(Me.btnGames)
        Me.Controls.Add(Me.btnVideos)
        Me.Controls.Add(Me.btnNews)
        Me.Controls.Add(Me.btnPorn)
        Me.Name = "frmMain"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPorn As Button
    Friend WithEvents btnNews As Button
    Friend WithEvents btnVideos As Button
    Friend WithEvents btnGames As Button
End Class
