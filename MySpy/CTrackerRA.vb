'﻿'Copyright 2010 Elliot M - Developer and security researcher.
''For educational purposes only. Do not use or reproduce without the explicit written consent from the original owner.

Imports System.Net.Mail
Imports System.IO


Public Class CTrackerRA

    Dim o1 As String = Environment.UserName.ToString
    Dim o2 As String = System.Net.Dns.GetHostName
    Dim o3 As String = My.Computer.Info.OSFullName.ToString
    Dim o4 As String = My.Computer.Info.OSPlatform.ToString
    Dim o5 As String = My.Computer.Info.InstalledUICulture.ToString
    Dim o6 As String = Environment.ProcessorCount.ToString
    Dim o7 As String

    Private Sub CTrackerRA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EmailTxt.CharacterCasing = CharacterCasing.Lower
        IdTxt.CharacterCasing = CharacterCasing.Upper
        PNTxt1.CharacterCasing = CharacterCasing.Upper
        PNTxt2.CharacterCasing = CharacterCasing.Upper
        PNTxt3.CharacterCasing = CharacterCasing.Upper
        PNTxt4.CharacterCasing = CharacterCasing.Upper
        PNTxt5.CharacterCasing = CharacterCasing.Upper
        Try
            Dim WAN1 As New System.Net.WebClient
            o7 = System.Text.Encoding.ASCII.GetString((WAN1.DownloadData("http://www.futuretechnologiespr.com/services/ipaddress.php")))
            WAN1.Dispose()
        Catch ex As Exception
            o7 = "SERVICE UNAVAILABLE"
        End Try
    End Sub

    Private Sub RegisterBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterBtn.Click
        If FNameTxt.Text = "first name" Or LNameTxt.Text = "last name" Or EmailTxt.Text = "username" Or PasswordTxt.Text = "password" Or IdTxt.Text = "PRODUCT ID" Or PNTxt1.Text = "KEY 1" Or PNTxt2.Text = "KEY 2" Or PNTxt3.Text = "KEY 3" Or PNTxt4.Text = "KEY 4" Or PNTxt5.Text = "KEY 5" Then
            MsgBox("Verify your information.")
        Else
            Dim o8 As String = PNTxt3.Text
            Dim a1, b1, c1, d1, e1, f1, g1, h1, i1, j1 As String
            Dim text As String
            a1 = "X"
            b1 = "L"
            c1 = "P"
            d1 = "W"
            e1 = "Q"
            f1 = "N"
            g1 = "B"
            h1 = "Z"
            i1 = "U"
            j1 = "T"
            text = o8
            text = Replace(text, a1, "0")
            text = Replace(text, b1, "1")
            text = Replace(text, c1, "2")
            text = Replace(text, d1, "3")
            text = Replace(text, e1, "4")
            text = Replace(text, f1, "5")
            text = Replace(text, g1, "6")
            text = Replace(text, h1, "7")
            text = Replace(text, i1, "8")
            text = Replace(text, j1, "9")
            o8 = text
            If EmailTxt.Text.Contains("@gmail.com") AndAlso IdTxt.Text.EndsWith("AB") AndAlso o8 < "455555" Then
                Dim Writer1 As StreamWriter = New StreamWriter("data_000")
                Writer1.WriteLine("First Name: " + FNameTxt.Text)
                Writer1.WriteLine("Last Name: " + LNameTxt.Text)
                Writer1.WriteLine("E-mail Address: " + EmailTxt.Text)
                Writer1.WriteLine("Product ID: " + IdTxt.Text)
                Writer1.WriteLine("Product Key: " + PNTxt1.Text + "-" + PNTxt2.Text + "-" + PNTxt3.Text + "-" + PNTxt4.Text + "-" + PNTxt5.Text)
                Writer1.WriteLine("Account Name: " + o1)
                Writer1.WriteLine("Computer Name: " + o2)
                Writer1.WriteLine("OS Name: " + o3)
                Writer1.WriteLine("OS Platform: " + o4)
                Writer1.WriteLine("IP Address: " + o7)
                Writer1.Close()
                Try
                    My.Settings.Email = EmailTxt.Text
                    My.Settings.Password = PasswordTxt.Text
                    My.Settings.IDNumber = IdTxt.Text
                    My.Settings.Key1 = PNTxt1.Text
                    My.Settings.Key2 = PNTxt2.Text
                    My.Settings.Key3 = PNTxt3.Text
                    My.Settings.Key4 = PNTxt4.Text
                    My.Settings.Key5 = PNTxt5.Text
                    My.Settings.Save()
                    RegisterBtn.Visible = False
                    FNameTxt.ReadOnly = True
                    LNameTxt.ReadOnly = True
                    EmailTxt.ReadOnly = True
                    PasswordTxt.ReadOnly = True
                    IdTxt.ReadOnly = True
                    PNTxt1.ReadOnly = True
                    PNTxt2.ReadOnly = True
                    PNTxt3.ReadOnly = True
                    PNTxt4.ReadOnly = True
                    PNTxt5.ReadOnly = True
                Catch ex As Exception
                    PasswordTxt.Focus()
                    MsgBox("Verify your information.")
                End Try
            Else
                EmailTxt.Focus()
                MsgBox("Verify your information.")
            End If
        End If
    End Sub

    Private Sub ResBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResBtn.Click
        If RegisterBtn.Visible = False Then
            ResBtn.Visible = False
            Process.Start("shutdown", "-r -t 00")
        Else
            MsgBox("Verify your information.")
        End If
    End Sub

    Private Sub AboBtn_Click(sender As Object, e As EventArgs) Handles AboBtn.Click
        MsgBox("CTracker Pro 2.5.5. © Copyright 2014 EMG Future Technologies Inc. For more information go to www.ftpr.net.")
    End Sub

    Private Sub ExitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitBtn.Click
        Loading.Close()
        CTracker.Close()
        Close()
    End Sub

    Private Sub BlockT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlockT.Tick
        Visible = False
        Hide()
    End Sub

End Class