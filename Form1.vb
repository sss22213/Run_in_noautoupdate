Imports System.Media
Imports System.IO
Imports System.Threading
Imports System.Net
Imports System.Text

Public Class Form1

    Dim a3 As Integer = 10
    Dim a2 As Integer = 0
    Dim a1 As Integer = 0


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Not TextBox2.Text = "" And Not TextBox4.Text = "" And Not TextBox3.Text = "" Then
            Dim s1 As New FileInfo("C:\BR\system\history.txt")
            Dim s2 As StreamWriter = s1.AppendText
            s2.WriteLine(Now + " 開始RUN IN" + " " + vbCrLf + "欲RUN IN" + TextBox2.Text + " 小時" + vbCrLf + "每" + TextBox4.Text + " 小時,休息" + TextBox3.Text + " 分鐘")
            s2.Close()
            Dim t1 As Long
            t1 = Val(TextBox4.Text) * 3600 * 1000
            Dim t2 As Long
            t2 = Val(TextBox3.Text) * 60 * 1000

            Timer1.Enabled = True
            Timer1.Interval = 1000
            Timer2.Enabled = True
            Timer2.Interval = t1

            TextBox2.ReadOnly = True
            TextBox3.ReadOnly = True
            TextBox4.ReadOnly = True
            Button1.Enabled = False
            Button1.Visible = False
            Button2.Visible = True
            Button2.Enabled = True
            BackgroundWorker1.RunWorkerAsync()
        Else
            MsgBox("資料未填妥，程式無法執行")
            Return
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        a1 = a1 + 1
        Dim hr As String = Str(a1 \ 60 \ 60) + "小時"
        Dim min As String = Str(a1 \ 60) + "分"
        Dim sec As String = Str(a1 Mod 60) + "秒"
        If (a1 \ 60) > 60 Then
            min = Str((a1 \ 60) Mod 60) + "分"
        End If

        TextBox1.Text = hr + min + sec

        If Val(TextBox2.Text * 3600) < a1 Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            My.Computer.Audio.Stop()
            Label4.Text = "RUN IN 完成"
            TextBox2.ReadOnly = False
            TextBox3.ReadOnly = False
            TextBox4.ReadOnly = False
            Button1.Enabled = True
            Button1.Text = "開始"
        End If

        
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Dim a34 As New FileInfo("C:\BR\system\URL.txt")
        Dim a35 As StreamReader = a34.OpenText
        Dim a11 As String = a35.ReadLine
        Label4.Text = "Run IN 中"
        My.Computer.Audio.Play(a11, AudioPlayMode.BackgroundLoop)
        a35.Close()

    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        'noautoupdate
      
    End Sub

    Private Sub Form1_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(500)
        Dim so1 As New FileInfo("C:\BR\system\origan.txt")
        Dim so2 As StreamReader = so1.OpenText
        Dim d1 As String = so2.ReadLine()

        If d1 = "0" Then
            so2.Close()
            Return

        Else
            Dim q1 As New FileInfo(d1)
            Dim q2 As StreamReader = q1.OpenText
            TextBox2.Text = q2.ReadLine
            TextBox4.Text = q2.ReadLine
            TextBox3.Text = q2.ReadLine
            q2.Close()
            so2.Close()
        End If

        Form.CheckForIllegalCrossThreadCalls = False
        BackgroundWorker2.RunWorkerAsync()
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
      
        Dim s1 As New FileInfo("C:\BR\system\history.txt")
        Dim s2 As StreamWriter = s1.AppendText
        s2.WriteLine(vbCrLf + Now + "休息開始")
        s2.Close()
        My.Computer.Audio.Stop()
        Label4.Text = "RUN IN 休息中"
        Dim s11 As New FileInfo("C:\BR\system\history.txt")
        Dim s21 As StreamWriter = s1.AppendText
        s21.WriteLine(Now + "RUN IN 休息中")
        s21.Close()
        Timer2.Enabled = False
        Timer3.Enabled = True
        Timer3.Interval = Val(TextBox3.Text) * 1000 * 60
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick

        Dim s1 As New FileInfo("C:\BR\system\history.txt")
        Dim s2 As StreamWriter = s1.AppendText
        s2.WriteLine(Now + "RUN IN 休息完成")
        s2.Close()
        BackgroundWorker1.RunWorkerAsync()
        Timer3.Enabled = False
        Timer2.Enabled = True

    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub 選項ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Form2.Show()

    End Sub

    Private Sub 關於ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles 關於ToolStripMenuItem1.Click
        Form3.Show()
    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub BackgroundWorker3_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork




    End Sub

    Private Sub RUNIN歷史紀錄ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RUNIN歷史紀錄ToolStripMenuItem.Click
        Dim a1 As New FileInfo("C:\BR\system\history.txt")
        Dim a2 As StreamReader = a1.OpenText
        MsgBox(a2.ReadToEnd())
        a2.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        My.Computer.Audio.Stop()
        Label4.Text = "RUN IN 停止"
        TextBox2.ReadOnly = False
        TextBox3.ReadOnly = False
        TextBox4.ReadOnly = False
        Button1.Enabled = True
        Button2.Enabled = False
        Button2.Visible = False
        Button1.Visible = True
        Button1.Text = "開始"
        TextBox1.Text = ""
        a1 = 0
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub 關於ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 關於ToolStripMenuItem.Click

    End Sub

    Private Sub 煲機音檔來源設定ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 煲機音檔來源設定ToolStripMenuItem.Click
        Form2.Show()

    End Sub

    Private Sub 選項ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles 選項ToolStripMenuItem1.Click

    End Sub

    Private Sub 設定檔管理ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 設定檔管理ToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub 關閉ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 關閉ToolStripMenuItem.Click
        Process.GetCurrentProcess.Kill()
    End Sub

    Private Sub 選項ToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub 刪除歷史紀錄ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 刪除歷史紀錄ToolStripMenuItem.Click
        Dim f11 As StreamWriter = New StreamWriter("C:\BR\system\history.txt", False)
        f11.Close()
        MsgBox("紀錄刪除成功")
    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
