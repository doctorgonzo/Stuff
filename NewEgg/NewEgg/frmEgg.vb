Imports System.IO
Public Class frmEgg3
    Const WISHLIST As String = "wishlist.txt"


   Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

      If cmbCategory.SelectedIndex = 0 Then
         webMain.Navigate("http://www.newegg.com/Product/ProductList.aspx?Submit=ENE&N=100007625%20600007943%204026&IsNodeId=1&bop=And&Order=REVIEWS&PageSize=50")
         ' http://secure.newegg.com/WishList/WishCartPlus.aspx?Submit=ADDITEM2WISHLIST&Item=N82E16819103846&qty=1
         'code to add an item to wishlist. Just change the number after &Item= and the quantity after &qty=
      ElseIf cmbCategory.SelectedIndex = 1 Then
         webMain.Navigate("http://www.newegg.com/Product/ProductList.aspx?Submit=ENE&N=100007671%2050001028%20600005863%204027&IsNodeId=1&bop=And&ORder=REVIEWS&Pagesize=50")
      ElseIf cmbCategory.SelectedIndex = 2 Then
         webMain.Navigate("http://www.newegg.com/Product/ProductList.aspx?Submit=ENE&N=100007611%204027&IsNodeId=1&bop=And&ORder=REVIEWS&Pagesize=50")
      ElseIf cmbCategory.SelectedIndex = 3 Then
         webMain.Navigate("http://www.newegg.com/Product/ProductList.aspx?Submit=ENE&N=100007603%20600003274&IsNodeId=1&bop=And&ORder=REVIEWS&Pagesize=50")
      ElseIf cmbCategory.SelectedIndex = 4 Then
         webMain.Navigate("http://www.newegg.com/Product/ProductList.aspx?Submit=ENE&N=100007709%204027&IsNodeId=1&bop=And&ORder=REVIEWS&Pagesize=50")
      ElseIf cmbCategory.SelectedIndex = 5 Then
         webMain.Navigate("http://www.newegg.com/Product/ProductList.aspx?Submit=ENE&N=100007657%204026%20600014021&IsNodeId=1&bop=And&ORder=REVIEWS&Pagesize=50")
      ElseIf cmbCategory.SelectedIndex = 6 Then
         webMain.Navigate("http://www.newegg.com/Product/ProductList.aspx?Submit=ENE&N=100007589%204093&IsNodeId=1&bop=And&Order=REVIEWS&PageSize=50")
      ElseIf cmbCategory.SelectedIndex = 7 Then
         webMain.Navigate("http://www.newegg.com/Product/ProductList.aspx?Submit=ENE&N=100008609%204025&IsNodeId=1&bop=And&ORder=REVIEWS&Pagesize=50")
      ElseIf cmbCategory.SelectedIndex = 8 Then
         webMain.Navigate("http://www.newegg.com/Product/ProductList.aspx?Submit=ENE&N=100008000%204024&IsNodeId=1&bop=And&ORder=REVIEWS&Pagesize=50")
      ElseIf cmbCategory.SelectedIndex = 9 Then
         webMain.Navigate("http://www.newegg.com/Product/ProductList.aspx?Submit=ENE&N=100007998%204024&IsNodeId=1&bop=And&ORder=REVIEWS&Pagesize=50")
      ElseIf cmbCategory.SelectedIndex = 10 Then
         webMain.Navigate("http://www.newegg.com/Product/ProductList.aspx?Submit=ENE&N=100007617%204017&IsNodeId=1&bop=And&ORder=REVIEWS&Pagesize=50")
      End If
   End Sub

   Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      cmbCategory.Items.Add("Motherboards")
      cmbCategory.Items.Add("Processors")
      cmbCategory.Items.Add("RAM")
      cmbCategory.Items.Add("Hard Drives")
      cmbCategory.Items.Add("Video Cards")
      cmbCategory.Items.Add("Power Supplies")
      cmbCategory.Items.Add("CD/DVD Burners")
      cmbCategory.Items.Add("Blu-Ray Drives")
      cmbCategory.Items.Add("CPU Fans/Heatsinks")
      cmbCategory.Items.Add("Case Fans")
      cmbCategory.Items.Add("Monitors")
      
   End Sub

   Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
      webMain.Navigate("http://www.newegg.com")
      cmbCategory.Focus()
   End Sub

   Private Sub btnEstimates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstimates.Click
        frmEstimates.Show()
   End Sub

   Private Sub btnSaveToWishlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveToWishlist.Click

      Dim readWish As StreamReader
      Dim writeToWish As StreamWriter
      Dim url As String

      Dim locEqual As Integer
      Dim desc As String
      Dim locDesc As Integer
      Dim strLength As Integer
      Dim index As Integer
      Dim itemLength As Integer

      url = webMain.Url.ToString
      locEqual = url.IndexOf("=")
        wishlistName = InputBox("Enter Wishlist Name", "Wishlist Creator") & ".html"
      If Not File.Exists("wishlists.txt") Then
         File.CreateText("wishlists.txt")
         readWish = File.OpenText("wishlists.txt")
      Else
         readWish = File.OpenText("wishlists.txt")
      End If
      If readWish.ReadToEnd.Contains(wishlistName) Then
         readWish.Close()
      Else
         readWish.Close()
         writeToWish = File.AppendText("wishlists.txt")
         writeToWish.WriteLine(wishlistName)
         writeToWish.Close()
      End If
      locDesc = webMain.DocumentText.IndexOf("<title>")
      index = webMain.DocumentText.IndexOf("</title>")
      strLength = index - (locDesc + 8)
      desc = webMain.DocumentText.Substring(locDesc + 8, strLength)
      itemLength = (url.Count) - (locEqual + 1)
      itemNum = url.Substring(locEqual + 1, itemLength)
      writeToWish = File.AppendText(wishlistName)
      writeToWish.WriteLine("<br>" & "<a href=" & url & ">" & desc & "</a>" & " - Item Number: " & itemNum & "<br>" & ControlChars.NewLine)
      writeToWish.Close()

      Dim price As String
      Dim priceURL As String
      priceURL = "http://m.newegg.com/Product/Product.aspx?Item=" & itemNum
      Dim priceWriter As StreamWriter
      Dim priceReader As StreamReader
      Dim priceStart As Integer
        Dim priceEnd As Integer
        webMain.Navigate(priceURL)
        priceStart = webMain.DocumentText.IndexOf("Price:")
        priceEnd = webMain.DocumentText.IndexOf("Price:") + 14
        price = webMain.DocumentText.Substring(priceStart, 30)
        priceWriter = File.AppendText("prices.txt")
        priceWriter.WriteLine(price)
        priceWriter.Close()


   End Sub
End Class
