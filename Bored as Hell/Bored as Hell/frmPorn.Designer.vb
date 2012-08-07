<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPorn
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
        Me.webPorn = New System.Windows.Forms.WebBrowser()
        Me.btnAgain = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'webPorn
        '
        Me.webPorn.Location = New System.Drawing.Point(12, 30)
        Me.webPorn.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webPorn.Name = "webPorn"
        Me.webPorn.ScriptErrorsSuppressed = True
        Me.webPorn.Size = New System.Drawing.Size(1340, 639)
        Me.webPorn.TabIndex = 0
        '
        'btnAgain
        '
        Me.btnAgain.Location = New System.Drawing.Point(1217, 1)
        Me.btnAgain.Name = "btnAgain"
        Me.btnAgain.Size = New System.Drawing.Size(130, 23)
        Me.btnAgain.TabIndex = 1
        Me.btnAgain.Text = "These suck, try again!"
        Me.btnAgain.UseVisualStyleBackColor = True
        '
        'frmPorn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 681)
        Me.Controls.Add(Me.btnAgain)
        Me.Controls.Add(Me.webPorn)
        Me.Name = "frmPorn"
        Me.Text = "Porn it is!"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents webPorn As System.Windows.Forms.WebBrowser
    Friend WithEvents btnAgain As System.Windows.Forms.Button
End Class
