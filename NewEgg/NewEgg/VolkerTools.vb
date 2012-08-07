Module VolkerTools
   Public UserId As Integer = 12121


   Private rand As New Random
   Public Const crLf As String = ControlChars.NewLine
   Public Const crLf2 As String = crLf & crLf

   Public Function GetRandom(ByVal min As Integer, ByVal max As Integer) As Integer

      Return rand.Next(max - min + 1) + min

   End Function

   Public Function vProperCase(ByVal orgString As String) As String
      Dim delimiters As String = " ,.-"                     'Word separators
      'Don't capitalize these
      Dim exceptions() As String = {"the", "a", "of", "in", "and", "or", "as"}
      Dim special() As String = {"Mac", "Mc", "O'"}         'Capitalize again after these

      Dim word As String      'One word from the string
      Dim onechar As String   'One character from the word
      Dim element As String   'One element of the above string arrays
      Dim foundit As Boolean  'Did we find it in the array?
      Dim c As Integer        'Character counter

      Dim newString As String = "" 'Proper case version of the string
      Dim len As Integer = orgString.Length

      'Capitalize the first character regardless
      If len > 0 Then
         onechar = orgString.Substring(0, 1)
         orgString = orgString.Remove(0, 1)
         orgString = orgString.Insert(0, onechar.ToUpper)
      End If

      Do While c < len
         'Extract the next word
         word = ""
         Do While c < len AndAlso delimiters.IndexOf(orgString.Substring(c, 1)) = -1
            word &= orgString.Substring(c, 1)
            c += 1
         Loop

         If word <> "" Then 'might be two delimiters together (comma, space)
            'See if the word is an exception
            foundit = False
            For Each element In exceptions
               If element = word Then
                  foundit = True
                  'If the word is "a" followed by a ".", it's an initial--capitalize it
                  If word = "a" AndAlso c < len AndAlso orgString.Substring(c, 1) = "." Then foundit = False
               End If
            Next element 'exception

            If Not foundit Then
               'Capitalize the first letter
               'Don't use vbProperCase--it lowercases everything first (leave user's original capitalization)
               onechar = word.Chars(0)
               word = word.Remove(0, 1)
               word = word.Insert(0, onechar.ToUpper)

               'See if starts with a special sequence
               For Each element In special            'If checking a partial string, make sure there are characters after the special text
                  If word.StartsWith(element) AndAlso word <> element Then
                     'Capitalize the character after the the special text too
                     If (word.Length > element.Length) Then  'If there no letters after the Mac, Mc, O', then skip this code
                        onechar = word.Chars(element.Length)
                        word = word.Remove(element.Length, 1)
                        word = word.Insert(element.Length, onechar.ToUpper)
                     End If

                  End If
               Next
            End If

            'Add the word to the new string
            newString &= word
         End If

         'Add the delimiter to the new string
         If c < len Then
            newString &= orgString.Substring(c, 1)
            'Skip the delimiter
            c += 1
         End If
      Loop
      Return newString
   End Function

   '*********************************************************************************************
   'Copy these as appropriate (add Handles clause)
   '*********************************************************************************************

   ''' <summary>
   '''This procedure ensures the user only enters digits, commas, ONE decimal point
   '''and a dollar sign (only at beginning) in a text box that collects currency 
   '''information.
   ''' </summary>
   Private Sub txtCurrency_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

      Dim theKey As String = e.KeyChar  'The key the user pressed
      Const BACKSP As String = ControlChars.Back  'Backspace key
      Dim txtbox As TextBox = CType(sender, TextBox)

      Select Case theKey
         Case "0" To "9"
            'Not allowed before $
            e.Handled = True 'Start off assuming key is bad
            If Not txtbox.Text.Contains("$") OrElse _
                   txtbox.SelectionStart > 0 OrElse _
                   txtbox.SelectedText.Contains("$") Then
               e.Handled = False
            End If
         Case BACKSP, ","
            'Always acceptable  (cDbl removes all commas regardless of their position
            e.Handled = False
         Case "."
            'Only allow one decimal point after $
            e.Handled = True
            If txtbox.Text.Contains("$") Then
               If Not txtbox.Text.Contains(".") AndAlso txtbox.SelectionStart > 0 OrElse _
                      txtbox.SelectedText.Contains(".") Then
                  e.Handled = False    'Key OK
               End If
            Else 'no dollar sign
               If Not txtbox.Text.Contains(".") OrElse txtbox.SelectedText.Contains(".") Then
                  e.Handled = False
               End If
            End If
         Case "$"
            'Only allow at the beginning of the field
            e.Handled = True
            If Not txtbox.Text.Contains("$") AndAlso txtbox.SelectionStart = 0 OrElse _
                   txtbox.SelectedText.Contains("$") Then
               e.Handled = False
            End If
         Case Else
            'Invalid key
            e.Handled = True
      End Select
   End Sub

   ''' <summary>
   '''This procedure ensures the user only enters digits, ONE decimal point
   '''and ONE percent sign in a text box for a percentage value.
   ''' </summary>
   Private Sub txtPercent_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

      Dim theKey As String = e.KeyChar  'The key the user pressed
      Const BACKSP As String = ControlChars.Back  'Backspace key
      Dim txtbox As TextBox = CType(sender, TextBox)

      Select Case theKey
         Case "0" To "9"
            'Only acceptable BEFORE %
            e.Handled = True        'Start off assuming key is invalid
            If Not txtbox.Text.Contains("%") OrElse _
                   txtbox.Text.Contains("%") AndAlso txtbox.SelectionStart < txtbox.Text.Length OrElse _
                   txtbox.SelectedText.Contains("%") Then
               e.Handled = False
            End If
         Case BACKSP
            'Always allowed
            e.Handled = False
         Case "."
            'Only allow one decimal point and must be before %
            e.Handled = True
            If txtbox.Text.Contains("%") Then
               If Not txtbox.Text.Contains(".") AndAlso txtbox.SelectionStart < txtbox.Text.Length OrElse _
                      txtbox.SelectedText.Contains(".") Then
                  e.Handled = False
               End If
            Else 'No %
               If Not txtbox.Text.Contains(".") OrElse txtbox.SelectedText.Contains(".") Then
                  e.Handled = False
               End If
            End If

         Case "%"
            'Only allow one percent sign at the end
            e.Handled = True
            If Not txtbox.Text.Contains("%") AndAlso txtbox.SelectionStart = txtbox.Text.Length OrElse _
               txtbox.SelectedText.Contains("%") Then
               e.Handled = False
            End If
         Case Else
            'Invalid key
            e.Handled = True
      End Select
   End Sub

   ''' <summary>
   ''' This procedure ensures the user only enters digits, commas, and ONE decimal point
   '''  in a text box that collects a decimal value.
   ''' </summary>
   Private Sub txtDecimal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
      Dim theKey As String = e.KeyChar  'The key the user pressed
      Const BACKSP As String = ControlChars.Back  'Backspace key
      Dim txtbox As TextBox = CType(sender, TextBox)

      Select Case theKey
         Case "0" To "9", BACKSP, ","
            'Always acceptable  (cDbl removes all commas regardless of their position
            e.Handled = False
         Case "."
            'Only allow one decimal point 
            e.Handled = True
            If Not txtbox.Text.Contains(".") OrElse txtbox.SelectedText.Contains(".") Then
               e.Handled = False
            End If
         Case Else
            'Invalid key
            e.Handled = True
      End Select

   End Sub
End Module
