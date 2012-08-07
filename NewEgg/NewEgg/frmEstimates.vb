Imports System.IO
Public Class frmEstimates
    Private locwishlists As Integer
    Private endwishlist As Integer
    Private list As New List(Of String)


    Private Sub btnGenerateEstimates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateEstimates.Click

        Dim Files() As String = IO.Directory.GetFiles(Directory.GetCurrentDirectory, "*.html", IO.SearchOption.TopDirectoryOnly)
        Dim File As String = Files((New Random).Next(0, Files.Length))
        Dim File2 As String = Files((New Random).Next(1, Files.Length))

        WebBrowser1.Navigate("file://" & cmbWishlists.SelectedItem.ToString)
        WebBrowser2.Navigate("file://" & File)
        WebBrowser3.Navigate("file://" & File2)
    End Sub

    Private Sub frmEstimates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        For Each File As String In
           My.Computer.FileSystem.GetFiles(Application.StartupPath, FileIO.SearchOption.SearchTopLevelOnly, "*.html")
            cmbWishlists.Items.Add(File)
            list.Add(File)
        Next
      


   End Sub
End Class