<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNews
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
        Me.webNews = New System.Windows.Forms.WebBrowser()
        Me.btnGoogle = New System.Windows.Forms.Button()
        Me.btnArsTechnica = New System.Windows.Forms.Button()
        Me.btnBBC = New System.Windows.Forms.Button()
        Me.btnFark = New System.Windows.Forms.Button()
        Me.btnCracked = New System.Windows.Forms.Button()
        Me.btnOnion = New System.Windows.Forms.Button()
        Me.btnSTP = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'webNews
        '
        Me.webNews.Location = New System.Drawing.Point(12, 42)
        Me.webNews.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webNews.Name = "webNews"
        Me.webNews.ScriptErrorsSuppressed = True
        Me.webNews.Size = New System.Drawing.Size(1326, 644)
        Me.webNews.TabIndex = 0
        Me.webNews.Url = New System.Uri("http://www.cnn.com", System.UriKind.Absolute)
        '
        'btnGoogle
        '
        Me.btnGoogle.Location = New System.Drawing.Point(13, 12)
        Me.btnGoogle.Name = "btnGoogle"
        Me.btnGoogle.Size = New System.Drawing.Size(75, 23)
        Me.btnGoogle.TabIndex = 1
        Me.btnGoogle.Text = "Google"
        Me.btnGoogle.UseVisualStyleBackColor = True
        '
        'btnArsTechnica
        '
        Me.btnArsTechnica.Location = New System.Drawing.Point(92, 12)
        Me.btnArsTechnica.Name = "btnArsTechnica"
        Me.btnArsTechnica.Size = New System.Drawing.Size(90, 23)
        Me.btnArsTechnica.TabIndex = 2
        Me.btnArsTechnica.Text = "Ars Technica"
        Me.btnArsTechnica.UseVisualStyleBackColor = True
        '
        'btnBBC
        '
        Me.btnBBC.Location = New System.Drawing.Point(186, 12)
        Me.btnBBC.Name = "btnBBC"
        Me.btnBBC.Size = New System.Drawing.Size(75, 23)
        Me.btnBBC.TabIndex = 3
        Me.btnBBC.Text = "BBC"
        Me.btnBBC.UseVisualStyleBackColor = True
        '
        'btnFark
        '
        Me.btnFark.Location = New System.Drawing.Point(265, 12)
        Me.btnFark.Name = "btnFark"
        Me.btnFark.Size = New System.Drawing.Size(75, 23)
        Me.btnFark.TabIndex = 4
        Me.btnFark.Text = "Fark"
        Me.btnFark.UseVisualStyleBackColor = True
        '
        'btnCracked
        '
        Me.btnCracked.Location = New System.Drawing.Point(344, 12)
        Me.btnCracked.Name = "btnCracked"
        Me.btnCracked.Size = New System.Drawing.Size(75, 23)
        Me.btnCracked.TabIndex = 5
        Me.btnCracked.Text = "Cracked"
        Me.btnCracked.UseVisualStyleBackColor = True
        '
        'btnOnion
        '
        Me.btnOnion.Location = New System.Drawing.Point(423, 12)
        Me.btnOnion.Name = "btnOnion"
        Me.btnOnion.Size = New System.Drawing.Size(75, 23)
        Me.btnOnion.TabIndex = 6
        Me.btnOnion.Text = "The Onion"
        Me.btnOnion.UseVisualStyleBackColor = True
        '
        'btnSTP
        '
        Me.btnSTP.Location = New System.Drawing.Point(502, 12)
        Me.btnSTP.Name = "btnSTP"
        Me.btnSTP.Size = New System.Drawing.Size(130, 23)
        Me.btnSTP.TabIndex = 6
        Me.btnSTP.Text = "Stevens Point Journal"
        Me.btnSTP.UseVisualStyleBackColor = True
        '
        'frmNews
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 698)
        Me.Controls.Add(Me.btnSTP)
        Me.Controls.Add(Me.btnOnion)
        Me.Controls.Add(Me.btnCracked)
        Me.Controls.Add(Me.btnFark)
        Me.Controls.Add(Me.btnBBC)
        Me.Controls.Add(Me.btnArsTechnica)
        Me.Controls.Add(Me.btnGoogle)
        Me.Controls.Add(Me.webNews)
        Me.Name = "frmNews"
        Me.Text = "Time to catch up on world events?"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents webNews As System.Windows.Forms.WebBrowser
    Friend WithEvents btnGoogle As System.Windows.Forms.Button
    Friend WithEvents btnArsTechnica As System.Windows.Forms.Button
    Friend WithEvents btnBBC As System.Windows.Forms.Button
    Friend WithEvents btnFark As System.Windows.Forms.Button
    Friend WithEvents btnCracked As System.Windows.Forms.Button
    Friend WithEvents btnOnion As System.Windows.Forms.Button
    Friend WithEvents btnSTP As System.Windows.Forms.Button
End Class
