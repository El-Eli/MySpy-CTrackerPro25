'﻿'Copyright 2010 Elliot M - Developer and security researcher.
''For educational purposes only. Do not use or reproduce without the explicit written consent from the original owner.
Public Class Loading

    Private Sub Load_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Visible = False
        Hide()
        If My.Settings.Email = "default" AndAlso My.Settings.Password = "default" Then
            Visible = False
            Hide()
            CTrackerRA.Visible = True
            CTrackerRA.Show()
            CTracker.Hide()
            CTracker.Close()
            Close()
        Else
            Visible = False
            Hide()
            CTrackerRA.Visible = False
            CTrackerRA.Hide()
            CTrackerRA.Close()
            CTracker.Show()
            Close()
        End If
    End Sub

    Private Sub LoadT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadT.Tick
        Visible = False
        Hide()
    End Sub

End Class