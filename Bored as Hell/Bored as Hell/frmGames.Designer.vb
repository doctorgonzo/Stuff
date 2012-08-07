<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGames
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
        Me.webGames = New System.Windows.Forms.WebBrowser()
        Me.btnAgain = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'webGames
        '
        Me.webGames.Location = New System.Drawing.Point(12, 39)
        Me.webGames.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webGames.Name = "webGames"
        Me.webGames.ScriptErrorsSuppressed = True
        Me.webGames.Size = New System.Drawing.Size(1340, 672)
        Me.webGames.TabIndex = 0
        Me.webGames.Url = New System.Uri("http://www.addictinggames.com", System.UriKind.Absolute)
        '
        'btnAgain
        '
        Me.btnAgain.Location = New System.Drawing.Point(1222, 10)
        Me.btnAgain.Name = "btnAgain"
        Me.btnAgain.Size = New System.Drawing.Size(130, 23)
        Me.btnAgain.TabIndex = 1
        Me.btnAgain.Text = "These suck, try again!"
        Me.btnAgain.UseVisualStyleBackColor = True
        '
        'frmGames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 723)
        Me.Controls.Add(Me.btnAgain)
        Me.Controls.Add(Me.webGames)
        Me.Name = "frmGames"
        Me.Text = "Some games to kill the time"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents webGames As System.Windows.Forms.WebBrowser
    Friend WithEvents btnAgain As System.Windows.Forms.Button
End Class
