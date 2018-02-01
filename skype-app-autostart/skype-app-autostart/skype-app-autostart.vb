Imports System.IO
Imports System.Text
Public Class Form1
    ' they are two possible Startup Folders in Windows.
    Dim path1 As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Start Menu\Programs\Startup\skype-app.cmd"
    Dim added1 As Boolean = False
    Dim path2 As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\skype-app.cmd"
    Dim added2 As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' check if there is already a startup file for skype
        If File.Exists(path1) Then
            added1 = True
            Button1.Enabled = False
            Button2.Enabled = True
            Button4.Visible = True
            MsgBox("You already have a skype-app.cmd - Please delete it before you create a new one")
        End If
        If File.Exists(path2) Then
            added2 = True
            Button1.Enabled = False
            Button2.Enabled = True
            Button4.Visible = True
            MsgBox("You already have a skype-app.cmd - Please delete it before you create a new one")
        End If
    End Sub
    Private Sub AddStartup(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Create or overwrite .cmd file.
            Dim fs As FileStream = File.Create(path1)

            ' Add command to .cmd file
            Dim cmdcontent As Byte() = New UTF8Encoding(True).GetBytes("start Skype:")
            fs.Write(cmdcontent, 0, cmdcontent.Length)
            fs.Close()
            added1 = True
            MsgBox("Skype added to the startup! Please use the *Test it* button and see what happens")
            Button2.Enabled = True
            Button1.Enabled = False
        Catch ex As Exception
            Try
                ' Create or overwrite .cmd file.
                Dim fs As FileStream = File.Create(path2)

                ' Add command to .cmd file
                Dim cmdcontent As Byte() = New UTF8Encoding(True).GetBytes("start Skype:")
                fs.Write(cmdcontent, 0, cmdcontent.Length)
                fs.Close()
                added2 = True
                MsgBox("Skype added to the startup! Please use the *Test it* button and see what happens")
                Button2.Enabled = True
                Button1.Enabled = False
            Catch ex1 As Exception
                MsgBox("Can't add skype to the startup. Please try it again as an admin. That should work.")
            End Try
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("https://github.com/MarcoPNS/skype-app-autostart#faq")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://twitter.com/marcosadowski")
    End Sub

    Private Sub TestStartup(sender As Object, e As EventArgs) Handles Button2.Click
        'Test .cmd
        MsgBox("On the first startup maybe you will be ask which program should start as a default application. Just check the Skype Windows 10 App and mark the box so that Windows should remember your decision.")
        If added1 = True Then Process.Start(path1)
        If added2 = True Then Process.Start(path2)
        Label2.Text = "Still need help? Press on the *?* -->"
        Button2.Enabled = False
        Button4.Visible = True
    End Sub

    Private Sub DeleteStartup(sender As Object, e As EventArgs) Handles Button4.Click
        If added1 = True Then
            Try
                File.Delete(path1)
                MsgBox("File deleted! " & path1)
                Button4.Visible = False
                Button1.Enabled = True
                Button2.Enabled = False
            Catch ex As Exception
                MsgBox("Can't delete the file! Please try it yourself. You can find the file here: " & path1)
            End Try
        End If
        If added2 = True Then
            Try
                File.Delete(path2)
                MsgBox("File deleted! " & path2)
                Button4.Visible = False
                Button1.Enabled = True
                Button2.Enabled = False
            Catch ex As Exception
                MsgBox("Can't delete the file! Please try it yourself. You can find the file here: " & path2)
            End Try
        End If
    End Sub
End Class
