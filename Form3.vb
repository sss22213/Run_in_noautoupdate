Imports System.IO

Public Class Form3

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label3.Text = "授權給" + " " + Environ("UserName")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://funnyworker.twbbs.org")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim a1 As New FileInfo("C:\BR\system\CHANGLOG.txt")
        Dim a2 As StreamReader = a1.OpenText

        a2.ReadLine()
        MsgBox(a2.ReadToEnd())
        a2.Close()
    End Sub
End Class