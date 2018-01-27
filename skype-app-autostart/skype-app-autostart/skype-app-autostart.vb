Imports System.IO
Imports System.Text
Public Class Form1
    Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Start Menu\Programs\Startup\skype-app.cmd"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Start Menu\Programs\Startup\skype-app.cmd")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Create or overwrite .cmd file.
            Dim fs As FileStream = File.Create(path)

            ' Add command to .cmd file
            Dim cmdcontent As Byte() = New UTF8Encoding(True).GetBytes("start Skype:")
            fs.Write(cmdcontent, 0, cmdcontent.Length)
            fs.Close()
            MsgBox("Skype added to the startup! Please use the *Test it* button and see what happens")
            Button2.Enabled = True
            Button1.Enabled = False
        Catch ex As Exception
            MsgBox("Can't add skype to the startup. Please try it again as an admin. That should work.")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("https://github.com/MarcoPNS/skype-app-autostart#faq")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://twitter.com/marcosadowski")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Test .cmd
        MsgBox("On the first startup maybe you will be ask which program should start as a default application. Just check the Skype Windows 10 App and mark the box so that Windows should remember your decision.")
        Process.Start(path)
        Label2.Text = "Still need help? Press on the *?* -->"
        Button2.Enabled = False
    End Sub
End Class
