Imports System.IO

Public Class Form5

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim f1 As New FileInfo("C:\BR\system\set\" + TextBox1.Text + ".txt")
        Dim f2 As StreamWriter = f1.CreateText
        f2.WriteLine(TextBox2.Text)
        f2.WriteLine(TextBox3.Text)
        f2.WriteLine(TextBox4.Text)
        f2.Close()
        Me.Hide()
    End Sub

    Private Sub Form5_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class