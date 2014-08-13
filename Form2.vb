Imports System.IO

Public Class Form2

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
        TextBox1.Text = OpenFileDialog1.FileName
        RadioButton1.Checked = False
        RadioButton4.Checked = False
        RadioButton3.Checked = False
        RadioButton5.Checked = False
        RadioButton2.Checked = True

    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        OpenFileDialog1.Filter = "音樂檔(*.wav|*.wav|音樂檔(*.wav*)|*.wav*"
        '
        Dim s1 As New FileInfo("C:\BR\system\URL.txt")
        Dim s2 As StreamReader = s1.OpenText
        Dim s3 As String = s2.ReadLine
        '
        Dim a1 As New FileInfo("C:\BR\system\image.txt")
        Dim a2 As StreamReader = a1.OpenText
        Dim a3 As Integer = a2.ReadLine()
        If a3 = 1 Then
            RadioButton1.Checked = True
        ElseIf a3 = 2 Then
            RadioButton2.Checked = True
            TextBox1.Text = s3
        ElseIf a3 = 3 Then
            RadioButton3.Checked = True
        ElseIf a3 = 4 Then
            RadioButton4.Checked = True
        ElseIf a3 = 5 Then
            RadioButton5.Checked = True
        End If
        s2.Close()
        a2.Close()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim d1 As New FileInfo("C:\BR\system\image.txt")
        Dim d2 As StreamWriter = d1.CreateText

        If RadioButton2.Checked = True Then
            Dim a1 As New FileInfo("C:\BR\system\URL.txt")
            Dim a2 As StreamWriter = a1.CreateText
            a2.WriteLine(TextBox1.Text)
            a2.Close()
            d2.WriteLine("2")
            Me.Hide()

        ElseIf RadioButton1.Checked = True Then
            Dim a1 As New FileInfo("C:\BR\system\URL.txt")
            Dim a2 As StreamWriter = a1.CreateText
            a2.WriteLine("C:\BR\BR.wav")
            a2.Close()
            d2.WriteLine("1")
            Me.Hide()

        ElseIf RadioButton3.Checked = True Then
            Dim a11 As New FileInfo("C:\BR\system\URL.txt")
            Dim a21 As StreamWriter = a11.CreateText
            a21.WriteLine("C:\BR\pink.wav")
            a21.Close()
            d2.WriteLine("3")
            Me.Hide()
        ElseIf RadioButton4.Checked = True Then
            Dim a11 As New FileInfo("C:\BR\system\URL.txt")
            Dim a21 As StreamWriter = a11.CreateText
            a21.WriteLine("C:\BR\white.wav")
            a21.Close()
            d2.WriteLine("4")
            Me.Hide()
        ElseIf RadioButton5.Checked = True Then
            Dim a11 As New FileInfo("C:\BR\system\URL.txt")
            Dim a21 As StreamWriter = a11.CreateText
            a21.WriteLine("C:\BR\scan_f.wav")
            a21.Close()
            d2.WriteLine("5")
            Me.Hide()
        End If
        d2.Close()
    End Sub
End Class