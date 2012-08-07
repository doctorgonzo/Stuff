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
        Me.btnBoosh = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBoosh
        '
        Me.btnBoosh.Location = New System.Drawing.Point(251, 223)
        Me.btnBoosh.Name = "btnBoosh"
        Me.btnBoosh.Size = New System.Drawing.Size(118, 50)
        Me.btnBoosh.TabIndex = 0
        Me.btnBoosh.Text = "DO NOT CLICK ME"
        Me.btnBoosh.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 497)
        Me.Controls.Add(Me.btnBoosh)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SPAM SPAM SPAM"
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents btnBoosh As System.Windows.Forms.Button

End Class
