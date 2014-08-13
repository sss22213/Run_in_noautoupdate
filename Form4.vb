Imports System.IO

Public Class Form4

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form5.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If Not TextBox1.Text = "" Then
            Dim a1 As New FileInfo("C:\BR\system\origan.txt")
            Dim a2 As StreamWriter = a1.CreateText
            a2.WriteLine(TextBox1.Text)
            a2.Close()
            MsgBox("設定將於下一次生效")
            Me.Hide()
            Form1.Close()
            Form1.Show()
        Else
            MsgBox("設定檔來源錯誤")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Form4_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Process.GetCurrentProcess.Kill()
    End Sub

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Form1.Hide()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        'Dim a1 As New FileInfo("C:\BR\system\origan.txt")
        'Dim a2 As StreamWriter = a1.CreateText
        'a2.WriteLine("0")
        'a2.Close()
        Form1.Show()
        Me.Hide()
    End Sub
End Class