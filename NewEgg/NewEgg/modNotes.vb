Module modNotes
   'ToDo:
   '
   'Change Estimates form setup from dropdown box to Groupbox with Checkoxes. This way you can have random or preselected wishlists
    'show up. Also, I need to add in the item costs and totals/totals with shipping to the Estimates form. Need to use NewEgg mobile
    'site in order to grab prices as actual prices, not variables (Credit to Peter for discovering this)
   '
   '
   '
   '
   '
   '
   '
   'Custom window graphics?
   '
   'Custom window animations for estimates?
   '
   'Any possible commercial application? ***This item may not belong here....***
   '
   '
   '
   '
   '
   '###Change Log: 12/08/2010(12:57AM) - Day one of programming. Got a basic layout for the main form and slapped on some fairly rough code to provide a 
   'proof-of-concept.
   '###12/08/2010(2:32PM) - Removed All of 'Em option. Added Save to Wishlist button. Added frmEstimates to handle display of program-generated estimates. 
   'Added a wishlist form.
   'Added a module to hold global variables.
   '###01/19/2011(5:12PM) - Added the ability to create and save custom wishlists formatted in HTML.
   '###01/21/2011(2:51AM) - Fixed wishlists so custom HTML file shows Item Description as a hyperlink instead of a raw URL. Saving to wishlist now also 
   'captures just the Item Number from the URL...don't know what I'm doing with it just yet but it must be handy for something.
   '###01/23/2011(12:55AM) - WOW! Made some serious progress today. Not sure I'll be able to list every little detail.
   'Fixed the Generate Wishlists button so it is actually functional now. When clicked, it opens a new form that allows the
   'user to select a previously saved wishlist from a dropdown box(see Notes above), when you click the button the program
   'shows you the selected wishlist in Tab 1, and a random wishlist in Tabs 2 and 3.
End Module
