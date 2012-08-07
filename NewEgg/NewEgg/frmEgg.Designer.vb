<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEgg3
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.webMain = New System.Windows.Forms.WebBrowser()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.btnEstimates = New System.Windows.Forms.Button()
        Me.btnSaveToWishlist = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(151, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(55, 23)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'webMain
        '
        Me.webMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webMain.Location = New System.Drawing.Point(12, 39)
        Me.webMain.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webMain.Name = "webMain"
        Me.webMain.Size = New System.Drawing.Size(1089, 577)
        Me.webMain.TabIndex = 2
        Me.webMain.Url = New System.Uri("http://www.newegg.com", System.UriKind.Absolute)
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(466, 10)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(55, 23)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(12, 12)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(121, 21)
        Me.cmbCategory.TabIndex = 1
        '
        'btnEstimates
        '
        Me.btnEstimates.Location = New System.Drawing.Point(345, 10)
        Me.btnEstimates.Name = "btnEstimates"
        Me.btnEstimates.Size = New System.Drawing.Size(115, 23)
        Me.btnEstimates.TabIndex = 0
        Me.btnEstimates.Text = "Generate Estimates"
        Me.btnEstimates.UseVisualStyleBackColor = True
        '
        'btnSaveToWishlist
        '
        Me.btnSaveToWishlist.Location = New System.Drawing.Point(224, 10)
        Me.btnSaveToWishlist.Name = "btnSaveToWishlist"
        Me.btnSaveToWishlist.Size = New System.Drawing.Size(115, 23)
        Me.btnSaveToWishlist.TabIndex = 0
        Me.btnSaveToWishlist.Text = "Save to Wishlist"
        Me.btnSaveToWishlist.UseVisualStyleBackColor = True
        '
        'frmEgg3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 620)
        Me.Controls.Add(Me.webMain)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.btnSaveToWishlist)
        Me.Controls.Add(Me.btnEstimates)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "frmEgg3"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents btnSearch As System.Windows.Forms.Button
   Friend WithEvents webMain As System.Windows.Forms.WebBrowser
   Friend WithEvents btnHome As System.Windows.Forms.Button
   Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
   Friend WithEvents btnEstimates As System.Windows.Forms.Button
   Friend WithEvents btnSaveToWishlist As System.Windows.Forms.Button

End Class
