<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWishlist
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
      Me.cmbWishlists = New System.Windows.Forms.ComboBox()
      Me.lblWishlists = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'cmbWishlists
      '
      Me.cmbWishlists.FormattingEnabled = True
      Me.cmbWishlists.Location = New System.Drawing.Point(13, 13)
      Me.cmbWishlists.Name = "cmbWishlists"
      Me.cmbWishlists.Size = New System.Drawing.Size(121, 21)
      Me.cmbWishlists.TabIndex = 0
      '
      'lblWishlists
      '
      Me.lblWishlists.AutoSize = True
      Me.lblWishlists.Location = New System.Drawing.Point(141, 20)
      Me.lblWishlists.Name = "lblWishlists"
      Me.lblWishlists.Size = New System.Drawing.Size(39, 13)
      Me.lblWishlists.TabIndex = 1
      Me.lblWishlists.Text = "Label1"
      '
      'frmWishlist
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(518, 284)
      Me.Controls.Add(Me.lblWishlists)
      Me.Controls.Add(Me.cmbWishlists)
      Me.Name = "frmWishlist"
      Me.Text = "Wishlist"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents cmbWishlists As System.Windows.Forms.ComboBox
   Friend WithEvents lblWishlists As System.Windows.Forms.Label
End Class
